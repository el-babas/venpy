using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VenPy.Class;
using System.Xml;
using System.IO;

namespace VenPy.Controls
{
    public partial class Connection : Form
    {
        #region [ VARIABLES ]

        /// <summary>
        /// Main Title
        /// </summary>
        private string pv_Title = "Conexión";
        /// <summary>
        /// Connection Time
        /// </summary>
        private string pv_Timeout = "30";

        #endregion

        #region [ PROPERTIES ]

        /// <summary>
        /// Types of Authentications
        /// </summary>
        private sealed class AuthenticationTypes
        {
            private AuthenticationTypes()
            { }
            public const string pb_WindowsAuthentication = "Autenticación Windows";
            public const string pb_SQLServerAuthenticaction = "Autenticación SQL Server";
        }
        public Boolean NameDefault { get; set; }
        public String NameFile { get; set; }
        public String NameAplication { get; set; }
        public String FilePath { get; set; }

        #endregion

        #region [ FORM ]

        /// <summary>
        /// Form Builder Connection
        /// </summary>
        public Connection(String p_NameAplication, String p_FilePath, Boolean p_NameDefault = true, String p_NameFile = "")
        {
            InitializeComponent();
            cmbAuthentication.SelectedIndexChanged += new EventHandler(CmbAuthentication_SelectedIndexChanged);
            btnAccept.Click += new EventHandler(BtnAccept_Click);
            btnCancel.Click += new EventHandler(BtnCancel_Click);
            NameAplication = p_NameAplication;
            NameDefault = p_NameDefault;
            NameFile = p_NameFile;
            FilePath = p_FilePath;
        }
        /// <summary>
        /// Load 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Connection_Load(object sender, EventArgs e)
        {
            try
            {
                FillControls();
                cmbAuthentication.SelectedValue = 2;
            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(pv_Title, "Ocurrio un error al iniciar la pantalla de conexión", ex); }
        }

        #endregion

        #region [ METHODS ]

        /// <summary>
        /// Fill the form controls
        /// </summary>
        private void FillControls()
        {
            try
            {
                List<Register> SQLAuthenticationType = new List<Register>();

                SQLAuthenticationType.Add(new Register(AuthenticationTypes.pb_WindowsAuthentication, 1));
                SQLAuthenticationType.Add(new Register(AuthenticationTypes.pb_SQLServerAuthenticaction, 2));

                cmbAuthentication.DropDownStyle = ComboBoxStyle.DropDownList;
                cmbAuthentication.DisplayMember = "Name";
                cmbAuthentication.ValueMember = "Value";
                cmbAuthentication.DataSource = SQLAuthenticationType;
            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(pv_Title, "Ocurrio un error al llenar los controles", ex); }
        }
        /// <summary>
        /// Verify if the hours have the correct format and if there is a username and password if necessary
        /// </summary>
        /// <returns></returns>
        private bool ValidateConnection()
        {
            try
            {
                bool l_iscorrect = true;
                string l_menssage = string.Empty;

                /*######################################## CONNECTING TO THE SERVER ##########################################*/
                if (string.IsNullOrEmpty(txtServerName.Text))
                {
                    l_iscorrect = false;
                    l_menssage += "Ingrese el Nombre o la Dirección IP del Servidor" + Environment.NewLine;
                }
                if (cmbAuthentication.SelectedItem != null)
                {
                    if (cmbAuthentication.SelectedItem.ToString() == AuthenticationTypes.pb_SQLServerAuthenticaction)
                    {
                        if (string.IsNullOrEmpty(txtUserName.Text))
                        {
                            l_iscorrect = false;
                            l_menssage += "Ingrese el Nombre del Usuario del Servidor" + Environment.NewLine;
                        }
                    }
                }
                else
                {
                    l_iscorrect = false;
                    l_menssage += "Debe Seleccionar un Tipo de Autenticación" + Environment.NewLine;
                }
                if (string.IsNullOrEmpty(txtDataBase.Text))
                {
                    l_iscorrect = false;
                    l_menssage += "Ingrese el Nombre de la Base de Datos" + Environment.NewLine;
                }
                if (!l_iscorrect)
                { Messages.ShowInformationMessage(pv_Title, "Faltan ingresar algunos datos", l_menssage); }
                return l_iscorrect;
            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(pv_Title, "Ocurrio un error al validar la información", ex); return false; }
        }
        /// <summary>
        /// Create the Connection Chain in an XML File (cConfig)
        /// </summary>
        /// <returns></returns>
        private bool CreateConnection()
        {
            try
            {
                if (cmbAuthentication.SelectedItem != null)
                {
                    string l_pathExport = FilePath;
                    string l_fileName = string.Empty;
                    string l_connection = string.Empty;

                    if (NameDefault)
                    { l_fileName = EncryptString.pb_ConnectionFile; }
                    else
                    { l_fileName = NameFile; }

                    string l_pathName = System.IO.Path.Combine(l_pathExport, l_fileName);
                    using (XmlTextWriter writer = new XmlTextWriter(l_pathName, Encoding.UTF8))
                    {
                        l_connection = string.Format("{0}|{1}|{2}|{3}|{4}|{5}", txtServerName.Text, txtDataBase.Text, txtUserName.Text, txtPassword.Text, NameAplication, pv_Timeout);
                        writer.Formatting = Formatting.Indented;
                        writer.WriteStartDocument();
                        writer.WriteStartElement("cString");
                        writer.WriteStartElement("connection");
                        writer.WriteElementString("connectionString", EncryptString.Encrypt(l_connection));
                        writer.WriteEndElement();
                        writer.WriteEndElement();
                        writer.WriteEndDocument();
                        writer.Close();
                    }
                    return true;
                }
                else
                { return false; }
            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(pv_Title, "Ocurrio un error al crear el archivo de conexión", ex); return false; }
        }
        /// <summary>
        /// Gets the connection string and data related to the connection
        /// </summary>
        /// <param name="p_fileName"></param>
        /// <param name="p_path"></param>
        /// <param name="p_string"></param>
        /// <param name="p_dataBase"></param>
        /// <param name="p_server"></param>
        /// <returns></returns>
        public static bool GetConnectionString(string p_path, string p_fileName, ref string p_string, ref string p_dataBase, ref string p_server)
        {
            try
            {
                string pathName = Path.Combine(p_path, p_fileName);
                if (File.Exists(pathName))
                {
                    XmlDocument xDoc = new XmlDocument();
                    xDoc.Load(pathName);
                    XmlNodeList xNode = xDoc.GetElementsByTagName("cString");
                    XmlNodeList xNodeList = ((XmlElement)xNode[0]).GetElementsByTagName("connection");
                    string l_getString = null;
                    string l_dataSource = null;
                    string l_initialCatalog = null;
                    string l_userID = null;
                    string l_password = null;
                    string l_applicationName = null;
                    string l_connectTimeout = null;
                    foreach (XmlElement item in xNodeList)
                    {
                        l_getString = item.GetElementsByTagName("connectionString")[0].InnerText.ToString();
                        l_getString = l_getString == null ? "" : l_getString.Trim();
                        l_getString = EncryptString.Decrypt(l_getString);
                    }
                    string[] _parametros = l_getString.Split('|');
                    if (_parametros.Length > 0) { l_dataSource = _parametros[0]; }
                    if (_parametros.Length > 1) { l_initialCatalog = _parametros[1]; }
                    if (_parametros.Length > 2) { l_userID = _parametros[2]; }
                    if (_parametros.Length > 3) { l_password = _parametros[3]; }
                    if (_parametros.Length > 4) { l_applicationName = _parametros[4]; }
                    if (_parametros.Length > 5) { l_connectTimeout = _parametros[5]; }
                    if (!string.IsNullOrEmpty(l_userID))
                    {
                        p_string = String.Format("Data Source={0};Initial Catalog={1};User Id={2};Password={3};Application Name={4};Connect Timeout={5}", l_dataSource, l_initialCatalog, l_userID, l_password, l_applicationName, l_connectTimeout);
                        p_dataBase = l_initialCatalog;
                        p_server = l_dataSource;
                    }
                    else
                    {
                        p_string = String.Format("Data Source={0};Initial Catalog={1};Integrated Security = True", l_dataSource, l_initialCatalog);
                        p_dataBase = l_initialCatalog;
                        p_server = l_dataSource;
                    }
                    return true;
                }
                else
                { return false; }
            }
            catch (Exception)
            { return false; }
        }

        #endregion

        #region [ EVENTS ]

        private void BtnAccept_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateConnection())
                {
                    if (CreateConnection())
                    { DialogResult = DialogResult.OK; }
                }
            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(pv_Title, "Ocurrio un error al aceptar los cambios", ex); }
        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult = DialogResult.Cancel;
            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(pv_Title, "Ocurrio un error al cancelar la operación", ex); }
        }
        private void CmbAuthentication_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbAuthentication.SelectedItem != null)
                {
                    txtUserName.Text = string.Empty;
                    txtPassword.Text = string.Empty;
                    txtUserName.Enabled = (cmbAuthentication.SelectedItem.ToString() == AuthenticationTypes.pb_SQLServerAuthenticaction);
                    txtPassword.Enabled = (cmbAuthentication.SelectedItem.ToString() == AuthenticationTypes.pb_SQLServerAuthenticaction);
                }
            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(pv_Title, "Ocurrio un error al seleccionar un item", ex); }
        }

        #endregion
    }
    #region [ CLASS REGISTER ]

    [Serializable()]
    public partial class Register
    {
        public String Name { get; set; }
        public Int32 Value { get; set; }
        /// <summary>
        /// List conformed by a String & Int16
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        public Register(String x_Name, Int32 x_Value)
        {
            Name = x_Name;
            Value = x_Value;
        }
        public override string ToString()
        {
            return Name;
        }
    }
    
    #endregion
}
