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
    public partial class VENPY_Entities : MasterEntity, INotifyPropertyChanged
    {
        #region [ VARIABLES ]

        private Int32 pv_busi_code;
        private Int32 pv_enti_code;
        private String pv_tble_tabletdi;
        private String pv_tble_codetdi;
        private String pv_enti_entitytype;
        private String pv_enti_documentnumber;
        private String pv_enti_businessname;
        private Nullable<DateTime> pv_enti_birthdate;
        private String pv_enti_address;
        private String pv_ubig_code;
        private String pv_enti_email;
        private String pv_enti_web;
        private String pv_enti_phonenumber;
        private String pv_enti_referentialaddress;
        private Boolean pv_enti_domiciled;
        private String pv_tble_tablepai;
        private String pv_tble_codepai;
        private Boolean pv_enti_favourite;
        private String pv_enti_bankaccount;
        private String pv_enti_status;
        private String pv_audi_creationuser;
        private DateTime pv_audi_creationdate;
        private String pv_audi_modificationuser;
        private Nullable<DateTime> pv_audi_modificationdate;

        #endregion

        #region [ CONSTRUCTORS ]

        public VENPY_Entities()
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
        public Int32 ENTI_Code
        {
            get { return pv_enti_code; }
            set
            {
                if (pv_enti_code != value)
                {
                    pv_enti_code = value;
                    OnAttributeChanged("ENTI_Code");
                }
            }
        }
        [DataMember]
        public String TBLE_TableTDI
        {
            get { return pv_tble_tabletdi; }
            set
            {
                if (pv_tble_tabletdi != value)
                {
                    pv_tble_tabletdi = value;
                    OnAttributeChanged("TBLE_TableTDI");
                }
            }
        }
        [DataMember]
        public String TBLE_CodeTDI
        {
            get { return pv_tble_codetdi; }
            set
            {
                if (pv_tble_codetdi != value)
                {
                    pv_tble_codetdi = value;
                    OnAttributeChanged("TBLE_CodeTDI");
                }
            }
        }
        [DataMember]
        public String ENTI_EntityType
        {
            get { return pv_enti_entitytype; }
            set
            {
                if (pv_enti_entitytype != value)
                {
                    pv_enti_entitytype = value;
                    OnAttributeChanged("ENTI_EntityType");
                }
            }
        }
        [DataMember]
        public String ENTI_DocumentNumber
        {
            get { return pv_enti_documentnumber; }
            set
            {
                if (pv_enti_documentnumber != value)
                {
                    pv_enti_documentnumber = value;
                    OnAttributeChanged("ENTI_DocumentNumber");
                }
            }
        }
        [DataMember]
        public String ENTI_BusinessName
        {
            get { return pv_enti_businessname; }
            set
            {
                if (pv_enti_businessname != value)
                {
                    pv_enti_businessname = value;
                    OnAttributeChanged("ENTI_BusinessName");
                }
            }
        }
        [DataMember]
        public Nullable<DateTime> ENTI_Birthdate
        {
            get { return pv_enti_birthdate; }
            set
            {
                if (pv_enti_birthdate != value)
                {
                    pv_enti_birthdate = value;
                    OnAttributeChanged("ENTI_Birthdate");
                }
            }
        }
        [DataMember]
        public String ENTI_Address
        {
            get { return pv_enti_address; }
            set
            {
                if (pv_enti_address != value)
                {
                    pv_enti_address = value;
                    OnAttributeChanged("ENTI_Address");
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
        public String ENTI_Email
        {
            get { return pv_enti_email; }
            set
            {
                if (pv_enti_email != value)
                {
                    pv_enti_email = value;
                    OnAttributeChanged("ENTI_Email");
                }
            }
        }
        [DataMember]
        public String ENTI_Web
        {
            get { return pv_enti_web; }
            set
            {
                if (pv_enti_web != value)
                {
                    pv_enti_web = value;
                    OnAttributeChanged("ENTI_Web");
                }
            }
        }
        [DataMember]
        public String ENTI_PhoneNumber
        {
            get { return pv_enti_phonenumber; }
            set
            {
                if (pv_enti_phonenumber != value)
                {
                    pv_enti_phonenumber = value;
                    OnAttributeChanged("ENTI_PhoneNumber1");
                }
            }
        }
        [DataMember]
        public String ENTI_ReferentialAddress
        {
            get { return pv_enti_referentialaddress; }
            set
            {
                if (pv_enti_referentialaddress != value)
                {
                    pv_enti_referentialaddress = value;
                    OnAttributeChanged("ENTI_ReferentialAddress");
                }
            }
        }
        [DataMember]
        public Boolean ENTI_Domiciled
        {
            get { return pv_enti_domiciled; }
            set
            {
                if (pv_enti_domiciled != value)
                {
                    pv_enti_domiciled = value;
                    OnAttributeChanged("ENTI_Domiciled");
                }
            }
        }
        [DataMember]
        public String TBLE_TablePAI
        {
            get { return pv_tble_tablepai; }
            set
            {
                if (pv_tble_tablepai != value)
                {
                    pv_tble_tablepai = value;
                    OnAttributeChanged("TBLE_TablePAI");
                }
            }
        }
        [DataMember]
        public String TBLE_CodePAI
        {
            get { return pv_tble_codepai; }
            set
            {
                if (pv_tble_codepai != value)
                {
                    pv_tble_codepai = value;
                    OnAttributeChanged("TBLE_CodePAI");
                }
            }
        }
        [DataMember]
        public Boolean ENTI_Favourite
        {
            get { return pv_enti_favourite; }
            set
            {
                if (pv_enti_favourite != value)
                {
                    pv_enti_favourite = value;
                    OnAttributeChanged("ENTI_Favourite");
                }
            }
        }
        [DataMember]
        public String ENTI_BankAccount
        {
            get { return pv_enti_bankaccount; }
            set
            {
                if (pv_enti_bankaccount != value)
                {
                    pv_enti_bankaccount = value;
                    OnAttributeChanged("ENTI_BankAccount");
                }
            }
        }
        [DataMember]
        public String ENTI_Status
        {
            get { return pv_enti_status; }
            set
            {
                if (pv_enti_status != value)
                {
                    pv_enti_status = value;
                    OnAttributeChanged("ENTI_Status");
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
