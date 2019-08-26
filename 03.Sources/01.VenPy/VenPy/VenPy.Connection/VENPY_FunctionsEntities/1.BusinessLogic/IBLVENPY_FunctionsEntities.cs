using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using VenPy.Entities;

namespace VenPy.Connection
{
    public interface IBLVENPY_FunctionsEntities
    {
        #region [ QUERIES ]

        ObservableCollection<VENPY_FunctionsEntities> BLFENTS_ByEntity(Int32 p_BUSI_Code, Nullable<Int32> p_ENTI_Code);

        #endregion

        #region [ METHODS ]

        Boolean BLFENTI_ByEntity(Int32 p_BUSI_Code, Int32 p_ENTI_Code, DataTable p_UDTT_FunctionsEntities, String p_AUDI_CreationUser, Boolean p_Transaction);

        #endregion
    }
}
