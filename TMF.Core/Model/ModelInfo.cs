using System;

namespace TMF.Core.Model
{
    [Serializable]
    public class ModelInfo
    {
        public bool IsDirty
        {
            get;
            set;
        }

        public bool IsNew
        {
            get;
            set;
        }

        public bool IsDeleted
        {
            get;
            set;
        }

        public object this[string fieldname]
        {
            get
            {
                return this.OnGetValue(fieldname);
            }
            set
            {
                this.OnSetValue(fieldname, value);
            }
        }

        protected bool IsNull(object Value)
        {
            return Value == null || Value == DBNull.Value;
        }

        public ModelInfo()
        {
            this.IsDirty = false;
            this.IsNew = true;
            this.IsDeleted = false;
        }

        protected virtual void OnSetValue(string fieldname, object value)
        {
        }

        protected virtual object OnGetValue(string fieldname)
        {
            return null;
        }
    }
}
