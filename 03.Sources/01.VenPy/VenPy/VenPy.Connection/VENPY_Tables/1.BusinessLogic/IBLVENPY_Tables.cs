using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using VenPy.Entities;

namespace VenPy.Connection
{
    public interface IBLVENPY_Tables
    {
        #region [ QUERIES ]

        ObservableCollection<VENPY_Tables> BLTBLES_All(Int32 p_BUSI_Code);
        ObservableCollection<VENPY_Tables> BLTBLES_ListTables(Int32 p_BUSI_Code, String p_TBLE_Table);
        VENPY_Tables BLTBLES_ATable(Int32 p_BUSI_Code, String p_TBLE_Table, String p_TBLE_Code);

        #endregion

        #region [ METHODS ]

        String BLTBLE_Save(ref VENPY_Tables p_Item);
        String BLTBLED_ATable(ref VENPY_Tables p_Item);

        #endregion
    }
}
