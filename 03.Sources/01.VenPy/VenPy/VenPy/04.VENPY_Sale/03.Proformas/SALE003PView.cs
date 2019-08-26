using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using VenPy.Controls;
using VenPy.Connection;
using VenPy.Entities;
using VenPy.Class;
using System.Windows.Forms;
using System.Data;
using System.Globalization;

namespace VenPy.Main
{
   public class SALE003PView
   {
      #region [ VARIABLES ]

      private ObservableCollection<VENPY_Proformas> pv_items;
      private ObservableCollection<VENPY_PriceList> pv_itemspricelist;
      private ObservableCollection<VENPY_Tables> pv_itemstables;
      private VENPY_Proformas pv_itemgridview;
      private Int32 pv_numberdecimals;
      private Int32 pv_numberdecimalsdetail;
      private Decimal pv_percentigv;

      #endregion

      #region [ PROPERTIES ]

      public String Title = "Proformas";
      public String NameForm = "SALE003";
      public ISALE003LView LView { get; set; }
      public IBLVENPY_Proformas BL_VENPY_Proformas { get; set; }
      public IBLVENPY_PriceList BL_VENPY_PriceList { get; set; }
      public IBLVENPY_PriceListDetail BL_VENPY_PriceListDetail { get; set; }
      public NumberStyles Number_Styles { get; set; }
      public CultureInfo Culture_Info { get; set; }
      public ObservableCollection<VENPY_Proformas> Items
      {
         get { return pv_items; }
         set { pv_items = value; }
      }
      public ObservableCollection<VENPY_PriceList> ItemsPriceList
      {
         get { return pv_itemspricelist; }
         set { pv_itemspricelist = value; }
      }
      public ObservableCollection<VENPY_Tables> ItemsTables
      {
         get { return pv_itemstables; }
         set { pv_itemstables = value; }
      }
      public VENPY_Proformas ItemGridView
      {
         get { return pv_itemgridview; }
         set { pv_itemgridview = value; }
      }
      public Int32 NumberDecimals
      {
         get { return pv_numberdecimals; }
         set { pv_numberdecimals = value; }
      }
      public Int32 NumberDecimalsDetail
      {
         get { return pv_numberdecimalsdetail; }
         set { pv_numberdecimalsdetail = value; }
      }
      public Decimal PercentIgv
      {
         get { return pv_percentigv; }
         set { pv_percentigv = value; }
      }

      #endregion

      #region [ CONSTRUCTORS ]

      public SALE003PView(ISALE003LView p_lview)
      {
         try
         {
            LView = p_lview;
         }
         catch (Exception ex)
         { Messages.ShowErrorMessage(Title, "Ha ocurrido un error al inicializar el formulario.", ex); }
      }

      #endregion

      #region [ METHODS ]

      public void Load()
      {
         try
         {
            BL_VENPY_PriceList = new BLVENPY_PriceList();
            BL_VENPY_Proformas = new BLVENPY_Proformas();
            Culture_Info = CultureInfo.CreateSpecificCulture("es-PE");
            Number_Styles = NumberStyles.Number | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.Currency | NumberStyles.AllowCurrencySymbol;
            LoadAdditionalData();
            LView.LViewLoad();
         }
         catch (Exception ex)
         { Messages.ShowErrorMessage(Title, "Ha ocurrido un error inicializando la vista.", ex); }
      }
      public void RefreshItems()
      {
         try
         {
            LView.Search();
         }
         catch (Exception ex)
         { Messages.ShowErrorMessage(Title, "Ha ocurrido un error al actualizar los Items.", ex); }
      }
      public void Search(String p_PROF_Number, DateTime p_PROF_DateBegin, DateTime p_PROF_DateEnd, Boolean p_PROF_OnlyActive)
      {
         try
         {
            Items = new ObservableCollection<VENPY_Proformas>();
            Items = BL_VENPY_Proformas.BLPROFS_ListProformas(SessionVariables.BusinessCode, p_PROF_Number, p_PROF_DateBegin, p_PROF_DateEnd, p_PROF_OnlyActive);
         }
         catch (Exception ex)
         { throw ex; }
      }
      public void New()
      {
         try
         {
            //MView = new SALE003MView();
            //MView.Presenter = this;
            //MView.MViewLoad();
            //MView.CleanControls();
            //Item = new VENPY_PriceList();
            //Item.Instance = InstanceEntity.Insert;
            //Item.PRLI_Active = true;
            //Item.PRLI_PriceListDetail = ItemsPriceListDetail;
            //MView.SetItem();
            //((SALE003MView)MView).ShowDialog();
         }
         catch (Exception ex)
         { Messages.ShowErrorMessage(Title, "Ocurrio un error al crear un nuevo Item.", ex); }
      }
      public void Edit()
      {
         try
         {
            if (ItemGridView != null)
            {
               //MView = new SALE003MView();
               //MView.Presenter = this;
               //MView.MViewLoad();
               //MView.CleanControls();
               //Item = BL_VENPY_PriceList.BLPRLIS_APriceList(ItemGridView.BUSI_Code, ItemGridView.PRLI_Code);
               //if (Item != null)
               //{
               //    Item.Instance = InstanceEntity.Update;
               //    MView.SetItem();
               //    ((SALE003MView)MView).ShowDialog();
               //}
               //else
               //{ Messages.ShowInformationMessage(Title, "Ha ocurrido un error al cargar el Item. "); }
            }
            else
            { Messages.ShowInformationMessage(Title, "Debe seleccionar un elemento de la grilla"); }
         }
         catch (Exception ex)
         { Messages.ShowErrorMessage(Title, "Ocurrio un error al editar", ex); }
      }
      public bool Save(VENPY_Proformas p_Item)
      {
         try
         {
            string l_message = BL_VENPY_Proformas.BLPROD_Save(ref p_Item);
            if (string.IsNullOrEmpty(l_message))
            {
               Messages.ShowSatisfactoryMessage(Title, "Se ha guardadó satisfactoriamente");
               return true;
            }
            else
            {
               Messages.ShowWarningMessage(Title, l_message);
               return false;
            }
         }
         catch (Exception ex)
         {
            Messages.ShowErrorMessage(Title, "Ha ocurrido un error al Guardar.", ex);
            return false;
         }
      }
      public void LoadAdditionalData()
      {
         try
         {
            VENPY_PersonalConfiguration l_PersonalConfiguration = new VENPY_PersonalConfiguration();
            l_PersonalConfiguration = TemporaryFiles.DeserializePersonalConfiguration().Where(filter => filter.BUSI_Code == SessionVariables.BusinessCode && filter.USER_Code == SessionVariables.UserCode && filter.PCON_Key == StaticLists.PCON_DecTotal).FirstOrDefault();
            NumberDecimals = l_PersonalConfiguration == null ? 0 : Convert.ToInt32(l_PersonalConfiguration.PCON_Value);
            l_PersonalConfiguration = TemporaryFiles.DeserializePersonalConfiguration().Where(filter => filter.BUSI_Code == SessionVariables.BusinessCode && filter.USER_Code == SessionVariables.UserCode && filter.PCON_Key == StaticLists.PCON_DecDetail).FirstOrDefault();
            NumberDecimalsDetail = l_PersonalConfiguration == null ? 0 : Convert.ToInt32(l_PersonalConfiguration.PCON_Value);

            l_PersonalConfiguration = TemporaryFiles.DeserializePersonalConfiguration().Where(filter => filter.BUSI_Code == SessionVariables.BusinessCode && filter.USER_Code == SessionVariables.UserCode && filter.PCON_Key == StaticLists.PCON_PriceList).FirstOrDefault();
            string l_PriceList = l_PersonalConfiguration == null ? null : l_PersonalConfiguration.PCON_Value;
            ItemsPriceList = new ObservableCollection<VENPY_PriceList>();
            if (!string.IsNullOrEmpty(l_PriceList))
            {
               ItemsPriceList = BL_VENPY_PriceList.BLPRLIS_ByUser(SessionVariables.BusinessCode, SessionVariables.UserCode);
               if (ItemsPriceList == null || ItemsPriceList.Count == 0)
               { Messages.ShowWarningMessage(Title, "No se ha encontrado ninguna Lista de Precios, puede que esto ocasione errores."); }
            }

            ItemsTables = TemporaryFiles.DeserializeTables();
            if (ItemsTables == null || ItemsTables.Count == 0)
            { Messages.ShowWarningMessage(Title, "No se ha encontrado ninguna Tabla, puede que esto ocasione errores."); }


            VENPY_Settings l_Settings = new VENPY_Settings();
            l_Settings = TemporaryFiles.DeserializeSettings().Where(filter => filter.BUSI_Code == SessionVariables.BusinessCode && filter.SETT_Key == StaticLists.SETT_Igv).FirstOrDefault();
            Decimal l_igv = (Decimal)0.00000000;
            if (Decimal.TryParse(l_Settings.SETT_Value, Number_Styles, Culture_Info, out l_igv))
            { PercentIgv = l_igv; }
         }
         catch (Exception ex)
         { Messages.ShowErrorMessage(Title, "Ha ocurrido un error al traer información adicional.", ex); }
      }

      #endregion
   }
}
