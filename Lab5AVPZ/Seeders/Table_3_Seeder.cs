using System.Drawing;
using System.Windows.Forms;

namespace Lab5AVPZ.Seeders
{
    public class Table_3_Seeder
    {
        private DataGridView _dataGridView;

        public Table_3_Seeder(DataGridView dataGridView)
        {
            _dataGridView = dataGridView;
        }

        public void Seed()
        {
            
            int n = 20;

            _dataGridView.Width = 905;
            _dataGridView.Height = 595;
            _dataGridView.ColumnCount = 5;
            _dataGridView.Columns[0].Width = 500;
            _dataGridView.Columns[1].Width = 100;
            _dataGridView.Columns[2].Width = 100;
            _dataGridView.Columns[1].Width = 100;
            _dataGridView.Columns[2].Width = 100;
            for (int i = 0; i < n; i++)
                _dataGridView.Rows.Add();

            _dataGridView.Rows[0].Cells[0].Value = "Назва заходів";
            _dataGridView.Rows[0].Cells[0].Style.Font = new Font(_dataGridView.DefaultCellStyle.Font, FontStyle.Bold);
            _dataGridView.Rows[1].Cells[0].Value = "1. Попереднє навчання членів проектного колективу";
            _dataGridView.Rows[2].Cells[0].Value = "2. Узгодження детального переліку вимог до ПЗ із замовником";
            _dataGridView.Rows[3].Cells[0].Value = "3. Внесення узгодженого переліку вимог до ПЗ замовника в договір";
            _dataGridView.Rows[4].Cells[0].Value =
                "4. Точне слідування вимогам замовника з узгодженого переліку вимог до ПЗ";
            _dataGridView.Rows[5].Cells[0].Value = "5. Попередні дослідження ринку";
            _dataGridView.Rows[6].Cells[0].Value =
                "6. Експертна оцінка програмного проекту досвідченим стороннім консультантом";
            _dataGridView.Rows[7].Cells[0].Value = "7. Консультації досвідченого стороннього консультанта";
            _dataGridView.Rows[8].Cells[0].Value = "8. Тренінг з вивчення необхідних інструментів розроблення ПЗ";
            _dataGridView.Rows[9].Cells[0].Value = "9. Укладання договору страхування";
            _dataGridView.Rows[10].Cells[0].Value =
                "10. Використання \"шаблонних\" рішень з вдалих попередніх проектів при управлінні програмним проектом";
            _dataGridView.Rows[11].Cells[0].Value =
                "11. Підготовка документів, які показують важливість даного проекту для досягнення фінансових цілей компанії-розробника";
            _dataGridView.Rows[12].Cells[0].Value =
                "12. Реорганізація роботи проектного колективу так, щоб обов\'язки та робота членів колективу перекривали один одного";
            _dataGridView.Rows[13].Cells[0].Value =
                "13. Придбання (замовлення) частини компонент розроблюваного ПЗ";
            _dataGridView.Rows[14].Cells[0].Value =
                "14. Заміна потенційно дефектних компонент розроблюваного ПЗ придбаними компонентами, які гарантують якість виконання роботи";
            _dataGridView.Rows[15].Cells[0].Value =
                "15. Придбання більш продуктивної бази даних";
            _dataGridView.Rows[16].Cells[0].Value =
                "16. Використання генератора програмного коду";
            _dataGridView.Rows[17].Cells[0].Value =
                "17. Реорганізація роботи проектного колективу залежно від рівня труднощів виконання завдань та професійних рівнів розробників";
            _dataGridView.Rows[18].Cells[0].Value =
                "18. Повторне використання придатних компонент ПЗ, які були розроблені для інших програмних проектів";
            _dataGridView.Rows[19].Cells[0].Value = "19. Аналіз доцільності розроблення даного ПЗ";
            _dataGridView.Rows[0].Cells[1].Style.Font = new Font(_dataGridView.DefaultCellStyle.Font, FontStyle.Bold);
            _dataGridView.Rows[0].Cells[2].Style.Font = new Font(_dataGridView.DefaultCellStyle.Font, FontStyle.Bold);
            _dataGridView.Rows[0].Cells[3].Style.Font = new Font(_dataGridView.DefaultCellStyle.Font, FontStyle.Bold);
            _dataGridView.Rows[0].Cells[4].Style.Font = new Font(_dataGridView.DefaultCellStyle.Font, FontStyle.Bold);
            _dataGridView.Rows[0].Cells[1].Value = "Пом'якшення";
            _dataGridView.Rows[0].Cells[2].Value = "Прийняття";
            _dataGridView.Rows[0].Cells[3].Value = "Ухилення";
            _dataGridView.Rows[0].Cells[4].Value = "Передача";

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < _dataGridView.ColumnCount - 1; j++)
                {
                    _dataGridView.Rows[i + 1].Cells[j + 1].Value = "0";
                }
            }

            /*lowLevelBefore.Text = lowLevel.Text;
            MediumLevelBefore.Text = mediumLevel.Text;
            HighLevelBefore.Text = highLevel.Text;*/
        }
    }
}
