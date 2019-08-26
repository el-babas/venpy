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
   public partial class VENPY_ProformaDetails : MasterEntity, INotifyPropertyChanged
   {
      #region [ VARIABLES ]

      private Int32 pv_busi_code;
      private Int32 pv_prof_code;
      private Int32 pv_pfde_item;
      private String pv_pfde_type;
      private String pv_tble_tablefap;
      private String pv_tble_codefap;
      private String pv_tble_tablefas;
      private String pv_tble_codefas;
      private Nullable<Int32> pv_prod_code;
      private Nullable<Int32> pv_serv_code;
      private String pv_plde_description;
      private String pv_tble_tableunm;
      private String pv_tble_codeunm;
      private String pv_tble_tabletai;
      private String pv_tble_codetai;
      private Decimal pv_plde_unitvalue;
      private Decimal pv_plde_unitprice;
      private Decimal pv_plde_quantity;
      private Decimal pv_plde_igv;
      private Decimal pv_plde_isc;
      private Decimal pv_prof_discount;
      private String pv_audi_creationuser;
      private DateTime pv_audi_creationdate;
      private String pv_audi_modificationuser;
      private Nullable<DateTime> pv_audi_modificationdate;

      #endregion

      #region [ CONSTRUCTORS ]

      public VENPY_ProformaDetails()
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
      public Int32 PFDE_Item
      {
         get { return pv_pfde_item; }
         set
         {
            if (pv_pfde_item != value)
            {
               pv_pfde_item = value;
               OnAttributeChanged("PFDE_Item");
            }
         }
      }
      [DataMember]
      public String PFDE_Type
      {
         get { return pv_pfde_type; }
         set
         {
            if (pv_pfde_type != value)
            {
               pv_pfde_type = value;
               OnAttributeChanged("PFDE_Type");
            }
         }
      }
      [DataMember]
      public String TBLE_TableFAP
      {
         get { return pv_tble_tablefap; }
         set
         {
            if (pv_tble_tablefap != value)
            {
               pv_tble_tablefap = value;
               OnAttributeChanged("TBLE_TableFAP");
            }
         }
      }
      [DataMember]
      public String TBLE_CodeFAP
      {
         get { return pv_tble_codefap; }
         set
         {
            if (pv_tble_codefap != value)
            {
               pv_tble_codefap = value;
               OnAttributeChanged("TBLE_CodeFAP");
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
      public Nullable<Int32> PROD_Code
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
      public Nullable<Int32> SERV_Code
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
      public String PLDE_Description
      {
         get { return pv_plde_description; }
         set
         {
            if (pv_plde_description != value)
            {
               pv_plde_description = value;
               OnAttributeChanged("PLDE_Description");
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
      public Decimal PLDE_Quantity
      {
         get { return pv_plde_quantity; }
         set
         {
            if (pv_plde_quantity != value)
            {
               pv_plde_quantity = value;
               OnAttributeChanged("PLDE_Quantity");
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
      public Decimal PLDE_ISC
      {
         get { return pv_plde_isc; }
         set
         {
            if (pv_plde_isc != value)
            {
               pv_plde_isc = value;
               OnAttributeChanged("PLDE_ISC");
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
