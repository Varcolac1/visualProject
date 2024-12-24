namespace VisualProject
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            loginBox = new GroupBox();
            regsiterLink = new LinkLabel();
            LoginPasswordTxt = new TextBox();
            loginUsernameTxt = new TextBox();
            passwordLabel = new Label();
            usernameLabel = new Label();
            loginBtn = new Button();
            registerBox = new GroupBox();
            registerBtn = new Button();
            loginLink = new LinkLabel();
            registerEmailTxt = new TextBox();
            emailLbl = new Label();
            registerPasswordTxt = new TextBox();
            registerUsernameTxt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            loginBox.SuspendLayout();
            registerBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // loginBox
            // 
            loginBox.Controls.Add(regsiterLink);
            loginBox.Controls.Add(LoginPasswordTxt);
            loginBox.Controls.Add(loginUsernameTxt);
            loginBox.Controls.Add(passwordLabel);
            loginBox.Controls.Add(usernameLabel);
            loginBox.Controls.Add(loginBtn);
            loginBox.Location = new Point(12, 12);
            loginBox.Name = "loginBox";
            loginBox.Size = new Size(356, 172);
            loginBox.TabIndex = 1;
            loginBox.TabStop = false;
            loginBox.Text = "Log In";
            loginBox.Visible = false;
            loginBox.Enter += loginBox_Enter;
            // 
            // regsiterLink
            // 
            regsiterLink.AutoSize = true;
            regsiterLink.Location = new Point(94, 133);
            regsiterLink.Name = "regsiterLink";
            regsiterLink.Size = new Size(59, 20);
            regsiterLink.TabIndex = 6;
            regsiterLink.TabStop = true;
            regsiterLink.Text = "register";
            regsiterLink.LinkClicked += regsiterLink_LinkClicked;
            // 
            // LoginPasswordTxt
            // 
            LoginPasswordTxt.Location = new Point(94, 68);
            LoginPasswordTxt.Name = "LoginPasswordTxt";
            LoginPasswordTxt.Size = new Size(204, 27);
            LoginPasswordTxt.TabIndex = 4;
            // 
            // loginUsernameTxt
            // 
            loginUsernameTxt.Location = new Point(94, 36);
            loginUsernameTxt.Name = "loginUsernameTxt";
            loginUsernameTxt.Size = new Size(204, 27);
            loginUsernameTxt.TabIndex = 3;
            loginUsernameTxt.TextChanged += usernameTxt_TextChanged;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(10, 68);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(77, 20);
            passwordLabel.TabIndex = 2;
            passwordLabel.Text = "Password: ";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new Point(10, 36);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(78, 20);
            usernameLabel.TabIndex = 1;
            usernameLabel.Text = "Username:";
            // 
            // loginBtn
            // 
            loginBtn.Location = new Point(94, 101);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(94, 29);
            loginBtn.TabIndex = 0;
            loginBtn.Text = "Log in";
            loginBtn.UseVisualStyleBackColor = true;
            loginBtn.Click += loginBtn_Click;
            // 
            // registerBox
            // 
            registerBox.Controls.Add(registerBtn);
            registerBox.Controls.Add(loginLink);
            registerBox.Controls.Add(registerEmailTxt);
            registerBox.Controls.Add(emailLbl);
            registerBox.Controls.Add(registerPasswordTxt);
            registerBox.Controls.Add(registerUsernameTxt);
            registerBox.Controls.Add(label1);
            registerBox.Controls.Add(label2);
            registerBox.Location = new Point(12, 12);
            registerBox.Name = "registerBox";
            registerBox.Size = new Size(356, 185);
            registerBox.TabIndex = 2;
            registerBox.TabStop = false;
            registerBox.Text = "Register";
            // 
            // registerBtn
            // 
            registerBtn.Location = new Point(96, 133);
            registerBtn.Name = "registerBtn";
            registerBtn.Size = new Size(94, 29);
            registerBtn.TabIndex = 12;
            registerBtn.Text = "Register";
            registerBtn.UseVisualStyleBackColor = true;
            registerBtn.Click += registerBtn_Click;
            // 
            // loginLink
            // 
            loginLink.AutoSize = true;
            loginLink.Location = new Point(96, 165);
            loginLink.Name = "loginLink";
            loginLink.Size = new Size(43, 20);
            loginLink.TabIndex = 11;
            loginLink.TabStop = true;
            loginLink.Text = "login";
            loginLink.LinkClicked += loginLink_LinkClicked;
            // 
            // registerEmailTxt
            // 
            registerEmailTxt.Location = new Point(96, 35);
            registerEmailTxt.Name = "registerEmailTxt";
            registerEmailTxt.Size = new Size(202, 27);
            registerEmailTxt.TabIndex = 10;
            // 
            // emailLbl
            // 
            emailLbl.AutoSize = true;
            emailLbl.Location = new Point(12, 37);
            emailLbl.Name = "emailLbl";
            emailLbl.Size = new Size(49, 20);
            emailLbl.TabIndex = 9;
            emailLbl.Text = "Email:";
            // 
            // registerPasswordTxt
            // 
            registerPasswordTxt.Location = new Point(96, 100);
            registerPasswordTxt.Name = "registerPasswordTxt";
            registerPasswordTxt.Size = new Size(202, 27);
            registerPasswordTxt.TabIndex = 8;
            // 
            // registerUsernameTxt
            // 
            registerUsernameTxt.Location = new Point(96, 68);
            registerUsernameTxt.Name = "registerUsernameTxt";
            registerUsernameTxt.Size = new Size(202, 27);
            registerUsernameTxt.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 100);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 6;
            label1.Text = "Password: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 68);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 5;
            label2.Text = "Username:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(387, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(518, 514);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(928, 531);
            Controls.Add(loginBox);
            Controls.Add(registerBox);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            loginBox.ResumeLayout(false);
            loginBox.PerformLayout();
            registerBox.ResumeLayout(false);
            registerBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox loginBox;
        private Button loginBtn;
        private Label usernameLabel;
        private TextBox loginUsernameTxt;
        private Label passwordLabel;
        private TextBox LoginPasswordTxt;
        private LinkLabel regsiterLink;
        private GroupBox registerBox;
        private TextBox registerPasswordTxt;
        private TextBox registerUsernameTxt;
        private Label label1;
        private Label label2;
        private TextBox registerEmailTxt;
        private Label emailLbl;
        private LinkLabel loginLink;
        private Button registerBtn;
        private PictureBox pictureBox1;
    }
}
