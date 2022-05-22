using System.Diagnostics;

namespace app
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            this.FormClosed += new FormClosedEventHandler((sender, e) =>
            {
                if (FormManager.MainForm == null)
                {
                    FormManager.LoginForm!.Show();
                }
            });

            passwordInput.UseSystemPasswordChar = true;
            pRepeatInput.UseSystemPasswordChar = true;
        }

        private void regBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(usernameInput.Text) || 
                string.IsNullOrEmpty(passwordInput.Text) || 
                string.IsNullOrEmpty(pRepeatInput.Text))
            {
                MessageBox.Show("Fill out all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (passwordInput.Text != pRepeatInput.Text)
            {
                MessageBox.Show("Passwords do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var accountFile = FileManager.CreateAccountFilePath(usernameInput.Text);
            var encAccountFile = FileManager.CreateAccountEncFilePath(usernameInput.Text);
            if (File.Exists(encAccountFile))
            {
                MessageBox.Show("Username is already taken!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ApplicationUser.Name = usernameInput.Text;
            //ApplicationUser.Password = passwordInput.Text;
            ApplicationUser.Password = BCrypt.Net.BCrypt.HashPassword(passwordInput.Text);
            ApplicationUser.AccountFilePath = accountFile;
            ApplicationUser.AccountFilePathEnc = encAccountFile;

            string line = ApplicationUser.StaticToString();

            File.WriteAllText(accountFile, line);

            FormManager.MainForm = new MainForm();
            FormManager.MainForm.Show();

            this.Close();
        }

        private void loginLink_Click(object sender, EventArgs e)
        {
            FormManager.LoginForm!.Show();
            this.Close();
        }
    }
}