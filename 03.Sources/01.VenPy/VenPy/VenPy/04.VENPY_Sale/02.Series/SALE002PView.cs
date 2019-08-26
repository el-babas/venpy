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
    public class SALE002PView
    {
        #region [ VARIABLES ]

        private ObservableCollection<VENPY_Tables> pv_itemstables;
        private ObservableCollection<VENPY_Series> pv_items;
        private ObservableCollection<VENPY_Series> pv_itemsdelete;

        #endregion

        #region [ PROPERTIES ]

        public String Title = "Series";
        public String NameForm = "SALE002";
        public ISALE002LView LView { get; set; }
        public IBLVENPY_Series BL_VENPY_Series { get; set; }
        public ObservableCollection<VENPY_Tables> ItemsTables
        {
            get { return pv_itemstables; }
            set { pv_itemstables = value; }
        }
        public ObservableCollection<VENPY_Series> Items
        {
            get { return pv_items; }
            set { pv_items = value; }
        }
        public ObservableCollection<VENPY_Series> ItemsDelete
        {
            get { return pv_itemsdelete; }
            set { pv_itemsdelete = value; }
        }

        #endregion

        #region [ CONSTRUCTORS ]

        public SALE002PView(ISALE002LView p_lview)
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
                BL_VENPY_Series = new BLVENPY_Series();
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
        public void Search(String p_TBLE_TableTDO, String p_TBLE_CodeTDO)
        {
            try
            {
                Items = new ObservableCollection<VENPY_Series>();
                Items = BL_VENPY_Series.BLSERIS_ListSeries(SessionVariables.BusinessCode, p_TBLE_TableTDO, p_TBLE_CodeTDO);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public bool Save()
        {
            try
            {
                LView.GetItem();
                if (Items != null && Items.Count > 0)
                {
                    string l_message = null;
                    int l_index = 1;
                    bool l_reviewdetail = true;
                    foreach (var l_item in Items)
                    {
                        if (!l_item.Check())
                        {
                            l_reviewdetail = false;
                            l_message += "Item " + l_index.ToString() + ":" + Environment.NewLine + l_item.SERI_ErrorMessage;
                        }
                        l_index++;
                    }
                    if (l_reviewdetail)
                    {
                        foreach (var l_itemduplicates in Items)
                        {
                            var l_series = Items.Where(Table => Table.BUSI_Code == l_itemduplicates.BUSI_Code && Table.TBLE_TableTDO == l_itemduplicates.TBLE_TableTDO && Table.TBLE_CodeTDO == l_itemduplicates.TBLE_CodeTDO && Table.SERI_Serie.ToUpper() == l_itemduplicates.SERI_Serie.ToUpper()).ToObservableCollection();
                            if (l_series != null && l_series.Count() > 1)
                            {
                                l_message += "* Existen Tipos de Documentos y Series duplicadas en los Items" + Environment.NewLine;
                                break;
                            }
                        }

                    }

                    if (string.IsNullOrEmpty(l_message))
                    {
                        l_message = BL_VENPY_Series.BLSERI_Save(ref pv_items, SessionVariables.UserName);
                        if (string.IsNullOrEmpty(l_message))
                        {
                            if (Delete())
                            {
                                Messages.ShowSatisfactoryMessage(Title, "Se ha guardadó satisfactoriamente");
                                return true;
                            }
                            else
                            { return false; }
                        }
                        else
                        {
                            Messages.ShowWarningMessage(Title, l_message);
                            return false;
                        }
                    }
                    else
                    {
                        Messages.ShowInformationMessage(Title, "Se han encontrado las siguientes observaciones", l_message);
                        return false;
                    }
                }
                else
                {
                    Messages.ShowInformationMessage(Title, "Debe ingresar al menos un Item");
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
                if (ItemsDelete != null && ItemsDelete.Count > 0)
                {

                    string l_message = BL_VENPY_Series.BLSERID_ASerie(ref pv_itemsdelete);
                    if (string.IsNullOrEmpty(l_message))
                    { return true; }
                    else
                    {
                        Messages.ShowWarningMessage(Title, "Eliminar: " + Environment.NewLine + l_message);
                        return false;
                    }
                }
                else
                { return true; }
            }
            catch (Exception ex)
            {
                Messages.ShowErrorMessage(Title, "Ha ocurrido un error al Eliminar.", ex);
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
