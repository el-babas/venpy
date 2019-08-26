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
    public partial class VENPY_Tables : MasterEntity, INotifyPropertyChanged
    {
        #region [ VARIABLES ]

        private Int32 pv_busi_code;
        private String pv_tble_table;
        private String pv_tble_code;
        private String pv_tble_internationalcode;
        private String pv_tble_sunatcode;
        private String pv_tble_description1;
        private String pv_tble_description2;
        private Nullable<Int32> pv_tble_number1;
        private Nullable<Decimal> pv_tble_number2;
        private String pv_tble_status;
        private Boolean pv_tble_default;
        private String pv_audi_creationuser;
        private DateTime pv_audi_creationdate;
        private String pv_audi_modificationuser;
        private Nullable<DateTime> pv_audi_modificationdate;

        #endregion

        #region [ CONSTRUCTORS ]

        public VENPY_Tables()
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
        public String TBLE_Table
        {
            get { return pv_tble_table; }
            set
            {
                if (pv_tble_table != value)
                {
                    pv_tble_table = value;
                    OnAttributeChanged("TBLE_Table");
                }
            }
        }
        [DataMember]
        public String TBLE_Code
        {
            get { return pv_tble_code; }
            set
            {
                if (pv_tble_code != value)
                {
                    pv_tble_code = value;
                    OnAttributeChanged("TBLE_Code");
                }
            }
        }
        [DataMember]
        public String TBLE_InternationalCode
        {
            get { return pv_tble_internationalcode; }
            set
            {
                if (pv_tble_internationalcode != value)
                {
                    pv_tble_internationalcode = value;
                    OnAttributeChanged("TBLE_InternationalCode");
                }
            }
        }
        [DataMember]
        public String TBLE_SunatCode
        {
            get { return pv_tble_sunatcode; }
            set
            {
                if (pv_tble_sunatcode != value)
                {
                    pv_tble_sunatcode = value;
                    OnAttributeChanged("TBLE_SunatCode");
                }
            }
        }
        [DataMember]
        public String TBLE_Description1
        {
            get { return pv_tble_description1; }
            set
            {
                if (pv_tble_description1 != value)
                {
                    pv_tble_description1 = value;
                    OnAttributeChanged("TBLE_Description1");
                }
            }
        }
        [DataMember]
        public String TBLE_Description2
        {
            get { return pv_tble_description2; }
            set
            {
                if (pv_tble_description2 != value)
                {
                    pv_tble_description2 = value;
                    OnAttributeChanged("TBLE_Description2");
                }
            }
        }
        [DataMember]
        public Nullable<Int32> TBLE_Number1
        {
            get { return pv_tble_number1; }
            set
            {
                if (pv_tble_number1 != value)
                {
                    pv_tble_number1 = value;
                    OnAttributeChanged("TBLE_Number1");
                }
            }
        }
        [DataMember]
        public Nullable<Decimal> TBLE_Number2
        {
            get { return pv_tble_number2; }
            set
            {
                if (pv_tble_number2 != value)
                {
                    pv_tble_number2 = value;
                    OnAttributeChanged("TBLE_Number2");
                }
            }
        }
        [DataMember]
        public String TBLE_Status
        {
            get { return pv_tble_status; }
            set
            {
                if (pv_tble_status != value)
                {
                    pv_tble_status = value;
                    OnAttributeChanged("TBLE_Status");
                }
            }
        }
        [DataMember]
        public Boolean TBLE_Default
        {
            get { return pv_tble_default; }
            set
            {
                if (pv_tble_default != value)
                {
                    pv_tble_default = value;
                    OnAttributeChanged("TBLE_Default");
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
