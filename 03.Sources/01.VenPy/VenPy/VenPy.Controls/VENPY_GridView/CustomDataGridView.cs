using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VenPy.Controls
{
   public partial class CustomDataGridView : DataGridView
   {
      #region [ CONSTRUCTORS ]

      public CustomDataGridView()
      {
         InitializeComponent();
         /* Hide the selection column */
         RowHeadersVisible = false;
      }

      #endregion

      #region [ METHODS ]

      public void AddImageColumn(String p_headerText, String p_dataColumnName, String p_columnName, Int32 p_width, Image p_image, String p_format, DataGridViewContentAlignment p_contentAlignment)
      {
         DataGridViewImageColumn l_column = new DataGridViewImageColumn();
         if (p_columnName.Trim() != "")
         { l_column.Name = p_columnName; }
         l_column.HeaderText = p_headerText;
         l_column.DataPropertyName = p_dataColumnName;
         l_column.Width = p_width;
         l_column.Image = p_image;
         l_column.DefaultCellStyle.Alignment = p_contentAlignment;
         if (!string.IsNullOrEmpty(p_format))
         { l_column.DefaultCellStyle.Format = p_format; }
         Columns.Add(l_column);
      }
      public void AddTextBoxColumn(String p_headerText, String p_dataColumnName, String p_columnName, Int32 p_width, Boolean p_readOnly, String p_format, DataGridViewContentAlignment p_contentAlignment)
      {
         DataGridViewTextBoxColumn l_column = new DataGridViewTextBoxColumn();
         if (p_columnName.Trim() != "")
         { l_column.Name = p_columnName; }
         l_column.HeaderText = p_headerText;
         l_column.DataPropertyName = p_dataColumnName;
         l_column.Width = p_width;
         l_column.ReadOnly = p_readOnly;
         l_column.DefaultCellStyle.Alignment = p_contentAlignment;
         if (!string.IsNullOrEmpty(p_format))
         { l_column.DefaultCellStyle.Format = p_format; }
         Columns.Add(l_column);
      }
      public void AddHelpTextBoxColumn(String p_headerText, String p_dataColumnName, String p_columnName, Int32 p_width, Boolean p_readOnly)
      {
         DataGridViewHelpTextBoxColumn l_column = new DataGridViewHelpTextBoxColumn();
         if (p_columnName.Trim() != "")
         { l_column.Name = p_columnName; }
         l_column.HeaderText = p_headerText;
         l_column.DataPropertyName = p_dataColumnName;
         l_column.Width = p_width;
         l_column.ReadOnly = p_readOnly;
         l_column.Visible = true;
         l_column.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
         l_column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
         l_column.SortMode = DataGridViewColumnSortMode.NotSortable;
         Columns.Add(l_column);
      }
      public void AddTextBoxNumericColumn(String p_headerText, String p_dataColumnName, String p_columnName, Int32 p_width, Boolean p_readOnly, DataGridViewContentAlignment p_contentAlignment, Int32 p_enteros, Int32 p_decimales)
      {
         CustomDataGridViewTextBoxNumericColumn l_column = new CustomDataGridViewTextBoxNumericColumn();
         string l_formato = string.Empty;
         if (p_columnName.Trim() != "")
         { l_column.Name = p_columnName; }
         l_column.HeaderText = p_headerText;
         l_column.DataPropertyName = p_dataColumnName;
         l_column.Width = p_width;
         l_column.ReadOnly = p_readOnly;
         l_column.DefaultCellStyle.Alignment = p_contentAlignment;
         try
         {
            string l_decimalSeparator = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
            string l_groupSeparator = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberGroupSeparator;
            string l_enteros = "0";
            string l_decimales = "";
            for (int i = 0; i < p_decimales; i++)
            { l_decimales += "0"; }
            for (int i = 2; i <= p_enteros; i++)
            {
               l_enteros = "#" + l_enteros;
               if ((l_enteros.Replace(l_groupSeparator, "").ToString().Length % 3) == 0 && i != p_enteros)
               { l_enteros = l_groupSeparator + l_enteros; }
            }
            l_formato = l_enteros + l_decimalSeparator + l_decimales;
            l_column.DefaultCellStyle.Format = l_formato;
         }
         catch (Exception ex)
         { throw ex; }
         if (!string.IsNullOrEmpty(l_formato))
         { l_column.DefaultCellStyle.Format = l_formato; }
         Columns.Add(l_column);
      }
      public void AddCheckBoxColumn(String p_headerText, String p_dataColumnName, String p_columnName, Int32 p_width, Boolean p_readOnly)
      {
         DataGridViewCheckBoxColumn l_column = new DataGridViewCheckBoxColumn();
         if (p_columnName.Trim() != "")
         { l_column.Name = p_columnName; }
         l_column.HeaderText = p_headerText;
         l_column.DataPropertyName = p_dataColumnName;
         l_column.Width = p_width;
         l_column.ReadOnly = p_readOnly;
         Columns.Add(l_column);
      }
      public void AddComboBoxColumn(String p_headerText, String p_dataColumnName, String p_columnName, Int32 p_width, Boolean p_readOnly, DataTable p_dataSource, String p_displayMember, String p_valueMember)
      {
         DataGridViewComboBoxColumn l_column = new DataGridViewComboBoxColumn();
         if (p_columnName.Trim() != "")
         { l_column.Name = p_columnName; }
         l_column.HeaderText = p_headerText;
         l_column.DataPropertyName = p_dataColumnName;
         l_column.Width = p_width;
         l_column.ReadOnly = p_readOnly;
         l_column.DataSource = p_dataSource;
         l_column.ValueMember = p_valueMember;
         l_column.DisplayMember = p_displayMember;
         l_column.FlatStyle = FlatStyle.Flat;
         l_column.DisplayStyleForCurrentCellOnly = true;
         Columns.Add(l_column);
      }

      #endregion
   }
}
