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
    public class MAIN003PView
    {
        #region [ VARIABLES ]

        private ObservableCollection<VENPY_BranchOffices> pv_items;
        private ObservableCollection<VENPY_WarehousesBranches> pv_itemswarehousesbranches;
        private ObservableCollection<VENPY_Ubigeos> pv_itemsubigeos;
        private VENPY_BranchOffices pv_item;
        private VENPY_BranchOffices pv_itemgridview;

        #endregion

        #region [ PROPERTIES ]

        public String Title = "Sucursales";
        public String NameForm = "MAIN003";
        public IMAIN003LView LView { get; set; }
        public IMAIN003MView MView { get; set; }
        public IBLVENPY_BranchOffices BL_VENPY_BranchOffices { get; set; }
        public IBLVENPY_WarehousesBranches BL_VENPY_WarehousesBranches { get; set; }
        public ObservableCollection<VENPY_BranchOffices> Items
        {
            get { return pv_items; }
            set { pv_items = value; }
        }
        public ObservableCollection<VENPY_WarehousesBranches> ItemsWarehousesBranches
        {
            get { return pv_itemswarehousesbranches; }
            set { pv_itemswarehousesbranches = value; }
        }
        public ObservableCollection<VENPY_Ubigeos> ItemsUbigeos
        {
            get { return pv_itemsubigeos; }
            set { pv_itemsubigeos = value; }
        }
        public VENPY_BranchOffices Item
        {
            get { return pv_item; }
            set { pv_item = value; }
        }
        public VENPY_BranchOffices ItemGridView
        {
            get { return pv_itemgridview; }
            set { pv_itemgridview = value; }
        }

        #endregion

        #region [ CONSTRUCTORS ]

        public MAIN003PView(IMAIN003LView p_lview, IMAIN003MView p_mview)
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
                BL_VENPY_BranchOffices = new BLVENPY_BranchOffices();
                BL_VENPY_WarehousesBranches = new BLVENPY_WarehousesBranches();
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
        public void Search(String p_BOFF_Name)
        {
            try
            {
                Items = new ObservableCollection<VENPY_BranchOffices>();
                Items = BL_VENPY_BranchOffices.BLBOFFS_ListBranchOffices(SessionVariables.BusinessCode, SessionVariables.UserCode, p_BOFF_Name);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public void New()
        {
            try
            {
                MView.CleanControls();
                Item = new VENPY_BranchOffices();
                Item.Instance = InstanceEntity.Insert;
                Item.BOFF_WarehousesBranches = ItemsWarehousesBranches;
                MView.FillWarehouses();
                ((MAIN003MView)MView).ShowDialog();
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
                    MView.CleanControls();
                    Item = BL_VENPY_BranchOffices.BLBOFFS_ABranchOffice(ItemGridView.BUSI_Code, ItemGridView.BOFF_Code);
                    if (Item != null)
                    {
                        Item.Instance = InstanceEntity.Update;
                        MView.SetItem();
                        MView.FillWarehouses();
                        ((MAIN003MView)MView).ShowDialog();
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
        public bool Save()
        {
            try
            {
                MView.GetItem();
                if (Item.Check())
                {
                    string l_message = BL_VENPY_BranchOffices.BLBOFF_Save(ref pv_item);
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
                    Messages.ShowInformationMessage(Title, "Falta ingresar datos obligatorios", Item.BOFF_ErrorMessage);
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
                ItemsWarehousesBranches = new ObservableCollection<VENPY_WarehousesBranches>();
                ItemsWarehousesBranches = BL_VENPY_WarehousesBranches.BLWABRS_ByBranch(SessionVariables.BusinessCode, null);
                if (ItemsWarehousesBranches == null || ItemsWarehousesBranches.Count == 0)
                { Messages.ShowWarningMessage(Title, "No se ha encontrado ningun Almacén, puede que esto ocasione errores."); }

                ItemsUbigeos = TemporaryFiles.DeserializeUbigeos();
                if (ItemsUbigeos == null || ItemsUbigeos.Count == 0)
                { Messages.ShowWarningMessage(Title, "No se ha encontrado ningun Ubigeo, puede que esto ocasione errores."); }
            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(Title, "Ha ocurrido un error al traer información adicional.", ex); }
        }

        #endregion
    }
}
