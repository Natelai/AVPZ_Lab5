using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5AVPZ.Seeders
{
    public class Table_1_1_Seeder
    {
        private DataGridView _dataGridView;

        public Table_1_1_Seeder(DataGridView dataGridView)
        {
            this._dataGridView = dataGridView;
        }

        public void Seed()
        {
            _dataGridView.Width = 705;
            _dataGridView.Height = 595;
            
            int temp = 0;
            int n = 23;

            _dataGridView.ColumnCount = 3;
            _dataGridView.Columns[0].Width = 500;
            _dataGridView.Columns[1].Width = 100;
            _dataGridView.Columns[2].Width = 100;
            for (int i = 0; i < n; i++)
                _dataGridView.Rows.Add();

            

            _dataGridView.Rows[0].Cells[0].Value = "1. Множина джерел появи технічних ризиків";
            _dataGridView.Rows[0].Cells[0].Style.Font = new Font(_dataGridView.DefaultCellStyle.Font, FontStyle.Bold);
            _dataGridView.Rows[1].Cells[0].Value = "1.1. функціональні характеристики ПЗ";
            _dataGridView.Rows[2].Cells[0].Value = "1.2. характеристики якості ПЗ";
            _dataGridView.Rows[3].Cells[0].Value = "1.3. характеристики надійності ПЗ";
            _dataGridView.Rows[4].Cells[0].Value = "1.4. застосовність ПЗ";
            _dataGridView.Rows[5].Cells[0].Value = "1.5. часова продуктивність ПЗ";
            _dataGridView.Rows[6].Cells[0].Value = "1.6. супроводжуваність ПЗ";
            _dataGridView.Rows[7].Cells[0].Value = "1.7. повторне використання компонент ПЗ";
            _dataGridView.Rows[8].Cells[0].Value = "2.Множина джерел появи вартісних ризиків";
            _dataGridView.Rows[8].Cells[0].Style.Font = new Font(_dataGridView.DefaultCellStyle.Font, FontStyle.Bold);
            _dataGridView.Rows[9].Cells[0].Value = "2.1. обмеження сумарного бюджету на програмний проект";
            _dataGridView.Rows[10].Cells[0].Value = "2.2. недоступна вартість реалізації програмного проекту";
            _dataGridView.Rows[11].Cells[0].Value =
                "2.3. низька ступінь реалізму при оцінюванні витрат на \n програмний проект;";
            _dataGridView.Rows[12].Cells[0].Value = "3. Множина джерел появи планових ризиків";
            _dataGridView.Rows[12].Cells[0].Style.Font = new Font(_dataGridView.DefaultCellStyle.Font, FontStyle.Bold);
            _dataGridView.Rows[13].Cells[0].Value =
                "3.1. властивості та можливості гнучкості внесення змін до планів життєвого циклу розроблення ПЗ,";
            _dataGridView.Rows[14].Cells[0].Value =
                "3.2. можливості порушення встановлених термінів реалізації етапів життєвого циклу розроблення ПЗ,";
            _dataGridView.Rows[15].Cells[0].Value =
                "3.3. низька ступінь реалізму при встановленні планів і етапів життєвого циклу розроблення ПЗ;";
            _dataGridView.Rows[16].Cells[0].Value =
                "4. Множина джерел появи ризиків реалізації процесу управління програмним проектом";
            _dataGridView.Rows[16].Cells[0].Style.Font = new Font(_dataGridView.DefaultCellStyle.Font, FontStyle.Bold);
            _dataGridView.Rows[17].Cells[0].Value = "4.1. хибна стратегія реалізації програмного проекту";
            _dataGridView.Rows[18].Cells[0].Value = "4.2. неефективне планування проекту розроблення ПЗ";
            _dataGridView.Rows[19].Cells[0].Value = "4.3. неякісне оцінювання програмного проекту";
            _dataGridView.Rows[20].Cells[0].Value = "4.4. прогалини в документуванні етапів реалізації програмного проекту";
            _dataGridView.Rows[21].Cells[0].Value =
                "4.5. промахи в прогнозуванні результатів реалізації програмного проекту";
            _dataGridView.Rows[22].Cells[0].Value = "Всього";
            _dataGridView.Rows[22].Cells[0].Style.Font = new Font(_dataGridView.DefaultCellStyle.Font, FontStyle.Bold);
            _dataGridView.Rows[22].Cells[0].ReadOnly = true;
            _dataGridView.Rows[22].Cells[1].ReadOnly = true;
            _dataGridView.Rows[22].Cells[2].ReadOnly = true;

            for (int i = 0; i < n; i++)
            {
                _dataGridView.Rows[i].Cells[0].ReadOnly = true;
                _dataGridView.Rows[i].Cells[2].ReadOnly = true;
            }

            for (int i = 0; i < 7; i++)
            {
                _dataGridView.Rows[i + 1].Cells[1].Value = 0;
                temp++;
            }

            _dataGridView.Rows[0].Cells[1].Value = temp;
            _dataGridView.Rows[0].Cells[1].ReadOnly = true;

            temp = 0;
            for (int i = 0; i < 3; i++)
            {
                _dataGridView.Rows[i + 9].Cells[1].Value = 0;
                _dataGridView.Rows[i + 13].Cells[1].Value = 0;
                temp++;
            }

            _dataGridView.Rows[8].Cells[1].Value = temp;
            _dataGridView.Rows[12].Cells[1].Value = temp;
            _dataGridView.Rows[8].Cells[1].ReadOnly = true;
            _dataGridView.Rows[12].Cells[1].ReadOnly = true;

            temp = 0;
            for (int i = 0; i < 5; i++)
            {
                _dataGridView.Rows[i + 17].Cells[1].Value = 0;
                temp++;
            }

            _dataGridView.Rows[16].Cells[1].Value = temp;
            _dataGridView.Rows[16].Cells[1].ReadOnly = true;

            RecountChangesTable1(0, 8, 12, 16, 22, _dataGridView);
        }

        public void RecountChangesTable1(int Req1, int Req2, int Req3, int Req4, int AllReq, DataGridView table)
        {
            var sum1 = 0;
            var sum2 = 0;
            var sum3 = 0;
            var sum4 = 0;
            var counts1 = Convert.ToInt32(table.Rows[Req1].Cells[1].Value);
            var counts2 = Convert.ToInt32(table.Rows[Req2].Cells[1].Value);
            var counts3 = Convert.ToInt32(table.Rows[Req3].Cells[1].Value);
            var counts4 = Convert.ToInt32(table.Rows[Req4].Cells[1].Value);

            for (int i = 0; i < AllReq; i++)
            {
                if (i == Req1 || i == Req2 || i == Req3 || i == Req4)
                {
                    continue;
                }

                try
                {
                    if (Convert.ToInt32(table.Rows[i].Cells[1].Value) != 0 &&
                        Convert.ToInt32(table.Rows[i].Cells[1].Value) != 1)
                    {
                        MessageBox.Show("Значення можуть бути лише або 1, або 0!", "Увага", MessageBoxButtons.OK);
                        table.Rows[i].Cells[1].Value = 1;
                        return;
                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex);
                    MessageBox.Show("Значення можуть бути лише цілого типу!", "Увага", MessageBoxButtons.OK);
                    table.Rows[i].Cells[1].Value = 1;
                    return;
                }
            }

            var counts = counts1 + counts2 + counts3 + counts4;

            for (int i = 0; i < counts1; i++)
            {
                sum1 += Convert.ToInt32(table.Rows[i + Req1 + 1].Cells[1].Value);
            }

            
            double percent1 = ((double)sum1 / (double)counts) * 100;
            table.Rows[Req1].Cells[2].Value = percent1.ToString("##.##") + " %";

            for (int i = 0; i < counts2; i++)
            {
                sum2 += Convert.ToInt32(table.Rows[i + Req2 + 1].Cells[1].Value);
            }

            var percent2 = ((double)sum2 / (double)counts) * 100;
            table.Rows[Req2].Cells[2].Value = percent2.ToString("##.##") + " %";

            for (int i = 0; i < counts3; i++)
            {
                sum3 += Convert.ToInt32(table.Rows[i + Req3 + 1].Cells[1].Value);
            }

            var percent3 = ((double)sum3 / (double)counts) * 100;
            table.Rows[Req3].Cells[2].Value = percent3.ToString("##.##") + " %";

            for (int i = 0; i < counts4; i++)
            {
                sum4 += Convert.ToInt32(table.Rows[i + Req4 + 1].Cells[1].Value);
            }

            var percent4 = ((double)sum4 / (double)counts) * 100;
            table.Rows[Req4].Cells[2].Value = percent4.ToString("##.##") + " %";
            sum1 = 0;
            sum2 = 0;
            sum3 = 0;
            sum4 = 0;

            table.Rows[AllReq].Cells[1].Value = counts;
            table.Rows[AllReq].Cells[2].Value = (percent1 + percent2 + percent3 + percent4).ToString("##.##") + " %";
        }

    }
}
