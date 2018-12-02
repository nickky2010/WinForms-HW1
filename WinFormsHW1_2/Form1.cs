using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsHW1_2
{
    public partial class Form1 : Form
    {
        Matrix matrix;
        public Form1()
        {
            InitializeComponent();
            dataGridView1.RowCount = 1;
            dataGridView1.ColumnCount = 1;
            dataGridView1.Columns[0].Width = 95;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = Convert.ToInt32(numericUpDown1.Value);
            dataGridView1.Columns[dataGridView1.ColumnCount - 1].Width = 95;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.RowCount = Convert.ToInt32(numericUpDown2.Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                CheckMatrix();
                for (int i = 0; i < matrix.Col; i++)
                {
                    for (int j = 0; j < matrix.Row; j++)
                    {
                        dataGridView1[i, j].Style.BackColor = Color.White;
                    }
                }
                if (radioButton1.Checked)
                {
                    (int value, int col, int row) min = matrix.Min();
                    dataGridView1[min.col, min.row].Style.BackColor = Color.Green;
                }
                else
                {
                    (int value, int col, int row) max = matrix.Max();
                    dataGridView1[max.col, max.row].Style.BackColor = Color.Green;
                }
            }
            catch
            {
                const string message = "Values are not numbers!";
                const string caption = "Error";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                CheckMatrix();
                listBox1.Items.Clear();
                List<int> listPos = Matrix.Find(ref matrix, x => x > 0);
                listPos.ForEach(x => listBox1.Items.Add(x.ToString()));
                listBox1.Show();
            }
            catch
            {
                const string message = "Values are not numbers!";
                const string caption = "Error";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CreatMatrix()
        {
            matrix = new Matrix(dataGridView1.ColumnCount, dataGridView1.RowCount);
            for (int i = 0; i < matrix.Col; i++)
            {
                for (int j = 0; j < matrix.Row; j++)
                {
                    matrix[i, j] = Convert.ToInt32(dataGridView1[i, j].Value);
                }
            }
        }
        private void CheckMatrix()
        {
            if (matrix == null)
                CreatMatrix();
            else
            {
                if (matrix.Col == dataGridView1.ColumnCount &&
                    matrix.Row == dataGridView1.RowCount)
                {
                    for (int i = 0; i < matrix.Col; i++)
                    {
                        for (int j = 0; j < matrix.Row; j++)
                        {
                            if (matrix[i, j] != Convert.ToInt32(dataGridView1[i, j].Value))
                            {
                                CreatMatrix();
                                j = matrix.Row;
                                i = matrix.Col;
                            }
                        }
                    }
                }
                else
                    CreatMatrix();
            }
        }
    }
}
