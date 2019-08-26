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
    public partial class VENPY_Ubigeos
    {
        #region [ VARIABLES ]

        private ObservableCollection<VENPY_Ubigeos> pv_ubig_offspring;
        private String pv_ubig_errormessage;

        #endregion

        #region [ PROPERTIES ]

        [DataMember]
        public ObservableCollection<VENPY_Ubigeos> UBIG_Offspring
        {
            get { return pv_ubig_offspring; }
            set
            {
                if (pv_ubig_offspring != value)
                { pv_ubig_offspring = value; }
            }
        }
        [DataMember]
        public String UBIG_ErrorMessage
        {
            get { return pv_ubig_errormessage; }
        }

        #endregion

        #region [ COPYTO ]

        public void CopyTo(ref VENPY_Ubigeos Item)
        {
            try
            {
                if (Item == null) { Item = new VENPY_Ubigeos(); }
                Item.UBIG_Code = this.UBIG_Code;
                Item.UBIG_ParentCode = this.UBIG_ParentCode;
                Item.UBIG_SunatCode = this.UBIG_SunatCode;
                Item.UBIG_InternationalCode = this.UBIG_InternationalCode;
                Item.UBIG_Description = this.UBIG_Description;
                Item.UBIG_Observations = this.UBIG_Observations;
                Item.AUDI_CreationUser = this.AUDI_CreationUser;
                Item.AUDI_CreationDate = this.AUDI_CreationDate;
                Item.AUDI_ModificationUser = this.AUDI_ModificationUser;
                Item.AUDI_ModificationDate = this.AUDI_ModificationDate;

                Item.UBIG_Offspring = this.UBIG_Offspring;
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region[ CHECK ]

        public bool Check()
        {
            try
            {
                bool l_correcto = true;
                pv_ubig_errormessage = null;
                if (string.IsNullOrEmpty(UBIG_Code))
                {
                    l_correcto = false;
                    pv_ubig_errormessage += "* Debe ingresar el campo Codigo" + Environment.NewLine;
                }
                if (string.IsNullOrEmpty(UBIG_Description))
                {
                    l_correcto = false;
                    pv_ubig_errormessage += "* Debe ingresar el campo Descripción" + Environment.NewLine;
                }
                return l_correcto;
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion
    }
}
