﻿using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Windows.Forms;

namespace MeterReports
{
    public partial class Login : Form
    {
        private Label label1;
        private TextBox TextBoxUsername;
        private TextBox TextBoxPassword;
        private Button ButtonLogin;
        private Button ButtonCancel;
        private Label label2;

        public Login()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxUsername = new System.Windows.Forms.TextBox();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.ButtonLogin = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "USERNAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(88, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "PASSWORD";
            // 
            // TextBoxUsername
            // 
            this.TextBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxUsername.Location = new System.Drawing.Point(216, 24);
            this.TextBoxUsername.Name = "TextBoxUsername";
            this.TextBoxUsername.Size = new System.Drawing.Size(168, 27);
            this.TextBoxUsername.TabIndex = 1;
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxPassword.Location = new System.Drawing.Point(216, 72);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.Size = new System.Drawing.Size(168, 27);
            this.TextBoxPassword.TabIndex = 1;
            // 
            // ButtonLogin
            // 
            this.ButtonLogin.AutoSize = true;
            this.ButtonLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonLogin.BackgroundImage")));
            this.ButtonLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonLogin.Location = new System.Drawing.Point(96, 128);
            this.ButtonLogin.Name = "ButtonLogin";
            this.ButtonLogin.Size = new System.Drawing.Size(288, 56);
            this.ButtonLogin.TabIndex = 2;
            this.ButtonLogin.Text = "LOGIN";
            this.ButtonLogin.UseVisualStyleBackColor = true;
            this.ButtonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.AutoSize = true;
            this.ButtonCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonCancel.BackgroundImage")));
            this.ButtonCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCancel.Location = new System.Drawing.Point(96, 198);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(288, 56);
            this.ButtonCancel.TabIndex = 2;
            this.ButtonCancel.Text = "CANCEL";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // Login
            // 
            this.ClientSize = new System.Drawing.Size(471, 265);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonLogin);
            this.Controls.Add(this.TextBoxPassword);
            this.Controls.Add(this.TextBoxUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            var userStore = new UserStore<IdentityUser>();
            var userManager = new UserManager<IdentityUser>(userStore);

            var user = userManager.FindByName("junarjacob");
            var checkPassword = userManager.CheckPassword(user, "Password123!");

            if (checkPassword)
            {
                MessageBox.Show("Find User");
                var f = new MainForm();
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("User not found!");
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            TextBoxUsername.Text = "";
            TextBoxPassword.Text = "";
        }
    }
}
