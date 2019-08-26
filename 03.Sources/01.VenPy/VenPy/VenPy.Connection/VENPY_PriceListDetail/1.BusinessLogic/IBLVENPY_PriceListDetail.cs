using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using VenPy.Entities;

namespace VenPy.Connection
{
    public interface IBLVENPY_PriceListDetail
    {
        #region [ QUERIES ]

        ObservableCollection<VENPY_PriceListDetail> BLPLDES_ByPriceList(Int32 p_BUSI_Code, Nullable<Int32> p_PRLI_Code);

        #endregion

        #region [ METHODS ]

        String BLPLDE_Save(ref VENPY_PriceListDetail p_Item, Boolean p_Transaction);

        #endregion
    }
}
