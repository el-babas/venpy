using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.NetworkInformation;
using System.Text.RegularExpressions;

namespace VenPy.Class
{
    public class Validations
    {
        #region [ METHODS ]

        public static bool UrlExists(string p_url, ref int p_code)
        {
            try
            {
                HttpWebRequest l_request = WebRequest.Create(p_url) as HttpWebRequest;
                l_request.Method = "HEAD";
                HttpWebResponse response = l_request.GetResponse() as HttpWebResponse;
                p_code = (int)response.StatusCode;
                response.Close();
                return (response.StatusCode == HttpStatusCode.OK);
            }
            catch (WebException ex)
            {
                if (ex.Status == WebExceptionStatus.ProtocolError)
                {
                    var response = ex.Response as HttpWebResponse;
                    if (response != null)
                    { p_code = (int)response.StatusCode; }
                }
                return false;
            }
        }
        public static bool CheckRUC(string p_ruc)
        {
            try
            {
                Int64 l_number = 0;
                if (!Int64.TryParse(p_ruc, out l_number))
                {
                    return false;
                    //throw new Exception("El valor no es numerico");
                }
                if (p_ruc.Length != 11)
                {
                    return false;
                    //throw new Exception("Numero de digitos invalido");
                }
                int dig01 = Convert.ToInt32(p_ruc.Substring(0, 1)) * 5;
                int dig02 = Convert.ToInt32(p_ruc.Substring(1, 1)) * 4;
                int dig03 = Convert.ToInt32(p_ruc.Substring(2, 1)) * 3;
                int dig04 = Convert.ToInt32(p_ruc.Substring(3, 1)) * 2;
                int dig05 = Convert.ToInt32(p_ruc.Substring(4, 1)) * 7;
                int dig06 = Convert.ToInt32(p_ruc.Substring(5, 1)) * 6;
                int dig07 = Convert.ToInt32(p_ruc.Substring(6, 1)) * 5;
                int dig08 = Convert.ToInt32(p_ruc.Substring(7, 1)) * 4;
                int dig09 = Convert.ToInt32(p_ruc.Substring(8, 1)) * 3;
                int dig10 = Convert.ToInt32(p_ruc.Substring(9, 1)) * 2;
                int dig11 = Convert.ToInt32(p_ruc.Substring(10, 1));
                int suma = dig01 + dig02 + dig03 + dig04 + dig05 + dig06 + dig07 + dig08 + dig09 + dig10;
                int residuo = suma % 11;
                int resta = 11 - residuo;

                int digChk = 0;
                if (resta == 10)
                {
                    digChk = 0;
                }
                else if (resta == 11)
                {
                    digChk = 1;
                }
                else
                {
                    digChk = resta;
                }

                if (dig11 == digChk)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            { return false; }
        }
        public static bool CheckMailFormat(string p_email)
        {
            try
            {
                String l_Formato;
                l_Formato = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
                if (Regex.IsMatch(p_email, l_Formato))
                {
                    if (Regex.Replace(p_email, l_Formato, String.Empty).Length == 0)
                    { return true; }
                    else
                    { return false; }
                }
                else
                { return false; }
            }
            catch (Exception)
            { return false; }
        }
        public static bool CheckMailsFormat(string p_emails)
        {
            try
            {
                bool l_isCorrect = true;
                if (!string.IsNullOrEmpty(p_emails))
                {
                    string[] l_emails = p_emails.Split(';');
                    foreach (string l_email in l_emails)
                    {
                        if (!string.IsNullOrEmpty(l_email))
                        {
                            if (!Regex.IsMatch(l_email.Trim(), @"^[0-9a-zA-Z\._][\w\.-]*[a-zA-Z0-9\._]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
                            { l_isCorrect = false; }
                        }
                        else
                        { l_isCorrect = false; }
                    }
                    return l_isCorrect;
                }
                else
                { return false; }
            }
            catch (Exception)
            { return false; }
        }

        #endregion
    }
}
