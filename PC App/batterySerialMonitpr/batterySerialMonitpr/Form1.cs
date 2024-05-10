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
namespace batterySerialMonitpr
{
    public partial class Form1 : Form
    {
        int cmdData = 0;
        string batteryData = "";
        int indx=0;
        string[] printdata;
        private Queue<byte> recievedData = new Queue<byte>();
        List<TextBox> myTextboxList = new List<TextBox>();
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSendData_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                if(cbsendCMD.Text.ToString()=="Real Time") cmdData = 11;
                byte[] buffer = new byte[] { Convert.ToByte(cmdData) };
                serialPort1.Write(buffer,0,1);
            }
        }

        private void btnPortClose_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                progressBar1.Value = 0;
            }
            //timer1.Stop();
        }

        private void btnPortOpen_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = cbCOMPRT.Text;
                serialPort1.BaudRate = Convert.ToInt32(cbBAUDRATE.Text);
                serialPort1.DataBits = Convert.ToInt32(cbDATABITS.Text);
                serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cbSTOPBITS.Text);
                serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), cbPARITYBITS.Text);
                serialPort1.Open();
                progressBar1.Value = 100;
                serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort_DataReceived);
            }
            catch(Exception er)
            {
                MessageBox.Show(er.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            cbCOMPRT.Items.AddRange(ports);
            timer1 = new Timer();
            timer1.Interval = 1000;
            timer1.Tick += new EventHandler(process);
            timer1.Start();
            myTextboxList.Add(tbCell1);
            myTextboxList.Add(tbCell2);
            myTextboxList.Add(tbCell3);
            myTextboxList.Add(tbCell4);
            myTextboxList.Add(tbCell5);
            myTextboxList.Add(tbCell6);
            myTextboxList.Add(tbCell7);
            myTextboxList.Add(tbCell8);
            myTextboxList.Add(tbCell9);
            myTextboxList.Add(tbCell10);
            myTextboxList.Add(tbCell11);
            myTextboxList.Add(tbCell12);
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }
         void process(object sender,EventArgs e)
        {
            TextBox[] tb = { tbCell1, tbCell2, tbCell3, tbCell4, tbCell5, tbCell6, tbCell7, tbCell8, tbCell9, tbCell10, tbCell11, tbCell12 };
            TextBox[] tbsoc = { textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7, textBox8, textBox9, textBox10, textBox11, textBox12 };
            tbTime.Text = DateTime.Now.ToLongTimeString();
            if (serialPort1.IsOpen)
            {
                string[] data = batteryData.Split(',');
                int colIndx = 0;
                if(data.Length>1)
                foreach (string word in data)
                {
                    try
                    {
                        Console.WriteLine(word);
                        string[] val = word.ToString().Split(':');
                        Console.WriteLine(val.Length);
                        if (val.Length == 3)
                        {
                                //colIndx = 0;
                            string[] icN = val[0].Split('C');
                            string[] cN = val[1].Split('C');
                            /*
                            Console.WriteLine("Val0 : "+val[0]);
                            Console.WriteLine("Val1 : " + val[1]);
                            Console.WriteLine("Val2 : " + val[2]);
                            Console.WriteLine("ICnlen : " + icN.Length);
                            Console.WriteLine("icn : " + icN[1]);
                            Console.WriteLine("cn : " + cN[1]);*/
                                if (int.Parse(icN[1]) == 1) tb[int.Parse(cN[1])-1].Text = val[2];
                                string[] Num = icN[1].Split(' ');
                                /*
                                Console.WriteLine("Numlen : " + Num.Length);
                                Console.WriteLine("num0 : " + Num[0]);
                                Console.WriteLine("num1 : " + Num[1]);
                                Console.WriteLine("num2 : " + Num[2]);
                                */
                                indx = Int16.Parse(Num[2]);
                                //if (val[2].Length > 0&&indx==1) tb[colIndx].Text = val[2];
                                //colIndx=colIndx+1;
                                /*if (val[0]=="IC1")
                                {
                                    if (val[1] == "C1") tbCell1.Text = val[2];
                                    if (val[1] == "C2") tbCell2.Text = val[2];
                                    if (val[1] == "C3") tbCell3.Text = val[2];
                                    if (val[1] == "C4") tbCell4.Text = val[2];
                                    if (val[1] == "C5") tbCell5.Text = val[2];
                                    if (val[1] == "C6") tbCell6.Text = val[2];
                                    if (val[1] == "C7") tbCell7.Text = val[2];
                                    if (val[1] == "C8") tbCell8.Text = val[2];
                                    if (val[1] == "C9") tbCell9.Text = val[2];
                                    if (val[1] == "C10") tbCell10.Text = val[2];
                                    if (val[1] == "C11") tbCell11.Text = val[2];
                                    if (val[1] == "C12") tbCell12.Text = val[2];
                                }*/
                        }
                        else if (val.Length == 5)
                        {
                                string[] icN1 = val[0].Split('C');
                                string[] icN2 = val[2].Split('C');
                                string[] cN1 = val[1].Split('C');
                                string[] cN2 = val[3].Split('C');
                                string[] val1 = val[2].Split('I');
                                string valc1 = string.Join("", val1[0].Take(5));
                                if (int.Parse(icN1[1]) == 1) tb[int.Parse(cN1[1]) - 1].Text = valc1;
                                if (int.Parse(icN2[1]) == 1) tb[int.Parse(cN2[1]) - 1].Text = val[4];
                        }
                        else if (val.Length == 7)
                            {
                                string[] icN1 = val[0].Split('C');
                                string[] icN2 = val[2].Split('C');
                                string[] icN3 = val[4].Split('C');
                                string[] cN1 = val[1].Split('C');
                                string[] cN2 = val[3].Split('C');
                                string[] cN3 = val[5].Split('C');
                                string[] val1 = val[2].Split('I');
                                string[] val2 = val[4].Split('I');
                                string valc1 = string.Join("", val1[0].Take(5));
                                string valc2 = string.Join("", val2[0].Take(5));
                                if (int.Parse(icN1[1]) == 1) tb[int.Parse(cN1[1]) - 1].Text = valc1;
                                if (int.Parse(icN2[1]) == 1) tb[int.Parse(cN2[1]) - 1].Text = valc2;
                                if (int.Parse(icN3[1]) == 1) tb[int.Parse(cN3[1]) - 1].Text = val[6];

                            }
                            else if (val.Length == 2)
                        {
                                //Console.WriteLine("cnt : " + colIndx);
                                //Console.WriteLine("Val0 : " + val[0]);
                                //Console.WriteLine("Val1 : " + val[1]);
                                if (val[1].Length > 0 && indx == 1) tb[colIndx].Text = val[1];
                                //Console.WriteLine(tb[0].Text);
                            colIndx=colIndx+1;
                        }else
                            {
                                Console.WriteLine("Emp");
                            }

                    }catch(Exception err)
                    {
                        Console.WriteLine(err.ToString());
                    }
                    

                }
                Console.WriteLine(printdata);
                float Voltage = 0;
                int ind = 0;
                if (data.Length > 1)
                    foreach (var tb_data in tb)
                {
                        string ssd = float.Parse(tb_data.Text.ToString()).ToString("0.000");  
                        //Console.WriteLine(ssd);
                    float sd = float.Parse(ssd);
                    Voltage = Voltage + sd;
                        tbsoc[ind].Text = (sd / 4.2 * 100).ToString("0.000");
                        ind++;
                }
                tbbatteryV1.Text = Voltage.ToString();
                float persent = Voltage / 42*100;
                lblPercent.Text = persent.ToString("0.00");
                int inper = (int)persent;
                if (inper < 3) inper = 0;
                else if (inper > 100) inper = 100;
                Console.WriteLine(inper);
                progressBar2.Value = inper;
            }
        }
        void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            batteryData += serialPort1.ReadExisting();

            //test for termination character in buffer
            if (batteryData.Contains("\n"))
            {
                //Console.WriteLine(batteryData);
               
            }
           
            processData();
        }
        void processData()
        {
            

            // Determine if we have a "packet" in the queue
            if (recievedData.Count > 50)
            {
                var packet = Enumerable.Range(0, 50).Select(i => recievedData.Dequeue());
                Console.WriteLine(packet);
            }
        }
    }
}
