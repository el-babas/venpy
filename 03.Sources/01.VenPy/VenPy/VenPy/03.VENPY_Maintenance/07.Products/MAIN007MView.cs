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
    public partial class MAIN007MView : Form, IMAIN007MView
    {
        #region [ PROPERTIES ]

        public MAIN007PView Presenter { get; set; }
        public BindingSource BSPROD_MeasurementUnitsProducts { get; set; }

        #endregion

        #region [ FORM ]

        public MAIN007MView()
        {
            InitializeComponent();
            BSPROD_MeasurementUnitsProducts = new BindingSource();
            btnSave.Click += new EventHandler(BtnSave_Click);
            btnAddDetail.Click += new EventHandler(BtnAddDetail_Click);
            dgvPROD_MeasurementUnitsProducts.CellDoubleClick += new DataGridViewCellEventHandler(DgvPROD_MeasurementUnitsProducts_CellDoubleClick);
            dgvPROD_MeasurementUnitsProducts.EditingControlShowing += new DataGridViewEditingControlShowingEventHandler(DgvPROD_MeasurementUnitsProducts_EditingControlShowing);
            cmbTBLE_CodeUNM.SelectedIndexChanged += new EventHandler(CmbTBLE_CodeUNM_SelectedIndexChanged);
        }
        public void MViewLoad()
        {
            try
            {
                CreateGridColumns();
                LoadControls();
            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(Presenter.Title, "Ha ocurrido un error cargando la vista.", ex); }
        }

        #endregion

        #region [ METHODS ]

        private void LoadControls()
        {
            try
            {
                if (Presenter.ItemsTables != null && Presenter.ItemsTables.Count > 0)
                {
                    ObservableCollection<VENPY_Tables> l_ItemsFAP = new ObservableCollection<VENPY_Tables>();
                    l_ItemsFAP = Presenter.ItemsTables.Where(Table => Table.BUSI_Code == SessionVariables.BusinessCode && Table.TBLE_Table == StaticLists.TBLE_FAP).ToObservableCollection();
                    if (l_ItemsFAP != null && l_ItemsFAP.Count > 0)
                    {
                        l_ItemsFAP.Insert(0, new VENPY_Tables { TBLE_Code = "0", TBLE_Description1 = "<Seleccionar Familia>" });
                        cmbTBLE_CodeFAP.ValueMember = "TBLE_Code";
                        cmbTBLE_CodeFAP.DisplayMember = "TBLE_Description1";
                        cmbTBLE_CodeFAP.DataSource = l_ItemsFAP;
                    }

                    ObservableCollection<VENPY_Tables> l_ItemsUNM = new ObservableCollection<VENPY_Tables>();
                    l_ItemsUNM = Presenter.ItemsTables.Where(Table => Table.BUSI_Code == SessionVariables.BusinessCode && Table.TBLE_Table == StaticLists.TBLE_UNM).ToObservableCollection();
                    if (l_ItemsUNM == null || l_ItemsUNM.Count == 0)
                    { Messages.ShowWarningMessage(Presenter.Title, "No se ha encontrado ninguna Unidad de Medida, puede que esto ocasione errores."); }
                    else
                    {
                        l_ItemsUNM.Insert(0, new VENPY_Tables { TBLE_Code = "0", TBLE_Description1 = "<Seleccionar Uni. Medida>" });
                        cmbTBLE_CodeUNM.ValueMember = "TBLE_Code";
                        cmbTBLE_CodeUNM.DisplayMember = "TBLE_Description1";
                        cmbTBLE_CodeUNM.DataSource = l_ItemsUNM;
                    }

                    ObservableCollection<VENPY_Tables> l_ItemsMAR = new ObservableCollection<VENPY_Tables>();
                    l_ItemsMAR = Presenter.ItemsTables.Where(Table => Table.BUSI_Code == SessionVariables.BusinessCode && Table.TBLE_Table == StaticLists.TBLE_MAR).ToObservableCollection();
                    if (l_ItemsMAR == null || l_ItemsMAR.Count == 0)
                    { l_ItemsMAR = new ObservableCollection<VENPY_Tables>(); }
                    l_ItemsMAR.Insert(0, new VENPY_Tables { TBLE_Code = "0", TBLE_Description1 = "<Seleccionar Marca>" });
                    cmbTBLE_CodeMAR.ValueMember = "TBLE_Code";
                    cmbTBLE_CodeMAR.DisplayMember = "TBLE_Description1";
                    cmbTBLE_CodeMAR.DataSource = l_ItemsMAR;

                }
            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(Presenter.Title, "Ha ocurrido un error al llenar los controles.", ex); }
        }
        private void CreateGridColumns()
        {
            try
            {
                ObservableCollection<VENPY_Tables> l_ItemsUNM = new ObservableCollection<VENPY_Tables>();
                l_ItemsUNM = Presenter.ItemsTables.Where(Table => Table.BUSI_Code == SessionVariables.BusinessCode && Table.TBLE_Table == StaticLists.TBLE_UNM).ToObservableCollection();
                if (l_ItemsUNM == null || l_ItemsUNM.Count == 0)
                { l_ItemsUNM = new ObservableCollection<VENPY_Tables>(); }
                l_ItemsUNM.Insert(0, new VENPY_Tables { TBLE_Code = "0", TBLE_Description1 = "<Seleccionar Uni. Medida>" });
                cmbTBLE_CodeUNM.ValueMember = "TBLE_Code";
                cmbTBLE_CodeUNM.DisplayMember = "TBLE_Description1";
                cmbTBLE_CodeUNM.DataSource = l_ItemsUNM;

                dgvPROD_MeasurementUnitsProducts.Columns.Clear();
                dgvPROD_MeasurementUnitsProducts.AutoGenerateColumns = false;
                dgvPROD_MeasurementUnitsProducts.MultiSelect = false;
                dgvPROD_MeasurementUnitsProducts.SelectionMode = DataGridViewSelectionMode.CellSelect;
                dgvPROD_MeasurementUnitsProducts.AllowUserToAddRows = false;
                dgvPROD_MeasurementUnitsProducts.AllowUserToDeleteRows = false;
                dgvPROD_MeasurementUnitsProducts.AllowUserToResizeRows = true;
                dgvPROD_MeasurementUnitsProducts.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
                dgvPROD_MeasurementUnitsProducts.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dgvPROD_MeasurementUnitsProducts.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(188, 230, 246);
                //dgvPROD_MeasurementUnitsProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvPROD_MeasurementUnitsProducts.AddImageColumn("", "Delete", "Delete", 35, Properties.Resources.remove_16x16, null, DataGridViewContentAlignment.MiddleCenter);
                dgvPROD_MeasurementUnitsProducts.AddComboBoxColumn("Unidad de Medida", "TBLE_CodeUNM", "TBLE_CodeUNM", 250, false, l_ItemsUNM.ToDataTable(), "TBLE_Description1", "TBLE_Code");
                dgvPROD_MeasurementUnitsProducts.AddTextBoxNumericColumn("Factor de Conversión", "MUPR_ConversionFactor", "MUPR_ConversionFactor", 120, false, DataGridViewContentAlignment.MiddleRight, 7, 5);

            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(Presenter.Title, "Ha ocurrido un error al dar formato a la Lista de Elementos del formulario.", ex); }
        }
        private void RemoveDetail()
        {
            try
            {
                if (BSPROD_MeasurementUnitsProducts.Current != null && BSPROD_MeasurementUnitsProducts.Current is VENPY_MeasurementUnitsProducts)
                {
                    BSPROD_MeasurementUnitsProducts.RemoveCurrent();
                    BSPROD_MeasurementUnitsProducts.ResetBindings(true);
                }
            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(Presenter.Title, "Ha ocurrido un error al eliminar un detalle.", ex); }
        }
        private void AddDetail()
        {
            try
            {
                VENPY_MeasurementUnitsProducts l_MeasurementUnitsProducts = new VENPY_MeasurementUnitsProducts();
                l_MeasurementUnitsProducts.BUSI_Code = SessionVariables.BusinessCode;
                l_MeasurementUnitsProducts.PROD_Code = Presenter.Item.PROD_Code;
                l_MeasurementUnitsProducts.TBLE_TableUNM = StaticLists.TBLE_UNM;
                l_MeasurementUnitsProducts.TBLE_CodeUNM = "0";
                l_MeasurementUnitsProducts.MUPR_ConversionFactor = 0;
                l_MeasurementUnitsProducts.AUDI_CreationUser = SessionVariables.UserName;
                l_MeasurementUnitsProducts.AUDI_ModificationUser = SessionVariables.UserName;
                l_MeasurementUnitsProducts.Instance = InstanceEntity.Insert;
                ((ObservableCollection<VENPY_MeasurementUnitsProducts>)BSPROD_MeasurementUnitsProducts.DataSource).Add(l_MeasurementUnitsProducts);
                BSPROD_MeasurementUnitsProducts.ResetBindings(true);
            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(Presenter.Title, "Ha ocurrido un error al agregar un detalle.", ex); }
        }
        private void AddDetailMinimum(String p_TBLE_CodeUNM)
        {
            try
            {
                if (BSPROD_MeasurementUnitsProducts != null && BSPROD_MeasurementUnitsProducts.DataSource != null)
                {
                    var l_DetailMinimum = (BSPROD_MeasurementUnitsProducts.DataSource as ObservableCollection<VENPY_MeasurementUnitsProducts>).Where(Table => Table.BUSI_Code == SessionVariables.BusinessCode && Table.TBLE_CodeUNM == p_TBLE_CodeUNM).ToObservableCollection();
                    if (l_DetailMinimum == null || l_DetailMinimum.Count() == 0)
                    {
                        VENPY_MeasurementUnitsProducts l_MeasurementUnitsProducts = new VENPY_MeasurementUnitsProducts();
                        l_MeasurementUnitsProducts.BUSI_Code = SessionVariables.BusinessCode;
                        l_MeasurementUnitsProducts.PROD_Code = Presenter.Item.PROD_Code;
                        l_MeasurementUnitsProducts.TBLE_TableUNM = StaticLists.TBLE_UNM;
                        l_MeasurementUnitsProducts.TBLE_CodeUNM = p_TBLE_CodeUNM;
                        l_MeasurementUnitsProducts.MUPR_ConversionFactor = 1;
                        l_MeasurementUnitsProducts.AUDI_CreationUser = SessionVariables.UserName;
                        l_MeasurementUnitsProducts.AUDI_ModificationUser = SessionVariables.UserName;
                        l_MeasurementUnitsProducts.Instance = InstanceEntity.Insert;
                        BSPROD_MeasurementUnitsProducts.Insert(0, l_MeasurementUnitsProducts);
                        BSPROD_MeasurementUnitsProducts.ResetBindings(true);
                    }
                }
            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(Presenter.Title, "Ha ocurrido un error al agregar un detalle.", ex); }
        }
        public void CleanControls()
        {
            try
            {
                txtPROD_Code.Text = string.Empty;
                cmbTBLE_CodeFAP.SelectedIndex = 0;
                cmbTBLE_CodeUNM.SelectedIndex = 0;
                txtPROD_Name.Text = string.Empty;
                chkPROD_Active.Checked = true;
                chkPROD_Original.Checked = false;
                txtPROD_Description.Text = string.Empty;
                cmbTBLE_CodeMAR.SelectedIndex = 0;
                txtPROD_Model.Text = string.Empty;
                txtPROD_Serie.Text = string.Empty;

                #region [ Details ]

                BSPROD_MeasurementUnitsProducts.DataSource = null;
                dgvPROD_MeasurementUnitsProducts.DataSource = BSPROD_MeasurementUnitsProducts;
                BSPROD_MeasurementUnitsProducts.ResetBindings(true);
                navPROD_MeasurementUnitsProducts.BindingSource = BSPROD_MeasurementUnitsProducts;
                dgvPROD_MeasurementUnitsProducts.ReadOnly = false;

                #endregion
            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(Presenter.Title, "Ha ocurrido un error al limpiar el formulario.", ex); }
        }
        public void SetItem()
        {
            try
            {
                txtPROD_Code.Text = Presenter.Item.PROD_Code.ToString();
                if (!string.IsNullOrEmpty(Presenter.Item.TBLE_TableFAP) && !string.IsNullOrEmpty(Presenter.Item.TBLE_CodeFAP))
                { cmbTBLE_CodeFAP.SelectedValue = Presenter.Item.TBLE_CodeFAP; }
                if (!string.IsNullOrEmpty(Presenter.Item.TBLE_TableUNM) && !string.IsNullOrEmpty(Presenter.Item.TBLE_CodeUNM))
                { cmbTBLE_CodeUNM.SelectedValue = Presenter.Item.TBLE_CodeUNM; }
                txtPROD_Name.Text = Presenter.Item.PROD_Name;
                chkPROD_Active.Checked = Presenter.Item.PROD_Active;
                chkPROD_Original.Checked = Presenter.Item.PROD_Original;
                txtPROD_Description.Text = Presenter.Item.PROD_Description;
                if (!string.IsNullOrEmpty(Presenter.Item.TBLE_TableMAR) && !string.IsNullOrEmpty(Presenter.Item.TBLE_CodeMAR))
                { cmbTBLE_CodeMAR.SelectedValue = Presenter.Item.TBLE_CodeMAR; }
                txtPROD_Model.Text = Presenter.Item.PROD_Model;
                txtPROD_Serie.Text = Presenter.Item.PROD_Serie;

                #region [ Details ]

                BSPROD_MeasurementUnitsProducts.DataSource = null;
                if (Presenter.Item.PROD_MeasurementUnitsProducts == null || Presenter.Item.PROD_MeasurementUnitsProducts.Count() == 0)
                { Presenter.Item.PROD_MeasurementUnitsProducts = new ObservableCollection<VENPY_MeasurementUnitsProducts>(); }
                BSPROD_MeasurementUnitsProducts.DataSource = Presenter.Item.PROD_MeasurementUnitsProducts;
                dgvPROD_MeasurementUnitsProducts.DataSource = BSPROD_MeasurementUnitsProducts;
                BSPROD_MeasurementUnitsProducts.ResetBindings(true);
                dgvPROD_MeasurementUnitsProducts.Refresh();
                dgvPROD_MeasurementUnitsProducts.ClearSelection();

                #endregion
            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(Presenter.Title, "Ha ocurrido un error al cargar el Item.", ex); }
        }
        public void GetItem()
        {
            try
            {
                Presenter.Item.BUSI_Code = SessionVariables.BusinessCode;
                Presenter.Item.TBLE_TableFAP = null;
                Presenter.Item.TBLE_CodeFAP = null;
                if (!cmbTBLE_CodeFAP.SelectedValue.ToString().Equals("0"))
                {
                    Presenter.Item.TBLE_TableFAP = StaticLists.TBLE_FAP;
                    Presenter.Item.TBLE_CodeFAP = cmbTBLE_CodeFAP.SelectedValue.ToString();
                }
                Presenter.Item.TBLE_TableUNM = null;
                Presenter.Item.TBLE_CodeUNM = null;
                if (!cmbTBLE_CodeUNM.SelectedValue.ToString().Equals("0"))
                {
                    Presenter.Item.TBLE_TableUNM = StaticLists.TBLE_UNM;
                    Presenter.Item.TBLE_CodeUNM = cmbTBLE_CodeUNM.SelectedValue.ToString();
                }
                Presenter.Item.PROD_Name = txtPROD_Name.Text;
                Presenter.Item.PROD_Description = string.IsNullOrEmpty(txtPROD_Description.Text) ? null : txtPROD_Description.Text;
                Presenter.Item.PROD_Active = chkPROD_Active.Checked;
                Presenter.Item.PROD_Original = chkPROD_Original.Checked;
                Presenter.Item.TBLE_TableMAR = null;
                Presenter.Item.TBLE_CodeMAR = null;
                if (!cmbTBLE_CodeMAR.SelectedValue.ToString().Equals("0"))
                {
                    Presenter.Item.TBLE_TableMAR = StaticLists.TBLE_MAR;
                    Presenter.Item.TBLE_CodeMAR = cmbTBLE_CodeMAR.SelectedValue.ToString();
                }
                Presenter.Item.PROD_Model = string.IsNullOrEmpty(txtPROD_Model.Text) ? null : txtPROD_Model.Text;
                Presenter.Item.PROD_Serie = string.IsNullOrEmpty(txtPROD_Serie.Text) ? null : txtPROD_Serie.Text;
                Presenter.Item.AUDI_CreationUser = SessionVariables.UserName;
                Presenter.Item.AUDI_ModificationUser = SessionVariables.UserName;

                #region [ Details ]

                Presenter.Item.PROD_MeasurementUnitsProducts = (BSPROD_MeasurementUnitsProducts.DataSource as ObservableCollection<VENPY_MeasurementUnitsProducts>);
                if (Presenter.Item.PROD_MeasurementUnitsProducts != null && Presenter.Item.PROD_MeasurementUnitsProducts.Count() > 0)
                { Presenter.Item.UDTT_MeasurementUnitsProducts = Presenter.Item.PROD_MeasurementUnitsProducts.ToTableParameter(); }

                #endregion
            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(Presenter.Title, "Ha ocurrido un error al obtener el Item.", ex); }
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
        private void DgvPROD_MeasurementUnitsProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                switch (dgvPROD_MeasurementUnitsProducts.Columns[e.ColumnIndex].Name)
                {
                    case "Delete":
                        RemoveDetail();
                        break;
                }
            }
            catch (Exception ex)
            { throw ex; }
        }
        private void DgvPROD_MeasurementUnitsProducts_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            try
            {
                CustomGridViewTextBoxNumeric l_CustomGridViewTextBoxNumeric = null;
                if (dgvPROD_MeasurementUnitsProducts.CurrentCell != null && dgvPROD_MeasurementUnitsProducts.CurrentCell.OwningColumn != null)
                {
                    switch (dgvPROD_MeasurementUnitsProducts.CurrentCell.OwningColumn.Name)
                    {
                        case "MUPR_ConversionFactor":
                            l_CustomGridViewTextBoxNumeric = (CustomDataGridViewTextBoxNumeric)e.Control;
                            l_CustomGridViewTextBoxNumeric.Entire = 7;
                            l_CustomGridViewTextBoxNumeric.Decimals = 5;
                            l_CustomGridViewTextBoxNumeric.Negative = false;
                            if (dgvPROD_MeasurementUnitsProducts.CurrentCell.Value != null)
                            { l_CustomGridViewTextBoxNumeric.Text = dgvPROD_MeasurementUnitsProducts.CurrentCell.Value.ToString(); }
                            break;
                    }
                }
            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(Presenter.Title, "Ha ocurrido un error al controlar los decimales.", ex); }
        }
        private void BtnAddDetail_Click(object sender, EventArgs e)
        {
            try
            {
                AddDetail();
            }
            catch (Exception ex)
            { throw ex; }
        }
        private void CmbTBLE_CodeUNM_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbTBLE_CodeUNM.SelectedValue != null && cmbTBLE_CodeUNM.SelectedValue.ToString() != "0")
                {
                    AddDetailMinimum(cmbTBLE_CodeUNM.SelectedValue.ToString());
                }
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion
    }
}
