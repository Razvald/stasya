namespace WinFormsApp1
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var login = LoginTxt.Text;
            var password = PasswordTxt.Text;

            var userId = DatabaseHelper.TryAuth(login, password);
            if (userId.HasValue)
            {
                var mainForm = new MainForm(userId.Value);
                Hide();
                mainForm.ShowDialog();
                Show();
            }
            else
            {
                MessageBox.Show("Неправильный логин или пароль.");
            }
        }
    }
}
