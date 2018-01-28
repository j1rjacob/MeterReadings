using NUnit.Framework;
using System.Collections.Generic;
using TMF.Core;
using TMF.Core.Model;

namespace MeterReports.Test
{
    [TestFixture]
    public class Nodes
    {
        private readonly TMF.Reports.BLL.NodeDTO _node;
        public Nodes()
        {
            _node = new TMF.Reports.BLL.NodeDTO();
        }

        [Test]
        public void Node_LST_Equal()
        {
            //Arrange
            //Act
            ReturnInfo node = _node.GetNodes(new SmartDB(), "");
            bool flag = node.Code == ErrorEnum.NoError;
            List<TMF.Reports.Model.NodeDTO> _nodeList = (List<TMF.Reports.Model.NodeDTO>)node.BizObject;
            //node.
            //Assert
            Assert.AreEqual(_nodeList.Count, 1137);
        }
    }
}
