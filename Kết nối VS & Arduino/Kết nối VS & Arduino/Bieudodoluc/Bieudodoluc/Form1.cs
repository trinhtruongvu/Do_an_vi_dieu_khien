
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
using ZedGraph;
using System.IO;

namespace Bieudodoluc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] Baudrate = { "1200", "2400", "4800", "9600", "19200", "31250", "38400", "57600", "115200" };
            cboBaudrate.Items.AddRange(Baudrate);
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void butConnect_Click(object sender, EventArgs e)
        {
            if (!serCom.IsOpen)
            {
                try
                {
                    serCom.PortName = cboCOMPORT.Text;
                    serCom.BaudRate = Convert.ToInt32(cboBaudrate.Text);
                    serCom.Open();
                    butConnect.Text = "Connected";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                serCom.Close();
                butConnect.Text = "Disconnected";
            }
        }

        private void butExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboCOMPORT.DataSource = SerialPort.GetPortNames();
            cboBaudrate.Text = "9600";      
        }
        int tong = 0;
        

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private bool IsNumeric(string value)
        {
            double number;
            return double.TryParse(value, out number);
        }
        private void serCom_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            String AllData = "";
            AllData = serCom.ReadLine();
            // txtPress.Text = AllData;
            AllData = AllData.Trim();
            int len = AllData.Length;
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SendvalueButtun_Click(object sender, EventArgs e)
        {
            if (!serCom.IsOpen)
            {
                MessageBox.Show("Serial port is not open.");
                return;
            }

            // Lấy dữ liệu từ các điều khiển
            string direction = DirectioncomboBox.SelectedItem.ToString(); // P or N
            double positionValue = Convert.ToDouble(PositiontextBox.Text) * 22.6744186; // Nhân giá trị từ PositiontextBox với 22.58
            string position = positionValue.ToString(); // Chuyển đổi giá trị thành chuỗi
            string velocity = VelocitytextBox.Text;

            // Tạo chuỗi dữ liệu
            string dataToSend = $"{direction}{position} {velocity}";

            // Gửi dữ liệu đến Arduino
            try
            {
                serCom.WriteLine(dataToSend);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sending data: " + ex.Message);
            }
        }

        private void VelocitytextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PositiontextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void DirectioncomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }


        private void Homebutton_Click(object sender, EventArgs e)
        {
            if (!serCom.IsOpen)
            {
                MessageBox.Show("Serial port is not open.");
                return;
            }

            // Gửi tín hiệu H đến Arduino để thực hiện homing
            try
            {
                serCom.WriteLine("H");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sending data: " + ex.Message);
            }
        }

        private void Stopmotorbutton_Click(object sender, EventArgs e)
        {
            if (!serCom.IsOpen)
            {
                MessageBox.Show("Serial port is not open.");
                return;
            }

            // Gửi tín hiệu S đến Arduino để dừng động cơ
            try
            {
                serCom.WriteLine("S");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sending data: " + ex.Message);
            }
        }

        private void Setbutton_Click(object sender, EventArgs e)
        {
            if (!serCom.IsOpen)
            {
                MessageBox.Show("Serial port is not open.");
                return;
            }

            // Gửi tín hiệu U đến Arduino để cập nhật vị trí hiện tại là vị trí mới 0
            try
            {
                serCom.WriteLine("U");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sending data: " + ex.Message);
            }
        }

    }
}