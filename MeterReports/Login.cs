using Microsoft.VisualBasic;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using TMF.Core;
using TMF.Core.Model;
using TMF.Reports.BLL;
using TMF.Reports.UTIL;

namespace MeterReports
{
    public partial class Login : Form
    {
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
        private TabPage tabPage1;
        private Button ButtonChangePassword;
        private TextBox TextBoxChangePassword;
        private TextBox TextBoxChangeUsername;
        private Label label7;
        private Label label8;
        private Button ButtonConnect;
        private readonly UserInfoBLL _userInfo;
        private string _currentUsername;
        public Login(string Username)
        {
            InitializeComponent();
            _userInfo = new UserInfoBLL();
            _currentUsername = Username ?? "j1rjacob";
        }
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.errorProviderLogin = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.ButtonLogin = new System.Windows.Forms.Button();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.TextBoxUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.ButtonConnect = new System.Windows.Forms.Button();
            this.TextBoxDBPassword = new System.Windows.Forms.TextBox();
            this.TextBoxDBUsername = new System.Windows.Forms.TextBox();
            this.TextBoxInitialCatalog = new System.Windows.Forms.TextBox();
            this.TextBoxDataSource = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ButtonChangePassword = new System.Windows.Forms.Button();
            this.TextBoxChangePassword = new System.Windows.Forms.TextBox();
            this.TextBoxChangeUsername = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLogin)).BeginInit();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProviderLogin
            // 
            this.errorProviderLogin.ContainerControl = this;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage1);
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
            // ButtonLogin
            // 
            this.ButtonLogin.AutoSize = true;
            this.ButtonLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonLogin.BackgroundImage")));
            this.ButtonLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonLogin.Location = new System.Drawing.Point(64, 176);
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
            this.TextBoxPassword.Location = new System.Drawing.Point(64, 121);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.PasswordChar = '*';
            this.TextBoxPassword.Size = new System.Drawing.Size(360, 27);
            this.TextBoxPassword.TabIndex = 1;
            this.TextBoxPassword.Text = "ajffjnrx";
            this.TextBoxPassword.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxPassword_Validating);
            this.TextBoxPassword.Validated += new System.EventHandler(this.TextBoxPassword_Validated);
            // 
            // TextBoxUsername
            // 
            this.TextBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxUsername.Location = new System.Drawing.Point(64, 50);
            this.TextBoxUsername.Name = "TextBoxUsername";
            this.TextBoxUsername.Size = new System.Drawing.Size(360, 27);
            this.TextBoxUsername.TabIndex = 0;
            this.TextBoxUsername.Text = "j1rjacob";
            this.TextBoxUsername.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxUsername_Validating);
            this.TextBoxUsername.Validated += new System.EventHandler(this.TextBoxUsername_Validated);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 22);
            this.label2.TabIndex = 16;
            this.label2.Text = "PASSWORD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 22);
            this.label1.TabIndex = 17;
            this.label1.Text = "USERNAME";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.ButtonConnect);
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
            // ButtonConnect
            // 
            this.ButtonConnect.AutoSize = true;
            this.ButtonConnect.BackColor = System.Drawing.Color.Red;
            this.ButtonConnect.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonConnect.BackgroundImage")));
            this.ButtonConnect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtonConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonConnect.Location = new System.Drawing.Point(64, 256);
            this.ButtonConnect.Name = "ButtonConnect";
            this.ButtonConnect.Size = new System.Drawing.Size(360, 56);
            this.ButtonConnect.TabIndex = 39;
            this.ButtonConnect.Text = "CONNECT";
            this.ButtonConnect.UseVisualStyleBackColor = false;
            this.ButtonConnect.Click += new System.EventHandler(this.ButtonConnect_Click);
            // 
            // TextBoxDBPassword
            // 
            this.TextBoxDBPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxDBPassword.Location = new System.Drawing.Point(64, 219);
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
            this.TextBoxDBUsername.Location = new System.Drawing.Point(64, 155);
            this.TextBoxDBUsername.Name = "TextBoxDBUsername";
            this.TextBoxDBUsername.Size = new System.Drawing.Size(360, 27);
            this.TextBoxDBUsername.TabIndex = 36;
            this.TextBoxDBUsername.Text = "sa";
            // 
            // TextBoxInitialCatalog
            // 
            this.TextBoxInitialCatalog.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxInitialCatalog.Location = new System.Drawing.Point(64, 91);
            this.TextBoxInitialCatalog.Name = "TextBoxInitialCatalog";
            this.TextBoxInitialCatalog.Size = new System.Drawing.Size(360, 27);
            this.TextBoxInitialCatalog.TabIndex = 34;
            this.TextBoxInitialCatalog.Text = "TMF_Meter_Readings";
            // 
            // TextBoxDataSource
            // 
            this.TextBoxDataSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxDataSource.Location = new System.Drawing.Point(64, 27);
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
            this.label6.Location = new System.Drawing.Point(64, 195);
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
            this.label5.Location = new System.Drawing.Point(64, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 22);
            this.label5.TabIndex = 29;
            this.label5.Text = "USERNAME";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(64, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 22);
            this.label4.TabIndex = 27;
            this.label4.Text = "INITIAL CATALOG";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 22);
            this.label3.TabIndex = 26;
            this.label3.Text = "DATA SOURCE";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ButtonChangePassword);
            this.tabPage1.Controls.Add(this.TextBoxChangePassword);
            this.tabPage1.Controls.Add(this.TextBoxChangeUsername);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(482, 318);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Reset Password";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ButtonChangePassword
            // 
            this.ButtonChangePassword.AutoSize = true;
            this.ButtonChangePassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonChangePassword.BackgroundImage")));
            this.ButtonChangePassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtonChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonChangePassword.Location = new System.Drawing.Point(61, 168);
            this.ButtonChangePassword.Name = "ButtonChangePassword";
            this.ButtonChangePassword.Size = new System.Drawing.Size(360, 56);
            this.ButtonChangePassword.TabIndex = 22;
            this.ButtonChangePassword.Text = "CHANGE PASSWORD";
            this.ButtonChangePassword.UseVisualStyleBackColor = true;
            this.ButtonChangePassword.Click += new System.EventHandler(this.ButtonChangePassword_Click);
            // 
            // TextBoxChangePassword
            // 
            this.TextBoxChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxChangePassword.Location = new System.Drawing.Point(62, 112);
            this.TextBoxChangePassword.Name = "TextBoxChangePassword";
            this.TextBoxChangePassword.PasswordChar = '*';
            this.TextBoxChangePassword.Size = new System.Drawing.Size(360, 27);
            this.TextBoxChangePassword.TabIndex = 19;
            // 
            // TextBoxChangeUsername
            // 
            this.TextBoxChangeUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxChangeUsername.Location = new System.Drawing.Point(62, 41);
            this.TextBoxChangeUsername.Name = "TextBoxChangeUsername";
            this.TextBoxChangeUsername.Size = new System.Drawing.Size(360, 27);
            this.TextBoxChangeUsername.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(61, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 22);
            this.label7.TabIndex = 20;
            this.label7.Text = "PASSWORD";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(60, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 22);
            this.label8.TabIndex = 21;
            this.label8.Text = "USERNAME";
            // 
            // Login
            // 
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(490, 344);
            this.Controls.Add(this.tabControl2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLogin)).EndInit();
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }
        private void ButtonLogin_Click_1(object sender, EventArgs e)
        {   
            if (this.ValidateChildren(ValidationConstraints.Enabled))
            {
                try
                {
                    ReturnInfo checkUser = _userInfo.GetUserByUsernamePassword(new SmartDB(), TextBoxUsername.Text, TextBoxPassword.Text);
                    var _currentUser = (TMF.Core.Model.UserInfo)checkUser.BizObject;

                    if (_currentUser.IsActive == true)
                    {
                        MessageBox.Show("User is currently login");
                    }
                    else
                    {
                        if (checkUser.Code == ErrorEnum.NoError)
                        {
                            var updateUser = _userInfo.UpdateLoginStatus(new SmartDB(), _currentUser.Username, true);

                            if (updateUser.Code == ErrorEnum.NoError)
                            {
                                var f = new Main(_currentUser);
                                f.Show();
                                this.Hide();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Username or Password not match.");
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Username or Password not match.");
                }
            }
            else
            {
                MessageBox.Show("There are invalid controls on the form.");
            }
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
                TextBoxUsername.Text = "";
                TextBoxPassword.Text = "";
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        protected override void OnClosed(EventArgs e)
        {
            var updateUser = _userInfo.UpdateLoginStatus(new SmartDB(), _currentUsername, false);

            if (updateUser.Code == ErrorEnum.NoError)
            {
                base.OnClosed(e);
                Application.Exit();
            }
            else
            {
                return;
            }
        }
        private void TextBoxUsername_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            bool cancel = false;
            if (string.IsNullOrEmpty(this.TextBoxUsername.Text))
            {
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
                cancel = true;
                this.errorProviderLogin.SetError(this.TextBoxPassword, "You must provide Password!");
            }
            e.Cancel = cancel;
        }
        private void TextBoxPassword_Validated(object sender, EventArgs e)
        {
            this.errorProviderLogin.SetError(this.TextBoxPassword, string.Empty);
        }
        private void Login_Load(object sender, EventArgs e)
        {
            TextBoxUsername.Focus();
        }
        private void ButtonChangePassword_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TextBoxChangeUsername.Text) &&
                !string.IsNullOrWhiteSpace(TextBoxChangePassword.Text))
            {   //Todo EditedBy
                ReturnInfo checkUser = _userInfo.GetUserByUsername(new SmartDB(), TextBoxChangeUsername.Text);
                var orig = (TMF.Core.Model.UserInfo)checkUser.BizObject;
                if (checkUser.Code == ErrorEnum.NoError)
                {
                    var security = Interaction
                        .InputBox(orig.SecurityQuestion, 
                        "Security Question", "", -1, -1);

                    var user = new TMF.Core.Model.UserInfo()
                    {
                        Id = orig.Id,
                        Username = TextBoxChangeUsername.Text,
                        Password = TextBoxChangePassword.Text,
                        Name = orig.Name,
                        Role = orig.Role,
                        SecurityQuestion = orig.SecurityQuestion,
                        SecurityAnswer = orig.SecurityAnswer,
                        IsActive = orig.IsActive
                    };
                    if (security == orig.SecurityAnswer)
                    {
                        var updateUser = _userInfo.Update(new SmartDB(), user);
                        bool flag = updateUser.Code == ErrorEnum.NoError;

                        if (updateUser.Message == "Password is required")
                        {
                            MessageBox.Show("Password is required or Press Esc");
                            return;
                        }
                        if (flag)
                        {
                            MessageBox.Show("User Updated");
                        }
                        else
                        {
                            MessageBox.Show("User is not updated!");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("User not found!");
                }
            }
            else
            {
                MessageBox.Show("Password was not changed");
            }
        }
        private void ButtonConnect_Click(object sender, EventArgs e)
        {
            ButtonConnect.BackColor = Color.Red;
            try
            {
                ConnectionStringManager.Create
                (TextBoxDataSource.Text, TextBoxInitialCatalog.Text,
                    TextBoxDBUsername.Text, TextBoxDBPassword.Text);

                if (IsServerConnected())
                {
                    ButtonConnect.BackColor = Color.Green;
                    MessageBox.Show("Connection Successful.");
                }
                else
                {
                    MessageBox.Show("Connection Unsuccessful.");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return;
            }
            System.Threading.Thread.Sleep(3000);
        }
        public bool IsServerConnected()
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            var connectionString = config.ConnectionStrings.ConnectionStrings["DefaultConnection"];
            using (var conn = new SqlConnection(connectionString.ConnectionString))
            {
                try
                {
                    conn.Open();
                    return true;
                }
                catch (SqlException)
                {
                    return false;
                }
            }
        }
    }
}
