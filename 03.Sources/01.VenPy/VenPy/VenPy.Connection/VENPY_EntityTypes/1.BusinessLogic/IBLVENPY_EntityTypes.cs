using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using VenPy.Entities;

namespace VenPy.Connection
{
    public interface IBLVENPY_EntityTypes
    {
        #region [ QUERIES ]

        ObservableCollection<VENPY_EntityTypes> BLETYPS_ListEntityTypes(Int32 p_BUSI_Code, String p_ETYP_Name);
        VENPY_EntityTypes BLETYPS_AEntityType(Int32 p_BUSI_Code, Int32 p_ETYP_Code);

        #endregion

        #region [ METHODS ]

        String BLETYP_Save(ref VENPY_EntityTypes p_Item);
        String BLETYPD_AEntityType(ref VENPY_EntityTypes p_Item);

        #endregion
    }
}
