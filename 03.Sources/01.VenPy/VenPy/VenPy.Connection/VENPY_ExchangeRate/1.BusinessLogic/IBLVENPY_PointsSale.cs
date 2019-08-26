using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using VenPy.Entities;

namespace VenPy.Connection
{
    public interface IBLVENPY_ExchangeRate
    {
        #region [ QUERIES ]

        ObservableCollection<VENPY_ExchangeRate> BLEXRAS_ListExchangeRate(Int32 p_BUSI_Code, String p_EXRA_Year, String p_EXRA_Month);

        #endregion

        #region [ METHODS ]

        String BLEXRA_Save(ref VENPY_ExchangeRate p_Item);

        #endregion
    }
}
