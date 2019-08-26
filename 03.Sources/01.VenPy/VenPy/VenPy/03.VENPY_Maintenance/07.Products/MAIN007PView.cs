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

namespace VenPy.Main
{
    public class MAIN007PView
    {
        #region [ VARIABLES ]

        private ObservableCollection<VENPY_Products> pv_items;
        private ObservableCollection<VENPY_Tables> pv_itemstables;
        private VENPY_Products pv_item;
        private VENPY_Products pv_itemgridview;

        #endregion

        #region [ PROPERTIES ]

        public String Title = "Productos";
        public String NameForm = "MAIN007";
        public IMAIN007LView LView { get; set; }
        public IMAIN007MView MView { get; set; }
        public IBLVENPY_Products BL_VENPY_Products { get; set; }
        public IBLVENPY_MeasurementUnitsProducts BL_VENPY_MeasurementUnitsProducts { get; set; }
        public ObservableCollection<VENPY_Products> Items
        {
            get { return pv_items; }
            set { pv_items = value; }
        }
        public ObservableCollection<VENPY_Tables> ItemsTables
        {
            get { return pv_itemstables; }
            set { pv_itemstables = value; }
        }
        public VENPY_Products Item
        {
            get { return pv_item; }
            set { pv_item = value; }
        }
        public VENPY_Products ItemGridView
        {
            get { return pv_itemgridview; }
            set { pv_itemgridview = value; }
        }

        #endregion

        #region [ CONSTRUCTORS ]

        public MAIN007PView(IMAIN007LView p_lview, IMAIN007MView p_mview)
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
                BL_VENPY_Products = new BLVENPY_Products();
                BL_VENPY_MeasurementUnitsProducts = new BLVENPY_MeasurementUnitsProducts();
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
        public void Search(String p_TBLE_TableFAP, String p_TBLE_CodeFAP, String p_TBLE_TableMAR, String p_TBLE_CodeMAR, String p_PROD_Name)
        {
            try
            {
                Items = new ObservableCollection<VENPY_Products>();
                Items = BL_VENPY_Products.BLPRODS_ListProducts(SessionVariables.BusinessCode, p_TBLE_TableFAP, p_TBLE_CodeFAP, p_TBLE_TableMAR, p_TBLE_CodeMAR, p_PROD_Name);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public void New(Int32 p_ETYP_Code)
        {
            try
            {
                MView = new MAIN007MView();
                MView.Presenter = this;
                MView.MViewLoad();
                MView.CleanControls();
                Item = new VENPY_Products();
                Item.Instance = InstanceEntity.Insert;
                Item.PROD_Active = true;
                Item.PROD_MeasurementUnitsProducts = new ObservableCollection<VENPY_MeasurementUnitsProducts>();
                MView.SetItem();
                ((MAIN007MView)MView).ShowDialog();
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
                    MView = new MAIN007MView();
                    MView.Presenter = this;
                    MView.MViewLoad();
                    MView.CleanControls();
                    Item = BL_VENPY_Products.BLPRODS_AProduct(ItemGridView.BUSI_Code, ItemGridView.PROD_Code);
                    if (Item != null)
                    {
                        Item.Instance = InstanceEntity.Update;
                        MView.SetItem();
                        ((MAIN007MView)MView).ShowDialog();
                    }
                    else
                    { Messages.ShowWarningMessage(Title, "Ha ocurrido un error al cargar el Item. "); }
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
                    if (Messages.ShowQuestionMessage(Title, "¿Esta seguro que desea eliminar el Producto seleccionado?", Messages.TLabelButtons.lbt_Yes_No) == DialogResult.Yes)
                    {
                        string l_message = BL_VENPY_Products.BLPRODD_AProduct(ref pv_itemgridview);
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
                    string l_message = BL_VENPY_Products.BLPROD_Save(ref pv_item);
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
                    Messages.ShowInformationMessage(Title, "Falta ingresar datos obligatorios", Item.PROD_ErrorMessage);
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
                ItemsTables = TemporaryFiles.DeserializeTables();
                if (ItemsTables == null || ItemsTables.Count == 0)
                { Messages.ShowWarningMessage(Title, "No se ha encontrado ninguna Tabla, puede que esto ocasione errores."); }
            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(Title, "Ha ocurrido un error al traer información adicional.", ex); }
        }

        #endregion
    }
}
