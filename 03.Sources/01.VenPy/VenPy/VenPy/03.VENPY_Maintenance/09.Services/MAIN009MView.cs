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
    public partial class MAIN009MView : Form, IMAIN009MView
    {
        #region [ PROPERTIES ]

        public MAIN009PView Presenter { get; set; }
        public BindingSource BSPROD_MeasurementUnitsProducts { get; set; }

        #endregion

        #region [ FORM ]

        public MAIN009MView()
        {
            InitializeComponent();
            BSPROD_MeasurementUnitsProducts = new BindingSource();
            btnSave.Click += new EventHandler(BtnSave_Click);
            cmbTBLE_CodeTAI.SelectedIndexChanged += new EventHandler(CmbTBLE_CodeTAI_SelectedIndexChanged);
            txnSERV_UnitValue.ValueChanged += new EventHandler(TxnSERV_UnitValue_ValueChanged);
            txnSERV_IGV.ValueChanged += new EventHandler(TxnSERV_IGV_ValueChanged);
            txnSERV_UnitPrice.ValueChanged += new EventHandler(TxnSERV_UnitPrice_ValueChanged);
        }
        public void MViewLoad()
        {
            try
            {
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
                    ObservableCollection<VENPY_Tables> l_ItemsFAS = new ObservableCollection<VENPY_Tables>();
                    l_ItemsFAS = Presenter.ItemsTables.Where(Table => Table.BUSI_Code == SessionVariables.BusinessCode && Table.TBLE_Table == StaticLists.TBLE_FAS).ToObservableCollection();
                    if (l_ItemsFAS == null || l_ItemsFAS.Count == 0)
                    {
                        l_ItemsFAS = new ObservableCollection<VENPY_Tables>();
                    }
                    else
                    {
                        l_ItemsFAS.Insert(0, new VENPY_Tables { TBLE_Code = "0", TBLE_Description1 = "<Seleccionar Familia>" });
                        cmbTBLE_CodeFAS.ValueMember = "TBLE_Code";
                        cmbTBLE_CodeFAS.DisplayMember = "TBLE_Description1";
                        cmbTBLE_CodeFAS.DataSource = l_ItemsFAS;
                    }

                    ObservableCollection<VENPY_Tables> l_ItemsUNM = new ObservableCollection<VENPY_Tables>();
                    l_ItemsUNM = Presenter.ItemsTables.Where(Table => Table.BUSI_Code == SessionVariables.BusinessCode && Table.TBLE_Table == StaticLists.TBLE_UNM).ToObservableCollection();
                    if (l_ItemsUNM == null || l_ItemsUNM.Count == 0)
                    {
                        Messages.ShowWarningMessage(Presenter.Title, "No se ha encontrado ninguna Unidad de Medida, puede que esto ocasione errores.");
                        l_ItemsUNM = new ObservableCollection<VENPY_Tables>();
                    }
                    else
                    {
                        l_ItemsUNM.Insert(0, new VENPY_Tables { TBLE_Code = "0", TBLE_Description1 = "<Seleccionar Uni. Medida>" });
                        cmbTBLE_CodeUNM.ValueMember = "TBLE_Code";
                        cmbTBLE_CodeUNM.DisplayMember = "TBLE_Description1";
                        cmbTBLE_CodeUNM.DataSource = l_ItemsUNM;
                    }

                    ObservableCollection<VENPY_Tables> l_ItemsMND = new ObservableCollection<VENPY_Tables>();
                    l_ItemsMND = Presenter.ItemsTables.Where(Table => Table.BUSI_Code == SessionVariables.BusinessCode && Table.TBLE_Table == StaticLists.TBLE_MND).ToObservableCollection();
                    if (l_ItemsMND == null || l_ItemsMND.Count == 0)
                    {
                        Messages.ShowWarningMessage(Presenter.Title, "No se ha encontrado ninguna Moneda, puede que esto ocasione errores.");
                        l_ItemsMND = new ObservableCollection<VENPY_Tables>();
                    }
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
                    {
                        Messages.ShowWarningMessage(Presenter.Title, "No se ha encontrado ningun Tipo de Afectación de IGV, puede que esto ocasione errores.");
                        l_ItemsTAI = new ObservableCollection<VENPY_Tables>();
                    }
                    else
                    {
                        l_ItemsTAI.Insert(0, new VENPY_Tables { TBLE_Code = "0", TBLE_Description1 = "<Seleccionar Afec. IGV>" });
                        cmbTBLE_CodeTAI.ValueMember = "TBLE_Code";
                        cmbTBLE_CodeTAI.DisplayMember = "TBLE_Description1";
                        cmbTBLE_CodeTAI.DataSource = l_ItemsTAI;
                    }
                }
                txnSERV_UnitValue.Standars = FormatStandards.Decimal;
                txnSERV_UnitValue.Negative = false;
                txnSERV_UnitValue.Entire = 20;
                txnSERV_UnitValue.Decimals = Presenter.NumberDecimals;
                txnSERV_UnitValue.Format = "###,###,##0.".PadRight(Presenter.NumberDecimals, '0');

                txnSERV_UnitPrice.Standars = FormatStandards.Decimal;
                txnSERV_UnitPrice.Negative = false;
                txnSERV_UnitPrice.Entire = 20;
                txnSERV_UnitPrice.Decimals = Presenter.NumberDecimals;
                txnSERV_UnitPrice.Format = "###,###,##0.".PadRight(Presenter.NumberDecimals, '0');

                txnSERV_IGV.Standars = FormatStandards.Decimal;
                txnSERV_IGV.Negative = false;
                txnSERV_IGV.Entire = 20;
                txnSERV_IGV.Decimals = Presenter.NumberDecimals;
                txnSERV_IGV.Format = "###,###,##0.".PadRight(Presenter.NumberDecimals, '0');

            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(Presenter.Title, "Ha ocurrido un error al llenar los controles.", ex); }
        }
        public void CleanControls()
        {
            try
            {
                txtSERV_Code.Text = string.Empty;
                cmbTBLE_CodeFAS.SelectedIndex = 0;
                txtSERV_Name.Text = string.Empty;
                chkSERV_Active.Checked = true;
                txtSERV_Description.Text = string.Empty;
                cmbTBLE_CodeUNM.SelectedIndex = 0;
                cmbTBLE_CodeMND.SelectedIndex = 0;
                cmbTBLE_CodeTAI.SelectedIndex = 0;
                txnSERV_UnitValue.Text = "0.".PadRight(Presenter.NumberDecimals, '0');
                txnSERV_UnitPrice.Text = "0.".PadRight(Presenter.NumberDecimals, '0');
                txnSERV_IGV.Text = "0.".PadRight(Presenter.NumberDecimals, '0');
            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(Presenter.Title, "Ha ocurrido un error al limpiar el formulario.", ex); }
        }
        public void SetItem()
        {
            try
            {
                cmbTBLE_CodeTAI.SelectedIndexChanged -= CmbTBLE_CodeTAI_SelectedIndexChanged;
                txnSERV_UnitValue.ValueChanged -= TxnSERV_UnitValue_ValueChanged;
                txnSERV_IGV.ValueChanged -= TxnSERV_IGV_ValueChanged;
                txnSERV_UnitPrice.ValueChanged -= TxnSERV_UnitPrice_ValueChanged;
                txtSERV_Code.Text = Presenter.Item.SERV_Code.ToString();
                if (!string.IsNullOrEmpty(Presenter.Item.TBLE_TableFAS) && !string.IsNullOrEmpty(Presenter.Item.TBLE_CodeFAS))
                { cmbTBLE_CodeFAS.SelectedValue = Presenter.Item.TBLE_CodeFAS; }
                txtSERV_Name.Text = Presenter.Item.SERV_Name;
                chkSERV_Active.Checked = Presenter.Item.SERV_Active;
                txtSERV_Description.Text = Presenter.Item.SERV_Description;
                if (!string.IsNullOrEmpty(Presenter.Item.TBLE_TableUNM) && !string.IsNullOrEmpty(Presenter.Item.TBLE_CodeUNM))
                { cmbTBLE_CodeUNM.SelectedValue = Presenter.Item.TBLE_CodeUNM; }
                if (!string.IsNullOrEmpty(Presenter.Item.TBLE_TableMND) && !string.IsNullOrEmpty(Presenter.Item.TBLE_CodeMND))
                { cmbTBLE_CodeMND.SelectedValue = Presenter.Item.TBLE_CodeMND; }
                if (!string.IsNullOrEmpty(Presenter.Item.TBLE_TableTAI) && !string.IsNullOrEmpty(Presenter.Item.TBLE_CodeTAI))
                { cmbTBLE_CodeTAI.SelectedValue = Presenter.Item.TBLE_CodeTAI; }
                txnSERV_UnitValue.Value = Presenter.Item.SERV_UnitValue;
                txnSERV_UnitPrice.Value = Presenter.Item.SERV_UnitPrice;
                txnSERV_IGV.Value = Presenter.Item.SERV_IGV;
                cmbTBLE_CodeTAI.SelectedIndexChanged += CmbTBLE_CodeTAI_SelectedIndexChanged;
                txnSERV_UnitValue.ValueChanged += TxnSERV_UnitValue_ValueChanged;
                txnSERV_IGV.ValueChanged += TxnSERV_IGV_ValueChanged;
                txnSERV_UnitPrice.ValueChanged += TxnSERV_UnitPrice_ValueChanged;
            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(Presenter.Title, "Ha ocurrido un error al cargar el Item.", ex); }
        }
        public void GetItem()
        {
            try
            {
                Presenter.Item.BUSI_Code = SessionVariables.BusinessCode;
                Presenter.Item.TBLE_TableFAS = null;
                Presenter.Item.TBLE_CodeFAS = null;
                if (!cmbTBLE_CodeFAS.SelectedValue.ToString().Equals("0"))
                {
                    Presenter.Item.TBLE_TableFAS = StaticLists.TBLE_FAS;
                    Presenter.Item.TBLE_CodeFAS = cmbTBLE_CodeFAS.SelectedValue.ToString();
                }
                Presenter.Item.SERV_Name = txtSERV_Name.Text;
                Presenter.Item.SERV_Active = chkSERV_Active.Checked;
                Presenter.Item.SERV_Description = string.IsNullOrEmpty(txtSERV_Description.Text) ? null : txtSERV_Description.Text;
                Presenter.Item.TBLE_TableUNM = null;
                Presenter.Item.TBLE_CodeUNM = null;
                if (!cmbTBLE_CodeUNM.SelectedValue.ToString().Equals("0"))
                {
                    Presenter.Item.TBLE_TableUNM = StaticLists.TBLE_UNM;
                    Presenter.Item.TBLE_CodeUNM = cmbTBLE_CodeUNM.SelectedValue.ToString();
                }
                Presenter.Item.TBLE_TableMND = null;
                Presenter.Item.TBLE_CodeMND = null;
                if (!cmbTBLE_CodeMND.SelectedValue.ToString().Equals("0"))
                {
                    Presenter.Item.TBLE_TableMND = StaticLists.TBLE_MND;
                    Presenter.Item.TBLE_CodeMND = cmbTBLE_CodeMND.SelectedValue.ToString();
                }
                Presenter.Item.TBLE_TableTAI = null;
                Presenter.Item.TBLE_CodeTAI = null;
                if (!cmbTBLE_CodeTAI.SelectedValue.ToString().Equals("0"))
                {
                    Presenter.Item.TBLE_TableTAI = StaticLists.TBLE_TAI;
                    Presenter.Item.TBLE_CodeTAI = cmbTBLE_CodeTAI.SelectedValue.ToString();
                }
                Presenter.Item.SERV_UnitValue = txnSERV_UnitValue.Value;
                Presenter.Item.SERV_UnitPrice = txnSERV_UnitPrice.Value;
                Presenter.Item.SERV_IGV = txnSERV_IGV.Value;
                Presenter.Item.AUDI_CreationUser = SessionVariables.UserName;
                Presenter.Item.AUDI_ModificationUser = SessionVariables.UserName;
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
        private void TxnSERV_UnitPrice_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbTBLE_CodeTAI.SelectedValue != null && cmbTBLE_CodeTAI.SelectedValue.ToString() != "0")
                {
                    Presenter.Item.SERV_UnitValue = txnSERV_UnitValue.Value;
                    Presenter.Item.SERV_UnitPrice = txnSERV_UnitPrice.Value;
                    Presenter.Item.SERV_IGV = txnSERV_IGV.Value;

                    Presenter.Item.CalculateUnitValue(Presenter.NumberDecimals, Presenter.PercentIgv, true);
                    txnSERV_UnitValue.ValueChanged -= TxnSERV_UnitValue_ValueChanged;
                    txnSERV_UnitValue.Value = Presenter.Item.SERV_UnitValue;
                    txnSERV_UnitValue.ValueChanged += TxnSERV_UnitValue_ValueChanged;
                    Presenter.Item.CalculateIgv(Presenter.NumberDecimals, Presenter.PercentIgv);
                    txnSERV_IGV.ValueChanged -= TxnSERV_IGV_ValueChanged;
                    txnSERV_IGV.Value = Presenter.Item.SERV_IGV;
                    txnSERV_IGV.ValueChanged += TxnSERV_IGV_ValueChanged;
                }
            }
            catch (Exception ex)
            { throw ex; }
        }
        private void TxnSERV_IGV_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbTBLE_CodeTAI.SelectedValue != null && cmbTBLE_CodeTAI.SelectedValue.ToString() != "0")
                {
                    Presenter.Item.SERV_UnitValue = txnSERV_UnitValue.Value;
                    Presenter.Item.SERV_UnitPrice = txnSERV_UnitPrice.Value;
                    Presenter.Item.SERV_IGV = txnSERV_IGV.Value;

                    Presenter.Item.CalculateUnitValue(Presenter.NumberDecimals, Presenter.PercentIgv, false);
                    txnSERV_UnitValue.ValueChanged -= TxnSERV_UnitValue_ValueChanged;
                    txnSERV_UnitValue.Value = Presenter.Item.SERV_UnitValue;
                    txnSERV_UnitValue.ValueChanged += TxnSERV_UnitValue_ValueChanged;
                    Presenter.Item.CalculateUnitPrice(Presenter.NumberDecimals, Presenter.PercentIgv);
                    txnSERV_UnitPrice.ValueChanged -= TxnSERV_UnitPrice_ValueChanged;
                    txnSERV_UnitPrice.Value = Presenter.Item.SERV_UnitPrice;
                    txnSERV_UnitPrice.ValueChanged += TxnSERV_UnitPrice_ValueChanged;
                }
            }
            catch (Exception ex)
            { throw ex; }
        }
        private void TxnSERV_UnitValue_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbTBLE_CodeTAI.SelectedValue != null && cmbTBLE_CodeTAI.SelectedValue.ToString() != "0")
                {
                    Presenter.Item.SERV_UnitValue = txnSERV_UnitValue.Value;
                    Presenter.Item.SERV_UnitPrice = txnSERV_UnitPrice.Value;
                    Presenter.Item.SERV_IGV = txnSERV_IGV.Value;

                    Presenter.Item.CalculateIgv(Presenter.NumberDecimals, Presenter.PercentIgv);
                    txnSERV_IGV.ValueChanged -= TxnSERV_IGV_ValueChanged;
                    txnSERV_IGV.Value = Presenter.Item.SERV_IGV;
                    txnSERV_IGV.ValueChanged += TxnSERV_IGV_ValueChanged;
                    Presenter.Item.CalculateUnitPrice(Presenter.NumberDecimals, Presenter.PercentIgv);
                    txnSERV_UnitPrice.ValueChanged -= TxnSERV_UnitPrice_ValueChanged;
                    txnSERV_UnitPrice.Value = Presenter.Item.SERV_UnitPrice;
                    txnSERV_UnitPrice.ValueChanged += TxnSERV_UnitPrice_ValueChanged;
                }
            }
            catch (Exception ex)
            { throw ex; }
        }
        private void CmbTBLE_CodeTAI_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbTBLE_CodeTAI.SelectedValue != null && cmbTBLE_CodeTAI.SelectedValue.ToString() != "0")
                {
                    Presenter.Item.TBLE_TableTAI = StaticLists.TBLE_TAI;
                    Presenter.Item.TBLE_CodeTAI = cmbTBLE_CodeTAI.SelectedValue.ToString();
                    Presenter.Item.SERV_UnitValue = txnSERV_UnitValue.Value;
                    Presenter.Item.SERV_UnitPrice = txnSERV_UnitPrice.Value;
                    Presenter.Item.SERV_IGV = txnSERV_IGV.Value;

                    Presenter.Item.CalculateIgv(Presenter.NumberDecimals, Presenter.PercentIgv);
                    txnSERV_IGV.ValueChanged -= TxnSERV_IGV_ValueChanged;
                    txnSERV_IGV.Value = Presenter.Item.SERV_IGV;
                    txnSERV_IGV.ValueChanged += TxnSERV_IGV_ValueChanged;
                    Presenter.Item.CalculateUnitPrice(Presenter.NumberDecimals, Presenter.PercentIgv);
                    txnSERV_UnitPrice.ValueChanged -= TxnSERV_UnitPrice_ValueChanged;
                    txnSERV_UnitPrice.Value = Presenter.Item.SERV_UnitPrice;
                    txnSERV_UnitPrice.ValueChanged += TxnSERV_UnitPrice_ValueChanged;
                    if (cmbTBLE_CodeTAI.SelectedValue.ToString() == StaticLists.TAI_Gra)
                    { txnSERV_IGV.ReadOnly = false; }
                    else
                    { txnSERV_IGV.ReadOnly = true; }
                }
                else
                { txnSERV_IGV.ReadOnly = false; }
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion
    }
}
