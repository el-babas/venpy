using System;
using System.Collections.Generic;
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
    public partial class MAIN001MView : Form, IMAIN001MView
    {
        #region [ PROPERTIES ]

        public MAIN001PView Presenter { get; set; }

        #endregion

        #region [ FORM ]

        public MAIN001MView()
        {
            InitializeComponent();
            btnSave.Click += new EventHandler(BtnSave_Click);
        }
        public void MViewLoad()
        {
            try
            {
                CleanControls();
            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(Presenter.Title, "Ha ocurrido un error cargando la vista.", ex); }
        }

        #endregion

        #region [ METHODS ]

        public void CleanControls()
        {
            try
            {
                txtUBIG_Code.Text = string.Empty;
                txtUBIG_ParentCode.Text = string.Empty;
                txtUBIG_SunatCode.Text = string.Empty;
                txtUBIG_InternationalCode.Text = string.Empty;
                txtUBIG_Description.Text = string.Empty;
                txtUBIG_Observations.Text = string.Empty;
            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(Presenter.Title, "Ha ocurrido un error al limpiar el formulario.", ex); }
        }
        public void SetItem()
        {
            try
            {
                txtUBIG_Code.Text = Presenter.Item.UBIG_Code;
                txtUBIG_ParentCode.Text = Presenter.Item.UBIG_ParentCode;
                txtUBIG_SunatCode.Text = Presenter.Item.UBIG_SunatCode;
                txtUBIG_InternationalCode.Text = Presenter.Item.UBIG_InternationalCode;
                txtUBIG_Description.Text = Presenter.Item.UBIG_Description;
                txtUBIG_Observations.Text = Presenter.Item.UBIG_Observations;
            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(Presenter.Title, "Ha ocurrido un error al cargar el Item.", ex); }
        }
        public void GetItem()
        {
            try
            {
                Presenter.Item.UBIG_Code = txtUBIG_Code.Text;
                Presenter.Item.UBIG_ParentCode = string.IsNullOrEmpty(txtUBIG_ParentCode.Text) ? null : txtUBIG_ParentCode.Text;
                Presenter.Item.UBIG_SunatCode = txtUBIG_SunatCode.Text;
                Presenter.Item.UBIG_InternationalCode = txtUBIG_InternationalCode.Text;
                Presenter.Item.UBIG_Description = txtUBIG_Description.Text;
                Presenter.Item.UBIG_Observations = txtUBIG_Observations.Text;
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
                    Presenter.Refresh();
                    Close();
                }
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(Presenter.Title, "Ha ocurrido un error al guardar el Item.", ex); }
        }

        #endregion
    }
}
