using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using TMF.Core;
using TMF.Core.Model;

namespace MeterReports
{
    public partial class User : Form
    {
        private UserStore<IdentityUser> _userStore;
        private UserManager<IdentityUser> _userManager;
        private readonly TMF.Reports.BLL.User _user;
        private readonly TMF.Reports.BLL.Roles _roles;
        private bool _save;
        private RoleStore<IdentityRole> _roleStore;
        private RoleManager<IdentityRole> _roleManager;
        public User()
        {
            InitializeComponent();
            _userStore = new UserStore<IdentityUser>();
            _userManager = new UserManager<IdentityUser>(_userStore);
            _roleStore = new RoleStore<IdentityRole>();
            _roleManager = new RoleManager<IdentityRole>(_roleStore);
            _user = new TMF.Reports.BLL.User();
            _roles = new TMF.Reports.BLL.Roles();
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
                var user = _userManager.FindByName(TextBoxUsername.Text.Trim());

                var oldRoleId = user.Roles.SingleOrDefault().RoleId;
                var oldRoleName = _roleManager.Roles.SingleOrDefault(r => r.Id == oldRoleId).Name;

                var result1 = _userManager.RemoveFromRole(user.Id, oldRoleName);
                var result2 = _userManager.AddToRole(user.Id, ComboBoxRole.Text);

                var flag = _userManager.Delete(user);

                if (flag.Succeeded && result1.Succeeded && result2.Succeeded)
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
        #region PriveteMethod
        private void SaveUser()
        {
            if (!string.IsNullOrWhiteSpace(TextBoxName.Text))
            {
                var createUser = _userManager.Create(new IdentityUser(TextBoxUsername.Text), TextBoxPassword.Text);
                
                if (createUser.Succeeded)
                {
                    var user = _userManager.FindByName(TextBoxUsername.Text);
                    var claimResult = _userManager.AddToRole(user.Id, ComboBoxRole.Text);
                    if (claimResult.Succeeded)
                    {
                        MessageBox.Show("User Created");
                        ResetControls();
                        BindUserWithDataGrid();
                    }
                    else
                    {
                        MessageBox.Show("Role doesn't Add");
                    }
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

                user.UserName = TextBoxName.Text;
                user.PasswordHash = _userManager.PasswordHasher.HashPassword(TextBoxPassword.Text);

                var flag = _userManager.Update(user);
                
                if (flag.Succeeded)
                {
                    var oldRoleId = user.Roles.SingleOrDefault().RoleId;
                    var oldRoleName = _roleManager.Roles.SingleOrDefault(r => r.Id == oldRoleId).Name;

                    if (oldRoleName != ComboBoxRole.Text)
                    {
                       var result1 = _userManager.RemoveFromRole(user.Id, oldRoleName);
                       var result2 = _userManager.AddToRole(user.Id, ComboBoxRole.Text);
                        if (result1.Succeeded && result2.Succeeded)
                        {
                            MessageBox.Show("User Updated");
                            ResetControls();
                        }
                        else
                        {
                            MessageBox.Show("User doesn't update");
                        }
                    }
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
            ReturnInfo getRoles = _roles.GetRolesList(new SmartDB());
            List<TMF.Reports.Model.Roles> roles = (List<TMF.Reports.Model.Roles>)getRoles.BizObject;
            foreach (var role in roles)
            {
                ComboBoxRole.Items.Add(role.Name);
            }
        }
        private void ResetControls()
        {
            TextBoxName.Enabled = false;
            TextBoxUsername.Enabled = false;
            TextBoxPassword.Enabled = false;
            ComboBoxRole.Enabled = true;
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
            //Todo: getUserList returning null;
            //try
            //{
                ReturnInfo getUserList = _user.GetUserByUserName(new SmartDB(), TextBoxSearch.Text);
                
                List<TMF.Reports.Model.User> user = (List<TMF.Reports.Model.User>)getUserList.BizObject;
                var bindingList = new BindingList<TMF.Reports.Model.User>(user);
                var source = new BindingSource(bindingList, null);
                DataGridViewUser.AutoGenerateColumns = false;
                DataGridViewUser.DataSource = source;
                LabelShow.Text = $"Showing {DataGridViewUser.CurrentRow.Index + 1} index of {DataGridViewUser.RowCount} records";
            //}
            //catch (Exception e)
            //{
            //    return;
            //}
}
        #endregion
    }
}
