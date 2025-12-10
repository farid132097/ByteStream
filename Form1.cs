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

        byte[]   DevID = new byte[5];
        UInt32[] UpTime = new UInt32[5];
        UInt16[] Vin = new UInt16[5];
        Int16[]  ATemp = new Int16[5];
        Int16[]  DTemp = new Int16[5];
        byte[]   RH = new byte[5];

        public ByteStream()
        {
            InitializeComponent();
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
            }
            else
            {
                //set indication
            }
        }

        private void UARTPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            int available_bytes = UARTPort.BytesToRead;
            if(available_bytes > 0)
            {
                UARTPort.Read(RawDataBuff, RawDataIndex, available_bytes);
                RawDataIndex += available_bytes;
                if(RawDataIndex == 14)
                {
                    this.Invoke(new Row_Update_Rough());
                }
                
                
            }
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

        private void Row_Update(byte index)
        {
            Row_Data_Update(index);
            RawDataIndex = 0;

            if(index == 0)
            {
                l1ID.Text = Convert.ToString(DevID[index]);
                l1UT.Text = Convert.ToString(UpTime[index]);
                l1Vin.Text = Convert.ToString(Vin[index]);
                l1AT.Text = Convert.ToString(ATemp[index]);
                l1DT.Text = Convert.ToString(DTemp[index]);
                l1RH.Text = Convert.ToString(RH[index]);
            }
            else if(index == 1)
            {
                l2ID.Text = Convert.ToString(DevID[index]);
                l2UT.Text = Convert.ToString(UpTime[index]);
                l2Vin.Text = Convert.ToString(Vin[index]);
                l2AT.Text = Convert.ToString(ATemp[index]);
                l2DT.Text = Convert.ToString(DTemp[index]);
                l2RH.Text = Convert.ToString(RH[index]);
            }
            else if (index == 2)
            {
                l3ID.Text = Convert.ToString(DevID[index]);
                l3UT.Text = Convert.ToString(UpTime[index]);
                l3Vin.Text = Convert.ToString(Vin[index]);
                l3AT.Text = Convert.ToString(ATemp[index]);
                l3DT.Text = Convert.ToString(DTemp[index]);
                l3RH.Text = Convert.ToString(RH[index]);
            }
            else if (index == 3)
            {
                l4ID.Text = Convert.ToString(DevID[index]);
                l4UT.Text = Convert.ToString(UpTime[index]);
                l4Vin.Text = Convert.ToString(Vin[index]);
                l4AT.Text = Convert.ToString(ATemp[index]);
                l4DT.Text = Convert.ToString(DTemp[index]);
                l4RH.Text = Convert.ToString(RH[index]);
            }
            else if (index == 4)
            {
                l5ID.Text = Convert.ToString(DevID[index]);
                l5UT.Text = Convert.ToString(UpTime[index]);
                l5Vin.Text = Convert.ToString(Vin[index]);
                l5AT.Text = Convert.ToString(ATemp[index]);
                l5DT.Text = Convert.ToString(DTemp[index]);
                l5RH.Text = Convert.ToString(RH[index]);
            }
        }

        private void Row_Update_Rough(object sender, SerialDataReceivedEventArgs e)
        {
            Row_Update(0);
        }

    }
}
