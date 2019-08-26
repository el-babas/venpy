using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VenPy.Class;
using VenPy.Entities;
using VenPy.Connection;
using System.ComponentModel;
using System.Data;

namespace VenPy.Controls
{
   public class HelpEntity : TextBox
   {
      #region [ ENUM ]

      public enum TypeTextBoxHelp
      {
         Numeric,
         Alphanumeric
      }
      public enum InstanceHelp
      {
         Enable,
         Disable
      }
      public enum TypeFilter
      {
         DocumentNumber,
         BusinessName
      }

      #endregion

      #region [ VARIABLES ]

      public String pb_title = "Ayuda de Entidad";
      public Button pb_helpButton;
      public Button pb_editButton;
      public Button pb_newButton;
      private Int32 pv_acceptedLength = 0;
      private Boolean pv_fillZeros;
      private VENPY_Entities pv_value;
      private IContainer pv_components = null;
      private TypeTextBoxHelp pv_type;
      //private DialogResult pv_helpDialogResult;

      #endregion

      #region [ PROPERTIES ]

      public Int32 AcceptedLength
      {
         get { return pv_acceptedLength; }
         set
         {
            if (Text.Length >= value)
            { Text = Text.Substring(0, value); }
            pv_acceptedLength = value;
         }
      }
      public Int32 EntityType { get; set; }
      public Int32 BusinessCode { get; set; }
      public Boolean FillZeros
      {
         get { return pv_fillZeros; }
         set { pv_fillZeros = value; }
      }
      public Boolean EnableHelpButton
      {
         get { return this.pb_helpButton.Enabled; }
         set { this.pb_helpButton.Enabled = value; }
      }
      public Boolean UseEntityType { get; set; }
      public VENPY_Entities Value
      {
         get { return pv_value; }
         set
         {
            pv_value = value;
            if (AyudaValueChanged != null)
            { AyudaValueChanged(pv_value, EventArgs.Empty); }
         }
      }
      private IBLVENPY_Entities BL_VENPY_Entities { get; set; }
      public TypeFilter MyTypeFiler { get; set; }
      public InstanceHelp MyInstanceHelp { get; set; }
      public TypeTextBoxHelp Type
      {
         get { return pv_type; }
         set { pv_type = value; }
      }
      public override Int32 MaxLength
      {
         get { return base.MaxLength; }
         set { base.MaxLength = value; }
      }
      public override Cursor Cursor
      {
         get { return base.Cursor; }
         set { base.Cursor = value; }
      }
      public override String Text
      {
         get { return base.Text; }
         set { base.Text = value; }
      }
      public new object Tag
      {
         get { return base.Tag; }
         set { base.Tag = value; }
      }

      #endregion

      #region [ CONSTRUCTORS ]

      public HelpEntity() : base()
      {
         InitializeEntidad();
         InitializeComponent();
         UseEntityType = true;
         BL_VENPY_Entities = new BLVENPY_Entities();
      }

      #endregion

      #region [ METHODS ]

      private void InitializeComponent()
      {
         pv_components = new Container();
      }
      private void InitializeEntidad()
      {

         base.Size = new System.Drawing.Size(100, 24);
         this.pv_fillZeros = false;
         this.pv_type = TypeTextBoxHelp.Alphanumeric;
         pb_helpButton = new Button();
         pb_helpButton.Image = Properties.Resources.Search_12x12;
         pb_helpButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
         pb_helpButton.UseVisualStyleBackColor = true;
         pb_helpButton.Size = new System.Drawing.Size(24, 24);
         pb_helpButton.Dock = DockStyle.Right;
         pb_helpButton.Cursor = Cursors.Hand;
         pb_helpButton.TabStop = false;
         pb_helpButton.Margin = new Padding(0);
         base.Controls.Add(pb_helpButton);
         pb_helpButton.BringToFront();
         pb_helpButton.Enabled = true;
         pb_helpButton.GotFocus += new EventHandler(AyudaButton_GotFocus);
         this.pb_helpButton.Click += new EventHandler(AyudaBoton_Click);
         this.KeyUp += new KeyEventHandler(TextBoxAyuda_Key);
         this.KeyPress += new KeyPressEventHandler(TextBoxAyuda_KeyPress);
      }
      private void SetInstance(InstanceHelp p_instance)
      {
         try
         {
            MyInstanceHelp = p_instance;
            switch (MyInstanceHelp)
            {
               case InstanceHelp.Enable:
                  base.ReadOnly = false;
                  Text = "";
                  base.BackColor = System.Drawing.Color.White;
                  pb_helpButton.Enabled = true;
                  pb_helpButton.Image = Properties.Resources.Search_12x12;
                  break;

               case InstanceHelp.Disable:
                  base.ReadOnly = true;
                  base.BackColor = System.Drawing.Color.LightGray;
                  pb_helpButton.Enabled = true;
                  pb_helpButton.Image = Properties.Resources.Clear_12x12;
                  break;
            }
         }
         catch (Exception ex)
         { throw ex; }
      }
      protected override void Dispose(Boolean p_disposing)
      {
         if (p_disposing && (pv_components != null))
         {
            pv_components.Dispose();
         }
         base.Dispose(p_disposing);
      }
      public new bool Focus()
      {
         this.Select();
         return base.Focus();
      }
      public void HelpValue()
      {
         try
         {
            DataTable l_dtHelp = new DataTable();
            switch (MyTypeFiler)
            {
               case TypeFilter.BusinessName:
                  l_dtHelp = BL_VENPY_Entities.BLENTIS_Help(BusinessCode, EntityType, null, Text).ToDataTable();
                  break;
               case TypeFilter.DocumentNumber:
                  l_dtHelp = BL_VENPY_Entities.BLENTIS_Help(BusinessCode, EntityType, Text, null).ToDataTable();
                  break;
            }
            if (l_dtHelp.Rows.Count == 0)
            { Messages.ShowInformationMessage(pb_title, "No se encontraron coincidencias."); }
            else if (l_dtHelp.Rows.Count == 1)
            {
               Int32 l_ENTI_Code;
               if (Int32.TryParse(l_dtHelp.Rows[0]["ENTI_Code"].ToString(), out l_ENTI_Code))
               { SetValue(l_ENTI_Code); }
               else
               { ClearValue(); }
            }
            else
            {
               List<HelpColumn> l_columns = new List<HelpColumn>();
               switch (MyTypeFiler)
               {
                  case TypeFilter.BusinessName:
                     l_columns.Add(new HelpColumn()
                     {
                        Index = 0,
                        ColumnName = "ENTI_DocumentNumber",
                        ColumnCaption = "Nro. Documento",
                        Alignment = DataGridViewContentAlignment.MiddleCenter,
                        Width = 125,
                        DataType = typeof(string),
                        Format = null
                     });
                     l_columns.Add(new HelpColumn()
                     {
                        Index = 1,
                        ColumnName = "ENTI_BusinessName",
                        ColumnCaption = "Nombre",
                        Alignment = DataGridViewContentAlignment.MiddleLeft,
                        Width = 250,
                        DataType = typeof(string),
                        Format = null
                     });
                     break;
                  case TypeFilter.DocumentNumber:
                     l_columns.Add(new HelpColumn()
                     {
                        Index = 0,
                        ColumnName = "ENTI_BusinessName",
                        ColumnCaption = "Nombre",
                        Alignment = DataGridViewContentAlignment.MiddleLeft,
                        Width = 250,
                        DataType = typeof(string),
                        Format = null
                     });
                     l_columns.Add(new HelpColumn()
                     {
                        Index = 1,
                        ColumnName = "ENTI_DocumentNumber",
                        ColumnCaption = "Nro. Documento",
                        Alignment = DataGridViewContentAlignment.MiddleCenter,
                        Width = 125,
                        DataType = typeof(string),
                        Format = null
                     });
                     break;
               }
               l_columns.Add(new HelpColumn()
               {
                  Index = 2,
                  ColumnName = "TBLE_NameTDI",
                  ColumnCaption = "Tipo Doc. Identidad",
                  Alignment = DataGridViewContentAlignment.MiddleLeft,
                  Width = 200,
                  DataType = typeof(string),
                  Format = null
               });
               l_columns.Add(new HelpColumn()
               {
                  Index = 3,
                  ColumnName = "ENTI_Code",
                  ColumnCaption = "Código",
                  Alignment = DataGridViewContentAlignment.MiddleRight,
                  Width = 50,
                  DataType = typeof(int),
                  Format = null
               });
               HelpForm l_HelpForm = new HelpForm(pb_title, l_dtHelp, false, l_columns);
               this.KeyUp -= TextBoxAyuda_Key;
               if (l_HelpForm.ShowDialog() == DialogResult.OK)
               {
                  Int32 l_ENTI_Code;
                  if (Int32.TryParse(l_HelpForm.Answer.Rows[0]["ENTI_Code"].ToString(), out l_ENTI_Code))
                  { SetValue(l_ENTI_Code); }
                  else
                  { ClearValue(); }
               }
               else { ClearValue(); }
               this.KeyUp += new KeyEventHandler(TextBoxAyuda_Key);
            }

         }
         catch (Exception ex)
         { Messages.ShowErrorMessage(pb_title, "Ha ocurrido un error al mostrar la ayuda", ex); }
      }
      public void SetValue(Int32 p_ENTI_Code)
      {
         try
         {
            var item = BL_VENPY_Entities.BLENTIS_AEntity(BusinessCode, p_ENTI_Code);
            if (item != null)
            {
               switch (MyTypeFiler)
               {
                  case TypeFilter.BusinessName:
                     Text = item.ENTI_BusinessName;
                     this.Select(item.ENTI_BusinessName.Length, 1);
                     break;
                  case TypeFilter.DocumentNumber:
                     Text = item.ENTI_DocumentNumber;
                     this.Select(item.ENTI_DocumentNumber.Length, 1);
                     break;
               }
               Value = item;
               pv_value = item;
               SetInstance(InstanceHelp.Disable);
            }
            else
            { ClearValue(); }
         }
         catch (Exception ex)
         { throw ex; }
      }
      public void ClearValue()
      {
         try
         {
            Value = null;
            this.Text = string.Empty; ;
            SetInstance(InstanceHelp.Enable);
         }
         catch (Exception ex)
         { throw ex; }
      }

      #endregion

      #region [ EVENTS ]

      public event EventHandler AyudaValueChanged;
      protected override void OnGotFocus(EventArgs e)
      {
         base.OnGotFocus(e);
         if (pv_fillZeros) { base.Text = this.Text.PadLeft(this.MaxLength, '0'); }
      }
      protected override void OnTextChanged(EventArgs e)
      {
         base.OnTextChanged(e);
      }
      protected override bool ProcessCmdKey(ref Message p_message, Keys p_keyData)
      {
         const int WM_KEYDOWN = 256;
         const int WM_SYSKEYDOWN = 260;
         if ((p_message.Msg == WM_KEYDOWN) || (p_message.Msg == WM_SYSKEYDOWN))
         {
            switch (p_keyData)
            {
               case Keys.Tab:
                  KeyEventArgs e = new KeyEventArgs(Keys.Tab);
                  base.OnKeyDown(e);
                  break;
            }
         }
         return base.ProcessCmdKey(ref p_message, p_keyData);
      }
      protected void AyudaBoton_Click(object sender, EventArgs e)
      {
         if (EnableHelpButton)
         {
            if (MyInstanceHelp == InstanceHelp.Enable)
            { HelpValue(); }
            else
            { ClearValue(); }
         }
      }
      protected void TextBoxAyuda_Key(object sender, KeyEventArgs e)
      {
         if (e.KeyCode == Keys.F4 && EnableHelpButton)
         {
            if ((this.Text.Trim().Length >= pv_acceptedLength))
            { HelpValue(); }
            else
            { HelpValue(); }
         }
      }
      protected void TextBoxAyuda_KeyPress(object sender, KeyPressEventArgs e)
      {
         if (pv_type == TypeTextBoxHelp.Numeric)
         {
            System.Globalization.NumberFormatInfo numberFormatInfo = System.Globalization.CultureInfo.CurrentCulture.NumberFormat;
            string l_NumberDecimalSeparator = numberFormatInfo.NumberDecimalSeparator;
            string l_NumberGroupSeparator = numberFormatInfo.NumberGroupSeparator;
            string l_NegativeSign = numberFormatInfo.NegativeSign;
            string l_keyInput = e.KeyChar.ToString();
            if (char.IsDigit(e.KeyChar))
            { /*Digits are OK*/ }
            else if (l_keyInput.Equals(l_NumberDecimalSeparator) || l_keyInput.Equals(l_NumberGroupSeparator) || l_keyInput.Equals(l_NegativeSign))
            { /*Decimal separator is OK*/}
            else if ((int)e.KeyChar == (int)Keys.Back)
            { /*Backspace key is OK*/}
            else
            {
               //Swallow this invalid key and beep
               e.Handled = true;
            }
         }
      }
      private void AyudaButton_GotFocus(object sender, EventArgs e)
      { this.Focus(); }

      #endregion
   }
}
