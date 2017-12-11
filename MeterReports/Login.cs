﻿using Microsoft.AspNet.Identity;
using System;
using System.Windows.Forms;
using TMF.Reports.BLL;
using TMF.Reports.Model;
using TMF.Reports.UTIL;

namespace MeterReports
{
    public partial class Login : Form
    {
        private Button ButtonCancel;

        private CustomUserStore _userStore;
        private ErrorProvider errorProviderLogin;
        private System.ComponentModel.IContainer components;
        private TabControl tabControl2;
        private TabPage tabPage3;
        private Button ButtonLogin;
        private TextBox TextBoxPassword;
        private TextBox TextBoxUsername;
        private Label label1;
        private TabPage tabPage4;
        private TextBox TextBoxDBPassword;
        private TextBox TextBoxDBUsername;
        private TextBox TextBoxInitialCatalog;
        private TextBox TextBoxDataSource;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private UserManager<CustomUser, int> _userManager;
        public Login()
        {
            InitializeComponent();
            _userStore = new CustomUserStore(new CustomUserDbContext());
            _userManager = new UserManager<CustomUser, int>(_userStore);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.errorProviderLogin = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.ButtonLogin = new System.Windows.Forms.Button();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.TextBoxUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxDBPassword = new System.Windows.Forms.TextBox();
            this.TextBoxDBUsername = new System.Windows.Forms.TextBox();
            this.TextBoxInitialCatalog = new System.Windows.Forms.TextBox();
            this.TextBoxDataSource = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLogin)).BeginInit();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.AutoSize = true;
            this.ButtonCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonCancel.BackgroundImage")));
            this.ButtonCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCancel.Location = new System.Drawing.Point(64, 226);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(360, 56);
            this.ButtonCancel.TabIndex = 3;
            this.ButtonCancel.Text = "CANCEL";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // errorProviderLogin
            // 
            this.errorProviderLogin.ContainerControl = this;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(490, 344);
            this.tabControl2.TabIndex = 5;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.ButtonLogin);
            this.tabPage3.Controls.Add(this.ButtonCancel);
            this.tabPage3.Controls.Add(this.TextBoxPassword);
            this.tabPage3.Controls.Add(this.TextBoxUsername);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(482, 318);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "User Credential";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.TextBoxDBPassword);
            this.tabPage4.Controls.Add(this.TextBoxDBUsername);
            this.tabPage4.Controls.Add(this.TextBoxInitialCatalog);
            this.tabPage4.Controls.Add(this.TextBoxDataSource);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(482, 318);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Connection Manager";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // ButtonLogin
            // 
            this.ButtonLogin.AutoSize = true;
            this.ButtonLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonLogin.BackgroundImage")));
            this.ButtonLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonLogin.Location = new System.Drawing.Point(64, 144);
            this.ButtonLogin.Name = "ButtonLogin";
            this.ButtonLogin.Size = new System.Drawing.Size(360, 56);
            this.ButtonLogin.TabIndex = 28;
            this.ButtonLogin.Text = "LOGIN";
            this.ButtonLogin.UseVisualStyleBackColor = true;
            this.ButtonLogin.Click += new System.EventHandler(this.ButtonLogin_Click_1);
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxPassword.Location = new System.Drawing.Point(64, 105);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.PasswordChar = '*';
            this.TextBoxPassword.Size = new System.Drawing.Size(360, 27);
            this.TextBoxPassword.TabIndex = 26;
            this.TextBoxPassword.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxPassword_Validating);
            this.TextBoxPassword.Validated += new System.EventHandler(this.TextBoxPassword_Validated);
            // 
            // TextBoxUsername
            // 
            this.TextBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxUsername.Location = new System.Drawing.Point(64, 34);
            this.TextBoxUsername.Name = "TextBoxUsername";
            this.TextBoxUsername.Size = new System.Drawing.Size(360, 27);
            this.TextBoxUsername.TabIndex = 14;
            this.TextBoxUsername.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxUsername_Validating);
            this.TextBoxUsername.Validated += new System.EventHandler(this.TextBoxUsername_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 22);
            this.label1.TabIndex = 17;
            this.label1.Text = "USERNAME";
            // 
            // TextBoxDBPassword
            // 
            this.TextBoxDBPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxDBPassword.Location = new System.Drawing.Point(64, 224);
            this.TextBoxDBPassword.Name = "TextBoxDBPassword";
            this.TextBoxDBPassword.PasswordChar = '*';
            this.TextBoxDBPassword.Size = new System.Drawing.Size(360, 27);
            this.TextBoxDBPassword.TabIndex = 38;
            this.TextBoxDBPassword.Text = "tmf101010";
            this.TextBoxDBPassword.UseSystemPasswordChar = true;
            // 
            // TextBoxDBUsername
            // 
            this.TextBoxDBUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxDBUsername.Location = new System.Drawing.Point(64, 168);
            this.TextBoxDBUsername.Name = "TextBoxDBUsername";
            this.TextBoxDBUsername.Size = new System.Drawing.Size(360, 27);
            this.TextBoxDBUsername.TabIndex = 36;
            this.TextBoxDBUsername.Text = "sa";
            // 
            // TextBoxInitialCatalog
            // 
            this.TextBoxInitialCatalog.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxInitialCatalog.Location = new System.Drawing.Point(64, 112);
            this.TextBoxInitialCatalog.Name = "TextBoxInitialCatalog";
            this.TextBoxInitialCatalog.Size = new System.Drawing.Size(360, 27);
            this.TextBoxInitialCatalog.TabIndex = 34;
            this.TextBoxInitialCatalog.Text = "TMF_Meter_Readings";
            // 
            // TextBoxDataSource
            // 
            this.TextBoxDataSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxDataSource.Location = new System.Drawing.Point(64, 56);
            this.TextBoxDataSource.Name = "TextBoxDataSource";
            this.TextBoxDataSource.Size = new System.Drawing.Size(360, 27);
            this.TextBoxDataSource.TabIndex = 25;
            this.TextBoxDataSource.Text = "AMTVICTORICURM\\SQLEXPRESS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(64, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(217, 22);
            this.label6.TabIndex = 31;
            this.label6.Text = "DATABASE PASSWORD";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(64, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 22);
            this.label5.TabIndex = 29;
            this.label5.Text = "USERNAME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 22);
            this.label3.TabIndex = 26;
            this.label3.Text = "DATA SOURCE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(64, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 22);
            this.label4.TabIndex = 27;
            this.label4.Text = "INITIAL CATALOG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 22);
            this.label2.TabIndex = 16;
            this.label2.Text = "PASSWORD";
            // 
            // Login
            // 
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(490, 344);
            this.Controls.Add(this.tabControl2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLogin)).EndInit();
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }
        
        private void ButtonLogin_Click_1(object sender, EventArgs e)
        {
            //j1rjacob, Password123!
            //try
            //{
            ConnectionStringManager.Create
            (TextBoxDataSource.Text, TextBoxInitialCatalog.Text,
                TextBoxDBUsername.Text, TextBoxDBPassword.Text);
            //}
            //catch (Exception exception)
            //{
            //    MessageBox.Show(exception.Message);
            //    return;
            //}

            System.Threading.Thread.Sleep(5000);

            if (this.ValidateChildren(ValidationConstraints.Enabled))
            {
                var user = _userManager.FindByName(TextBoxUsername.Text.Trim());
                if (_userManager.CheckPassword(user, TextBoxPassword.Text.Trim())
                    && user.Locked != 1)
                {
                    var f = new Main(user);
                    f.Show();
                    user.Locked = 1;
                    _userManager.Update(user);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username or Password not match.");
                }
            }
            else
            {
                MessageBox.Show("There are invalid controls on the form.");
                //Return user to form...
            }
        }
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            TextBoxUsername.Text = "";
            TextBoxPassword.Text = "";
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                ButtonLogin.PerformClick();
                return true;
            }
            if (keyData == Keys.Escape)
            {
                ButtonCancel.PerformClick();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Application.Exit();
        }

        private void TextBoxUsername_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            bool cancel = false;
            if (string.IsNullOrEmpty(this.TextBoxUsername.Text))
            {
                //This control fails validation: Name cannot be empty.
                cancel = true;
                this.errorProviderLogin.SetError(this.TextBoxUsername, "You must provide Username!");
            }
            e.Cancel = cancel;
        }
        private void TextBoxUsername_Validated(object sender, EventArgs e)
        {
            this.errorProviderLogin.SetError(this.TextBoxUsername, string.Empty);
        }
        private void TextBoxPassword_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            bool cancel = false;
            if (string.IsNullOrEmpty(this.TextBoxPassword.Text))
            {
                //This control fails validation: Name cannot be empty.
                cancel = true;
                this.errorProviderLogin.SetError(this.TextBoxPassword, "You must provide Password!");
            }
            e.Cancel = cancel;
        }
        private void TextBoxPassword_Validated(object sender, EventArgs e)
        {
            this.errorProviderLogin.SetError(this.TextBoxPassword, string.Empty);
        }
    }
}
