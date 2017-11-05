using System;

namespace TMF.Core
{
    public class CastDBNull
    {
        public static T To<T>(object value, T defaultValue)
        {
            T result;
            try
            {
                bool flag = value != DBNull.Value;
                if (flag)
                {
                    bool flag2 = typeof(T) == typeof(int?);
                    if (flag2)
                    {
                        object obj = Convert.ToInt32(value);
                        result = (T)((object)obj);
                    }
                    else
                    {
                        bool flag3 = typeof(T) == typeof(double?);
                        if (flag3)
                        {
                            object obj = Convert.ToDouble(value);
                            result = (T)((object)obj);
                        }
                        else
                        {
                            bool flag4 = typeof(T).Name == "Int32";
                            if (flag4)
                            {
                                object obj = Convert.ToInt32(value);
                                result = (T)((object)obj);
                            }
                            else
                            {
                                bool flag5 = typeof(T).Name == "Double";
                                if (flag5)
                                {
                                    object obj = Convert.ToDouble(value);
                                    result = (T)((object)obj);
                                }
                                else
                                {
                                    bool flag6 = typeof(T).Name == "String";
                                    if (flag6)
                                    {
                                        object obj = Convert.ToString(value);
                                        result = (T)((object)obj);
                                    }
                                    else
                                    {
                                        result = (T)((object)value);
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    result = defaultValue;
                }
            }
            catch
            {
                result = CastDBNull.To2<T>(value, defaultValue);
            }
            return result;
        }

        public static T To2<T>(object value, T defaultValue)
        {
            T result;
            try
            {
                Type type = value.GetType();
                string name = type.Name;
                if (!(name == "Decimal"))
                {
                    if (name == "Byte")
                    {
                        bool flag = Convert.ToByte(value) == 0;
                        object obj;
                        if (flag)
                        {
                            obj = false;
                            result = (T)((object)obj);
                            return result;
                        }
                        obj = true;
                        result = (T)((object)obj);
                        return result;
                    }
                }
                else
                {
                    Type typeFromHandle = typeof(T);
                    bool flag2 = typeFromHandle.Name == "Int32";
                    if (flag2)
                    {
                        object obj = Convert.ToInt32(value);
                        result = (T)((object)obj);
                        return result;
                    }
                    result = (T)((object)value);
                    return result;
                }
            }
            catch
            {
                result = defaultValue;
                return result;
            }
            result = defaultValue;
            return result;
        }
    }
}
