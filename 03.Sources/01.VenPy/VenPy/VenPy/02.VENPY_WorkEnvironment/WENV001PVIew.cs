using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using VenPy.Class;
using VenPy.Entities;
using VenPy.Connection;
using VenPy.Controls;

namespace VenPy.Main
{
    public class WENV001PVIew
    {
        #region [ VARIABLES ]

        private String pv_Title = "Entorno de Trabajo";
        private ObservableCollection<VENPY_Business> pv_items_VENPY_Business;
        private ObservableCollection<VENPY_BranchOffices> pv_items_VENPY_BranchOffices;
        private ObservableCollection<VENPY_PointsSale> pv_items_VENPY_PointsSale;

        #endregion

        #region [ PROPERTIES ]

        public String Title
        {
            get { return pv_Title; }
            set { pv_Title = value; }
        }
        public ObservableCollection<VENPY_Business> Items_VENPY_Business
        {
            get { return pv_items_VENPY_Business; }
            set { pv_items_VENPY_Business = value; }
        }
        public ObservableCollection<VENPY_BranchOffices> Items_VENPY_BranchOffices
        {
            get { return pv_items_VENPY_BranchOffices; }
            set { pv_items_VENPY_BranchOffices = value; }
        }
        public ObservableCollection<VENPY_PointsSale> Items_VENPY_PointsSale
        {
            get { return pv_items_VENPY_PointsSale; }
            set { pv_items_VENPY_PointsSale = value; }
        }

        #endregion

        #region [ CONSTRUCTORS ]

        public WENV001PVIew()
        { }

        #endregion

        #region [ METHODS ]

        public void LoadBusiness()
        {
            try
            {
                IBLVENPY_Business BL_VENPY_Business = new BLVENPY_Business();
                Items_VENPY_Business = new ObservableCollection<VENPY_Business>();
                Items_VENPY_Business = BL_VENPY_Business.BLBUSIS_ByUser(SessionVariables.UserCode);
            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(Title, "Ha ocurrido un error al cargar las empresas", ex); }
        }
        public void LoadBranchOffices()
        {
            try
            {
                IBLVENPY_BranchOffices BL_VENPY_BranchOffices = new BLVENPY_BranchOffices();
                Items_VENPY_BranchOffices = new ObservableCollection<VENPY_BranchOffices>();
                if (Items_VENPY_Business != null && Items_VENPY_Business.Count() > 0)
                { Items_VENPY_BranchOffices = BL_VENPY_BranchOffices.BLBOFFS_ByUser(SessionVariables.UserCode, null); }
                else
                { Messages.ShowWarningMessage(Title, "El usuario no tiene asignado ninguna empresa"); }
            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(Title, "Ha ocurrido un error al cargar las sucursales", ex); }
        }
        public void LoadPointsSale()
        {
            try
            {
                IBLVENPY_PointsSale BL_VENPY_PointsSale = new BLVENPY_PointsSale();
                Items_VENPY_PointsSale = new ObservableCollection<VENPY_PointsSale>();
                if (Items_VENPY_BranchOffices != null && Items_VENPY_BranchOffices.Count() > 0)
                { Items_VENPY_PointsSale = BL_VENPY_PointsSale.BLPSALS_ByUser(SessionVariables.UserCode, null); }
                else
                { Messages.ShowWarningMessage(Title, "El usuario no tiene asignado ninguna sucursal"); }
            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(Title, "Ha ocurrido un error al cargar los puntos de venta", ex); }
        }

        #endregion
    }
}
