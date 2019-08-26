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
    public partial class VENPY_Ubigeos : MasterEntity, INotifyPropertyChanged
    {
        #region [ VARIABLES ]

        private String pv_ubig_code;
        private String pv_ubig_parentcode;
        private String pv_ubig_sunatcode;
        private String pv_ubig_internationalcode;
        private String pv_ubig_description;
        private String pv_ubig_observations;
        private String pv_audi_creationuser;
        private DateTime pv_audi_creationdate;
        private String pv_audi_modificationuser;
        private Nullable<DateTime> pv_audi_modificationdate;

        #endregion

        #region [ CONSTRUCTORS ]
        
        public VENPY_Ubigeos()
        { }
        
        #endregion

        #region [ PROPERTIES ]

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
        public String UBIG_ParentCode
        {
            get { return pv_ubig_parentcode; }
            set
            {
                if (pv_ubig_parentcode != value)
                {
                    pv_ubig_parentcode = value;
                    OnAttributeChanged("UBIG_ParentCode");
                }
            }
        }
        [DataMember]
        public String UBIG_SunatCode
        {
            get { return pv_ubig_sunatcode; }
            set
            {
                if (pv_ubig_sunatcode != value)
                {
                    pv_ubig_sunatcode = value;
                    OnAttributeChanged("UBIG_SunatCode");
                }
            }
        }
        [DataMember]
        public String UBIG_InternationalCode
        {
            get { return pv_ubig_internationalcode; }
            set
            {
                if (pv_ubig_internationalcode != value)
                {
                    pv_ubig_internationalcode = value;
                    OnAttributeChanged("UBIG_InternationalCode");
                }
            }
        }
        [DataMember]
        public String UBIG_Description
        {
            get { return pv_ubig_description; }
            set
            {
                if (pv_ubig_description != value)
                {
                    pv_ubig_description = value;
                    OnAttributeChanged("UBIG_Description");
                }
            }
        }
        [DataMember]
        public String UBIG_Observations
        {
            get { return pv_ubig_observations; }
            set
            {
                if (pv_ubig_observations != value)
                {
                    pv_ubig_observations = value;
                    OnAttributeChanged("UBIG_Observations");
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
