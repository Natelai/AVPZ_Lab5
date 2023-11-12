using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5AVPZ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var data = new Data();
            data.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var table1_2 = new Table12();
            table1_2.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var table3 = new Table3();
            table3.ShowDialog();
        }
    }
}
