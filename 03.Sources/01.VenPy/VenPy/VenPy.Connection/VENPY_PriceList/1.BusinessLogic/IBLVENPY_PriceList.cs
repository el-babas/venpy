using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using VenPy.Entities;

namespace VenPy.Connection
{
    public interface IBLVENPY_PriceList
    {
        #region [ QUERIES ]

        ObservableCollection<VENPY_PriceList> BLPRLIS_ListPriceList(Int32 p_BUSI_Code, String p_PRLI_Name);
        ObservableCollection<VENPY_PriceList> BLPRLIS_ByUser(Int32 p_BUSI_Code, Int32 p_USER_Code);
        VENPY_PriceList BLPRLIS_APriceList(Int32 p_BUSI_Code, Int32 p_PRLI_Code);

        #endregion

        #region [ METHODS ]

        String BLPRLI_Save(ref VENPY_PriceList p_Item);
        String BLPRLID_APriceList(ref VENPY_PriceList p_Item);

        #endregion
    }
}
