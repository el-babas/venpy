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
    public partial class VENPY_PointsSale : MasterEntity, INotifyPropertyChanged
    {
        #region [ VARIABLES ]

        private Int32 pv_busi_code;
        private Int32 pv_boff_code;
        private Int32 pv_psal_code;
        private String pv_psal_name;
        private Boolean pv_psal_main;
        private String pv_psal_status;
        private String pv_audi_creationuser;
        private DateTime pv_audi_creationdate;
        private String pv_audi_modificationuser;
        private Nullable<DateTime> pv_audi_modificationdate;

        #endregion

        #region [ CONSTRUCTORS ]

        public VENPY_PointsSale()
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
        public Int32 BOFF_Code
        {
            get { return pv_boff_code; }
            set
            {
                if (pv_boff_code != value)
                {
                    pv_boff_code = value;
                    OnAttributeChanged("BOFF_Code");
                }
            }
        }
        [DataMember]
        public Int32 PSAL_Code
        {
            get { return pv_psal_code; }
            set
            {
                if (pv_psal_code != value)
                {
                    pv_psal_code = value;
                    OnAttributeChanged("PSAL_Code");
                }
            }
        }
        [DataMember]
        public String PSAL_Name
        {
            get { return pv_psal_name; }
            set
            {
                if (pv_psal_name != value)
                {
                    pv_psal_name = value;
                    OnAttributeChanged("PSAL_Name");
                }
            }
        }
        [DataMember]
        public Boolean PSAL_Main
        {
            get { return pv_psal_main; }
            set
            {
                if (pv_psal_main != value)
                {
                    pv_psal_main = value;
                    OnAttributeChanged("PSAL_Main");
                }
            }
        }
        [DataMember]
        public String PSAL_Status
        {
            get { return pv_psal_status; }
            set
            {
                if (pv_psal_status != value)
                {
                    pv_psal_status = value;
                    OnAttributeChanged("PSAL_Status");
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
