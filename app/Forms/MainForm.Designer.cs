namespace app.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.generateBtn = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.showPassword = new System.Windows.Forms.CheckBox();
            this.clearFieldsBtn = new System.Windows.Forms.Button();
            this.savePasswordBtn = new System.Windows.Forms.Button();
            this.commentTxt = new System.Windows.Forms.TextBox();
            this.applicationTxt = new System.Windows.Forms.TextBox();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.searchInput = new System.Windows.Forms.TextBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.nameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailsCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Password Manager";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(151, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name *";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(130, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password *";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Application/URL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(126, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Comment";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 57);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(829, 396);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.generateBtn);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.showPassword);
            this.tabPage1.Controls.Add(this.clearFieldsBtn);
            this.tabPage1.Controls.Add(this.savePasswordBtn);
            this.tabPage1.Controls.Add(this.commentTxt);
            this.tabPage1.Controls.Add(this.applicationTxt);
            this.tabPage1.Controls.Add(this.passwordTxt);
            this.tabPage1.Controls.Add(this.nameTxt);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(821, 363);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // generateBtn
            // 
            this.generateBtn.AutoSize = true;
            this.generateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.generateBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.generateBtn.Location = new System.Drawing.Point(352, 88);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(121, 20);
            this.generateBtn.TabIndex = 14;
            this.generateBtn.Text = "Generate for Me!";
            this.generateBtn.Click += new System.EventHandler(this.generateBtn_Click);
            this.generateBtn.MouseEnter += new System.EventHandler(this.generateBtn_MouseEnter);
            this.generateBtn.MouseLeave += new System.EventHandler(this.generateBtn_MouseLeave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label7.Location = new System.Drawing.Point(375, 322);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Unique Fields";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(352, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "* Required Fields";
            // 
            // showPassword
            // 
            this.showPassword.AutoSize = true;
            this.showPassword.Location = new System.Drawing.Point(601, 247);
            this.showPassword.Name = "showPassword";
            this.showPassword.Size = new System.Drawing.Size(132, 24);
            this.showPassword.TabIndex = 11;
            this.showPassword.Text = "Show Password";
            this.showPassword.UseVisualStyleBackColor = true;
            this.showPassword.CheckedChanged += new System.EventHandler(this.showPassword_CheckedChanged);
            // 
            // clearFieldsBtn
            // 
            this.clearFieldsBtn.Location = new System.Drawing.Point(619, 177);
            this.clearFieldsBtn.Name = "clearFieldsBtn";
            this.clearFieldsBtn.Size = new System.Drawing.Size(94, 29);
            this.clearFieldsBtn.TabIndex = 10;
            this.clearFieldsBtn.Text = "Clear fields";
            this.clearFieldsBtn.UseVisualStyleBackColor = true;
            this.clearFieldsBtn.Click += new System.EventHandler(this.clearFieldsBtn_Click);
            // 
            // savePasswordBtn
            // 
            this.savePasswordBtn.BackColor = System.Drawing.Color.Transparent;
            this.savePasswordBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.savePasswordBtn.Location = new System.Drawing.Point(601, 111);
            this.savePasswordBtn.Name = "savePasswordBtn";
            this.savePasswordBtn.Size = new System.Drawing.Size(131, 32);
            this.savePasswordBtn.TabIndex = 9;
            this.savePasswordBtn.Text = "Save Password";
            this.savePasswordBtn.UseVisualStyleBackColor = false;
            this.savePasswordBtn.Click += new System.EventHandler(this.savePasswordBtn_Click);
            // 
            // commentTxt
            // 
            this.commentTxt.Location = new System.Drawing.Point(258, 249);
            this.commentTxt.Name = "commentTxt";
            this.commentTxt.Size = new System.Drawing.Size(215, 27);
            this.commentTxt.TabIndex = 8;
            // 
            // applicationTxt
            // 
            this.applicationTxt.Location = new System.Drawing.Point(258, 182);
            this.applicationTxt.Name = "applicationTxt";
            this.applicationTxt.Size = new System.Drawing.Size(215, 27);
            this.applicationTxt.TabIndex = 7;
            // 
            // passwordTxt
            // 
            this.passwordTxt.Location = new System.Drawing.Point(258, 111);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(215, 27);
            this.passwordTxt.TabIndex = 6;
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(258, 42);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(215, 27);
            this.nameTxt.TabIndex = 5;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.searchInput);
            this.tabPage2.Controls.Add(this.dgv);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(821, 363);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(544, 15);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label9.Size = new System.Drawing.Size(271, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "To see decrypted password, go to Details.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Search by Name";
            // 
            // searchInput
            // 
            this.searchInput.Location = new System.Drawing.Point(138, 8);
            this.searchInput.Name = "searchInput";
            this.searchInput.Size = new System.Drawing.Size(204, 27);
            this.searchInput.TabIndex = 1;
            this.searchInput.TextChanged += new System.EventHandler(this.searchInput_TextChanged);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameCol,
            this.passwordCol,
            this.appCol,
            this.commentCol,
            this.detailsCol});
            this.dgv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv.Location = new System.Drawing.Point(6, 44);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 29;
            this.dgv.Size = new System.Drawing.Size(809, 316);
            this.dgv.TabIndex = 0;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // nameCol
            // 
            this.nameCol.HeaderText = "Name";
            this.nameCol.MinimumWidth = 6;
            this.nameCol.Name = "nameCol";
            this.nameCol.Width = 125;
            // 
            // passwordCol
            // 
            this.passwordCol.HeaderText = "Encrypted Password";
            this.passwordCol.MinimumWidth = 6;
            this.passwordCol.Name = "passwordCol";
            this.passwordCol.Width = 125;
            // 
            // appCol
            // 
            this.appCol.HeaderText = "Application/URL";
            this.appCol.MinimumWidth = 6;
            this.appCol.Name = "appCol";
            this.appCol.Width = 125;
            // 
            // commentCol
            // 
            this.commentCol.HeaderText = "Comment";
            this.commentCol.MinimumWidth = 6;
            this.commentCol.Name = "commentCol";
            this.commentCol.Width = 125;
            // 
            // detailsCol
            // 
            this.detailsCol.HeaderText = "Details";
            this.detailsCol.MinimumWidth = 6;
            this.detailsCol.Name = "detailsCol";
            this.detailsCol.Text = "See Details";
            this.detailsCol.ToolTipText = "See Details";
            this.detailsCol.Width = 125;
            // 
            // logoutBtn
            // 
            this.logoutBtn.Location = new System.Drawing.Point(743, 14);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(94, 29);
            this.logoutBtn.TabIndex = 6;
            this.logoutBtn.Text = "Log out";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 465);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(871, 512);
            this.MinimumSize = new System.Drawing.Size(871, 512);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button clearFieldsBtn;
        private Button savePasswordBtn;
        private TextBox commentTxt;
        private TextBox applicationTxt;
        private TextBox passwordTxt;
        private TextBox nameTxt;
        private CheckBox showPassword;
        private Label label6;
        private Label label7;
        private Label generateBtn;
        private DataGridView dgv;
        private Label label8;
        private TextBox searchInput;
        private Label label9;
        private DataGridViewTextBoxColumn nameCol;
        private DataGridViewTextBoxColumn passwordCol;
        private DataGridViewTextBoxColumn appCol;
        private DataGridViewTextBoxColumn commentCol;
        private DataGridViewButtonColumn detailsCol;
        private Button logoutBtn;
    }
}