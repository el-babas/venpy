using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Microsoft.Reporting.WinForms;
using Microsoft.Reporting;
using System.Reflection;
using System.Diagnostics;


namespace VenPy.Controls
{
    public partial class Preliminary : Form
    {
        #region [ VARIABLES ]

        private String pv_Title;
        private String pv_User;
        private String pv_Company;
        private DataSet pv_DataSet;
        private DataTable pv_DataTable;
        private DataTable pv_FinalDataTable;
        private DataTable pv_SourceDataTable;
        private MemoryStream pv_Rdlc;
        private IEnumerable<PreliminaryColumns> pv_EnumerablePreliminaryColumns;

        #endregion

        #region [ FORM ]

        public Preliminary(DataTable p_DataTable, IEnumerable<PreliminaryColumns> p_PreliminaryColumns, String p_Title, String p_User, String p_Company = "")
        {
            try
            {
                InitializeComponent();
                Text = p_Title.ToUpper();
                pv_DataSet = new DataSet();
                pv_DataTable = LoadDataTable(p_DataTable, p_PreliminaryColumns);
                pv_DataSet.Tables.Add(pv_DataTable);
                pv_Title = p_Title.ToUpper();
                pv_User = p_User.ToUpper();
                pv_Company = p_Company.ToUpper();
                OpenPreview();
            }
            catch (Exception ex)
            { throw ex; }
        }
        private void Preliminary_Load(object sender, EventArgs e)
        {
            try
            {
                rptPreview.RefreshReport();
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ METHODS ]

        public DataTable LoadDataTable(DataTable p_DataTable, IEnumerable<PreliminaryColumns> p_PreliminaryColumns)
        {
            try
            {
                DataColumn l_DataColumn;
                DataRow l_DataRow;
                pv_FinalDataTable = new DataTable();
                pv_SourceDataTable = new DataTable();
                pv_EnumerablePreliminaryColumns = new List<PreliminaryColumns>();
                pv_SourceDataTable = p_DataTable;
                pv_EnumerablePreliminaryColumns = p_PreliminaryColumns;
                p_PreliminaryColumns = p_PreliminaryColumns.OrderBy(col => col.Index);
                if (p_PreliminaryColumns != null)
                {
                    for (int i = 0; i < p_PreliminaryColumns.Count(); i++)
                    {
                        l_DataColumn = new DataColumn();
                        l_DataColumn.ColumnName = p_PreliminaryColumns.ElementAt(i).ColumnName;
                        l_DataColumn.Caption = p_PreliminaryColumns.ElementAt(i).ColumnCaption;
                        l_DataColumn.DataType = Type.GetType("System.String");
                        p_PreliminaryColumns.ElementAt(i).DataType = p_PreliminaryColumns.ElementAt(i).DataType == null ? Type.GetType("System.String") : p_PreliminaryColumns.ElementAt(i).DataType;
                        pv_FinalDataTable.Columns.Add(l_DataColumn);
                    }
                    for (int j = 0; j < p_DataTable.Rows.Count; j++)
                    {
                        l_DataRow = pv_FinalDataTable.NewRow();
                        for (int k = 0; k < pv_FinalDataTable.Columns.Count; k++)
                        {
                            Type l_Type = Type.GetType(p_PreliminaryColumns.ElementAt(k).DataType.FullName);
                            String l_Format = null;
                            switch (l_Type.FullName)
                            {
                                case "System.String":
                                    l_DataRow[k] = p_DataTable.Rows[j][pv_FinalDataTable.Columns[k].ColumnName];
                                    break;
                                case "System.Boolean":
                                    if (p_DataTable.Rows[j][pv_FinalDataTable.Columns[k].ColumnName].ToString() == bool.TrueString)
                                    { l_DataRow[k] = "Si"; }
                                    else if (p_DataTable.Rows[j][pv_FinalDataTable.Columns[k].ColumnName].ToString() == bool.FalseString)
                                    { l_DataRow[k] = "No"; }
                                    break;
                                case "System.Int32":
                                    l_Format = p_PreliminaryColumns.ElementAt(k).Format == null ? "0" : p_PreliminaryColumns.ElementAt(k).Format;
                                    Int32 _int = Convert.ToInt32(p_DataTable.Rows[j][pv_FinalDataTable.Columns[k].ColumnName]);
                                    l_DataRow[k] = _int.ToString(l_Format);
                                    break;
                                case "System.DateTime":
                                    l_Format = p_PreliminaryColumns.ElementAt(k).Format == null ? "{0:dd/MM/yy}" : p_PreliminaryColumns.ElementAt(k).Format;
                                    DateTime _date = Convert.ToDateTime(p_DataTable.Rows[j][pv_FinalDataTable.Columns[k].ColumnName]);
                                    l_DataRow[k] = String.Format(l_Format, _date).ToString();
                                    break;
                                case "System.Decimal":
                                    l_Format = p_PreliminaryColumns.ElementAt(k).Format == null ? "0.00" : p_PreliminaryColumns.ElementAt(k).Format;
                                    Decimal _decimal = Convert.ToDecimal(p_DataTable.Rows[j][pv_FinalDataTable.Columns[k].ColumnName]);
                                    l_DataRow[k] = _decimal.ToString(l_Format);
                                    break;
                                default:
                                    l_DataRow[k] = p_DataTable.Rows[j][pv_FinalDataTable.Columns[k].ColumnName];
                                    break;
                            }

                        }
                        pv_FinalDataTable.Rows.Add(l_DataRow);
                    }
                }
                return pv_FinalDataTable;
            }
            catch (Exception ex)
            { throw ex; }
        }
        private void OpenPreview()
        {
            try
            {
                List<String> l_ListFields = new List<String>();
                foreach (var item in pv_EnumerablePreliminaryColumns)
                {
                    l_ListFields.Add(item.ColumnName.ToString());
                }
                if (pv_Rdlc != null)
                {
                    pv_Rdlc.Dispose();
                }
                pv_Rdlc = GenerateColumnsRdlc(l_ListFields);
                ShowReport();
            }
            catch (Exception ex)
            { throw ex; }
        }
        private MemoryStream GenerateColumnsRdlc(List<String> p_AllFields)
        {
            try
            {
                MemoryStream l_MemoryStream = new MemoryStream();
                RdlcGenerator l_RdlcGenerator = new RdlcGenerator();
                l_RdlcGenerator.AllFields = p_AllFields;
                l_RdlcGenerator.AllColumns = GetColumnsPreview();
                l_RdlcGenerator.WriteXml(l_MemoryStream, pv_Title, pv_User, pv_Company);
                l_MemoryStream.Position = 0;
                return l_MemoryStream;
            }
            catch (Exception ex)
            { throw ex; }
        }
        private List<ReportColumns> GetColumnsPreview()
        {
            try
            {
                DataTable l_DataTable = pv_DataSet.Tables[0];
                List<ReportColumns> l_ListReportColumns = new List<ReportColumns>();
                ReportColumns l_ReportColumns;
                foreach (PreliminaryColumns item in pv_EnumerablePreliminaryColumns)
                {
                    l_ReportColumns = new ReportColumns(item.ColumnName, item.ColumnCaption, item.Align);
                    l_ListReportColumns.Add(l_ReportColumns);
                }
                return l_ListReportColumns;
            }
            catch (Exception ex)
            { throw ex; }
        }
        private string GetExtension(RenderingExtension p_Extention)
        {
            try
            {
                switch (p_Extention.Name.ToUpper())
                {
                    case "PDF":
                        return ".pdf";
                    case "CSV":
                        return ".csv";
                    case "EXCEL":
                        return ".xls";
                    case "EXCELOPENXML":
                        return ".xlsx";
                    case "MHTML":
                        return ".mhtml";
                    case "IMAGE":
                        return ".tif";
                    case "XML":
                        return ".xml";
                    case "WORD":
                        return ".doc";
                    case "WORDOPENXML":
                        return ".docx";
                    case "HTML4.0":
                        return ".html";
                    case "NULL":
                        throw new NotImplementedException("Extension not implemented.");
                }
                throw new NotImplementedException("Extension not implemented.");
            }
            catch (Exception ex)
            { throw ex; }
        }
        private void ShowReport()
        {
            try
            {
                ReportDataSource l_ReportDataSource = new ReportDataSource();
                rptPreview.Reset();
                rptPreview.LocalReport.LoadReportDefinition(pv_Rdlc);
                rptPreview.LocalReport.DataSources.Add(new ReportDataSource("MyData", pv_DataSet.Tables[0]));
                rptPreview.RefreshReport();
                rptPreview.ReportExport += new ExportEventHandler(RptPreview_ReportExport);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ EVENTS ]

        private void RptPreview_ReportExport(object sender, ReportExportEventArgs e)
        {
            try
            {
                e.Cancel = true;
                String l_Extention = GetExtension(e.Extension);
                SaveFileDialog saveFileDialog = new SaveFileDialog()
                {
                    Title = "Save As",
                    CheckPathExists = true,
                    InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                    Filter = e.Extension.LocalizedName + " (*" + l_Extention + ")|*" + l_Extention + "|All files(*.*)|*.*",
                    FilterIndex = 0,
                    FileName = pv_Title
                };
                if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
                {
                    rptPreview.ExportDialog(e.Extension, e.DeviceInfo, saveFileDialog.FileName);
                    Process.Start(saveFileDialog.FileName);
                }
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion
    }
}
