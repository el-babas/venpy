using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VenPy.Entities;

namespace VenPy.Connection
{
    public interface IBLVENPY_Users
    {
        #region [ QUERIES ]

        VENPY_Users BLUSERS_Authentication(String p_USER_UserId, String p_USER_Password);

        #endregion
    }
}
