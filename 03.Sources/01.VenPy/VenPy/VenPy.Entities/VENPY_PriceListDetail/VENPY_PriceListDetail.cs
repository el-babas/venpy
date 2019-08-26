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
    public partial class VENPY_PriceListDetail : MasterEntity, INotifyPropertyChanged
    {
        #region [ VARIABLES ]

        private Int32 pv_busi_code;
        private Int32 pv_prli_code;
        private Int32 pv_plde_item;
        private Int32 pv_prod_code;
        private String pv_tble_tableunm;
        private String pv_tble_codeunm;
        private String pv_tble_tabletai;
        private String pv_tble_codetai;
        private Decimal pv_plde_unitvalue;
        private Decimal pv_plde_igv;
        private Decimal pv_plde_unitprice;
        private String pv_audi_creationuser;
        private DateTime pv_audi_creationdate;
        private String pv_audi_modificationuser;
        private Nullable<DateTime> pv_audi_modificationdate;

        #endregion

        #region [ CONSTRUCTORS ]

        public VENPY_PriceListDetail()
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
        public Int32 PRLI_Code
        {
            get { return pv_prli_code; }
            set
            {
                if (pv_prli_code != value)
                {
                    pv_prli_code = value;
                    OnAttributeChanged("PRLI_Code");
                }
            }
        }
        [DataMember]
        public Int32 PLDE_Item
        {
            get { return pv_plde_item; }
            set
            {
                if (pv_plde_item != value)
                {
                    pv_plde_item = value;
                    OnAttributeChanged("PLDE_Item");
                }
            }
        }
        [DataMember]
        public Int32 PROD_Code
        {
            get { return pv_prod_code; }
            set
            {
                if (pv_prod_code != value)
                {
                    pv_prod_code = value;
                    OnAttributeChanged("PROD_Code");
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
        public Decimal PLDE_UnitValue
        {
            get { return pv_plde_unitvalue; }
            set
            {
                if (pv_plde_unitvalue != value)
                {
                    pv_plde_unitvalue = value;
                    OnAttributeChanged("PLDE_UnitValue");
                }
            }
        }
        [DataMember]
        public Decimal PLDE_IGV
        {
            get { return pv_plde_igv; }
            set
            {
                if (pv_plde_igv != value)
                {
                    pv_plde_igv = value;
                    OnAttributeChanged("PLDE_IGV");
                }
            }
        }
        [DataMember]
        public Decimal PLDE_UnitPrice
        {
            get { return pv_plde_unitprice; }
            set
            {
                if (pv_plde_unitprice != value)
                {
                    pv_plde_unitprice = value;
                    OnAttributeChanged("PLDE_UnitPrice");
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
