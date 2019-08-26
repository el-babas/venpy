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
    public partial class VENPY_ExchangeRate : MasterEntity, INotifyPropertyChanged
    {
        #region [ VARIABLES ]

        private Int32 pv_busi_code;
        private DateTime pv_exra_date;
        private Decimal pv_exra_officialpurchase;
        private Decimal pv_exra_officialsale;
        private Decimal pv_exra_internalpurchase;
        private Decimal pv_exra_internalsale;
        private String pv_audi_creationuser;
        private DateTime pv_audi_creationdate;
        private String pv_audi_modificationuser;
        private Nullable<DateTime> pv_audi_modificationdate;

        #endregion

        #region [ CONSTRUCTORS ]

        public VENPY_ExchangeRate()
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
        public DateTime EXRA_Date
        {
            get { return pv_exra_date; }
            set
            {
                if (pv_exra_date != value)
                {
                    pv_exra_date = value;
                    OnAttributeChanged("EXRA_Date");
                }
            }
        }
        [DataMember]
        public Decimal EXRA_OfficialPurchase
        {
            get { return pv_exra_officialpurchase; }
            set
            {
                if (pv_exra_officialpurchase != value)
                {
                    pv_exra_officialpurchase = value;
                    OnAttributeChanged("EXRA_OfficialPurchase");
                }
            }
        }
        [DataMember]
        public Decimal EXRA_OfficialSale
        {
            get { return pv_exra_officialsale; }
            set
            {
                if (pv_exra_officialsale != value)
                {
                    pv_exra_officialsale = value;
                    OnAttributeChanged("EXRA_OfficialSale");
                }
            }
        }
        [DataMember]
        public Decimal EXRA_InternalPurchase
        {
            get { return pv_exra_internalpurchase; }
            set
            {
                if (pv_exra_internalpurchase != value)
                {
                    pv_exra_internalpurchase = value;
                    OnAttributeChanged("EXRA_InternalPurchase");
                }
            }
        }
        [DataMember]
        public Decimal EXRA_InternalSale
        {
            get { return pv_exra_internalsale; }
            set
            {
                if (pv_exra_internalsale != value)
                {
                    pv_exra_internalsale = value;
                    OnAttributeChanged("EXRA_InternalSale");
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
