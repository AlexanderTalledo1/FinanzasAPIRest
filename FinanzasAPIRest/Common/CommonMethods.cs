using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanzasAPIRest.Common
{
    public class CommonMethods
    {
        public static string Key = "adef@@kxcbv@";

        public static string ConvertToEncrypt(string password)
        {
            //if (String.IsNullOrEmpty(password)) return "";
            password += Key;
            var passwordByes = Encoding.UTF8.GetBytes(password);
            //return Convert.ToBase64String(passwordByes);
            return String.IsNullOrEmpty(password) ? "" :
                   Convert.ToBase64String(passwordByes);
        }
        public static string ConvertToDecrypt(string base64EncodeData)
        {
            if (String.IsNullOrEmpty(base64EncodeData)) return "";
            var base64EncodeBytes = Convert.FromBase64String(base64EncodeData);
            var result = Encoding.UTF8.GetString(base64EncodeBytes);
            result = result.Substring(0, result.Length - Key.Length);
            return result;
        }
    }
}
