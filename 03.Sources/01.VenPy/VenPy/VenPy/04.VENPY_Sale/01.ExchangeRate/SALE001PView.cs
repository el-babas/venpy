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
    public class SALE001PView
    {
        #region [ VARIABLES ]

        private VENPY_ExchangeRate pv_item;
        private ObservableCollection<VENPY_ExchangeRate> pv_items;

        #endregion

        #region [ PROPERTIES ]

        public String Title = "Tipo de Cambio";
        public String NameForm = "SALE001";
        public ISALE001LView LView { get; set; }
        public IBLVENPY_ExchangeRate BL_VENPY_ExchangeRate { get; set; }
        public VENPY_ExchangeRate Item
        {
            get { return pv_item; }
            set { pv_item = value; }
        }
        public ObservableCollection<VENPY_ExchangeRate> Items
        {
            get { return pv_items; }
            set { pv_items = value; }
        }

        #endregion

        #region [ CONSTRUCTORS ]

        public SALE001PView(ISALE001LView p_lview)
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
                BL_VENPY_ExchangeRate = new BLVENPY_ExchangeRate();
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
        public void Search(String p_EXRA_Year, String p_EXRA_Month)
        {
            try
            {
                int l_year = Convert.ToInt32(p_EXRA_Year);
                int l_month = Convert.ToInt32(p_EXRA_Month);
                Items = new ObservableCollection<VENPY_ExchangeRate>();
                Items = BL_VENPY_ExchangeRate.BLEXRAS_ListExchangeRate(SessionVariables.BusinessCode, p_EXRA_Year, p_EXRA_Month);
                DateTime l_date = new DateTime(l_year, l_month, 1);
                for (int i = 1; i <= DateTime.DaysInMonth(l_date.Year, l_date.Month); i++)
                {
                    int l_day = i;
                    var l_item = Items.Where(query => query.EXRA_Date.Day == l_day).FirstOrDefault();
                    if (l_item != null)
                    {
                        int _index = Items.IndexOf(l_item);
                        l_item.BUSI_Code = SessionVariables.BusinessCode;
                        l_item.AUDI_CreationUser = SessionVariables.UserName;
                        l_item.AUDI_ModificationUser = SessionVariables.UserName;
                        l_item.EXRA_Date = new DateTime(l_year, l_month, l_day);
                        l_item.Instance = InstanceEntity.Update;
                        Items[_index] = l_item;
                    }
                    else
                    {
                        VENPY_ExchangeRate l_ExchangeRate = new VENPY_ExchangeRate();
                        l_ExchangeRate.BUSI_Code = SessionVariables.BusinessCode;
                        l_ExchangeRate.AUDI_CreationUser = SessionVariables.UserName;
                        l_ExchangeRate.AUDI_ModificationUser = SessionVariables.UserName;
                        l_ExchangeRate.EXRA_Date = new DateTime(l_year, l_month, l_day);
                        l_ExchangeRate.Instance = InstanceEntity.Insert;
                        Items.Add(l_ExchangeRate);
                    }
                }
                Items = Items.OrderBy(order => order.EXRA_Date).ToObservableCollection();
            }
            catch (Exception ex)
            { throw ex; }
        }
        public bool Save()
        {
            try
            {
                if (Item != null)
                {
                    if (Item.Check())
                    {
                        string l_message = BL_VENPY_ExchangeRate.BLEXRA_Save(ref pv_item);
                        if (string.IsNullOrEmpty(l_message))
                        { return true; }
                        else
                        {
                            Messages.ShowWarningMessage(Title, l_message);
                            return false;
                        }
                    }
                    else
                    {
                        Messages.ShowInformationMessage(Title, "Falta ingresar datos obligatorios", Item.EXRA_ErrorMessage);
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
                Messages.ShowErrorMessage(Title, "Ha ocurrido un error al Guardar.", ex);
                return false;
            }
        }

        #endregion
    }
}
