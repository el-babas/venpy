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
using VenPy.Connection;
using VenPy.Entities;
using VenPy.Class;

namespace VenPy.Main
{
    public partial class MAIN002MView : Form, IMAIN002MView
    {
        #region [ PROPERTIES ]

        public MAIN002PView Presenter { get; set; }

        #endregion

        #region [ FORM ]

        public MAIN002MView()
        {
            InitializeComponent();
            /*Handle the line break through events in TextBox*/
            txtBUSI_SocialNetworks.KeyUp += new KeyEventHandler(TxtBUSI_SocialNetworks_KeyUp);
            txtBUSI_SocialNetworks.GotFocus += new EventHandler(TxtBUSI_SocialNetworks_GotFocus);
            txtBUSI_SocialNetworks.LostFocus += new EventHandler(TxtBUSI_SocialNetworks_LostFocus);

            cmbBUSI_CodeDepartamento.SelectedIndexChanged += new EventHandler(CmbBUSI_CodeDepartamento_SelectedIndexChanged);
            cmbBUSI_CodeProvincia.SelectedIndexChanged += new EventHandler(CmbBUSI_CodeProvincia_SelectedIndexChanged);
            btnSave.Click += new EventHandler(BtnSave_Click);

            cmbBUSI_CodeProvincia.Enabled = false;
            cmbBUSI_CodeDistrito.Enabled = false;
        }
        public void MViewLoad()
        {
            try
            {
                LoadControls();
                CleanControls();
            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(Presenter.Title, "Ha ocurrido un error cargando la vista.", ex); }
        }

        #endregion

        #region [ METHODS ]

        public void LoadControls()
        {
            try
            {
                if (Presenter.ItemsUbigeos != null && Presenter.ItemsUbigeos.Count > 0)
                {
                    ObservableCollection<VENPY_Ubigeos> l_ItemsDepartamentos = new ObservableCollection<VENPY_Ubigeos>();
                    l_ItemsDepartamentos = Presenter.ItemsUbigeos.Where(Ubigeo => Ubigeo.UBIG_ParentCode == null).ToObservableCollection();
                    cmbBUSI_CodeDepartamento.ValueMember = "UBIG_Code";
                    cmbBUSI_CodeDepartamento.DisplayMember = "UBIG_Description";
                    cmbBUSI_CodeDepartamento.DataSource = l_ItemsDepartamentos;
                }
            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(Presenter.Title, "Ha ocurrido un error al llenar los controles.", ex); }
        }
        public void CleanControls()
        {
            try
            {
                txtBUSI_Code.Text = string.Empty;
                txtBUSI_RUC.Text = string.Empty;
                txtBUSI_BusinessName.Text = string.Empty;
                txtBUSI_TradeName.Text = string.Empty;
                txtBUSI_Address1.Text = string.Empty;
                txtBUSI_Address2.Text = string.Empty;
                txtBUSI_Urbanization.Text = string.Empty;
                txtBUSI_Email.Text = string.Empty;
                txtBUSI_Web.Text = string.Empty;
                txtBUSI_SocialNetworks.Text = string.Empty;
                txtBUSI_PhoneNumber1.Text = string.Empty;
                txtBUSI_PhoneNumber2.Text = string.Empty;
                txtBUSI_BankAccount.Text = string.Empty;
                cmbBUSI_CodeDepartamento.SelectedIndex = 0;
                cmbBUSI_CodeProvincia.SelectedIndex = 0;
                cmbBUSI_CodeDistrito.SelectedIndex = 0;
                tabGeneral.SelectedTab = tabPage1;
            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(Presenter.Title, "Ha ocurrido un error al limpiar el formulario.", ex); }
        }
        public void SetItem()
        {
            try
            {
                txtBUSI_Code.Text = Presenter.Item.BUSI_Code.ToString();
                txtBUSI_RUC.Text = Presenter.Item.BUSI_RUC;
                txtBUSI_BusinessName.Text = Presenter.Item.BUSI_BusinessName;
                txtBUSI_TradeName.Text = Presenter.Item.BUSI_TradeName;
                txtBUSI_Address1.Text = Presenter.Item.BUSI_Address1;
                txtBUSI_Address2.Text = Presenter.Item.BUSI_Address2;
                txtBUSI_Urbanization.Text = Presenter.Item.BUSI_Urbanization;
                txtBUSI_Email.Text = Presenter.Item.BUSI_Email;
                txtBUSI_Web.Text = Presenter.Item.BUSI_Web;
                txtBUSI_SocialNetworks.Text = Presenter.Item.BUSI_SocialNetworks;
                txtBUSI_PhoneNumber1.Text = Presenter.Item.BUSI_PhoneNumber1;
                txtBUSI_PhoneNumber2.Text = Presenter.Item.BUSI_PhoneNumber2;
                txtBUSI_BankAccount.Text = Presenter.Item.BUSI_BankAccount;
                cmbBUSI_CodeDepartamento.SelectedValue = Presenter.Item.BUSI_CodeDepartamento;
                cmbBUSI_CodeProvincia.SelectedValue = Presenter.Item.BUSI_CodeProvincia;
                CmbBUSI_CodeProvincia_SelectedIndexChanged(null, null);
                cmbBUSI_CodeDistrito.SelectedValue = Presenter.Item.BUSI_CodeDistrito;
            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(Presenter.Title, "Ha ocurrido un error al cargar el Item.", ex); }
        }
        public void GetItem()
        {
            try
            {
                Presenter.Item.BUSI_RUC = txtBUSI_RUC.Text;
                Presenter.Item.BUSI_BusinessName = txtBUSI_BusinessName.Text;
                Presenter.Item.BUSI_TradeName = txtBUSI_TradeName.Text;
                Presenter.Item.BUSI_Address1 = txtBUSI_Address1.Text;
                Presenter.Item.BUSI_Address2 = txtBUSI_Address2.Text;
                Presenter.Item.BUSI_Urbanization = txtBUSI_Urbanization.Text;
                Presenter.Item.BUSI_Email = txtBUSI_Email.Text;
                Presenter.Item.BUSI_Web = txtBUSI_Web.Text;
                Presenter.Item.BUSI_SocialNetworks = txtBUSI_SocialNetworks.Text;
                Presenter.Item.BUSI_PhoneNumber1 = txtBUSI_PhoneNumber1.Text;
                Presenter.Item.BUSI_PhoneNumber2 = txtBUSI_PhoneNumber2.Text;
                Presenter.Item.BUSI_BankAccount = txtBUSI_BankAccount.Text;
                Presenter.Item.BUSI_CodeDepartamento = cmbBUSI_CodeDepartamento.SelectedValue.ToString();
                Presenter.Item.BUSI_CodeProvincia = cmbBUSI_CodeProvincia.SelectedValue.ToString();
                Presenter.Item.BUSI_CodeDistrito = cmbBUSI_CodeDistrito.SelectedValue.ToString();
                Presenter.Item.UBIG_Code = cmbBUSI_CodeDistrito.SelectedValue.ToString();
                Presenter.Item.AUDI_CreationUser = SessionVariables.UserName;
                Presenter.Item.AUDI_ModificationUser = SessionVariables.UserName;
            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(Presenter.Title, "Ha ocurrido un error al obtener el Item.", ex); }
        }

        #endregion

        #region [ EVENTS ]

        private void CmbBUSI_CodeDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbBUSI_CodeDepartamento.SelectedValue != null)
                {
                    ObservableCollection<VENPY_Ubigeos> l_ItemsProvincias = new ObservableCollection<VENPY_Ubigeos>();
                    l_ItemsProvincias = Presenter.ItemsUbigeos.Where(Ubigeo => Ubigeo.UBIG_ParentCode == cmbBUSI_CodeDepartamento.SelectedValue.ToString()).ToObservableCollection();
                    cmbBUSI_CodeProvincia.ValueMember = "UBIG_Code";
                    cmbBUSI_CodeProvincia.DisplayMember = "UBIG_Description";
                    cmbBUSI_CodeProvincia.DataSource = l_ItemsProvincias;
                    cmbBUSI_CodeProvincia.Enabled = true;
                }
                else
                { cmbBUSI_CodeProvincia.Enabled = false; }
            }
            catch (Exception ex)
            { throw ex; }
        }
        private void CmbBUSI_CodeProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbBUSI_CodeProvincia.SelectedValue != null)
                {
                    ObservableCollection<VENPY_Ubigeos> l_ItemsDistritos = new ObservableCollection<VENPY_Ubigeos>();
                    l_ItemsDistritos = Presenter.ItemsUbigeos.Where(Ubigeo => Ubigeo.UBIG_ParentCode == cmbBUSI_CodeProvincia.SelectedValue.ToString()).ToObservableCollection();
                    cmbBUSI_CodeDistrito.ValueMember = "UBIG_Code";
                    cmbBUSI_CodeDistrito.DisplayMember = "UBIG_Description";
                    cmbBUSI_CodeDistrito.DataSource = l_ItemsDistritos;
                    cmbBUSI_CodeDistrito.Enabled = true;
                }
                else
                { cmbBUSI_CodeDistrito.Enabled = false; }
            }
            catch (Exception ex)
            { throw ex; }
        }
        private void TxtBUSI_SocialNetworks_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtBUSI_SocialNetworks.Text = txtBUSI_SocialNetworks.Text + Environment.NewLine;
                    txtBUSI_SocialNetworks.Select(txtBUSI_SocialNetworks.Text.Length, 0);
                }
            }
            catch (Exception ex)
            { throw ex; }
        }
        private void TxtBUSI_SocialNetworks_GotFocus(object sender, EventArgs e)
        {
            try
            {
                btnSave.Click -= BtnSave_Click;
            }
            catch (Exception ex)
            { throw ex; }
        }
        private void TxtBUSI_SocialNetworks_LostFocus(object sender, EventArgs e)
        {
            try
            {
                btnSave.Click += BtnSave_Click;
            }
            catch (Exception ex)
            { throw ex; }
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                if (Presenter.Save())
                {
                    Presenter.RefreshItems();
                    Close();
                }
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(Presenter.Title, "Ha ocurrido un error al Guardar.", ex); }
        }

        #endregion
    }
}
