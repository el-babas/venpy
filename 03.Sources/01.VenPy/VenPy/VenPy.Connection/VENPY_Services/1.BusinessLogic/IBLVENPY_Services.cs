using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using VenPy.Entities;

namespace VenPy.Connection
{
    public interface IBLVENPY_Services
    {
        #region [ QUERIES ]

        ObservableCollection<VENPY_Services> BLSERVS_ListServices(Int32 p_BUSI_Code, String p_TBLE_TableFAS, String p_TBLE_CodeFAS, String p_SERV_Name);
        VENPY_Services BLSERVS_AService(Int32 p_BUSI_Code, Int32 p_SERV_Code);

        #endregion

        #region [ METHODS ]

        String BLSERV_Save(ref VENPY_Services p_Item);
        String BLSERVD_AService(ref VENPY_Services p_Item);
        
        #endregion
    }
}
