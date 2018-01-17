using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TMF.Core;
using TMF.Core.Model;

namespace MeterReports
{
    public partial class Main : Form
    {
        private readonly TMF.Core.Model.UserInfo _currentUser;
        private readonly TMF.Reports.BLL.City _city;
        private readonly TMF.Reports.BLL.Gateway _gateway;
        private readonly TMF.Reports.BLL.Meter _meter;

        public Main()
        {
                
        }
        public Main(TMF.Core.Model.UserInfo currentUser)
        {
            InitializeComponent();
            _currentUser = currentUser;
            _city = new TMF.Reports.BLL.City();
            _gateway = new TMF.Reports.BLL.Gateway();
            _meter = new TMF.Reports.BLL.Meter();
        }

        private bool OpenForms<T>()
        {
            bool result=false;
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(T))
                {
                    form.WindowState = FormWindowState.Normal;                    
                    result =true;
                    break;
                }
            }
            return result;
        }
        private void treeViewMain_DoubleClick(object sender, EventArgs e)
        {
            TreeNode node = treeViewMain.SelectedNode;
            
            switch (node.Text)
            {
                case "User":
                    userToolStripMenuItem.PerformClick();
                    break;
                case "Gateway":
                    gatewayToolStripMenuItem.PerformClick();
                    break;
                case "Meter":
                    meterToolStripMenuItem.PerformClick();
                    break;
                case "Meter Type":
                    meterTypeToolStripMenuItem.PerformClick();
                    break;
                case "Meter Protocol":
                    meterProtocolToolStripMenuItem.PerformClick();
                    break;
                case "Meter Size":
                    meterSizeToolStripMenuItem.PerformClick();
                    break;
                case "City":
                    cityToolStripMenuItem.PerformClick();
                    break;
                case "DMZ":
                    dMZToolStripMenuItem.PerformClick();
                    break;
                case "Meter Reading":
                    meterReadingToolStripMenuItem.PerformClick();
                    break;
                default:
                    break;
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            logoutToolStripMenuItem.Text = $"Logout {_currentUser.Username}";
            GetCities();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form c in this.MdiChildren)
            {
                c.Close();
            }

            var l = new Login(_currentUser.Username);
            l.Show();
            this.Hide();
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            logoutToolStripMenuItem.PerformClick();
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var user = new User(_currentUser);
            if (!OpenForms<User>())
            {
                user.MdiParent = this;
                user.Show();
            }
        }

        private void gatewayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var gw = new Gateway(_currentUser);
            if (!OpenForms<Gateway>())
            {
                gw.MdiParent = this;
                gw.Show();
            }
        }

        private void meterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var m = new Meter(_currentUser);
            if (!OpenForms<Meter>())
            {
                m.MdiParent = this;
                m.Show();
            }
        }

        private void meterTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var mt = new MeterType(_currentUser);
            if (!OpenForms<MeterType>())
            {
                mt.MdiParent = this;
                mt.Show();
            }
        }
        private void meterProtocolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var mp = new MeterProtocol(_currentUser);
            if (!OpenForms<MeterType>())
            {
                mp.MdiParent = this;
                mp.Show();
            }
        }
        private void meterSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ms = new MeterSize(_currentUser);
            if (!OpenForms<MeterType>())
            {
                ms.MdiParent = this;
                ms.Show();
            }
        }
        private void dMZToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var d = new DMZ(_currentUser);
            if (!OpenForms<DMZ>())
            {
                d.MdiParent = this;
                d.Show();
            }
        }
        private void cityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ct = new Citi(_currentUser);
            if (!OpenForms<Citi>())
            {
                ct.MdiParent = this;
                ct.Show();
            }
        }
        private void meterReadingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var m = new MeterReading(_currentUser);
            if (!OpenForms<MeterReading>())
            {
                m.MdiParent = this;
                m.Show();
            }
        }

        private void treeViewMain_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void restoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var r = new DbaseUtil(1);
            if (!OpenForms<DbaseUtil>())
            {
                r.MdiParent = this;
                r.Show();
            }
        }

        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var b = new DbaseUtil(0);
            if (!OpenForms<DbaseUtil>())
            {
                b.MdiParent = this;
                b.Show();
            }
        }

        private void waterConsumptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var wc = new FormWaterConsumption();
            if (!OpenForms<FormWaterConsumption>())
            {
                wc.MdiParent = this;
                wc.Show();
            }
        }

        private void meterReadingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rmr = new ReportMeterReading();
            if (!OpenForms<FormWaterConsumption>())
            {
                rmr.MdiParent = this;
                rmr.Show();
            }
        }
        
        public void GetCities()
        {
            ReturnInfo getCityList = _city.GetCityByDescription(new SmartDB(), "");
            var city = (List<TMF.Reports.Model.City>)getCityList.BizObject;

            ReturnInfo getGatewayList = _gateway.GetGatewayBySimCard(new SmartDB(), "");
            List<TMF.Reports.Model.Gateway> gateway = (List<TMF.Reports.Model.Gateway>)getGatewayList.BizObject;

            ReturnInfo getMeterList = _meter.GetMeterBySerialNumber(new SmartDB(), "");
            List<TMF.Reports.Model.Meter> meter = (List<TMF.Reports.Model.Meter>)getMeterList.BizObject;

            TreeViewMeters.Nodes.Clear();

            foreach (var c in city)
            {
                var str = c.Description;
                TreeViewMeters.Nodes.Add(str, str, 0, 0);
            }

            var uniqueMacs = meter.GroupBy(x => new { x.CityId, x.MacAddress } )
                         .Select(g => g.First());
            
            foreach (var um in uniqueMacs)
            {
                string description = (from c in city
                    where c.Id == um.CityId
                    select c.Description).First();

                var node = TreeViewMeters.Nodes.Find(description, true);

                TreeViewMeters.Nodes[node[0].Text]
                    .Nodes
                    .Add(um.MacAddress, um.MacAddress, 1, 1);
            }

            foreach (var m in meter)
            {
                string description = (from c in city
                                      where c.Id == m.CityId
                                      select c.Description).First();


                var node1 = TreeViewMeters.Nodes.Find(description, true);

                string macAddress = (from n in meter
                                     where n.SerialNumber == m.SerialNumber
                                     select n.MacAddress).First();

                var node2 = TreeViewMeters.Nodes.Find(macAddress, true);
                
                TreeViewMeters.Nodes[node1[0].Text]
                    .Nodes[node2[0].Text]
                    
                    .Nodes.AddRange(
                        new TreeNode[] { new TreeNode(m.SerialNumber, 2, 2, 
                        new TreeNode[]
                        {
                            new TreeNode("Info",3,3),
                            new TreeNode("Reading",3,3),
                            new TreeNode("GPS", 3, 3)
                        })
                        });
            }
            TreeViewMeters.EndUpdate();
        }

        private void TreeViewMeters_DoubleClick(object sender, EventArgs e)
        {
            TreeNode node = TreeViewMeters.SelectedNode;
            //MessageBox.Show($"{node.Parent.Text} {node.Text}");
            switch (node.Text)
            {
                case "Info":
                    var m = new Meter(_currentUser);
                    if (!OpenForms<Meter>())
                    {
                        m.MdiParent = this;
                        m.Show();
                        m.TextBoxSearch.Text = node.Parent.Text;
                        m.ButtonSearch.PerformClick();
                    }
                    break;
                case "Reading":
                    var mr = new MeterReading(_currentUser);
                    if (!OpenForms<MeterReading>())
                    {
                        mr.MdiParent = this;
                        mr.Show();
                        mr.TextBoxSearch.Text = node.Parent.Text;
                        mr.ButtonSearch.PerformClick();
                        mr.DataGridViewMeterReading.FirstDisplayedScrollingRowIndex = mr.DataGridViewMeterReading.RowCount - 1;
                        // select new row
                        mr.DataGridViewMeterReading.Rows[mr.DataGridViewMeterReading.Rows.Count - 1].Selected = true;
                        mr.DataGridViewMeterReading_SelectionChanged(this, new EventArgs());
                    }
                    break;
                case "GPS":
                    //var m = new Meter(_currentUser);
                    //if (!OpenForms<Meter>())
                    //{
                    //    m.MdiParent = this;
                    //    m.Show();
                    //    m.TextBoxSearch.Text = node.Parent.Text;
                    //    m.ButtonSearch.PerformClick();
                    //}
                    break;
                default:
                    break;
            }
        }
    }
}
