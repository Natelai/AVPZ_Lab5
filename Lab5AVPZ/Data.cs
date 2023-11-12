using Lab5AVPZ.Seeders;
using System;
using System.Windows.Forms;

namespace Lab5AVPZ
{
    public partial class Data : Form
    {
        private Table_1_1_Seeder _seeder;
        private void backButton_Click(object sender, EventArgs e)
        {
            
        }

        public Data()
        {
            InitializeComponent();
            _seeder = new Table_1_1_Seeder(Table_1_1);
            _seeder.Seed();
        }

        private void backToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void recountToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _seeder.RecountChangesTable1(0, 8, 12, 16, 22, this.Table_1_1);
        }

        


    }
}
