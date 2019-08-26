using System;
using System.Text;
using System.Linq;
using System.Globalization;
using System.ComponentModel;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Runtime.Serialization;

namespace VenPy.Entities
{
    public partial class VENPY_Tables
    {
        #region [ VARIABLES ]

        private String pv_tble_namestatus;
        private String pv_tble_errormessage;

        #endregion

        #region [ PROPERTIES ]

        [DataMember]
        public String TBLE_NameStatus
        {
            get { return pv_tble_namestatus; }
            set
            {
                if (pv_tble_namestatus != value)
                {
                    pv_tble_namestatus = value;
                    OnAttributeChanged("TBLE_NameStatus");
                }
            }
        }
        [DataMember]
        public String TBLE_ErrorMessage
        {
            get { return pv_tble_errormessage; }
        }

        #endregion

        #region [ COPYTO ]

        public void CopyTo(ref VENPY_Tables Item)
        {
            try
            {
                if (Item == null) { Item = new VENPY_Tables(); }
                Item.BUSI_Code = this.BUSI_Code;
                Item.TBLE_Table = this.TBLE_Table;
                Item.TBLE_Code = this.TBLE_Code;
                Item.TBLE_InternationalCode = this.TBLE_InternationalCode;
                Item.TBLE_SunatCode = this.TBLE_SunatCode;
                Item.TBLE_Description1 = this.TBLE_Description1;
                Item.TBLE_Description2 = this.TBLE_Description2;
                Item.TBLE_Number1 = this.TBLE_Number1;
                Item.TBLE_Number2 = this.TBLE_Number2;
                Item.TBLE_Status = this.TBLE_Status;
                Item.TBLE_Default = this.TBLE_Default;
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
                pv_tble_errormessage = null;
                if (BUSI_Code.Equals(0))
                {
                    l_correcto = false;
                    pv_tble_errormessage += "* Debe ingresar un Código de Empresa" + Environment.NewLine;
                }
                if (string.IsNullOrEmpty(TBLE_Table))
                {
                    l_correcto = false;
                    pv_tble_errormessage += "* Debe ingresar un tipo de Tabla" + Environment.NewLine;
                }
                if (string.IsNullOrEmpty(TBLE_Description1))
                {
                    l_correcto = false;
                    pv_tble_errormessage += "* Debe ingresar una Descripción 1" + Environment.NewLine;
                }
                return l_correcto;
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion
    }
}
