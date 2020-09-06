using System.Globalization;
namespace System
{
    public class MainClass
    {
        public static void Main()
        {
            DateTime date = DateTime.Now;
            string formatedDate = date.AsDMYMHString();
            Console.WriteLine($"Formated Date is : {formatedDate}");
            string inputSrting = "250";
             short InputNumber = inputSrting.AsInt16();
            Console.WriteLine(InputNumber);
            Console.ReadLine();

        }
    }
    /// <summary>
    /// Extension methods Example of Real Time 
    /// </summary>
    public static class MyExtensions
    {
        public static String ToDMYString(this DateTime Date)
        {
            return Date.ToString("dd MMM yyyy");
        }
        public static string AsDMYMHString(this DateTime date)
        {
            if (date == Convert.ToDateTime("1 Jan 1900"))
            {
                return "";
            }
            else
            {
                return date.ToString("dd MMM yyyy HH:mm tt");
            }
        }
        public static String AsDMYString(this object objData)
        {
            CultureInfo cultureUK = new CultureInfo("en-GB");
            DateTime dt = DateTime.Now;
            return Convert.ToDateTime(objData, cultureUK).ToDMYString();
        }
        public static DateTime ToDate(this String date)
        {
            CultureInfo cultureUK = new CultureInfo("en-GB");
            return Convert.ToDateTime(date, cultureUK);
        }
        public static object IsDbNull(this object objData, object defaultValue)
        {
            if (objData == DBNull.Value)
                return defaultValue;
            else
                return objData;
        }
        public static object IsNull(this object objData, object defaultValue)
        {
            if (objData == null) return defaultValue;
            else
                return objData;
        }
        public static string IsNull(this string data, object defaultValue)
        {
            if (data == null) return defaultValue.ToString(); else return data;
        }
        public static short AsInt16(this object objData)
        {
            short value = 0;
            short.TryParse(objData.ToString(), out value);
            return value;
        }
        public static int AsInt32(this object objData)
        {
            int value = 0;
            int.TryParse(objData.ToString(), out value);
            return value;
        }
        public static Single AsSingle(this object objData)
        {
            Single value = 0; 
            Single.TryParse(objData.ToString(), out value);
            return value;
        }
        public static double AsDouble(this object objData)
        {
            double value = 0;
            double.TryParse(objData.ToString(), out value);
            return value;
        }
        public static Int64 AsInt64(this object objData)
        {
            long value = 0;
            long.TryParse(objData.ToString(), out value);
            return value;             
        }
        public static bool AsBoolean(this object objData)
        {
            return Convert.ToBoolean(objData);
        }

        public static byte AsByte(this object objData)
        {
            return Convert.ToByte(objData);
        }
        public static DateTime? AsDateTime(this object objData)
        {
            if (objData == null) return null;
            return Convert.ToDateTime(objData);
        }
        public static string ConvertHexToString(this string HexDecValue)
        {
            string StrValue = "";
            while (HexDecValue.Length > 0)
            {
                StrValue += System.Convert.ToChar(System.Convert.ToUInt32(HexDecValue.Substring(0, 2), 16)).ToString();
                HexDecValue = HexDecValue.Substring(2, HexDecValue.Length - 2);
            }
            return StrValue;
        }
    
    }
}