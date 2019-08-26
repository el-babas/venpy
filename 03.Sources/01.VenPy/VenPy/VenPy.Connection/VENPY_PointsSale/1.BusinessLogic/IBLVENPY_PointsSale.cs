using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using VenPy.Entities;

namespace VenPy.Connection
{
    public interface IBLVENPY_PointsSale
    {
        #region [ QUERIES ]

        ObservableCollection<VENPY_PointsSale> BLPSALS_ByUser(Int32 p_USER_Code, Nullable<Int32> p_BUSI_Code);
        ObservableCollection<VENPY_PointsSale> BLPSALS_ListPointsSale(Int32 p_BUSI_Code, Int32 p_USER_Code, String p_PSAL_Name);
        VENPY_PointsSale BLPSALS_APointSale(Int32 p_BUSI_Code, Int32 p_BOFF_Code, Int32 p_PSAL_Code);

        #endregion

        #region [ METHODS ]

        String BLPSAL_Save(ref VENPY_PointsSale p_Item);

        #endregion
    }
}
