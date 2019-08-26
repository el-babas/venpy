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
    public partial class VENPY_Services : MasterEntity, INotifyPropertyChanged
    {
        #region [ VARIABLES ]

        private Int32 pv_busi_code;
        private Int32 pv_serv_code;
        private Boolean pv_serv_active;
        private String pv_serv_name;
        private String pv_serv_description;
        private String pv_tble_tablefas;
        private String pv_tble_codefas;
        private String pv_tble_tableunm;
        private String pv_tble_codeunm;
        private String pv_tble_tabletai;
        private String pv_tble_codetai;
        private String pv_tble_tablemnd;
        private String pv_tble_codemnd;
        private Decimal pv_serv_unitvalue;
        private Decimal pv_serv_igv;
        private Decimal pv_serv_unitprice;
        private String pv_audi_creationuser;
        private DateTime pv_audi_creationdate;
        private String pv_audi_modificationuser;
        private Nullable<DateTime> pv_audi_modificationdate;

        #endregion

        #region [ CONSTRUCTORS ]

        public VENPY_Services()
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
        public Int32 SERV_Code
        {
            get { return pv_serv_code; }
            set
            {
                if (pv_serv_code != value)
                {
                    pv_serv_code = value;
                    OnAttributeChanged("SERV_Code");
                }
            }
        }
        [DataMember]
        public Boolean SERV_Active
        {
            get { return pv_serv_active; }
            set
            {
                if (pv_serv_active != value)
                {
                    pv_serv_active = value;
                    OnAttributeChanged("SERV_Active");
                }
            }
        }
        [DataMember]
        public String SERV_Name
        {
            get { return pv_serv_name; }
            set
            {
                if (pv_serv_name != value)
                {
                    pv_serv_name = value;
                    OnAttributeChanged("SERV_Name");
                }
            }
        }
        [DataMember]
        public String SERV_Description
        {
            get { return pv_serv_description; }
            set
            {
                if (pv_serv_description != value)
                {
                    pv_serv_description = value;
                    OnAttributeChanged("SERV_Description");
                }
            }
        }
        [DataMember]
        public String TBLE_TableFAS
        {
            get { return pv_tble_tablefas; }
            set
            {
                if (pv_tble_tablefas != value)
                {
                    pv_tble_tablefas = value;
                    OnAttributeChanged("TBLE_TableFAS");
                }
            }
        }
        [DataMember]
        public String TBLE_CodeFAS
        {
            get { return pv_tble_codefas; }
            set
            {
                if (pv_tble_codefas != value)
                {
                    pv_tble_codefas = value;
                    OnAttributeChanged("TBLE_CodeFAS");
                }
            }
        }
        [DataMember]
        public String TBLE_TableUNM
        {
            get { return pv_tble_tableunm; }
            set
            {
                if (pv_tble_tableunm != value)
                {
                    pv_tble_tableunm = value;
                    OnAttributeChanged("TBLE_TableUNM");
                }
            }
        }
        [DataMember]
        public String TBLE_CodeUNM
        {
            get { return pv_tble_codeunm; }
            set
            {
                if (pv_tble_codeunm != value)
                {
                    pv_tble_codeunm = value;
                    OnAttributeChanged("TBLE_CodeUNM");
                }
            }
        }
        [DataMember]
        public String TBLE_TableTAI
        {
            get { return pv_tble_tabletai; }
            set
            {
                if (pv_tble_tabletai != value)
                {
                    pv_tble_tabletai = value;
                    OnAttributeChanged("TBLE_TableTAI");
                }
            }
        }
        [DataMember]
        public String TBLE_CodeTAI
        {
            get { return pv_tble_codetai; }
            set
            {
                if (pv_tble_codetai != value)
                {
                    pv_tble_codetai = value;
                    OnAttributeChanged("TBLE_CodeTAI");
                }
            }
        }
        [DataMember]
        public String TBLE_TableMND
        {
            get { return pv_tble_tablemnd; }
            set
            {
                if (pv_tble_tablemnd != value)
                {
                    pv_tble_tablemnd = value;
                    OnAttributeChanged("TBLE_TableMND");
                }
            }
        }
        [DataMember]
        public String TBLE_CodeMND
        {
            get { return pv_tble_codemnd; }
            set
            {
                if (pv_tble_codemnd != value)
                {
                    pv_tble_codemnd = value;
                    OnAttributeChanged("TBLE_CodeMND");
                }
            }
        }
        [DataMember]
        public Decimal SERV_UnitValue
        {
            get { return pv_serv_unitvalue; }
            set
            {
                if (pv_serv_unitvalue != value)
                {
                    pv_serv_unitvalue = value;
                    OnAttributeChanged("SERV_UnitValue");
                }
            }
        }
        [DataMember]
        public Decimal SERV_IGV
        {
            get { return pv_serv_igv; }
            set
            {
                if (pv_serv_igv != value)
                {
                    pv_serv_igv = value;
                    OnAttributeChanged("SERV_IGV");
                }
            }
        }
        [DataMember]
        public Decimal SERV_UnitPrice
        {
            get { return pv_serv_unitprice; }
            set
            {
                if (pv_serv_unitprice != value)
                {
                    pv_serv_unitprice = value;
                    OnAttributeChanged("SERV_UnitPrice");
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
