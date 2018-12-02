using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsHW1_1
{
    public partial class Form1 : Form
    {
        bool messageBox = false;
        public Form1()
        {
            InitializeComponent();
            Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
            timer2.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Text = DateTime.Now.ToLongTimeString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            FormClosingEventArgs ex = new FormClosingEventArgs(CloseReason.ApplicationExitCall, false);
            Form1_FormClosing(sender, ex);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (messageBox == false && e.CloseReason == CloseReason.ApplicationExitCall)
            {
                messageBox = true;
                const string message = "To new meetings";
                const string caption = "Bye-Bye";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = 0;
            double y = 0;
            try
            {
                if (textBox1.Text == "" || textBox2.Text == "")
                {
                    const string message = "No values!";
                    const string caption = "Warning";
                    MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    x = Convert.ToDouble(textBox1.Text);
                    y = Convert.ToDouble(textBox2.Text);
                    textBox3.Text = (Math.Pow(Math.Pow(Math.Sin(x+1), 2), 3) -
                        (Math.Sqrt(Math.Abs(y - 3)) / 3.01)).ToString();
                }
            }
            catch
            {
                const string message = "Values are not numbers!";
                const string caption = "Error";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
