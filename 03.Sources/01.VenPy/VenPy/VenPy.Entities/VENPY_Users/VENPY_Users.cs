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
    public partial class VENPY_Users : MasterEntity, INotifyPropertyChanged
    {
        #region [ VARIABLES ]

        private Int32 pv_user_code;
        private String pv_user_userid;
        private String pv_user_password;
        private String pv_user_username;
        private String pv_user_lastname;
        private String pv_user_description;
        private Boolean pv_user_active;
        private String pv_user_mail;
        private Int32 pv_grou_code;
        private String pv_audi_creationuser;
        private DateTime pv_audi_creationdate;
        private String pv_audi_modificationuser;
        private Nullable<DateTime> pv_audi_modificationdate;

        #endregion

        #region [ CONSTRUCTORS ]

        public VENPY_Users()
        { }

        #endregion

        #region [ PROPERTIES ]

        [DataMember]
        public Int32 USER_Code
        {
            get { return pv_user_code; }
            set
            {
                if (pv_user_code != value)
                {
                    pv_user_code = value;
                    OnAttributeChanged("USER_Code");
                }
            }
        }
        [DataMember]
        public String USER_UserId
        {
            get { return pv_user_userid; }
            set
            {
                if (pv_user_userid != value)
                {
                    pv_user_userid = value;
                    OnAttributeChanged("USER_UserId");
                }
            }
        }
        [DataMember]
        public String USER_Password
        {
            get { return pv_user_password; }
            set
            {
                if (pv_user_password != value)
                {
                    pv_user_password = value;
                    OnAttributeChanged("USER_Password");
                }
            }
        }
        [DataMember]
        public String USER_UserName
        {
            get { return pv_user_username; }
            set
            {
                if (pv_user_username != value)
                {
                    pv_user_username = value;
                    OnAttributeChanged("USER_UserName");
                }
            }
        }
        [DataMember]
        public String USER_LastName
        {
            get { return pv_user_lastname; }
            set
            {
                if (pv_user_lastname != value)
                {
                    pv_user_lastname = value;
                    OnAttributeChanged("USER_LastName");
                }
            }
        }
        [DataMember]
        public String USER_Description
        {
            get { return pv_user_description; }
            set
            {
                if (pv_user_description != value)
                {
                    pv_user_description = value;
                    OnAttributeChanged("USER_Description");
                }
            }
        }
        [DataMember]
        public Boolean USER_Active
        {
            get { return pv_user_active; }
            set
            {
                if (pv_user_active != value)
                {
                    pv_user_active = value;
                    OnAttributeChanged("USER_Active");
                }
            }
        }
        [DataMember]
        public String USER_Mail
        {
            get { return pv_user_mail; }
            set
            {
                if (pv_user_mail != value)
                {
                    pv_user_mail = value;
                    OnAttributeChanged("USER_Mail");
                }
            }
        }
        [DataMember]
        public Int32 GROU_Code
        {
            get { return pv_grou_code; }
            set
            {
                if (pv_grou_code != value)
                {
                    pv_grou_code = value;
                    OnAttributeChanged("GROU_Code");
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

