using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VenPy.Entities;

namespace VenPy.Connection
{
    public partial class BLVENPY_Users : IBLVENPY_Users
    {

        #region [ QUERIES ]

        public VENPY_Users BLUSERS_Authentication(String p_USER_UserId, String p_USER_Password)
        {
            try
            {
                return USERS_Authentication(p_USER_UserId, p_USER_Password);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion
    }
}
