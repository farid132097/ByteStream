namespace ByteStream
{
    partial class ByteStream
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.UARTPort = new System.IO.Ports.SerialPort(this.components);
            this.cbPorts = new System.Windows.Forms.ComboBox();
            this.lblDevID = new System.Windows.Forms.Label();
            this.lblUpTime = new System.Windows.Forms.Label();
            this.lblVin = new System.Windows.Forms.Label();
            this.lblATemp = new System.Windows.Forms.Label();
            this.lblDTemp = new System.Windows.Forms.Label();
            this.lblRH = new System.Windows.Forms.Label();
            this.l1ID = new System.Windows.Forms.Label();
            this.l1UT = new System.Windows.Forms.Label();
            this.l1Vin = new System.Windows.Forms.Label();
            this.l1AT = new System.Windows.Forms.Label();
            this.l1DT = new System.Windows.Forms.Label();
            this.l1RH = new System.Windows.Forms.Label();
            this.RxTimeout = new System.Windows.Forms.Timer(this.components);
            this.l2ID = new System.Windows.Forms.Label();
            this.l2UT = new System.Windows.Forms.Label();
            this.l3ID = new System.Windows.Forms.Label();
            this.l4ID = new System.Windows.Forms.Label();
            this.l5ID = new System.Windows.Forms.Label();
            this.l3UT = new System.Windows.Forms.Label();
            this.l4UT = new System.Windows.Forms.Label();
            this.l5UT = new System.Windows.Forms.Label();
            this.l2Vin = new System.Windows.Forms.Label();
            this.l3Vin = new System.Windows.Forms.Label();
            this.l4Vin = new System.Windows.Forms.Label();
            this.l5Vin = new System.Windows.Forms.Label();
            this.l2AT = new System.Windows.Forms.Label();
            this.l3AT = new System.Windows.Forms.Label();
            this.l4AT = new System.Windows.Forms.Label();
            this.l5AT = new System.Windows.Forms.Label();
            this.l2DT = new System.Windows.Forms.Label();
            this.l3DT = new System.Windows.Forms.Label();
            this.l4DT = new System.Windows.Forms.Label();
            this.l5DT = new System.Windows.Forms.Label();
            this.l2RH = new System.Windows.Forms.Label();
            this.l3RH = new System.Windows.Forms.Label();
            this.l4RH = new System.Windows.Forms.Label();
            this.l5RH = new System.Windows.Forms.Label();
            this.lblDbg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UARTPort
            // 
            this.UARTPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.UARTPort_DataReceived);
            // 
            // cbPorts
            // 
            this.cbPorts.AllowDrop = true;
            this.cbPorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPorts.FormattingEnabled = true;
            this.cbPorts.Location = new System.Drawing.Point(20, 21);
            this.cbPorts.Name = "cbPorts";
            this.cbPorts.Size = new System.Drawing.Size(121, 21);
            this.cbPorts.TabIndex = 0;
            this.cbPorts.SelectedIndexChanged += new System.EventHandler(this.cbPorts_SelectedIndexChanged);
            this.cbPorts.Click += new System.EventHandler(this.cbPorts_Click);
            // 
            // lblDevID
            // 
            this.lblDevID.AutoSize = true;
            this.lblDevID.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDevID.Location = new System.Drawing.Point(14, 73);
            this.lblDevID.Name = "lblDevID";
            this.lblDevID.Size = new System.Drawing.Size(43, 13);
            this.lblDevID.TabIndex = 1;
            this.lblDevID.Text = "NodeID";
            // 
            // lblUpTime
            // 
            this.lblUpTime.AutoSize = true;
            this.lblUpTime.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpTime.Location = new System.Drawing.Point(81, 73);
            this.lblUpTime.Name = "lblUpTime";
            this.lblUpTime.Size = new System.Drawing.Size(67, 13);
            this.lblUpTime.TabIndex = 2;
            this.lblUpTime.Text = "UpTime (S)";
            // 
            // lblVin
            // 
            this.lblVin.AutoSize = true;
            this.lblVin.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVin.Location = new System.Drawing.Point(173, 73);
            this.lblVin.Name = "lblVin";
            this.lblVin.Size = new System.Drawing.Size(55, 13);
            this.lblVin.TabIndex = 3;
            this.lblVin.Text = "Vin (mV)";
            // 
            // lblATemp
            // 
            this.lblATemp.AutoSize = true;
            this.lblATemp.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblATemp.Location = new System.Drawing.Point(248, 73);
            this.lblATemp.Name = "lblATemp";
            this.lblATemp.Size = new System.Drawing.Size(97, 13);
            this.lblATemp.TabIndex = 4;
            this.lblATemp.Text = "AnalogTemp (\'C)";
            // 
            // lblDTemp
            // 
            this.lblDTemp.AutoSize = true;
            this.lblDTemp.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDTemp.Location = new System.Drawing.Point(358, 73);
            this.lblDTemp.Name = "lblDTemp";
            this.lblDTemp.Size = new System.Drawing.Size(103, 13);
            this.lblDTemp.TabIndex = 5;
            this.lblDTemp.Text = "DigitalTemp (\'C)";
            // 
            // lblRH
            // 
            this.lblRH.AutoSize = true;
            this.lblRH.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRH.Location = new System.Drawing.Point(470, 73);
            this.lblRH.Name = "lblRH";
            this.lblRH.Size = new System.Drawing.Size(85, 13);
            this.lblRH.TabIndex = 6;
            this.lblRH.Text = "DigitalRH (%)";
            // 
            // l1ID
            // 
            this.l1ID.AutoSize = true;
            this.l1ID.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l1ID.Location = new System.Drawing.Point(27, 109);
            this.l1ID.Name = "l1ID";
            this.l1ID.Size = new System.Drawing.Size(14, 14);
            this.l1ID.TabIndex = 7;
            this.l1ID.Text = "-";
            // 
            // l1UT
            // 
            this.l1UT.AutoSize = true;
            this.l1UT.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l1UT.Location = new System.Drawing.Point(96, 109);
            this.l1UT.Name = "l1UT";
            this.l1UT.Size = new System.Drawing.Size(14, 14);
            this.l1UT.TabIndex = 8;
            this.l1UT.Text = "-";
            // 
            // l1Vin
            // 
            this.l1Vin.AutoSize = true;
            this.l1Vin.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l1Vin.Location = new System.Drawing.Point(184, 109);
            this.l1Vin.Name = "l1Vin";
            this.l1Vin.Size = new System.Drawing.Size(14, 14);
            this.l1Vin.TabIndex = 9;
            this.l1Vin.Text = "-";
            // 
            // l1AT
            // 
            this.l1AT.AutoSize = true;
            this.l1AT.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l1AT.Location = new System.Drawing.Point(277, 109);
            this.l1AT.Name = "l1AT";
            this.l1AT.Size = new System.Drawing.Size(14, 14);
            this.l1AT.TabIndex = 10;
            this.l1AT.Text = "-";
            // 
            // l1DT
            // 
            this.l1DT.AutoSize = true;
            this.l1DT.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l1DT.Location = new System.Drawing.Point(386, 109);
            this.l1DT.Name = "l1DT";
            this.l1DT.Size = new System.Drawing.Size(14, 14);
            this.l1DT.TabIndex = 11;
            this.l1DT.Text = "-";
            // 
            // l1RH
            // 
            this.l1RH.AutoSize = true;
            this.l1RH.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l1RH.Location = new System.Drawing.Point(492, 109);
            this.l1RH.Name = "l1RH";
            this.l1RH.Size = new System.Drawing.Size(14, 14);
            this.l1RH.TabIndex = 12;
            this.l1RH.Text = "-";
            // 
            // RxTimeout
            // 
            this.RxTimeout.Interval = 1;
            this.RxTimeout.Tick += new System.EventHandler(this.RxTimeout_Tick);
            // 
            // l2ID
            // 
            this.l2ID.AutoSize = true;
            this.l2ID.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l2ID.Location = new System.Drawing.Point(27, 136);
            this.l2ID.Name = "l2ID";
            this.l2ID.Size = new System.Drawing.Size(14, 14);
            this.l2ID.TabIndex = 13;
            this.l2ID.Text = "-";
            // 
            // l2UT
            // 
            this.l2UT.AutoSize = true;
            this.l2UT.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l2UT.Location = new System.Drawing.Point(96, 136);
            this.l2UT.Name = "l2UT";
            this.l2UT.Size = new System.Drawing.Size(14, 14);
            this.l2UT.TabIndex = 14;
            this.l2UT.Text = "-";
            // 
            // l3ID
            // 
            this.l3ID.AutoSize = true;
            this.l3ID.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l3ID.Location = new System.Drawing.Point(27, 165);
            this.l3ID.Name = "l3ID";
            this.l3ID.Size = new System.Drawing.Size(14, 14);
            this.l3ID.TabIndex = 15;
            this.l3ID.Text = "-";
            // 
            // l4ID
            // 
            this.l4ID.AutoSize = true;
            this.l4ID.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l4ID.Location = new System.Drawing.Point(27, 195);
            this.l4ID.Name = "l4ID";
            this.l4ID.Size = new System.Drawing.Size(14, 14);
            this.l4ID.TabIndex = 16;
            this.l4ID.Text = "-";
            // 
            // l5ID
            // 
            this.l5ID.AutoSize = true;
            this.l5ID.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l5ID.Location = new System.Drawing.Point(27, 224);
            this.l5ID.Name = "l5ID";
            this.l5ID.Size = new System.Drawing.Size(14, 14);
            this.l5ID.TabIndex = 17;
            this.l5ID.Text = "-";
            // 
            // l3UT
            // 
            this.l3UT.AutoSize = true;
            this.l3UT.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l3UT.Location = new System.Drawing.Point(96, 165);
            this.l3UT.Name = "l3UT";
            this.l3UT.Size = new System.Drawing.Size(14, 14);
            this.l3UT.TabIndex = 18;
            this.l3UT.Text = "-";
            // 
            // l4UT
            // 
            this.l4UT.AutoSize = true;
            this.l4UT.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l4UT.Location = new System.Drawing.Point(96, 195);
            this.l4UT.Name = "l4UT";
            this.l4UT.Size = new System.Drawing.Size(14, 14);
            this.l4UT.TabIndex = 19;
            this.l4UT.Text = "-";
            // 
            // l5UT
            // 
            this.l5UT.AutoSize = true;
            this.l5UT.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l5UT.Location = new System.Drawing.Point(96, 224);
            this.l5UT.Name = "l5UT";
            this.l5UT.Size = new System.Drawing.Size(14, 14);
            this.l5UT.TabIndex = 20;
            this.l5UT.Text = "-";
            // 
            // l2Vin
            // 
            this.l2Vin.AutoSize = true;
            this.l2Vin.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l2Vin.Location = new System.Drawing.Point(184, 136);
            this.l2Vin.Name = "l2Vin";
            this.l2Vin.Size = new System.Drawing.Size(14, 14);
            this.l2Vin.TabIndex = 21;
            this.l2Vin.Text = "-";
            // 
            // l3Vin
            // 
            this.l3Vin.AutoSize = true;
            this.l3Vin.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l3Vin.Location = new System.Drawing.Point(184, 165);
            this.l3Vin.Name = "l3Vin";
            this.l3Vin.Size = new System.Drawing.Size(14, 14);
            this.l3Vin.TabIndex = 22;
            this.l3Vin.Text = "-";
            // 
            // l4Vin
            // 
            this.l4Vin.AutoSize = true;
            this.l4Vin.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l4Vin.Location = new System.Drawing.Point(184, 195);
            this.l4Vin.Name = "l4Vin";
            this.l4Vin.Size = new System.Drawing.Size(14, 14);
            this.l4Vin.TabIndex = 23;
            this.l4Vin.Text = "-";
            // 
            // l5Vin
            // 
            this.l5Vin.AutoSize = true;
            this.l5Vin.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l5Vin.Location = new System.Drawing.Point(184, 224);
            this.l5Vin.Name = "l5Vin";
            this.l5Vin.Size = new System.Drawing.Size(14, 14);
            this.l5Vin.TabIndex = 24;
            this.l5Vin.Text = "-";
            // 
            // l2AT
            // 
            this.l2AT.AutoSize = true;
            this.l2AT.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l2AT.Location = new System.Drawing.Point(277, 136);
            this.l2AT.Name = "l2AT";
            this.l2AT.Size = new System.Drawing.Size(14, 14);
            this.l2AT.TabIndex = 25;
            this.l2AT.Text = "-";
            // 
            // l3AT
            // 
            this.l3AT.AutoSize = true;
            this.l3AT.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l3AT.Location = new System.Drawing.Point(277, 165);
            this.l3AT.Name = "l3AT";
            this.l3AT.Size = new System.Drawing.Size(14, 14);
            this.l3AT.TabIndex = 26;
            this.l3AT.Text = "-";
            // 
            // l4AT
            // 
            this.l4AT.AutoSize = true;
            this.l4AT.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l4AT.Location = new System.Drawing.Point(277, 195);
            this.l4AT.Name = "l4AT";
            this.l4AT.Size = new System.Drawing.Size(14, 14);
            this.l4AT.TabIndex = 27;
            this.l4AT.Text = "-";
            // 
            // l5AT
            // 
            this.l5AT.AutoSize = true;
            this.l5AT.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l5AT.Location = new System.Drawing.Point(277, 224);
            this.l5AT.Name = "l5AT";
            this.l5AT.Size = new System.Drawing.Size(14, 14);
            this.l5AT.TabIndex = 28;
            this.l5AT.Text = "-";
            // 
            // l2DT
            // 
            this.l2DT.AutoSize = true;
            this.l2DT.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l2DT.Location = new System.Drawing.Point(386, 136);
            this.l2DT.Name = "l2DT";
            this.l2DT.Size = new System.Drawing.Size(14, 14);
            this.l2DT.TabIndex = 29;
            this.l2DT.Text = "-";
            // 
            // l3DT
            // 
            this.l3DT.AutoSize = true;
            this.l3DT.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l3DT.Location = new System.Drawing.Point(386, 165);
            this.l3DT.Name = "l3DT";
            this.l3DT.Size = new System.Drawing.Size(14, 14);
            this.l3DT.TabIndex = 30;
            this.l3DT.Text = "-";
            // 
            // l4DT
            // 
            this.l4DT.AutoSize = true;
            this.l4DT.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l4DT.Location = new System.Drawing.Point(386, 195);
            this.l4DT.Name = "l4DT";
            this.l4DT.Size = new System.Drawing.Size(14, 14);
            this.l4DT.TabIndex = 31;
            this.l4DT.Text = "-";
            // 
            // l5DT
            // 
            this.l5DT.AutoSize = true;
            this.l5DT.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l5DT.Location = new System.Drawing.Point(386, 224);
            this.l5DT.Name = "l5DT";
            this.l5DT.Size = new System.Drawing.Size(14, 14);
            this.l5DT.TabIndex = 32;
            this.l5DT.Text = "-";
            // 
            // l2RH
            // 
            this.l2RH.AutoSize = true;
            this.l2RH.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l2RH.Location = new System.Drawing.Point(492, 136);
            this.l2RH.Name = "l2RH";
            this.l2RH.Size = new System.Drawing.Size(14, 14);
            this.l2RH.TabIndex = 33;
            this.l2RH.Text = "-";
            // 
            // l3RH
            // 
            this.l3RH.AutoSize = true;
            this.l3RH.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l3RH.Location = new System.Drawing.Point(492, 165);
            this.l3RH.Name = "l3RH";
            this.l3RH.Size = new System.Drawing.Size(14, 14);
            this.l3RH.TabIndex = 34;
            this.l3RH.Text = "-";
            // 
            // l4RH
            // 
            this.l4RH.AutoSize = true;
            this.l4RH.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l4RH.Location = new System.Drawing.Point(492, 195);
            this.l4RH.Name = "l4RH";
            this.l4RH.Size = new System.Drawing.Size(14, 14);
            this.l4RH.TabIndex = 35;
            this.l4RH.Text = "-";
            // 
            // l5RH
            // 
            this.l5RH.AutoSize = true;
            this.l5RH.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l5RH.Location = new System.Drawing.Point(492, 224);
            this.l5RH.Name = "l5RH";
            this.l5RH.Size = new System.Drawing.Size(14, 14);
            this.l5RH.TabIndex = 36;
            this.l5RH.Text = "-";
            // 
            // lblDbg
            // 
            this.lblDbg.AutoSize = true;
            this.lblDbg.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDbg.Location = new System.Drawing.Point(173, 24);
            this.lblDbg.Name = "lblDbg";
            this.lblDbg.Size = new System.Drawing.Size(0, 14);
            this.lblDbg.TabIndex = 37;
            // 
            // ByteStream
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 260);
            this.Controls.Add(this.lblDbg);
            this.Controls.Add(this.l5RH);
            this.Controls.Add(this.l4RH);
            this.Controls.Add(this.l3RH);
            this.Controls.Add(this.l2RH);
            this.Controls.Add(this.l5DT);
            this.Controls.Add(this.l4DT);
            this.Controls.Add(this.l3DT);
            this.Controls.Add(this.l2DT);
            this.Controls.Add(this.l5AT);
            this.Controls.Add(this.l4AT);
            this.Controls.Add(this.l3AT);
            this.Controls.Add(this.l2AT);
            this.Controls.Add(this.l5Vin);
            this.Controls.Add(this.l4Vin);
            this.Controls.Add(this.l3Vin);
            this.Controls.Add(this.l2Vin);
            this.Controls.Add(this.l5UT);
            this.Controls.Add(this.l4UT);
            this.Controls.Add(this.l3UT);
            this.Controls.Add(this.l5ID);
            this.Controls.Add(this.l4ID);
            this.Controls.Add(this.l3ID);
            this.Controls.Add(this.l2UT);
            this.Controls.Add(this.l2ID);
            this.Controls.Add(this.l1RH);
            this.Controls.Add(this.l1DT);
            this.Controls.Add(this.l1AT);
            this.Controls.Add(this.l1Vin);
            this.Controls.Add(this.l1UT);
            this.Controls.Add(this.l1ID);
            this.Controls.Add(this.lblRH);
            this.Controls.Add(this.lblDTemp);
            this.Controls.Add(this.lblATemp);
            this.Controls.Add(this.lblVin);
            this.Controls.Add(this.lblUpTime);
            this.Controls.Add(this.lblDevID);
            this.Controls.Add(this.cbPorts);
            this.Name = "ByteStream";
            this.Text = "ByteStream";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort UARTPort;
        private System.Windows.Forms.ComboBox cbPorts;
        private System.Windows.Forms.Label lblDevID;
        private System.Windows.Forms.Label lblUpTime;
        private System.Windows.Forms.Label lblVin;
        private System.Windows.Forms.Label lblATemp;
        private System.Windows.Forms.Label lblDTemp;
        private System.Windows.Forms.Label lblRH;
        private System.Windows.Forms.Label l1ID;
        private System.Windows.Forms.Label l1UT;
        private System.Windows.Forms.Label l1Vin;
        private System.Windows.Forms.Label l1AT;
        private System.Windows.Forms.Label l1DT;
        private System.Windows.Forms.Label l1RH;
        private System.Windows.Forms.Timer RxTimeout;
        private System.Windows.Forms.Label l2ID;
        private System.Windows.Forms.Label l2UT;
        private System.Windows.Forms.Label l3ID;
        private System.Windows.Forms.Label l4ID;
        private System.Windows.Forms.Label l5ID;
        private System.Windows.Forms.Label l3UT;
        private System.Windows.Forms.Label l4UT;
        private System.Windows.Forms.Label l5UT;
        private System.Windows.Forms.Label l2Vin;
        private System.Windows.Forms.Label l3Vin;
        private System.Windows.Forms.Label l4Vin;
        private System.Windows.Forms.Label l5Vin;
        private System.Windows.Forms.Label l2AT;
        private System.Windows.Forms.Label l3AT;
        private System.Windows.Forms.Label l4AT;
        private System.Windows.Forms.Label l5AT;
        private System.Windows.Forms.Label l2DT;
        private System.Windows.Forms.Label l3DT;
        private System.Windows.Forms.Label l4DT;
        private System.Windows.Forms.Label l5DT;
        private System.Windows.Forms.Label l2RH;
        private System.Windows.Forms.Label l3RH;
        private System.Windows.Forms.Label l4RH;
        private System.Windows.Forms.Label l5RH;
        private System.Windows.Forms.Label lblDbg;
    }
}

