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
    public partial class VENPY_Business
    {
        #region [ VARIABLES ]

        private String pv_busi_departamento;
        private String pv_busi_provincia;
        private String pv_busi_distrito;
        private String pv_busi_codedepartamento;
        private String pv_busi_codeprovincia;
        private String pv_busi_codedistrito;
        private String pv_busi_errormessage;

        #endregion

        #region [ PROPERTIES ]

        [DataMember]
        public String BUSI_Departamento
        {
            get { return pv_busi_departamento; }
            set
            {
                if (pv_busi_departamento != value)
                {
                    pv_busi_departamento = value;
                    OnAttributeChanged("BUSI_Departamento");
                }
            }
        }
        [DataMember]
        public String BUSI_Provincia
        {
            get { return pv_busi_provincia; }
            set
            {
                if (pv_busi_provincia != value)
                {
                    pv_busi_provincia = value;
                    OnAttributeChanged("BUSI_Provincia");
                }
            }
        }
        [DataMember]
        public String BUSI_Distrito
        {
            get { return pv_busi_distrito; }
            set
            {
                if (pv_busi_distrito != value)
                {
                    pv_busi_distrito = value;
                    OnAttributeChanged("BUSI_Distrito");
                }
            }
        }
        [DataMember]
        public String BUSI_CodeDepartamento
        {
            get { return pv_busi_codedepartamento; }
            set
            {
                if (pv_busi_codedepartamento != value)
                {
                    pv_busi_codedepartamento = value;
                    OnAttributeChanged("BUSI_CodeDepartamento");
                }
            }
        }
        [DataMember]
        public String BUSI_CodeProvincia
        {
            get { return pv_busi_codeprovincia; }
            set
            {
                if (pv_busi_codeprovincia != value)
                {
                    pv_busi_codeprovincia = value;
                    OnAttributeChanged("BUSI_CodeProvincia");
                }
            }
        }
        [DataMember]
        public String BUSI_CodeDistrito
        {
            get { return pv_busi_codedistrito; }
            set
            {
                if (pv_busi_codedistrito != value)
                {
                    pv_busi_codedistrito = value;
                    OnAttributeChanged("BUSI_CodeDistrito");
                }
            }
        }
        [DataMember]
        public String BUSI_ErrorMessage
        {
            get { return pv_busi_errormessage; }
        }

        #endregion

        #region [ COPYTO ]

        public void CopyTo(ref VENPY_Business Item)
        {
            try
            {
                if (Item == null) { Item = new VENPY_Business(); }
                Item.BUSI_Code = this.BUSI_Code;
                Item.BUSI_RUC = this.BUSI_RUC;
                Item.BUSI_BusinessName = this.BUSI_BusinessName;
                Item.BUSI_TradeName = this.BUSI_TradeName;
                Item.BUSI_Address1 = this.BUSI_Address1;
                Item.BUSI_Address2 = this.BUSI_Address2;
                Item.BUSI_Urbanization = this.BUSI_Urbanization;
                Item.BUSI_Email = this.BUSI_Email;
                Item.BUSI_Web = this.BUSI_Web;
                Item.BUSI_SocialNetworks = this.BUSI_SocialNetworks;
                Item.BUSI_PhoneNumber1 = this.BUSI_PhoneNumber1;
                Item.BUSI_PhoneNumber2 = this.BUSI_PhoneNumber2;
                Item.BUSI_BankAccount = this.BUSI_BankAccount;
                Item.UBIG_Code = this.UBIG_Code;
                Item.AUDI_CreationUser = this.AUDI_CreationUser;
                Item.AUDI_CreationDate = this.AUDI_CreationDate;
                Item.AUDI_ModificationUser = this.AUDI_ModificationUser;
                Item.AUDI_ModificationDate = this.AUDI_ModificationDate;

                Item.BUSI_Departamento = this.BUSI_Departamento;
                Item.BUSI_Provincia = this.BUSI_Provincia;
                Item.BUSI_Distrito = this.BUSI_Distrito;
                Item.BUSI_CodeDepartamento = this.BUSI_CodeDepartamento;
                Item.BUSI_CodeProvincia = this.BUSI_CodeProvincia;
                Item.BUSI_CodeDistrito = this.BUSI_CodeDistrito;
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
                pv_busi_errormessage = null;
                if (string.IsNullOrEmpty(BUSI_RUC))
                {
                    l_correcto = false;
                    pv_busi_errormessage += "* Debe ingresar el campo R.U.C" + Environment.NewLine;
                }
                else if (!Validations.CheckRUC(BUSI_RUC))
                {
                    l_correcto = false;
                    pv_busi_errormessage += "* El número de R.U.C ingresado no es valido" + Environment.NewLine;
                }
                if (string.IsNullOrEmpty(BUSI_BusinessName))
                {
                    l_correcto = false;
                    pv_busi_errormessage += "* Debe ingresar el campo Razón Social" + Environment.NewLine;
                }
                if (string.IsNullOrEmpty(BUSI_Address1))
                {
                    l_correcto = false;
                    pv_busi_errormessage += "* Debe ingresar el campo Dirección Fiscal" + Environment.NewLine;
                }
                if (string.IsNullOrEmpty(BUSI_CodeDepartamento))
                {
                    l_correcto = false;
                    pv_busi_errormessage += "* Debe seleccionar un Departamento" + Environment.NewLine;
                }
                if (string.IsNullOrEmpty(BUSI_CodeProvincia))
                {
                    l_correcto = false;
                    pv_busi_errormessage += "* Debe seleccionar un Provincia" + Environment.NewLine;
                }
                if (string.IsNullOrEmpty(BUSI_CodeDistrito))
                {
                    l_correcto = false;
                    pv_busi_errormessage += "* Debe seleccionar un Distrito" + Environment.NewLine;
                }
                if (!string.IsNullOrEmpty(BUSI_Email))
                {
                    if (!Validations.CheckMailsFormat(BUSI_Email))
                    {
                        l_correcto = false;
                        pv_busi_errormessage += "* El formato del Correo Electronico ingresado es incorrecto" + Environment.NewLine;
                    }
                }
                return l_correcto;
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion
    }
}
