using Lab5AVPZ.Seeders;
using System;
using System.Windows.Forms;

namespace Lab5AVPZ
{
    public partial class Table12 : Form
    {
        private Table_1_2_Seeder _seeder;
        public Table12()
        {
            InitializeComponent();
            _seeder = new Table_1_2_Seeder(dataGridView1);
            _seeder.Seed();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void recountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _seeder.RecountChangesTable1(0, 12, 20, 30, 45, this.dataGridView1);
        }
    }
}
