namespace TMF.Core
{
    public interface IInfo
    {
        ErrorEnum Code
        {
            get;
            set;
        }

        string Message
        {
            get;
            set;
        }

        object BizObject
        {
            get;
            set;
        }

        int RowsAffected
        {
            get;
            set;
        }
    }
}
