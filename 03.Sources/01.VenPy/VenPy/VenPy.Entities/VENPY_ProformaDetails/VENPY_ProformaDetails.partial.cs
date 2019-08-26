using System;
using System.Text;
using System.Linq;
using System.Globalization;
using System.ComponentModel;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Runtime.Serialization;
using System.Data;
using VenPy.Class;

namespace VenPy.Entities
{
    public partial class VENPY_ProformaDetails
    {
        #region [ COPYTO ]

        public void CopyTo(ref VENPY_ProformaDetails Item)
        {
            try
            {
                if (Item == null) { Item = new VENPY_ProformaDetails(); }
                Item.BUSI_Code = this.BUSI_Code;
                Item.PROF_Code = this.PROF_Code;
                Item.PFDE_Item = this.PFDE_Item;
                Item.PFDE_Type = this.PFDE_Type;
                Item.TBLE_TableFAP = this.TBLE_TableFAP;
                Item.TBLE_CodeFAP = this.TBLE_CodeFAP;
                Item.TBLE_TableFAS = this.TBLE_TableFAS;
                Item.TBLE_CodeFAS = this.TBLE_CodeFAS;
                Item.PROD_Code = this.PROD_Code;
                Item.SERV_Code = this.SERV_Code;
                Item.TBLE_TableUNM = this.TBLE_TableUNM;
                Item.TBLE_CodeUNM = this.TBLE_CodeUNM;
                Item.TBLE_TableTAI = this.TBLE_TableTAI;
                Item.TBLE_CodeTAI = this.TBLE_CodeTAI;
                Item.PLDE_UnitValue = this.PLDE_UnitValue;
                Item.PLDE_UnitPrice = this.PLDE_UnitPrice;
                Item.PLDE_Quantity = this.PLDE_Quantity;
                Item.PLDE_IGV = this.PLDE_IGV;
                Item.PLDE_ISC = this.PLDE_ISC;
                Item.PROF_Discount = this.PROF_Discount;
                Item.AUDI_CreationUser = this.AUDI_CreationUser;
                Item.AUDI_CreationDate = this.AUDI_CreationDate;
                Item.AUDI_ModificationUser = this.AUDI_ModificationUser;
                Item.AUDI_ModificationDate = this.AUDI_ModificationDate;
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion
    }
}
