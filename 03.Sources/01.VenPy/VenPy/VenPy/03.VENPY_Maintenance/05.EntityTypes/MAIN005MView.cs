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
    public partial class MAIN005MView : Form, IMAIN005MView
    {
        #region [ PROPERTIES ]

        public MAIN005PView Presenter { get; set; }

        #endregion

        #region [ FORM ]

        public MAIN005MView()
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
                txtETYP_Code.Text = string.Empty;
                txtETYP_Name.Text = string.Empty;
                txtETYP_Description.Text = string.Empty;
                chkETYP_Active.Checked = true;
            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(Presenter.Title, "Ha ocurrido un error al limpiar el formulario.", ex); }
        }
        public void BlockControls()
        {
            try
            {
                if (!Presenter.Item.ETYP_Default || SessionVariables.UserType == StaticLists.USER_Root)
                {
                    txtETYP_Name.ReadOnly = false;
                    txtETYP_Description.ReadOnly = false;
                    chkETYP_Active.Enabled = true;
                }
                else
                {
                    txtETYP_Name.ReadOnly = true;
                    txtETYP_Description.ReadOnly = true;
                    chkETYP_Active.Enabled = false;
                }
            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(Presenter.Title, "Ha ocurrido un error al bloquear el formulario.", ex); }
        }
        public void SetItem()
        {
            try
            {
                txtETYP_Code.Text = Presenter.Item.ETYP_Code.ToString();
                txtETYP_Name.Text = Presenter.Item.ETYP_Name;
                txtETYP_Description.Text = Presenter.Item.ETYP_Description;
                chkETYP_Active.Checked = Presenter.Item.ETYP_Active;
            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(Presenter.Title, "Ha ocurrido un error al cargar el Item.", ex); }
        }
        public void GetItem()
        {
            try
            {
                Presenter.Item.BUSI_Code = SessionVariables.BusinessCode;
                Presenter.Item.ETYP_Name = txtETYP_Name.Text;
                Presenter.Item.ETYP_Description = txtETYP_Description.Text;
                Presenter.Item.ETYP_Active = chkETYP_Active.Checked;
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
