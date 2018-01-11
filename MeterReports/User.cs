using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using TMF.Core;
using TMF.Core.Model;

namespace MeterReports
{

    public partial class User : Form
    {
       
        private readonly UserInfoBLL _userInfo;
        private readonly TMF.Core.Model.UserInfo _currentUser;
        private string _userId;
        private bool _save;
        public User(TMF.Core.Model.UserInfo currentUser)
        {
            InitializeComponent();
            
            _userInfo = new UserInfoBLL();
            _currentUser = currentUser;
            _userId = "";
            _save = true;
        }
        private void User_Load(object sender, EventArgs e)
        {
            ResetControls();
            GetRoles();
        }
        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TextBoxName.Text) &&
                _currentUser.Role == "Administrator")
            {
                var updateUser = _userInfo.Delete(new SmartDB(), _userId);
                bool flag = updateUser.Code == ErrorEnum.NoError;

                if (flag)
                {
                    MessageBox.Show("User Deleted");
                    ResetControls();
                }
                else
                {
                    MessageBox.Show("User is not deleted!");
                }
            }
            else
            {
                MessageBox.Show("No User to delete or Contact Admin.");
            }
        }
        private void ButtonNew_Click(object sender, EventArgs e)
        {
            TextBoxName.Enabled = true;
            TextBoxUsername.Enabled = true;
            TextBoxPassword.Enabled = true;
            ComboBoxRole.Enabled = true;
            ButtonEdit.Enabled = false;
            ButtonSave.Enabled = true;
            ButtonDelete.Enabled = false;
            TextBoxName.Text = "";
            TextBoxUsername.Text = "";
            TextBoxPassword.Text = "";
            _userId = "";
            TextBoxName.Focus();
        }
        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            TextBoxName.Enabled = true;
            TextBoxUsername.Enabled = true;
            TextBoxPassword.Enabled = true;
            ComboBoxRole.Enabled = true;
            ButtonNew.Enabled = false;
            ButtonEdit.Enabled = true;
            ButtonSave.Enabled = true;
            ButtonDelete.Enabled = false;
            TextBoxPassword.Clear();
            _save = false;
            TextBoxName.Focus();
        }
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (_save)
                SaveUser();
            else
                EditUser();
        }
        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            BindUserWithDataGrid();
        }

        private void DataGridViewUser_SelectionChanged(object sender, EventArgs e)
        {
            LabelShow.Text = $"Showing {DataGridViewUser.CurrentRow.Index + 1} index of {DataGridViewUser.RowCount} records";

            string userId;
            try
            {
                userId = (string)DataGridViewUser.CurrentRow.Cells[0].Value;
            }
            catch (Exception)
            {
                return;
            }

            try
            {
                ReturnInfo getUser = _userInfo.GetUserById(new SmartDB(), userId);
                bool flag = getUser.Code == ErrorEnum.NoError;
                var user = (TMF.Core.Model.UserInfo)getUser.BizObject;

                if (user.Id == "" ? false : true)
                {
                    TextBoxName.Text = user.Name;
                    TextBoxUsername.Text = user.Username;
                    TextBoxPassword.Text = user.Password;
                    ComboBoxRole.Text = user.Role;
                    _userId = user.Id;
                    ButtonEdit.Enabled = true;
                    ButtonDelete.Enabled = true;
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        #region PriveteMethod
        private void SaveUser()
        {
            ReturnInfo checkUser = _userInfo.GetUserByUsername(new SmartDB(), TextBoxUsername.Text);
            
            if (checkUser.Code == ErrorEnum.NoRecord || 
                checkUser.Code == ErrorEnum.NoError)
            {
                if (!string.IsNullOrWhiteSpace(TextBoxName.Text) &&
                                _currentUser.Role == "Administrator")
                {
                    TMF.Core.Model.UserInfo user = new TMF.Core.Model.UserInfo()
                    {
                        Id = Guid.NewGuid().ToString("N"),
                        Username = TextBoxUsername.Text,
                        Password = TextBoxPassword.Text,
                        Name = TextBoxName.Text,
                        Role = ComboBoxRole.Text,
                        IsActive = false
                    };
                   
                    var createUser = _userInfo.Create(new SmartDB(), ref user);
                    bool flag = createUser.Code == ErrorEnum.NoError;
                    
                    if (createUser.Code == ErrorEnum.UniqueConstraint)
                    {
                        MessageBox.Show("Username Duplicate");
                        return;
                    }
                    if (flag)
                    {
                        MessageBox.Show("User Created");
                        ResetControls();
                        BindUserWithDataGrid();
                    }
                    else
                    {
                        MessageBox.Show("User not created");
                    }
                }
                else
                    MessageBox.Show("No User to save or Contact Admin.");
            }
        }
        private void EditUser()
        {
            if (!string.IsNullOrWhiteSpace(TextBoxName.Text) &&
                _currentUser.Role == "Administrator")
            {   //Todo EditedBy
                TMF.Core.Model.UserInfo user = new TMF.Core.Model.UserInfo()
                {
                    Id = _userId,
                    Username = TextBoxUsername.Text,
                    Password = TextBoxPassword.Text,
                    Name = TextBoxName.Text,
                    Role = ComboBoxRole.Text,
                    IsActive = true
                };

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
                    ResetControls();
                }
                else
                {
                    MessageBox.Show("User is not updated!");
                }
            }
            else
            {
                MessageBox.Show("No User to edit or Contact Admin.");
            }
        }
        private void GetRoles()
        {
            ComboBoxRole.Items.Clear();
            ComboBoxRole.DataSource = Enum.GetValues(typeof(UserLevel));
        }
        private void ResetControls()
        {
            TextBoxName.Enabled = false;
            TextBoxUsername.Enabled = false;
            TextBoxPassword.Enabled = false;
            ComboBoxRole.Enabled = false;
            TextBoxSearch.Text = "";
            TextBoxName.Text = "";
            TextBoxUsername.Text = "";
            TextBoxPassword.Text = "";
            ComboBoxRole.Text = "";
            ButtonNew.Enabled = true;
            ButtonEdit.Enabled = false;
            ButtonSave.Enabled = false;
            ButtonDelete.Enabled = false;
            _save = true;
            BindUserWithDataGrid();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape || keyData == Keys.F5)
            {
                ResetControls();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void BindUserWithDataGrid()
        {   //TODO: Refactor this for reuse. 
            try
            {
                ReturnInfo getUserList = _userInfo.GetUsersByName(new SmartDB(), TextBoxSearch.Text);

                List<TMF.Core.Model.UserInfo> user = (List<TMF.Core.Model.UserInfo>)getUserList.BizObject;
                var bindingList = new BindingList<TMF.Core.Model.UserInfo>(user);
                var source = new BindingSource(bindingList, null);
                DataGridViewUser.AutoGenerateColumns = false;
                DataGridViewUser.DataSource = source;
                LabelShow.Text = $"Showing {DataGridViewUser.CurrentRow.Index + 1} index of {DataGridViewUser.RowCount} records";
            }
            catch (Exception)
            {
                return;
            }
        }
        #endregion
    }
}
