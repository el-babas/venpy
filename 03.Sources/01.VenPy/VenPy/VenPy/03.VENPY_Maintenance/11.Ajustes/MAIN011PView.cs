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
    public class MAIN011PView
    {
        #region [ VARIABLES ]

        private ObservableCollection<VENPY_Settings> pv_items;

        #endregion

        #region [ PROPERTIES ]

        public String Title = "Ajustes Generales";
        public String NameForm = "MAIN011";
        public IMAIN011MView MView { get; set; }
        public IBLVENPY_Settings BL_VENPY_Settings { get; set; }
        public ObservableCollection<VENPY_Settings> Items
        {
            get { return pv_items; }
            set { pv_items = value; }
        }

        #endregion

        #region [ CONSTRUCTORS ]

        public MAIN011PView(IMAIN011MView p_mview)
        {
            try
            {
                MView = p_mview;
            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(Title, "Ha ocurrido un error al inicializar el formulario.", ex); }
        }

        #endregion

        #region [ SETTINGS ]

        public VENPY_Settings SALI
        {
            get
            {
                string l_SETT_Key = StaticLists.SETT_Refresh;
                string l_SETT_Description = "ACTUALIZAR LISTAS TEMPORALES AL INICIAR";
                if (Items.Where(param => param.SETT_Key == l_SETT_Key).FirstOrDefault() == null)
                {
                    VENPY_Settings l_item = new VENPY_Settings();
                    l_item.BUSI_Code = SessionVariables.BusinessCode;
                    l_item.SETT_Key = l_SETT_Key;
                    l_item.SETT_Description = l_SETT_Description;
                    l_item.Instance = InstanceEntity.Insert;
                    l_item.AUDI_CreationUser = SessionVariables.UserName;
                    l_item.AUDI_ModificationUser = SessionVariables.UserName;
                    Items.Add(l_item);
                }
                return Items.Where(param => param.SETT_Key == l_SETT_Key).FirstOrDefault();
            }
        }
        public VENPY_Settings STCO
        {
            get
            {
                string l_SETT_Key = StaticLists.SETT_TcOfficial;
                string l_SETT_Description = "TIPO DE CAMBIO OFICIAL";
                if (Items.Where(param => param.SETT_Key == l_SETT_Key).FirstOrDefault() == null)
                {
                    VENPY_Settings l_item = new VENPY_Settings();
                    l_item.BUSI_Code = SessionVariables.BusinessCode;
                    l_item.SETT_Key = l_SETT_Key;
                    l_item.SETT_Description = l_SETT_Description;
                    l_item.Instance = InstanceEntity.Insert;
                    l_item.AUDI_CreationUser = SessionVariables.UserName;
                    l_item.AUDI_ModificationUser = SessionVariables.UserName;
                    Items.Add(l_item);
                }
                return Items.Where(param => param.SETT_Key == l_SETT_Key).FirstOrDefault();
            }
        }
        public VENPY_Settings SEND
        {
            get
            {
                string l_SETT_Key = StaticLists.SETT_Unknown;
                string l_SETT_Description = "USUARIO DESCONOCIDO";
                if (Items.Where(param => param.SETT_Key == l_SETT_Key).FirstOrDefault() == null)
                {
                    VENPY_Settings l_item = new VENPY_Settings();
                    l_item.BUSI_Code = SessionVariables.BusinessCode;
                    l_item.SETT_Key = l_SETT_Key;
                    l_item.SETT_Description = l_SETT_Description;
                    l_item.Instance = InstanceEntity.Insert;
                    l_item.AUDI_CreationUser = SessionVariables.UserName;
                    l_item.AUDI_ModificationUser = SessionVariables.UserName;
                    Items.Add(l_item);
                }
                return Items.Where(param => param.SETT_Key == l_SETT_Key).FirstOrDefault();
            }
        }
        public VENPY_Settings SIGV
        {
            get
            {
                string l_SETT_Key = StaticLists.SETT_Igv;
                string l_SETT_Description = "PORCETAJE DEL IGV";
                if (Items.Where(param => param.SETT_Key == l_SETT_Key).FirstOrDefault() == null)
                {
                    VENPY_Settings l_item = new VENPY_Settings();
                    l_item.BUSI_Code = SessionVariables.BusinessCode;
                    l_item.SETT_Key = l_SETT_Key;
                    l_item.SETT_Description = l_SETT_Description;
                    l_item.Instance = InstanceEntity.Insert;
                    l_item.AUDI_CreationUser = SessionVariables.UserName;
                    l_item.AUDI_ModificationUser = SessionVariables.UserName;
                    Items.Add(l_item);
                }
                return Items.Where(param => param.SETT_Key == l_SETT_Key).FirstOrDefault();
            }
        }

        #endregion

        #region [ METHODS ]

        public void Load()
        {
            try
            {
                BL_VENPY_Settings = new BLVENPY_Settings();
                MView.MViewLoad();
            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(Title, "Ha ocurrido un error inicializando la vista.", ex); }
        }
        public void Edit()
        {
            try
            {
                MView.CleanControls();
                Items = BL_VENPY_Settings.BLSETTS_ByBusiness(SessionVariables.BusinessCode);
                MView.SetItem();
                ((MAIN011MView)MView).ShowDialog();
            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(Title, "Ocurrio un error al editar", ex); }
        }
        public bool Save()
        {
            try
            {
                MView.GetItem();
                string l_message = BL_VENPY_Settings.BLSETT_Save(ref pv_items, SessionVariables.UserName);
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
            catch (Exception ex)
            {
                Messages.ShowErrorMessage(Title, "Ha ocurrido un error al Guardar.", ex);
                return false;
            }
        }

        #endregion
    }
}
