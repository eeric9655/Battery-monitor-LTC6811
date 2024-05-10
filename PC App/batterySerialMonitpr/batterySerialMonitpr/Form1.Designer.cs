
namespace batterySerialMonitpr
{
    partial class Form1
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
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbPARITYBITS = new System.Windows.Forms.ComboBox();
            this.cbSTOPBITS = new System.Windows.Forms.ComboBox();
            this.cbDATABITS = new System.Windows.Forms.ComboBox();
            this.cbBAUDRATE = new System.Windows.Forms.ComboBox();
            this.cbCOMPRT = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPortClose = new System.Windows.Forms.Button();
            this.btnPortOpen = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnSendData = new System.Windows.Forms.Button();
            this.cbsendCMD = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Device1 = new System.Windows.Forms.TabPage();
            this.label34 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.lblPercent = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbCell12 = new System.Windows.Forms.TextBox();
            this.tbTime = new System.Windows.Forms.TextBox();
            this.tbbatteryV1 = new System.Windows.Forms.TextBox();
            this.tbCell6 = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbCell11 = new System.Windows.Forms.TextBox();
            this.tbCell5 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbCell10 = new System.Windows.Forms.TextBox();
            this.tbCell4 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbCell9 = new System.Windows.Forms.TextBox();
            this.tbCell3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbCell8 = new System.Windows.Forms.TextBox();
            this.tbCell2 = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbCell7 = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.tbCell1 = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Device2 = new System.Windows.Forms.TabPage();
            this.Device3 = new System.Windows.Forms.TabPage();
            this.Device4 = new System.Windows.Forms.TabPage();
            this.Device5 = new System.Windows.Forms.TabPage();
            this.Device6 = new System.Windows.Forms.TabPage();
            this.Device7 = new System.Windows.Forms.TabPage();
            this.Device8 = new System.Windows.Forms.TabPage();
            this.label31 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label42 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label43 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label45 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label52 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.Device1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbPARITYBITS);
            this.groupBox1.Controls.Add(this.cbSTOPBITS);
            this.groupBox1.Controls.Add(this.cbDATABITS);
            this.groupBox1.Controls.Add(this.cbBAUDRATE);
            this.groupBox1.Controls.Add(this.cbCOMPRT);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 148);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "COM Port Control";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cbPARITYBITS
            // 
            this.cbPARITYBITS.FormattingEnabled = true;
            this.cbPARITYBITS.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.cbPARITYBITS.Location = new System.Drawing.Point(99, 120);
            this.cbPARITYBITS.Name = "cbPARITYBITS";
            this.cbPARITYBITS.Size = new System.Drawing.Size(120, 21);
            this.cbPARITYBITS.TabIndex = 2;
            this.cbPARITYBITS.Text = "None";
            // 
            // cbSTOPBITS
            // 
            this.cbSTOPBITS.FormattingEnabled = true;
            this.cbSTOPBITS.Items.AddRange(new object[] {
            "Two",
            "One"});
            this.cbSTOPBITS.Location = new System.Drawing.Point(99, 94);
            this.cbSTOPBITS.Name = "cbSTOPBITS";
            this.cbSTOPBITS.Size = new System.Drawing.Size(120, 21);
            this.cbSTOPBITS.TabIndex = 2;
            this.cbSTOPBITS.Text = "One";
            // 
            // cbDATABITS
            // 
            this.cbDATABITS.FormattingEnabled = true;
            this.cbDATABITS.Items.AddRange(new object[] {
            "6",
            "7",
            "8"});
            this.cbDATABITS.Location = new System.Drawing.Point(99, 68);
            this.cbDATABITS.Name = "cbDATABITS";
            this.cbDATABITS.Size = new System.Drawing.Size(120, 21);
            this.cbDATABITS.TabIndex = 2;
            this.cbDATABITS.Text = "8";
            // 
            // cbBAUDRATE
            // 
            this.cbBAUDRATE.FormattingEnabled = true;
            this.cbBAUDRATE.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "19200",
            "28800",
            "57600",
            "115200",
            "230400"});
            this.cbBAUDRATE.Location = new System.Drawing.Point(99, 43);
            this.cbBAUDRATE.Name = "cbBAUDRATE";
            this.cbBAUDRATE.Size = new System.Drawing.Size(120, 21);
            this.cbBAUDRATE.TabIndex = 2;
            this.cbBAUDRATE.Text = "115200";
            // 
            // cbCOMPRT
            // 
            this.cbCOMPRT.FormattingEnabled = true;
            this.cbCOMPRT.Location = new System.Drawing.Point(99, 16);
            this.cbCOMPRT.Name = "cbCOMPRT";
            this.cbCOMPRT.Size = new System.Drawing.Size(120, 21);
            this.cbCOMPRT.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "PARITY BITS:";
            this.label5.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "STOP BITS:";
            this.label4.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "DATA BITS:";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "BAUD RATE:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "COM PORT: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPortClose);
            this.groupBox2.Controls.Add(this.btnPortOpen);
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Location = new System.Drawing.Point(12, 166);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(234, 80);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // btnPortClose
            // 
            this.btnPortClose.Location = new System.Drawing.Point(124, 20);
            this.btnPortClose.Name = "btnPortClose";
            this.btnPortClose.Size = new System.Drawing.Size(104, 23);
            this.btnPortClose.TabIndex = 2;
            this.btnPortClose.Text = "Disconnect";
            this.btnPortClose.UseVisualStyleBackColor = true;
            this.btnPortClose.Click += new System.EventHandler(this.btnPortClose_Click);
            // 
            // btnPortOpen
            // 
            this.btnPortOpen.Location = new System.Drawing.Point(7, 20);
            this.btnPortOpen.Name = "btnPortOpen";
            this.btnPortOpen.Size = new System.Drawing.Size(111, 23);
            this.btnPortOpen.TabIndex = 1;
            this.btnPortOpen.Text = "Connect";
            this.btnPortOpen.UseVisualStyleBackColor = true;
            this.btnPortOpen.Click += new System.EventHandler(this.btnPortOpen_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(7, 49);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(221, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // btnSendData
            // 
            this.btnSendData.Location = new System.Drawing.Point(134, 19);
            this.btnSendData.Name = "btnSendData";
            this.btnSendData.Size = new System.Drawing.Size(88, 21);
            this.btnSendData.TabIndex = 2;
            this.btnSendData.Text = "Send Data";
            this.btnSendData.UseVisualStyleBackColor = true;
            this.btnSendData.Click += new System.EventHandler(this.btnSendData_Click);
            // 
            // cbsendCMD
            // 
            this.cbsendCMD.FormattingEnabled = true;
            this.cbsendCMD.Items.AddRange(new object[] {
            "Real Time",
            "Ones",
            "Continuous"});
            this.cbsendCMD.Location = new System.Drawing.Point(8, 19);
            this.cbsendCMD.Name = "cbsendCMD";
            this.cbsendCMD.Size = new System.Drawing.Size(120, 21);
            this.cbsendCMD.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbsendCMD);
            this.groupBox3.Controls.Add(this.btnSendData);
            this.groupBox3.Location = new System.Drawing.Point(12, 252);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(234, 51);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Send Command";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Device1);
            this.tabControl1.Controls.Add(this.Device2);
            this.tabControl1.Controls.Add(this.Device3);
            this.tabControl1.Controls.Add(this.Device4);
            this.tabControl1.Controls.Add(this.Device5);
            this.tabControl1.Controls.Add(this.Device6);
            this.tabControl1.Controls.Add(this.Device7);
            this.tabControl1.Controls.Add(this.Device8);
            this.tabControl1.Location = new System.Drawing.Point(253, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(558, 293);
            this.tabControl1.TabIndex = 4;
            // 
            // Device1
            // 
            this.Device1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Device1.Controls.Add(this.label34);
            this.Device1.Controls.Add(this.label32);
            this.Device1.Controls.Add(this.lblPercent);
            this.Device1.Controls.Add(this.label57);
            this.Device1.Controls.Add(this.label15);
            this.Device1.Controls.Add(this.label17);
            this.Device1.Controls.Add(this.label16);
            this.Device1.Controls.Add(this.label14);
            this.Device1.Controls.Add(this.label53);
            this.Device1.Controls.Add(this.label13);
            this.Device1.Controls.Add(this.label52);
            this.Device1.Controls.Add(this.label12);
            this.Device1.Controls.Add(this.textBox12);
            this.Device1.Controls.Add(this.tbCell12);
            this.Device1.Controls.Add(this.tbTime);
            this.Device1.Controls.Add(this.tbbatteryV1);
            this.Device1.Controls.Add(this.textBox6);
            this.Device1.Controls.Add(this.tbCell6);
            this.Device1.Controls.Add(this.label33);
            this.Device1.Controls.Add(this.label45);
            this.Device1.Controls.Add(this.label11);
            this.Device1.Controls.Add(this.textBox11);
            this.Device1.Controls.Add(this.tbCell11);
            this.Device1.Controls.Add(this.textBox5);
            this.Device1.Controls.Add(this.tbCell5);
            this.Device1.Controls.Add(this.label44);
            this.Device1.Controls.Add(this.label10);
            this.Device1.Controls.Add(this.textBox10);
            this.Device1.Controls.Add(this.tbCell10);
            this.Device1.Controls.Add(this.textBox4);
            this.Device1.Controls.Add(this.tbCell4);
            this.Device1.Controls.Add(this.label43);
            this.Device1.Controls.Add(this.label9);
            this.Device1.Controls.Add(this.textBox9);
            this.Device1.Controls.Add(this.tbCell9);
            this.Device1.Controls.Add(this.textBox3);
            this.Device1.Controls.Add(this.tbCell3);
            this.Device1.Controls.Add(this.label42);
            this.Device1.Controls.Add(this.label8);
            this.Device1.Controls.Add(this.textBox8);
            this.Device1.Controls.Add(this.tbCell8);
            this.Device1.Controls.Add(this.textBox2);
            this.Device1.Controls.Add(this.tbCell2);
            this.Device1.Controls.Add(this.label30);
            this.Device1.Controls.Add(this.label41);
            this.Device1.Controls.Add(this.label7);
            this.Device1.Controls.Add(this.textBox7);
            this.Device1.Controls.Add(this.tbCell7);
            this.Device1.Controls.Add(this.label29);
            this.Device1.Controls.Add(this.textBox1);
            this.Device1.Controls.Add(this.tbCell1);
            this.Device1.Controls.Add(this.label28);
            this.Device1.Controls.Add(this.label23);
            this.Device1.Controls.Add(this.label27);
            this.Device1.Controls.Add(this.label22);
            this.Device1.Controls.Add(this.label26);
            this.Device1.Controls.Add(this.label21);
            this.Device1.Controls.Add(this.label25);
            this.Device1.Controls.Add(this.label20);
            this.Device1.Controls.Add(this.label24);
            this.Device1.Controls.Add(this.label51);
            this.Device1.Controls.Add(this.label40);
            this.Device1.Controls.Add(this.label50);
            this.Device1.Controls.Add(this.label39);
            this.Device1.Controls.Add(this.label49);
            this.Device1.Controls.Add(this.label38);
            this.Device1.Controls.Add(this.label48);
            this.Device1.Controls.Add(this.label37);
            this.Device1.Controls.Add(this.label47);
            this.Device1.Controls.Add(this.label36);
            this.Device1.Controls.Add(this.label46);
            this.Device1.Controls.Add(this.label35);
            this.Device1.Controls.Add(this.label19);
            this.Device1.Controls.Add(this.label31);
            this.Device1.Controls.Add(this.label18);
            this.Device1.Controls.Add(this.label6);
            this.Device1.Controls.Add(this.progressBar2);
            this.Device1.Controls.Add(this.pictureBox1);
            this.Device1.Controls.Add(this.label54);
            this.Device1.Controls.Add(this.label55);
            this.Device1.Controls.Add(this.label56);
            this.Device1.Location = new System.Drawing.Point(4, 22);
            this.Device1.Name = "Device1";
            this.Device1.Padding = new System.Windows.Forms.Padding(3);
            this.Device1.Size = new System.Drawing.Size(550, 267);
            this.Device1.TabIndex = 0;
            this.Device1.Text = "Device1";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(90, 203);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(24, 24);
            this.label34.TabIndex = 0;
            this.label34.Text = "V";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.BackColor = System.Drawing.Color.White;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(213, 217);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(26, 24);
            this.label32.TabIndex = 0;
            this.label32.Text = "%";
            // 
            // lblPercent
            // 
            this.lblPercent.AutoSize = true;
            this.lblPercent.BackColor = System.Drawing.Color.White;
            this.lblPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercent.Location = new System.Drawing.Point(156, 217);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Size = new System.Drawing.Size(60, 24);
            this.lblPercent.TabIndex = 0;
            this.lblPercent.Text = "85.64";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(277, 10);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Cell 7 : ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(277, 140);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(48, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "Cell 12 : ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(277, 114);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(48, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "Cell 11 : ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(277, 88);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Cell 10 : ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(277, 62);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Cell 9 : ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(277, 36);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Cell 8 : ";
            // 
            // tbCell12
            // 
            this.tbCell12.Location = new System.Drawing.Point(325, 137);
            this.tbCell12.Name = "tbCell12";
            this.tbCell12.Size = new System.Drawing.Size(54, 20);
            this.tbCell12.TabIndex = 1;
            this.tbCell12.Text = "0";
            this.tbCell12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbTime
            // 
            this.tbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTime.Location = new System.Drawing.Point(273, 230);
            this.tbTime.Multiline = true;
            this.tbTime.Name = "tbTime";
            this.tbTime.Size = new System.Drawing.Size(135, 32);
            this.tbTime.TabIndex = 1;
            this.tbTime.Text = "12:44:42 PM";
            this.tbTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbbatteryV1
            // 
            this.tbbatteryV1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbbatteryV1.Location = new System.Drawing.Point(11, 199);
            this.tbbatteryV1.Multiline = true;
            this.tbbatteryV1.Name = "tbbatteryV1";
            this.tbbatteryV1.Size = new System.Drawing.Size(73, 32);
            this.tbbatteryV1.TabIndex = 1;
            this.tbbatteryV1.Text = "35.97";
            this.tbbatteryV1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbCell6
            // 
            this.tbCell6.Location = new System.Drawing.Point(56, 137);
            this.tbCell6.Name = "tbCell6";
            this.tbCell6.Size = new System.Drawing.Size(54, 20);
            this.tbCell6.TabIndex = 1;
            this.tbCell6.Text = "3.65";
            this.tbCell6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(8, 180);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(115, 16);
            this.label33.TabIndex = 0;
            this.label33.Text = "Battery Voltage";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 140);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Cell 6 : ";
            // 
            // tbCell11
            // 
            this.tbCell11.Location = new System.Drawing.Point(325, 111);
            this.tbCell11.Name = "tbCell11";
            this.tbCell11.Size = new System.Drawing.Size(54, 20);
            this.tbCell11.TabIndex = 1;
            this.tbCell11.Text = "0";
            this.tbCell11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbCell5
            // 
            this.tbCell5.Location = new System.Drawing.Point(56, 111);
            this.tbCell5.Name = "tbCell5";
            this.tbCell5.Size = new System.Drawing.Size(54, 20);
            this.tbCell5.TabIndex = 1;
            this.tbCell5.Text = "3.51";
            this.tbCell5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Cell 5 : ";
            // 
            // tbCell10
            // 
            this.tbCell10.Location = new System.Drawing.Point(325, 85);
            this.tbCell10.Name = "tbCell10";
            this.tbCell10.Size = new System.Drawing.Size(54, 20);
            this.tbCell10.TabIndex = 1;
            this.tbCell10.Text = "3.55";
            this.tbCell10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbCell4
            // 
            this.tbCell4.Location = new System.Drawing.Point(56, 85);
            this.tbCell4.Name = "tbCell4";
            this.tbCell4.Size = new System.Drawing.Size(54, 20);
            this.tbCell4.TabIndex = 1;
            this.tbCell4.Text = "3.68";
            this.tbCell4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Cell 4 : ";
            // 
            // tbCell9
            // 
            this.tbCell9.Location = new System.Drawing.Point(325, 59);
            this.tbCell9.Name = "tbCell9";
            this.tbCell9.Size = new System.Drawing.Size(54, 20);
            this.tbCell9.TabIndex = 1;
            this.tbCell9.Text = "3.54";
            this.tbCell9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbCell9.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // tbCell3
            // 
            this.tbCell3.Location = new System.Drawing.Point(56, 59);
            this.tbCell3.Name = "tbCell3";
            this.tbCell3.Size = new System.Drawing.Size(54, 20);
            this.tbCell3.TabIndex = 1;
            this.tbCell3.Text = "3.65";
            this.tbCell3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Cell 3 : ";
            // 
            // tbCell8
            // 
            this.tbCell8.Location = new System.Drawing.Point(325, 33);
            this.tbCell8.Name = "tbCell8";
            this.tbCell8.Size = new System.Drawing.Size(54, 20);
            this.tbCell8.TabIndex = 1;
            this.tbCell8.Text = "3.65";
            this.tbCell8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbCell2
            // 
            this.tbCell2.Location = new System.Drawing.Point(56, 33);
            this.tbCell2.Name = "tbCell2";
            this.tbCell2.Size = new System.Drawing.Size(54, 20);
            this.tbCell2.TabIndex = 1;
            this.tbCell2.Text = "3.58";
            this.tbCell2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(131, 166);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(134, 20);
            this.label30.TabIndex = 0;
            this.label30.Text = "Battery Percent";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Cell 2 : ";
            // 
            // tbCell7
            // 
            this.tbCell7.Location = new System.Drawing.Point(325, 7);
            this.tbCell7.Name = "tbCell7";
            this.tbCell7.Size = new System.Drawing.Size(54, 20);
            this.tbCell7.TabIndex = 1;
            this.tbCell7.Text = "3.64";
            this.tbCell7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(385, 140);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(14, 13);
            this.label29.TabIndex = 0;
            this.label29.Text = "V";
            // 
            // tbCell1
            // 
            this.tbCell1.Location = new System.Drawing.Point(56, 7);
            this.tbCell1.Name = "tbCell1";
            this.tbCell1.Size = new System.Drawing.Size(54, 20);
            this.tbCell1.TabIndex = 1;
            this.tbCell1.Text = "3.52";
            this.tbCell1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(385, 114);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(14, 13);
            this.label28.TabIndex = 0;
            this.label28.Text = "V";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(116, 140);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(14, 13);
            this.label23.TabIndex = 0;
            this.label23.Text = "V";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(385, 88);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(14, 13);
            this.label27.TabIndex = 0;
            this.label27.Text = "V";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(116, 114);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(14, 13);
            this.label22.TabIndex = 0;
            this.label22.Text = "V";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(385, 66);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(14, 13);
            this.label26.TabIndex = 0;
            this.label26.Text = "V";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(116, 88);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(14, 13);
            this.label21.TabIndex = 0;
            this.label21.Text = "V";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(385, 36);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(14, 13);
            this.label25.TabIndex = 0;
            this.label25.Text = "V";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(116, 66);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(14, 13);
            this.label20.TabIndex = 0;
            this.label20.Text = "V";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(386, 10);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(14, 13);
            this.label24.TabIndex = 0;
            this.label24.Text = "V";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(116, 36);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(14, 13);
            this.label19.TabIndex = 0;
            this.label19.Text = "V";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(117, 10);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(14, 13);
            this.label18.TabIndex = 0;
            this.label18.Text = "V";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Cell 1 : ";
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(146, 204);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(98, 51);
            this.progressBar2.TabIndex = 3;
            this.progressBar2.Value = 88;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::batterySerialMonitpr.Properties.Resources.ver;
            this.pictureBox1.Location = new System.Drawing.Point(135, 194);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Device2
            // 
            this.Device2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Device2.Location = new System.Drawing.Point(4, 22);
            this.Device2.Name = "Device2";
            this.Device2.Padding = new System.Windows.Forms.Padding(3);
            this.Device2.Size = new System.Drawing.Size(414, 267);
            this.Device2.TabIndex = 1;
            this.Device2.Text = "Device2";
            // 
            // Device3
            // 
            this.Device3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Device3.Location = new System.Drawing.Point(4, 22);
            this.Device3.Name = "Device3";
            this.Device3.Padding = new System.Windows.Forms.Padding(3);
            this.Device3.Size = new System.Drawing.Size(414, 267);
            this.Device3.TabIndex = 2;
            this.Device3.Text = "Device3";
            // 
            // Device4
            // 
            this.Device4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Device4.Location = new System.Drawing.Point(4, 22);
            this.Device4.Name = "Device4";
            this.Device4.Padding = new System.Windows.Forms.Padding(3);
            this.Device4.Size = new System.Drawing.Size(414, 267);
            this.Device4.TabIndex = 3;
            this.Device4.Text = "Device4";
            // 
            // Device5
            // 
            this.Device5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Device5.Location = new System.Drawing.Point(4, 22);
            this.Device5.Name = "Device5";
            this.Device5.Padding = new System.Windows.Forms.Padding(3);
            this.Device5.Size = new System.Drawing.Size(414, 267);
            this.Device5.TabIndex = 4;
            this.Device5.Text = "Device5";
            // 
            // Device6
            // 
            this.Device6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Device6.Location = new System.Drawing.Point(4, 22);
            this.Device6.Name = "Device6";
            this.Device6.Padding = new System.Windows.Forms.Padding(3);
            this.Device6.Size = new System.Drawing.Size(414, 267);
            this.Device6.TabIndex = 5;
            this.Device6.Text = "Device6";
            // 
            // Device7
            // 
            this.Device7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Device7.Location = new System.Drawing.Point(4, 22);
            this.Device7.Name = "Device7";
            this.Device7.Padding = new System.Windows.Forms.Padding(3);
            this.Device7.Size = new System.Drawing.Size(414, 267);
            this.Device7.TabIndex = 6;
            this.Device7.Text = "Device7";
            // 
            // Device8
            // 
            this.Device8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Device8.Location = new System.Drawing.Point(4, 22);
            this.Device8.Name = "Device8";
            this.Device8.Padding = new System.Windows.Forms.Padding(3);
            this.Device8.Size = new System.Drawing.Size(414, 267);
            this.Device8.TabIndex = 7;
            this.Device8.Text = "Device8";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(137, 10);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(45, 13);
            this.label31.TabIndex = 0;
            this.label31.Text = "SoC 1 : ";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(246, 10);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(15, 13);
            this.label35.TabIndex = 0;
            this.label35.Text = "%";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(185, 7);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(54, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "83.81";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(137, 36);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(42, 13);
            this.label41.TabIndex = 0;
            this.label41.Text = "SoC 2 :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(185, 33);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(54, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "85.23";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(137, 62);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(45, 13);
            this.label42.TabIndex = 0;
            this.label42.Text = "SoC 3 : ";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(185, 59);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(54, 20);
            this.textBox3.TabIndex = 1;
            this.textBox3.Text = "86.9";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(137, 88);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(45, 13);
            this.label43.TabIndex = 0;
            this.label43.Text = "SoC 4 : ";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(185, 85);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(54, 20);
            this.textBox4.TabIndex = 1;
            this.textBox4.Text = "87.61";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(137, 114);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(45, 13);
            this.label44.TabIndex = 0;
            this.label44.Text = "SoC 5 : ";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(185, 111);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(54, 20);
            this.textBox5.TabIndex = 1;
            this.textBox5.Text = "83.57";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(137, 140);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(45, 13);
            this.label45.TabIndex = 0;
            this.label45.Text = "SoC 6 : ";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(185, 137);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(54, 20);
            this.textBox6.TabIndex = 1;
            this.textBox6.Text = "86.9";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(460, 7);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(54, 20);
            this.textBox7.TabIndex = 1;
            this.textBox7.Text = "86.66";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(460, 33);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(54, 20);
            this.textBox8.TabIndex = 1;
            this.textBox8.Text = "86.9";
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(460, 59);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(54, 20);
            this.textBox9.TabIndex = 1;
            this.textBox9.Text = "84.28";
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox9.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(460, 85);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(54, 20);
            this.textBox10.TabIndex = 1;
            this.textBox10.Text = "84.52";
            this.textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(460, 111);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(54, 20);
            this.textBox11.TabIndex = 1;
            this.textBox11.Text = "0";
            this.textBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(460, 137);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(54, 20);
            this.textBox12.TabIndex = 1;
            this.textBox12.Text = "0";
            this.textBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(412, 36);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(45, 13);
            this.label52.TabIndex = 0;
            this.label52.Text = "SoC 8 : ";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(412, 62);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(45, 13);
            this.label53.TabIndex = 0;
            this.label53.Text = "SoC 9 : ";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(412, 88);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(51, 13);
            this.label54.TabIndex = 0;
            this.label54.Text = "SoC 10 : ";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(412, 114);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(51, 13);
            this.label55.TabIndex = 0;
            this.label55.Text = "SoC 11 : ";
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(412, 140);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(51, 13);
            this.label56.TabIndex = 0;
            this.label56.Text = "SoC 12 : ";
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(412, 10);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(45, 13);
            this.label57.TabIndex = 0;
            this.label57.Text = "SoC 7 : ";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(245, 36);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(15, 13);
            this.label36.TabIndex = 0;
            this.label36.Text = "%";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(245, 66);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(15, 13);
            this.label37.TabIndex = 0;
            this.label37.Text = "%";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(245, 88);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(15, 13);
            this.label38.TabIndex = 0;
            this.label38.Text = "%";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(246, 114);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(15, 13);
            this.label39.TabIndex = 0;
            this.label39.Text = "%";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(245, 140);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(15, 13);
            this.label40.TabIndex = 0;
            this.label40.Text = "%";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(520, 10);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(15, 13);
            this.label46.TabIndex = 0;
            this.label46.Text = "%";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(519, 36);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(15, 13);
            this.label47.TabIndex = 0;
            this.label47.Text = "%";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(519, 66);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(15, 13);
            this.label48.TabIndex = 0;
            this.label48.Text = "%";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(519, 88);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(15, 13);
            this.label49.TabIndex = 0;
            this.label49.Text = "%";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(520, 114);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(15, 13);
            this.label50.TabIndex = 0;
            this.label50.Text = "%";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(519, 140);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(15, 13);
            this.label51.TabIndex = 0;
            this.label51.Text = "%";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 311);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Battery Monitor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.Device1.ResumeLayout(false);
            this.Device1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbPARITYBITS;
        private System.Windows.Forms.ComboBox cbSTOPBITS;
        private System.Windows.Forms.ComboBox cbDATABITS;
        private System.Windows.Forms.ComboBox cbBAUDRATE;
        private System.Windows.Forms.ComboBox cbCOMPRT;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSendData;
        private System.Windows.Forms.Button btnPortClose;
        private System.Windows.Forms.Button btnPortOpen;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ComboBox cbsendCMD;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Device1;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label lblPercent;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbCell12;
        private System.Windows.Forms.TextBox tbbatteryV1;
        private System.Windows.Forms.TextBox tbCell6;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbCell11;
        private System.Windows.Forms.TextBox tbCell5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbCell10;
        private System.Windows.Forms.TextBox tbCell4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbCell9;
        private System.Windows.Forms.TextBox tbCell3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbCell8;
        private System.Windows.Forms.TextBox tbCell2;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbCell7;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox tbCell1;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage Device2;
        private System.Windows.Forms.TabPage Device3;
        private System.Windows.Forms.TabPage Device4;
        private System.Windows.Forms.TabPage Device5;
        private System.Windows.Forms.TabPage Device6;
        private System.Windows.Forms.TabPage Device7;
        private System.Windows.Forms.TabPage Device8;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.TextBox tbTime;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label56;
    }
}

