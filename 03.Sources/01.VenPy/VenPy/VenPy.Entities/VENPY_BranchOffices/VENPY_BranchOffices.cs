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
    public partial class VENPY_BranchOffices : MasterEntity, INotifyPropertyChanged
    {
        #region [ VARIABLES ]

        private Int32 pv_busi_code;
        private Int32 pv_boff_code;
        private String pv_boff_name;
        private String pv_boff_address;
        private String pv_boff_description;
        private String pv_boff_email;
        private String pv_boff_web;
        private String pv_boff_socialnetworks;
        private String pv_boff_phonenumber1;
        private String pv_boff_phonenumber2;
        private String pv_ubig_code;
        private String pv_audi_creationuser;
        private DateTime pv_audi_creationdate;
        private String pv_audi_modificationuser;
        private Nullable<DateTime> pv_audi_modificationdate;

        #endregion

        #region [ CONSTRUCTORS ]
        
        public VENPY_BranchOffices()
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
        public String BOFF_Name
        {
            get { return pv_boff_name; }
            set
            {
                if (pv_boff_name != value)
                {
                    pv_boff_name = value;
                    OnAttributeChanged("BOFF_Name");
                }
            }
        }
        [DataMember]
        public String BOFF_Address
        {
            get { return pv_boff_address; }
            set
            {
                if (pv_boff_address != value)
                {
                    pv_boff_address = value;
                    OnAttributeChanged("BOFF_Address");
                }
            }
        }
        [DataMember]
        public String BOFF_Description
        {
            get { return pv_boff_description; }
            set
            {
                if (pv_boff_description != value)
                {
                    pv_boff_description = value;
                    OnAttributeChanged("BOFF_Description");
                }
            }
        }
        [DataMember]
        public String BOFF_Email
        {
            get { return pv_boff_email; }
            set
            {
                if (pv_boff_email != value)
                {
                    pv_boff_email = value;
                    OnAttributeChanged("BOFF_Email");
                }
            }
        }
        [DataMember]
        public String BOFF_Web
        {
            get { return pv_boff_web; }
            set
            {
                if (pv_boff_web != value)
                {
                    pv_boff_web = value;
                    OnAttributeChanged("BOFF_Web");
                }
            }
        }
        [DataMember]
        public String BOFF_SocialNetworks
        {
            get { return pv_boff_socialnetworks; }
            set
            {
                if (pv_boff_socialnetworks != value)
                {
                    pv_boff_socialnetworks = value;
                    OnAttributeChanged("BOFF_SocialNetworks");
                }
            }
        }
        [DataMember]
        public String BOFF_PhoneNumber1
        {
            get { return pv_boff_phonenumber1; }
            set
            {
                if (pv_boff_phonenumber1 != value)
                {
                    pv_boff_phonenumber1 = value;
                    OnAttributeChanged("BOFF_PhoneNumber1");
                }
            }
        }
        [DataMember]
        public String BOFF_PhoneNumber2
        {
            get { return pv_boff_phonenumber2; }
            set
            {
                if (pv_boff_phonenumber2 != value)
                {
                    pv_boff_phonenumber2 = value;
                    OnAttributeChanged("BOFF_PhoneNumber2");
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
