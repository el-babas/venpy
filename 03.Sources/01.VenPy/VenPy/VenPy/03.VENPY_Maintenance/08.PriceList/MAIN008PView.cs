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
    public class MAIN008PView
    {
        #region [ VARIABLES ]

        private ObservableCollection<VENPY_PriceList> pv_items;
        private ObservableCollection<VENPY_PriceListDetail> pv_itemspricelistdetail;
        private ObservableCollection<VENPY_Tables> pv_itemstables;
        private VENPY_PriceList pv_item;
        private VENPY_PriceList pv_itemgridview;
        private Int32 pv_numberdecimals;
        private Decimal pv_percentigv;

        #endregion

        #region [ PROPERTIES ]

        public String Title = "Lista de Precios";
        public String NameForm = "MAIN008";
        public IMAIN008LView LView { get; set; }
        public IMAIN008MView MView { get; set; }
        public IBLVENPY_PriceList BL_VENPY_PriceList { get; set; }
        public IBLVENPY_PriceListDetail BL_VENPY_PriceListDetail { get; set; }
        public NumberStyles Number_Styles { get; set; }
        public CultureInfo Culture_Info { get; set; }
        public ObservableCollection<VENPY_PriceList> Items
        {
            get { return pv_items; }
            set { pv_items = value; }
        }
        public ObservableCollection<VENPY_PriceListDetail> ItemsPriceListDetail
        {
            get { return pv_itemspricelistdetail; }
            set { pv_itemspricelistdetail = value; }
        }
        public ObservableCollection<VENPY_Tables> ItemsTables
        {
            get { return pv_itemstables; }
            set { pv_itemstables = value; }
        }
        public VENPY_PriceList Item
        {
            get { return pv_item; }
            set { pv_item = value; }
        }
        public VENPY_PriceList ItemGridView
        {
            get { return pv_itemgridview; }
            set { pv_itemgridview = value; }
        }
        public Int32 NumberDecimals
        {
            get { return pv_numberdecimals; }
            set { pv_numberdecimals = value; }
        }
        public Decimal PercentIgv
        {
            get { return pv_percentigv; }
            set { pv_percentigv = value; }
        }

        #endregion

        #region [ CONSTRUCTORS ]

        public MAIN008PView(IMAIN008LView p_lview, IMAIN008MView p_mview)
        {
            try
            {
                LView = p_lview;
                MView = p_mview;
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
                BL_VENPY_PriceListDetail = new BLVENPY_PriceListDetail();
                Culture_Info = CultureInfo.CreateSpecificCulture("es-PE");
                Number_Styles = NumberStyles.Number | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.Currency | NumberStyles.AllowCurrencySymbol;
                LoadAdditionalData();
                LView.LViewLoad();
                MView.MViewLoad();
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
        public void Search(String p_PRLI_Name)
        {
            try
            {
                Items = new ObservableCollection<VENPY_PriceList>();
                Items = BL_VENPY_PriceList.BLPRLIS_ListPriceList(SessionVariables.BusinessCode, p_PRLI_Name);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public void New()
        {
            try
            {
                MView = new MAIN008MView();
                MView.Presenter = this;
                MView.MViewLoad();
                MView.CleanControls();
                Item = new VENPY_PriceList();
                Item.Instance = InstanceEntity.Insert;
                Item.PRLI_Active = true;
                Item.PRLI_PriceListDetail = ItemsPriceListDetail;
                MView.SetItem();
                ((MAIN008MView)MView).ShowDialog();
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
                    MView = new MAIN008MView();
                    MView.Presenter = this;
                    MView.MViewLoad();
                    MView.CleanControls();
                    Item = BL_VENPY_PriceList.BLPRLIS_APriceList(ItemGridView.BUSI_Code, ItemGridView.PRLI_Code);
                    if (Item != null)
                    {
                        Item.Instance = InstanceEntity.Update;
                        MView.SetItem();
                        ((MAIN008MView)MView).ShowDialog();
                    }
                    else
                    { Messages.ShowInformationMessage(Title, "Ha ocurrido un error al cargar el Item. "); }
                }
                else
                { Messages.ShowInformationMessage(Title, "Debe seleccionar un elemento de la grilla"); }
            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(Title, "Ocurrio un error al editar", ex); }
        }
        public bool Delete()
        {
            try
            {
                if (ItemGridView != null)
                {
                    if (Messages.ShowQuestionMessage(Title, "¿Esta seguro que desea eliminar la Lista de Precio seleccionada?", Messages.TLabelButtons.lbt_Yes_No) == DialogResult.Yes)
                    {
                        string l_message = BL_VENPY_PriceList.BLPRLID_APriceList(ref pv_itemgridview);
                        if (string.IsNullOrEmpty(l_message))
                        {
                            Messages.ShowSatisfactoryMessage(Title, "Se ha eliminado satisfactoriamente");
                            return true;
                        }
                        else
                        {
                            Messages.ShowWarningMessage(Title, l_message);
                            return false;
                        }
                    }
                    else
                    { return false; }
                }
                else
                {
                    Messages.ShowInformationMessage(Title, "Debe seleccionar un elemento de la grilla");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Messages.ShowErrorMessage(Title, "Ha ocurrido un error al eliminar", ex);
                return false;
            }
        }
        public bool Save()
        {
            try
            {
                MView.GetItem();
                if (Item.Check())
                {
                    string l_message = BL_VENPY_PriceList.BLPRLI_Save(ref pv_item);
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
                else
                {
                    Messages.ShowInformationMessage(Title, "Falta ingresar datos obligatorios", Item.PRLI_ErrorMessage);
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
                ItemsPriceListDetail = new ObservableCollection<VENPY_PriceListDetail>();
                ItemsPriceListDetail = BL_VENPY_PriceListDetail.BLPLDES_ByPriceList(SessionVariables.BusinessCode, null);
                if (ItemsPriceListDetail == null || ItemsPriceListDetail.Count == 0)
                { Messages.ShowWarningMessage(Title, "No se ha encontrado ningun listado de Productos, puede que esto ocasione errores."); }

                ItemsTables = TemporaryFiles.DeserializeTables();
                if (ItemsTables == null || ItemsTables.Count == 0)
                { Messages.ShowWarningMessage(Title, "No se ha encontrado ninguna Tabla, puede que esto ocasione errores."); }

                VENPY_PersonalConfiguration l_PersonalConfiguration = new VENPY_PersonalConfiguration();
                l_PersonalConfiguration = TemporaryFiles.DeserializePersonalConfiguration().Where(filter => filter.BUSI_Code == SessionVariables.BusinessCode && filter.USER_Code == SessionVariables.UserCode && filter.PCON_Key == StaticLists.PCON_DecDetail).FirstOrDefault();
                NumberDecimals = l_PersonalConfiguration == null ? 0 : Convert.ToInt32(l_PersonalConfiguration.PCON_Value);

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
