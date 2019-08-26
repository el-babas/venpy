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
    public partial class MAIN008MView : Form, IMAIN008MView
    {
        #region [ PROPERTIES ]

        public MAIN008PView Presenter { get; set; }
        public BindingSource BSPRLI_PriceListDetail { get; set; }

        #endregion

        #region [ FORM ]

        public MAIN008MView()
        {
            InitializeComponent();
            BSPRLI_PriceListDetail = new BindingSource();
            btnSave.Click += new EventHandler(BtnSave_Click);
            cmbTBLE_CodeTAI.SelectedIndexChanged += new EventHandler(CmbTBLE_CodeTAI_SelectedIndexChanged);
            dgvPRLI_PriceListDetail.EditingControlShowing += new DataGridViewEditingControlShowingEventHandler(DgvPRLI_PriceListDetail_EditingControlShowing);
            dgvPRLI_PriceListDetail.CellEndEdit += new DataGridViewCellEventHandler(DgvPRLI_PriceListDetail_CellEndEdit);
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
                    ObservableCollection<VENPY_Tables> l_ItemsMND = new ObservableCollection<VENPY_Tables>();
                    l_ItemsMND = Presenter.ItemsTables.Where(Table => Table.BUSI_Code == SessionVariables.BusinessCode && Table.TBLE_Table == StaticLists.TBLE_MND).ToObservableCollection();
                    if (l_ItemsMND == null || l_ItemsMND.Count == 0)
                    { Messages.ShowWarningMessage(Presenter.Title, "No se ha encontrado ninguna Unidad de Medida, puede que esto ocasione errores."); }
                    else
                    {
                        l_ItemsMND.Insert(0, new VENPY_Tables { TBLE_Code = "0", TBLE_Description1 = "<Seleccionar Moneda>" });
                        cmbTBLE_CodeMND.ValueMember = "TBLE_Code";
                        cmbTBLE_CodeMND.DisplayMember = "TBLE_Description1";
                        cmbTBLE_CodeMND.DataSource = l_ItemsMND;
                    }

                    ObservableCollection<VENPY_Tables> l_ItemsTAI = new ObservableCollection<VENPY_Tables>();
                    l_ItemsTAI = Presenter.ItemsTables.Where(Table => Table.BUSI_Code == SessionVariables.BusinessCode && Table.TBLE_Table == StaticLists.TBLE_TAI).ToObservableCollection();
                    if (l_ItemsTAI == null || l_ItemsTAI.Count == 0)
                    { l_ItemsTAI = new ObservableCollection<VENPY_Tables>(); }
                    l_ItemsTAI.Insert(0, new VENPY_Tables { TBLE_Code = "0", TBLE_Description1 = "<Seleccionar Afectación IGV>" });
                    cmbTBLE_CodeTAI.ValueMember = "TBLE_Code";
                    cmbTBLE_CodeTAI.DisplayMember = "TBLE_Description1";
                    cmbTBLE_CodeTAI.DataSource = l_ItemsTAI;
                }
            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(Presenter.Title, "Ha ocurrido un error al llenar los controles.", ex); }
        }
        private void CreateGridColumns()
        {
            try
            {
                ObservableCollection<VENPY_Tables> l_ItemsTAI = new ObservableCollection<VENPY_Tables>();
                l_ItemsTAI = Presenter.ItemsTables.Where(Table => Table.BUSI_Code == SessionVariables.BusinessCode && Table.TBLE_Table == StaticLists.TBLE_TAI).ToObservableCollection();
                if (l_ItemsTAI == null || l_ItemsTAI.Count == 0)
                { l_ItemsTAI = new ObservableCollection<VENPY_Tables>(); }
                l_ItemsTAI.Insert(0, new VENPY_Tables { TBLE_Code = "0", TBLE_Description1 = "<Afectación IGV>" });
                cmbTBLE_CodeMND.ValueMember = "TBLE_Code";
                cmbTBLE_CodeMND.DisplayMember = "TBLE_Description1";
                cmbTBLE_CodeMND.DataSource = l_ItemsTAI;

                dgvPRLI_PriceListDetail.Columns.Clear();
                dgvPRLI_PriceListDetail.AutoGenerateColumns = false;
                dgvPRLI_PriceListDetail.MultiSelect = false;
                dgvPRLI_PriceListDetail.SelectionMode = DataGridViewSelectionMode.CellSelect;
                dgvPRLI_PriceListDetail.AllowUserToAddRows = false;
                dgvPRLI_PriceListDetail.AllowUserToDeleteRows = false;
                dgvPRLI_PriceListDetail.AllowUserToResizeRows = true;
                dgvPRLI_PriceListDetail.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
                dgvPRLI_PriceListDetail.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(188, 230, 246);
                dgvPRLI_PriceListDetail.AddTextBoxColumn("Producto", "PROD_Name", "PROD_Name", 250, true, null, DataGridViewContentAlignment.MiddleLeft);
                dgvPRLI_PriceListDetail.AddTextBoxColumn("PROD_Code", "PROD_Code", "PROD_Code", 100, true, null, DataGridViewContentAlignment.MiddleCenter);
                dgvPRLI_PriceListDetail.AddTextBoxColumn("TBLE_TableUNM", "TBLE_TableUNM", "TBLE_TableUNM", 120, true, null, DataGridViewContentAlignment.MiddleCenter);
                dgvPRLI_PriceListDetail.AddTextBoxColumn("TBLE_CodeUNM", "TBLE_CodeUNM", "TBLE_CodeUNM", 100, true, null, DataGridViewContentAlignment.MiddleCenter);
                dgvPRLI_PriceListDetail.AddTextBoxColumn("Unidad de Medida", "TBLE_NameUNM", "TBLE_NameUNM", 150, true, null, DataGridViewContentAlignment.MiddleLeft);
                dgvPRLI_PriceListDetail.AddTextBoxColumn("TBLE_TableTAI", "TBLE_TableTAI", "TBLE_TableTAI", 100, true, null, DataGridViewContentAlignment.MiddleCenter);
                dgvPRLI_PriceListDetail.AddComboBoxColumn("Afectación IGV", "TBLE_CodeTAI", "TBLE_CodeTAI", 120, false, l_ItemsTAI.ToDataTable(), "TBLE_Description1", "TBLE_Code");
                dgvPRLI_PriceListDetail.AddTextBoxNumericColumn("Valor Unitario", "PLDE_UnitValue", "PLDE_UnitValue", 100, false, DataGridViewContentAlignment.MiddleRight, 20, Presenter.NumberDecimals);
                dgvPRLI_PriceListDetail.AddTextBoxNumericColumn("I.G.V", "PLDE_IGV", "PLDE_IGV", 75, false, DataGridViewContentAlignment.MiddleRight, 20, Presenter.NumberDecimals);
                dgvPRLI_PriceListDetail.AddTextBoxNumericColumn("Precio Unitario", "PLDE_UnitPrice", "PLDE_UnitPrice", 120, false, DataGridViewContentAlignment.MiddleRight, 20, Presenter.NumberDecimals);

                dgvPRLI_PriceListDetail.Columns["PROD_Code"].Visible = false;
                dgvPRLI_PriceListDetail.Columns["TBLE_TableUNM"].Visible = false;
                dgvPRLI_PriceListDetail.Columns["TBLE_CodeUNM"].Visible = false;
                dgvPRLI_PriceListDetail.Columns["TBLE_TableTAI"].Visible = false;
            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(Presenter.Title, "Ha ocurrido un error al dar formato a la Lista de Elementos del formulario.", ex); }
        }
        public void CleanControls()
        {
            try
            {
                txtPRLI_Code.Text = string.Empty;
                cmbTBLE_CodeMND.SelectedIndex = 0;
                txtPRLI_Name.Text = string.Empty;
                chkPRLI_Active.Checked = true;
                txtPRLI_Description.Text = string.Empty;
                cmbTBLE_CodeTAI.SelectedIndex = 0;

                #region [ Details ]

                BSPRLI_PriceListDetail.DataSource = null;
                dgvPRLI_PriceListDetail.DataSource = BSPRLI_PriceListDetail;
                BSPRLI_PriceListDetail.ResetBindings(true);
                navPROD_MeasurementUnitsProducts.BindingSource = BSPRLI_PriceListDetail;
                dgvPRLI_PriceListDetail.ReadOnly = false;

                #endregion
            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(Presenter.Title, "Ha ocurrido un error al limpiar el formulario.", ex); }
        }
        public void SetItem()
        {
            try
            {
                txtPRLI_Code.Text = Presenter.Item.PRLI_Code.ToString();
                if (!string.IsNullOrEmpty(Presenter.Item.TBLE_TableMND) && !string.IsNullOrEmpty(Presenter.Item.TBLE_CodeMND))
                { cmbTBLE_CodeMND.SelectedValue = Presenter.Item.TBLE_CodeMND; }
                chkPRLI_Active.Checked = Presenter.Item.PRLI_Active;
                txtPRLI_Name.Text = Presenter.Item.PRLI_Name;
                txtPRLI_Description.Text = Presenter.Item.PRLI_Description;
                cmbTBLE_CodeTAI.SelectedIndexChanged -= CmbTBLE_CodeTAI_SelectedIndexChanged;
                if (!string.IsNullOrEmpty(Presenter.Item.TBLE_TableTAI) && !string.IsNullOrEmpty(Presenter.Item.TBLE_CodeTAI))
                { cmbTBLE_CodeTAI.SelectedValue = Presenter.Item.TBLE_CodeTAI; }
                cmbTBLE_CodeTAI.SelectedIndexChanged += CmbTBLE_CodeTAI_SelectedIndexChanged;

                #region [ Details ]

                BSPRLI_PriceListDetail.DataSource = null;
                if (Presenter.Item.PRLI_PriceListDetail == null || Presenter.Item.PRLI_PriceListDetail.Count() == 0)
                { Presenter.Item.PRLI_PriceListDetail = new ObservableCollection<VENPY_PriceListDetail>(); }
                BSPRLI_PriceListDetail.DataSource = Presenter.Item.PRLI_PriceListDetail;
                dgvPRLI_PriceListDetail.DataSource = BSPRLI_PriceListDetail;
                BSPRLI_PriceListDetail.ResetBindings(true);
                dgvPRLI_PriceListDetail.Refresh();
                dgvPRLI_PriceListDetail.ClearSelection();

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
                Presenter.Item.TBLE_TableMND = null;
                Presenter.Item.TBLE_CodeMND = null;
                if (!cmbTBLE_CodeMND.SelectedValue.ToString().Equals("0"))
                {
                    Presenter.Item.TBLE_TableMND = StaticLists.TBLE_MND;
                    Presenter.Item.TBLE_CodeMND = cmbTBLE_CodeMND.SelectedValue.ToString();
                }
                Presenter.Item.PRLI_Active = chkPRLI_Active.Checked;
                Presenter.Item.PRLI_Name = txtPRLI_Name.Text;
                Presenter.Item.TBLE_TableTAI = null;
                Presenter.Item.TBLE_CodeTAI = null;
                if (!cmbTBLE_CodeMND.SelectedValue.ToString().Equals("0"))
                {
                    Presenter.Item.TBLE_TableTAI = StaticLists.TBLE_TAI;
                    Presenter.Item.TBLE_CodeTAI = cmbTBLE_CodeMND.SelectedValue.ToString();
                }
                Presenter.Item.PRLI_Description = string.IsNullOrEmpty(txtPRLI_Description.Text) ? null : txtPRLI_Description.Text;
                Presenter.Item.AUDI_CreationUser = SessionVariables.UserName;
                Presenter.Item.AUDI_ModificationUser = SessionVariables.UserName;

                #region [ Details ]

                Presenter.Item.PRLI_PriceListDetail = (BSPRLI_PriceListDetail.DataSource as ObservableCollection<VENPY_PriceListDetail>);

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
        private void CmbTBLE_CodeTAI_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbTBLE_CodeTAI.SelectedValue != null && cmbTBLE_CodeTAI.SelectedValue.ToString() != "0")
                {
                    if (Presenter.Item.PRLI_PriceListDetail != null && Presenter.Item.PRLI_PriceListDetail.Count() > 0)
                    {
                        foreach (VENPY_PriceListDetail l_item in Presenter.Item.PRLI_PriceListDetail)
                        {
                            l_item.TBLE_TableTAI = StaticLists.TBLE_TAI;
                            l_item.TBLE_CodeTAI = cmbTBLE_CodeTAI.SelectedValue.ToString();
                        }
                        BSPRLI_PriceListDetail.ResetBindings(true);
                        dgvPRLI_PriceListDetail.Refresh();
                    }
                }
            }
            catch (Exception ex)
            { throw ex; }
        }
        private void DgvPRLI_PriceListDetail_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            try
            {
                CustomGridViewTextBoxNumeric l_CustomGridViewTextBoxNumeric = null;
                if (dgvPRLI_PriceListDetail.CurrentCell != null && dgvPRLI_PriceListDetail.CurrentCell.OwningColumn != null)
                {
                    switch (dgvPRLI_PriceListDetail.CurrentCell.OwningColumn.Name)
                    {
                        case "PLDE_UnitValue":
                        case "PLDE_IGV":
                        case "PLDE_UnitPrice":
                            l_CustomGridViewTextBoxNumeric = (CustomDataGridViewTextBoxNumeric)e.Control;
                            l_CustomGridViewTextBoxNumeric.Entire = 20;
                            l_CustomGridViewTextBoxNumeric.Decimals = Presenter.NumberDecimals;
                            l_CustomGridViewTextBoxNumeric.Negative = false;
                            if (dgvPRLI_PriceListDetail.CurrentCell.Value != null)
                            { l_CustomGridViewTextBoxNumeric.Text = dgvPRLI_PriceListDetail.CurrentCell.Value.ToString(); }
                            break;
                    }
                }
            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(Presenter.Title, "Ha ocurrido un error al controlar los decimales.", ex); }
        }
        private void DgvPRLI_PriceListDetail_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvPRLI_PriceListDetail.Rows[e.RowIndex].DataBoundItem is VENPY_PriceListDetail)
                {
                    switch (dgvPRLI_PriceListDetail.Columns[e.ColumnIndex].Name)
                    {
                        case "TBLE_CodeTAI":
                            (dgvPRLI_PriceListDetail.Rows[e.RowIndex].DataBoundItem as VENPY_PriceListDetail).CalculateIgv(Presenter.NumberDecimals, Presenter.PercentIgv);
                            (dgvPRLI_PriceListDetail.Rows[e.RowIndex].DataBoundItem as VENPY_PriceListDetail).CalculateUnitPrice(Presenter.NumberDecimals, Presenter.PercentIgv);
                            if (dgvPRLI_PriceListDetail.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null && !string.IsNullOrEmpty(dgvPRLI_PriceListDetail.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()) && dgvPRLI_PriceListDetail.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == StaticLists.TAI_Gra)
                            { dgvPRLI_PriceListDetail.Rows[e.RowIndex].Cells["PLDE_IGV"].ReadOnly = false; }
                            else
                            { dgvPRLI_PriceListDetail.Rows[e.RowIndex].Cells["PLDE_IGV"].ReadOnly = true; }
                            break;
                        case "PLDE_UnitValue":
                            (dgvPRLI_PriceListDetail.Rows[e.RowIndex].DataBoundItem as VENPY_PriceListDetail).CalculateIgv(Presenter.NumberDecimals, Presenter.PercentIgv);
                            (dgvPRLI_PriceListDetail.Rows[e.RowIndex].DataBoundItem as VENPY_PriceListDetail).CalculateUnitPrice(Presenter.NumberDecimals, Presenter.PercentIgv);
                            break;
                        case "PLDE_IGV":
                            (dgvPRLI_PriceListDetail.Rows[e.RowIndex].DataBoundItem as VENPY_PriceListDetail).CalculateUnitValue(Presenter.NumberDecimals, Presenter.PercentIgv, false);
                            (dgvPRLI_PriceListDetail.Rows[e.RowIndex].DataBoundItem as VENPY_PriceListDetail).CalculateUnitPrice(Presenter.NumberDecimals, Presenter.PercentIgv);
                            break;
                        case "PLDE_UnitPrice":
                            (dgvPRLI_PriceListDetail.Rows[e.RowIndex].DataBoundItem as VENPY_PriceListDetail).CalculateUnitValue(Presenter.NumberDecimals, Presenter.PercentIgv, true);
                            (dgvPRLI_PriceListDetail.Rows[e.RowIndex].DataBoundItem as VENPY_PriceListDetail).CalculateIgv(Presenter.NumberDecimals, Presenter.PercentIgv);
                            break;
                    }
                }
            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(Presenter.Title, "Ha ocurrido un error al calcular los valores.", ex); }

        }

        #endregion
    }
}
