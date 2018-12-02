using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_5_indep_work_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            dataGridView1.RowCount = 1;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = Convert.ToInt32(numericUpDown1.Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyArray myArray = new MyArray(dataGridView1.ColumnCount);
            for (int i = 0; i < myArray.Count; i++)
            {
                try
                {
                    myArray[i] = Convert.ToInt32(dataGridView1[i, 0].Value);
                }
                catch
                {

                }
            }
            Form2 form2 = new Form2(ref myArray, comboBox1.SelectedIndex);
            form2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }
    }
}
