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
    public partial class MAIN006MView : Form, IMAIN006MView
    {
        #region [ PROPERTIES ]

        public MAIN006PView Presenter { get; set; }

        #endregion

        #region [ FORM ]

        public MAIN006MView()
        {
            InitializeComponent();
            btnSave.Click += new EventHandler(BtnSave_Click);
            rbtENTI_NaturalPerson.CheckedChanged += new EventHandler(RbtENTI_NaturalPerson_CheckedChanged);
            chkENTI_Domiciled.CheckedChanged += new EventHandler(ChkENTI_Domiciled_CheckedChanged);
            cmbTBLE_CodePAI.SelectedIndexChanged += new EventHandler(CmbTBLE_CodePAI_SelectedIndexChanged);
            cmbENTI_CodeDepartamento.SelectedIndexChanged += new EventHandler(CmbENTI_CodeDepartamento_SelectedIndexChanged);
            cmbENTI_CodeProvincia.SelectedIndexChanged += new EventHandler(CmbENTI_CodeProvincia_SelectedIndexChanged);
            cmbENTI_CodeDepartamento.Enabled = false;
            cmbENTI_CodeProvincia.Enabled = false;
            cmbENTI_CodeDistrito.Enabled = false;
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
                ObservableCollection<VENPY_Tables> l_ItemsTablesState = new ObservableCollection<VENPY_Tables>();
                l_ItemsTablesState.Add(new VENPY_Tables { TBLE_Code = "A", TBLE_Description1 = "ACTIVO" });
                l_ItemsTablesState.Add(new VENPY_Tables { TBLE_Code = "I", TBLE_Description1 = "INACTIVO" });
                l_ItemsTablesState.Add(new VENPY_Tables { TBLE_Code = "D", TBLE_Description1 = "DESHABILITADO" });
                l_ItemsTablesState.Add(new VENPY_Tables { TBLE_Code = "N", TBLE_Description1 = "NO HABIDO" });
                l_ItemsTablesState.Add(new VENPY_Tables { TBLE_Code = "B", TBLE_Description1 = "BLOQUEADO" });
                cmbENTI_Status.ValueMember = "TBLE_Code";
                cmbENTI_Status.DisplayMember = "TBLE_Description1";
                cmbENTI_Status.DataSource = l_ItemsTablesState;

                if (Presenter.ItemsTables != null && Presenter.ItemsTables.Count > 0)
                {
                    ObservableCollection<VENPY_Tables> l_ItemsTDI = new ObservableCollection<VENPY_Tables>();
                    l_ItemsTDI = Presenter.ItemsTables.Where(Table => Table.BUSI_Code == SessionVariables.BusinessCode && Table.TBLE_Table == StaticLists.TBLE_TDI).ToObservableCollection();
                    if (l_ItemsTDI == null || l_ItemsTDI.Count == 0)
                    { Messages.ShowWarningMessage(Presenter.Title, "No se ha encontrado ningun Tipo de Documento de Identidad, puede que esto ocasione errores."); }
                    else
                    {
                        cmbTBLE_CodeTDI.ValueMember = "TBLE_Code";
                        cmbTBLE_CodeTDI.DisplayMember = "TBLE_Description1";
                        cmbTBLE_CodeTDI.DataSource = l_ItemsTDI;
                    }

                    ObservableCollection<VENPY_Tables> l_ItemsPAI = new ObservableCollection<VENPY_Tables>();
                    l_ItemsPAI = Presenter.ItemsTables.Where(Table => Table.BUSI_Code == SessionVariables.BusinessCode && Table.TBLE_Table == StaticLists.TBLE_PAI).ToObservableCollection();
                    if (l_ItemsPAI == null || l_ItemsPAI.Count == 0)
                    { Messages.ShowWarningMessage(Presenter.Title, "No se ha encontrado ningun Pais, puede que esto ocasione errores."); }
                    else
                    {
                        l_ItemsPAI.Insert(0, new VENPY_Tables { TBLE_Code = "0", TBLE_Description1 = "<Seleccionar Pais>" });
                        cmbTBLE_CodePAI.ValueMember = "TBLE_Code";
                        cmbTBLE_CodePAI.DisplayMember = "TBLE_Description1";
                        cmbTBLE_CodePAI.DataSource = l_ItemsPAI;
                    }
                }

                if (Presenter.ItemsUbigeos != null && Presenter.ItemsUbigeos.Count > 0)
                {
                    ObservableCollection<VENPY_Ubigeos> l_ItemsDepartamentos = new ObservableCollection<VENPY_Ubigeos>();
                    l_ItemsDepartamentos = Presenter.ItemsUbigeos.Where(Ubigeo => Ubigeo.UBIG_ParentCode == null).ToObservableCollection();
                    l_ItemsDepartamentos.Insert(0, new VENPY_Ubigeos { UBIG_Code = "0", UBIG_Description = "<Seleccionar Departamento>" });
                    cmbENTI_CodeDepartamento.ValueMember = "UBIG_Code";
                    cmbENTI_CodeDepartamento.DisplayMember = "UBIG_Description";
                    cmbENTI_CodeDepartamento.DataSource = l_ItemsDepartamentos;
                }
            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(Presenter.Title, "Ha ocurrido un error al llenar los controles.", ex); }
        }
        public void CleanControls()
        {
            try
            {
                tabGeneral.SelectedTab = tabPage1;
                txtENTI_Code.Text = string.Empty;
                cmbENTI_Status.SelectedIndex = 0;
                rbtENTI_NaturalPerson.Checked = true;
                rbtENTI_LegalPerson.Checked = false;
                cmbTBLE_CodeTDI.SelectedIndex = 0;
                txtENTI_DocumentNumber.Text = string.Empty;
                chkENTI_Domiciled.Checked = false;
                chkENTI_Favourite.Checked = false;
                txtENTI_BusinessName.Text = string.Empty;
                txtENTI_Address.Text = string.Empty;
                txtENTI_ReferentialAddress.Text = string.Empty;
                cmbTBLE_CodePAI.SelectedIndex = 0;
                cmbENTI_CodeDepartamento.SelectedIndex = 0;
                cmbENTI_CodeProvincia.SelectedIndex = 0;
                cmbENTI_CodeDistrito.SelectedIndex = 0;
                mdtlblENTI_Birthdate.MDTDate = null;
                txtENTI_PhoneNumber.Text = string.Empty;
                txtENTI_Email.Text = string.Empty;
                txtENTI_Web.Text = string.Empty;
                txtENTI_BankAccount.Text = string.Empty;
                ltvETYP_Code.Items.Clear();
            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(Presenter.Title, "Ha ocurrido un error al limpiar el formulario.", ex); }
        }
        public void SetItem()
        {
            try
            {
                txtENTI_Code.Text = Presenter.Item.ENTI_Code.ToString();
                cmbENTI_Status.SelectedValue = Presenter.Item.ENTI_Status;
                switch (Presenter.Item.ENTI_EntityType)
                {
                    case "N":
                        rbtENTI_NaturalPerson.Checked = true;
                        break;
                    case "J":
                        rbtENTI_LegalPerson.Checked = true;
                        break;
                }
                if (!string.IsNullOrEmpty(Presenter.Item.TBLE_TableTDI) && !string.IsNullOrEmpty(Presenter.Item.TBLE_CodeTDI))
                { cmbTBLE_CodeTDI.SelectedValue = Presenter.Item.TBLE_CodeTDI; }
                txtENTI_DocumentNumber.Text = Presenter.Item.ENTI_DocumentNumber;
                chkENTI_Domiciled.Checked = Presenter.Item.ENTI_Domiciled;
                chkENTI_Favourite.Checked = Presenter.Item.ENTI_Favourite;
                txtENTI_BusinessName.Text = Presenter.Item.ENTI_BusinessName;
                txtENTI_Address.Text = Presenter.Item.ENTI_Address;
                txtENTI_ReferentialAddress.Text = Presenter.Item.ENTI_ReferentialAddress;
                if (!string.IsNullOrEmpty(Presenter.Item.TBLE_TablePAI) && !string.IsNullOrEmpty(Presenter.Item.TBLE_CodePAI))
                { cmbTBLE_CodePAI.SelectedValue = Presenter.Item.TBLE_CodePAI; }
                if (!string.IsNullOrEmpty(Presenter.Item.ENTI_CodeDepartamento))
                { cmbENTI_CodeDepartamento.SelectedValue = Presenter.Item.ENTI_CodeDepartamento; }
                if (!string.IsNullOrEmpty(Presenter.Item.ENTI_CodeProvincia))
                { cmbENTI_CodeProvincia.SelectedValue = Presenter.Item.ENTI_CodeProvincia; }
                if (!string.IsNullOrEmpty(Presenter.Item.ENTI_CodeDistrito))
                { cmbENTI_CodeDistrito.SelectedValue = Presenter.Item.ENTI_CodeDistrito; }
                mdtlblENTI_Birthdate.MDTDate = Presenter.Item.ENTI_Birthdate;
                txtENTI_PhoneNumber.Text = Presenter.Item.ENTI_PhoneNumber;
                txtENTI_Email.Text = Presenter.Item.ENTI_Email;
                txtENTI_Web.Text = Presenter.Item.ENTI_Web;
                txtENTI_BankAccount.Text = Presenter.Item.ENTI_BankAccount;
            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(Presenter.Title, "Ha ocurrido un error al cargar el Item.", ex); }
        }
        public void GetItem()
        {
            try
            {
                Presenter.Item.BUSI_Code = SessionVariables.BusinessCode;
                Presenter.Item.ENTI_Status = cmbENTI_Status.SelectedValue.ToString();
                Presenter.Item.ENTI_EntityType = rbtENTI_LegalPerson.Checked ? "J" : "N";
                Presenter.Item.TBLE_TableTDI = StaticLists.TBLE_TDI;
                Presenter.Item.TBLE_CodeTDI = cmbTBLE_CodeTDI.SelectedValue.ToString();
                Presenter.Item.ENTI_DocumentNumber = txtENTI_DocumentNumber.Text;
                Presenter.Item.ENTI_Domiciled = chkENTI_Domiciled.Checked;
                Presenter.Item.ENTI_Favourite = chkENTI_Favourite.Checked;
                Presenter.Item.ENTI_BusinessName = txtENTI_BusinessName.Text;
                Presenter.Item.ENTI_Address = txtENTI_Address.Text;
                Presenter.Item.ENTI_ReferentialAddress = String.IsNullOrEmpty(txtENTI_ReferentialAddress.Text) ? null : txtENTI_ReferentialAddress.Text;
                Presenter.Item.TBLE_TablePAI = null;
                Presenter.Item.TBLE_CodePAI = null;
                if (!cmbTBLE_CodePAI.SelectedValue.ToString().Equals("0"))
                {
                    Presenter.Item.TBLE_TablePAI = StaticLists.TBLE_PAI;
                    Presenter.Item.TBLE_CodePAI = cmbTBLE_CodePAI.SelectedValue.ToString();
                }
                Presenter.Item.UBIG_Code = null;
                if (!cmbENTI_CodeDistrito.SelectedValue.ToString().Equals("0"))
                { Presenter.Item.UBIG_Code = cmbENTI_CodeDistrito.SelectedValue.ToString(); }
                Presenter.Item.ENTI_Birthdate = mdtlblENTI_Birthdate.MDTDate;
                Presenter.Item.ENTI_PhoneNumber = string.IsNullOrEmpty(txtENTI_PhoneNumber.Text) ? null : txtENTI_PhoneNumber.Text;
                Presenter.Item.ENTI_Email = string.IsNullOrEmpty(txtENTI_Email.Text) ? null : txtENTI_Email.Text;
                Presenter.Item.ENTI_Web = string.IsNullOrEmpty(txtENTI_Web.Text) ? null : txtENTI_Web.Text;
                Presenter.Item.ENTI_BankAccount = string.IsNullOrEmpty(txtENTI_BankAccount.Text) ? null : txtENTI_BankAccount.Text;
                Presenter.Item.AUDI_CreationUser = SessionVariables.UserName;
                Presenter.Item.AUDI_ModificationUser = SessionVariables.UserName;
                GetEntityTypes();
            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(Presenter.Title, "Ha ocurrido un error al obtener el Item.", ex); }
        }
        public void EntityTypes()
        {
            try
            {
                lblENTI_BusinessName.Text = "Razón Social";
                lblENTI_Birthdate.Text = "Aniversario";

                if (rbtENTI_NaturalPerson.Checked)
                {
                    lblENTI_BusinessName.Text = "Nombre Completo";
                    lblENTI_Birthdate.Text = "Cumpleaños";
                    cmbTBLE_CodeTDI.SelectedValue = StaticLists.TDI_Dni;
                }
                if (rbtENTI_LegalPerson.Checked)
                {
                    lblENTI_BusinessName.Text = "Razón Social";
                    lblENTI_Birthdate.Text = "Aniversario";
                    cmbTBLE_CodeTDI.SelectedValue = StaticLists.TDI_Ruc;
                }
            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(Presenter.Title, "Ocurrio un error al construir el formulario.", ex); }
        }
        public void FillEntityTypes(Int32 p_ETYP_Code)
        {
            try
            {
                if (Presenter.Item.ENTI_FunctionsEntities != null && Presenter.Item.ENTI_FunctionsEntities.Count() > 0)
                {
                    ltvETYP_Code.Items.Clear();
                    ltvETYP_Code.View = View.List;
                    ltvETYP_Code.CheckBoxes = true;
                    foreach (VENPY_FunctionsEntities FunctionEntity in Presenter.Item.ENTI_FunctionsEntities)
                    {
                        ListViewItem l_item = null;
                        if (FunctionEntity.ETYP_Code.Equals(p_ETYP_Code))
                        { l_item = new ListViewItem() { Tag = FunctionEntity, Text = FunctionEntity.FENT_Name, Checked = true }; }
                        else
                        { l_item = new ListViewItem() { Tag = FunctionEntity, Text = FunctionEntity.FENT_Name, Checked = FunctionEntity.FENT_Select }; }
                        ltvETYP_Code.Items.Add(l_item);
                    }
                }
            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(Presenter.Title, "Ha ocurrido un error al llenar los Tipos de Entidades.", ex); }
        }
        public void GetEntityTypes()
        {
            try
            {
                Presenter.Item.ENTI_FunctionsEntities = new ObservableCollection<VENPY_FunctionsEntities>();
                foreach (ListViewItem item in ltvETYP_Code.Items)
                {
                    var l_item = ((VENPY_FunctionsEntities)item.Tag);
                    if (item.Checked)
                    {
                        var l_FunctionEntity = new VENPY_FunctionsEntities();
                        l_FunctionEntity.BUSI_Code = SessionVariables.BusinessCode;
                        l_FunctionEntity.ENTI_Code = Presenter.Item.ENTI_Code;
                        l_FunctionEntity.ETYP_Code = l_item.ETYP_Code;
                        l_FunctionEntity.AUDI_CreationUser = SessionVariables.UserName;
                        l_FunctionEntity.AUDI_ModificationUser = SessionVariables.UserName;
                        Presenter.Item.ENTI_FunctionsEntities.Add(l_FunctionEntity);
                    }
                }
                Presenter.Item.UDTT_FunctionsEntities = new DataTable();
                if (Presenter.Item.ENTI_FunctionsEntities != null && Presenter.Item.ENTI_FunctionsEntities.Count > 0)
                {
                    Presenter.Item.UDTT_FunctionsEntities = Presenter.Item.ENTI_FunctionsEntities.ToTableParameter();
                }
            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(Presenter.Title, "Ha ocurrido un error al cargar los Tipos de Entidad.", ex); }
        }

        #endregion

        #region [ EVENTS ]

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
        private void RbtENTI_NaturalPerson_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                EntityTypes();
            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(Presenter.Title, "Ocurrio un error al construir el formulario.", ex); }
        }
        private void ChkENTI_Domiciled_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chkENTI_Domiciled.Checked)
                {
                    cmbTBLE_CodePAI.SelectedValue = StaticLists.PAI_Per;
                    cmbENTI_CodeDepartamento.SelectedValue = "0";
                    cmbENTI_CodeDepartamento.Enabled = true;
                    cmbENTI_CodeProvincia.SelectedValue = "0";
                    cmbENTI_CodeProvincia.Enabled = true;
                    cmbENTI_CodeDistrito.SelectedValue = "0";
                    cmbENTI_CodeDistrito.Enabled = true;
                }
                else
                {
                    cmbTBLE_CodePAI.SelectedValue = "0";
                    cmbENTI_CodeDepartamento.SelectedValue = "0";
                    cmbENTI_CodeDepartamento.Enabled = false;
                    cmbENTI_CodeProvincia.SelectedValue = "0";
                    cmbENTI_CodeProvincia.Enabled = false;
                    cmbENTI_CodeDistrito.SelectedValue = "0";
                    cmbENTI_CodeDistrito.Enabled = false;
                }
            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(Presenter.Title, "Ocurrio un error al seleccionar Domiciliado.", ex); }
        }
        private void CmbTBLE_CodePAI_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbTBLE_CodePAI.SelectedValue != null && !cmbTBLE_CodePAI.SelectedValue.ToString().Equals("0"))
                {
                    if (cmbTBLE_CodePAI.SelectedValue.ToString().Equals(StaticLists.PAI_Per))
                    { cmbENTI_CodeDepartamento.Enabled = true; }
                    else
                    {
                        cmbENTI_CodeDepartamento.SelectedValue = "0";
                        cmbENTI_CodeDepartamento.Enabled = false;
                        cmbENTI_CodeProvincia.SelectedValue = "0";
                        cmbENTI_CodeProvincia.Enabled = false;
                        cmbENTI_CodeDistrito.SelectedValue = "0";
                        cmbENTI_CodeDistrito.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(Presenter.Title, "Ocurrio un error al cambiar el País.", ex); }
        }
        private void CmbENTI_CodeDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbENTI_CodeDepartamento.SelectedValue != null)
                {
                    ObservableCollection<VENPY_Ubigeos> l_ItemsProvincias = new ObservableCollection<VENPY_Ubigeos>();
                    l_ItemsProvincias = Presenter.ItemsUbigeos.Where(Ubigeo => Ubigeo.UBIG_ParentCode == cmbENTI_CodeDepartamento.SelectedValue.ToString()).ToObservableCollection();
                    l_ItemsProvincias.Insert(0, new VENPY_Ubigeos { UBIG_Code = "0", UBIG_Description = "<Seleccionar Provincia>" });
                    cmbENTI_CodeProvincia.ValueMember = "UBIG_Code";
                    cmbENTI_CodeProvincia.DisplayMember = "UBIG_Description";
                    cmbENTI_CodeProvincia.DataSource = l_ItemsProvincias;
                    cmbENTI_CodeProvincia.Enabled = true;
                }
                else
                { cmbENTI_CodeProvincia.Enabled = false; }
            }
            catch (Exception ex)
            { throw ex; }
        }
        private void CmbENTI_CodeProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbENTI_CodeProvincia.SelectedValue != null)
                {
                    ObservableCollection<VENPY_Ubigeos> l_ItemsDistritos = new ObservableCollection<VENPY_Ubigeos>();
                    l_ItemsDistritos = Presenter.ItemsUbigeos.Where(Ubigeo => Ubigeo.UBIG_ParentCode == cmbENTI_CodeProvincia.SelectedValue.ToString()).ToObservableCollection();
                    l_ItemsDistritos.Insert(0, new VENPY_Ubigeos { UBIG_Code = "0", UBIG_Description = "<Seleccionar Distrito>" });
                    cmbENTI_CodeDistrito.ValueMember = "UBIG_Code";
                    cmbENTI_CodeDistrito.DisplayMember = "UBIG_Description";
                    cmbENTI_CodeDistrito.DataSource = l_ItemsDistritos;
                    cmbENTI_CodeDistrito.Enabled = true;
                }
                else
                { cmbENTI_CodeDistrito.Enabled = false; }
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion
    }
}
