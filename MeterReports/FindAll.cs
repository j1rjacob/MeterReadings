using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using TMF.Core;
using TMF.Core.Model;

namespace MeterReports
{
    public partial class FindAll : Form
    {
        private List<TMF.Reports.Model.NodeDTO> _nodeList;
        private TMF.Reports.BLL.NodeDTO _node;
        public FindAll()
        {
            InitializeComponent();
        }
        public void SetNodes()
        {
            TreeViewFind.Nodes.Clear();
            TreeViewFind.ImageList = imageListFind;

            _node = new TMF.Reports.BLL.NodeDTO();
            ReturnInfo node = _node.GetNodes(new SmartDB(), TextBoxSearch.Text);
            _nodeList = (List<TMF.Reports.Model.NodeDTO>)node.BizObject;

            //Cities
            var cities = _nodeList.Select(x => x.City).Distinct().ToList();
            foreach (var city in cities)
            {
                var cityName = city;
                TreeViewFind.Nodes.Add(cityName, cityName, 0, 0);
            }

            //DMZ
            var dmzs = _nodeList.GroupBy(x => new { x.City, x.DMZ })
                .Select(g => g.First())
                .Where(d => d.DMZ != "");

            foreach (var dmz in dmzs)
            {
                var city = TreeViewFind.Nodes.Find(dmz.City, true);

                TreeViewFind.Nodes[city[0].Text]
                    .Nodes
                    .Add(dmz.DMZ, dmz.DMZ, 1, 1);
            }

            //MacAddress
            var macs = _nodeList.GroupBy(x => new { x.City, x.DMZ, x.MacAddress })
                .Select(g => g.First())
                .Where(m => m.MacAddress != "" && m.DMZ != "");

            foreach (var mac in macs)
            {
                var nodeCity = TreeViewFind.Nodes.Find(mac.City, true);
                var nodeDMZ = TreeViewFind.Nodes.Find(mac.DMZ, true);

                TreeViewFind.Nodes[nodeCity[0].Text]
                    .Nodes[nodeDMZ[0].Text]
                    .Nodes
                    .Add(mac.MacAddress, mac.MacAddress, 2, 2);

            }

            //Meters
            var meters = _nodeList.GroupBy(x => new { x.City, x.DMZ, x.MacAddress, x.SerialNumber })
                .Select(g => g.First())
                .Where(m => m.MacAddress != "" && m.DMZ != "" && m.SerialNumber != "");

            foreach (var meter in meters)
            {
                var nodeCity = TreeViewFind.Nodes.Find(meter.City, true);
                var nodeDMZ = TreeViewFind.Nodes.Find(meter.DMZ, true);
                var nodeMac = TreeViewFind.Nodes.Find(meter.MacAddress, true);

                TreeViewFind.Nodes[nodeCity[0].Text]
                    .Nodes[nodeDMZ[0].Text]
                    .Nodes[nodeMac[0].Text]
                    .Nodes.AddRange(
                        new TreeNode[] { new TreeNode(meter.SerialNumber, 2, 2,
                            new TreeNode[]
                            {
                                new TreeNode("Info",3,3),
                                new TreeNode("Reading",3,3),
                                new TreeNode("GPS", 3, 3)
                            })
                        });
            }
            //Set Selected Node
            //TreeViewFind.Nodes[0]
            //    .Nodes[0]
            //    .Nodes[0]
            //    .Nodes[0].IsSelected; 
            _nodeList.Clear();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                SetNodes();
                return true;
            }
            if (keyData == Keys.Escape)
            {
                TextBoxSearch.Clear();
                TreeViewFind.Nodes.Clear();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
