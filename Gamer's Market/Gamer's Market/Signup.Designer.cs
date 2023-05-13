namespace Gamer_s_Market
{
    partial class Signup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signup));
            label4 = new Label();
            label3 = new Label();
            signinLink = new LinkLabel();
            label1 = new Label();
            passwordBox = new TextBox();
            firstnameBox = new TextBox();
            confirmpassBox = new TextBox();
            emailBox = new TextBox();
            lastnameBox = new TextBox();
            label2 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            submitBtn = new Button();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(224, 224, 224);
            label4.Location = new Point(198, 360);
            label4.Name = "label4";
            label4.Size = new Size(100, 13);
            label4.TabIndex = 23;
            label4.Text = "Confirm Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(224, 224, 224);
            label3.Location = new Point(198, 303);
            label3.Name = "label3";
            label3.Size = new Size(56, 13);
            label3.TabIndex = 22;
            label3.Text = "Password";
            // 
            // signinLink
            // 
            signinLink.AutoSize = true;
            signinLink.BackColor = Color.Transparent;
            signinLink.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            signinLink.LinkBehavior = LinkBehavior.HoverUnderline;
            signinLink.LinkColor = Color.LightSkyBlue;
            signinLink.Location = new Point(403, 473);
            signinLink.Name = "signinLink";
            signinLink.Size = new Size(43, 13);
            signinLink.TabIndex = 20;
            signinLink.TabStop = true;
            signinLink.Text = "Sign in";
            signinLink.LinkClicked += signinLink_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(224, 224, 224);
            label1.Location = new Point(159, 460);
            label1.Name = "label1";
            label1.Size = new Size(397, 13);
            label1.TabIndex = 19;
            label1.Text = "By clicking Submit, you agree to our terms and conditions and privacy policy";
            // 
            // passwordBox
            // 
            passwordBox.Location = new Point(198, 319);
            passwordBox.Name = "passwordBox";
            passwordBox.PlaceholderText = "Enter your password";
            passwordBox.Size = new Size(312, 23);
            passwordBox.TabIndex = 17;
            // 
            // firstnameBox
            // 
            firstnameBox.Location = new Point(198, 214);
            firstnameBox.Name = "firstnameBox";
            firstnameBox.PlaceholderText = "Enter first name";
            firstnameBox.Size = new Size(136, 23);
            firstnameBox.TabIndex = 16;
            // 
            // confirmpassBox
            // 
            confirmpassBox.Location = new Point(198, 376);
            confirmpassBox.Name = "confirmpassBox";
            confirmpassBox.PlaceholderText = "Enter confirm password";
            confirmpassBox.Size = new Size(312, 23);
            confirmpassBox.TabIndex = 24;
            // 
            // emailBox
            // 
            emailBox.Location = new Point(198, 266);
            emailBox.Name = "emailBox";
            emailBox.PlaceholderText = "Enter email address";
            emailBox.Size = new Size(312, 23);
            emailBox.TabIndex = 25;
            // 
            // lastnameBox
            // 
            lastnameBox.Location = new Point(358, 214);
            lastnameBox.Name = "lastnameBox";
            lastnameBox.PlaceholderText = "Enter last name";
            lastnameBox.Size = new Size(152, 23);
            lastnameBox.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(224, 224, 224);
            label2.Location = new Point(198, 198);
            label2.Name = "label2";
            label2.Size = new Size(61, 13);
            label2.TabIndex = 27;
            label2.Text = "First Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(224, 224, 224);
            label5.Location = new Point(198, 250);
            label5.Name = "label5";
            label5.Size = new Size(78, 13);
            label5.TabIndex = 28;
            label5.Text = "Email Address";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(224, 224, 224);
            label6.Location = new Point(358, 198);
            label6.Name = "label6";
            label6.Size = new Size(59, 13);
            label6.TabIndex = 29;
            label6.Text = "Last Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(224, 224, 224);
            label7.Location = new Point(267, 473);
            label7.Name = "label7";
            label7.Size = new Size(140, 13);
            label7.TabIndex = 30;
            label7.Text = "Already have an account? ";
            // 
            // submitBtn
            // 
            submitBtn.BackColor = SystemColors.ActiveBorder;
            submitBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            submitBtn.Location = new Point(309, 414);
            submitBtn.Name = "submitBtn";
            submitBtn.Size = new Size(98, 28);
            submitBtn.TabIndex = 31;
            submitBtn.Text = "Submit";
            submitBtn.UseVisualStyleBackColor = false;
            submitBtn.Click += submitBtn_Click;
            // 
            // Signup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(720, 512);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(lastnameBox);
            Controls.Add(emailBox);
            Controls.Add(confirmpassBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(signinLink);
            Controls.Add(label1);
            Controls.Add(submitBtn);
            Controls.Add(passwordBox);
            Controls.Add(firstnameBox);
            Name = "Signup";
            Text = "Signup";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label3;
        private LinkLabel signinLink;
        private Label label1;
        private TextBox passwordBox;
        private TextBox firstnameBox;
        private TextBox confirmpassBox;
        private TextBox emailBox;
        private TextBox lastnameBox;
        private Label label2;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button submitBtn;
    }
}