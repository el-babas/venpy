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
    public partial class VENPY_PriceList : MasterEntity, INotifyPropertyChanged
    {
        #region [ VARIABLES ]

        private Int32 pv_busi_code;
        private Int32 pv_prli_code;
        private Boolean pv_prli_active;
        private String pv_tble_tablemnd;
        private String pv_tble_codemnd;
        private String pv_prli_name;
        private String pv_tble_tabletai;
        private String pv_tble_codetai;
        private String pv_prli_description;
        private String pv_audi_creationuser;
        private DateTime pv_audi_creationdate;
        private String pv_audi_modificationuser;
        private Nullable<DateTime> pv_audi_modificationdate;

        #endregion

        #region [ CONSTRUCTORS ]

        public VENPY_PriceList()
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
        public Int32 PRLI_Code
        {
            get { return pv_prli_code; }
            set
            {
                if (pv_prli_code != value)
                {
                    pv_prli_code = value;
                    OnAttributeChanged("PRLI_Code");
                }
            }
        }
        [DataMember]
        public Boolean PRLI_Active
        {
            get { return pv_prli_active; }
            set
            {
                if (pv_prli_active != value)
                {
                    pv_prli_active = value;
                    OnAttributeChanged("PRLI_Active");
                }
            }
        }
        [DataMember]
        public String TBLE_TableMND
        {
            get { return pv_tble_tablemnd; }
            set
            {
                if (pv_tble_tablemnd != value)
                {
                    pv_tble_tablemnd = value;
                    OnAttributeChanged("TBLE_TableMND");
                }
            }
        }
        [DataMember]
        public String TBLE_CodeMND
        {
            get { return pv_tble_codemnd; }
            set
            {
                if (pv_tble_codemnd != value)
                {
                    pv_tble_codemnd = value;
                    OnAttributeChanged("TBLE_CodeMND");
                }
            }
        }
        [DataMember]
        public String PRLI_Name
        {
            get { return pv_prli_name; }
            set
            {
                if (pv_prli_name != value)
                {
                    pv_prli_name = value;
                    OnAttributeChanged("PRLI_Name");
                }
            }
        }
        [DataMember]
        public String TBLE_TableTAI
        {
            get { return pv_tble_tabletai; }
            set
            {
                if (pv_tble_tabletai != value)
                {
                    pv_tble_tabletai = value;
                    OnAttributeChanged("TBLE_TableTAI");
                }
            }
        }
        [DataMember]
        public String TBLE_CodeTAI
        {
            get { return pv_tble_codetai; }
            set
            {
                if (pv_tble_codetai != value)
                {
                    pv_tble_codetai = value;
                    OnAttributeChanged("TBLE_CodeTAI");
                }
            }
        }
        [DataMember]
        public String PRLI_Description
        {
            get { return pv_prli_description; }
            set
            {
                if (pv_prli_description != value)
                {
                    pv_prli_description = value;
                    OnAttributeChanged("PRLI_Description");
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
