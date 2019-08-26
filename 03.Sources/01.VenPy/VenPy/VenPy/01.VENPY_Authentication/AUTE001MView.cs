using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VenPy.Controls;

namespace VenPy.Main
{
    public partial class AUTE001MView : Form
    {
        #region [ PROPERTIES ]

        public AUTE001PView Presenter { get; set; }

        #endregion

        #region [ FORM ]

        public AUTE001MView()
        {
            InitializeComponent();
        }

        #endregion

        #region [ EVENTS ]

        private void BtnAccept_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Presenter.ValidateUser(txtUser.Text, txtPassword.Text))
                {
                    txtUser.Text = string.Empty;
                    txtPassword.Text = string.Empty;
                    Messages.ShowInformationMessage(Presenter.Title, "Usuario y/o Contraseña Incorrecta");
                    txtUser.Focus();
                }
                else
                { Close(); }
            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(Presenter.Title, "Ha ocurrido un error al aceptar", ex); }
        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                Presenter.SignOff = true;
                Close();
            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(Presenter.Title, "Ha ocurrido un error al cancelar", ex); }
        }

        #endregion

    }
}
