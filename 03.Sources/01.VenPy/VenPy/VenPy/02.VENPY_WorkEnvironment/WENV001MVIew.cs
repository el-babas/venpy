using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VenPy.Controls;
using VenPy.Entities;
using VenPy.Class;

namespace VenPy.Main
{
    public partial class WENV001MVIew : Form
    {
        #region [ PROPERTIES ]

        public WENV001PVIew Presenter { get; set; }

        #endregion

        #region [ FORM ]

        public WENV001MVIew()
        {
            InitializeComponent();
            btnAccept.Click += new EventHandler(BtnAccept_Click);
            btnCancel.Click += new EventHandler(BtnCancel_Click);
            cmbBusiness.SelectedIndexChanged += new EventHandler(CmbBusiness_SelectedIndexChanged);
            cmbBranchOffices.SelectedIndexChanged += new EventHandler(CmbBranchOffices_SelectedIndexChanged);
        }
        private void WENV001MVIew_Load(object sender, EventArgs e)
        {
            Presenter.LoadBusiness();
            Presenter.LoadBranchOffices();
            Presenter.LoadPointsSale();
            FillBusiness();
        }

        #endregion 

        #region [ METHODS ]

        private void FillBusiness()
        {
            try
            {
                ObservableCollection<VENPY_Business> l_items_VENPY_Business = new ObservableCollection<VENPY_Business>();
                l_items_VENPY_Business = Presenter.Items_VENPY_Business;
                l_items_VENPY_Business.Insert(0, new VENPY_Business { BUSI_Code = 0, BUSI_BusinessName = "< Seleccionar Empresa >" });
                cmbBusiness.ValueMember = "BUSI_Code";
                cmbBusiness.DisplayMember = "BUSI_BusinessName";
                cmbBusiness.DataSource = l_items_VENPY_Business;
                cmbBusiness.SelectedIndex = l_items_VENPY_Business.Count > 1 ? 1 : 0;
            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(Presenter.Title, "Ha ocurrido un error al cargar los combos", ex); }
        }
        private void FillBranchOffices(Int32 p_BUSI_Code)
        {
            try
            {
                ObservableCollection<VENPY_BranchOffices> l_items_VENPY_BranchOffices = new ObservableCollection<VENPY_BranchOffices>();
                l_items_VENPY_BranchOffices = Presenter.Items_VENPY_BranchOffices.Where(s => s.BUSI_Code == p_BUSI_Code).ToObservableCollection();
                l_items_VENPY_BranchOffices.Insert(0, new VENPY_BranchOffices { BOFF_Code = 0, BOFF_Name = "< Seleccionar Sucursal >" });
                cmbBranchOffices.ValueMember = "BOFF_Code";
                cmbBranchOffices.DisplayMember = "BOFF_Name";
                cmbBranchOffices.DataSource = l_items_VENPY_BranchOffices;
                cmbBranchOffices.SelectedIndex = l_items_VENPY_BranchOffices.Count > 1 ? 1 : 0;
            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(Presenter.Title, "Ha ocurrido un error al cargar los combos", ex); }
        }
        private void FillPointsSale(Int32 p_BUSI_Code, Int32 p_BOFF_Code)
        {
            try
            {
                ObservableCollection<VENPY_PointsSale> l_items_VENPY_PointsSale = new ObservableCollection<VENPY_PointsSale>();
                l_items_VENPY_PointsSale = Presenter.Items_VENPY_PointsSale.Where(p => p.BUSI_Code == p_BUSI_Code && p.BOFF_Code == p_BOFF_Code).ToObservableCollection();
                l_items_VENPY_PointsSale.Insert(0, new VENPY_PointsSale { PSAL_Code = 0, PSAL_Name = "< Seleccionar Punto Venta >" });
                cmbPointsSale.ValueMember = "PSAL_Code";
                cmbPointsSale.DisplayMember = "PSAL_Name";
                cmbPointsSale.DataSource = l_items_VENPY_PointsSale;
                cmbPointsSale.SelectedIndex = l_items_VENPY_PointsSale.Count > 1 ? 1 : 0;
            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(Presenter.Title, "Ha ocurrido un error al cargar los combos", ex); }
        }

        #endregion

        #region [ EVENTS ]

        private void CmbBusiness_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                FillBranchOffices(Convert.ToInt32(cmbBusiness.SelectedValue.ToString()));
            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(Presenter.Title, "Ha ocurrido un error al cambiar de empresa", ex); }
        }
        private void CmbBranchOffices_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                FillPointsSale(Convert.ToInt32(cmbBusiness.SelectedValue.ToString()), Convert.ToInt32(cmbBranchOffices.SelectedValue.ToString()));
            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(Presenter.Title, "Ha ocurrido un error al cambiar de sucursal", ex); }
        }
        private void BtnAccept_Click(object sender, EventArgs e)
        {
            try
            {
                if (!cmbBusiness.SelectedValue.ToString().Equals("0"))
                {
                    if (!cmbBranchOffices.SelectedValue.ToString().Equals("0"))
                    {
                        if (!cmbPointsSale.SelectedValue.ToString().Equals("0"))
                        {
                            SessionVariables.BusinessCode = (cmbBusiness.SelectedItem as VENPY_Business).BUSI_Code;
                            SessionVariables.BusinessRuc = (cmbBusiness.SelectedItem as VENPY_Business).BUSI_RUC;
                            SessionVariables.BusinessName = (cmbBusiness.SelectedItem as VENPY_Business).BUSI_BusinessName;
                            SessionVariables.BranchCode = (cmbBranchOffices.SelectedItem as VENPY_BranchOffices).BOFF_Code;
                            SessionVariables.BranchName = (cmbBranchOffices.SelectedItem as VENPY_BranchOffices).BOFF_Name;
                            SessionVariables.PointSaleCode = (cmbPointsSale.SelectedItem as VENPY_PointsSale).PSAL_Code;
                            SessionVariables.PointSaleName = (cmbPointsSale.SelectedItem as VENPY_PointsSale).PSAL_Name;
                            SessionVariables.Version = Application.ProductVersion;
                            DialogResult = DialogResult.OK;
                        }
                        else
                        { Messages.ShowInformationMessage(Presenter.Title, "Debe Seleccionar una punto de venta"); }
                    }
                    else
                    { Messages.ShowInformationMessage(Presenter.Title, "Debe Seleccionar una sucursal"); }
                }
                else
                { Messages.ShowInformationMessage(Presenter.Title, "Debe Seleccionar una empresa"); }

            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(Presenter.Title, "Ha ocurrido un error al aceptar", ex); }
        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
                DialogResult = DialogResult.Cancel;
            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(Presenter.Title, "Ha ocurrido un error al cancelar", ex); }
        }

        #endregion
    }
}
