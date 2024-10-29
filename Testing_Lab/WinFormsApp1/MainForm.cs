namespace WinFormsApp1
{
    public partial class MainForm : Form
    {
        private readonly int _userId;

        public MainForm(int userId)
        {
            InitializeComponent();
            _userId = userId; // сохраняем ID авторизованного пользователя
            LoadRequests();
        }

        private void LoadRequests(string search = "")
        {
            dataGridView1.DataSource = DatabaseHelper.GetRequests(search);
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            LoadRequests(SearchBox.Text);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            using AddEditRequestForm addForm = new(_userId);
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                LoadRequests(); // Перезагружаем данные после добавления новой заявки
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            int requestId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Номер"].Value);
            int client = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Клиент"].Value);
            string priority = dataGridView1.CurrentRow.Cells["Приоритет"].Value.ToString();
            DateTime dateAdded = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["Дата добавления"].Value);
            int equipment = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Оборудование"].Value);
            string issueType = dataGridView1.CurrentRow.Cells["Тип неисправности"].Value.ToString();
            string description = dataGridView1.CurrentRow.Cells["Описание проблемы"].Value.ToString();
            int manager = _userId;
            string faultReason = dataGridView1.CurrentRow.Cells["Причина неисправности"].Value.ToString();
            decimal cost = Convert.ToDecimal(dataGridView1.CurrentRow.Cells["Стоимость выполнения"].Value);

            DatabaseHelper.UpdateRequest(requestId, client, priority, dateAdded, equipment, issueType, description, manager, faultReason, cost);
            LoadRequests();
        }

        private void AnaliticButton_Click(object sender, EventArgs e)
        {
            using StatisticsForm addForm = new();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                LoadRequests(); // Перезагружаем данные после добавления новой заявки
            }
        }
    }
}