using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using TMF.Core;
using TMF.Core.Model;
using TMF.Reports.BLL;
using TMF.Reports.Model;

namespace MeterReports
{
    public partial class User : Form
    {
        private CustomUserStore _userStore;
        private UserManager<CustomUser, int> _userManager;
        private readonly TMF.Reports.BLL.User _user;
        private int _userId;
        private bool _save;
        public User()
        {
            InitializeComponent();
            _userStore = new CustomUserStore(new CustomUserDbContext());
            _userManager = new UserManager<CustomUser, int>(_userStore);
            _user = new TMF.Reports.BLL.User();
            _userId = 0;
            _save = true;
        }
        private void User_Load(object sender, EventArgs e)
        {
            ResetControls();
        }
        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TextBoxName.Text))
            {   
                var user = _userManager.FindById(_userId);

                var flag = _userManager.Delete(user);

                if (flag.Succeeded)
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
                MessageBox.Show("No User to delete.");
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
            ComboBoxRole.Enabled = true;
            _userId = 0;
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
            _save = false;
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
        private void ComboBoxRole_MouseClick(object sender, MouseEventArgs e)
        {
            GetRoles();
        }
        private void DataGridViewUser_SelectionChanged(object sender, EventArgs e)
        {
            LabelShow.Text = $"Showing {DataGridViewUser.CurrentRow.Index + 1} index of {DataGridViewUser.RowCount} records";

            int userId;
            try
            {
                userId = (int)DataGridViewUser.CurrentRow.Cells[0].Value;
            }
            catch (Exception exception)
            {
                return;
            }
            ReturnInfo getUser = _user.GetUserById(new SmartDB(), userId);
            bool flag = getUser.Code == ErrorEnum.NoError;
            TMF.Reports.Model.User user = (TMF.Reports.Model.User)getUser.BizObject;

            try
            {
                if (user.Id == 0 ? false : true)
                {
                    TextBoxName.Text = user.FullName;
                    TextBoxUsername.Text = user.UserName;
                    ComboBoxRole.Text = user.Role;
                    _userId = user.Id;
                    ButtonEdit.Enabled = true;
                    ButtonDelete.Enabled = true;
                }
            }
            catch (Exception jerry)
            {
                return;
            }
        }
        #region PriveteMethod
        private void SaveUser()
        {
            if (!string.IsNullOrWhiteSpace(TextBoxName.Text))
            {
                CustomUser user = new CustomUser
                {
                    FullName = TextBoxName.Text,
                    UserName = TextBoxUsername.Text,
                    Role = ComboBoxRole.Text
                };

                var createUser = _userManager.Create(user, TextBoxPassword.Text);
                
                if (createUser.Succeeded)
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
                MessageBox.Show("No User to save.");
        }
        private void EditUser()
        {
            if (!string.IsNullOrWhiteSpace(TextBoxName.Text))
            {   //Todo EditedBy

                var user = _userManager.FindByName(TextBoxUsername.Text.Trim());

                user.FullName = TextBoxName.Text;
                user.UserName = TextBoxUsername.Text;
                user.PasswordHash = _userManager.PasswordHasher.HashPassword(TextBoxPassword.Text);
                user.Role = ComboBoxRole.Text;

                var flag = _userManager.Update(user);
                
                if (flag.Succeeded)
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
                MessageBox.Show("No User to edit.");
            }
        }
        private void GetRoles()
        {
            ComboBoxRole.Items.Clear();
            ComboBoxRole.Items.Add("Administrator");
            ComboBoxRole.Items.Add("Encoder");
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
            ComboBoxRole.Items.Clear();
            ButtonNew.Enabled = true;
            ButtonEdit.Enabled = false;
            ButtonSave.Enabled = false;
            ButtonDelete.Enabled = false;
            _save = true;
            BindUserWithDataGrid();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                ResetControls();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        //private int GetLockCount(int Id)
        //{
        //    IInfo info = _dmz.GetDMZById(new SmartDB(), Id);
        //    var lockcount = (info.BizObject as TMF.Reports.Model.DMZ).LockCount;
        //    return lockcount;
        //}
        private void BindUserWithDataGrid()
        {   //TODO: Refactor this for reuse. 
            try
            {
                ReturnInfo getUserList = _user.GetUserByUserName(new SmartDB(), TextBoxSearch.Text);
                
                List<TMF.Reports.Model.User> user = (List<TMF.Reports.Model.User>)getUserList.BizObject;
                var bindingList = new BindingList<TMF.Reports.Model.User>(user);
                var source = new BindingSource(bindingList, null);
                DataGridViewUser.AutoGenerateColumns = false;
                DataGridViewUser.DataSource = source;
                LabelShow.Text = $"Showing {DataGridViewUser.CurrentRow.Index + 1} index of {DataGridViewUser.RowCount} records";
            }
            catch (Exception e)
            {
                return;
            }
        }
        #endregion
    }
}
