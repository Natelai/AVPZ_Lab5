using Lab5AVPZ.Seeders;
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
    public partial class Table3 : Form
    {
        private Table_3_Seeder _seeder;
        public Table3()
        {
            InitializeComponent();
            _seeder = new Table_3_Seeder(dataGridView1);
            _seeder.Seed();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void backToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
