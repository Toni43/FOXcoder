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

namespace TestFormsC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String[] ports = SerialPort.GetPortNames();
            cBoxComPorts.Items.AddRange(ports);
            serialPort1.ReadTimeout = 3000;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonProg_Click(object sender, EventArgs e)
        {
            int freq;
            String settings_str = "START";
            try
            {
                freq = int.Parse(cBoxFreq.Text);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Console.WriteLine("Введённая частота={0}", freq);

            if ((freq < 0) | (freq == 0) | (freq < 3510) | (freq > 3600))
            {
                Console.WriteLine("Введена неправильная частота");

                // Initializes the variables to pass to the MessageBox.Show method.
                string message = "Диапазон используемых частот передатчика должен быть в пределах 3510 - 3600 кГц";
                string caption = "Введена некорректная частота";
                // MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                // DialogResult result;

                // Displays the MessageBox.
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (rbMOE.Checked == true) settings_str += ",MOE";
            if (rbMOI.Checked == true) settings_str += ",MOI";
            if (rbMOS.Checked == true) settings_str += ",MOS";
            if (rbMOH.Checked == true) settings_str += ",MOH";
            if (rbMO5.Checked == true) settings_str += ",MO5";
            if (rbMO.Checked == true) settings_str += ",MO";
            if (rbMM.Checked == true) settings_str += ",MM";

            if (rb30s.Checked == true) settings_str += ",30";
            if (rb60s.Checked == true) settings_str += ",60";

            settings_str += ",";
            settings_str += Convert.ToString(freq);

            if (cBoxStartMode.Checked == true) settings_str += ",1";
            else settings_str += ",0";

            settings_str += ",STOP";

            Console.WriteLine(settings_str);

            try
            {
                serialPort1.PortName = cBoxComPorts.Text;
                serialPort1.Open();
                serialPort1.WriteLine(settings_str);
            }

            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string txAnswerStr = serialPort1.ReadLine();
                if (txAnswerStr == "OK") labelDevAnswer.Text = "Программирование выполнено!";
                timer2.Start();
            }
            catch (Exception err)
            {
                MessageBox.Show("Таймаут ответа от передатчика", err.Message, MessageBoxButtons.OK,MessageBoxIcon.Error);
                Console.WriteLine("Строка с настройками НЕ отправлена");
                labelOutSrt.Text = "Строка с настройками НЕ отправлена";
                serialPort1.Close();
                timer1.Start();
                return;
            }
            serialPort1.Close();
            Console.WriteLine("Строка с настройками отправлена");
            labelOutSrt.Text = "Строка с настройками отправлена";
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            labelOutSrt.Text = "";
        }

        private void cBoxFreq_SelectedIndexChanged(object sender, EventArgs e)
        {
            int freq;
            try
            {
                freq = int.Parse(cBoxFreq.Text);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if ((freq < 0) | (freq == 0) | (freq < 3510) | (freq > 3600)) cBoxFreq.ForeColor = Color.Red;
            else cBoxFreq.ForeColor = Color.Black;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
            labelDevAnswer.Text = "";
        }
    }
}
