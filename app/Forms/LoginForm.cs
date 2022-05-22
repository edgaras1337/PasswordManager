using app.EncryptionHelpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(usernameInput.Text) || string.IsNullOrEmpty(passwordInput.Text))
            {
                MessageBox.Show("Fill out all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var accountFilePath = FileManager.CreateAccountFilePath(usernameInput.Text);
            var encAccountFilePath = FileManager.CreateAccountEncFilePath(usernameInput.Text);

            if (!File.Exists(encAccountFilePath))
            {
                MessageBox.Show("Incorrect username or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            AESHelper.DecryptFile(encAccountFilePath, accountFilePath);

            var userDetails = File.ReadAllLines(accountFilePath).First().Split(',');


            //if (userDetails[0] != usernameInput.Text || userDetails[1] != passwordInput.Text)
            if (userDetails[0] != usernameInput.Text || 
                !BCrypt.Net.BCrypt.Verify(passwordInput.Text, userDetails[1]))
            {
                MessageBox.Show("Incorrect username or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //AesHelper.EncryptFile(encAccountFilePath, accountFilePath);
                
                return;
            }

            ApplicationUser.Name = userDetails[0];
            ApplicationUser.Password = userDetails[1];
            ApplicationUser.AccountFilePath = accountFilePath;
            ApplicationUser.AccountFilePathEnc = accountFilePath.Replace(".csv", ".enc");

            

            FormManager.MainForm = new MainForm();
            FormManager.MainForm.Show();

            this.Hide();

            usernameInput.Clear();
            passwordInput.Clear();
        }

        private void registerLink_Click(object sender, EventArgs e)
        {
            this.Hide();

            FormManager.RegisterForm = new RegisterForm();
            FormManager.RegisterForm.Show();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            passwordInput.UseSystemPasswordChar = true;
        }
    }
}
