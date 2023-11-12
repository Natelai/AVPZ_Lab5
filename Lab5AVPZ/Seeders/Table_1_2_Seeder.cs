using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab5AVPZ.Seeders
{
    public class Table_1_2_Seeder
    {
        private DataGridView _dataGridView;

        public Table_1_2_Seeder(DataGridView dataGridView)
        {
            this._dataGridView = dataGridView;
        }

        public void Seed()
        {
            _dataGridView.Width = 705;
            _dataGridView.Height = 595;
            int temp = 0;
            int n = 46;

            _dataGridView.ColumnCount = 3;
            _dataGridView.Columns[0].Width = 500;
            _dataGridView.Columns[1].Width = 100;
            _dataGridView.Columns[2].Width = 100;
            for (int i = 0; i < n; i++)
                _dataGridView.Rows.Add();

            _dataGridView.Rows[0].Cells[0].Value = "1. Множина настання технічних ризикових подій";
            _dataGridView.Rows[0].Cells[0].Style.Font = new Font(_dataGridView.DefaultCellStyle.Font, FontStyle.Bold);
            _dataGridView.Rows[1].Cells[0].Value =
                "1.1. Затримки у постачанні обладнання, необхідного для підтримки процесу розроблення ПЗ";
            _dataGridView.Rows[2].Cells[0].Value =
                "1.2. Затримки у постачанні інструментальних засобів, необхідних для підтримки процесу розроблення ПЗ";
            _dataGridView.Rows[3].Cells[0].Value =
                "1.3. Небажання команди виконавців використовувати інструментальні засоби для підтримки процесу розроблення ПЗ";
            _dataGridView.Rows[4].Cells[0].Value =
                "1.4. Формування запитів на більш потужні інструментальні засоби розроблення ПЗ";
            _dataGridView.Rows[5].Cells[0].Value = "1.5. Відмова команди виконавців від CASE-засобів розроблення ПЗ";
            _dataGridView.Rows[6].Cells[0].Value =
                "1.6. Неефективність програмного коду, згенерованого CASE-засобами розроблення ПЗ";
            _dataGridView.Rows[7].Cells[0].Value =
                "1.7. Неможливість інтеграції CASE-засобів з іншими інструментальними засобами для підтримки процесу розроблення ПЗ";
            _dataGridView.Rows[8].Cells[0].Value =
                "1.8. Недостатня продуктивність баз(и) даних для підтримки процесу розроблення ПЗ";
            _dataGridView.Rows[9].Cells[0].Value =
                "1.9. Програмні компоненти, які використовують повторно в ПЗ, мають дефекти та обмежені функціональні можливості";
            _dataGridView.Rows[10].Cells[0].Value =
                "1.10. Швидкість виявлення дефектів у програмному коді є нижчою від раніше запланованих термінів";
            _dataGridView.Rows[11].Cells[0].Value =
                "1.11. Поява дефектних системних компонент, які використовують для розроблення ПЗ";
            _dataGridView.Rows[12].Cells[0].Value = "2.Множина настання вартісних ризикових подій";
            _dataGridView.Rows[12].Cells[0].Style.Font = new Font(_dataGridView.DefaultCellStyle.Font, FontStyle.Bold);
            _dataGridView.Rows[13].Cells[0].Value =
                "2.1. Недо(пере)оцінювання витрат на реалізацію програмного проекту (надмірно низька вартість)";
            _dataGridView.Rows[14].Cells[0].Value = "2.2. Фінансові ускладнення у компанії-замовника ПЗ";
            _dataGridView.Rows[15].Cells[0].Value = "2.3. фінансові ускладнення у компанії-розробника ПЗ";
            _dataGridView.Rows[16].Cells[0].Value =
                "2.4. Змен(збіль)шення бюджету програмного проекта з ініціативи компанії-замовника ПЗ під час його реалізації";
            _dataGridView.Rows[17].Cells[0].Value =
                "2.5. Висока вартість виконання повторних робіт, необхідних для зміни вимог до ПЗ";
            _dataGridView.Rows[18].Cells[0].Value = "2.6. Реорганізація структурних підрозділів у компанії-замовника ПЗ";
            _dataGridView.Rows[19].Cells[0].Value = "2.7. Реорганізація команди виконавців у компанії-розробника ПЗ";
            _dataGridView.Rows[20].Cells[0].Value = "3. Множина настання планових ризикових подій";
            _dataGridView.Rows[20].Cells[0].Style.Font = new Font(_dataGridView.DefaultCellStyle.Font, FontStyle.Bold);
            _dataGridView.Rows[21].Cells[0].Value = "3.1.  зміни графіка виконання робіт з боку замовника чи розробника ПЗ";
            _dataGridView.Rows[22].Cells[0].Value =
                "3.2.   порушення графіка виконання робіт з боку компанії-розробника ПЗ;";
            _dataGridView.Rows[23].Cells[0].Value =
                "3.3.   потреба зміни користувацьких вимог до ПЗ з боку компанії-замовника ПЗ";
            _dataGridView.Rows[24].Cells[0].Value =
                "3.4.   потреба зміни функціональних вимог до ПЗ з боку компанії-розробника ПЗ";
            _dataGridView.Rows[25].Cells[0].Value =
                "3.5.   потреба виконання великої кількості повторних робіт, необхідних для зміни вимог до ПЗ";
            _dataGridView.Rows[26].Cells[0].Value =
                "3.6. недо(пере)оцінювання тривалості етапів реалізації програмного проекту з боку компанії-замовника ПЗ";
            _dataGridView.Rows[27].Cells[0].Value =
                "3.7.   остаточний розмір ПЗ значно перевищує (менший від) заплановані(их) його характеристики";
            _dataGridView.Rows[28].Cells[0].Value = "3.8.   поява на ринку аналогічного ПЗ до виходу замовленого";
            _dataGridView.Rows[29].Cells[0].Value = "3.9.   поява на ринку більш конкурентоздатного ПЗ";
            _dataGridView.Rows[30].Cells[0].Value =
                "4. Множина настання ризикових подій реалізації процесу управління програмним проектом";
            _dataGridView.Rows[30].Cells[0].Style.Font = new Font(_dataGridView.DefaultCellStyle.Font, FontStyle.Bold);
            _dataGridView.Rows[31].Cells[0].Value = "4.1.   низький моральний стан персоналу команди виконавців ПЗ";
            _dataGridView.Rows[32].Cells[0].Value = "4.2.   низька взаємодія між членами команди виконавців ПЗ";
            _dataGridView.Rows[33].Cells[0].Value = "4.3.   пасивність керівника (менеджера) програмного проекту";
            _dataGridView.Rows[34].Cells[0].Value =
                "4.4.   недостатня компетентність керівника (менеджера) програмного проекту";
            _dataGridView.Rows[35].Cells[0].Value =
                "4.5.   незадоволеність замовника результатами етапів реалізації програмного проекту";
            _dataGridView.Rows[36].Cells[0].Value =
                "4.6.   недостатня кількість фахівців у команді виконавців ПЗ з необхідним професійним рівнем";
            _dataGridView.Rows[37].Cells[0].Value =
                "4.7.   хвороба провідного виконавця в найкритичніший момент розроблення ПЗ";
            _dataGridView.Rows[38].Cells[0].Value = "4.8.   одночасна хвороба декількох виконавців підчас розроблення ПЗ";
            _dataGridView.Rows[39].Cells[0].Value =
                "4.9.   неможливість організації необхідного навчання персоналу команди виконавців ПЗ";
            _dataGridView.Rows[40].Cells[0].Value = "4.10.   зміна пріоритетів у процесі управління програмним проектом";
            _dataGridView.Rows[41].Cells[0].Value =
                "4.11. недо(пере)оцінювання необхідної кількості розробників (підрядників і субпідрядників) на етапах життєвого циклу розроблення ПЗ";
            _dataGridView.Rows[42].Cells[0].Value =
                "4.12. недостатнє (надмірне) документування результатів на етапах реалізації програмного проекту";
            _dataGridView.Rows[43].Cells[0].Value =
                "4.13.   нереалістичне прогнозування результатів на етапах реалізації програмного проекту";
            _dataGridView.Rows[44].Cells[0].Value =
                "4.14.   недостатній професійний рівень представників від компанії-замовника ПЗ";
            _dataGridView.Rows[45].Cells[0].Value = "Всього";
            _dataGridView.Rows[45].Cells[0].Style.Font = new Font(_dataGridView.DefaultCellStyle.Font, FontStyle.Bold);
            _dataGridView.Rows[45].Cells[0].ReadOnly = true;
            _dataGridView.Rows[45].Cells[1].ReadOnly = true;
            _dataGridView.Rows[45].Cells[2].ReadOnly = true;

            temp = 0;

            for (int i = 0; i < n; i++)
            {
                _dataGridView.Rows[i].Cells[0].ReadOnly = true;
                _dataGridView.Rows[i].Cells[2].ReadOnly = true;
            }

            for (int i = 0; i < 11; i++)
            {
                _dataGridView.Rows[i + 1].Cells[1].Value = 1;
                temp++;
            }

            _dataGridView.Rows[0].Cells[1].Value = temp;
            _dataGridView.Rows[0].Cells[1].ReadOnly = true;

            temp = 0;

            for (int i = 0; i < 7; i++)
            {
                _dataGridView.Rows[i + 13].Cells[1].Value = 1;
                temp++;
            }

            _dataGridView.Rows[12].Cells[1].Value = temp;
            _dataGridView.Rows[12].Cells[1].ReadOnly = true;

            temp = 0;

            for (int i = 0; i < 9; i++)
            {
                _dataGridView.Rows[i + 21].Cells[1].Value = 1;
                temp++;
            }

            _dataGridView.Rows[20].Cells[1].Value = temp;
            _dataGridView.Rows[20].Cells[1].ReadOnly = true;

            temp = 0;

            for (int i = 0; i < 14; i++)
            {
                _dataGridView.Rows[i + 31].Cells[1].Value = 1;
                temp++;
            }

            _dataGridView.Rows[30].Cells[1].Value = temp;
            _dataGridView.Rows[30].Cells[1].ReadOnly = true;

            RecountChangesTable1(0, 12, 20, 30, 45, _dataGridView);
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
