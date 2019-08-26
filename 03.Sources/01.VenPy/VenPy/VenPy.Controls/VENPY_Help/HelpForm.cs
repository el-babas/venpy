using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VenPy.Controls
{
    public partial class HelpForm : Form
    {
        #region [ VARIABLES ]

        private BindingSource pv_binding;
        private DataTable pv_answer;

        #endregion

        #region [ PROPERTIES ]

        public new Color BackColor { get; set; }
        public String Title
        {
            get { return Text; }
            set { Text = value; lblTitle.Text = value; }
        }
        public Boolean IsBackColor { get; set; }
        public Boolean MultiSelect
        {
            get { return dgvItems.MultiSelect; }
            set { dgvItems.MultiSelect = value; }
        }
        public DataTable Answer
        { get { return pv_answer; } }

        #endregion

        #region [ FORM ]

        public HelpForm(String p_title, DataTable p_data, Boolean p_multiselect)
        {
            InitializeComponent();
            txtFilter.TextChanged += txtBus_TextChanged;
            txtFilter.KeyDown += txtBus_KeyDown;
            FormatGrid();
            try
            {
                pv_binding = new BindingSource();
                Title = p_title;
                MultiSelect = p_multiselect;
                LoadData(p_data);
                StartPosition = FormStartPosition.CenterParent;
                ShowInTaskbar = false;
            }
            catch (Exception ex)
            { throw ex; }
        }
        public HelpForm(String p_title, DataTable p_data, Boolean p_multiselect, IEnumerable<HelpColumn> p_columns, String p_filter = "")
        {
            InitializeComponent();
            txtFilter.TextChanged += txtBus_TextChanged;
            txtFilter.KeyDown += txtBus_KeyDown;
            IsBackColor = true;
            BackColor = Color.LightGreen;
            FormatGrid();
            try
            {
                pv_binding = new BindingSource();
                Title = p_title;
                MultiSelect = p_multiselect;
                LoadData(p_data, p_columns);
                txtFilter.Text = p_filter;
                StartPosition = FormStartPosition.CenterParent;
                ShowInTaskbar = false;
            }
            catch (Exception ex)
            { throw ex; }
        }
        private void HelpForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (pv_binding != null && pv_binding.DataSource != null && ((DataTable)pv_binding.DataSource).Rows.Count == 0)
                {
                    Messages.ShowInformationMessage(Title, "No se encontrarón resultados", Messages.TButtons.btn_Accept);
                    this.Close();
                }
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ METHODS ]

        private void FormatGrid()
        {
            dgvItems.RowHeadersVisible = false;
            dgvItems.AutoGenerateColumns = false;
            dgvItems.RowTemplate.Height = 16;
            dgvItems.ColumnHeadersHeight = 18;
            dgvItems.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvItems.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
        }
        public void LoadData(DataTable p_data)
        {
            try
            {
                dgvItems.Columns.Clear();
                dgvItems.AutoGenerateColumns = false;
                dgvItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvItems.AllowUserToAddRows = false;
                dgvItems.AllowUserToDeleteRows = false;
                dgvItems.AllowUserToResizeRows = false;
                foreach (DataColumn l_column in p_data.Columns)
                {
                    DataGridViewTextBoxColumn l_newColumn = new DataGridViewTextBoxColumn();
                    l_newColumn.Name = l_column.ColumnName;
                    l_newColumn.DataPropertyName = l_column.ColumnName;
                    l_newColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    l_newColumn.HeaderText = !String.IsNullOrEmpty(l_column.Caption) ? l_column.Caption : l_column.ColumnName;
                    dgvItems.Columns.Add(l_newColumn);
                }
                dgvItems.Columns[0].DefaultCellStyle.BackColor = BackColor;
                dgvItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                pv_binding.DataSource = null;
                pv_binding.DataSource = p_data;
                dgvItems.DataSource = pv_binding;
                pv_binding.ResetBindings(true);
                if (IsNumericType(dgvItems.Columns[0].ValueType))
                { txtFilter.Text = string.Empty; }
                else
                { txtFilter.Text = string.Empty; }
            }
            catch (Exception ex)
            { throw ex; }
        }
        public void LoadData(DataTable p_data, IEnumerable<HelpColumn> p_columns)
        {
            try
            {
                dgvItems.Columns.Clear();
                dgvItems.AutoGenerateColumns = false;
                dgvItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvItems.AllowUserToAddRows = false;
                dgvItems.AllowUserToDeleteRows = false;
                dgvItems.AllowUserToResizeRows = false;
                if (p_columns != null)
                {
                    for (int i = 0; i < p_columns.Count(); i++)
                    {
                        DataGridViewTextBoxColumn l_newColumn = new DataGridViewTextBoxColumn();
                        l_newColumn.Name = p_columns.ElementAt(i).ColumnName;
                        l_newColumn.DataPropertyName = p_columns.ElementAt(i).ColumnName;
                        l_newColumn.HeaderText = p_columns.ElementAt(i).ColumnCaption;
                        l_newColumn.DisplayIndex = p_columns.ElementAt(i).Index;
                        l_newColumn.DefaultCellStyle.Alignment = p_columns.ElementAt(i).Alignment;
                        if (p_columns.ElementAt(i).Width > 0)
                        { l_newColumn.Width = p_columns.ElementAt(i).Width; }
                        else
                        { l_newColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells; }
                        l_newColumn.DefaultCellStyle.Format = p_columns.ElementAt(i).Format;
                        l_newColumn.Resizable = DataGridViewTriState.True;
                        if (p_columns.ElementAt(i).IsBackColor) { l_newColumn.DefaultCellStyle.BackColor = p_columns.ElementAt(i).BackColor; }
                        dgvItems.Columns.Add(l_newColumn);
                    }
                    if (dgvItems.Columns.Count > 0) { dgvItems.Columns[0].DefaultCellStyle.BackColor = BackColor; }
                }
                dgvItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                pv_binding.DataSource = null;
                pv_binding.DataSource = p_data;
                dgvItems.DataSource = pv_binding;
                pv_binding.ResetBindings(true);
            }
            catch (Exception ex)
            { throw ex; }
        }
        private bool LoadAnswer()
        {
            try
            {
                pv_answer = new DataTable();
                pv_answer = ((DataTable)pv_binding.DataSource).Copy();
                pv_answer.Rows.Clear();
                foreach (DataGridViewRow l_row in dgvItems.Rows)
                {
                    if (l_row.Selected)
                    {
                        DataRow l_dataRow = pv_answer.NewRow();
                        foreach (DataColumn column in pv_answer.Columns)
                        {
                            l_dataRow[column] = ((DataRowView)l_row.DataBoundItem).Row[column.ColumnName];
                        }
                        pv_answer.Rows.Add(l_dataRow);
                    }
                }
                return (pv_answer != null && pv_answer.Rows.Count > 0);
            }
            catch (Exception)
            { return false; }
        }
        private bool IsNumericType(Type p_type)
        {
            switch (p_type.FullName)
            {
                case "System.Byte": return true;
                case "System.SByte": return true;
                case "System.Int16": return true;
                case "System.UInt16": return true;
                case "System.Int32": return true;
                case "System.UInt32": return true;
                case "System.Int64": return true;
                case "System.UInt64": return true;
                case "System.Single": return true;
                case "System.Double": return true;
                case "System.Decimal": return true;
                default: return false;
            }
        }

        #endregion

        #region [ EVENTS ]

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (LoadAnswer())
            { this.DialogResult = DialogResult.OK; }
            else
            { this.DialogResult = DialogResult.Cancel; }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DataTable l_dataTable = ((DataTable)pv_binding.DataSource).Copy();
            l_dataTable.Rows.Clear();
            this.DialogResult = DialogResult.Cancel;
        }
        private void txtBus_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string l_column = dgvItems.Columns.GetFirstColumn(DataGridViewElementStates.Displayed).Name;
                string l_value = txtFilter.Text.Trim();
                if (!string.IsNullOrEmpty(l_value))
                {
                    if (IsNumericType(((DataTable)((BindingSource)dgvItems.DataSource).DataSource).Columns[dgvItems.Columns.GetFirstColumn(DataGridViewElementStates.Displayed).Name].DataType))
                    { pv_binding.Filter = "[" + l_column + "] = " + l_value; }
                    else
                    { pv_binding.Filter = "[" + l_column + "] like '" + l_value + "%'"; }
                }
                else
                { pv_binding.Filter = null; }
            }
            catch (Exception ex)
            { throw ex; }
        }
        private void txtBus_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            { pv_binding.MoveNext(); }
            else if (e.KeyCode == Keys.Up)
            { pv_binding.MovePrevious(); }
            else if (e.KeyCode == Keys.Next)
            { pv_binding.MoveNext(); }
            else if (e.KeyCode == Keys.Back)
            { pv_binding.MovePrevious(); }
        }
        private void dgvItems_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (LoadAnswer())
                { this.DialogResult = DialogResult.OK; }
            }
        }
        private void dgvItems_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvItems.Columns[e.ColumnIndex].DisplayIndex = 0;
            try
            {
                if (IsBackColor)
                {
                    foreach (DataGridViewColumn l_column in dgvItems.Columns)
                    { l_column.DefaultCellStyle.BackColor = Color.White; }
                    dgvItems.Columns[e.ColumnIndex].DefaultCellStyle.BackColor = BackColor;
                    if (IsNumericType(dgvItems.Columns[e.ColumnIndex].ValueType))
                    { txtFilter.Text = string.Empty; }
                    else
                    { txtFilter.Text = string.Empty; }
                }
            }
            catch (Exception ex)
            { throw ex; }
        }
        private void dgvItems_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (LoadAnswer())
                { this.DialogResult = DialogResult.OK; }
                else
                { this.DialogResult = DialogResult.Cancel; }
            }
        }

        #endregion
    }

    public partial class HelpColumn
    {
        #region [ CONSTRUCTORS ]

        public HelpColumn()
        {
            Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataType = typeof(string);
            Format = null;
        }

        #endregion

        #region [ PROPERTIES ]

        public Type DataType { get; set; }
        public Int32 Index { get; set; }
        public Int32 Width { get; set; }
        public Color BackColor { get; set; }
        public String ColumnName { get; set; }
        public String ColumnCaption { get; set; }
        public String Format { get; set; }
        public Boolean IsBackColor { get; set; }
        public DataGridViewContentAlignment Alignment { get; set; }

        #endregion
    }
}
