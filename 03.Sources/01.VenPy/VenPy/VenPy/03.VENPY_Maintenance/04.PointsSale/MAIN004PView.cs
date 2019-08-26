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
    public class MAIN004PView
    {
        #region [ VARIABLES ]

        private ObservableCollection<VENPY_PointsSale> pv_items;
        private VENPY_PointsSale pv_item;
        private VENPY_PointsSale pv_itemgridview;

        #endregion

        #region [ PROPERTIES ]

        public String Title = "Puntos de Ventas";
        public String NameForm = "MAIN004";
        public IMAIN004LView LView { get; set; }
        public IMAIN004MView MView { get; set; }
        public IBLVENPY_PointsSale BL_VENPY_PointsSale { get; set; }
        public ObservableCollection<VENPY_PointsSale> Items
        {
            get { return pv_items; }
            set { pv_items = value; }
        }
        public VENPY_PointsSale Item
        {
            get { return pv_item; }
            set { pv_item = value; }
        }
        public VENPY_PointsSale ItemGridView
        {
            get { return pv_itemgridview; }
            set { pv_itemgridview = value; }
        }

        #endregion

        #region [ CONSTRUCTORS ]

        public MAIN004PView(IMAIN004LView p_lview, IMAIN004MView p_mview)
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
                BL_VENPY_PointsSale = new BLVENPY_PointsSale();
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
        public void Search(String p_PSAL_Name)
        {
            try
            {
                Items = new ObservableCollection<VENPY_PointsSale>();
                Items = BL_VENPY_PointsSale.BLPSALS_ListPointsSale(SessionVariables.BusinessCode, SessionVariables.UserCode, p_PSAL_Name);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public void New()
        {
            try
            {
                MView.CleanControls();
                Item = new VENPY_PointsSale();
                Item.Instance = InstanceEntity.Insert;
                ((MAIN004MView)MView).ShowDialog();
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
                    Item = BL_VENPY_PointsSale.BLPSALS_APointSale(ItemGridView.BUSI_Code, ItemGridView.BOFF_Code, ItemGridView.PSAL_Code);
                    if (Item != null)
                    {
                        Item.Instance = InstanceEntity.Update;
                        MView.SetItem();
                        ((MAIN004MView)MView).ShowDialog();
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
                    string l_message = BL_VENPY_PointsSale.BLPSAL_Save(ref pv_item);
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
                    Messages.ShowInformationMessage(Title, "Falta ingresar datos obligatorios", Item.PSAL_ErrorMessage);
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
