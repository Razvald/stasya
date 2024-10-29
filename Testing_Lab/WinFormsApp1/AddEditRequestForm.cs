namespace WinFormsApp1
{
    public partial class AddEditRequestForm : Form
    {
        public class Client
        {
            public int ClientID { get; set; }
            public string ClientName { get; set; }
        }

        public class Equipment
        {
            public int EquipmentID { get; set; }
            public string EquipmentName { get; set; }
        }

        private readonly int _userId;

        public AddEditRequestForm(int userId)
        {
            InitializeComponent();
            _userId = userId;
            LoadClients();
            LoadEquipment();
        }

        private void LoadClients()
        {
            ClientCmb.DataSource = DatabaseHelper.GetClients();
            ClientCmb.DisplayMember = "ClientName";
            ClientCmb.ValueMember = "ClientID";
        }

        private void LoadEquipment()
        {
            EquipCmb.DataSource = DatabaseHelper.GetEquipment();
            EquipCmb.DisplayMember = "EquipmentName";
            EquipCmb.ValueMember = "EquipmentID";
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var requestId = (int)DatabaseHelper.GetLastIndex() + 1; // Увеличиваем ID на 1
            var newRequest = new
            {
                Client = (int)ClientCmb.SelectedValue,
                Priority = PriorityTxt.Text,
                DateAdded = DateTime.Today,
                Equipment = (int)EquipCmb.SelectedValue,
                IssueType = ProblemTxt.Text,
                Description = DescriptionTxt.Text,
                Manager = _userId,
                FaultReason = ReasonTxt.Text,
                Cost = decimal.TryParse(CostTxt.Text, out var parsedCost) ? parsedCost : 0
            };

            DatabaseHelper.AddRequest(requestId, newRequest.Client, newRequest.Priority, newRequest.DateAdded, newRequest.Equipment,
                                       newRequest.IssueType, newRequest.Description, newRequest.Manager, newRequest.FaultReason, newRequest.Cost);

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
