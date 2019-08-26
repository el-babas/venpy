using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Windows.Forms;

namespace VenPy.Controls
{
    public partial class CustomDataGridViewTextBoxNumeric : CustomGridViewTextBoxNumeric, IDataGridViewEditingControl
    {
        #region [ VARIABLES ]

        private Int32 pv_rowindexnum;
        private Boolean pv_valueischanged = false;
        private DataGridView pv_datagridviewcontrol;

        #endregion

        #region [ PROPERTIES ]

        DataGridView IDataGridViewEditingControl.EditingControlDataGridView
        {
            get { return pv_datagridviewcontrol; }
            set { pv_datagridviewcontrol = value; }
        }
        Object IDataGridViewEditingControl.EditingControlFormattedValue
        {
            get { return this.Text; }
            set { this.Text = value.ToString(); }
        }
        Int32 IDataGridViewEditingControl.EditingControlRowIndex
        {
            get { return pv_rowindexnum; }
            set { pv_rowindexnum = value; }
        }
        Boolean IDataGridViewEditingControl.EditingControlValueChanged
        {
            get { return pv_valueischanged; }
            set { pv_valueischanged = value; }
        }
        Boolean IDataGridViewEditingControl.RepositionEditingControlOnValueChange
        {
            get { return false; }
        }
        Cursor IDataGridViewEditingControl.EditingPanelCursor
        {
            get { return base.Cursor; }
        }

        #endregion

        #region [ CONSTRUCTORS ]

        public CustomDataGridViewTextBoxNumeric()
        { Text = string.Empty; }

        #endregion

        #region [ METHODS ]

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.ValidateKeyPress(e);
            base.OnKeyPress(e);
        }
        protected override void OnValidating(CancelEventArgs e)
        {
            base.OnValidating(e);
        }
        protected override void OnTextChanged(EventArgs e)
        {
            pv_valueischanged = true;
            this.EditingControlDataGridView.NotifyCurrentCellDirty(true);
            base.OnTextChanged(e);
        }
        protected override void OnCausesValidationChanged(EventArgs e)
        {
            base.OnCausesValidationChanged(e);
        }
        public virtual DataGridView EditingControlDataGridView
        {
            get { return this.pv_datagridviewcontrol; }
            set { this.pv_datagridviewcontrol = value; }
        }
        void IDataGridViewEditingControl.ApplyCellStyleToEditingControl(DataGridViewCellStyle p_dataGridViewCellStyle)
        {
            base.Font = p_dataGridViewCellStyle.Font;
            base.ForeColor = p_dataGridViewCellStyle.ForeColor;
            base.BackColor = p_dataGridViewCellStyle.BackColor;
        }
        void IDataGridViewEditingControl.PrepareEditingControlForEdit(Boolean p_selectAll)
        { }
        bool IDataGridViewEditingControl.EditingControlWantsInputKey(Keys p_keyData, Boolean p_dataGridViewWantsInputKey)
        {
            if (p_keyData == Keys.Escape)
            { return false; }
            else
            { return true; }
        }
        object IDataGridViewEditingControl.GetEditingControlFormattedValue(DataGridViewDataErrorContexts p_context)
        { return Text; }

        #endregion
    }
    public partial class CustomDataGridViewTextBoxNumericColumn : DataGridViewColumn
    {
        #region [ VARIABLES ]

        private CustomDataGridViewTextBoxNumericCell pv_textboxnumerico;

        #endregion

        #region [ PROPERTIES ]

        public override DataGridViewCell CellTemplate
        {
            get
            { return base.CellTemplate; }
            set
            {
                if ((value != null) && !value.GetType().IsAssignableFrom(typeof(CustomDataGridViewTextBoxNumericCell)))
                {
                    throw new InvalidCastException("Debe ser un CustomDataGridViewTextBoxNumericCell");
                }
                base.CellTemplate = value;
            }
        }

        #endregion

        #region [ CONSTRUCTORS ]

        public CustomDataGridViewTextBoxNumericColumn() : base()
        {
            pv_textboxnumerico = new CustomDataGridViewTextBoxNumericCell();
            base.CellTemplate = pv_textboxnumerico;
        }

        #endregion
    }
    public partial class CustomDataGridViewTextBoxNumericCell : DataGridViewTextBoxCell
    {
        #region [ PROPERTIES ]

        public override Type EditType
        {
            get { return typeof(CustomDataGridViewTextBoxNumeric); }
        }
        public override Type ValueType
        {
            get { return typeof(string); }
        }
        public override Object DefaultNewRowValue
        {
            get { return "0"; }
        }

        #endregion

        #region [ CONSTRUCTORS ]

        public CustomDataGridViewTextBoxNumericCell() : base()
        { Style.Format = string.Empty; }

        #endregion

        #region [ METHODS ]

        public override void InitializeEditingControl(int p_rowIndex, object p_initialFormattedValue, DataGridViewCellStyle p_dataGridViewCellStyle)
        {
            try
            {
                base.InitializeEditingControl(p_rowIndex, p_initialFormattedValue, p_dataGridViewCellStyle);
                CustomDataGridViewTextBoxNumeric l_customDataGridViewTextBoxNumeric = (CustomDataGridViewTextBoxNumeric)DataGridView.EditingControl;
                try
                { l_customDataGridViewTextBoxNumeric.Text = (string)(ReferenceEquals(Value, DBNull.Value) ? "" : Value); }
                catch (Exception)
                { l_customDataGridViewTextBoxNumeric.Text = string.Empty; }
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion
    }
}
