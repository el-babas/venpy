using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using VenPy.Entities;

namespace VenPy.Connection
{
    public partial class BLVENPY_PersonalConfiguration : IBLVENPY_PersonalConfiguration
    {
        #region [ QUERIES ]

        public ObservableCollection<VENPY_PersonalConfiguration> BLPCONS_ByUser(Int32 p_BUSI_Code, Int32 p_USER_Code)
        {
            try
            {
                return PCONS_ByUser(p_BUSI_Code, p_USER_Code);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion
    }
}
