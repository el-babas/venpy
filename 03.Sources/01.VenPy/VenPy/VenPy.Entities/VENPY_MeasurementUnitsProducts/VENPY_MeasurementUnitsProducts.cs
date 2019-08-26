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
    public partial class VENPY_MeasurementUnitsProducts : MasterEntity, INotifyPropertyChanged
    {
        #region [ VARIABLES ]

        private Int32 pv_busi_code;
        private Int32 pv_prod_code;
        private String pv_tble_tableunm;
        private String pv_tble_codeunm;
        private Decimal pv_mupr_conversionfactor;
        private String pv_audi_creationuser;
        private DateTime pv_audi_creationdate;
        private String pv_audi_modificationuser;
        private Nullable<DateTime> pv_audi_modificationdate;

        #endregion

        #region [ CONSTRUCTORS ]

        public VENPY_MeasurementUnitsProducts()
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
        [TableParameter(Export = true, Order = 3)]
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
        [TableParameter(Export = true, Order = 4)]
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
        [TableParameter(Export = true, Order = 5)]
        public Decimal MUPR_ConversionFactor
        {
            get { return pv_mupr_conversionfactor; }
            set
            {
                if (pv_mupr_conversionfactor != value)
                {
                    pv_mupr_conversionfactor = value;
                    OnAttributeChanged("MUPR_ConversionFactor");
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
