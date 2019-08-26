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
    public partial class MAIN010LView : UserControl, IMAIN010LView
    {
        #region [ PROPERTIES ]

        public TabPage TabPageControl { get; set; }
        public MAIN010PView Presenter { get; set; }
        public BindingSource BSItems { get; set; }

        #endregion

        #region [ FORM ]

        public MAIN010LView(TabPage p_tabPageControl)
        {
            TabPageControl = p_tabPageControl;
            InitializeComponent();
            BSItems = new BindingSource();
            btnClose.Click += new EventHandler(BtnClose_Click);
            btnSearch.Click += new EventHandler(BtnSearch_Click);
            btnNew.Click += new EventHandler(BtnNew_Click);
            btnExport.Click += new EventHandler(BtnExport_Click);
            dgvItems.CellDoubleClick += new DataGridViewCellEventHandler(DgvItems_CellDoubleClick);
            cmbTBLE_Table.SelectedIndexChanged += new EventHandler(CmbTBLE_Table_SelectedIndexChanged);
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
                    ObservableCollection<VENPY_Tables> l_ItemsTDI = new ObservableCollection<VENPY_Tables>();
                    l_ItemsTDI = Presenter.ItemsTables.Where(Table => Table.BUSI_Code == SessionVariables.BusinessCode && Table.TBLE_Table == StaticLists.TBLE_TAB).ToObservableCollection();
                    if (l_ItemsTDI == null || l_ItemsTDI.Count == 0)
                    { Messages.ShowWarningMessage(Presenter.Title, "No se ha encontrado ninguna Tabla, puede que esto ocasione errores."); }
                    else
                    {
                        cmbTBLE_Table.ValueMember = "TBLE_Code";
                        cmbTBLE_Table.DisplayMember = "TBLE_Description1";
                        cmbTBLE_Table.DataSource = l_ItemsTDI;
                    }  
                }
            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(Presenter.Title, "Ha ocurrido un error al llenar los controles.", ex); }
        }
        public void Search()
        {
            try
            {
                CleanDataGridView();
                Presenter.Search(cmbTBLE_Table.SelectedValue.ToString());
                FillDataGridView();
            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(Presenter.Title, "Ha ocurrido un error al buscar.", ex); }
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
        private void CreateGridColumns()
        {
            try
            {
                dgvItems.Columns.Clear();
                dgvItems.AutoGenerateColumns = false;
                dgvItems.MultiSelect = false;
                dgvItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvItems.AllowUserToAddRows = false;
                dgvItems.AllowUserToDeleteRows = false;
                dgvItems.AllowUserToResizeRows = false;
                dgvItems.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(188, 230, 246);
                dgvItems.AddImageColumn("EDITAR", "Edit", "Edit", 75, Properties.Resources.edit_16x16, null, DataGridViewContentAlignment.MiddleCenter);
                dgvItems.AddImageColumn("ELIMINAR", "Delete", "Delete", 75, Properties.Resources.remove_16x16, null, DataGridViewContentAlignment.MiddleCenter);
                dgvItems.AddTextBoxColumn("TABLA", "TBLE_Table", "TBLE_Table", 100, true, null, DataGridViewContentAlignment.MiddleCenter);
                dgvItems.AddTextBoxColumn("CODIGO", "TBLE_Code", "TBLE_Code", 100, true, null, DataGridViewContentAlignment.MiddleCenter);
                dgvItems.AddTextBoxColumn("DESCRIPCION", "TBLE_Description1", "TBLE_Description1", 300, true, null, DataGridViewContentAlignment.MiddleLeft);
                dgvItems.AddTextBoxColumn("ESTADO", "TBLE_NameStatus", "TBLE_NameStatus", 150, true, null, DataGridViewContentAlignment.MiddleCenter);

                dgvItems.AddCheckBoxColumn("DEFECTO", "TBLE_Default", "TBLE_Default", 200, true);
                dgvItems.Columns["TBLE_Default"].Visible = false;
                dgvItems.AddTextBoxColumn("CÓDIGO EMPRESA", "BUSI_Code", "BUSI_Code", 500, true, null, DataGridViewContentAlignment.MiddleCenter);
                dgvItems.Columns["BUSI_Code"].Visible = false;
            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(Presenter.Title, "Ha ocurrido un error al dar formato a la Lista de Elementos del formulario.", ex); }
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
                {
                    dgvItems.Enabled = false;
                    btnExport.Enabled = false;
                    Messages.ShowInformationMessage(Presenter.Title, "No se encontrarón registros");
                }
            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(Presenter.Title, "Ha ocurrido un error al llenar la grilla.", ex); }
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
        private void SelectItem()
        {
            try
            {
                if (Presenter != null)
                {
                    if (BSItems != null && BSItems.Current != null && BSItems.Current is VENPY_Tables)
                    { Presenter.ItemGridView = ((VENPY_Tables)BSItems.Current); }
                    else
                    { Presenter.ItemGridView = null; }
                }
            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(Presenter.Title, "Ha ocurrido un error al seleccionar un Item de la grilla.", ex); }
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
        private void BtnNew_Click(object sender, EventArgs e)
        {
            try
            {
                Presenter.New(cmbTBLE_Table.SelectedValue.ToString());
            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(Presenter.Title, "Ocurrio un error al crear un nuevo Item.", ex); }
        }
        private void DgvItems_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                switch (dgvItems.Columns[e.ColumnIndex].Name)
                {
                    case "Edit":
                        SelectItem();
                        Presenter.Edit();
                        break;
                    case "Delete":
                        SelectItem();
                        if (Presenter.Delete())
                        { Presenter.RefreshItems(); }
                        break;
                }
            }
            catch (Exception ex)
            { throw ex; }
        }
        private void CmbTBLE_Table_SelectedIndexChanged(object sender, EventArgs e)
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

        #endregion
    }
}
