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
    public partial class Form2 : Form
    {
        public Form2(ref MyArray myArray, int comboBox1SelectedIndex)
        {
            InitializeComponent();
            int count = myArray.Count;
            dataGridView1.ColumnCount = 1;
            dataGridView1.RowCount = count;
            for (int i = 0; i < count; i++)
            {
                dataGridView1[0, i].Value = myArray[i];
            }
            switch (comboBox1SelectedIndex)
            {
                case 0:
                    {
                        label1.Text = "Сумма =";
                        textBox1.Text = myArray.Sum().ToString();
                        break;
                    }
                case 1:
                    {
                        label1.Text = "Произведение =";
                        textBox1.Text = myArray.Mult().ToString();
                        break;
                    }
            }
        }
    }
}
