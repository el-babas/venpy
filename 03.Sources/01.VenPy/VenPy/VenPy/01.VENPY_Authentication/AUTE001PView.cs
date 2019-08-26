using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VenPy.Class;
using VenPy.Entities;
using VenPy.Controls;
using VenPy.Connection;

namespace VenPy.Main
{
    public class AUTE001PView
    {
        #region [ VARIABLES ]

        private String pv_Title = "Inicio de Sesión";
        private Boolean pv_SignOff = false;

        #endregion

        #region [ PROPERTIES ]

        public String Title
        {
            get { return pv_Title; }
            set { pv_Title = value; }
        }
        public Boolean SignOff
        {
            get { return pv_SignOff; }
            set { pv_SignOff = value; }
        }

        #endregion

        #region [ CONSTRUCTORS ]

        public AUTE001PView()
        { }

        #endregion 

        #region [ METHODS ]

        public bool ValidateUser(String p_User, String p_Password)
        {
            try
            {
                string l_password1 = EncryptionVB60.Encrypt(p_Password.Trim());
                VENPY_Users Item_VENPY_Users = new VENPY_Users();
                IBLVENPY_Users BL_VENPY_Users = new BLVENPY_Users();
                Item_VENPY_Users = BL_VENPY_Users.BLUSERS_Authentication(p_User, l_password1);
                if (Item_VENPY_Users != null)
                {
                    string l_password2 = EncryptionVB60.Encrypt(p_Password.Trim());
                    if (Item_VENPY_Users.USER_Password.Equals(l_password2.Trim()))
                    {
                        SessionVariables.UserName = Item_VENPY_Users.USER_UserId;
                        SessionVariables.UserCode = Item_VENPY_Users.USER_Code;
                        SessionVariables.UserFullName = Item_VENPY_Users.USER_FullName;
                        SessionVariables.UserType = Item_VENPY_Users.USER_Type;
                        return true;
                    }
                    else
                    { return false; }
                }
                else
                { return false; }
            }
            catch (Exception ex)
            {
                Messages.ShowErrorMessage(Title, "Ocurrio un error al validar el usuario", ex);
                return false;
            }
        }

        #endregion
    }
}
