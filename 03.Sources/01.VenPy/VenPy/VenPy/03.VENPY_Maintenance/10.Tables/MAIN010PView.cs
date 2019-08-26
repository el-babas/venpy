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
    public class MAIN010PView
    {
        #region [ VARIABLES ]

        private ObservableCollection<VENPY_Tables> pv_itemstables;
        private ObservableCollection<VENPY_Tables> pv_items;
        private VENPY_Tables pv_item;
        private VENPY_Tables pv_itemgridview;

        #endregion

        #region [ PROPERTIES ]

        public String Title = "Tablas";
        public String NameForm = "MAIN010";
        public IMAIN010LView LView { get; set; }
        public IMAIN010MView MView { get; set; }
        public IBLVENPY_Tables BL_VENPY_Tables { get; set; }
        public ObservableCollection<VENPY_Tables> ItemsTables
        {
            get { return pv_itemstables; }
            set { pv_itemstables = value; }
        }
        public ObservableCollection<VENPY_Tables> Items
        {
            get { return pv_items; }
            set { pv_items = value; }
        }
        public VENPY_Tables Item
        {
            get { return pv_item; }
            set { pv_item = value; }
        }
        public VENPY_Tables ItemGridView
        {
            get { return pv_itemgridview; }
            set { pv_itemgridview = value; }
        }

        #endregion

        #region [ CONSTRUCTORS ]

        public MAIN010PView(IMAIN010LView p_lview, IMAIN010MView p_mview)
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
                BL_VENPY_Tables = new BLVENPY_Tables();
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
        public void Search(String p_TBLE_Table)
        {
            try
            {
                Items = new ObservableCollection<VENPY_Tables>();
                Items = BL_VENPY_Tables.BLTBLES_ListTables(SessionVariables.BusinessCode, p_TBLE_Table);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public void New(String p_TBLE_Table)
        {
            try
            {
                MView.CleanControls();
                Item = new VENPY_Tables();
                Item.Instance = InstanceEntity.Insert;
                Item.TBLE_Default = false;
                Item.TBLE_Table = p_TBLE_Table;
                Item.TBLE_Status = "A";
                MView.SetItem();
                ((MAIN010MView)MView).ShowDialog();
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
                    Item = BL_VENPY_Tables.BLTBLES_ATable(ItemGridView.BUSI_Code, ItemGridView.TBLE_Table, ItemGridView.TBLE_Code);
                    if (Item != null)
                    {
                        Item.Instance = InstanceEntity.Update;
                        MView.SetItem();
                        ((MAIN010MView)MView).ShowDialog();
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
                    string l_message = BL_VENPY_Tables.BLTBLE_Save(ref pv_item);
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
                    Messages.ShowInformationMessage(Title, "Falta ingresar datos obligatorios", Item.TBLE_ErrorMessage);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Messages.ShowErrorMessage(Title, "Ha ocurrido un error al Guardar.", ex);
                return false;
            }
        }
        public bool Delete()
        {
            try
            {
                if (ItemGridView != null)
                {
                    if (!ItemGridView.TBLE_Default || SessionVariables.UserType == StaticLists.USER_Root)
                    {
                        if (Messages.ShowQuestionMessage(Title, "¿Esta seguro que desea eliminar el registro seleccionado?", Messages.TLabelButtons.lbt_Yes_No) == DialogResult.Yes)
                        {
                            string l_message = BL_VENPY_Tables.BLTBLED_ATable(ref pv_itemgridview);
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
                        Messages.ShowWarningMessage(Title, "No se puede eliminar el Item seleccionado, porque contiene valores predeterminados");
                        return false;
                    }
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
