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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            linkLabel1.Text = "Манько Николай.\n\nHard skills C#, C/C++\n(now learning WinForms, MS SQL)";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/nickkymanko/");
        }
    }
}
