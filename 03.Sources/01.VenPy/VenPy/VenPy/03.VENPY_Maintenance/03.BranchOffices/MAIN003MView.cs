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
    public partial class MAIN003MView : Form, IMAIN003MView
    {
        #region [ PROPERTIES ]

        public MAIN003PView Presenter { get; set; }

        #endregion

        #region [ FORM ]

        public MAIN003MView()
        {
            InitializeComponent();
            /*Handle the line break through events in TextBox*/
            txtBOFF_SocialNetworks.KeyUp += new KeyEventHandler(TxtBOFF_SocialNetworks_KeyUp);
            txtBOFF_SocialNetworks.GotFocus += new EventHandler(TxtBOFF_SocialNetworks_GotFocus);
            txtBOFF_SocialNetworks.LostFocus += new EventHandler(TxtBOFF_SocialNetworks_LostFocus);

            cmbBOFF_CodeDepartamento.SelectedIndexChanged += new EventHandler(CmbBOFF_CodeDepartamento_SelectedIndexChanged);
            cmbBOFF_CodeProvincia.SelectedIndexChanged += new EventHandler(CmbBOFF_CodeProvincia_SelectedIndexChanged);
            btnSave.Click += new EventHandler(BtnSave_Click);

            cmbBOFF_CodeProvincia.Enabled = false;
            cmbBOFF_CodeDistrito.Enabled = false;
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
                    cmbBOFF_CodeDepartamento.ValueMember = "UBIG_Code";
                    cmbBOFF_CodeDepartamento.DisplayMember = "UBIG_Description";
                    cmbBOFF_CodeDepartamento.DataSource = l_ItemsDepartamentos;
                }
            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(Presenter.Title, "Ha ocurrido un error al llenar los controles.", ex); }
        }
        public void CleanControls()
        {
            try
            {
                txtBOFF_Code.Text = string.Empty;
                txtBOFF_Name.Text = string.Empty;
                txtBOFF_Address.Text = string.Empty;
                txtBOFF_Description.Text = string.Empty;
                txtBOFF_Email.Text = string.Empty;
                txtBOFF_Web.Text = string.Empty;
                txtBOFF_SocialNetworks.Text = string.Empty;
                txtBOFF_PhoneNumber1.Text = string.Empty;
                txtBOFF_PhoneNumber2.Text = string.Empty;
                cmbBOFF_CodeDepartamento.SelectedIndex = 0;
                cmbBOFF_CodeProvincia.SelectedIndex = 0;
                cmbBOFF_CodeDistrito.SelectedIndex = 0;
                tabGeneral.SelectedTab = tabPage1;
                ltvTBLE_CodeALM.Clear();
            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(Presenter.Title, "Ha ocurrido un error al limpiar el formulario.", ex); }
        }
        public void SetItem()
        {
            try
            {
                txtBOFF_Code.Text = Presenter.Item.BOFF_Code.ToString();
                txtBOFF_Name.Text = Presenter.Item.BOFF_Name;
                txtBOFF_Address.Text = Presenter.Item.BOFF_Address;
                txtBOFF_Description.Text = Presenter.Item.BOFF_Description;
                txtBOFF_Email.Text = Presenter.Item.BOFF_Email;
                txtBOFF_Web.Text = Presenter.Item.BOFF_Web;
                txtBOFF_SocialNetworks.Text = Presenter.Item.BOFF_SocialNetworks;
                txtBOFF_PhoneNumber1.Text = Presenter.Item.BOFF_PhoneNumber1;
                txtBOFF_PhoneNumber2.Text = Presenter.Item.BOFF_PhoneNumber2;
                cmbBOFF_CodeDepartamento.SelectedValue = Presenter.Item.BOFF_CodeDepartamento;
                cmbBOFF_CodeProvincia.SelectedValue = Presenter.Item.BOFF_CodeProvincia;
                CmbBOFF_CodeProvincia_SelectedIndexChanged(null, null);
                cmbBOFF_CodeDistrito.SelectedValue = Presenter.Item.BOFF_CodeDistrito;
            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(Presenter.Title, "Ha ocurrido un error al cargar el Item.", ex); }
        }
        public void GetItem()
        {
            try
            {
                Presenter.Item.BUSI_Code = SessionVariables.BusinessCode;
                Presenter.Item.BOFF_Name = txtBOFF_Name.Text;
                Presenter.Item.BOFF_Address = txtBOFF_Address.Text;
                Presenter.Item.BOFF_Description = txtBOFF_Description.Text;
                Presenter.Item.BOFF_Email = txtBOFF_Email.Text;
                Presenter.Item.BOFF_Web = txtBOFF_Web.Text;
                Presenter.Item.BOFF_SocialNetworks = txtBOFF_SocialNetworks.Text;
                Presenter.Item.BOFF_PhoneNumber1 = txtBOFF_PhoneNumber1.Text;
                Presenter.Item.BOFF_PhoneNumber2 = txtBOFF_PhoneNumber2.Text;
                Presenter.Item.BOFF_CodeDepartamento = cmbBOFF_CodeDepartamento.SelectedValue.ToString();
                Presenter.Item.BOFF_CodeProvincia = cmbBOFF_CodeProvincia.SelectedValue.ToString();
                Presenter.Item.BOFF_CodeDistrito = cmbBOFF_CodeDistrito.SelectedValue.ToString();
                Presenter.Item.UBIG_Code = cmbBOFF_CodeDistrito.SelectedValue.ToString();
                Presenter.Item.AUDI_CreationUser = SessionVariables.UserName;
                Presenter.Item.AUDI_ModificationUser = SessionVariables.UserName;
                GetWarehouses();
            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(Presenter.Title, "Ha ocurrido un error al obtener el Item.", ex); }
        }
        public void FillWarehouses()
        {
            try
            {
                if (Presenter.Item.BOFF_WarehousesBranches != null && Presenter.Item.BOFF_WarehousesBranches.Count() > 0)
                {
                    ltvTBLE_CodeALM.Items.Clear();
                    ltvTBLE_CodeALM.View = View.List;
                    ltvTBLE_CodeALM.CheckBoxes = true;
                    foreach (VENPY_WarehousesBranches WarehouseBranch in Presenter.Item.BOFF_WarehousesBranches)
                    {
                        ListViewItem l_item = null;
                        l_item = new ListViewItem() { Tag = WarehouseBranch, Text = WarehouseBranch.TBLE_NameALM, Checked = WarehouseBranch.WABR_Select };
                        ltvTBLE_CodeALM.Items.Add(l_item);
                    }
                }
            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(Presenter.Title, "Ha ocurrido un error al llenar los Almacenes.", ex); }
        }
        public void GetWarehouses()
        {
            try
            {
                Presenter.Item.BOFF_WarehousesBranches = new ObservableCollection<VENPY_WarehousesBranches>();
                foreach (ListViewItem item in ltvTBLE_CodeALM.Items)
                {
                    var l_item = ((VENPY_WarehousesBranches)item.Tag);
                    if (item.Checked)
                    {
                        var l_WarehouseBranch = new VENPY_WarehousesBranches();
                        l_WarehouseBranch.BUSI_Code = SessionVariables.BusinessCode;
                        l_WarehouseBranch.BOFF_Code = Presenter.Item.BOFF_Code;
                        l_WarehouseBranch.TBLE_TableALM = l_item.TBLE_TableALM;
                        l_WarehouseBranch.TBLE_CodeALM = l_item.TBLE_CodeALM;
                        l_WarehouseBranch.AUDI_CreationUser = SessionVariables.UserName;
                        l_WarehouseBranch.AUDI_ModificationUser = SessionVariables.UserName;
                        Presenter.Item.BOFF_WarehousesBranches.Add(l_WarehouseBranch);
                    }
                }
                Presenter.Item.UDTT_WarehousesBranches = new DataTable();
                if (Presenter.Item.BOFF_WarehousesBranches != null && Presenter.Item.BOFF_WarehousesBranches.Count > 0)
                {
                    Presenter.Item.UDTT_WarehousesBranches = Presenter.Item.BOFF_WarehousesBranches.ToTableParameter();
                }
            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(Presenter.Title, "Ha ocurrido un error al cargar los Almacenes.", ex); }
        }

        #endregion

        #region [ EVENTS ]

        private void CmbBOFF_CodeDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbBOFF_CodeDepartamento.SelectedValue != null)
                {
                    ObservableCollection<VENPY_Ubigeos> l_ItemsProvincias = new ObservableCollection<VENPY_Ubigeos>();
                    l_ItemsProvincias = Presenter.ItemsUbigeos.Where(Ubigeo => Ubigeo.UBIG_ParentCode == cmbBOFF_CodeDepartamento.SelectedValue.ToString()).ToObservableCollection();
                    cmbBOFF_CodeProvincia.ValueMember = "UBIG_Code";
                    cmbBOFF_CodeProvincia.DisplayMember = "UBIG_Description";
                    cmbBOFF_CodeProvincia.DataSource = l_ItemsProvincias;
                    cmbBOFF_CodeProvincia.Enabled = true;
                }
                else
                { cmbBOFF_CodeProvincia.Enabled = false; }
            }
            catch (Exception ex)
            { throw ex; }
        }
        private void CmbBOFF_CodeProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbBOFF_CodeProvincia.SelectedValue != null)
                {
                    ObservableCollection<VENPY_Ubigeos> l_ItemsDistritos = new ObservableCollection<VENPY_Ubigeos>();
                    l_ItemsDistritos = Presenter.ItemsUbigeos.Where(Ubigeo => Ubigeo.UBIG_ParentCode == cmbBOFF_CodeProvincia.SelectedValue.ToString()).ToObservableCollection();
                    cmbBOFF_CodeDistrito.ValueMember = "UBIG_Code";
                    cmbBOFF_CodeDistrito.DisplayMember = "UBIG_Description";
                    cmbBOFF_CodeDistrito.DataSource = l_ItemsDistritos;
                    cmbBOFF_CodeDistrito.Enabled = true;
                }
                else
                { cmbBOFF_CodeDistrito.Enabled = false; }
            }
            catch (Exception ex)
            { throw ex; }
        }
        private void TxtBOFF_SocialNetworks_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtBOFF_SocialNetworks.Text = txtBOFF_SocialNetworks.Text + Environment.NewLine;
                    txtBOFF_SocialNetworks.Select(txtBOFF_SocialNetworks.Text.Length, 0);
                }
            }
            catch (Exception ex)
            { throw ex; }
        }
        private void TxtBOFF_SocialNetworks_GotFocus(object sender, EventArgs e)
        {
            try
            {
                btnSave.Click -= BtnSave_Click;
            }
            catch (Exception ex)
            { throw ex; }
        }
        private void TxtBOFF_SocialNetworks_LostFocus(object sender, EventArgs e)
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
