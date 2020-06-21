using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SeSerial
{
    public partial class Form1 : Form
    {
        int tempo = 0;
        int elempo = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                timer1.Stop();

            }
            else
            {

                serialPort1.Open();
                timer1.Start();
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (serialPort1.IsOpen)
            {
                textBox1.AppendText(serialPort1.ReadExisting());
            }
        }
    }
}
