using System;
using System.Windows.Forms;
using System.Drawing;

namespace VenPy.Controls
{
   public partial class DataGridViewHelpTextBoxControl : TextBox
   {
      #region [ VARIABLES ]

      public Button pb_helpButton;

      #endregion

      #region [ PROPERTIES ]

      public override string Text
      {
         get { return base.Text; }
         set { base.Text = value; }
      }
      public new object Tag
      {
         get { return base.Tag; }
         set { base.Tag = value; }
      }
      public override Cursor Cursor
      {
         get { return base.Cursor; }
         set { base.Cursor = value; }
      }

      #endregion

      #region [ CONSTRUCTORS ]

      public DataGridViewHelpTextBoxControl()
         : base()
      {
         pb_helpButton = new Button();
         pb_helpButton.Image = Properties.Resources.Search_12x12;
         pb_helpButton.UseVisualStyleBackColor = true;
         pb_helpButton.Size = new Size(21, 21);
         pb_helpButton.Dock = DockStyle.Right;
         pb_helpButton.Cursor = Cursors.Arrow;
         Controls.Add(pb_helpButton);
         pb_helpButton.BringToFront();
         KeyUp += new KeyEventHandler(DataGridViewHelpTextBoxControl_KeyUp);
         pb_helpButton.Click += new EventHandler(HelpButton_Click);
      }

      #endregion

      #region [ METHODS ]

      protected override void Dispose(bool p_disposing)
      { base.Dispose(p_disposing); }

      #endregion

      #region [ EVENTS ]

      public event ButtonClickEventHandler ButtonClick;
      public delegate void ButtonClickEventHandler(object sender, EventArgs e);
      protected override void OnTextChanged(EventArgs e)
      { base.OnTextChanged(e); }
      private void HelpButton_Click(object sender, EventArgs e)
      {
         ButtonClick?.Invoke(sender, e);
      }
      private void DataGridViewHelpTextBoxControl_KeyUp(object sender, KeyEventArgs e)
      {
         if (e.KeyCode == Keys.F2)
         {
            HelpButton_Click(sender, e);
         }
      }

      #endregion
   }

   public class DataGridViewHelpTextBox : DataGridViewHelpTextBoxControl, IDataGridViewEditingControl
   {
      #region [ VARIABLES ]

      private int pv_rowIndexNum;
      private bool pv_valueIsChanged = false;
      private DataGridView pv_dataGridViewControl;

      #endregion

      #region [ PROPERTIES ]

      public virtual DataGridView EditingControlDataGridView
      {
         get { return this.pv_dataGridViewControl; }
         set { this.pv_dataGridViewControl = value; }
      }
      DataGridView IDataGridViewEditingControl.EditingControlDataGridView
      {
         get { return pv_dataGridViewControl; }
         set { pv_dataGridViewControl = value; }
      }
      Cursor IDataGridViewEditingControl.EditingPanelCursor
      {
         get { return base.Cursor; }
      }
      int IDataGridViewEditingControl.EditingControlRowIndex
      {
         get { return pv_rowIndexNum; }
         set { pv_rowIndexNum = value; }
      }
      bool IDataGridViewEditingControl.EditingControlValueChanged
      {
         get { return pv_valueIsChanged; }
         set { pv_valueIsChanged = value; }
      }
      bool IDataGridViewEditingControl.RepositionEditingControlOnValueChange
      {
         get { return false; }
      }
      object IDataGridViewEditingControl.EditingControlFormattedValue
      {
         get { return this.Text; }
         set { this.Text = value.ToString(); }
      }

      #endregion

      #region [ CONSTRUCTORS ]

      public DataGridViewHelpTextBox()
      { Text = string.Empty; }

      #endregion

      #region [ METHODS ]

      bool IDataGridViewEditingControl.EditingControlWantsInputKey(Keys p_keyData, bool p_dataGridViewWantsInputKey)
      {
         if (p_keyData == Keys.Escape)
         { return false; }
         else
         { return true; }
      }
      object IDataGridViewEditingControl.GetEditingControlFormattedValue(DataGridViewDataErrorContexts p_context)
      {
         return this.Text;
      }
      void IDataGridViewEditingControl.ApplyCellStyleToEditingControl(DataGridViewCellStyle p_dataGridViewCellStyle)
      {
         base.Font = p_dataGridViewCellStyle.Font;
         base.ForeColor = p_dataGridViewCellStyle.ForeColor;
         base.BackColor = p_dataGridViewCellStyle.BackColor;
      }
      void IDataGridViewEditingControl.PrepareEditingControlForEdit(bool selectAll)
      {

      }

      #endregion

      #region [ EVENTS ]

      public event ButtonClickEventHandler ButtonClick;
      public delegate void ButtonClickEventHandler(object sender, EventArgs e);
      private void HelpButton_Click(object sender, EventArgs e)
      {
         ButtonClick?.Invoke(sender, e);
      }
      protected override void OnTextChanged(EventArgs e)
      {
         pv_valueIsChanged = true;
         this.EditingControlDataGridView.NotifyCurrentCellDirty(true);
         base.OnTextChanged(e);
      }

      #endregion

   }

   public class DataGridViewHelpTextBoxColumn : DataGridViewColumn
   {
      #region [ PROPERTIES ]

      public override DataGridViewCell CellTemplate
      {
         get { return base.CellTemplate; }
         set
         {
            if ((value != null) && !value.GetType().IsAssignableFrom(typeof(DataGridViewHelpTextBoxCell)))
            {
               throw new InvalidCastException("Debe ser un DataGridViewHelpTextBoxCell");
            }
            base.CellTemplate = value;
         }
      }

      #endregion

      #region [ CONSTRUCTORS ]

      public DataGridViewHelpTextBoxColumn()
         : base()
      {
         DataGridViewHelpTextBoxCell HelpTextBoxCell = new DataGridViewHelpTextBoxCell();
         base.CellTemplate = HelpTextBoxCell;
      }

      #endregion
   }

   public class DataGridViewHelpTextBoxCell : DataGridViewTextBoxCell
   {
      #region [ PROPERTIES ]

      public override Type EditType
      {
         get { return typeof(DataGridViewHelpTextBox); }
      }
      public override Type ValueType
      {
         get { return typeof(string); }
      }
      public override object DefaultNewRowValue
      {
         get { return string.Empty; }
      }

      #endregion

      #region [ CONSTRUCTORS ]

      public DataGridViewHelpTextBoxCell()
         : base()
      {
         this.Style.Format = "";
      }

      #endregion

      #region [ METHODS ]

      public override void InitializeEditingControl(int p_rowIndex, object p_initialFormattedValue, DataGridViewCellStyle p_dataGridViewCellStyle)
      {
         try
         {
            base.InitializeEditingControl(p_rowIndex, p_initialFormattedValue, p_dataGridViewCellStyle);
            DataGridViewHelpTextBoxControl ctl = (DataGridViewHelpTextBoxControl)DataGridView.EditingControl;
            try
            { ctl.Text = (string)(object.ReferenceEquals(this.Value, DBNull.Value) ? "" : this.Value); }
            catch (Exception)
            { ctl.Text = ""; }
         }
         catch (Exception)
         { }
      }

      #endregion
   }

}
