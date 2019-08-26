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
    public class MAIN005PView
    {
        #region [ VARIABLES ]

        private ObservableCollection<VENPY_EntityTypes> pv_items;
        private VENPY_EntityTypes pv_item;
        private VENPY_EntityTypes pv_itemgridview;

        #endregion

        #region [ PROPERTIES ]

        public String Title = "Tipos de Entidades";
        public String NameForm = "MAIN005";
        public IMAIN005LView LView { get; set; }
        public IMAIN005MView MView { get; set; }
        public IBLVENPY_EntityTypes BL_VENPY_EntityTypes { get; set; }
        public ObservableCollection<VENPY_EntityTypes> Items
        {
            get { return pv_items; }
            set { pv_items = value; }
        }
        public VENPY_EntityTypes Item
        {
            get { return pv_item; }
            set { pv_item = value; }
        }
        public VENPY_EntityTypes ItemGridView
        {
            get { return pv_itemgridview; }
            set { pv_itemgridview = value; }
        }

        #endregion

        #region [ CONSTRUCTORS ]

        public MAIN005PView(IMAIN005LView p_lview, IMAIN005MView p_mview)
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
                BL_VENPY_EntityTypes = new BLVENPY_EntityTypes();
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
        public void Search(String p_ETYP_Name)
        {
            try
            {
                Items = new ObservableCollection<VENPY_EntityTypes>();
                Items = BL_VENPY_EntityTypes.BLETYPS_ListEntityTypes(SessionVariables.BusinessCode, p_ETYP_Name);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public void New()
        {
            try
            {
                MView.CleanControls();
                Item = new VENPY_EntityTypes();
                Item.Instance = InstanceEntity.Insert;
                Item.ETYP_Default = false;
                MView.BlockControls();
                ((MAIN005MView)MView).ShowDialog();
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
                    Item = BL_VENPY_EntityTypes.BLETYPS_AEntityType(ItemGridView.BUSI_Code, ItemGridView.ETYP_Code);
                    if (Item != null)
                    {
                        Item.Instance = InstanceEntity.Update;
                        MView.BlockControls();
                        MView.SetItem();
                        ((MAIN005MView)MView).ShowDialog();
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
                    if (!ItemGridView.ETYP_Default || SessionVariables.UserType == StaticLists.USER_Root)
                    {
                        if (Messages.ShowQuestionMessage(Title, "¿Esta seguro que desea eliminar el Tipo de Entidad seleccionado?", Messages.TLabelButtons.lbt_Yes_No) == DialogResult.Yes)
                        {
                            string l_message = BL_VENPY_EntityTypes.BLETYPD_AEntityType(ref pv_itemgridview);
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
        public bool Save()
        {
            try
            {
                MView.GetItem();
                if (!Item.ETYP_Default || SessionVariables.UserType == StaticLists.USER_Root)
                {
                    if (Item.Check())
                    {
                        string l_message = BL_VENPY_EntityTypes.BLETYP_Save(ref pv_item);
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
                        Messages.ShowInformationMessage(Title, "Falta ingresar datos obligatorios", Item.ETYP_ErrorMessage);
                        return false;
                    }
                }
                else
                {
                    Messages.ShowWarningMessage(Title, "No se puede guardar los cambios, porque contiene valores predeterminados");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Messages.ShowErrorMessage(Title, "Ha ocurrido un error al Guardar.", ex);
                return false;
            }
        }

        #endregion
    }
}
