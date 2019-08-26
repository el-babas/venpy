using System;
using System.Text;
using System.Linq;
using System.Globalization;
using System.ComponentModel;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Runtime.Serialization;
using VenPy.Class;

namespace VenPy.Entities
{
    public partial class VENPY_ExchangeRate
    {
        #region [ VARIABLES ]

        private String pv_exra_dateformat;
        private String pv_exra_errormessage;

        #endregion

        #region [ PROPERTIES ]

        [DataMember]
        public String EXRA_DateFormat
        {
            get
            {
                pv_exra_dateformat = pv_exra_date.ToString("dd/MM/yyyy");
                return pv_exra_dateformat;
            }
        }
        [DataMember]
        public String EXRA_ErrorMessage
        {
            get { return pv_exra_errormessage; }
        }

        #endregion

        #region [ COPYTO ]

        public void CopyTo(ref VENPY_ExchangeRate Item)
        {
            try
            {
                if (Item == null) { Item = new VENPY_ExchangeRate(); }
                Item.BUSI_Code = this.BUSI_Code;
                Item.EXRA_Date = this.EXRA_Date;
                Item.EXRA_OfficialPurchase = this.EXRA_OfficialPurchase;
                Item.EXRA_OfficialSale = this.EXRA_OfficialSale;
                Item.EXRA_InternalPurchase = this.EXRA_InternalPurchase;
                Item.EXRA_InternalSale = this.EXRA_InternalSale;
                Item.AUDI_CreationUser = this.AUDI_CreationUser;
                Item.AUDI_CreationDate = this.AUDI_CreationDate;
                Item.AUDI_ModificationUser = this.AUDI_ModificationUser;
                Item.AUDI_ModificationDate = this.AUDI_ModificationDate;
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ CHECK ]

        public bool Check()
        {
            try
            {
                bool l_correcto = true;
                pv_exra_errormessage = null;
                if (BUSI_Code.Equals(0))
                {
                    l_correcto = false;
                    pv_exra_errormessage += "* Debe ingresar un Código de Empresa" + Environment.NewLine;
                }
                return l_correcto;
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion
    }
}
