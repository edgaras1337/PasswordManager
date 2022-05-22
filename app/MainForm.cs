using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app
{
    public partial class MainForm : Form
    {
        private List<PasswordContent> _passwords = FileManager.ReadPasswords(ApplicationUser.AccountFilePath!);
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            tabControl1.TabPages[0].Text = "Add Password";
            tabControl1.TabPages[1].Text = "View Passwords";

            // 1st tab
            passwordTxt.UseSystemPasswordChar = true;

            // 2nd tab
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            var width = dgv.Width;
            nameCol.Width = (int)(width * 0.17);
            passwordCol.Width = (int)(width * 0.20);
            detailsCol.Width = (int)(width * 0.12);

            UpdateGrid();

            this.FormClosed += new FormClosedEventHandler(OnFormClosed!);
        }

        private void OnFormClosed(object sender, EventArgs e)
        {
            AESHelper.EncryptFile(ApplicationUser.AccountFilePath!, ApplicationUser.AccountFilePathEnc!);
            ApplicationUser.LogOut();

            FormManager.LoginForm!.Show();
        }

        private void savePasswordBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameTxt.Text) || string.IsNullOrEmpty(passwordTxt.Text))
            {
                MessageBox.Show("Fill out all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var password = new PasswordContent
            {
                Name = nameTxt.Text,
                Password = RSAHelper.EncryptPassword(passwordTxt.Text),
                Application = applicationTxt.Text,
                Comment = commentTxt.Text,
            };

            var filePath = ApplicationUser.AccountFilePath!;
            var passwords = FileManager.ReadPasswords(filePath);

            foreach (var pwd in passwords)
            {
                if (pwd.Name == password.Name)
                {
                    MessageBox.Show("Name is not unique! Please pick another name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            File.AppendAllText(filePath, password.ToString());


            MessageBox.Show("Password saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearFields();
            UpdateGrid();  
        }

        private void showPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (showPassword.Checked)
            {
                passwordTxt.UseSystemPasswordChar = false;
            }
            else
            {
                passwordTxt.UseSystemPasswordChar = true;
            }
        }
        private void generateBtn_MouseEnter(object sender, EventArgs e)
        {
            generateBtn.Font = new Font(generateBtn.Font, FontStyle.Underline);
        }

        private void generateBtn_MouseLeave(object sender, EventArgs e)
        {
            generateBtn.Font = new Font(generateBtn.Font, FontStyle.Regular);
        }

        private void ClearFields()
        {
            nameTxt.Clear();
            passwordTxt.Clear();
            applicationTxt.Clear();
            commentTxt.Clear();
        }

        private void generateBtn_Click(object sender, EventArgs e)
        {
            int length = 8 + new Random().Next(10);

            passwordTxt.Text = CreatePassword(length);

            showPassword.Checked = true;
        }

        public static string CreatePassword(int length)
        {
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            var res = new StringBuilder();
            var rnd = new Random();
            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.ColumnIndex == dgv.Columns[4].Index && e.RowIndex >= 0)
            {
                var row = dgv.Rows[e.RowIndex];

                var password = _passwords.FirstOrDefault(e => e.Name == row.Cells[0].Value.ToString());

                var detailsForm = new DetailsForm(password!);
                detailsForm.Show();

                detailsForm.FormClosed += new FormClosedEventHandler(OnDetailFormClose!);
            }
        }

        private void OnDetailFormClose(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void searchInput_TextChanged(object sender, EventArgs e)
        {
            var txt = searchInput.Text;

            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.IsNewRow) continue;

                var value = row.Cells[0]?.Value?.ToString();
                if (value != null && value.Contains(txt))
                {
                    row.Visible = true;
                }
                else
                {
                    row.Visible = false;
                }
            }
        }

        private void UpdateGrid()
        {
            _passwords = FileManager.ReadPasswords(ApplicationUser.AccountFilePath!);
            dgv.Rows.Clear();
            foreach (var pwd in _passwords)
            {
                // name, pwd, show, app comm
                dgv.Rows.Add(pwd.Name, pwd.Password, pwd.Application, pwd.Comment, "See Details");
            }
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Are you sure you want to log out?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (res == DialogResult.No) return;

            this.Close();
        }
    }
}
