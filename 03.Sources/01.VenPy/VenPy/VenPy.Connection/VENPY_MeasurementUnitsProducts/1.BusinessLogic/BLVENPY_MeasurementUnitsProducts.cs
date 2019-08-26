using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using VenPy.Entities;
using VenPy.Class;
using System.Data;

namespace VenPy.Connection
{
    public partial class BLVENPY_MeasurementUnitsProducts : IBLVENPY_MeasurementUnitsProducts
    {
        #region [ QUERIES ]

        public ObservableCollection<VENPY_MeasurementUnitsProducts> BLMUPRS_ByProduct(Int32 p_BUSI_Code, Int32 p_PROD_Code)
        {
            try
            {
                return MUPRS_ByProduct(p_BUSI_Code, p_PROD_Code);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ METHODS ]

        public Boolean BLMUPRI_ByProduct(Int32 p_BUSI_Code, Int32 p_PROD_Code, DataTable p_UDTT_MeasurementUnitsProducts, String p_AUDI_CreationUser, Boolean p_Transaction)
        {
            bool l_correcto = false;
            if (p_Transaction)
            {
                DataAccessPersonalSQL.DAP_BeginTransaction();
                try
                {
                    l_correcto = MUPRI_ByProduct(p_BUSI_Code, p_PROD_Code, p_UDTT_MeasurementUnitsProducts, p_AUDI_CreationUser);
                    if (l_correcto)
                    { DataAccessPersonalSQL.DAP_CommitTransaction(); }
                    else
                    { DataAccessPersonalSQL.DAP_RollbackTransaction(); }
                    return l_correcto;
                }
                catch (Exception ex)
                {
                    DataAccessPersonalSQL.DAP_RollbackTransaction();
                    throw ex;
                }
            }
            else
            {
                try
                {
                    l_correcto = MUPRI_ByProduct(p_BUSI_Code, p_PROD_Code, p_UDTT_MeasurementUnitsProducts, p_AUDI_CreationUser);
                    return l_correcto;
                }
                catch (Exception ex)
                { throw ex; }
            }
        }

        #endregion
    }
}
