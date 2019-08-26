using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using VenPy.Entities;

namespace VenPy.Connection
{
    public interface IBLVENPY_Business
    {
        #region [ QUERIES ]

        ObservableCollection<VENPY_Business> BLBUSIS_ByUser(Int32 p_USER_Code);
        ObservableCollection<VENPY_Business> BLBUSIS_ListCompanies(Int32 p_USER_Code, String p_BUSI_RUC, String p_BUSI_BusinessName);
        VENPY_Business BLBUSIS_ACompany(Int32 p_BUSI_Code);

        #endregion

        #region [ METHODS ]

        String BLBUSI_Save(ref VENPY_Business p_Item);

        #endregion
    }
}
