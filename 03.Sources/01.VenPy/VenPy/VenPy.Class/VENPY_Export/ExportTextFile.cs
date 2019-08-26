using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace VenPy.Class
{
    public class ExportTextFile
    {
        public static void ExportToTextFile(String p_title, DataGridView p_dgvItems, List<String> p_subtitle)
        {
            try
            {
                String l_FileName = p_title;
                String l_Path = null;
                SaveFileDialog FRM_SaveFileDialog = new SaveFileDialog();
                FRM_SaveFileDialog.Title = p_title;
                FRM_SaveFileDialog.Filter = "txt files (*.txt)|*.txt";
                FRM_SaveFileDialog.FilterIndex = 1;
                FRM_SaveFileDialog.RestoreDirectory = true;
                FRM_SaveFileDialog.FileName = l_FileName;
                FRM_SaveFileDialog.DefaultExt = ".txt";
                if (FRM_SaveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    l_Path = FRM_SaveFileDialog.FileName;
                    if (!string.IsNullOrEmpty(l_Path))
                    {
                        #region [ DataTable ]

                        int l_width = 0;
                        List<int> l_maximumLength = new List<int>();
                        for (int x = 0; x < p_dgvItems.Columns.Count; x++)
                        {
                            int l_length = p_dgvItems.Columns[x].HeaderText.Length;
                            string l_format = p_dgvItems.Columns[x].DefaultCellStyle.Format == null ? string.Empty : p_dgvItems.Columns[x].DefaultCellStyle.Format;
                            string l_stringFormat = "{0:" + l_format + "}";
                            for (int y = 0; y < p_dgvItems.Rows.Count; y++)
                            {
                                string l_info = p_dgvItems.Rows[y].Cells[x].Value == null ? string.Empty : string.Format(l_stringFormat, p_dgvItems.Rows[y].Cells[x].Value).ToString();
                                if (l_info.Length > l_length)
                                { l_length = l_info.ToString().Length; }
                            }
                            l_maximumLength.Add(l_length);
                        }

                        DataTable l_Data = new DataTable(p_title);
                        int l_realIndex = 0;
                        List<int> l_listIndex = new List<int>();
                        foreach (DataGridViewColumn l_column in p_dgvItems.Columns)
                        {
                            if (l_column.Name != "Edit" && l_column.Name != "Delete" && l_column.Visible)
                            {
                                l_width += l_maximumLength[l_realIndex] + 3;
                                l_Data.Columns.Add(l_column.HeaderText.PadRight(l_maximumLength[l_realIndex]), typeof(string));
                                l_listIndex.Add(l_realIndex);
                            }
                            l_realIndex++;
                        }
                        foreach (DataGridViewRow l_row in p_dgvItems.Rows)
                        {
                            DataRow _NewRow = l_Data.NewRow();
                            int indiceRow = 0;
                            for (int i = 0; i < l_row.Cells.Count; i++)
                            {
                                if (l_listIndex.Contains(i))
                                {
                                    string l_valueType = p_dgvItems.Columns[i].ValueType.FullName;
                                    string l_format = p_dgvItems.Columns[i].DefaultCellStyle.Format == null ? string.Empty : p_dgvItems.Columns[i].DefaultCellStyle.Format;
                                    string l_value = string.Empty;
                                    string l_stringFormat = "{0:" + l_format + "}";
                                    switch (l_valueType)
                                    {
                                        case "System.String":
                                            l_value = l_row.Cells[i].Value == null ? string.Empty.PadRight(l_maximumLength[i]) : l_row.Cells[i].Value.ToString().PadRight(l_maximumLength[i]);
                                            break;
                                        case "System.Boolean":
                                            l_value = l_row.Cells[i].Value == null ? string.Empty.PadRight(l_maximumLength[i]) : l_row.Cells[i].Value.ToString().PadRight(l_maximumLength[i]);
                                            break;
                                        case "System.Long":
                                        case "System.Int":
                                        case "System.Int16":
                                        case "System.Int32":
                                        case "System.Int64":
                                            l_value = l_row.Cells[i].Value == null ? string.Empty.PadRight(l_maximumLength[i]) : string.Format(l_stringFormat, l_row.Cells[i].Value).PadLeft(l_maximumLength[i]);
                                            break;
                                        case "System.DateTime":
                                            l_value = l_row.Cells[i].Value == null ? string.Empty.PadRight(l_maximumLength[i]) : string.Format(l_stringFormat, l_row.Cells[i].Value).PadLeft(l_maximumLength[i]);
                                            break;
                                        case "System.Decimal":
                                        case "System.Double":
                                        case "System.Float":
                                            l_value = l_row.Cells[i].Value == null ? string.Empty.PadRight(l_maximumLength[i]) : string.Format(l_stringFormat, l_row.Cells[i].Value).PadLeft(l_maximumLength[i]);
                                            break;
                                        default:
                                            l_value = l_row.Cells[i].Value == null ? string.Empty.PadRight(l_maximumLength[i]) : l_row.Cells[i].Value.ToString().PadRight(l_maximumLength[i]);
                                            break;
                                    }
                                    _NewRow[indiceRow] = l_value;
                                    indiceRow++;
                                }
                            }
                            l_Data.Rows.Add(_NewRow);
                        }

                        #endregion

                        #region [ TxtFile ]

                        int l_center = (l_width / 2) - (p_title.Length / 2);

                        using (StreamWriter l_StreamWriter = new StreamWriter(l_Path, false))
                        {
                            l_StreamWriter.WriteLine();
                            l_StreamWriter.Write("  " + p_title.ToUpper().PadLeft(l_center));
                            l_StreamWriter.WriteLine();
                            l_StreamWriter.Write("  ".PadRight(l_width, '='));
                            l_StreamWriter.WriteLine();
                            foreach (string subtitle in p_subtitle)
                            {
                                l_StreamWriter.Write("  " + subtitle.ToUpper());
                                l_StreamWriter.WriteLine();
                            }
                            l_StreamWriter.WriteLine();
                            l_StreamWriter.Write("  ".PadRight(l_width, '='));
                            l_StreamWriter.WriteLine();
                            for (int j = 0; j < l_Data.Columns.Count; j++)
                            {
                                if (j == 0)
                                { l_StreamWriter.Write("  " + l_Data.Columns[j].ColumnName + "   "); }
                                else
                                { l_StreamWriter.Write(l_Data.Columns[j].ColumnName + "   "); }
                            }
                            l_StreamWriter.WriteLine();
                            l_StreamWriter.Write("  ".PadRight(l_width, '='));
                            l_StreamWriter.WriteLine();
                            foreach (DataRow row in l_Data.Rows)
                            {
                                object[] array = row.ItemArray;
                                l_StreamWriter.Write("  " + string.Join("   ", array) + "   ");
                                l_StreamWriter.WriteLine();
                            }
                            l_StreamWriter.Write("  ".PadRight(l_width, '='));
                        }

                        if (File.Exists(l_Path))
                        { Process.Start(l_Path); }

                        #endregion
                    }
                }
            }
            catch (Exception ex)
            { throw ex; }
        }
        public static void ExportToTextFile(String p_title, DataTable p_dataTable, List<String> p_subtitle, List<ExportColumns> p_exportColumns)
        {
            try
            {
                String l_FileName = p_title;
                String l_Path = null;
                SaveFileDialog FRM_SaveFileDialog = new SaveFileDialog();
                FRM_SaveFileDialog.Title = p_title;
                FRM_SaveFileDialog.Filter = "txt files (*.txt)|*.txt";
                FRM_SaveFileDialog.FilterIndex = 1;
                FRM_SaveFileDialog.RestoreDirectory = true;
                FRM_SaveFileDialog.FileName = l_FileName;
                FRM_SaveFileDialog.DefaultExt = ".txt";
                if (FRM_SaveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    l_Path = FRM_SaveFileDialog.FileName;
                    if (!string.IsNullOrEmpty(l_Path))
                    {
                        #region [ DataTable ]

                        int l_width = 0;
                        List<int> l_maximumLength = new List<int>();
                        DataTable l_data = new DataTable(p_title);
                        foreach (ExportColumns x_exportColumn in p_exportColumns)
                        {
                            int l_length = x_exportColumn.ColumnCaption.Length;
                            string l_format = x_exportColumn.Format == null ? string.Empty : x_exportColumn.Format;
                            string l_stringFormat = "{0:" + l_format + "}";
                            for (int y = 0; y < p_dataTable.Rows.Count; y++)
                            {
                                string l_info = p_dataTable.Rows[y][x_exportColumn.ColumnName] == null ? string.Empty : string.Format(l_stringFormat, p_dataTable.Rows[y][x_exportColumn.ColumnName]).ToString();
                                if (l_info.Length > l_length)
                                { l_length = l_info.ToString().Length; }
                            }
                            l_maximumLength.Add(l_length);
                        }
                        if (p_exportColumns != null)
                        {
                            for (int i = 0; i < p_exportColumns.Count(); i++)
                            {
                                DataColumn l_DataColumn = new DataColumn();
                                l_DataColumn.ColumnName = p_exportColumns.ElementAt(i).ColumnName;
                                l_DataColumn.Caption = p_exportColumns.ElementAt(i).ColumnCaption.PadRight(l_maximumLength[i]);
                                l_DataColumn.DataType = p_exportColumns.ElementAt(i).DataType = p_exportColumns.ElementAt(i).DataType == null ? Type.GetType("System.String") : p_exportColumns.ElementAt(i).DataType;
                                l_data.Columns.Add(l_DataColumn);
                            }
                            for (int j = 0; j < p_dataTable.Rows.Count; j++)
                            {
                                DataRow l_DataRow = l_data.NewRow();
                                for (int k = 0; k < l_data.Columns.Count; k++)
                                {
                                    if (j == 0)
                                    { l_width += l_maximumLength[k] + 3; }
                                    string l_valueType = p_exportColumns[k].DataType.FullName;
                                    string l_format = p_exportColumns[k].Format == null ? string.Empty : p_exportColumns[k].Format;
                                    string l_value = string.Empty;
                                    string l_stringFormat = "{0:" + l_format + "}";
                                    switch (l_valueType)
                                    {
                                        case "System.String":
                                            l_value = p_dataTable.Rows[j][l_data.Columns[k].ColumnName] == null ? string.Empty.PadRight(l_maximumLength[k]) : p_dataTable.Rows[j][l_data.Columns[k].ColumnName].ToString().PadRight(l_maximumLength[k]);
                                            break;
                                        case "System.Boolean":
                                            l_value = p_dataTable.Rows[j][l_data.Columns[k].ColumnName] == null ? string.Empty.PadRight(l_maximumLength[k]) : p_dataTable.Rows[j][l_data.Columns[k].ColumnName].ToString().PadRight(l_maximumLength[k]);
                                            break;
                                        case "System.Long":
                                        case "System.Int":
                                        case "System.Int16":
                                        case "System.Int32":
                                        case "System.Int64":
                                            l_value = p_dataTable.Rows[j][l_data.Columns[k].ColumnName] == null ? string.Empty.PadRight(l_maximumLength[k]) : string.Format(l_stringFormat, p_dataTable.Rows[j][l_data.Columns[k].ColumnName]).PadLeft(l_maximumLength[k]);
                                            break;
                                        case "System.DateTime":
                                            l_value = p_dataTable.Rows[j][l_data.Columns[k].ColumnName] == null ? string.Empty.PadRight(l_maximumLength[k]) : string.Format(l_stringFormat, p_dataTable.Rows[j][l_data.Columns[k].ColumnName]).PadLeft(l_maximumLength[k]);
                                            break;
                                        case "System.Decimal":
                                        case "System.Double":
                                        case "System.Float":
                                            l_value = p_dataTable.Rows[j][l_data.Columns[k].ColumnName] == null ? string.Empty.PadRight(l_maximumLength[k]) : string.Format(l_stringFormat, p_dataTable.Rows[j][l_data.Columns[k].ColumnName]).PadLeft(l_maximumLength[k]);
                                            break;
                                        default:
                                            l_value = p_dataTable.Rows[j][l_data.Columns[k].ColumnName] == null ? string.Empty.PadRight(l_maximumLength[k]) : p_dataTable.Rows[j][l_data.Columns[k].ColumnName].ToString().PadRight(l_maximumLength[k]);
                                            break;
                                    }
                                    l_DataRow[k] = l_value;
                                }
                                l_data.Rows.Add(l_DataRow);
                            }
                        }

                        #endregion

                        #region [ TxtFile ]

                        int l_center = (l_width / 2) - (p_title.Length / 2);

                        using (StreamWriter l_StreamWriter = new StreamWriter(l_Path, false))
                        {
                            l_StreamWriter.WriteLine();
                            l_StreamWriter.Write("  " + p_title.ToUpper().PadLeft(l_center));
                            l_StreamWriter.WriteLine();
                            l_StreamWriter.Write("  ".PadRight(l_width, '='));
                            l_StreamWriter.WriteLine();
                            foreach (string subtitle in p_subtitle)
                            {
                                l_StreamWriter.Write("  " + subtitle.ToUpper());
                                l_StreamWriter.WriteLine();
                            }
                            l_StreamWriter.WriteLine();
                            l_StreamWriter.Write("  ".PadRight(l_width, '='));
                            l_StreamWriter.WriteLine();
                            for (int j = 0; j < l_data.Columns.Count; j++)
                            {
                                if (j == 0)
                                { l_StreamWriter.Write("  " + l_data.Columns[j].Caption + "   "); }
                                else
                                { l_StreamWriter.Write(l_data.Columns[j].Caption + "   "); }
                            }
                            l_StreamWriter.WriteLine();
                            l_StreamWriter.Write("  ".PadRight(l_width, '='));
                            l_StreamWriter.WriteLine();
                            foreach (DataRow row in l_data.Rows)
                            {
                                object[] array = row.ItemArray;
                                l_StreamWriter.Write("  " + string.Join("   ", array) + "   ");
                                l_StreamWriter.WriteLine();
                            }
                            l_StreamWriter.Write("  ".PadRight(l_width, '='));
                        }

                        if (File.Exists(l_Path))
                        { Process.Start(l_Path); }

                        #endregion
                    }
                }
            }
            catch (Exception ex)
            { throw ex; }
        }
    }
}
