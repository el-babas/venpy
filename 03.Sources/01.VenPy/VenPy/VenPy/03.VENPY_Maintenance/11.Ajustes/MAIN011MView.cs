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
    public partial class MAIN011MView : Form, IMAIN011MView
    {
        #region [ PROPERTIES ]

        public MAIN011PView Presenter { get; set; }

        #endregion

        #region [ FORM ]

        public MAIN011MView()
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
                htxSEND.BusinessCode = SessionVariables.BusinessCode;
                htxSEND.EntityType = StaticLists.ETYP_Client;
            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(Presenter.Title, "Ha ocurrido un error al llenar los controles.", ex); }
        }
        public void CleanControls()
        {
            try
            {
                htxSEND.ClearValue();
                txnSIGV.Value = 0;
                chkSALI.Checked = false;
            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(Presenter.Title, "Ha ocurrido un error al limpiar el formulario.", ex); }
        }
        public void SetItem()
        {
            try
            {
                int l_Code;
                if (int.TryParse(Presenter.SEND.SETT_Value, out l_Code))
                { htxSEND.SetValue(l_Code); }
                if (int.TryParse(Presenter.SALI.SETT_Value, out l_Code))
                { chkSALI.Checked = l_Code == 1 ? true : false; }
                if (int.TryParse(Presenter.STCO.SETT_Value, out l_Code))
                { chkSTCO.Checked = l_Code == 1 ? true : false; }
                decimal l_Value;
                if (decimal.TryParse(Presenter.SIGV.SETT_Value, out l_Value))
                { txnSIGV.Value = l_Value; }

            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(Presenter.Title, "Ha ocurrido un error al cargar el Item.", ex); }
        }
        public void GetItem()
        {
            try
            {
                if (htxSEND.Value != null)
                { Presenter.SEND.SETT_Value = htxSEND.Value.ENTI_Code.ToString(); }
                else { Presenter.SEND.SETT_Value = string.Empty; }
                if (chkSALI.Checked)
                { Presenter.SALI.SETT_Value = "1"; }
                else { Presenter.SALI.SETT_Value = "0"; }
                if (chkSTCO.Checked)
                { Presenter.STCO.SETT_Value = "1"; }
                else { Presenter.STCO.SETT_Value = "0"; }
                if (txnSIGV.Value >= (decimal)0.0)
                { Presenter.SIGV.SETT_Value = txnSIGV.Value.ToString(); }
                else { Presenter.SIGV.SETT_Value = string.Empty; }
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
