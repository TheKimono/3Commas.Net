using System;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.Text;

namespace XCommas.Net
{
    internal static class XCommasHelper
    {
        public static string Sign(string stringToSign, string secret)
        {
            using (HMACSHA256 hmac = new HMACSHA256(Encoding.ASCII.GetBytes(secret)))
            {
                byte[] hashValue = hmac.ComputeHash(Encoding.ASCII.GetBytes(stringToSign));
                return HashEncode(hashValue);
            }
        }

        public static string HashEncode(byte[] hash)
        {
            return BitConverter.ToString(hash).Replace("-", "").ToLower();
        }

        public static string GetEnumMemberAttrValue<T>(this T enumVal)
        {
            var enumType = typeof(T);
            var memInfo = enumType.GetMember(enumVal.ToString());
            var attr = memInfo.FirstOrDefault()?.GetCustomAttributes(false).OfType<EnumMemberAttribute>().FirstOrDefault();
            if (attr != null)
            {
                return attr.Value;
            }

            return null;
        }
    }
}
