using TMF.Core;
using TMF.Core.Model;

namespace TMF.Reports.BLL
{
    public class NodeDTO : BusinessBase
    {
        private static readonly DAL.NodeDTO _dal = new DAL.NodeDTO();

        public IInfo CheckRight()
        {
            return new ReturnInfo(ErrorEnum.NoError, "");
        }
        public ReturnInfo GetNodes(SmartDB dbInstance)
        {
            IInfo records = _dal.GetRecordsByDescription(dbInstance,"");
            return new ReturnInfo
            {
                BizObject = ((records.Code == ErrorEnum.NoError) ? records.BizObject : null),
                Code = records.Code,
                Message = records.Message,
                RowsAffected = records.RowsAffected
            };
        }
    }
}
