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
    public enum UserStatus
    {
        Unlocked = 0,
        Locked = 1
        
    }
    public partial class User : Form
    {
        private CustomUserStore _userStore;
        private UserManager<CustomUser, int> _userManager;
        private readonly TMF.Reports.BLL.User _user;
        private readonly CustomUser _currentUser;
        private int _userId;
        private bool _save;
        public User(CustomUser currentUser)
        {
            InitializeComponent();
            _userStore = new CustomUserStore(new CustomUserDbContext());
            _userManager = new UserManager<CustomUser, int>(_userStore);
            _user = new TMF.Reports.BLL.User();
            _currentUser = currentUser;
            _userId = 0;
            _save = true;
        }
        private void User_Load(object sender, EventArgs e)
        {
            ResetControls();
            GetStatus();
        }
        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TextBoxName.Text) &&
                _currentUser.Role == "Administrator")
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
        private void ButtonLock_Click(object sender, EventArgs e)
        {
            PerformLock();
        }
        
        private void ButtonUnlock_Click(object sender, EventArgs e)
        {
            PerformUnlock();
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
            catch (Exception)
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
            catch (Exception)
            {
                return;
            }
        }
        private void DataGridViewUser_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewUser.Rows[e.RowIndex].Cells[5].Value = "Lock";
            DataGridViewUser.Rows[e.RowIndex].Cells[6].Value = "UnLock";
        }
        private void DataGridViewUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //var senderGrid = (DataGridView)sender;

            //if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
            //    e.RowIndex >= 0)
            //{
            //    PerformLock();
            //}
            //if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
            //    e.RowIndex >= 0)
            //{
            //    PerformUnlock();
            //}

            DataGridViewButtonCell cell = (DataGridViewButtonCell)DataGridViewUser
                                          .Rows[e.RowIndex].Cells[e.ColumnIndex];
            string selectedCell = cell.Value.ToString();

            if (selectedCell == "Lock")
            {
                PerformLock();
            }
            if (selectedCell == "UnLock")
            {
                PerformUnlock();
            }
        }

        #region PriveteMethod
        private void PerformLock()
        {
            if (!string.IsNullOrWhiteSpace(TextBoxName.Text) &&
                _currentUser.Role == "Administrator")
            {
                var user = _userManager.FindById(_userId);

                user.Locked = 1;

                var flag = _userManager.Update(user);

                if (flag.Succeeded)
                {
                    MessageBox.Show("User Locked");
                    ResetControls();
                }
                else
                {
                    MessageBox.Show("User is not locked!");
                }
            }
            else
            {
                MessageBox.Show("No User to edit.");
            }
        }
        private void PerformUnlock()
        {
            if (!string.IsNullOrWhiteSpace(TextBoxName.Text) &&
                _currentUser.Role == "Administrator")
            {
                var user = _userManager.FindById(_userId);

                user.Locked = 0;

                var flag = _userManager.Update(user);

                if (flag.Succeeded)
                {
                    MessageBox.Show("User Unlocked");
                    ResetControls();
                }
                else
                {
                    MessageBox.Show("User is not unlocked!");
                }
            }
            else
                MessageBox.Show("No User to unlocked.");
        }
        private void SaveUser()
        {
            if (!string.IsNullOrWhiteSpace(TextBoxName.Text) &&
                _currentUser.Role == "Administrator")
            {
                CustomUser user = new CustomUser
                {
                    FullName = TextBoxName.Text,
                    UserName = TextBoxUsername.Text,
                    Role = ComboBoxRole.Text,
                    Locked = (int)(UserStatus)Enum.Parse(typeof(UserStatus), ComboBoxStatus.Text)
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
                MessageBox.Show("No User to save or Contact Admin.");
        }
        private void EditUser()
        {
            if (!string.IsNullOrWhiteSpace(TextBoxName.Text) &&
                _currentUser.Role == "Administrator")
            {   //Todo EditedBy
                var user = _userManager.FindById(_userId);

                user.FullName = TextBoxName.Text;
                user.UserName = TextBoxUsername.Text;
                user.PasswordHash = _userManager.PasswordHasher.HashPassword(TextBoxPassword.Text);
                user.Role = ComboBoxRole.Text;
                user.Locked = (int)(UserStatus)Enum.Parse(typeof(UserStatus), ComboBoxStatus.Text);

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
                MessageBox.Show("No User to edit or Contact Admin.");
            }
        }
        private void GetRoles()
        {
            ComboBoxRole.Items.Clear();
            ComboBoxRole.Items.Add("Administrator");
            ComboBoxRole.Items.Add("Encoder");
        }

        private void GetStatus()
        {
            ComboBoxStatus.Items.Clear();
            ComboBoxStatus.DataSource = Enum.GetValues(typeof(UserStatus));
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
                ReturnInfo getUserList = _user.GetUserByUserName(new SmartDB(), TextBoxSearch.Text);
                
                List<TMF.Reports.Model.User> user = (List<TMF.Reports.Model.User>)getUserList.BizObject;
                var bindingList = new BindingList<TMF.Reports.Model.User>(user);
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
