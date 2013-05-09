using System;
using System.Collections.Generic;
using System.Management;
using System.Text;

namespace EVSoft.HRMSLicense
{
    public class SystemInfo
    {
        public static string RunQuery(string TableName, string MethodName)
        {
            try
            {
                ManagementObjectSearcher MOS = new ManagementObjectSearcher("Select * from Win32_" + TableName);
                foreach (ManagementObject MO in MOS.Get())
                {
                    try
                    {
                        return RemoveUseLess(MO[MethodName].ToString().Trim().ToUpper());
                    }
                    catch (Exception e)
                    {
                        return "";
                    }
                }
            }
            catch (Exception ex)
            {
                return "";
            }
            return "";
        }

        //public static string RunQuery(string _Iquery, string _Name)
        //{
        //    ManagementObjectSearcher searcher = new ManagementObjectSearcher(_Iquery);
        //    foreach (ManagementObject obj2 in searcher.Get())
        //    {
        //        PropertyDataCollection properties = obj2.Properties;
        //        foreach (PropertyData data in properties)
        //        {
        //            if (data.Name.ToString() == _Name)
        //            {
        //                return RemoveUseLess(data.Value.ToString().Trim().ToUpper());
        //            }
        //        }
        //    }
        //    return "";
        //}

        public static string RemoveUseLess(string st)
        {
            char ch;
            for (int i = st.Length - 1; i >= 0; i--)
            {
                ch = char.ToUpper(st[i]);

                if ((ch < 'A' || ch > 'Z') &&
                    (ch < '0' || ch > '9'))
                {
                    st = st.Remove(i, 1);
                }
            }
            return st;
        }
    }
}
