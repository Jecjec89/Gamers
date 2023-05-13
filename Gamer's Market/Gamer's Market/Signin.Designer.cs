namespace Gamer_s_Market
{
    partial class Signin
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
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            signupLink = new LinkLabel();
            label1 = new Label();
            signinBtn = new Button();
            passwordBox = new TextBox();
            emailBox = new TextBox();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(0, 190, 230);
            label4.Location = new Point(210, 314);
            label4.Name = "label4";
            label4.Size = new Size(126, 13);
            label4.TabIndex = 15;
            label4.Text = "Forgot your password?";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(0, 190, 230);
            label3.Location = new Point(210, 259);
            label3.Name = "label3";
            label3.Size = new Size(56, 13);
            label3.TabIndex = 14;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 190, 230);
            label2.Location = new Point(210, 195);
            label2.Name = "label2";
            label2.Size = new Size(101, 13);
            label2.TabIndex = 13;
            label2.Text = "Email or username";
            // 
            // signupLink
            // 
            signupLink.AutoSize = true;
            signupLink.BackColor = Color.Transparent;
            signupLink.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            signupLink.LinkBehavior = LinkBehavior.HoverUnderline;
            signupLink.LinkColor = Color.LightSkyBlue;
            signupLink.Location = new Point(340, 402);
            signupLink.Name = "signupLink";
            signupLink.Size = new Size(100, 13);
            signupLink.TabIndex = 12;
            signupLink.TabStop = true;
            signupLink.Text = "Create an account";
            signupLink.LinkClicked += signupLink_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(282, 402);
            label1.Name = "label1";
            label1.Size = new Size(61, 13);
            label1.TabIndex = 11;
            label1.Text = "New here?";
            // 
            // signinBtn
            // 
            signinBtn.BackColor = Color.Turquoise;
            signinBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            signinBtn.ForeColor = Color.White;
            signinBtn.Location = new Point(210, 348);
            signinBtn.Name = "signinBtn";
            signinBtn.Size = new Size(292, 40);
            signinBtn.TabIndex = 10;
            signinBtn.Text = "Sign in";
            signinBtn.UseVisualStyleBackColor = false;
            signinBtn.Click += signinBtn_Click;
            // 
            // passwordBox
            // 
            passwordBox.Location = new Point(210, 275);
            passwordBox.Name = "passwordBox";
            passwordBox.PlaceholderText = "Enter your password";
            passwordBox.Size = new Size(292, 23);
            passwordBox.TabIndex = 9;
            // 
            // emailBox
            // 
            emailBox.Location = new Point(210, 211);
            emailBox.Name = "emailBox";
            emailBox.PlaceholderText = "Enter your email or username";
            emailBox.Size = new Size(292, 23);
            emailBox.TabIndex = 8;
            // 
            // Signin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Sign_in__1_;
            ClientSize = new Size(720, 512);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(signupLink);
            Controls.Add(label1);
            Controls.Add(signinBtn);
            Controls.Add(passwordBox);
            Controls.Add(emailBox);
            Name = "Signin";
            Text = "Signin";
            Load += Signin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label3;
        private Label label2;
        private LinkLabel signupLink;
        private Label label1;
        private Button signinBtn;
        private TextBox passwordBox;
        private TextBox emailBox;
    }
}