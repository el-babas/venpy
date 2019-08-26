using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using VenPy.Entities;

namespace VenPy.Connection
{
    public interface IBLVENPY_Entities
    {
        #region [ QUERIES ]

        ObservableCollection<VENPY_Entities> BLENTIS_ListEntities(Int32 p_BUSI_Code, Int32 p_ETYP_Code, String p_ENTI_DocumentNumber, String p_ENTI_BusinessName, Boolean p_ENTI_Favourite);
        VENPY_Entities BLENTIS_AEntity(Int32 p_BUSI_Code, Int32 p_ENTI_Code);
        ObservableCollection<VENPY_Entities> BLENTIS_Help(Int32 p_BUSI_Code, Int32 p_ETYP_Code, String p_ENTI_DocumentNumber, String p_ENTI_BusinessName);

        #endregion

        #region [ METHODS ]

        String BLENTI_Save(ref VENPY_Entities p_Item);
        String BLENTID_AEntity(ref VENPY_Entities p_Item);

        #endregion
    }
}
