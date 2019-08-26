using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using VenPy.Entities;

namespace VenPy.Connection
{
    public interface IBLVENPY_Ubigeos
    {
        #region [ QUERIES ]

        ObservableCollection<VENPY_Ubigeos> BLUBIGS_All();
        VENPY_Ubigeos BLUBIGS_AUbigeo(String p_UBIG_Code);

        #endregion

        #region [ METHODS ]

        String BLUBIG_Save(ref VENPY_Ubigeos p_Item);
        String BLUBIGD_AUbigeo(ref VENPY_Ubigeos p_Item);

        #endregion
    }
}
