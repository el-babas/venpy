using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using VenPy.Entities;

namespace VenPy.Connection
{
    public interface IBLVENPY_Proformas
    {
        #region [ QUERIES ]

        ObservableCollection<VENPY_Proformas> BLPROFS_ListProformas(Int32 p_BUSI_Code, String p_PROF_Number, DateTime p_PROF_DateBegin, DateTime p_PROF_DateEnd, Boolean p_PROF_OnlyActive);
        VENPY_Proformas BLPROFS_AProforma(Int32 p_BUSI_Code, Int32 p_PROF_Code);

        #endregion

        #region [ METHODS ]

        String BLPROD_Save(ref VENPY_Proformas p_Item);

        #endregion
    }
}
