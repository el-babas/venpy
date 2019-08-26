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
    public partial class VENPY_PersonalConfiguration : MasterEntity, INotifyPropertyChanged
    {
        #region [ VARIABLES ]

        private Int32 pv_busi_code;
        private Int32 pv_user_code;
        private String pv_pcon_key;
        private String pv_pcon_value;
        private String pv_pcon_description;
        private String pv_audi_creationuser;
        private DateTime pv_audi_creationdate;
        private String pv_audi_modificationuser;
        private Nullable<DateTime> pv_audi_modificationdate;

        #endregion

        #region [ CONSTRUCTORS ]

        public VENPY_PersonalConfiguration()
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
        public String PCON_Key
        {
            get { return pv_pcon_key; }
            set
            {
                if (pv_pcon_key != value)
                {
                    pv_pcon_key = value;
                    OnAttributeChanged("PCON_Key");
                }
            }
        }
        [DataMember]
        public String PCON_Value
        {
            get { return pv_pcon_value; }
            set
            {
                if (pv_pcon_value != value)
                {
                    pv_pcon_value = value;
                    OnAttributeChanged("PCON_Value");
                }
            }
        }
        [DataMember]
        public String PCON_Description
        {
            get { return pv_pcon_description; }
            set
            {
                if (pv_pcon_description != value)
                {
                    pv_pcon_description = value;
                    OnAttributeChanged("PCON_Description");
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
