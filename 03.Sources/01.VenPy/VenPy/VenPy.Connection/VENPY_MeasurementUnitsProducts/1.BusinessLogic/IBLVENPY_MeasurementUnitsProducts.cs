using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using VenPy.Entities;

namespace VenPy.Connection
{
    public interface IBLVENPY_MeasurementUnitsProducts
    {
        #region [ QUERIES ]

        ObservableCollection<VENPY_MeasurementUnitsProducts> BLMUPRS_ByProduct(Int32 p_BUSI_Code, Int32 p_PROD_Code);

        #endregion

        #region [ METHODS ]

        Boolean BLMUPRI_ByProduct(Int32 p_BUSI_Code, Int32 p_PROD_Code, DataTable p_UDTT_MeasurementUnitsProducts, String p_AUDI_CreationUser, Boolean p_Transaction);

        #endregion
    }
}
