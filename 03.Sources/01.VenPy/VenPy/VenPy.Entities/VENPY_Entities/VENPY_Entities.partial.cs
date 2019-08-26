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
    public partial class VENPY_Entities
    {
        #region [ VARIABLES ]

        private String pv_enti_departamento;
        private String pv_enti_provincia;
        private String pv_enti_distrito;
        private String pv_enti_codedepartamento;
        private String pv_enti_codeprovincia;
        private String pv_enti_codedistrito;
        private String pv_enti_namestatus;
        private String pv_tble_nametdi;
        private ObservableCollection<VENPY_FunctionsEntities> pv_enti_functionsentities;
        private DataTable pv_udtt_functionsentities;
        private String pv_enti_errormessage;

        #endregion

        #region [ PROPERTIES ]

        [DataMember]
        public String ENTI_Departamento
        {
            get { return pv_enti_departamento; }
            set
            {
                if (pv_enti_departamento != value)
                {
                    pv_enti_departamento = value;
                    OnAttributeChanged("ENTI_Departamento");
                }
            }
        }
        [DataMember]
        public String ENTI_Provincia
        {
            get { return pv_enti_provincia; }
            set
            {
                if (pv_enti_provincia != value)
                {
                    pv_enti_provincia = value;
                    OnAttributeChanged("ENTI_Provincia");
                }
            }
        }
        [DataMember]
        public String ENTI_Distrito
        {
            get { return pv_enti_distrito; }
            set
            {
                if (pv_enti_distrito != value)
                {
                    pv_enti_distrito = value;
                    OnAttributeChanged("ENTI_Distrito");
                }
            }
        }
        [DataMember]
        public String ENTI_CodeDepartamento
        {
            get { return pv_enti_codedepartamento; }
            set
            {
                if (pv_enti_codedepartamento != value)
                {
                    pv_enti_codedepartamento = value;
                    OnAttributeChanged("ENTI_CodeDepartamento");
                }
            }
        }
        [DataMember]
        public String ENTI_CodeProvincia
        {
            get { return pv_enti_codeprovincia; }
            set
            {
                if (pv_enti_codeprovincia != value)
                {
                    pv_enti_codeprovincia = value;
                    OnAttributeChanged("ENTI_CodeProvincia");
                }
            }
        }
        [DataMember]
        public String ENTI_CodeDistrito
        {
            get { return pv_enti_codedistrito; }
            set
            {
                if (pv_enti_codedistrito != value)
                {
                    pv_enti_codedistrito = value;
                    OnAttributeChanged("ENTI_CodeDistrito");
                }
            }
        }
        [DataMember]
        public String ENTI_NameStatus
        {
            get { return pv_enti_namestatus; }
            set
            {
                if (pv_enti_namestatus != value)
                {
                    pv_enti_namestatus = value;
                    OnAttributeChanged("ENTI_NameStatus");
                }
            }
        }
        [DataMember]
        public String TBLE_NameTDI
        {
            get { return pv_tble_nametdi; }
            set
            {
                if (pv_tble_nametdi != value)
                {
                    pv_tble_nametdi = value;
                    OnAttributeChanged("TBLE_NameTDI");
                }
            }
        }
        [DataMember]
        public ObservableCollection<VENPY_FunctionsEntities> ENTI_FunctionsEntities
        {
            get { return pv_enti_functionsentities; }
            set { pv_enti_functionsentities = value; }
        }
        [DataMember]
        public DataTable UDTT_FunctionsEntities
        {
            get { return pv_udtt_functionsentities; }
            set { pv_udtt_functionsentities = value; }
        }
        [DataMember]
        public String ENTI_ErrorMessage
        {
            get { return pv_enti_errormessage; }
        }

        #endregion

        #region [ COPYTO ]

        public void CopyTo(ref VENPY_Entities Item)
        {
            try
            {
                if (Item == null) { Item = new VENPY_Entities(); }
                Item.BUSI_Code = this.BUSI_Code;
                Item.ENTI_Code = this.ENTI_Code;
                Item.TBLE_TableTDI = this.TBLE_TableTDI;
                Item.TBLE_CodeTDI = this.TBLE_CodeTDI;
                Item.ENTI_EntityType = this.ENTI_EntityType;
                Item.ENTI_DocumentNumber = this.ENTI_DocumentNumber;
                Item.ENTI_BusinessName = this.ENTI_BusinessName;
                Item.ENTI_Birthdate = this.ENTI_Birthdate;
                Item.ENTI_Address = this.ENTI_Address;
                Item.UBIG_Code = this.UBIG_Code;
                Item.ENTI_Email = this.ENTI_Email;
                Item.ENTI_Web = this.ENTI_Web;
                Item.ENTI_PhoneNumber = this.ENTI_PhoneNumber;
                Item.ENTI_ReferentialAddress = this.ENTI_ReferentialAddress;
                Item.ENTI_Domiciled = this.ENTI_Domiciled;
                Item.TBLE_TablePAI = this.TBLE_TablePAI;
                Item.TBLE_CodePAI = this.TBLE_CodePAI;
                Item.ENTI_Favourite = this.ENTI_Favourite;
                Item.ENTI_BankAccount = this.ENTI_BankAccount;
                Item.ENTI_Status = this.ENTI_Status;
                Item.AUDI_CreationUser = this.AUDI_CreationUser;
                Item.AUDI_CreationDate = this.AUDI_CreationDate;
                Item.AUDI_ModificationUser = this.AUDI_ModificationUser;
                Item.AUDI_ModificationDate = this.AUDI_ModificationDate;

                Item.ENTI_Departamento = this.ENTI_Departamento;
                Item.ENTI_Provincia = this.ENTI_Provincia;
                Item.ENTI_Distrito = this.ENTI_Distrito;
                Item.ENTI_CodeDepartamento = this.ENTI_CodeDepartamento;
                Item.ENTI_CodeProvincia = this.ENTI_CodeProvincia;
                Item.ENTI_CodeDistrito = this.ENTI_CodeDistrito;
                Item.ENTI_NameStatus = this.ENTI_NameStatus;
                Item.TBLE_NameTDI = this.TBLE_NameTDI;
                Item.ENTI_FunctionsEntities = this.ENTI_FunctionsEntities;
                Item.UDTT_FunctionsEntities = this.UDTT_FunctionsEntities;

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
                pv_enti_errormessage = null;
                if (BUSI_Code.Equals(0))
                {
                    l_correcto = false;
                    pv_enti_errormessage += "* Debe ingresar un Código de Empresa" + Environment.NewLine;
                }
                if (string.IsNullOrEmpty(ENTI_Status))
                {
                    l_correcto = false;
                    pv_enti_errormessage += "* Debe seleccionar un Estado" + Environment.NewLine;
                }
                if (string.IsNullOrEmpty(ENTI_EntityType))
                {
                    l_correcto = false;
                    pv_enti_errormessage += "* Debe indicar si es una entidad Natural o Juridica" + Environment.NewLine;
                }
                if (string.IsNullOrEmpty(TBLE_TableTDI) || string.IsNullOrEmpty(TBLE_CodeTDI))
                {
                    l_correcto = false;
                    pv_enti_errormessage += "* Debe seleccionar un Tipo de Documento" + Environment.NewLine;
                }
                if (string.IsNullOrEmpty(ENTI_DocumentNumber))
                {
                    l_correcto = false;
                    pv_enti_errormessage += "* Debe ingresar un Número de Documento" + Environment.NewLine;
                }
                else
                {
                    switch (TBLE_CodeTDI)
                    {
                        case StaticLists.TDI_Dni:
                            if (ENTI_DocumentNumber.Length != 8)
                            {
                                l_correcto = false;
                                pv_enti_errormessage += "* Un D.N.I. debe tener 8 dígitos" + Environment.NewLine;
                            }
                            break;
                        case StaticLists.TDI_Ruc:
                            if (!Validations.CheckRUC(ENTI_DocumentNumber))
                            {
                                l_correcto = false;
                                pv_enti_errormessage += "* El número de R.U.C ingresado no es valido" + Environment.NewLine;
                            }
                            break;
                    }
                }
                if (string.IsNullOrEmpty(ENTI_BusinessName))
                {
                    l_correcto = false;
                    pv_enti_errormessage += "* Debe ingresar una Razón Social o Nombre" + Environment.NewLine;
                }
                if (string.IsNullOrEmpty(ENTI_Address))
                {
                    l_correcto = false;
                    pv_enti_errormessage += "* Debe ingresar una Dirección" + Environment.NewLine;
                }
                if (!string.IsNullOrEmpty(ENTI_Email))
                {
                    if (!Validations.CheckMailsFormat(ENTI_Email))
                    {
                        l_correcto = false;
                        pv_enti_errormessage += "* El formato del Correo Electronico ingresado es incorrecto" + Environment.NewLine;
                    }
                }
                if (UDTT_FunctionsEntities == null || UDTT_FunctionsEntities.Rows.Count == 0)
                {
                    l_correcto = false;
                    pv_enti_errormessage += "* Debe seleccionar por los menos un Tipo de Entidad" + Environment.NewLine;
                }

                return l_correcto;
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion
    }
}
