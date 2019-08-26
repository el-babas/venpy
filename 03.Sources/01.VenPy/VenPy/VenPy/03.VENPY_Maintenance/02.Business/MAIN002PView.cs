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
    public class MAIN002PView
    {
        #region [ VARIABLES ]

        private ObservableCollection<VENPY_Business> pv_items;
        private ObservableCollection<VENPY_Ubigeos> pv_itemsubigeos;
        private VENPY_Business pv_item;
        private VENPY_Business pv_itemgridview;

        #endregion

        #region [ PROPERTIES ]

        public String Title = "Empresas";
        public String NameForm = "MAIN002";
        public IMAIN002LView LView { get; set; }
        public IMAIN002MView MView { get; set; }
        public IBLVENPY_Business BL_VENPY_Business { get; set; }
        public ObservableCollection<VENPY_Business> Items
        {
            get { return pv_items; }
            set { pv_items = value; }
        }
        public ObservableCollection<VENPY_Ubigeos> ItemsUbigeos
        {
            get { return pv_itemsubigeos; }
            set { pv_itemsubigeos = value; }
        }
        public VENPY_Business Item
        {
            get { return pv_item; }
            set { pv_item = value; }
        }
        public VENPY_Business ItemGridView
        {
            get { return pv_itemgridview; }
            set { pv_itemgridview = value; }
        }

        #endregion

        #region [ CONSTRUCTORS ]

        public MAIN002PView(IMAIN002LView p_lview, IMAIN002MView p_mview)
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
                BL_VENPY_Business = new BLVENPY_Business();
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
        public void Search(String p_BUSI_RUC, String p_BUSI_BusinessName)
        {
            try
            {
                BL_VENPY_Business = new BLVENPY_Business();
                Items = new ObservableCollection<VENPY_Business>();
                Items = BL_VENPY_Business.BLBUSIS_ListCompanies(SessionVariables.UserCode, p_BUSI_RUC, p_BUSI_BusinessName);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public void New()
        {
            try
            {
                MView.CleanControls();
                Item = new VENPY_Business();
                Item.Instance = InstanceEntity.Insert;
                ((MAIN002MView)MView).ShowDialog();
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
                    Item = BL_VENPY_Business.BLBUSIS_ACompany(ItemGridView.BUSI_Code);
                    if (Item != null)
                    {
                        Item.Instance = InstanceEntity.Update;
                        MView.SetItem();
                        ((MAIN002MView)MView).ShowDialog();
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
                    string l_message = BL_VENPY_Business.BLBUSI_Save(ref pv_item);
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
                    Messages.ShowInformationMessage(Title, "Falta ingresar datos obligatorios", Item.BUSI_ErrorMessage);
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
