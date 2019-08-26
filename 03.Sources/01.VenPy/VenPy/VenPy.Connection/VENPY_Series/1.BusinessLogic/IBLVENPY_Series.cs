using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using VenPy.Entities;

namespace VenPy.Connection
{
    public interface IBLVENPY_Series
    {
        #region [ QUERIES ]

        ObservableCollection<VENPY_Series> BLSERIS_ListSeries(Int32 p_BUSI_Code, String p_TBLE_TableTDO, String p_TBLE_CodeTDO);

        #endregion

        #region [ METHODS ]

        String BLSERI_Save(ref ObservableCollection<VENPY_Series> p_Items, String p_User);
        String BLSERID_ASerie(ref ObservableCollection<VENPY_Series> p_Items);

        #endregion
    }
}
