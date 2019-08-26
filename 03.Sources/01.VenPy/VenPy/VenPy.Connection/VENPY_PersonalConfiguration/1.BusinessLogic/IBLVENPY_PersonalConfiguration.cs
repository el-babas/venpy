using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using VenPy.Entities;

namespace VenPy.Connection
{
    public interface IBLVENPY_PersonalConfiguration
    {
        #region [ QUERIES ]

        ObservableCollection<VENPY_PersonalConfiguration> BLPCONS_ByUser(Int32 p_BUSI_Code, Int32 p_USER_Code);

        #endregion
    }
}
