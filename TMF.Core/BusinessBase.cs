using System;
using System.Diagnostics;
using System.Reflection;
using System.Security;

namespace TMF.Core
{
    public class BusinessBase
    {
        private static Type declaringType = null;

        public static Type DeclaringType
        {
            get
            {
                return BusinessBase.declaringType;
            }
            set
            {
                BusinessBase.declaringType = value;
            }
        }

        public string getMethodName()
        {
            string result = "";
            try
            {
                StackTrace stackTrace = new StackTrace(true);
                int i;
                for (i = 0; i < stackTrace.FrameCount; i++)
                {
                    StackFrame frame = stackTrace.GetFrame(i);
                    bool flag = frame != null && frame.GetMethod().DeclaringType == base.GetType();
                    if (flag)
                    {
                        break;
                    }
                }
                bool flag2 = i < stackTrace.FrameCount;
                if (flag2)
                {
                    StackFrame frame2 = stackTrace.GetFrame(i);
                    bool flag3 = frame2 != null;
                    if (flag3)
                    {
                        MethodBase method = frame2.GetMethod();
                        bool flag4 = method != null;
                        if (flag4)
                        {
                            result = method.Name;
                        }
                    }
                }
            }
            catch (SecurityException)
            {
            }
            return result;
        }

        private string getTopMostMethodName()
        {
            string result = "";
            try
            {
                StackTrace stackTrace = new StackTrace(true);
                int i;
                for (i = 0; i < stackTrace.FrameCount; i++)
                {
                    StackFrame frame = stackTrace.GetFrame(i);
                    bool flag = frame != null && frame.GetMethod().DeclaringType == base.GetType();
                    if (flag)
                    {
                        break;
                    }
                }
                while (i < stackTrace.FrameCount)
                {
                    StackFrame frame2 = stackTrace.GetFrame(i);
                    bool flag2 = frame2 != null && frame2.GetMethod().DeclaringType != base.GetType();
                    if (flag2)
                    {
                        break;
                    }
                    i++;
                }
                bool flag3 = i < stackTrace.FrameCount;
                if (flag3)
                {
                    StackFrame frame3 = stackTrace.GetFrame(i);
                    bool flag4 = frame3 != null;
                    if (flag4)
                    {
                        MethodBase method = frame3.GetMethod();
                        bool flag5 = method != null;
                        if (flag5)
                        {
                            result = method.Name;
                        }
                    }
                }
            }
            catch (SecurityException)
            {
            }
            return result;
        }

        public static string StaticGetMethodName()
        {
            string result = "";
            try
            {
                StackTrace stackTrace = new StackTrace(true);
                int i;
                for (i = 0; i < stackTrace.FrameCount; i++)
                {
                    StackFrame frame = stackTrace.GetFrame(i);
                    bool flag = frame != null && frame.GetMethod().DeclaringType == BusinessBase.declaringType;
                    if (flag)
                    {
                        break;
                    }
                }
                bool flag2 = i < stackTrace.FrameCount;
                if (flag2)
                {
                    StackFrame frame2 = stackTrace.GetFrame(i);
                    bool flag3 = frame2 != null;
                    if (flag3)
                    {
                        MethodBase method = frame2.GetMethod();
                        bool flag4 = method != null;
                        if (flag4)
                        {
                            result = method.Name;
                        }
                    }
                }
            }
            catch (SecurityException)
            {
            }
            return result;
        }
    }
}
