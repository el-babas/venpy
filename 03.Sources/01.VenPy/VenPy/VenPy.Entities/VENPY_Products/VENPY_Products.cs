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
    public partial class VENPY_Products : MasterEntity, INotifyPropertyChanged
    {
        #region [ VARIABLES ]

        private Int32 pv_busi_code;
        private Int32 pv_prod_code;
        private Boolean pv_prod_active;
        private String pv_tble_tablefap;
        private String pv_tble_codefap;
        private String pv_tble_tableunm;
        private String pv_tble_codeunm;
        private String pv_prod_name;
        private String pv_prod_description;
        private Boolean pv_prod_original;
        private String pv_tble_tablemar;
        private String pv_tble_codemar;
        private String pv_prod_model;
        private String pv_prod_serie;
        private String pv_audi_creationuser;
        private DateTime pv_audi_creationdate;
        private String pv_audi_modificationuser;
        private Nullable<DateTime> pv_audi_modificationdate;

        #endregion

        #region [ CONSTRUCTORS ]
        
        public VENPY_Products()
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
        public Int32 PROD_Code
        {
            get { return pv_prod_code; }
            set
            {
                if (pv_prod_code != value)
                {
                    pv_prod_code = value;
                    OnAttributeChanged("PROD_Code");
                }
            }
        }
        [DataMember]
        public Boolean PROD_Active
        {
            get { return pv_prod_active; }
            set
            {
                if (pv_prod_active != value)
                {
                    pv_prod_active = value;
                    OnAttributeChanged("PROD_Active");
                }
            }
        }
        [DataMember]
        public String TBLE_TableFAP
        {
            get { return pv_tble_tablefap; }
            set
            {
                if (pv_tble_tablefap != value)
                {
                    pv_tble_tablefap = value;
                    OnAttributeChanged("TBLE_TableFAP");
                }
            }
        }
        [DataMember]
        public String TBLE_CodeFAP
        {
            get { return pv_tble_codefap; }
            set
            {
                if (pv_tble_codefap != value)
                {
                    pv_tble_codefap = value;
                    OnAttributeChanged("TBLE_CodeFAP");
                }
            }
        }
        [DataMember]
        public String TBLE_TableUNM
        {
            get { return pv_tble_tableunm; }
            set
            {
                if (pv_tble_tableunm != value)
                {
                    pv_tble_tableunm = value;
                    OnAttributeChanged("TBLE_TableUNM");
                }
            }
        }
        [DataMember]
        public String TBLE_CodeUNM
        {
            get { return pv_tble_codeunm; }
            set
            {
                if (pv_tble_codeunm != value)
                {
                    pv_tble_codeunm = value;
                    OnAttributeChanged("TBLE_CodeUNM");
                }
            }
        }
        [DataMember]
        public String PROD_Name
        {
            get { return pv_prod_name; }
            set
            {
                if (pv_prod_name != value)
                {
                    pv_prod_name = value;
                    OnAttributeChanged("PROD_Name");
                }
            }
        }
        [DataMember]
        public String PROD_Description
        {
            get { return pv_prod_description; }
            set
            {
                if (pv_prod_description != value)
                {
                    pv_prod_description = value;
                    OnAttributeChanged("PROD_Description");
                }
            }
        }
        [DataMember]
        public Boolean PROD_Original
        {
            get { return pv_prod_original; }
            set
            {
                if (pv_prod_original != value)
                {
                    pv_prod_original = value;
                    OnAttributeChanged("PROD_Original");
                }
            }
        }
        [DataMember]
        public String TBLE_TableMAR
        {
            get { return pv_tble_tablemar; }
            set
            {
                if (pv_tble_tablemar != value)
                {
                    pv_tble_tablemar = value;
                    OnAttributeChanged("TBLE_TableMAR");
                }
            }
        }
        [DataMember]
        public String TBLE_CodeMAR
        {
            get { return pv_tble_codemar; }
            set
            {
                if (pv_tble_codemar != value)
                {
                    pv_tble_codemar = value;
                    OnAttributeChanged("TBLE_CodeMAR");
                }
            }
        }
        [DataMember]
        public String PROD_Model
        {
            get { return pv_prod_model; }
            set
            {
                if (pv_prod_model != value)
                {
                    pv_prod_model = value;
                    OnAttributeChanged("PROD_Model");
                }
            }
        }
        [DataMember]
        public String PROD_Serie
        {
            get { return pv_prod_serie; }
            set
            {
                if (pv_prod_serie != value)
                {
                    pv_prod_serie = value;
                    OnAttributeChanged("PROD_Serie");
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
