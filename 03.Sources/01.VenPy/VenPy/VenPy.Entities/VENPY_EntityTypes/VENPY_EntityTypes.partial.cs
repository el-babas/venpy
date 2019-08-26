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
    public partial class VENPY_EntityTypes
    {
        #region [ VARIABLES ]

        private String pv_etyp_errormessage;

        #endregion

        #region [ PROPERTIES ]

        [DataMember]
        public String ETYP_ErrorMessage
        {
            get { return pv_etyp_errormessage; }
        }

        #endregion

        #region [ COPYTO ]

        public void CopyTo(ref VENPY_EntityTypes Item)
        {
            try
            {
                if (Item == null) { Item = new VENPY_EntityTypes(); }
                Item.BUSI_Code = this.BUSI_Code;
                Item.ETYP_Code = this.ETYP_Code;
                Item.ETYP_Name = this.ETYP_Name;
                Item.ETYP_Description = this.ETYP_Description;
                Item.ETYP_Active = this.ETYP_Active;
                Item.ETYP_Default = this.ETYP_Default;
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
                pv_etyp_errormessage = null;
                if (BUSI_Code.Equals(0))
                {
                    l_correcto = false;
                    pv_etyp_errormessage += "* Debe ingresar un Código de Empresa" + Environment.NewLine;
                }
                if (string.IsNullOrEmpty(ETYP_Name))
                {
                    l_correcto = false;
                    pv_etyp_errormessage += "* Debe ingresar el campo Nombre" + Environment.NewLine;
                }
                return l_correcto;
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion
    }
}
