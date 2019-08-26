using System;
using System.Text;
using System.Linq;
using System.Globalization;
using System.ComponentModel;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Runtime.Serialization;
using System.Data;
using VenPy.Class;

namespace VenPy.Entities
{
   public partial class VENPY_Proformas
   {
      #region [ VARIABLES ]

      private ObservableCollection<VENPY_ProformaDetails> pv_prof_proformadetails;
      private ObservableCollection<VENPY_ProformaDetails> pv_prof_proformadetailsdeleted;
      private String pv_prof_errormessage;
      private String pv_tble_namemnd;
      private String pv_prof_customername;
      private String pv_prof_namestatus;

      #endregion

      #region [ PROPERTIES ]

      [DataMember]
      public ObservableCollection<VENPY_ProformaDetails> PROF_ProformaDetails
      {
         get { return pv_prof_proformadetails; }
         set { pv_prof_proformadetails = value; }
      }
      [DataMember]
      public ObservableCollection<VENPY_ProformaDetails> PROF_ProformaDetailsDeleted
      {
         get { return pv_prof_proformadetailsdeleted; }
         set { pv_prof_proformadetailsdeleted = value; }
      }
      [DataMember]
      public String PROF_ErrorMessage
      {
         get { return pv_prof_errormessage; }
      }
      [DataMember]
      public String TBLE_NameMND
      {
         get { return pv_tble_namemnd; }
         set
         {
            if (pv_tble_namemnd != value)
            {
               pv_tble_namemnd = value;
               OnAttributeChanged("TBLE_NameMND");
            }
         }
      }
      [DataMember]
      public String PROF_CustomerName
      {
         get { return pv_prof_customername; }
         set
         {
            if (pv_prof_customername != value)
            {
               pv_prof_customername = value;
               OnAttributeChanged("PROF_CustomerName");
            }
         }
      }
      [DataMember]
      public String PROF_NameStatus
      {
         get { return pv_prof_namestatus; }
         set
         {
            if (pv_prof_namestatus != value)
            {
               pv_prof_namestatus = value;
               OnAttributeChanged("PROF_NameStatus");
            }
         }
      }

      #endregion

      #region [ COPYTO ]

      public void CopyTo(ref VENPY_Proformas Item)
      {
         try
         {
            if (Item == null) { Item = new VENPY_Proformas(); }
            Item.BUSI_Code = this.BUSI_Code;
            Item.PROF_Code = this.PROF_Code;
            Item.ENTI_Code = this.ENTI_Code;
            Item.PROF_Number = this.PROF_Number;
            Item.PROF_Date = this.PROF_Date;
            Item.PROF_DueDate = this.PROF_DueDate;
            Item.TBLE_TableMND = this.TBLE_TableMND;
            Item.TBLE_CodeMND = this.TBLE_CodeMND;
            Item.PRLI_Code = this.PRLI_Code;
            Item.PROF_Status = this.PROF_Status;
            Item.PROF_Export = this.PROF_Export;
            Item.PROF_IGV = this.PROF_IGV;
            Item.PROF_PercentageIGV = this.PROF_PercentageIGV;
            Item.PROF_ISC = this.PROF_ISC;
            Item.PROF_Discount = this.PROF_Discount;
            Item.PROF_TotalPrice = this.PROF_TotalPrice;
            Item.PROF_Generated = this.PROF_Generated;
            Item.AUDI_CreationUser = this.AUDI_CreationUser;
            Item.AUDI_CreationDate = this.AUDI_CreationDate;
            Item.AUDI_ModificationUser = this.AUDI_ModificationUser;
            Item.AUDI_ModificationDate = this.AUDI_ModificationDate;
         }
         catch (Exception ex)
         { throw ex; }
      }

      #endregion
   }
}
