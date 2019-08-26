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
    public partial class VENPY_FunctionsEntities
    {
        #region [ VARIABLES ]

        private String pv_fent_name;
        private String pv_fent_description;
        private Boolean pv_fent_select;

        #endregion

        #region [ PROPERTIES ]

        [DataMember]
        public String FENT_Name
        {
            get { return pv_fent_name; }
            set
            {
                if (pv_fent_name != value)
                {
                    pv_fent_name = value;
                    OnAttributeChanged("FENT_Name");
                }
            }
        }
        [DataMember]
        public String FENT_Description
        {
            get { return pv_fent_description; }
            set
            {
                if (pv_fent_description != value)
                {
                    pv_fent_description = value;
                    OnAttributeChanged("FENT_Description");
                }
            }
        }
        [DataMember]
        public Boolean FENT_Select
        {
            get { return pv_fent_select; }
            set
            {
                if (pv_fent_select != value)
                {
                    pv_fent_select = value;
                    OnAttributeChanged("FENT_Select");
                }
            }
        }

        #endregion

        #region [ COPYTO ]

        public void CopyTo(ref VENPY_FunctionsEntities Item)
        {
            try
            {
                if (Item == null) { Item = new VENPY_FunctionsEntities(); }
                Item.BUSI_Code = this.BUSI_Code;
                Item.ENTI_Code = this.ENTI_Code;
                Item.ETYP_Code = this.ETYP_Code;
                Item.AUDI_CreationUser = this.AUDI_CreationUser;
                Item.AUDI_CreationDate = this.AUDI_CreationDate;
                Item.AUDI_ModificationUser = this.AUDI_ModificationUser;
                Item.AUDI_ModificationDate = this.AUDI_ModificationDate;

                Item.FENT_Name = this.FENT_Name;
                Item.FENT_Description = this.FENT_Description;
                Item.FENT_Select = this.FENT_Select;
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion
    }
}
