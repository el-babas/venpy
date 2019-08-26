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
    public class MAIN006PView
    {
        #region [ VARIABLES ]

        private ObservableCollection<VENPY_Entities> pv_items;
        private ObservableCollection<VENPY_FunctionsEntities> p_itemsfunctionsentities;
        private ObservableCollection<VENPY_Ubigeos> pv_itemsubigeos;
        private ObservableCollection<VENPY_Tables> pv_itemstables;
        private VENPY_Entities pv_item;
        private VENPY_Entities pv_itemgridview;

        #endregion

        #region [ PROPERTIES ]

        public String Title = "Entidades";
        public String NameForm = "MAIN006";
        public IMAIN006LView LView { get; set; }
        public IMAIN006MView MView { get; set; }
        public IBLVENPY_Entities BL_VENPY_Entities { get; set; }
        public IBLVENPY_FunctionsEntities BL_VENPY_FunctionsEntities { get; set; }
        public ObservableCollection<VENPY_Entities> Items
        {
            get { return pv_items; }
            set { pv_items = value; }
        }
        public ObservableCollection<VENPY_FunctionsEntities> ItemsFunctionsEntities
        {
            get { return p_itemsfunctionsentities; }
            set { p_itemsfunctionsentities = value; }
        }
        public ObservableCollection<VENPY_Ubigeos> ItemsUbigeos
        {
            get { return pv_itemsubigeos; }
            set { pv_itemsubigeos = value; }
        }
        public ObservableCollection<VENPY_Tables> ItemsTables
        {
            get { return pv_itemstables; }
            set { pv_itemstables = value; }
        }
        public VENPY_Entities Item
        {
            get { return pv_item; }
            set { pv_item = value; }
        }
        public VENPY_Entities ItemGridView
        {
            get { return pv_itemgridview; }
            set { pv_itemgridview = value; }
        }

        #endregion

        #region [ CONSTRUCTORS ]

        public MAIN006PView(IMAIN006LView p_lview, IMAIN006MView p_mview)
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
                BL_VENPY_Entities = new BLVENPY_Entities();
                BL_VENPY_FunctionsEntities = new BLVENPY_FunctionsEntities();
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
        public void Search(Int32 p_ETYP_Code, String p_ENTI_DocumentNumber, String p_ENTI_BusinessName, Boolean p_ENTI_Favourite)
        {
            try
            {
                Items = new ObservableCollection<VENPY_Entities>();
                Items = BL_VENPY_Entities.BLENTIS_ListEntities(SessionVariables.BusinessCode, p_ETYP_Code, p_ENTI_DocumentNumber, p_ENTI_BusinessName, p_ENTI_Favourite);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public void New(Int32 p_ETYP_Code)
        {
            try
            {
                MView.CleanControls();
                Item = new VENPY_Entities();
                Item.Instance = InstanceEntity.Insert;
                Item.ENTI_Status = "A";
                Item.ENTI_EntityType = "J";
                Item.ENTI_Domiciled = true;
                Item.ENTI_FunctionsEntities = ItemsFunctionsEntities;
                MView.SetItem();
                MView.FillEntityTypes(p_ETYP_Code);
                ((MAIN006MView)MView).ShowDialog();
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
                    Item = BL_VENPY_Entities.BLENTIS_AEntity(ItemGridView.BUSI_Code, ItemGridView.ENTI_Code);
                    if (Item != null)
                    {
                        Item.Instance = InstanceEntity.Update;
                        MView.SetItem();
                        MView.FillEntityTypes(0);
                        ((MAIN006MView)MView).ShowDialog();
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
                    if (Messages.ShowQuestionMessage(Title, "¿Esta seguro que desea eliminar la Entidad seleccionada?", Messages.TLabelButtons.lbt_Yes_No) == DialogResult.Yes)
                    {
                        string l_message = BL_VENPY_Entities.BLENTID_AEntity(ref pv_itemgridview);
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
                    string l_message = BL_VENPY_Entities.BLENTI_Save(ref pv_item);
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
                    Messages.ShowInformationMessage(Title, "Falta ingresar datos obligatorios", Item.ENTI_ErrorMessage);
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
                ItemsFunctionsEntities = new ObservableCollection<VENPY_FunctionsEntities>();
                ItemsFunctionsEntities = BL_VENPY_FunctionsEntities.BLFENTS_ByEntity(SessionVariables.BusinessCode, null);
                if (ItemsFunctionsEntities == null || ItemsFunctionsEntities.Count == 0)
                { Messages.ShowWarningMessage(Title, "No se ha encontrado ningun Tipo de Entidad, puede que esto ocasione errores."); }

                ItemsUbigeos = TemporaryFiles.DeserializeUbigeos();
                if (ItemsUbigeos == null || ItemsUbigeos.Count == 0)
                { Messages.ShowWarningMessage(Title, "No se ha encontrado ningun Ubigeo, puede que esto ocasione errores."); }

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
