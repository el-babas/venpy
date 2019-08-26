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
    public partial class VENPY_Business : MasterEntity, INotifyPropertyChanged
    {
        #region [ VARIABLES ]

        private Int32 pv_busi_code;
        private String pv_busi_ruc;
        private String pv_busi_businessname;
        private String pv_busi_tradename;
        private String pv_busi_address1;
        private String pv_busi_address2;
        private String pv_busi_urbanization;
        private String pv_busi_email;
        private String pv_busi_web;
        private String pv_busi_socialnetworks;
        private String pv_busi_phonenumber1;
        private String pv_busi_phonenumber2;
        private String pv_busi_bankaccount;
        private String pv_ubig_code;
        private String pv_audi_creationuser;
        private DateTime pv_audi_creationdate;
        private String pv_audi_modificationuser;
        private Nullable<DateTime> pv_audi_modificationdate;

        #endregion

        #region [ CONSTRUCTORS ]
        
        public VENPY_Business()
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
        public String BUSI_RUC
        {
            get { return pv_busi_ruc; }
            set
            {
                if (pv_busi_ruc != value)
                {
                    pv_busi_ruc = value;
                    OnAttributeChanged("BUSI_RUC");
                }
            }
        }
        [DataMember]
        public String BUSI_BusinessName
        {
            get { return pv_busi_businessname; }
            set
            {
                if (pv_busi_businessname != value)
                {
                    pv_busi_businessname = value;
                    OnAttributeChanged("BUSI_BusinessName");
                }
            }
        }
        [DataMember]
        public String BUSI_TradeName
        {
            get { return pv_busi_tradename; }
            set
            {
                if (pv_busi_tradename != value)
                {
                    pv_busi_tradename = value;
                    OnAttributeChanged("BUSI_TradeName");
                }
            }
        }
        [DataMember]
        public String BUSI_Address1
        {
            get { return pv_busi_address1; }
            set
            {
                if (pv_busi_address1 != value)
                {
                    pv_busi_address1 = value;
                    OnAttributeChanged("BUSI_Address1");
                }
            }
        }
        [DataMember]
        public String BUSI_Address2
        {
            get { return pv_busi_address2; }
            set
            {
                if (pv_busi_address2 != value)
                {
                    pv_busi_address2 = value;
                    OnAttributeChanged("BUSI_Address2");
                }
            }
        }
        [DataMember]
        public String BUSI_Urbanization
        {
            get { return pv_busi_urbanization; }
            set
            {
                if (pv_busi_urbanization != value)
                {
                    pv_busi_urbanization = value;
                    OnAttributeChanged("BUSI_Urbanization");
                }
            }
        }
        [DataMember]
        public String BUSI_Email
        {
            get { return pv_busi_email; }
            set
            {
                if (pv_busi_email != value)
                {
                    pv_busi_email = value;
                    OnAttributeChanged("BUSI_Email");
                }
            }
        }
        [DataMember]
        public String BUSI_Web
        {
            get { return pv_busi_web; }
            set
            {
                if (pv_busi_web != value)
                {
                    pv_busi_web = value;
                    OnAttributeChanged("BUSI_Web");
                }
            }
        }
        [DataMember]
        public String BUSI_SocialNetworks
        {
            get { return pv_busi_socialnetworks; }
            set
            {
                if (pv_busi_socialnetworks != value)
                {
                    pv_busi_socialnetworks = value;
                    OnAttributeChanged("BUSI_SocialNetworks");
                }
            }
        }
        [DataMember]
        public String BUSI_PhoneNumber1
        {
            get { return pv_busi_phonenumber1; }
            set
            {
                if (pv_busi_phonenumber1 != value)
                {
                    pv_busi_phonenumber1 = value;
                    OnAttributeChanged("BUSI_PhoneNumber1");
                }
            }
        }
        [DataMember]
        public String BUSI_PhoneNumber2
        {
            get { return pv_busi_phonenumber2; }
            set
            {
                if (pv_busi_phonenumber2 != value)
                {
                    pv_busi_phonenumber2 = value;
                    OnAttributeChanged("BUSI_PhoneNumber2");
                }
            }
        }
        [DataMember]
        public String BUSI_BankAccount
        {
            get { return pv_busi_bankaccount; }
            set
            {
                if (pv_busi_bankaccount != value)
                {
                    pv_busi_bankaccount = value;
                    OnAttributeChanged("BUSI_BankAccount");
                }
            }
        }
        [DataMember]
        public String UBIG_Code
        {
            get { return pv_ubig_code; }
            set
            {
                if (pv_ubig_code != value)
                {
                    pv_ubig_code = value;
                    OnAttributeChanged("UBIG_Code");
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
