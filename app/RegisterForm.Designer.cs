namespace app
{
    partial class RegisterForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.heading = new System.Windows.Forms.Label();
            this.usernameInput = new System.Windows.Forms.TextBox();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.regPanel = new System.Windows.Forms.Panel();
            this.pRepeatInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.regBtn = new System.Windows.Forms.Button();
            this.loginLink = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.regPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // heading
            // 
            this.heading.AutoSize = true;
            this.heading.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.heading.Location = new System.Drawing.Point(304, 12);
            this.heading.Name = "heading";
            this.heading.Size = new System.Drawing.Size(125, 41);
            this.heading.TabIndex = 0;
            this.heading.Text = "Register";
            // 
            // usernameInput
            // 
            this.usernameInput.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usernameInput.Location = new System.Drawing.Point(6, 29);
            this.usernameInput.Name = "usernameInput";
            this.usernameInput.Size = new System.Drawing.Size(240, 30);
            this.usernameInput.TabIndex = 1;
            // 
            // passwordInput
            // 
            this.passwordInput.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordInput.Location = new System.Drawing.Point(6, 104);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.Size = new System.Drawing.Size(240, 30);
            this.passwordInput.TabIndex = 2;
            // 
            // regPanel
            // 
            this.regPanel.Controls.Add(this.pRepeatInput);
            this.regPanel.Controls.Add(this.usernameInput);
            this.regPanel.Controls.Add(this.passwordInput);
            this.regPanel.Location = new System.Drawing.Point(255, 97);
            this.regPanel.Name = "regPanel";
            this.regPanel.Size = new System.Drawing.Size(253, 226);
            this.regPanel.TabIndex = 3;
            // 
            // pRepeatInput
            // 
            this.pRepeatInput.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pRepeatInput.Location = new System.Drawing.Point(6, 174);
            this.pRepeatInput.Name = "pRepeatInput";
            this.pRepeatInput.Size = new System.Drawing.Size(240, 30);
            this.pRepeatInput.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(149, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(145, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username";
            // 
            // regBtn
            // 
            this.regBtn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.regBtn.Location = new System.Drawing.Point(293, 344);
            this.regBtn.Name = "regBtn";
            this.regBtn.Size = new System.Drawing.Size(165, 34);
            this.regBtn.TabIndex = 4;
            this.regBtn.Text = "Register";
            this.regBtn.UseVisualStyleBackColor = true;
            this.regBtn.Click += new System.EventHandler(this.regBtn_Click);
            // 
            // loginLink
            // 
            this.loginLink.Location = new System.Drawing.Point(12, 12);
            this.loginLink.Name = "loginLink";
            this.loginLink.Size = new System.Drawing.Size(94, 29);
            this.loginLink.TabIndex = 5;
            this.loginLink.Text = "Login";
            this.loginLink.UseVisualStyleBackColor = true;
            this.loginLink.Click += new System.EventHandler(this.loginLink_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Repeat Password";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.loginLink);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.regBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.regPanel);
            this.Controls.Add(this.heading);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(725, 497);
            this.MinimumSize = new System.Drawing.Size(725, 497);
            this.Name = "RegisterForm";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.regPanel.ResumeLayout(false);
            this.regPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label heading;
        private TextBox usernameInput;
        private TextBox passwordInput;
        private Panel regPanel;
        private Label label2;
        private Label label1;
        private Button regBtn;
        private Button loginLink;
        private TextBox pRepeatInput;
        private Label label3;
    }
}