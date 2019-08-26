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
    public partial class SALE002LView : UserControl, ISALE002LView
    {
        #region [ PROPERTIES ]

        public TabPage TabPageControl { get; set; }
        public SALE002PView Presenter { get; set; }
        public BindingSource BSItems { get; set; }

        #endregion

        #region [ FORM ]

        public SALE002LView(TabPage p_tabPageControl)
        {
            TabPageControl = p_tabPageControl;
            InitializeComponent();
            BSItems = new BindingSource();
            btnClose.Click += new EventHandler(BtnClose_Click);
            btnSave.Click += new EventHandler(BtnSave_Click);
            btnNew.Click += new EventHandler(BtnNew_Click);
            btnExport.Click += new EventHandler(BtnExport_Click);
            dgvItems.CellDoubleClick += new DataGridViewCellEventHandler(DgvItems_CellDoubleClick);
            cmbTBLE_CodeTDO.SelectedIndexChanged += new EventHandler(CmbTBLE_CodeTDO_SelectedIndexChanged);
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
                if (Presenter.ItemsTables != null && Presenter.ItemsTables.Count > 0)
                {
                    ObservableCollection<VENPY_Tables> l_ItemsTDO = new ObservableCollection<VENPY_Tables>();
                    l_ItemsTDO = Presenter.ItemsTables.Where(Table => Table.BUSI_Code == SessionVariables.BusinessCode && Table.TBLE_Table == StaticLists.TBLE_TDO && Table.TBLE_Default == true).ToObservableCollection();
                    if (l_ItemsTDO == null || l_ItemsTDO.Count == 0)
                    { Messages.ShowWarningMessage(Presenter.Title, "No se ha encontrado ningun Tipo de Documento, puede que esto ocasione errores."); }
                    else
                    {
                        cmbTBLE_CodeTDO.ValueMember = "TBLE_Code";
                        cmbTBLE_CodeTDO.DisplayMember = "TBLE_Description1";
                        cmbTBLE_CodeTDO.DataSource = l_ItemsTDO;
                    }
                }
            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(Presenter.Title, "Ha ocurrido un error al llenar los controles.", ex); }
        }
        private void CreateGridColumns()
        {
            try
            {
                ObservableCollection<VENPY_Tables> l_ItemsTDO = new ObservableCollection<VENPY_Tables>();
                l_ItemsTDO = Presenter.ItemsTables.Where(Table => Table.BUSI_Code == SessionVariables.BusinessCode && Table.TBLE_Table == StaticLists.TBLE_TDO && Table.TBLE_Default == true).ToObservableCollection();
                if (l_ItemsTDO == null || l_ItemsTDO.Count == 0)
                { l_ItemsTDO = new ObservableCollection<VENPY_Tables>(); }
                l_ItemsTDO.Insert(0, new VENPY_Tables { TBLE_Code = "0", TBLE_Description1 = "<Seleccionar Documento>" });

                dgvItems.Columns.Clear();
                dgvItems.AutoGenerateColumns = false;
                dgvItems.MultiSelect = false;
                dgvItems.SelectionMode = DataGridViewSelectionMode.CellSelect;
                dgvItems.AllowUserToAddRows = false;
                dgvItems.AllowUserToDeleteRows = false;
                dgvItems.AllowUserToResizeRows = true;
                dgvItems.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(188, 230, 246);
                dgvItems.AddImageColumn("", "Delete", "Delete", 35, Properties.Resources.remove_16x16, null, DataGridViewContentAlignment.MiddleCenter);
                dgvItems.AddComboBoxColumn("TIPO DE DOCUMENTO", "TBLE_CodeTDO", "TBLE_CodeTDO", 220, false, l_ItemsTDO.ToDataTable(), "TBLE_Description1", "TBLE_Code");
                dgvItems.AddTextBoxColumn("SERIE", "SERI_Serie", "SERI_Serie", 150, false, null, DataGridViewContentAlignment.MiddleLeft);
                dgvItems.AddTextBoxNumericColumn("NUMERO ACTUAL", "SERI_Number", "SERI_Number", 120, false, DataGridViewContentAlignment.MiddleRight, 10, 0);
                dgvItems.AddTextBoxColumn("DESCRIPCION", "SERI_Description", "SERI_Description", 350, false, null, DataGridViewContentAlignment.MiddleLeft);

                dgvItems.AddTextBoxColumn("CÓDIGO", "SERI_Code", "SERI_Code", 50, true, null, DataGridViewContentAlignment.MiddleCenter);
                dgvItems.Columns["SERI_Code"].Visible = false;
                dgvItems.AddTextBoxColumn("CÓDIGO EMPRESA", "BUSI_Code", "BUSI_Code", 50, true, null, DataGridViewContentAlignment.MiddleCenter);
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
                }
                else
                { Messages.ShowInformationMessage(Presenter.Title, "No se encontrarón registros"); }
            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(Presenter.Title, "Ha ocurrido un error al llenar la grilla.", ex); }
        }
        public void GetItem()
        {
            try
            {
                Presenter.Items = (BSItems.DataSource as ObservableCollection<VENPY_Series>);
            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(Presenter.Title, "Ha ocurrido un error al obtener el Item.", ex); }
        }
        public void Search()
        {
            try
            {
                dgvItems.EndEdit();
                CleanDataGridView();
                Presenter.Search(StaticLists.TBLE_TDO, cmbTBLE_CodeTDO.SelectedValue.ToString());
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
        private void Remove()
        {
            try
            {
                if (BSItems.Current != null && BSItems.Current is VENPY_Series)
                {
                    var l_item = ((VENPY_Series)BSItems.Current);
                    if (l_item.Instance != InstanceEntity.Insert)
                    {
                        if (SessionVariables.UserType == StaticLists.USER_Root || SessionVariables.UserType == StaticLists.USER_Administrator)
                        {
                            if (Presenter.ItemsDelete == null) { Presenter.ItemsDelete = new ObservableCollection<VENPY_Series>(); }
                            Presenter.ItemsDelete.Add(l_item);
                        }
                        else
                        {
                            Messages.ShowWarningMessage(Presenter.Title, "No se puede eliminar el Item seleccionado, porque no tiene los permisos necesarios");
                        }
                    }
                    BSItems.RemoveCurrent();
                    BSItems.ResetBindings(true);
                }

            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(Presenter.Title, "Ha ocurrido un error al eliminar un detalle.", ex); }
        }
        private void New()
        {
            try
            {
                VENPY_Series l_Series = new VENPY_Series();
                l_Series.BUSI_Code = SessionVariables.BusinessCode;
                l_Series.TBLE_TableTDO = StaticLists.TBLE_TDO;
                l_Series.TBLE_CodeTDO = cmbTBLE_CodeTDO.SelectedValue.ToString();
                l_Series.SERI_Number = 0;
                l_Series.AUDI_CreationUser = SessionVariables.UserName;
                l_Series.AUDI_ModificationUser = SessionVariables.UserName;
                l_Series.Instance = InstanceEntity.Insert;
                ((ObservableCollection<VENPY_Series>)BSItems.DataSource).Add(l_Series);
                BSItems.ResetBindings(true);
            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(Presenter.Title, "Ha ocurrido un error al agregar un detalle.", ex); }
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
        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                if (Presenter.Save())
                { Search(); }
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
        private void BtnNew_Click(object sender, EventArgs e)
        {
            try
            {
                New();
            }
            catch (Exception ex)
            { throw ex; }
        }
        private void DgvItems_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            CustomGridViewTextBoxNumeric l_CustomGridViewTextBoxNumeric = null;
            if (dgvItems.CurrentCell != null && dgvItems.CurrentCell.OwningColumn != null)
            {
                switch (dgvItems.CurrentCell.OwningColumn.Name)
                {
                    case "SERI_Number":
                        l_CustomGridViewTextBoxNumeric = (CustomDataGridViewTextBoxNumeric)e.Control;
                        l_CustomGridViewTextBoxNumeric.Entire = 10;
                        l_CustomGridViewTextBoxNumeric.Decimals = 0;
                        l_CustomGridViewTextBoxNumeric.Negative = false;
                        if (dgvItems.CurrentCell.Value != null)
                        { l_CustomGridViewTextBoxNumeric.Text = dgvItems.CurrentCell.Value.ToString(); }
                        break;
                }
            }
        }
        private void CmbTBLE_CodeTDO_SelectedIndexChanged(object sender, EventArgs e)
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
        private void DgvItems_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                switch (dgvItems.Columns[e.ColumnIndex].Name)
                {
                    case "Delete":
                        Remove();
                        break;
                }
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion
    }
}
