using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace ByteStream
{
    public partial class ByteStream : Form
    {
        byte[]   RawDataBuff  = new byte[1024];
        int      RawDataIndex = 0;
        byte     RowIndex = 0;
        byte     DataSaturated = 0;

        byte[]   DevID = new byte[5];
        UInt32[] UpTime = new UInt32[5];
        UInt16[] Vin = new UInt16[5];
        Int16[]  ATemp = new Int16[5];
        Int16[]  DTemp = new Int16[5];
        byte[]   RH = new byte[5];
        UInt16   TimeoutTick = 0;
        UInt16   CRCCalc = 0;
        UInt16   CRCRec = 0;
        UInt16   PacketEndEvCnt = 0;

        public ByteStream()
        {
            InitializeComponent();
        }

        private void Raw_Data_Buf_Flush()
        {
            for(UInt16 i=0; i<RawDataBuff.Length; i++)
            {
                RawDataBuff[i] = 0;
            }
            RawDataIndex = 0;
        }

        private void cbPorts_Click(object sender, EventArgs e)
        {
            if(UARTPort.IsOpen == true)
            {
                UARTPort.Close();
            }
            string[] ports = SerialPort.GetPortNames();
            cbPorts.Items.Clear();
            cbPorts.Items.AddRange(ports);
        }

        private void cbPorts_SelectedIndexChanged(object sender, EventArgs e)
        {
            UARTPort.PortName = cbPorts.SelectedItem.ToString();
            UARTPort.BaudRate = 19200;

            try
            {
                UARTPort.Open();
            }
            catch
            {
                //set workaround
            }

            if (UARTPort.IsOpen == true)
            {
                //set indication
                this.BeginInvoke((Action)Raw_Data_Buf_Flush);
                lblDbg.Text = "UART Port Opened";
                lblDbg.BackColor = Color.LightGreen;
            }
            else
            {
                //set indication
                lblDbg.Text = "UART Port Not Opened";
                lblDbg.BackColor = Color.Red;
            }
        }

        private void UARTPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            int available_bytes = UARTPort.BytesToRead;
            if( (available_bytes > 0) && (available_bytes< RawDataBuff.Length) )
            {
                UARTPort.Read(RawDataBuff, RawDataIndex, available_bytes);
                RawDataIndex += available_bytes;
                this.BeginInvoke( (Action) RxTimeout_Start );
            }
        }

        UInt16 Calcuate_CRC(UInt16 crc, byte data)
        {
            crc = (UInt16) (crc ^ ((UInt16)data << 8));
            for (byte i = 0; i < 8; i++)
            {
                if ( (crc & 0x8000) != 0)
                {
                    crc = (UInt16) ((crc << 1) ^ 0x1021);
                }
                else
                {
                    crc <<= 1;
                }
            }
            return crc;
        }


        private void Row_Data_Update(byte index)
        {
            DevID[index] = RawDataBuff[0];

            UpTime[index] = RawDataBuff[1];
            UpTime[index] <<= 8;
            UpTime[index] |= RawDataBuff[2];
            UpTime[index] <<= 8;
            UpTime[index] |= RawDataBuff[3];
            UpTime[index] <<= 8;
            UpTime[index] |= RawDataBuff[4];

            Vin[index] = RawDataBuff[5];
            Vin[index] <<= 8;
            Vin[index] |= RawDataBuff[6];

            ATemp[index] = RawDataBuff[7];
            ATemp[index] <<= 8;
            ATemp[index] |= RawDataBuff[8];

            DTemp[index] = RawDataBuff[9];
            DTemp[index] <<= 8;
            DTemp[index] |= RawDataBuff[10];

            RH[index] = RawDataBuff[11];
        }

        private void Row_Update_Fields(byte index)
        {
            Row_Data_Update(index);
            Row_Update_Texts(index);
        }

        private void Row_Copy_Fields(byte ToIndex, byte FromIndex)
        {
            DevID[ToIndex] = DevID[FromIndex];
            UpTime[ToIndex] = UpTime[FromIndex];
            Vin[ToIndex] = Vin[FromIndex];
            ATemp[ToIndex] = ATemp[FromIndex];
            DTemp[ToIndex] = DTemp[FromIndex];
            RH[ToIndex] = RH[FromIndex];
        }

        private void Row_Update_Texts(byte index)
        {
            string[] row1 = new string[6] ;
            string[] row2 = new string[6];
            string[] row3 = new string[6];
            string[] row4 = new string[6];
            string[] row5 = new string[6];

            if (index == 0)
            {
                row1[0] = Convert.ToString(DevID[index]);
                row1[1] = Convert.ToString(UpTime[index]);
                row1[2] = Convert.ToString(Vin[index]);
                row1[3] = Convert.ToString(ATemp[index] / 10);
                row1[3] += ".";
                row1[3] += Convert.ToString(ATemp[index] % 10);
                row1[4] = Convert.ToString(DTemp[index] / 10);
                row1[4] += ".";
                row1[4] += Convert.ToString(DTemp[index] % 10);
                row1[5] = Convert.ToString(RH[index]);

                l1ID.Text = row1[0];
                l1UT.Text = row1[1];
                l1Vin.Text = row1[2];
                l1AT.Text = row1[3];
                l1DT.Text = row1[4];
                l1RH.Text = row1[5];

            }
            else if (index == 1)
            {
                row2[0] = Convert.ToString(DevID[index]);
                row2[1] = Convert.ToString(UpTime[index]);
                row2[2] = Convert.ToString(Vin[index]);
                row2[3] = Convert.ToString(ATemp[index] / 10);
                row2[3] += ".";
                row2[3] += Convert.ToString(ATemp[index] % 10);
                row2[4] = Convert.ToString(DTemp[index] / 10);
                row2[4] += ".";
                row2[4] += Convert.ToString(DTemp[index] % 10);
                row2[5] = Convert.ToString(RH[index]);

                l2ID.Text = row2[0];
                l2UT.Text = row2[1];
                l2Vin.Text = row2[2];
                l2AT.Text = row2[3];
                l2DT.Text = row2[4];
                l2RH.Text = row2[5];
            }
            else if (index == 2)
            {
                row3[0] = Convert.ToString(DevID[index]);
                row3[1] = Convert.ToString(UpTime[index]);
                row3[2] = Convert.ToString(Vin[index]);
                row3[3] = Convert.ToString(ATemp[index] / 10);
                row3[3] += ".";
                row3[3] += Convert.ToString(ATemp[index] % 10);
                row3[4] = Convert.ToString(DTemp[index] / 10);
                row3[4] += ".";
                row3[4] += Convert.ToString(DTemp[index] % 10);
                row3[5] = Convert.ToString(RH[index]);

                l3ID.Text = row3[0];
                l3UT.Text = row3[1];
                l3Vin.Text = row3[2];
                l3AT.Text = row3[3];
                l3DT.Text = row3[4];
                l3RH.Text = row3[5];
            }
            else if (index == 3)
            {
                row4[0] = Convert.ToString(DevID[index]);
                row4[1] = Convert.ToString(UpTime[index]);
                row4[2] = Convert.ToString(Vin[index]);
                row4[3] = Convert.ToString(ATemp[index] / 10);
                row4[3] += ".";
                row4[3] += Convert.ToString(ATemp[index] % 10);
                row4[4] = Convert.ToString(DTemp[index] / 10);
                row4[4] += ".";
                row4[4] += Convert.ToString(DTemp[index] % 10);
                row4[5] = Convert.ToString(RH[index]);

                l4ID.Text = row4[0];
                l4UT.Text = row4[1];
                l4Vin.Text = row4[2];
                l4AT.Text = row4[3];
                l4DT.Text = row4[4];
                l4RH.Text = row4[5];
            }
            else if (index == 4)
            {
                row5[0] = Convert.ToString(DevID[index]);
                row5[1] = Convert.ToString(UpTime[index]);
                row5[2] = Convert.ToString(Vin[index]);
                row5[3] = Convert.ToString(ATemp[index] / 10);
                row5[3] += ".";
                row5[3] += Convert.ToString(ATemp[index] % 10);
                row5[4] = Convert.ToString(DTemp[index] / 10);
                row5[4] += ".";
                row5[4] += Convert.ToString(DTemp[index] % 10);
                row5[5] = Convert.ToString(RH[index]);

                l5ID.Text = row5[0];
                l5UT.Text = row5[1];
                l5Vin.Text = row5[2];
                l5AT.Text = row5[3];
                l5DT.Text = row5[4];
                l5RH.Text = row5[5];
            }
        }


        private void Row_Update_All()
        {
            if(RowIndex < 4)
            {
                Row_Update_Fields(RowIndex);
                RowIndex++;
            }
            
            else
            {
                if(DataSaturated == 0)
                {
                    Row_Update_Fields(RowIndex);
                    DataSaturated = 1;
                }
                else
                {
                    Row_Copy_Fields(0, 1);
                    Row_Copy_Fields(1, 2);
                    Row_Copy_Fields(2, 3);
                    Row_Copy_Fields(3, 4);
                    Row_Update_Texts(0);
                    Row_Update_Texts(1);
                    Row_Update_Texts(2);
                    Row_Update_Texts(3);
                    Row_Update_Fields(RowIndex);
                }
                

            }
        }

        private void Row_Update_With_Verification()
        {
            if(RawDataIndex > 2)
            {
                CRCCalc = 0;
                CRCRec = RawDataBuff[RawDataIndex - 2];
                CRCRec <<= 8;
                CRCRec |= RawDataBuff[RawDataIndex - 1];

                for (byte i=0; i< RawDataIndex-2; i++)
                {
                    CRCCalc = Calcuate_CRC(CRCCalc, RawDataBuff[i]);
                }

                if(CRCRec == CRCCalc)
                {
                    this.BeginInvoke((Action)Row_Update_All);
                }

                this.BeginInvoke((Action)Raw_Data_Buf_Flush);
            }
        }


        private void RxTimeout_Start()
        {
            TimeoutTick = 0;
            RxTimeout.Start();
        }

        private void RxTimeout_Tick(object sender, EventArgs e)
        {
            TimeoutTick++;
            
            if (TimeoutTick > 2)
            {
                RxTimeout.Stop();
                TimeoutTick = 0;
                PacketEndEvCnt++;
                this.BeginInvoke((Action)Row_Update_With_Verification);
                this.BeginInvoke((Action)Debug_Print);

            }
        }


        private void Debug_Print()
        {
            lblDbg.BackColor = Color.Transparent;
            string dbg_data = "";
            dbg_data += "[";
            dbg_data += Convert.ToString(PacketEndEvCnt);
            dbg_data += "]";

            dbg_data += "   ";

            for (byte i=0; i<14; i++)
            {
                dbg_data += RawDataBuff[i].ToString("X2");
                dbg_data += " ";
            }
            lblDbg.Text = dbg_data;
        }
    }
}
