using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VenPy.Class
{
    public class ExportExcel
    {
        public static void ExportToExcel(String p_title, DataGridView p_dgvItems, List<String> p_subtitle)
        {
            try
            {
                List<string> l_listTitles = new List<string>();
                l_listTitles.Add(p_title);
                int l_initialRow = 2;
                int l_initialColumn = 2;
                int l_realIndex = 0;
                ExcelDocuments l_excelDocuments = new ExcelDocuments(1, l_listTitles);
                List<string> l_listHeaders = new List<string>();
                DataTable l_data = new DataTable(p_title);
                List<int> l_listIndex = new List<int>();
                foreach (DataGridViewColumn l_column in p_dgvItems.Columns)
                {
                    if (l_column.Name != "Edit" && l_column.Name != "Delete" && l_column.Visible)
                    {
                        if (l_column.ValueType.Name.Contains("Nullable"))
                        { l_data.Columns.Add(l_column.HeaderText); }
                        else
                        { l_data.Columns.Add(l_column.HeaderText, l_column.ValueType); }
                        l_listHeaders.Add(l_column.HeaderText);
                        l_listIndex.Add(l_realIndex);
                    }
                    l_realIndex++;
                }
                foreach (DataGridViewRow l_row in p_dgvItems.Rows)
                {
                    DataRow _NewRow = l_data.NewRow();
                    int indiceRow = 0;
                    for (int i = 0; i < l_row.Cells.Count; i++)
                    {
                        if (l_listIndex.Contains(i))
                        {
                            _NewRow[indiceRow] = l_row.Cells[i].Value;
                            indiceRow++;
                        }
                    }
                    l_data.Rows.Add(_NewRow);
                }
                string[] l_headers = l_listHeaders.ToArray();
                if (l_data.Rows.Count > 0)
                {
                    if (p_subtitle == null || p_subtitle.Count() == 0)
                    {
                        p_subtitle = new List<string>();
                        p_subtitle.Add(string.Empty);
                    }
                    l_excelDocuments.InsertTitles(p_title, 1, ref l_initialRow, l_initialColumn, p_subtitle, l_headers.Length);
                    l_excelDocuments.InsertHeaders(1, l_headers, l_initialColumn, l_initialRow + 1, true, true);
                    l_excelDocuments.InsertData(1, l_data, l_initialColumn, l_initialRow + 2, true, true);
                }
            }
            catch (Exception ex)
            { throw ex; }
        }
        public static void ExportToExcel(String p_title, DataTable p_dataTable, List<String> p_subtitle, List<ExportColumns> p_exportColumns)
        {
            try
            {
                List<string> l_listTitles = new List<string>();
                l_listTitles.Add(p_title);
                int l_initialRow = 2;
                int l_initialColumn = 2;
                ExcelDocuments l_excelDocuments = new ExcelDocuments(1, l_listTitles);
                List<string> l_listHeaders = new List<string>();
                DataTable l_data = new DataTable(p_title);
                List<int> l_listIndex = new List<int>();
                if (p_exportColumns != null)
                {
                    for (int i = 0; i < p_exportColumns.Count(); i++)
                    {
                        DataColumn l_DataColumn = new DataColumn();
                        l_DataColumn.ColumnName = p_exportColumns.ElementAt(i).ColumnName;
                        l_DataColumn.Caption = p_exportColumns.ElementAt(i).ColumnCaption;
                        l_DataColumn.DataType = p_exportColumns.ElementAt(i).DataType = p_exportColumns.ElementAt(i).DataType == null ? Type.GetType("System.String") : p_exportColumns.ElementAt(i).DataType;
                        l_data.Columns.Add(l_DataColumn);
                        l_listHeaders.Add(p_exportColumns.ElementAt(i).ColumnCaption);
                    }
                    for (int j = 0; j < p_dataTable.Rows.Count; j++)
                    {
                        DataRow l_DataRow = l_data.NewRow();
                        for (int k = 0; k < l_data.Columns.Count; k++)
                        {
                            l_DataRow[k] = p_dataTable.Rows[j][l_data.Columns[k].ColumnName] == null ? string.Empty : p_dataTable.Rows[j][l_data.Columns[k].ColumnName];
                        }
                        l_data.Rows.Add(l_DataRow);
                    }
                }
                string[] l_headers = l_listHeaders.ToArray();
                if (l_data.Rows.Count > 0)
                {
                    if (p_subtitle == null || p_subtitle.Count() == 0)
                    {
                        p_subtitle = new List<string>();
                        p_subtitle.Add(string.Empty);
                    }
                    l_excelDocuments.InsertTitles(p_title, 1, ref l_initialRow, l_initialColumn, p_subtitle, l_headers.Length);
                    l_excelDocuments.InsertHeaders(1, l_headers, l_initialColumn, l_initialRow + 1, true, true);
                    l_excelDocuments.InsertData(1, l_data, l_initialColumn, l_initialRow + 2, true, true);
                }
            }
            catch (Exception ex)
            { throw ex; }
        }
    }
}
