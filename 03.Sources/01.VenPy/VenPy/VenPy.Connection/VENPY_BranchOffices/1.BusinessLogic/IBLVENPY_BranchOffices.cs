using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using VenPy.Entities;

namespace VenPy.Connection
{
    public interface IBLVENPY_BranchOffices
    {
        #region [ QUERIES ]

        ObservableCollection<VENPY_BranchOffices> BLBOFFS_ByUser(Int32 p_USER_Code, Nullable<Int32> p_BUSI_Code);
        ObservableCollection<VENPY_BranchOffices> BLBOFFS_ListBranchOffices(Int32 p_BUSI_Code, Int32 p_USER_Code, String p_BOFF_Name);
        VENPY_BranchOffices BLBOFFS_ABranchOffice(Int32 p_BUSI_Code, Int32 p_BOFF_Code);

        #endregion

        #region [ METHODS ]

        String BLBOFF_Save(ref VENPY_BranchOffices p_Item);

        #endregion
    }
}
