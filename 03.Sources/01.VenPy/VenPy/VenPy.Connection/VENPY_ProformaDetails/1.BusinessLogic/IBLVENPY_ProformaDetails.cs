using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using VenPy.Entities;

namespace VenPy.Connection
{
    public interface IBLVENPY_ProformaDetails
    {
        #region [ QUERIES ]

        ObservableCollection<VENPY_ProformaDetails> BLPFDES_ByProforma(Int32 p_BUSI_Code, Int32 p_PROF_Code);

        #endregion

        #region [ METHODS ]

        String BLPFDE_Save(ref ObservableCollection<VENPY_ProformaDetails> p_Items, String p_User);
        String BLPFDED_AProformaDetail(ref ObservableCollection<VENPY_ProformaDetails> p_Items);

        #endregion
    }
}
