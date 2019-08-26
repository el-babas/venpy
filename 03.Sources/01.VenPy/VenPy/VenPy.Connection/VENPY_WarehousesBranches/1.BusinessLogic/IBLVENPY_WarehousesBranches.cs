using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using VenPy.Entities;

namespace VenPy.Connection
{
    public interface IBLVENPY_WarehousesBranches
    {
        #region [ QUERIES ]

        ObservableCollection<VENPY_WarehousesBranches> BLWABRS_ByBranch(Int32 p_BUSI_Code, Nullable<Int32> p_BOFF_Code);

        #endregion

        #region [ METHODS ]

        Boolean BLWABRI_ByBranch(Int32 p_BUSI_Code, Int32 p_BOFF_Code, DataTable p_UDTT_WarehousesBranches, String p_AUDI_CreationUser, Boolean p_Transaction);

        #endregion
    }
}
