using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.IO;
using VenPy.Entities;
using VenPy.Class;
using VenPy.Controls;

namespace VenPy.Main
{
   public partial class MainForm : Form
   {
      #region [ VARIABLES ]

      private String pv_Title = "VenPy";
      private String pv_File = "cString.xml";

      #endregion

      #region [ PROPERTIES ]

      private String Title
      {
         get { return pv_Title; }
         set { pv_Title = value; }
      }

      #endregion

      #region [ FORM ]

      public MainForm()
      {
         InitializeComponent();
      }
      private void Main_Load(object sender, EventArgs e)
      {
         try
         {
            GetConnection();
            AuthenticateUser();
            FillLabels();
            GenerateTemporaryFiles();
            DrawScreen(null);
         }
         catch (Exception ex)
         { Messages.ShowErrorMessage(Title, "Ocurrio un error al iniciar el formulario", ex); }
      }

      #endregion

      #region [ CONNECTION ]

      protected void GetConnection()
      {
         try
         {
            string l_path = Application.StartupPath;
            string l_fileName = pv_File;
            string l_string = null;
            string l_dataBase = null;
            string l_server = null;
            if (VenPy.Controls.Connection.GetConnectionString(l_path, l_fileName, ref l_string, ref l_dataBase, ref l_server))
            {
               SessionVariables.ConeccionString = l_string;
               SessionVariables.Server = l_server;
               SessionVariables.DataBase = l_dataBase;
               DataAccessPersonalSQL.StartConnection(l_string);
            }
            else
            {
               if (GetConnectionString())
               {
                  if (VenPy.Controls.Connection.GetConnectionString(l_path, l_fileName, ref l_string, ref l_dataBase, ref l_server))
                  {
                     SessionVariables.ConeccionString = l_string;
                     SessionVariables.Server = l_server;
                     SessionVariables.DataBase = l_dataBase;
                     DataAccessPersonalSQL.StartConnection(l_string);
                  }
                  else
                  { Close(); Application.Exit(); }
               }
               else
               { Close(); Application.Exit(); }
            }
         }
         catch (Exception ex)
         { Messages.ShowErrorMessage(Title, "Ocurrio un error al conectarse con la Base de Datos", ex); }
      }
      private bool GetConnectionString()
      {
         try
         {
            string l_path = Application.StartupPath;
            Controls.Connection FRM_Conexion = new Controls.Connection(pv_Title, l_path);
            FRM_Conexion.ShowDialog();
            FRM_Conexion.BringToFront();
            if (FRM_Conexion.DialogResult == DialogResult.OK)
            { return true; }
            else
            { return false; }
         }
         catch (Exception ex)
         {
            Messages.ShowErrorMessage(Title, "Ocurrio un error al mostrar el formulario de conexión", ex);
            return false;
         }
      }

      #endregion

      #region [ METHODS ]

      private void AuthenticateUser()
      {
         try
         {
            AUTE001MView FRM_AUTE001MView;
            AUTE001PView FRM_AUTE001PView;
            FRM_AUTE001MView = new AUTE001MView();
            FRM_AUTE001PView = new AUTE001PView();
            FRM_AUTE001MView.Presenter = FRM_AUTE001PView;
            FRM_AUTE001MView.StartPosition = FormStartPosition.CenterScreen;
            FRM_AUTE001MView.ShowDialog();

            if (FRM_AUTE001PView.SignOff)
            {
               Close();
               return;
            }
            else
            {
               WENV001MVIew FRM_WENV001MVIew;
               WENV001PVIew FRM_WENV001PVIew;
               FRM_WENV001MVIew = new WENV001MVIew();
               FRM_WENV001PVIew = new WENV001PVIew();
               FRM_WENV001MVIew.Presenter = FRM_WENV001PVIew;
               FRM_WENV001MVIew.StartPosition = FormStartPosition.CenterScreen;
               if (FRM_WENV001MVIew.ShowDialog() == DialogResult.OK)
               {
                  FRM_WENV001MVIew.Close();
               }
               else
               {
                  Close();
                  return;
               }
            }

            WindowState = FormWindowState.Maximized;
         }
         catch (Exception ex)
         { Messages.ShowErrorMessage(Title, "Ocurrio un error al iniciar el formulario de autentificación", ex); }
      }
      private void FillLabels()
      {
         try
         {
            lblNameCompany.Text = SessionVariables.BusinessName;
            lblNameUser.Text = SessionVariables.UserName;
            lblFooter.Text = string.Format("VERSIÓN : {0}  |  SERVIDOR : {1}  |  BASE DE DATOS : {2}  |  SUCURSAL : {3}  |  PUNTO DE VENTA : {4}   ", SessionVariables.Version, SessionVariables.Server, SessionVariables.DataBase, SessionVariables.BranchName, SessionVariables.PointSaleName);
         }
         catch (Exception ex)
         { Messages.ShowErrorMessage(Title, "Ocurrio un error al llenar los datos del entorno", ex); }
      }
      private void DrawScreen(Object p_TagButton)
      {
         try
         {
            string l_tagButton = Convert.ToString(p_TagButton);
            tlpMenu.Visible = true;
            toolMaintenance.Visible = false;
            toolSale.Visible = false;
            switch (l_tagButton)
            {
               case "MAIN000":
                  toolMaintenance.Visible = true;
                  toolSale.Visible = false;
                  tlpMenu.Visible = false;
                  break;
               case "SALE000":
                  toolSale.Visible = true;
                  toolMaintenance.Visible = false;
                  tlpMenu.Visible = false;
                  break;
            }

         }
         catch (Exception ex)
         { Messages.ShowErrorMessage(Title, "Ocurrio un error al dibujar la pantalla", ex); }
      }

      #endregion

      #region [ VIEWS ]

      #region [ MAINTENANCE ]

      MAIN001PView MAIN001_PView;
      MAIN001LView MAIN001_LView;
      MAIN001MView MAIN001_MView;
      private void MAIN001()
      {
         try
         {
            if (MAIN001_LView == null)
            {
               TabPage l_pageView = new TabPage();
               MAIN001_LView = new MAIN001LView(l_pageView);
               MAIN001_MView = new MAIN001MView();
               MAIN001_PView = new MAIN001PView(MAIN001_LView, MAIN001_MView);
               MAIN001_LView.Presenter = MAIN001_PView;
               MAIN001_MView.Presenter = MAIN001_PView;
               l_pageView.BackColor = Color.White;
               l_pageView.Controls.Add(MAIN001_LView);
               l_pageView.Text = tsbtnMAIN001.Text;
               MAIN001_LView.Dock = DockStyle.Fill;
               tabMain.TabPages.Add(l_pageView);
               MAIN001_LView.CloseForm += new CloseFormEventArgs.CloseFormEventHandler(Views_CloseForm);
               MAIN001_PView.Load();
            }
            tabMain.SelectedTab = MAIN001_LView.TabPageControl;

         }
         catch (Exception ex)
         { Messages.ShowErrorMessage(Title, "Ha ocurrido un error al iniciar el mantenimiento.", ex); }
      }
      MAIN002PView MAIN002_PView;
      MAIN002LView MAIN002_LView;
      MAIN002MView MAIN002_MView;
      private void MAIN002()
      {
         try
         {
            if (MAIN002_LView == null)
            {
               TabPage l_pageView = new TabPage();
               MAIN002_LView = new MAIN002LView(l_pageView);
               MAIN002_MView = new MAIN002MView();
               MAIN002_PView = new MAIN002PView(MAIN002_LView, MAIN002_MView);
               MAIN002_LView.Presenter = MAIN002_PView;
               MAIN002_MView.Presenter = MAIN002_PView;
               l_pageView.BackColor = Color.White;
               l_pageView.Controls.Add(MAIN002_LView);
               l_pageView.Text = tsbtnMAIN002.Text;
               MAIN002_LView.Dock = DockStyle.Fill;
               tabMain.TabPages.Add(l_pageView);
               MAIN002_LView.CloseForm += new CloseFormEventArgs.CloseFormEventHandler(Views_CloseForm);
               MAIN002_PView.Load();
            }
            tabMain.SelectedTab = MAIN002_LView.TabPageControl;

         }
         catch (Exception ex)
         { Messages.ShowErrorMessage(Title, "Ha ocurrido un error al iniciar el mantenimiento.", ex); }
      }
      MAIN003PView MAIN003_PView;
      MAIN003LView MAIN003_LView;
      MAIN003MView MAIN003_MView;
      private void MAIN003()
      {
         try
         {
            if (MAIN003_LView == null)
            {
               TabPage l_pageView = new TabPage();
               MAIN003_LView = new MAIN003LView(l_pageView);
               MAIN003_MView = new MAIN003MView();
               MAIN003_PView = new MAIN003PView(MAIN003_LView, MAIN003_MView);
               MAIN003_LView.Presenter = MAIN003_PView;
               MAIN003_MView.Presenter = MAIN003_PView;
               l_pageView.BackColor = Color.White;
               l_pageView.Controls.Add(MAIN003_LView);
               l_pageView.Text = tsbtnMAIN003.Text;
               MAIN003_LView.Dock = DockStyle.Fill;
               tabMain.TabPages.Add(l_pageView);
               MAIN003_LView.CloseForm += new CloseFormEventArgs.CloseFormEventHandler(Views_CloseForm);
               MAIN003_PView.Load();
            }
            tabMain.SelectedTab = MAIN003_LView.TabPageControl;

         }
         catch (Exception ex)
         { Messages.ShowErrorMessage(Title, "Ha ocurrido un error al iniciar el mantenimiento.", ex); }
      }
      MAIN004PView MAIN004_PView;
      MAIN004LView MAIN004_LView;
      MAIN004MView MAIN004_MView;
      private void MAIN004()
      {
         try
         {
            if (MAIN004_LView == null)
            {
               TabPage l_pageView = new TabPage();
               MAIN004_LView = new MAIN004LView(l_pageView);
               MAIN004_MView = new MAIN004MView();
               MAIN004_PView = new MAIN004PView(MAIN004_LView, MAIN004_MView);
               MAIN004_LView.Presenter = MAIN004_PView;
               MAIN004_MView.Presenter = MAIN004_PView;
               l_pageView.BackColor = Color.White;
               l_pageView.Controls.Add(MAIN004_LView);
               l_pageView.Text = tsbtnMAIN004.Text;
               MAIN004_LView.Dock = DockStyle.Fill;
               tabMain.TabPages.Add(l_pageView);
               MAIN004_LView.CloseForm += new CloseFormEventArgs.CloseFormEventHandler(Views_CloseForm);
               MAIN004_PView.Load();
            }
            tabMain.SelectedTab = MAIN004_LView.TabPageControl;

         }
         catch (Exception ex)
         { Messages.ShowErrorMessage(Title, "Ha ocurrido un error al iniciar el mantenimiento.", ex); }
      }
      MAIN005PView MAIN005_PView;
      MAIN005LView MAIN005_LView;
      MAIN005MView MAIN005_MView;
      private void MAIN005()
      {
         try
         {
            if (MAIN005_LView == null)
            {
               TabPage l_pageView = new TabPage();
               MAIN005_LView = new MAIN005LView(l_pageView);
               MAIN005_MView = new MAIN005MView();
               MAIN005_PView = new MAIN005PView(MAIN005_LView, MAIN005_MView);
               MAIN005_LView.Presenter = MAIN005_PView;
               MAIN005_MView.Presenter = MAIN005_PView;
               l_pageView.BackColor = Color.White;
               l_pageView.Controls.Add(MAIN005_LView);
               l_pageView.Text = tsbtnMAIN005.Text;
               MAIN005_LView.Dock = DockStyle.Fill;
               tabMain.TabPages.Add(l_pageView);
               MAIN005_LView.CloseForm += new CloseFormEventArgs.CloseFormEventHandler(Views_CloseForm);
               MAIN005_PView.Load();
            }
            tabMain.SelectedTab = MAIN005_LView.TabPageControl;

         }
         catch (Exception ex)
         { Messages.ShowErrorMessage(Title, "Ha ocurrido un error al iniciar el mantenimiento.", ex); }
      }
      MAIN006PView MAIN006_PView;
      MAIN006LView MAIN006_LView;
      MAIN006MView MAIN006_MView;
      private void MAIN006()
      {
         try
         {
            if (MAIN006_LView == null)
            {
               TabPage l_pageView = new TabPage();
               MAIN006_LView = new MAIN006LView(l_pageView);
               MAIN006_MView = new MAIN006MView();
               MAIN006_PView = new MAIN006PView(MAIN006_LView, MAIN006_MView);
               MAIN006_LView.Presenter = MAIN006_PView;
               MAIN006_MView.Presenter = MAIN006_PView;
               l_pageView.BackColor = Color.White;
               l_pageView.Controls.Add(MAIN006_LView);
               l_pageView.Text = tsbtnMAIN006.Text;
               MAIN006_LView.Dock = DockStyle.Fill;
               tabMain.TabPages.Add(l_pageView);
               MAIN006_LView.CloseForm += new CloseFormEventArgs.CloseFormEventHandler(Views_CloseForm);
               MAIN006_PView.Load();
            }
            tabMain.SelectedTab = MAIN006_LView.TabPageControl;

         }
         catch (Exception ex)
         { Messages.ShowErrorMessage(Title, "Ha ocurrido un error al iniciar el mantenimiento.", ex); }
      }
      MAIN007PView MAIN007_PView;
      MAIN007LView MAIN007_LView;
      MAIN007MView MAIN007_MView;
      private void MAIN007()
      {
         try
         {
            if (MAIN007_LView == null)
            {
               TabPage l_pageView = new TabPage();
               MAIN007_LView = new MAIN007LView(l_pageView);
               MAIN007_MView = new MAIN007MView();
               MAIN007_PView = new MAIN007PView(MAIN007_LView, MAIN007_MView);
               MAIN007_LView.Presenter = MAIN007_PView;
               MAIN007_MView.Presenter = MAIN007_PView;
               l_pageView.BackColor = Color.White;
               l_pageView.Controls.Add(MAIN007_LView);
               l_pageView.Text = tsbtnMAIN007.Text;
               MAIN007_LView.Dock = DockStyle.Fill;
               tabMain.TabPages.Add(l_pageView);
               MAIN007_LView.CloseForm += new CloseFormEventArgs.CloseFormEventHandler(Views_CloseForm);
               MAIN007_PView.Load();
            }
            tabMain.SelectedTab = MAIN007_LView.TabPageControl;

         }
         catch (Exception ex)
         { Messages.ShowErrorMessage(Title, "Ha ocurrido un error al iniciar el mantenimiento.", ex); }
      }
      MAIN008PView MAIN008_PView;
      MAIN008LView MAIN008_LView;
      MAIN008MView MAIN008_MView;
      private void MAIN008()
      {
         try
         {
            if (MAIN008_LView == null)
            {
               TabPage l_pageView = new TabPage();
               MAIN008_LView = new MAIN008LView(l_pageView);
               MAIN008_MView = new MAIN008MView();
               MAIN008_PView = new MAIN008PView(MAIN008_LView, MAIN008_MView);
               MAIN008_LView.Presenter = MAIN008_PView;
               MAIN008_MView.Presenter = MAIN008_PView;
               l_pageView.BackColor = Color.White;
               l_pageView.Controls.Add(MAIN008_LView);
               l_pageView.Text = tsbtnMAIN008.Text;
               MAIN008_LView.Dock = DockStyle.Fill;
               tabMain.TabPages.Add(l_pageView);
               MAIN008_LView.CloseForm += new CloseFormEventArgs.CloseFormEventHandler(Views_CloseForm);
               MAIN008_PView.Load();
            }
            tabMain.SelectedTab = MAIN008_LView.TabPageControl;

         }
         catch (Exception ex)
         { Messages.ShowErrorMessage(Title, "Ha ocurrido un error al iniciar el mantenimiento.", ex); }
      }
      MAIN009PView MAIN009_PView;
      MAIN009LView MAIN009_LView;
      MAIN009MView MAIN009_MView;
      private void MAIN009()
      {
         try
         {
            if (MAIN009_LView == null)
            {
               TabPage l_pageView = new TabPage();
               MAIN009_LView = new MAIN009LView(l_pageView);
               MAIN009_MView = new MAIN009MView();
               MAIN009_PView = new MAIN009PView(MAIN009_LView, MAIN009_MView);
               MAIN009_LView.Presenter = MAIN009_PView;
               MAIN009_MView.Presenter = MAIN009_PView;
               l_pageView.BackColor = Color.White;
               l_pageView.Controls.Add(MAIN009_LView);
               l_pageView.Text = tsbtnMAIN009.Text;
               MAIN009_LView.Dock = DockStyle.Fill;
               tabMain.TabPages.Add(l_pageView);
               MAIN009_LView.CloseForm += new CloseFormEventArgs.CloseFormEventHandler(Views_CloseForm);
               MAIN009_PView.Load();
            }
            tabMain.SelectedTab = MAIN009_LView.TabPageControl;

         }
         catch (Exception ex)
         { Messages.ShowErrorMessage(Title, "Ha ocurrido un error al iniciar el mantenimiento.", ex); }
      }
      MAIN010PView MAIN010_PView;
      MAIN010LView MAIN010_LView;
      MAIN010MView MAIN010_MView;
      private void MAIN010()
      {
         try
         {
            if (MAIN010_LView == null)
            {
               TabPage l_pageView = new TabPage();
               MAIN010_LView = new MAIN010LView(l_pageView);
               MAIN010_MView = new MAIN010MView();
               MAIN010_PView = new MAIN010PView(MAIN010_LView, MAIN010_MView);
               MAIN010_LView.Presenter = MAIN010_PView;
               MAIN010_MView.Presenter = MAIN010_PView;
               l_pageView.BackColor = Color.White;
               l_pageView.Controls.Add(MAIN010_LView);
               l_pageView.Text = tsbtnMAIN010.Text;
               MAIN010_LView.Dock = DockStyle.Fill;
               tabMain.TabPages.Add(l_pageView);
               MAIN010_LView.CloseForm += new CloseFormEventArgs.CloseFormEventHandler(Views_CloseForm);
               MAIN010_PView.Load();
            }
            tabMain.SelectedTab = MAIN010_LView.TabPageControl;

         }
         catch (Exception ex)
         { Messages.ShowErrorMessage(Title, "Ha ocurrido un error al iniciar el mantenimiento.", ex); }
      }
      MAIN011PView MAIN011_PView;
      MAIN011MView MAIN011_MView;
      private void MAIN011()
      {
         try
         {
            MAIN011_MView = new MAIN011MView();
            MAIN011_PView = new MAIN011PView(MAIN011_MView);
            MAIN011_MView.Presenter = MAIN011_PView;
            MAIN011_PView.Load();
            MAIN011_PView.Edit();
         }
         catch (Exception ex)
         { Messages.ShowErrorMessage(Title, "Ha ocurrido un error al iniciar el mantenimiento.", ex); }
      }

      #endregion

      #region [ SALE ]

      SALE001PView SALE001_PView;
      SALE001LView SALE001_LView;
      private void SALE001()
      {
         try
         {
            if (SALE001_LView == null)
            {
               TabPage l_pageView = new TabPage();
               SALE001_LView = new SALE001LView(l_pageView);
               SALE001_PView = new SALE001PView(SALE001_LView);
               SALE001_LView.Presenter = SALE001_PView;
               l_pageView.BackColor = Color.White;
               l_pageView.Controls.Add(SALE001_LView);
               l_pageView.Text = tsbtnSALE001.Text;
               SALE001_LView.Dock = DockStyle.Fill;
               tabMain.TabPages.Add(l_pageView);
               SALE001_LView.CloseForm += new CloseFormEventArgs.CloseFormEventHandler(Views_CloseForm);
               SALE001_PView.Load();
            }
            tabMain.SelectedTab = SALE001_LView.TabPageControl;

         }
         catch (Exception ex)
         { Messages.ShowErrorMessage(Title, "Ha ocurrido un error al iniciar el mantenimiento.", ex); }
      }
      SALE002PView SALE002_PView;
      SALE002LView SALE002_LView;
      private void SALE002()
      {
         try
         {
            if (SALE002_LView == null)
            {
               TabPage l_pageView = new TabPage();
               SALE002_LView = new SALE002LView(l_pageView);
               SALE002_PView = new SALE002PView(SALE002_LView);
               SALE002_LView.Presenter = SALE002_PView;
               l_pageView.BackColor = Color.White;
               l_pageView.Controls.Add(SALE002_LView);
               l_pageView.Text = tsbtnSALE002.Text;
               SALE002_LView.Dock = DockStyle.Fill;
               tabMain.TabPages.Add(l_pageView);
               SALE002_LView.CloseForm += new CloseFormEventArgs.CloseFormEventHandler(Views_CloseForm);
               SALE002_PView.Load();
            }
            tabMain.SelectedTab = SALE002_LView.TabPageControl;

         }
         catch (Exception ex)
         { Messages.ShowErrorMessage(Title, "Ha ocurrido un error al iniciar el mantenimiento.", ex); }
      }
      //SALE003PView SALE003_PView;
      //SALE003LView SALE003_LView;
      //private void SALE003()
      //{
      //   try
      //   {
      //      if (SALE003_LView == null)
      //      {
      //         TabPage l_pageView = new TabPage();
      //         SALE003_LView = new SALE003LView(l_pageView);
      //         SALE003_PView = new SALE003PView(SALE003_LView);
      //         SALE003_LView.Presenter = SALE003_PView;
      //         l_pageView.BackColor = Color.White;
      //         l_pageView.Controls.Add(SALE003_LView);
      //         l_pageView.Text = tsbtnSALE003.Text;
      //         SALE003_LView.Dock = DockStyle.Fill;
      //         tabMain.TabPages.Add(l_pageView);
      //         SALE003_LView.CloseForm += new CloseFormEventArgs.CloseFormEventHandler(Views_CloseForm);
      //         SALE003_PView.Load();
      //      }
      //      tabMain.SelectedTab = SALE003_LView.TabPageControl;

      //   }
      //   catch (Exception ex)
      //   { Messages.ShowErrorMessage(Title, "Ha ocurrido un error al iniciar el mantenimiento.", ex); }
      //}

      #endregion

      #endregion

      #region [ EVENTS ]

      private void Views_CloseForm(object sender, CloseFormEventArgs e)
      {
         try
         {
            tabMain.TabPages.Remove((TabPage)e.TabPageControl);
            if (!string.IsNullOrEmpty(e.FormName))
            {
               switch (e.FormName)
               {
                  case "MAIN001":
                     MAIN001_PView = null;
                     MAIN001_LView = null;
                     MAIN001_MView = null;
                     break;
                  case "MAIN002":
                     MAIN002_PView = null;
                     MAIN002_LView = null;
                     MAIN002_MView = null;
                     break;
                  case "MAIN003":
                     MAIN003_PView = null;
                     MAIN003_LView = null;
                     MAIN003_MView = null;
                     break;
                  case "MAIN004":
                     MAIN004_PView = null;
                     MAIN004_LView = null;
                     MAIN004_MView = null;
                     break;
                  case "MAIN005":
                     MAIN005_PView = null;
                     MAIN005_LView = null;
                     MAIN005_MView = null;
                     break;
                  case "MAIN006":
                     MAIN006_PView = null;
                     MAIN006_LView = null;
                     MAIN006_MView = null;
                     break;
                  case "MAIN007":
                     MAIN007_PView = null;
                     MAIN007_LView = null;
                     MAIN007_MView = null;
                     break;
                  case "MAIN008":
                     MAIN008_PView = null;
                     MAIN008_LView = null;
                     MAIN008_MView = null;
                     break;
                  case "MAIN009":
                     MAIN009_PView = null;
                     MAIN009_LView = null;
                     MAIN009_MView = null;
                     break;
                  case "MAIN010":
                     MAIN010_PView = null;
                     MAIN010_LView = null;
                     MAIN010_MView = null;
                     break;
                  case "MAIN011":
                     MAIN011_PView = null;
                     MAIN011_MView = null;
                     break;
                  case "SALE001":
                     SALE001_PView = null;
                     SALE001_LView = null;
                     break;
                  case "SALE002":
                     SALE002_PView = null;
                     SALE002_LView = null;
                     break;
                  //case "SALE003":
                  //   SALE003_PView = null;
                  //   SALE003_LView = null;
                  //   break;
               }
            }
         }
         catch (Exception ex)
         { Messages.ShowErrorMessage(Title, "Ha ocurrido un error al cerrar la pestaña.", ex); }
         finally
         {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            SetProcessWorkingSetSize(Process.GetCurrentProcess().Handle, -1, -1);
         }
      }
      [DllImport("kernel32.dll", EntryPoint = "SetProcessWorkingSetSize", ExactSpelling = true, CharSet = CharSet.Ansi, SetLastError = true)]
      private static extern int SetProcessWorkingSetSize(IntPtr process, int minimumWorkingSetSize, int maximumWorkingSetSize);

      #region [ MAINTENANCE ]

      private void BtnMaintenance_Click(object sender, EventArgs e)
      { DrawScreen(btnMaintenance.Tag); }
      private void TsbtnMAIN001_Click(object sender, EventArgs e)
      { MAIN001(); }
      private void TsbtnMAIN002_Click(object sender, EventArgs e)
      { MAIN002(); }
      private void TsbtnMAIN003_Click(object sender, EventArgs e)
      { MAIN003(); }
      private void TsbtnMAIN004_Click(object sender, EventArgs e)
      { MAIN004(); }
      private void TsbtnMAIN005_Click(object sender, EventArgs e)
      { MAIN005(); }
      private void TsbtnMAIN006_Click(object sender, EventArgs e)
      { MAIN006(); }
      private void TsbtnMAIN007_Click(object sender, EventArgs e)
      { MAIN007(); }
      private void TsbtnMAIN008_Click(object sender, EventArgs e)
      { MAIN008(); }
      private void TsbtnMAIN009_Click(object sender, EventArgs e)
      { MAIN009(); }
      private void TsbtnMAIN010_Click(object sender, EventArgs e)
      { MAIN010(); }
      private void TsbtnMAIN011_Click(object sender, EventArgs e)
      { MAIN011(); }

      #endregion

      #region [ SALE ]

      private void BtnSale_Click(object sender, EventArgs e)
      { DrawScreen(btnSale.Tag); }
      private void TsbtnSALE001_Click(object sender, EventArgs e)
      { SALE001(); }
      private void TsbtnSALE002_Click(object sender, EventArgs e)
      { SALE002(); }
      private void TsbtnSALE003_Click(object sender, EventArgs e)
      { /*SALE003(); */}

      #endregion

      #endregion

      #region [ FILES XML ]

      private void GenerateTemporaryFiles()
      {
         try
         {
            String l_path = Path.Combine(Application.StartupPath, "VENPY_TemporaryFiles", SessionVariables.BusinessRuc, SessionVariables.UserName);
            if (!Directory.Exists(l_path))
            { DirectoryInfo l_DirectoryInfo = Directory.CreateDirectory(l_path); }
            TemporaryFiles.PathTemporaryFile = l_path;

            TemporaryFiles.LoadSettings(SessionVariables.BusinessCode);
            VENPY_Settings l_Settings = new VENPY_Settings();
            l_Settings = TemporaryFiles.DeserializeSettings().Where(filter => filter.BUSI_Code == SessionVariables.BusinessCode && filter.SETT_Key == StaticLists.SETT_Refresh).FirstOrDefault();

            if (l_Settings != null)
            {
               String l_file = null;
               l_file = Path.Combine(TemporaryFiles.PathTemporaryFile, TemporaryFiles.pv_filename_personalconfiguration);
               if (!File.Exists(l_file) || l_Settings.SETT_Value.Equals("1"))
               { TemporaryFiles.LoadPersonalConfiguration(SessionVariables.BusinessCode, SessionVariables.UserCode); }

               l_file = Path.Combine(TemporaryFiles.PathTemporaryFile, TemporaryFiles.pv_filename_ubigeos);
               if (!File.Exists(l_file) || l_Settings.SETT_Value.Equals("1"))
               { TemporaryFiles.LoadUbigeos(); }

               l_file = Path.Combine(TemporaryFiles.PathTemporaryFile, TemporaryFiles.pv_filename_tables);
               if (!File.Exists(l_file) || l_Settings.SETT_Value.Equals("1"))
               { TemporaryFiles.LoadTables(SessionVariables.BusinessCode); }
            }
            else
            { Messages.ShowWarningMessage(Title, "No se puedo cargar los archivos temporales, debe comunicarse con su proveedor"); }
         }
         catch (Exception ex)
         { Messages.ShowErrorMessage(Title, "Ocurrio un error al crear los archivos temporales.", ex); }
      }


      #endregion

   }
}
