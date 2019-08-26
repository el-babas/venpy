using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using VenPy.Entities;

namespace VenPy.Connection
{
    public interface IBLVENPY_Products
    {
        #region [ QUERIES ]

        ObservableCollection<VENPY_Products> BLPRODS_ListProducts(Int32 p_BUSI_Code, String p_TBLE_TableFAP, String p_TBLE_CodeFAP, String p_TBLE_TableMAR, String p_TBLE_CodeMAR, String p_PROD_Name);
        VENPY_Products BLPRODS_AProduct(Int32 p_BUSI_Code, Int32 p_PROD_Code);

        #endregion

        #region [ METHODS ]

        String BLPROD_Save(ref VENPY_Products p_Item);
        String BLPRODD_AProduct(ref VENPY_Products p_Item);
        
        #endregion
    }
}
