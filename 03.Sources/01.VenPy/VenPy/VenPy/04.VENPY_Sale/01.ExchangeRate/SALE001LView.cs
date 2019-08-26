using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.Windows.Forms;
using VenPy.Controls;
using VenPy.Connection;
using VenPy.Entities;
using VenPy.Class;

namespace VenPy.Main
{
    public partial class SALE001LView : UserControl, ISALE001LView
    {
        #region [ PROPERTIES ]

        public TabPage TabPageControl { get; set; }
        public SALE001PView Presenter { get; set; }
        public BindingSource BSItems { get; set; }

        #endregion

        #region [ FORM ]

        public SALE001LView(TabPage p_tabPageControl)
        {
            TabPageControl = p_tabPageControl;
            InitializeComponent();
            BSItems = new BindingSource();
            btnClose.Click += new EventHandler(BtnClose_Click);
            btnSearch.Click += new EventHandler(BtnSearch_Click);
            btnExport.Click += new EventHandler(BtnExport_Click);
            dgvItems.CellBeginEdit += new DataGridViewCellCancelEventHandler(DgvItems_CellBeginEdit);
            dgvItems.CellEndEdit += new DataGridViewCellEventHandler(DgvItems_CellEndEdit);
            cmbEXRA_Month.SelectedIndexChanged += new EventHandler(CmbEXRA_Month_SelectedIndexChanged);
        }
        public void LViewLoad()
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

        public void LoadControls()
        {
            try
            {
                ObservableCollection<VENPY_Tables> l_tablesYear = new ObservableCollection<VENPY_Tables>();
                for (int anio = DateTime.Now.Year - 2; anio <= DateTime.Now.Year + 2; anio++)
                {
                    l_tablesYear.Add(new VENPY_Tables { TBLE_Table = "ANO", TBLE_Code = anio.ToString(), TBLE_Description1 = anio.ToString() });
                }
                cmbEXRA_Year.DataSource = l_tablesYear;
                cmbEXRA_Year.ValueMember = "TBLE_Code";
                cmbEXRA_Year.DisplayMember = "TBLE_Description1";
                cmbEXRA_Year.SelectedValue = DateTime.Now.Year.ToString();

                ObservableCollection<VENPY_Tables> l_tablesMonth = new ObservableCollection<VENPY_Tables>();
                l_tablesMonth.Add(new VENPY_Tables { TBLE_Table = "MES", TBLE_Code = "1", TBLE_Description1 = "Enero" });
                l_tablesMonth.Add(new VENPY_Tables { TBLE_Table = "MES", TBLE_Code = "2", TBLE_Description1 = "Febrero" });
                l_tablesMonth.Add(new VENPY_Tables { TBLE_Table = "MES", TBLE_Code = "3", TBLE_Description1 = "Marzo" });
                l_tablesMonth.Add(new VENPY_Tables { TBLE_Table = "MES", TBLE_Code = "4", TBLE_Description1 = "Abril" });
                l_tablesMonth.Add(new VENPY_Tables { TBLE_Table = "MES", TBLE_Code = "5", TBLE_Description1 = "Mayo" });
                l_tablesMonth.Add(new VENPY_Tables { TBLE_Table = "MES", TBLE_Code = "6", TBLE_Description1 = "Junio" });
                l_tablesMonth.Add(new VENPY_Tables { TBLE_Table = "MES", TBLE_Code = "7", TBLE_Description1 = "Julio" });
                l_tablesMonth.Add(new VENPY_Tables { TBLE_Table = "MES", TBLE_Code = "8", TBLE_Description1 = "Agosto" });
                l_tablesMonth.Add(new VENPY_Tables { TBLE_Table = "MES", TBLE_Code = "9", TBLE_Description1 = "Setiembre" });
                l_tablesMonth.Add(new VENPY_Tables { TBLE_Table = "MES", TBLE_Code = "10", TBLE_Description1 = "Octubre" });
                l_tablesMonth.Add(new VENPY_Tables { TBLE_Table = "MES", TBLE_Code = "11", TBLE_Description1 = "Noviembre" });
                l_tablesMonth.Add(new VENPY_Tables { TBLE_Table = "MES", TBLE_Code = "12", TBLE_Description1 = "Diciembre" });
                cmbEXRA_Month.DataSource = l_tablesMonth;
                cmbEXRA_Month.ValueMember = "TBLE_Code";
                cmbEXRA_Month.DisplayMember = "TBLE_Description1";
                cmbEXRA_Month.SelectedValue = DateTime.Now.Month.ToString();
            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(Presenter.Title, "Ha ocurrido un error al llenar los controles.", ex); }
        }
        private void CreateGridColumns()
        {
            try
            {
                dgvItems.Columns.Clear();
                dgvItems.AutoGenerateColumns = false;
                dgvItems.MultiSelect = false;
                dgvItems.SelectionMode = DataGridViewSelectionMode.CellSelect;
                dgvItems.AllowUserToAddRows = false;
                dgvItems.AllowUserToDeleteRows = false;
                dgvItems.AllowUserToResizeRows = true;
                dgvItems.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(188, 230, 246);
                dgvItems.AddTextBoxColumn("FECHA", "EXRA_DateFormat", "EXRA_DateFormat", 150, true, null, DataGridViewContentAlignment.MiddleCenter);
                dgvItems.AddTextBoxNumericColumn("COMPRA OFICIAL", "EXRA_OfficialPurchase", "EXRA_OfficialPurchase", 150, false, DataGridViewContentAlignment.MiddleRight, 7, 3);
                dgvItems.AddTextBoxNumericColumn("VENTA OFICIAL", "EXRA_OfficialSale", "EXRA_OfficialSale", 150, false, DataGridViewContentAlignment.MiddleRight, 7, 3);
                dgvItems.AddTextBoxNumericColumn("COMPRA", "EXRA_InternalPurchase", "EXRA_InternalPurchase", 150, false, DataGridViewContentAlignment.MiddleRight, 7, 3);
                dgvItems.AddTextBoxNumericColumn("VENTA", "EXRA_InternalSale", "EXRA_InternalSale", 150, false, DataGridViewContentAlignment.MiddleRight, 7, 3);

                dgvItems.AddTextBoxColumn("CÓDIGO EMPRESA", "BUSI_Code", "BUSI_Code", 500, true, null, DataGridViewContentAlignment.MiddleCenter);
                dgvItems.Columns["BUSI_Code"].Visible = false;

                dgvItems.EditingControlShowing += new DataGridViewEditingControlShowingEventHandler(DgvItems_EditingControlShowing);
            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(Presenter.Title, "Ha ocurrido un error al dar formato a la Lista de Elementos del formulario.", ex); }
        }
        private void CleanDataGridView()
        {
            try
            {
                BSItems.DataSource = null;
                dgvItems.DataSource = BSItems;
                navItems.BindingSource = BSItems;
                BSItems.ResetBindings(true);
                dgvItems.Enabled = false;
            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(Presenter.Title, "Ha ocurrido un error al limpiar la grilla.", ex); }
        }
        private void FillDataGridView()
        {
            try
            {
                BSItems.DataSource = Presenter.Items;
                dgvItems.DataSource = BSItems;
                BSItems.ResetBindings(true);
                dgvItems.Enabled = true;
                if (Presenter.Items != null && Presenter.Items.Count > 0)
                {
                    btnExport.Enabled = true;
                    dgvItems.Enabled = true;
                    dgvItems.Refresh();
                    dgvItems.ClearSelection();

                    if (Presenter.Items.Where(query => query.EXRA_Date == DateTime.Now.Date).FirstOrDefault() != null)
                    {
                        dgvItems.Rows[DateTime.Now.Day - 1].Selected = true;
                        dgvItems.CurrentCell = dgvItems[1, DateTime.Now.Day - 1];
                        dgvItems.Focus();
                    }
                }
                else
                {
                    dgvItems.Enabled = false;
                    btnExport.Enabled = false;
                    Messages.ShowInformationMessage(Presenter.Title, "No se encontrarón registros");
                }
            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(Presenter.Title, "Ha ocurrido un error al llenar la grilla.", ex); }
        }
        public void Search()
        {
            try
            {
                dgvItems.EndEdit();
                CleanDataGridView();
                Presenter.Search(cmbEXRA_Year.SelectedValue.ToString(), cmbEXRA_Month.SelectedValue.ToString());
                FillDataGridView();
            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(Presenter.Title, "Ha ocurrido un error al buscar.", ex); }
        }
        private void Export()
        {
            try
            {
                if (Presenter.Items != null && Presenter.Items.Count > 0)
                {
                    List<String> l_subTitles = new List<String>();
                    l_subTitles.Add(String.Empty);
                    l_subTitles.Add(String.Format("EMPRESA : {0}", SessionVariables.BusinessName));
                    l_subTitles.Add(String.Format("USUARIO : {0}", SessionVariables.UserFullName));
                    l_subTitles.Add(String.Format("FECHA Y HORA : {0}", DateTime.Now.ToString("dd/MM/yyyy HH:mm")));
                    l_subTitles.Add(String.Empty);

                    VENPY_PersonalConfiguration l_PersonalConfiguration = new VENPY_PersonalConfiguration();
                    l_PersonalConfiguration = TemporaryFiles.DeserializePersonalConfiguration().Where(filter => filter.BUSI_Code == SessionVariables.BusinessCode && filter.USER_Code == SessionVariables.UserCode && filter.PCON_Key == StaticLists.PCON_Export).FirstOrDefault();
                    if (l_PersonalConfiguration == null || l_PersonalConfiguration.PCON_Value.Equals("0"))
                    {
                        l_PersonalConfiguration = TemporaryFiles.DeserializePersonalConfiguration().Where(filter => filter.BUSI_Code == SessionVariables.BusinessCode && filter.USER_Code == SessionVariables.UserCode && filter.PCON_Key == StaticLists.PCON_MaxRows).FirstOrDefault();
                        Int32 l_maxrows = l_PersonalConfiguration == null ? 0 : Convert.ToInt32(l_PersonalConfiguration.PCON_Value);
                        if (l_maxrows >= dgvItems.Rows.Count)
                        { ExportTextFile.ExportToTextFile(Presenter.Title, dgvItems, l_subTitles); }
                        else
                        { Messages.ShowWarningMessage(Presenter.Title, string.Format("No puede exportar un archivo .txt porque la cantidad de items es mayor a {0} ,revise su configuracion personal", l_maxrows)); }
                    }
                    else
                    { ExportExcel.ExportToExcel(Presenter.Title, dgvItems, l_subTitles); }

                }
                else
                {
                    Messages.ShowInformationMessage(Presenter.Title, "No existen Registros para Exportar.");
                }
            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(Presenter.Title, "Ocurrio un error al exportar.", ex); }
        }

        #endregion

        #region [ EVENTS ]

        public event CloseFormEventArgs.CloseFormEventHandler CloseForm;
        private void BtnClose_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                CloseForm?.Invoke(null, new CloseFormEventArgs(TabPageControl, Presenter.NameForm));
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            { throw ex; }
        }
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                Search();
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(Presenter.Title, "Ocurrio un error al ejecutar la busqueda.", ex); }
        }
        private void BtnExport_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                Export();
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(Presenter.Title, "Ocurrio un error al exportar.", ex); }
        }
        private void DgvItems_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            try
            {
                if (dgvItems.Rows[e.RowIndex].Cells["EXRA_DateFormat"].Value != null)
                {
                    DateTime l_date;
                    if (DateTime.TryParse(dgvItems.Rows[e.RowIndex].Cells["EXRA_DateFormat"].Value.ToString(), out l_date))
                    {
                        if (Convert.ToDateTime(DateTime.Now.ToShortDateString()).CompareTo(Convert.ToDateTime(l_date.ToShortDateString())) <= 0)
                        { dgvItems.Rows[e.RowIndex].ReadOnly = false; }
                        else
                        { dgvItems.Rows[e.RowIndex].ReadOnly = true; }
                    }
                    else
                    { dgvItems.Rows[e.RowIndex].ReadOnly = true; }
                }
                else
                { dgvItems.Rows[e.RowIndex].ReadOnly = true; }
            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(Presenter.Title, "Ha ocurrido un error al abrir la edicion de la Celda.", ex); }
        }
        private void DgvItems_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if ((VENPY_ExchangeRate)(((DataGridView)(sender)).CurrentRow.DataBoundItem) != null)
                {
                    Presenter.Item = (VENPY_ExchangeRate)(((DataGridView)(sender)).CurrentRow.DataBoundItem);
                    if (Presenter.Save())
                    { Presenter.Item.Instance = InstanceEntity.Update; }
                }
            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(Presenter.Title, "Ocurrio un error al editar la celda.", ex); }
        }
        private void DgvItems_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            CustomGridViewTextBoxNumeric l_CustomGridViewTextBoxNumeric = null;
            if (dgvItems.CurrentCell != null && dgvItems.CurrentCell.OwningColumn != null)
            {
                switch (dgvItems.CurrentCell.OwningColumn.Name)
                {
                    case "EXRA_OfficialPurchase":
                    case "EXRA_OfficialSale":
                    case "EXRA_InternalPurchase":
                    case "EXRA_InternalSale":
                        l_CustomGridViewTextBoxNumeric = (CustomDataGridViewTextBoxNumeric)e.Control;
                        l_CustomGridViewTextBoxNumeric.Entire = 7;
                        l_CustomGridViewTextBoxNumeric.Decimals = 3;
                        l_CustomGridViewTextBoxNumeric.Negative = false;
                        if (dgvItems.CurrentCell.Value != null)
                        { l_CustomGridViewTextBoxNumeric.Text = dgvItems.CurrentCell.Value.ToString(); }
                        break;
                }
            }
        }
        private void CmbEXRA_Month_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(cmbEXRA_Month.SelectedValue.ToString()) && cmbEXRA_Month.SelectedValue.ToString().Length < 3)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    Search();
                    Cursor.Current = Cursors.Default;
                }
            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(Presenter.Title, "Ocurrio un error al ejecutar la busqueda.", ex); }
        }

        #endregion
    }
}
