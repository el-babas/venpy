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
   public partial class VENPY_Proformas : MasterEntity, INotifyPropertyChanged
   {
      #region [ VARIABLES ]

      private Int32 pv_busi_code;
      private Int32 pv_prof_code;
      private Int32 pv_enti_code;
      private String pv_prof_number;
      private DateTime pv_prof_date;
      private Nullable<DateTime> pv_prof_duedate;
      private String pv_tble_tablemnd;
      private String pv_tble_codemnd;
      private Nullable<Int32> pv_prli_code;
      private String pv_prof_status;
      private Boolean pv_prof_export;
      private Decimal pv_prof_igv;
      private Decimal pv_prof_percentageigv;
      private Decimal pv_prof_isc;
      private Decimal pv_prof_discount;
      private Decimal pv_prof_totalprice;
      private Boolean pv_prof_generated;
      private String pv_audi_creationuser;
      private DateTime pv_audi_creationdate;
      private String pv_audi_modificationuser;
      private Nullable<DateTime> pv_audi_modificationdate;

      #endregion

      #region [ CONSTRUCTORS ]

      public VENPY_Proformas()
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
      public Int32 PROF_Code
      {
         get { return pv_prof_code; }
         set
         {
            if (pv_prof_code != value)
            {
               pv_prof_code = value;
               OnAttributeChanged("PROF_Code");
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
      public String PROF_Number
      {
         get { return pv_prof_number; }
         set
         {
            if (pv_prof_number != value)
            {
               pv_prof_number = value;
               OnAttributeChanged("PROF_Number");
            }
         }
      }
      [DataMember]
      public DateTime PROF_Date
      {
         get { return pv_prof_date; }
         set
         {
            if (pv_prof_date != value)
            {
               pv_prof_date = value;
               OnAttributeChanged("PROF_Date");
            }
         }
      }
      [DataMember]
      public Nullable<DateTime> PROF_DueDate
      {
         get { return pv_prof_duedate; }
         set
         {
            if (pv_prof_duedate != value)
            {
               pv_prof_duedate = value;
               OnAttributeChanged("PROF_DueDate");
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
      public Nullable<Int32> PRLI_Code
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
      public String PROF_Status
      {
         get { return pv_prof_status; }
         set
         {
            if (pv_prof_status != value)
            {
               pv_prof_status = value;
               OnAttributeChanged("PROF_Status");
            }
         }
      }
      [DataMember]
      public Boolean PROF_Export
      {
         get { return pv_prof_export; }
         set
         {
            if (pv_prof_export != value)
            {
               pv_prof_export = value;
               OnAttributeChanged("PROF_Export");
            }
         }
      }
      [DataMember]
      public Decimal PROF_IGV
      {
         get { return pv_prof_igv; }
         set
         {
            if (pv_prof_igv != value)
            {
               pv_prof_igv = value;
               OnAttributeChanged("PROF_IGV");
            }
         }
      }
      [DataMember]
      public Decimal PROF_PercentageIGV
      {
         get { return pv_prof_percentageigv; }
         set
         {
            if (pv_prof_percentageigv != value)
            {
               pv_prof_percentageigv = value;
               OnAttributeChanged("PROF_PercentageIGV");
            }
         }
      }
      [DataMember]
      public Decimal PROF_ISC
      {
         get { return pv_prof_isc; }
         set
         {
            if (pv_prof_isc != value)
            {
               pv_prof_isc = value;
               OnAttributeChanged("PROF_ISC");
            }
         }
      }
      [DataMember]
      public Decimal PROF_Discount
      {
         get { return pv_prof_discount; }
         set
         {
            if (pv_prof_discount != value)
            {
               pv_prof_discount = value;
               OnAttributeChanged("PROF_Discount");
            }
         }
      }
      [DataMember]
      public Decimal PROF_TotalPrice
      {
         get { return pv_prof_totalprice; }
         set
         {
            if (pv_prof_totalprice != value)
            {
               pv_prof_totalprice = value;
               OnAttributeChanged("PROF_TotalPrice");
            }
         }
      }
      [DataMember]
      public Boolean PROF_Generated
      {
         get { return pv_prof_generated; }
         set
         {
            if (pv_prof_generated != value)
            {
               pv_prof_generated = value;
               OnAttributeChanged("PROF_Generated");
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
