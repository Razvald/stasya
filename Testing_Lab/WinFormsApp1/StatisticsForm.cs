using System.Data;

namespace WinFormsApp1
{
    public partial class StatisticsForm : Form
    {
        public StatisticsForm()
        {
            InitializeComponent();
            LoadAnalistic();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close(); // Закрытие формы
        }

        private void LoadAnalistic()
        {
            // Создание DataTable для статистики
            DataTable statisticsTable = new DataTable();
            statisticsTable.Columns.Add("Статистика", typeof(string));
            statisticsTable.Columns.Add("Значение", typeof(string));

            // Добавление данных о статистике
            statisticsTable.Rows.Add("Общее количество заявок", DatabaseHelper.GetTotalRequests().ToString());
            statisticsTable.Rows.Add("Средняя стоимость выполнения", DatabaseHelper.GetAverageCost().ToString("F2"));

            // Пример добавления дополнительной статистики
            statisticsTable.Rows.Add("Максимальная стоимость", DatabaseHelper.GetMaxCost().ToString("F2"));
            statisticsTable.Rows.Add("Минимальная стоимость", DatabaseHelper.GetMinCost().ToString("F2"));

            // Установка источника данных для DataGridView
            dataGridView1.DataSource = statisticsTable;
        }
    }
}
