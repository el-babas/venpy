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
    public partial class MAIN004MView : Form, IMAIN004MView
    {
        #region [ PROPERTIES ]

        public MAIN004PView Presenter { get; set; }

        #endregion

        #region [ FORM ]

        public MAIN004MView()
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
                l_ItemsTablesState.Add(new VENPY_Tables { TBLE_Code = "A", TBLE_Description1 = "ACTIVO"});
                l_ItemsTablesState.Add(new VENPY_Tables { TBLE_Code = "I", TBLE_Description1 = "INACTIVO" });
                l_ItemsTablesState.Add(new VENPY_Tables { TBLE_Code = "C", TBLE_Description1 = "CERRADO" });
                cmbPSAL_Status.ValueMember = "TBLE_Code";
                cmbPSAL_Status.DisplayMember = "TBLE_Description1";
                cmbPSAL_Status.DataSource = l_ItemsTablesState;

            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(Presenter.Title, "Ha ocurrido un error al llenar los controles.", ex); }
        }
        public void CleanControls()
        {
            try
            {
                txtPSAL_Code.Text = string.Empty;
                txtPSAL_Name.Text = string.Empty;
                chkPSAL_Main.Checked = false;
                cmbPSAL_Status.SelectedIndex = 0;
            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(Presenter.Title, "Ha ocurrido un error al limpiar el formulario.", ex); }
        }
        public void SetItem()
        {
            try
            {
                txtPSAL_Code.Text = Presenter.Item.PSAL_Code.ToString();
                txtPSAL_Name.Text = Presenter.Item.PSAL_Name;
                chkPSAL_Main.Checked = Presenter.Item.PSAL_Main;
                cmbPSAL_Status.SelectedValue = Presenter.Item.PSAL_Status;
                
            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(Presenter.Title, "Ha ocurrido un error al cargar el Item.", ex); }
        }
        public void GetItem()
        {
            try
            {
                Presenter.Item.BUSI_Code = SessionVariables.BusinessCode;
                Presenter.Item.BOFF_Code = SessionVariables.BranchCode;
                Presenter.Item.PSAL_Name = txtPSAL_Name.Text;
                Presenter.Item.PSAL_Main = chkPSAL_Main.Checked; 
                Presenter.Item.PSAL_Status = cmbPSAL_Status.SelectedValue.ToString();
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
