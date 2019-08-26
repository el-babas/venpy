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
using System.Data;

namespace VenPy.Entities
{
    public partial class VENPY_BranchOffices
    {
        #region [ VARIABLES ]

        private String pv_boff_departamento;
        private String pv_boff_provincia;
        private String pv_boff_distrito;
        private String pv_boff_codedepartamento;
        private String pv_boff_codeprovincia;
        private String pv_boff_codedistrito;
        private ObservableCollection<VENPY_WarehousesBranches> pv_boff_warehousesbranches;
        private DataTable pv_udtt_warehousesbranches;
        private String pv_boff_errormessage;

        #endregion

        #region [ PROPERTIES ]

        [DataMember]
        public String BOFF_Departamento
        {
            get { return pv_boff_departamento; }
            set
            {
                if (pv_boff_departamento != value)
                {
                    pv_boff_departamento = value;
                    OnAttributeChanged("BOFF_Departamento");
                }
            }
        }
        [DataMember]
        public String BOFF_Provincia
        {
            get { return pv_boff_provincia; }
            set
            {
                if (pv_boff_provincia != value)
                {
                    pv_boff_provincia = value;
                    OnAttributeChanged("BOFF_Provincia");
                }
            }
        }
        [DataMember]
        public String BOFF_Distrito
        {
            get { return pv_boff_distrito; }
            set
            {
                if (pv_boff_distrito != value)
                {
                    pv_boff_distrito = value;
                    OnAttributeChanged("BOFF_Distrito");
                }
            }
        }
        [DataMember]
        public String BOFF_CodeDepartamento
        {
            get { return pv_boff_codedepartamento; }
            set
            {
                if (pv_boff_codedepartamento != value)
                {
                    pv_boff_codedepartamento = value;
                    OnAttributeChanged("BOFF_CodeDepartamento");
                }
            }
        }
        [DataMember]
        public String BOFF_CodeProvincia
        {
            get { return pv_boff_codeprovincia; }
            set
            {
                if (pv_boff_codeprovincia != value)
                {
                    pv_boff_codeprovincia = value;
                    OnAttributeChanged("BOFF_CodeProvincia");
                }
            }
        }
        [DataMember]
        public String BOFF_CodeDistrito
        {
            get { return pv_boff_codedistrito; }
            set
            {
                if (pv_boff_codedistrito != value)
                {
                    pv_boff_codedistrito = value;
                    OnAttributeChanged("BOFF_CodeDistrito");
                }
            }
        }
        [DataMember]
        public ObservableCollection<VENPY_WarehousesBranches> BOFF_WarehousesBranches
        {
            get { return pv_boff_warehousesbranches; }
            set { pv_boff_warehousesbranches = value; }
        }
        [DataMember]
        public DataTable UDTT_WarehousesBranches
        {
            get { return pv_udtt_warehousesbranches; }
            set { pv_udtt_warehousesbranches = value; }
        }
        [DataMember]
        public String BOFF_ErrorMessage
        {
            get { return pv_boff_errormessage; }
        }

        #endregion

        #region [ COPYTO ]

        public void CopyTo(ref VENPY_BranchOffices Item)
        {
            try
            {
                if (Item == null) { Item = new VENPY_BranchOffices(); }
                Item.BUSI_Code = this.BUSI_Code;
                Item.BOFF_Code = this.BOFF_Code;
                Item.BOFF_Name = this.BOFF_Name;
                Item.BOFF_Address = this.BOFF_Address;
                Item.BOFF_Description = this.BOFF_Description;
                Item.BOFF_Email = this.BOFF_Email;
                Item.BOFF_Web = this.BOFF_Web;
                Item.BOFF_SocialNetworks = this.BOFF_SocialNetworks;
                Item.BOFF_PhoneNumber1 = this.BOFF_PhoneNumber1;
                Item.BOFF_PhoneNumber2 = this.BOFF_PhoneNumber2;
                Item.UBIG_Code = this.UBIG_Code;
                Item.AUDI_CreationUser = this.AUDI_CreationUser;
                Item.AUDI_CreationDate = this.AUDI_CreationDate;
                Item.AUDI_ModificationUser = this.AUDI_ModificationUser;
                Item.AUDI_ModificationDate = this.AUDI_ModificationDate;

                Item.BOFF_Departamento = this.BOFF_Departamento;
                Item.BOFF_Provincia = this.BOFF_Provincia;
                Item.BOFF_Distrito = this.BOFF_Distrito;
                Item.BOFF_CodeDepartamento = this.BOFF_CodeDepartamento;
                Item.BOFF_CodeProvincia = this.BOFF_CodeProvincia;
                Item.BOFF_CodeDistrito = this.BOFF_CodeDistrito;
                Item.BOFF_WarehousesBranches = this.BOFF_WarehousesBranches;
                Item.UDTT_WarehousesBranches = this.UDTT_WarehousesBranches;
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
                pv_boff_errormessage = null;
                if (BUSI_Code.Equals(0))
                {
                    l_correcto = false;
                    pv_boff_errormessage += "* Debe ingresar un Código de Empresa" + Environment.NewLine;
                }
                if (string.IsNullOrEmpty(BOFF_Name))
                {
                    l_correcto = false;
                    pv_boff_errormessage += "* Debe ingresar el campo Nombre" + Environment.NewLine;
                }
                if (string.IsNullOrEmpty(BOFF_Address))
                {
                    l_correcto = false;
                    pv_boff_errormessage += "* Debe ingresar el campo Dirección" + Environment.NewLine;
                }
                if (string.IsNullOrEmpty(BOFF_CodeDepartamento))
                {
                    l_correcto = false;
                    pv_boff_errormessage += "* Debe seleccionar un Departamento" + Environment.NewLine;
                }
                if (string.IsNullOrEmpty(BOFF_CodeProvincia))
                {
                    l_correcto = false;
                    pv_boff_errormessage += "* Debe seleccionar un Provincia" + Environment.NewLine;
                }
                if (string.IsNullOrEmpty(BOFF_CodeDistrito))
                {
                    l_correcto = false;
                    pv_boff_errormessage += "* Debe seleccionar un Distrito" + Environment.NewLine;
                }
                if (!string.IsNullOrEmpty(BOFF_Email))
                {
                    if (!Validations.CheckMailsFormat(BOFF_Email))
                    {
                        l_correcto = false;
                        pv_boff_errormessage += "* El formato del Correo Electronico ingresado es incorrecto" + Environment.NewLine;
                    }
                }
                if (UDTT_WarehousesBranches == null || UDTT_WarehousesBranches.Rows.Count == 0)
                {
                    l_correcto = false;
                    pv_boff_errormessage += "* Debe seleccionar por los menos un Almacen" + Environment.NewLine;
                }

                return l_correcto;
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion
    }
}
