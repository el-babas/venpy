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
    public partial class VENPY_PointsSale
    {
        #region [ VARIABLES ]

        private String pv_psal_namestatus;
        private String pv_psal_errormessage;

        #endregion

        #region [ PROPERTIES ]

        [DataMember]
        public String PSAL_NameStatus
        {
            get { return pv_psal_namestatus; }
            set
            {
                if (pv_psal_namestatus != value)
                {
                    pv_psal_namestatus = value;
                    OnAttributeChanged("PSAL_NameStatus");
                }
            }
        }
        [DataMember]
        public String PSAL_ErrorMessage
        {
            get { return pv_psal_errormessage; }
        }

        #endregion

        #region [ COPYTO ]

        public void CopyTo(ref VENPY_PointsSale Item)
        {
            try
            {
                if (Item == null) { Item = new VENPY_PointsSale(); }
                Item.BUSI_Code = this.BUSI_Code;
                Item.BOFF_Code = this.BOFF_Code;
                Item.PSAL_Code = this.PSAL_Code;
                Item.PSAL_Name = this.PSAL_Name;
                Item.PSAL_Main = this.PSAL_Main;
                Item.PSAL_Status = this.PSAL_Status;
                Item.AUDI_CreationUser = this.AUDI_CreationUser;
                Item.AUDI_CreationDate = this.AUDI_CreationDate;
                Item.AUDI_ModificationUser = this.AUDI_ModificationUser;
                Item.AUDI_ModificationDate = this.AUDI_ModificationDate;

                Item.PSAL_NameStatus = this.PSAL_NameStatus;
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
                pv_psal_errormessage = null;
                if (BUSI_Code.Equals(0))
                {
                    l_correcto = false;
                    pv_psal_errormessage += "* Debe ingresar un Código de Empresa" + Environment.NewLine;
                }
                if (BOFF_Code.Equals(0))
                {
                    l_correcto = false;
                    pv_psal_errormessage += "* Debe ingresar un Código de Sucursal" + Environment.NewLine;
                }
                if (string.IsNullOrEmpty(PSAL_Name))
                {
                    l_correcto = false;
                    pv_psal_errormessage += "* Debe ingresar el campo Nombre" + Environment.NewLine;
                }
                if (string.IsNullOrEmpty(PSAL_Status))
                {
                    l_correcto = false;
                    pv_psal_errormessage += "* Debe seleccionar un Estado" + Environment.NewLine;
                }
                else if (PSAL_Main && PSAL_Status != "A" )
                {
                    l_correcto = false;
                    pv_psal_errormessage += "* El Punto de Venta principal debe estar activo" + Environment.NewLine;
                }
                return l_correcto;
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion
    }
}
