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
    public partial class MAIN007LView : UserControl, IMAIN007LView
    {
        #region [ PROPERTIES ]

        public TabPage TabPageControl { get; set; }
        public MAIN007PView Presenter { get; set; }
        public BindingSource BSItems { get; set; }

        #endregion

        #region [ FORM ]

        public MAIN007LView(TabPage p_tabPageControl)
        {
            TabPageControl = p_tabPageControl;
            InitializeComponent();
            BSItems = new BindingSource();
            btnClose.Click += new EventHandler(BtnClose_Click);
            btnSearch.Click += new EventHandler(BtnSearch_Click);
            btnNew.Click += new EventHandler(BtnNew_Click);
            btnExport.Click += new EventHandler(BtnExport_Click);
            dgvItems.CellDoubleClick += new DataGridViewCellEventHandler(DgvItems_CellDoubleClick);
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
                    ObservableCollection<VENPY_Tables> l_ItemsFAP = new ObservableCollection<VENPY_Tables>();
                    l_ItemsFAP = Presenter.ItemsTables.Where(Table => Table.BUSI_Code == SessionVariables.BusinessCode && Table.TBLE_Table == StaticLists.TBLE_FAP).ToObservableCollection();
                    if (l_ItemsFAP == null || l_ItemsFAP.Count == 0)
                    { Messages.ShowWarningMessage(Presenter.Title, "No se ha encontrado ninguna Familia de Productos, puede que esto ocasione errores."); }
                    else
                    {
                        cmbTBLE_CodeFAP.ValueMember = "TBLE_Code";
                        cmbTBLE_CodeFAP.DisplayMember = "TBLE_Description1";
                        cmbTBLE_CodeFAP.DataSource = l_ItemsFAP;
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
        public void Search()
        {
            try
            {
                String l_TBLE_TableFAP = null;
                String l_TBLE_CodeFAP = null;
                String l_TBLE_TableMAR = null;
                String l_TBLE_CodeMAR = null;
                if (!cmbTBLE_CodeFAP.SelectedValue.ToString().Equals("0"))
                {
                    l_TBLE_TableFAP = StaticLists.TBLE_FAP;
                    l_TBLE_CodeFAP = cmbTBLE_CodeFAP.SelectedValue.ToString();
                }
                if (!cmbTBLE_CodeMAR.SelectedValue.ToString().Equals("0"))
                {
                    l_TBLE_TableMAR = StaticLists.TBLE_MAR;
                    l_TBLE_CodeMAR = cmbTBLE_CodeMAR.SelectedValue.ToString();
                }
                CleanDataGridView();
                Presenter.Search(l_TBLE_TableFAP, l_TBLE_CodeFAP, l_TBLE_TableMAR, l_TBLE_CodeMAR, txtPROD_Name.Text);
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
                dgvItems.AddTextBoxColumn("FAMILIA", "TBLE_NameFAP", "TBLE_NameFAP", 150, true, null, DataGridViewContentAlignment.MiddleCenter);
                dgvItems.AddTextBoxColumn("NOMBRE", "PROD_Name", "PROD_Name", 200, true, null, DataGridViewContentAlignment.MiddleLeft);
                dgvItems.AddTextBoxColumn("UNI. MEDIDA MÍNIMA", "TBLE_NameUNM", "TBLE_NameUNM", 150, true, null, DataGridViewContentAlignment.MiddleCenter);
                dgvItems.AddTextBoxColumn("MARCA", "TBLE_NameMAR", "TBLE_NameMAR", 150, true, null, DataGridViewContentAlignment.MiddleLeft);
                dgvItems.AddCheckBoxColumn("ORIGINAL", "PROD_Original", "PROD_Original", 100, true);
                dgvItems.AddCheckBoxColumn("ACTIVO", "PROD_Active", "PROD_Active", 100, true);
                dgvItems.AddTextBoxColumn("CÓDIGO", "PROD_Code", "PROD_Code", 100, true, null, DataGridViewContentAlignment.MiddleCenter);

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
                    if (BSItems != null && BSItems.Current != null && BSItems.Current is VENPY_Products)
                    { Presenter.ItemGridView = ((VENPY_Products)BSItems.Current); }
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
                Int32 l_ETYP_Code = 0;
                if (cmbTBLE_CodeFAP.SelectedValue != null && !cmbTBLE_CodeFAP.SelectedValue.ToString().Equals("0"))
                { l_ETYP_Code = Convert.ToInt32(cmbTBLE_CodeFAP.SelectedValue.ToString()); }
                Presenter.New(l_ETYP_Code);
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

        #endregion
    }
}
