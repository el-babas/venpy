using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using Vb = Microsoft.VisualBasic;

namespace VenPy.Class
{
    public class EncryptionVB60
    {
        #region [ METHODS ]

        public static string Encrypt(string p_string)
        {
            string l_string = Vb.Strings.Chr(7).ToString() + Vb.Strings.Chr(20).ToString() + Vb.Strings.Chr(21).ToString() + Vb.Strings.Chr(15).ToString();
            return FncEncode(p_string, l_string);
        }
        public static bool Check(string p_string, string p_hash)
        {
            string l_hashOfInput = Encrypt(p_string);
            StringComparer Contrast = StringComparer.OrdinalIgnoreCase;
            if (0 == Contrast.Compare(l_hashOfInput, p_hash))
            { return true; }
            else
            { return false; }
        }
        private static string FncEncode(string p_string, string p_password)
        {
            int i = 1;
            int j = 1;
            string l_resultingString = "";
            try
            {
                while (i <= Vb.Strings.Len(p_string))
                {
                    l_resultingString = l_resultingString + Vb.Strings.Chr(Vb.Strings.Asc(Vb.Strings.Mid(p_string, i, 1)) ^ Vb.Strings.Asc(Vb.Strings.Mid(p_password, j, 1)));
                    if (j < Vb.Strings.Len(p_password))
                    { j = j + 1; }
                    else
                    { j = 1; }
                    i = i + 1;
                }
            }
            catch (Exception ex)
            { throw ex; }
            return l_resultingString;
        }
        private static byte Asc(char p_src)
        {
            try
            {
                return Convert.ToByte(System.Text.Encoding.GetEncoding("iso-8859-1").GetBytes(p_src + "")[0]);
            }
            catch (Exception ex)
            { throw ex; }
        }
        private static char Chr(byte p_src)
        {
            try
            {
                return (System.Text.Encoding.GetEncoding("iso-8859-1").GetChars(new byte[] { p_src })[0]);
            }
            catch (Exception ex)
            { throw ex; }
        }
        private static char Mid(string p_s, int p_a, int p_b)
        {
            try
            {
                string l_temporal = p_s.Substring(p_a - 1, p_b);
                return Convert.ToChar(l_temporal);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion
    }

    public class EncryptString
    {
        #region [ VARIABLES ]

        private static String pv_PublicKey = "<RSAKeyValue><Modulus>zH6u07+N1eK6IzvMPr16YD9GmUG/GmQbpVWR/M9+MC8AjeuO3U/P8+a79KurB9KhdkbyG9Ayq8gHlmnpATxClQBpWi5jpbUPmq8UHbZTM9Njd0zaHNtS9+X3MOXovwvG2YsykS+yFjqVxFp9fgG7N38CR5MEXRRL4yZFkhNxefQWqaawxIIbRH8yKbUthqky2Fx5T8hnKWO9PNYHYx3yVdPEyXQYDFKfLB3RgF0rGkhdNPvrVwE+/KixxaWstlQD7omoLC6obyDdVE3tUnooBV5juYgSr3lK6gGOV4WxgNLJKrz3ZkwCy6wvCv8RfMql6k8ILnzjL7FqGTa41LvZbQ==</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";
        private static String pv_PrivateKey = "<RSAKeyValue><Modulus>zH6u07+N1eK6IzvMPr16YD9GmUG/GmQbpVWR/M9+MC8AjeuO3U/P8+a79KurB9KhdkbyG9Ayq8gHlmnpATxClQBpWi5jpbUPmq8UHbZTM9Njd0zaHNtS9+X3MOXovwvG2YsykS+yFjqVxFp9fgG7N38CR5MEXRRL4yZFkhNxefQWqaawxIIbRH8yKbUthqky2Fx5T8hnKWO9PNYHYx3yVdPEyXQYDFKfLB3RgF0rGkhdNPvrVwE+/KixxaWstlQD7omoLC6obyDdVE3tUnooBV5juYgSr3lK6gGOV4WxgNLJKrz3ZkwCy6wvCv8RfMql6k8ILnzjL7FqGTa41LvZbQ==</Modulus><Exponent>AQAB</Exponent><P>6N2jqAlCqtY/nbF3Otm+S6QBLK7Vw3JcIe5ZJd0soNr8f3Iir7cRtqhgZwGkWa6iImyDJ5IZj9aSGZHoP6tTEN1QkuvASvBQHeuNn+OuG4nd7Rd/DruQLu6f3PzeS84gGeO4+eXFg9EqBBFiRgN+UZML63oujhAImsY5YVHaoUk=</P><Q>4M9/+gaJBMpN0sw36dpPgq8Tz4OUZtOyEB88vHODZbejyXZfP0Qs1f+XoyDA3BL4vRSNxFg399Jo4JZ3AK7FT28bNgNRpV+AzuZKsRnpizuQCFmmB94t2v+FuRqoY6ujVU1ROr8GF7CFuGaJgpIBTYnmAGNyuJKk0XdoKbzUGwU=</Q><DP>KSynd1rL0vE3JmbushU2NKG3I3N2kKxz5fwC/1LwRTDzXIWN5Iv2Mdnr0crUiJb8TCHrvt9ybaB/DM5jxn5AncbELHZK9fUv9VplHFRhwLTL7NQuvygjAmlnEugTVkwIGQvO9UDPf9NIHpgETGTpvPrHLMfZ23yySMur8a1LfyE=</DP><DQ>RmnXrMlFO2HeFEtwq+d8BfOuYc3VuotN92zBSkln+4EUZPKVjKxe2rxOk4KbxZKPpDF+4eO7y/x0avvV1DnphSLIxBcwCHssTiGlfWkfVEPYrjTeIxK9DB4ClWK7IVTOONaZvau9Tcg1afd71JDEpbOufaqocRVFWHJtBr2lNb0=</DQ><InverseQ>MXKtbyycYfJsWD/eLI+NfWiWICGEDJ9cMYUG4FQfxGbUo7/olzBQrZSpT7MicMnYWfiUhCwiXf17Z7z5XWVgldSz6GpJKFza2m79wBxhcW0HEIOTdpXItz7Cr6ndqvgBMqzRBpMHVpemzUH58ErebOg1u/LKMO7ni48y+Q2umXw=</InverseQ><D>ZTQk7aKVXU7x89H6SOqZD90A4YQKQdNdYzuwHj/KIaqBSbtUXu7K6dg9GN+Eq0BwrAp8c4tcKGu8ZZJQwE3EXd1wRjNDGZU7/b+74uCC2Nk7FqWwJCvfKdRju41s3G/Fn5AmHHhQWHPx/tUR2jSdJN/0jtuRg0cyL16Xe62nsURbGXT66DCHoQFaafoqj6Bb5SH2J3ymAZQqZ94E+tPvpBFss2zlKhCXAVN5EWZPw+1IkqwwcOedgQouHuXlZtgVKXxDKQl3jfeP/eCa19+pO62Pxr9GJrMffAXnHDTmGfxc+RihDgawF4uaYHNg1yboXOZBxzqIhbl9/xgbKTMAQQ==</D></RSAKeyValue>";
        public const String pb_ConnectionFile = "cString.xml";

        #endregion

        #region [ METHODS ]

        public static String Encrypt(string p_string)
        {
            try
            {
                RSACryptoServiceProvider Rsa = new RSACryptoServiceProvider();
                Rsa.FromXmlString(pv_PublicKey);
                Byte[] data = Rsa.Encrypt(System.Text.Encoding.Default.GetBytes(p_string), false);
                return Convert.ToBase64String(data);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public static String Decrypt(string p_string)
        {
            try
            {
                RSACryptoServiceProvider Rsa = new RSACryptoServiceProvider();
                Rsa.FromXmlString(pv_PrivateKey);
                Byte[] data = Rsa.Decrypt(Convert.FromBase64String(p_string), false);
                return System.Text.Encoding.Default.GetString(data);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion
    }
}
