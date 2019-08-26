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
    [Serializable()]
    public partial class VENPY_EntityTypes : MasterEntity, INotifyPropertyChanged
    {
        #region [ VARIABLES ]

        private Int32 pv_busi_code;
        private Int32 pv_etyp_code;
        private String pv_etyp_name;
        private String pv_etyp_description;
        private Boolean pv_etyp_active;
        private Boolean pv_etyp_default;
        private String pv_audi_creationuser;
        private DateTime pv_audi_creationdate;
        private String pv_audi_modificationuser;
        private Nullable<DateTime> pv_audi_modificationdate;

        #endregion

        #region [ CONSTRUCTORS ]

        public VENPY_EntityTypes()
        { }

        #endregion

        #region [ PROPERTIES ]

        [DataMember]
        public Int32 BUSI_Code
        {
            get { return pv_busi_code; }
            set
            {
                if (pv_busi_code != value)
                {
                    pv_busi_code = value;
                    OnAttributeChanged("BUSI_Code");
                }
            }
        }
        [DataMember]
        public Int32 ETYP_Code
        {
            get { return pv_etyp_code; }
            set
            {
                if (pv_etyp_code != value)
                {
                    pv_etyp_code = value;
                    OnAttributeChanged("ETYP_Code");
                }
            }
        }
        [DataMember]
        public String ETYP_Name
        {
            get { return pv_etyp_name; }
            set
            {
                if (pv_etyp_name != value)
                {
                    pv_etyp_name = value;
                    OnAttributeChanged("ETYP_Name");
                }
            }
        }
        [DataMember]
        public String ETYP_Description
        {
            get { return pv_etyp_description; }
            set
            {
                if (pv_etyp_description != value)
                {
                    pv_etyp_description = value;
                    OnAttributeChanged("ETYP_Description");
                }
            }
        }
        [DataMember]
        public Boolean ETYP_Active
        {
            get { return pv_etyp_active; }
            set
            {
                if (pv_etyp_active != value)
                {
                    pv_etyp_active = value;
                    OnAttributeChanged("ETYP_Active");
                }
            }
        }
        [DataMember]
        public Boolean ETYP_Default
        {
            get { return pv_etyp_default; }
            set
            {
                if (pv_etyp_default != value)
                {
                    pv_etyp_default = value;
                    OnAttributeChanged("ETYP_Default");
                }
            }
        }
        [DataMember]
        public String AUDI_CreationUser
        {
            get { return pv_audi_creationuser; }
            set
            {
                if (pv_audi_creationuser != value)
                {
                    pv_audi_creationuser = value;
                    OnAttributeChanged("AUDI_CreationUser");
                }
            }
        }
        [DataMember]
        public DateTime AUDI_CreationDate
        {
            get { return pv_audi_creationdate; }
            set
            {
                if (pv_audi_creationdate != value)
                {
                    pv_audi_creationdate = value;
                    OnAttributeChanged("AUDI_CreationDate");
                }
            }
        }
        [DataMember]
        public String AUDI_ModificationUser
        {
            get { return pv_audi_modificationuser; }
            set
            {
                if (pv_audi_modificationuser != value)
                {
                    pv_audi_modificationuser = value;
                    OnAttributeChanged("AUDI_ModificationUser");
                }
            }
        }
        [DataMember]
        public Nullable<DateTime> AUDI_ModificationDate
        {
            get { return pv_audi_modificationdate; }
            set
            {
                if (pv_audi_modificationdate != value)
                {
                    pv_audi_modificationdate = value;
                    OnAttributeChanged("AUDI_ModificationDate");
                }
            }
        }

        #endregion
    }
}
