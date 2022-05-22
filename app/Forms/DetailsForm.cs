using app.EncryptionHelpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace app.Forms
{
    public partial class DetailsForm : Form
    {
        private PasswordContent _passwordContent;
        public DetailsForm(PasswordContent passwordContent)
        {
            InitializeComponent();

            _passwordContent = passwordContent;
        }

        private void DetailsForm_Load(object sender, EventArgs e)
        {
            nameTxt.Text = _passwordContent.Name;
            passwordTxt.Text = RSAHelper.DecryptPassword(_passwordContent.Password!);
            applicationTxt.Text = _passwordContent.Application;
            commentTxt.Text = _passwordContent.Comment;

            toolTip1.SetToolTip(copyLabel, "Copied!");
            toolTip1.Active = false;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(passwordTxt.Text))
            {
                MessageBox.Show("Please enter the password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var sb = new StringBuilder();
            sb.Append(ApplicationUser.StaticToString());

            var content = FileManager.ReadPasswords(ApplicationUser.AccountFilePath!);

            var toChange = content.FirstOrDefault(e => e.Name == nameTxt.Text);
            toChange!.Password = RSAHelper.EncryptPassword(passwordTxt.Text);
            toChange.Application = applicationTxt.Text;
            toChange.Comment = commentTxt.Text;

            content.ForEach(x => sb.Append(x.ToString()));

            File.WriteAllText(ApplicationUser.AccountFilePath!, sb.ToString());

            this.Close();

            MessageBox.Show("Changes have been saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Are you sure you want to exit without saving?\nAll changes will be lost.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.No) return;
            this.Close();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Are you sure you want to delete this password?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.No) return;

            var sb = new StringBuilder();
            sb.Append(ApplicationUser.StaticToString());

            var content = FileManager.ReadPasswords(ApplicationUser.AccountFilePath!);

            content.Remove(content.FirstOrDefault(e => e.Name == nameTxt.Text)!);

            content.ForEach(x => sb.Append(x.ToString()));

            File.WriteAllText(ApplicationUser.AccountFilePath!, sb.ToString());

            this.Close();
        }

        private void copyLabel_MouseEnter(object sender, EventArgs e)
        {
            var italic = FontStyle.Italic;
            var underlineItalic = italic |= FontStyle.Underline;
            copyLabel.Font = new Font(copyLabel.Font, underlineItalic);
        }

        private void copyLabel_MouseLeave(object sender, EventArgs e)
        {
            copyLabel.Font = new Font(copyLabel.Font, FontStyle.Italic);
        }

        private void copyLabel_Click(object sender, EventArgs e)
        {
            toolTip1.Active = true;
            toolTip1.Show(toolTip1.GetToolTip(copyLabel), copyLabel);

            Clipboard.SetText(passwordTxt.Text);

            var timer = new System.Timers.Timer();
            timer.Elapsed += new ElapsedEventHandler(OnTimedEvent!);
            timer.Interval = 10000;
            timer.Enabled = true;
        }

        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            toolTip1.Active = false;
        }
    }
}
