using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Windows.Forms;

namespace MeterReports
{
    public partial class User : Form
    {
        private UserStore<IdentityUser> _userStore;
        private UserManager<IdentityUser> _userManager;
        private bool _save;

        public User()
        {
            InitializeComponent();
            _save = true;
        }

        private void User_Load(object sender, EventArgs e)
        {
            _userStore = new UserStore<IdentityUser>();
            _userManager = new UserManager<IdentityUser>(_userStore);
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TextBoxName.Text))
            {   
                var user = _userManager.FindByName(TextBoxUsername.Text.Trim());
                
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

        #region PriveteMethod
        private void SaveUser()
        {
            if (!string.IsNullOrWhiteSpace(TextBoxName.Text))
            {
                //TMF.Reports.Model.DMZ dmz = new TMF.Reports.Model.DMZ()
                //{   //TODO User id for CreatedBy
                //    Description = TextBoxDescription.Text,
                //    CityId = ComboBoxCity.Text,
                //    TotalNumberOfMeters = Convert.ToInt32(TextBoxTotalMeters.Text),
                //    CreatedBy = "646f18f9-6425-4769-aa79-16ecdb7cf816",
                //    DocDate = DateTime.Now,
                //    Show = 1,
                //    LockCount = 0
                //};

                //var createDMZ = _dmz.Create(new SmartDB(), ref dmz);

                var createUser = _userManager.Create(new IdentityUser(TextBoxUsername.Text), TextBoxPassword.Text);
                //MessageBox.Show($"Created: {createUser.Succeeded}");

                //bool flag = createDMZ.Code == ErrorEnum.NoError;
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

                user.UserName = TextBoxName.Text;
                user.PasswordHash = _userManager.PasswordHasher.HashPassword(TextBoxPassword.Text);

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
            //ComboBoxCity.Items.Clear();
            //ReturnInfo getCity = _city.GetCityList(new SmartDB());
            //List<TMF.Reports.Model.City> cities = (List<TMF.Reports.Model.City>)getCity.BizObject;
            //foreach (var city in cities)
            //{
            //    ComboBoxCity.Items.Add(city.Description);
            //}
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
            try
            {
                //ReturnInfo getDMZList = _dmz.GetDMZByDescription(new SmartDB(), TextBoxSearch.Text);
                ////bool flag = getCityList.Code == ErrorEnum.NoError;
                //List<TMF.Reports.Model.DMZ> dmz = (List<TMF.Reports.Model.DMZ>)getDMZList.BizObject;
                //var bindingList = new BindingList<TMF.Reports.Model.DMZ>(dmz);
                //var source = new BindingSource(bindingList, null);
                //DataGridViewDMZ.AutoGenerateColumns = false;
                //DataGridViewDMZ.DataSource = source;
                //LabelShow.Text = $"Showing {DataGridViewDMZ.CurrentRow.Index + 1} index of {DataGridViewDMZ.RowCount} records";
            }
            catch (Exception e)
            {
                return;
            }
        }
        #endregion
    }
}
