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
    public partial class VENPY_Series
	{
        #region [ VARIABLES ]

        private String pv_seri_errormessage;

        #endregion

        #region [ PROPERTIES ]
        
        [DataMember]
        public String SERI_ErrorMessage
        {
            get { return pv_seri_errormessage; }
        }

        #endregion

        #region [ COPYTO ]

        public void CopyTo(ref VENPY_Series Item)
        {
            try
            {
                if (Item == null) { Item = new VENPY_Series(); }
                Item.BUSI_Code = this.BUSI_Code;
                Item.SERI_Code = this.SERI_Code;
                Item.TBLE_TableTDO = this.TBLE_TableTDO;
                Item.TBLE_CodeTDO = this.TBLE_CodeTDO;
                Item.SERI_Serie = this.SERI_Serie;
                Item.SERI_Number = this.SERI_Number;
                Item.SERI_Description = this.SERI_Description;
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
                pv_seri_errormessage = null;
                if (BUSI_Code.Equals(0))
                {
                    l_correcto = false;
                    pv_seri_errormessage += "* Debe ingresar un Código de Empresa" + Environment.NewLine;
                }
                if (string.IsNullOrEmpty(TBLE_TableTDO) || string.IsNullOrEmpty(TBLE_CodeTDO) || TBLE_CodeTDO.Equals("0"))
                {
                    l_correcto = false;
                    pv_seri_errormessage += "* Debe seleccionar un Tipo de Documento" + Environment.NewLine;
                }
                if (string.IsNullOrEmpty(SERI_Serie) || SERI_Serie.Length < 4)
                {
                    l_correcto = false;
                    pv_seri_errormessage += "* Debe ingresar un Serie correcta" + Environment.NewLine;
                }
                if (SERI_Number <= 0)
                {
                    l_correcto = false;
                    pv_seri_errormessage += "* El Numero correlativo debe ser mayor a cero" + Environment.NewLine;
                }
                return l_correcto;
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion
    }
}
