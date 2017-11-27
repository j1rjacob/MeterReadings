using System;

namespace TMF.Reports.UTIL
{
    public static class Util
    {
        public static string RemoveDash(this string meterAddress)
        {
            string[] separator1 = { " " };
            string[] results;

            results = meterAddress.Split(separator1, StringSplitOptions.RemoveEmptyEntries);
            return results[2].Replace("-", "");
        }
    }
}
