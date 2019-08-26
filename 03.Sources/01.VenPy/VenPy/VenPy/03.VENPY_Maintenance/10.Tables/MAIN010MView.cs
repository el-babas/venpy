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
    public partial class MAIN010MView : Form, IMAIN010MView
    {
        #region [ PROPERTIES ]

        public MAIN010PView Presenter { get; set; }

        #endregion

        #region [ FORM ]

        public MAIN010MView()
        {
            InitializeComponent();
            btnSave.Click += new EventHandler(BtnSave_Click);
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
                cmbTBLE_Status.ValueMember = "TBLE_Code";
                cmbTBLE_Status.DisplayMember = "TBLE_Description1";
                cmbTBLE_Status.DataSource = l_ItemsTablesState;

            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(Presenter.Title, "Ha ocurrido un error al llenar los controles.", ex); }
        }
        public void CleanControls()
        {
            try
            {
                txtTBLE_Table.Text = string.Empty;
                txtTBLE_Code.Text = string.Empty;
                cmbTBLE_Status.SelectedIndex = 0;
                txtTBLE_SunatCode.Text = string.Empty;
                txtTBLE_InternationalCode.Text = string.Empty;
                txtTBLE_Description1.Text = string.Empty;
                txtTBLE_Description2.Text = string.Empty;
                txnTBLE_Number1.Value = 0;
                txnTBLE_Number2.Value = 0;
            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(Presenter.Title, "Ha ocurrido un error al limpiar el formulario.", ex); }
        }
        public void SetItem()
        {
            try
            {

                txtTBLE_Table.Text = Presenter.Item.TBLE_Table;
                txtTBLE_Code.Text = Presenter.Item.TBLE_Code;
                cmbTBLE_Status.SelectedValue = Presenter.Item.TBLE_Status;
                txtTBLE_SunatCode.Text = Presenter.Item.TBLE_SunatCode;
                txtTBLE_InternationalCode.Text = Presenter.Item.TBLE_InternationalCode;
                txtTBLE_Description1.Text = Presenter.Item.TBLE_Description1;
                txtTBLE_Description2.Text = Presenter.Item.TBLE_Description2;
                txnTBLE_Number1.Value = 0;
                if (Presenter.Item.TBLE_Number1.HasValue) { txnTBLE_Number1.Value = Presenter.Item.TBLE_Number1.Value; }
                txnTBLE_Number2.Value = 0;
                if (Presenter.Item.TBLE_Number2.HasValue) { txnTBLE_Number2.Value = Presenter.Item.TBLE_Number2.Value; }
            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(Presenter.Title, "Ha ocurrido un error al cargar el Item.", ex); }
        }
        public void GetItem()
        {
            try
            {
                Presenter.Item.BUSI_Code = SessionVariables.BusinessCode;
                Presenter.Item.TBLE_Table = txtTBLE_Table.Text;
                Presenter.Item.TBLE_Code = txtTBLE_Code.Text;
                Presenter.Item.TBLE_Status = cmbTBLE_Status.SelectedValue.ToString();
                Presenter.Item.TBLE_SunatCode = string.IsNullOrEmpty(txtTBLE_SunatCode.Text) ? null : txtTBLE_SunatCode.Text;
                Presenter.Item.TBLE_InternationalCode = string.IsNullOrEmpty(txtTBLE_InternationalCode.Text) ? null : txtTBLE_InternationalCode.Text;
                Presenter.Item.TBLE_Description1 = txtTBLE_Description1.Text;
                Presenter.Item.TBLE_Description2 = string.IsNullOrEmpty(txtTBLE_Description2.Text) ? null : txtTBLE_Description2.Text;
                Presenter.Item.TBLE_Number1 = null;
                if (txnTBLE_Number1.Value != 0) { Presenter.Item.TBLE_Number1 = Convert.ToInt32(txnTBLE_Number1.Value); }
                Presenter.Item.TBLE_Number2 = null;
                if (txnTBLE_Number2.Value != 0) { Presenter.Item.TBLE_Number2 = txnTBLE_Number2.Value; }
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

        #endregion
    }
}
