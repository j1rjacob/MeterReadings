using System;

namespace TMF.Core.Model
{
    [Serializable]
    public class ReturnInfo : IInfo
    {
        private ErrorEnum returnCode = ErrorEnum.NoError;

        private string returnMessage = "";

        private int rowsAffected = 0;

        private object bizObject = null;

        public int RowsAffected
        {
            get
            {
                return this.rowsAffected;
            }
            set
            {
                this.rowsAffected = value;
            }
        }

        public object BizObject
        {
            get
            {
                return this.bizObject;
            }
            set
            {
                this.bizObject = value;
            }
        }

        public ErrorEnum Code
        {
            get
            {
                return this.returnCode;
            }
            set
            {
                this.returnCode = value;
            }
        }

        public string Message
        {
            get
            {
                return this.returnMessage;
            }
            set
            {
                this.returnMessage = value;
            }
        }

        public ReturnInfo()
        {
            this.returnCode = ErrorEnum.NoError;
            this.returnMessage = "";
            this.rowsAffected = 0;
        }

        public ReturnInfo(ErrorEnum returnCode, string returnMessage)
        {
            this.returnCode = returnCode;
            this.returnMessage = returnMessage;
            this.rowsAffected = 0;
        }

        public ReturnInfo(ErrorEnum returnCode, string returnMessage, int rowsAffected)
        {
            this.returnCode = returnCode;
            this.returnMessage = returnMessage;
            this.rowsAffected = rowsAffected;
        }

        protected void Clear()
        {
            this.returnCode = ErrorEnum.NoError;
            this.returnMessage = "";
            this.rowsAffected = 0;
        }
    }
}
