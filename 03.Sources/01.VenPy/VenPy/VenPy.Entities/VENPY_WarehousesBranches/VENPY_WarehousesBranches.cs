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
    public partial class VENPY_WarehousesBranches : MasterEntity, INotifyPropertyChanged
    {
        #region [ VARIABLES ]

        private Int32 pv_busi_code;
        private Int32 pv_boff_code;
        private String pv_tble_tablealm;
        private String pv_tble_codealm;
        private String pv_audi_creationuser;
        private DateTime pv_audi_creationdate;
        private String pv_audi_modificationuser;
        private Nullable<DateTime> pv_audi_modificationdate;

        #endregion

        #region [ CONSTRUCTORS ]
        
        public VENPY_WarehousesBranches()
        { }

        #endregion

        #region [ PROPERTIES ]
        
        [DataMember]
        [TableParameter(Export = true, Order = 1)]
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
        [TableParameter(Export = true, Order = 2)]
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
        [TableParameter(Export = true, Order = 3)]
        public String TBLE_TableALM
        {
            get { return pv_tble_tablealm; }
            set
            {
                if (pv_tble_tablealm != value)
                {
                    pv_tble_tablealm = value;
                    OnAttributeChanged("TBLE_TableALM");
                }
            }
        }
        [DataMember]
        [TableParameter(Export = true, Order = 4)]
        public String TBLE_CodeALM
        {
            get { return pv_tble_codealm; }
            set
            {
                if (pv_tble_codealm != value)
                {
                    pv_tble_codealm = value;
                    OnAttributeChanged("TBLE_CodeALM");
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
