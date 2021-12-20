﻿
namespace PresentationLayer {
    partial class Form1 {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button_SignUp = new System.Windows.Forms.Button();
            this.textBox_ConfirmPassword = new System.Windows.Forms.TextBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_Registration = new System.Windows.Forms.Panel();
            this.panel_LogIn = new System.Windows.Forms.Panel();
            this.buttonShowHidePasswordLogin = new System.Windows.Forms.Button();
            this.label_EmailLogin = new System.Windows.Forms.Label();
            this.textBox_EmailLogin = new System.Windows.Forms.TextBox();
            this.textBox_PasswordLogin = new System.Windows.Forms.TextBox();
            this.button_LogIn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonShowHideConfirmPassword = new System.Windows.Forms.Button();
            this.buttonLowercase = new System.Windows.Forms.Button();
            this.buttonNumbers = new System.Windows.Forms.Button();
            this.buttonLength = new System.Windows.Forms.Button();
            this.buttonShowHidePassword = new System.Windows.Forms.Button();
            this.buttonUppercase = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label_EmailExistLogin = new System.Windows.Forms.Label();
            this.label_EmailExist = new System.Windows.Forms.Label();
            this.panel_4 = new System.Windows.Forms.Panel();
            this.panel_3 = new System.Windows.Forms.Panel();
            this.panel_1 = new System.Windows.Forms.Panel();
            this.label_ConfirmPassword = new System.Windows.Forms.Label();
            this.label_Password = new System.Windows.Forms.Label();
            this.label_Email = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button_RegisterChoose = new System.Windows.Forms.Button();
            this.button_LogInChoose = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel_Registration.SuspendLayout();
            this.panel_LogIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_SignUp
            // 
            this.button_SignUp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(85)))), ((int)(((byte)(148)))));
            this.button_SignUp.FlatAppearance.BorderSize = 2;
            this.button_SignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_SignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SignUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(85)))), ((int)(((byte)(148)))));
            this.button_SignUp.Location = new System.Drawing.Point(78, 292);
            this.button_SignUp.Name = "button_SignUp";
            this.button_SignUp.Size = new System.Drawing.Size(161, 46);
            this.button_SignUp.TabIndex = 19;
            this.button_SignUp.Text = "SIGN UP";
            this.button_SignUp.UseVisualStyleBackColor = true;
            this.button_SignUp.Click += new System.EventHandler(this.button_SignUp_Click);
            this.button_SignUp.MouseEnter += new System.EventHandler(this.button_SignUp_Enter);
            this.button_SignUp.MouseLeave += new System.EventHandler(this.button_SignUp_Leave);
            // 
            // textBox_ConfirmPassword
            // 
            this.textBox_ConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_ConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ConfirmPassword.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBox_ConfirmPassword.Location = new System.Drawing.Point(30, 251);
            this.textBox_ConfirmPassword.MaxLength = 50;
            this.textBox_ConfirmPassword.MinimumSize = new System.Drawing.Size(200, 18);
            this.textBox_ConfirmPassword.Name = "textBox_ConfirmPassword";
            this.textBox_ConfirmPassword.Size = new System.Drawing.Size(214, 18);
            this.textBox_ConfirmPassword.TabIndex = 17;
            this.textBox_ConfirmPassword.Text = "Confirm Password";
            this.textBox_ConfirmPassword.TextChanged += new System.EventHandler(this.textBoxMasterPassword_TextChanged);
            this.textBox_ConfirmPassword.Enter += new System.EventHandler(this.textBox_ConfirmPassword_Enter);
            this.textBox_ConfirmPassword.Leave += new System.EventHandler(this.textBox_ConfirmPassword_Leave);
            // 
            // textBox_Password
            // 
            this.textBox_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Password.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Password.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBox_Password.Location = new System.Drawing.Point(30, 77);
            this.textBox_Password.MaxLength = 50;
            this.textBox_Password.MinimumSize = new System.Drawing.Size(200, 18);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(214, 18);
            this.textBox_Password.TabIndex = 16;
            this.textBox_Password.Tag = "273, 18";
            this.textBox_Password.Text = "Password";
            this.textBox_Password.TextChanged += new System.EventHandler(this.textBox_Password_TextChanged);
            this.textBox_Password.Enter += new System.EventHandler(this.textBox_Password_Enter);
            this.textBox_Password.Leave += new System.EventHandler(this.textBox_Password_Leave);
            // 
            // textBox_Email
            // 
            this.textBox_Email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Email.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Email.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBox_Email.Location = new System.Drawing.Point(30, 33);
            this.textBox_Email.MaximumSize = new System.Drawing.Size(260, 18);
            this.textBox_Email.MaxLength = 50;
            this.textBox_Email.MinimumSize = new System.Drawing.Size(200, 18);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(249, 18);
            this.textBox_Email.TabIndex = 15;
            this.textBox_Email.Text = "Email";
            this.textBox_Email.Enter += new System.EventHandler(this.textBox_Email_Enter);
            this.textBox_Email.Leave += new System.EventHandler(this.textBox_Email_Leave);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(308, 496);
            this.panel1.TabIndex = 12;
            // 
            // panel_Registration
            // 
            this.panel_Registration.BackColor = System.Drawing.Color.White;
            this.panel_Registration.Controls.Add(this.buttonShowHideConfirmPassword);
            this.panel_Registration.Controls.Add(this.buttonLowercase);
            this.panel_Registration.Controls.Add(this.buttonNumbers);
            this.panel_Registration.Controls.Add(this.textBox_Email);
            this.panel_Registration.Controls.Add(this.buttonLength);
            this.panel_Registration.Controls.Add(this.textBox_ConfirmPassword);
            this.panel_Registration.Controls.Add(this.buttonShowHidePassword);
            this.panel_Registration.Controls.Add(this.textBox_Password);
            this.panel_Registration.Controls.Add(this.buttonUppercase);
            this.panel_Registration.Controls.Add(this.label3);
            this.panel_Registration.Controls.Add(this.label2);
            this.panel_Registration.Controls.Add(this.label1);
            this.panel_Registration.Controls.Add(this.label10);
            this.panel_Registration.Controls.Add(this.label_EmailExistLogin);
            this.panel_Registration.Controls.Add(this.label_EmailExist);
            this.panel_Registration.Controls.Add(this.panel_4);
            this.panel_Registration.Controls.Add(this.panel_3);
            this.panel_Registration.Controls.Add(this.panel_1);
            this.panel_Registration.Controls.Add(this.label_ConfirmPassword);
            this.panel_Registration.Controls.Add(this.label_Password);
            this.panel_Registration.Controls.Add(this.label_Email);
            this.panel_Registration.Controls.Add(this.button_SignUp);
            this.panel_Registration.Controls.Add(this.label4);
            this.panel_Registration.Controls.Add(this.label5);
            this.panel_Registration.Controls.Add(this.label6);
            this.panel_Registration.Location = new System.Drawing.Point(319, 108);
            this.panel_Registration.Margin = new System.Windows.Forms.Padding(0);
            this.panel_Registration.Name = "panel_Registration";
            this.panel_Registration.Size = new System.Drawing.Size(313, 379);
            this.panel_Registration.TabIndex = 24;
            this.panel_Registration.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel_LogIn
            // 
            this.panel_LogIn.Controls.Add(this.buttonShowHidePasswordLogin);
            this.panel_LogIn.Controls.Add(this.label_EmailLogin);
            this.panel_LogIn.Controls.Add(this.textBox_EmailLogin);
            this.panel_LogIn.Controls.Add(this.textBox_PasswordLogin);
            this.panel_LogIn.Controls.Add(this.button_LogIn);
            this.panel_LogIn.Controls.Add(this.label7);
            this.panel_LogIn.Controls.Add(this.label8);
            this.panel_LogIn.Location = new System.Drawing.Point(651, 108);
            this.panel_LogIn.Margin = new System.Windows.Forms.Padding(0);
            this.panel_LogIn.Name = "panel_LogIn";
            this.panel_LogIn.Size = new System.Drawing.Size(313, 379);
            this.panel_LogIn.TabIndex = 25;
            this.panel_LogIn.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // buttonShowHidePasswordLogin
            // 
            this.buttonShowHidePasswordLogin.BackColor = System.Drawing.Color.White;
            this.buttonShowHidePasswordLogin.BackgroundImage = global::PresentationLayer.Properties.Resources.show;
            this.buttonShowHidePasswordLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonShowHidePasswordLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonShowHidePasswordLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonShowHidePasswordLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonShowHidePasswordLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShowHidePasswordLogin.ForeColor = System.Drawing.Color.White;
            this.buttonShowHidePasswordLogin.Location = new System.Drawing.Point(250, 75);
            this.buttonShowHidePasswordLogin.Name = "buttonShowHidePasswordLogin";
            this.buttonShowHidePasswordLogin.Size = new System.Drawing.Size(34, 23);
            this.buttonShowHidePasswordLogin.TabIndex = 50;
            this.buttonShowHidePasswordLogin.UseVisualStyleBackColor = false;
            this.buttonShowHidePasswordLogin.Click += new System.EventHandler(this.buttonShowHidePasswordLogin_Click);
            // 
            // label_EmailLogin
            // 
            this.label_EmailLogin.AutoSize = true;
            this.label_EmailLogin.ForeColor = System.Drawing.Color.Red;
            this.label_EmailLogin.Location = new System.Drawing.Point(18, 12);
            this.label_EmailLogin.Name = "label_EmailLogin";
            this.label_EmailLogin.Size = new System.Drawing.Size(181, 13);
            this.label_EmailLogin.TabIndex = 25;
            this.label_EmailLogin.Text = "Invalid email address or password";
            this.label_EmailLogin.Visible = false;
            // 
            // textBox_EmailLogin
            // 
            this.textBox_EmailLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_EmailLogin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_EmailLogin.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBox_EmailLogin.Location = new System.Drawing.Point(30, 33);
            this.textBox_EmailLogin.MaximumSize = new System.Drawing.Size(249, 18);
            this.textBox_EmailLogin.Name = "textBox_EmailLogin";
            this.textBox_EmailLogin.Size = new System.Drawing.Size(225, 18);
            this.textBox_EmailLogin.TabIndex = 15;
            this.textBox_EmailLogin.Text = "Email";
            this.textBox_EmailLogin.Enter += new System.EventHandler(this.textBox_EmailLogin_Enter);
            this.textBox_EmailLogin.Leave += new System.EventHandler(this.textBox_EmailLogin_Leave);
            // 
            // textBox_PasswordLogin
            // 
            this.textBox_PasswordLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_PasswordLogin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_PasswordLogin.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBox_PasswordLogin.Location = new System.Drawing.Point(30, 77);
            this.textBox_PasswordLogin.MaximumSize = new System.Drawing.Size(225, 18);
            this.textBox_PasswordLogin.Name = "textBox_PasswordLogin";
            this.textBox_PasswordLogin.Size = new System.Drawing.Size(225, 18);
            this.textBox_PasswordLogin.TabIndex = 16;
            this.textBox_PasswordLogin.Text = "Password";
            this.textBox_PasswordLogin.Enter += new System.EventHandler(this.textBox_PasswordLogin_Enter);
            this.textBox_PasswordLogin.Leave += new System.EventHandler(this.textBox_PasswordLogin_Leave);
            // 
            // button_LogIn
            // 
            this.button_LogIn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(85)))), ((int)(((byte)(148)))));
            this.button_LogIn.FlatAppearance.BorderSize = 2;
            this.button_LogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_LogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_LogIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(85)))), ((int)(((byte)(148)))));
            this.button_LogIn.Location = new System.Drawing.Point(78, 292);
            this.button_LogIn.Name = "button_LogIn";
            this.button_LogIn.Size = new System.Drawing.Size(161, 46);
            this.button_LogIn.TabIndex = 19;
            this.button_LogIn.Text = "LOG IN";
            this.button_LogIn.UseVisualStyleBackColor = true;
            this.button_LogIn.Click += new System.EventHandler(this.button_LogIn_Click);
            this.button_LogIn.MouseEnter += new System.EventHandler(this.button_LogIn_Enter);
            this.button_LogIn.MouseLeave += new System.EventHandler(this.button_LogIn_Leave);
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Location = new System.Drawing.Point(20, 28);
            this.label7.MinimumSize = new System.Drawing.Size(273, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(273, 30);
            this.label7.TabIndex = 50;
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Location = new System.Drawing.Point(20, 71);
            this.label8.MinimumSize = new System.Drawing.Size(273, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(273, 30);
            this.label8.TabIndex = 51;
            // 
            // buttonShowHideConfirmPassword
            // 
            this.buttonShowHideConfirmPassword.BackColor = System.Drawing.Color.White;
            this.buttonShowHideConfirmPassword.BackgroundImage = global::PresentationLayer.Properties.Resources.show;
            this.buttonShowHideConfirmPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonShowHideConfirmPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonShowHideConfirmPassword.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonShowHideConfirmPassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonShowHideConfirmPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShowHideConfirmPassword.ForeColor = System.Drawing.Color.White;
            this.buttonShowHideConfirmPassword.Location = new System.Drawing.Point(250, 249);
            this.buttonShowHideConfirmPassword.Name = "buttonShowHideConfirmPassword";
            this.buttonShowHideConfirmPassword.Size = new System.Drawing.Size(34, 23);
            this.buttonShowHideConfirmPassword.TabIndex = 34;
            this.buttonShowHideConfirmPassword.UseVisualStyleBackColor = false;
            this.buttonShowHideConfirmPassword.Click += new System.EventHandler(this.buttonShowHideConfirmPassword_Click);
            // 
            // buttonLowercase
            // 
            this.buttonLowercase.BackgroundImage = global::PresentationLayer.Properties.Resources.blank;
            this.buttonLowercase.Enabled = false;
            this.buttonLowercase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLowercase.ForeColor = System.Drawing.Color.White;
            this.buttonLowercase.Location = new System.Drawing.Point(30, 173);
            this.buttonLowercase.Name = "buttonLowercase";
            this.buttonLowercase.Size = new System.Drawing.Size(25, 25);
            this.buttonLowercase.TabIndex = 46;
            this.buttonLowercase.UseVisualStyleBackColor = true;
            // 
            // buttonNumbers
            // 
            this.buttonNumbers.BackgroundImage = global::PresentationLayer.Properties.Resources.blank;
            this.buttonNumbers.Enabled = false;
            this.buttonNumbers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNumbers.ForeColor = System.Drawing.Color.White;
            this.buttonNumbers.Location = new System.Drawing.Point(30, 144);
            this.buttonNumbers.Name = "buttonNumbers";
            this.buttonNumbers.Size = new System.Drawing.Size(25, 25);
            this.buttonNumbers.TabIndex = 45;
            this.buttonNumbers.UseVisualStyleBackColor = true;
            // 
            // buttonLength
            // 
            this.buttonLength.BackgroundImage = global::PresentationLayer.Properties.Resources.blank;
            this.buttonLength.Enabled = false;
            this.buttonLength.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLength.ForeColor = System.Drawing.Color.White;
            this.buttonLength.Location = new System.Drawing.Point(30, 115);
            this.buttonLength.Name = "buttonLength";
            this.buttonLength.Size = new System.Drawing.Size(25, 25);
            this.buttonLength.TabIndex = 44;
            this.buttonLength.UseVisualStyleBackColor = true;
            // 
            // buttonShowHidePassword
            // 
            this.buttonShowHidePassword.BackColor = System.Drawing.Color.White;
            this.buttonShowHidePassword.BackgroundImage = global::PresentationLayer.Properties.Resources.show;
            this.buttonShowHidePassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonShowHidePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonShowHidePassword.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonShowHidePassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonShowHidePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShowHidePassword.ForeColor = System.Drawing.Color.White;
            this.buttonShowHidePassword.Location = new System.Drawing.Point(250, 75);
            this.buttonShowHidePassword.Name = "buttonShowHidePassword";
            this.buttonShowHidePassword.Size = new System.Drawing.Size(34, 23);
            this.buttonShowHidePassword.TabIndex = 33;
            this.buttonShowHidePassword.UseVisualStyleBackColor = false;
            this.buttonShowHidePassword.Click += new System.EventHandler(this.buttonShowHidePassword_Click);
            // 
            // buttonUppercase
            // 
            this.buttonUppercase.BackgroundImage = global::PresentationLayer.Properties.Resources.blank;
            this.buttonUppercase.Enabled = false;
            this.buttonUppercase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUppercase.ForeColor = System.Drawing.Color.White;
            this.buttonUppercase.Location = new System.Drawing.Point(30, 205);
            this.buttonUppercase.Name = "buttonUppercase";
            this.buttonUppercase.Size = new System.Drawing.Size(25, 25);
            this.buttonUppercase.TabIndex = 43;
            this.buttonUppercase.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "At least 1 uppercase letter";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "At least 1 lowercase letter";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "At least 1 number";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(61, 121);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(142, 13);
            this.label10.TabIndex = 39;
            this.label10.Text = "At least 12 characters long";
            // 
            // label_EmailExistLogin
            // 
            this.label_EmailExistLogin.AutoSize = true;
            this.label_EmailExistLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_EmailExistLogin.ForeColor = System.Drawing.Color.Black;
            this.label_EmailExistLogin.Location = new System.Drawing.Point(125, 354);
            this.label_EmailExistLogin.Name = "label_EmailExistLogin";
            this.label_EmailExistLogin.Size = new System.Drawing.Size(72, 24);
            this.label_EmailExistLogin.TabIndex = 32;
            this.label_EmailExistLogin.Text = "Log in?";
            this.label_EmailExistLogin.Visible = false;
            this.label_EmailExistLogin.Click += new System.EventHandler(this.label_EmailExistLogin_Click);
            // 
            // label_EmailExist
            // 
            this.label_EmailExist.AutoSize = true;
            this.label_EmailExist.ForeColor = System.Drawing.Color.Red;
            this.label_EmailExist.Location = new System.Drawing.Point(43, 341);
            this.label_EmailExist.Name = "label_EmailExist";
            this.label_EmailExist.Size = new System.Drawing.Size(241, 13);
            this.label_EmailExist.TabIndex = 31;
            this.label_EmailExist.Text = "Account with this email address already exists";
            this.label_EmailExist.Visible = false;
            this.label_EmailExist.Click += new System.EventHandler(this.label_EmailExist_Click);
            // 
            // panel_4
            // 
            this.panel_4.BackColor = System.Drawing.Color.LightGray;
            this.panel_4.Location = new System.Drawing.Point(202, 105);
            this.panel_4.Margin = new System.Windows.Forms.Padding(0);
            this.panel_4.Name = "panel_4";
            this.panel_4.Size = new System.Drawing.Size(91, 5);
            this.panel_4.TabIndex = 30;
            // 
            // panel_3
            // 
            this.panel_3.BackColor = System.Drawing.Color.LightGray;
            this.panel_3.Location = new System.Drawing.Point(111, 105);
            this.panel_3.Margin = new System.Windows.Forms.Padding(0);
            this.panel_3.Name = "panel_3";
            this.panel_3.Size = new System.Drawing.Size(91, 5);
            this.panel_3.TabIndex = 30;
            // 
            // panel_1
            // 
            this.panel_1.BackColor = System.Drawing.Color.LightGray;
            this.panel_1.Location = new System.Drawing.Point(21, 105);
            this.panel_1.Margin = new System.Windows.Forms.Padding(0);
            this.panel_1.Name = "panel_1";
            this.panel_1.Size = new System.Drawing.Size(91, 5);
            this.panel_1.TabIndex = 29;
            // 
            // label_ConfirmPassword
            // 
            this.label_ConfirmPassword.AutoSize = true;
            this.label_ConfirmPassword.ForeColor = System.Drawing.Color.Red;
            this.label_ConfirmPassword.Location = new System.Drawing.Point(17, 232);
            this.label_ConfirmPassword.Name = "label_ConfirmPassword";
            this.label_ConfirmPassword.Size = new System.Drawing.Size(133, 13);
            this.label_ConfirmPassword.TabIndex = 29;
            this.label_ConfirmPassword.Text = "Passwords do not match";
            this.label_ConfirmPassword.Visible = false;
            this.label_ConfirmPassword.Click += new System.EventHandler(this.label_ConfirmPassword_Click);
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.ForeColor = System.Drawing.Color.Red;
            this.label_Password.Location = new System.Drawing.Point(18, 58);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(94, 13);
            this.label_Password.TabIndex = 25;
            this.label_Password.Text = "Invalid password";
            this.label_Password.Visible = false;
            // 
            // label_Email
            // 
            this.label_Email.AutoSize = true;
            this.label_Email.ForeColor = System.Drawing.Color.Red;
            this.label_Email.Location = new System.Drawing.Point(18, 12);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(114, 13);
            this.label_Email.TabIndex = 24;
            this.label_Email.Text = "Invalid email address";
            this.label_Email.Visible = false;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(20, 28);
            this.label4.MinimumSize = new System.Drawing.Size(273, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(273, 30);
            this.label4.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(20, 71);
            this.label5.MinimumSize = new System.Drawing.Size(273, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(273, 30);
            this.label5.TabIndex = 48;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Location = new System.Drawing.Point(20, 245);
            this.label6.MinimumSize = new System.Drawing.Size(273, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(273, 30);
            this.label6.TabIndex = 49;
            // 
            // button_RegisterChoose
            // 
            this.button_RegisterChoose.BackColor = System.Drawing.SystemColors.Control;
            this.button_RegisterChoose.DialogResult = System.Windows.Forms.DialogResult.No;
            this.button_RegisterChoose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(85)))), ((int)(((byte)(148)))));
            this.button_RegisterChoose.FlatAppearance.BorderSize = 2;
            this.button_RegisterChoose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_RegisterChoose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_RegisterChoose.ForeColor = System.Drawing.Color.Black;
            this.button_RegisterChoose.Location = new System.Drawing.Point(370, 36);
            this.button_RegisterChoose.Margin = new System.Windows.Forms.Padding(64, 0, 0, 0);
            this.button_RegisterChoose.Name = "button_RegisterChoose";
            this.button_RegisterChoose.Size = new System.Drawing.Size(92, 43);
            this.button_RegisterChoose.TabIndex = 26;
            this.button_RegisterChoose.Text = "REGISTER";
            this.button_RegisterChoose.UseVisualStyleBackColor = false;
            this.button_RegisterChoose.Click += new System.EventHandler(this.button_RegisterChoose_Click);
            // 
            // button_LogInChoose
            // 
            this.button_LogInChoose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(85)))), ((int)(((byte)(148)))));
            this.button_LogInChoose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(85)))), ((int)(((byte)(148)))));
            this.button_LogInChoose.FlatAppearance.BorderSize = 2;
            this.button_LogInChoose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_LogInChoose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_LogInChoose.ForeColor = System.Drawing.Color.White;
            this.button_LogInChoose.Location = new System.Drawing.Point(462, 36);
            this.button_LogInChoose.Margin = new System.Windows.Forms.Padding(0, 0, 64, 0);
            this.button_LogInChoose.Name = "button_LogInChoose";
            this.button_LogInChoose.Size = new System.Drawing.Size(92, 43);
            this.button_LogInChoose.TabIndex = 27;
            this.button_LogInChoose.Text = "LOG IN";
            this.button_LogInChoose.UseVisualStyleBackColor = false;
            this.button_LogInChoose.Click += new System.EventHandler(this.button_LogInChoose_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1038, 496);
            this.Controls.Add(this.panel_LogIn);
            this.Controls.Add(this.panel_Registration);
            this.Controls.Add(this.button_RegisterChoose);
            this.Controls.Add(this.button_LogInChoose);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_Registration.ResumeLayout(false);
            this.panel_Registration.PerformLayout();
            this.panel_LogIn.ResumeLayout(false);
            this.panel_LogIn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_SignUp;
        private System.Windows.Forms.TextBox textBox_ConfirmPassword;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_Registration;
        private System.Windows.Forms.Panel panel_LogIn;
        private System.Windows.Forms.TextBox textBox_EmailLogin;
        private System.Windows.Forms.TextBox textBox_PasswordLogin;
        private System.Windows.Forms.Button button_LogIn;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.Label label_Email;
        private System.Windows.Forms.Label label_EmailLogin;
        private System.Windows.Forms.Button button_RegisterChoose;
        private System.Windows.Forms.Button button_LogInChoose;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label_ConfirmPassword;
        private System.Windows.Forms.Panel panel_1;
        private System.Windows.Forms.Panel panel_4;
        private System.Windows.Forms.Panel panel_3;
        private System.Windows.Forms.Label label_EmailExistLogin;
        private System.Windows.Forms.Label label_EmailExist;
        private System.Windows.Forms.Button buttonShowHidePassword;
        private System.Windows.Forms.Button buttonShowHideConfirmPassword;
        private System.Windows.Forms.Button buttonLowercase;
        private System.Windows.Forms.Button buttonNumbers;
        private System.Windows.Forms.Button buttonLength;
        private System.Windows.Forms.Button buttonUppercase;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonShowHidePasswordLogin;
    }
}

