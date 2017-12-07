using Microsoft.AspNet.Identity;
using System;
using System.Windows.Forms;
using TMF.Reports.BLL;
using TMF.Reports.Model;

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

        private CustomUserStore _userStore;
        private ErrorProvider errorProviderLogin;
        private System.ComponentModel.IContainer components;
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxUsername = new System.Windows.Forms.TextBox();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.ButtonLogin = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.errorProviderLogin = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "USERNAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(92, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "PASSWORD";
            // 
            // TextBoxUsername
            // 
            this.TextBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxUsername.Location = new System.Drawing.Point(96, 48);
            this.TextBoxUsername.Name = "TextBoxUsername";
            this.TextBoxUsername.Size = new System.Drawing.Size(288, 27);
            this.TextBoxUsername.TabIndex = 0;
            this.TextBoxUsername.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxUsername_Validating);
            this.TextBoxUsername.Validated += new System.EventHandler(this.TextBoxUsername_Validated);
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxPassword.Location = new System.Drawing.Point(96, 119);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.PasswordChar = '*';
            this.TextBoxPassword.Size = new System.Drawing.Size(288, 27);
            this.TextBoxPassword.TabIndex = 1;
            this.TextBoxPassword.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxPassword_Validating);
            this.TextBoxPassword.Validated += new System.EventHandler(this.TextBoxPassword_Validated);
            // 
            // ButtonLogin
            // 
            this.ButtonLogin.AutoSize = true;
            this.ButtonLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonLogin.BackgroundImage")));
            this.ButtonLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonLogin.Location = new System.Drawing.Point(96, 162);
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
            this.ButtonCancel.Location = new System.Drawing.Point(96, 232);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(288, 56);
            this.ButtonCancel.TabIndex = 3;
            this.ButtonCancel.Text = "CANCEL";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // errorProviderLogin
            // 
            this.errorProviderLogin.ContainerControl = this;
            // 
            // Login
            // 
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(471, 312);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonLogin);
            this.Controls.Add(this.TextBoxPassword);
            this.Controls.Add(this.TextBoxUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {//junarjacob, Password123!
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
