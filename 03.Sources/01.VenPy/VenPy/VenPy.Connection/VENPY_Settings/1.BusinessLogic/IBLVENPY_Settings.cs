using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using VenPy.Entities;

namespace VenPy.Connection
{
    public interface IBLVENPY_Settings
    {
        #region [ QUERIES ]

        ObservableCollection<VENPY_Settings> BLSETTS_ByBusiness(Int32 p_BUSI_Code);

        #endregion

        #region [ METHODS ]

        String BLSETT_Save(ref ObservableCollection<VENPY_Settings> p_Items, String p_User);

        #endregion
    }
}
