using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Drawing;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data;
using System.Collections.ObjectModel;


namespace VenPy.Class
{
    public class ExcelDocuments
    {
        #region [ VARIABLES ]

        public Excel.Application pb_app = null;
        private Excel.Workbook pv_workbook = null;
        private Excel.Worksheet pv_worksheet = null;
        private Excel.Range pv_worksheetRange = null;
        private string pv_plantilla = @"\VENPY_Export\Template.xltx";
        private Dictionary<int, Excel.Worksheet> pv_pages;
        private Dictionary<string, Excel.XlLineStyle> pv_xlLineStyle;
        private Dictionary<string, Excel.XlBorderWeight> pv_xlBorderWeight;
        private Dictionary<string, Excel.XlHAlign> pv_xlHAlign;
        private Dictionary<string, Excel.XlVAlign> pv_xlVAlign;

        #endregion

        #region [ CONSTRUCTORS ]

        public ExcelDocuments(int p_numPages, List<string> p_names)
        {
            try
            {
                pv_pages = new Dictionary<Int32, Excel.Worksheet>();
                pb_app = new Excel.Application();
                string l_template = AppDomain.CurrentDomain.BaseDirectory + pv_plantilla;
                pv_workbook = pb_app.Workbooks.Add(l_template);
                for (int i = p_numPages; i >= 1; i--)
                {
                    if (i == p_numPages)
                    { pv_worksheet = (Excel.Worksheet)pv_workbook.Worksheets[1]; }
                    else
                    { pv_worksheet = (Excel.Worksheet)pv_workbook.Worksheets.Add(); }
                    if (p_names != null)
                    { pv_worksheet.Name = p_names[i - 1]; }
                    pv_pages.Add(i, pv_worksheet);
                }
            }
            catch (Exception ex)
            {
                pv_workbook = null;
                pb_app = null;
                throw (ex);
            }
        }

        #endregion

        #region [ METHODS ]

        public void InsertTitles(string p_title, int p_page, ref int p_row, int p_column, List<string> p_subtitles, int p_cell)
        {
            int l_value = 1;
            try
            {
                string l_letterInitialColumn = Column(p_column);
                string l_letterFinalColumn = Column((p_column - 1) + p_cell);
                for (int i = 0; i <= p_subtitles.Count - 1; i++)
                {
                    if (i == 0)
                    {
                        string l_column1 = l_letterInitialColumn + Convert.ToString(p_row);
                        string l_column2 = l_letterFinalColumn + Convert.ToString(p_row);
                        CreateTitle(p_page, p_row, p_column, p_title.ToUpper(), l_column1, l_column2, true, true);
                    }
                    CreateSubTitles(p_page, p_row + l_value, p_column, p_subtitles[i], l_letterInitialColumn + Convert.ToString(p_row + l_value), l_letterFinalColumn + Convert.ToString(p_row + 1));
                    p_row += 1;
                }
            }
            catch (Exception ex)
            { throw ex; }
        }
        public void InsertHeaders(int p_page, object[] p_header, int p_initialColumn, int p_initialRow, bool p_headerStyle, bool p_fit)
        {
            try
            {
                pv_worksheetRange = pv_pages[p_page].Range[pv_pages[p_page].Cells[p_initialRow, p_initialColumn],
                                    pv_pages[p_page].Cells[p_initialRow, (p_initialColumn - 1) + p_header.Length]];
                pv_worksheetRange.Value2 = p_header;
                if (p_headerStyle)
                {
                    pv_worksheetRange.Interior.Color = ColorTranslator.ToOle(Color.FromArgb(55, 72, 80));
                    pv_worksheetRange.Font.Bold = true;
                    pv_worksheetRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                    pv_worksheetRange.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
                    pv_worksheetRange.Font.Color = ColorTranslator.ToOle(Color.White); ;
                    pv_worksheetRange.Font.Size = 12;
                }
                if (p_fit)
                {
                    for (int c = p_initialColumn; c < p_initialColumn + p_header.GetLength(0); c++)
                    { pv_pages[p_page].Columns[c + 1].AutoFit(); }
                }
                SetEdges(Column(p_initialColumn) + p_initialRow, Column((p_initialColumn - 1) + p_header.Length) + p_initialRow, "Simple", "Delgado", "White");
            }
            catch (Exception ex)
            {
                pv_workbook = null;
                pb_app = null;
                throw (ex);
            }
        }
        public void InsertData(int p_page, DataTable p_data, int p_initialColumn, int p_initialRow, bool p_format = true, bool p_fit = true)
        {
            try
            {
                object[,] l_data = new object[p_data.Rows.Count, p_data.Columns.Count];
                if (p_data.Rows.Count > 0)
                {
                    for (int f = 0; f < p_data.Rows.Count; f++)
                    {
                        for (int c = 0; c < p_data.Columns.Count; c++)
                        { l_data[f, c] = p_data.Rows[f][c]; }
                    }
                    pv_worksheetRange = pv_pages[p_page].Range[pv_pages[p_page].Cells[p_initialRow, p_initialColumn],
                                        pv_pages[p_page].Cells[p_data.Rows.Count + p_initialRow - 1, p_data.Columns.Count + p_initialColumn - 1]];
                    pv_worksheetRange.Value2 = l_data;

                    pv_worksheetRange.Interior.Color = ColorTranslator.ToOle(Color.FromArgb(236, 239, 244));
                    pv_worksheetRange.Font.Bold = false;
                    pv_worksheetRange.Font.Color = ColorTranslator.ToOle(Color.Black);
                    pv_worksheetRange.Font.Size = 10;
                    pv_worksheetRange.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;

                    if (p_fit)
                    {
                        for (int c = p_initialColumn; c < p_data.Columns.Count + p_initialColumn; c++)
                        { pv_pages[p_page].Columns[c].AutoFit(); }
                    }
                    if (p_format)
                    {
                        for (int c = 0; c < p_data.Columns.Count; c++)
                        {
                            string _tip = p_data.Rows[0][c].GetType().ToString();
                            if (p_data.Rows[0][c].GetType() == Type.GetType("System.Decimal") || p_data.Rows[0][c].GetType() == Type.GetType("System.Double") || p_data.Rows[0][c].GetType() == Type.GetType("System.Float"))
                            { pv_pages[p_page].Columns[c + p_initialColumn].NumberFormat = "#,##0.00"; }
                            if (p_data.Rows[0][c].GetType() == Type.GetType("System.Long") || p_data.Rows[0][c].GetType() == Type.GetType("System.Int") || p_data.Rows[0][c].GetType() == Type.GetType("System.Int16") || p_data.Rows[0][c].GetType() == Type.GetType("System.Int32") || p_data.Rows[0][c].GetType() == Type.GetType("System.Int64"))
                            { pv_pages[p_page].Columns[c + p_initialColumn].NumberFormat = "#,##0"; }
                            if (p_data.Rows[0][c].GetType() == Type.GetType("System.DBNull"))
                            { pv_pages[p_page].Columns[c + p_initialColumn].NumberFormat = ""; }
                            if (p_data.Rows[0][c].GetType() == Type.GetType("System.DateTime"))
                            { pv_pages[p_page].Columns[c + p_initialColumn].NumberFormat = "dd/mm/yyyy;@"; }
                        }
                    }
                    SetEdges(Column(p_initialColumn) + p_initialRow, Column((p_initialColumn - 1) + p_data.Columns.Count) + (p_initialRow + p_data.Rows.Count - 1), "Simple", "Delgado", "Black");
                }
                pb_app.Visible = true;
            }
            catch (Exception ex)
            {
                pv_workbook = null;
                pb_app = null;
                throw (ex);
            }
        }
        private void CreateTitle(int p_page, int p_row, int p_column, string p_text, string p_initialColumn, string p_finalColumn, bool p_centered, bool p_underlined)
        {
            try
            {
                pv_pages[p_page].Cells[p_row, p_column] = p_text;
                pv_worksheetRange = pv_pages[p_page].get_Range(p_initialColumn, p_finalColumn);
                pv_worksheetRange.Merge();
                if (p_centered)
                { pv_worksheetRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter; }
                pv_worksheetRange.Font.Size = 15;
                pv_worksheetRange.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
                pv_worksheetRange.Font.Underline = p_underlined;
                pv_worksheetRange.Font.Bold = true;
            }
            catch (Exception ex)
            {
                pv_workbook = null;
                pb_app = null;
                throw (ex);
            }
        }
        private void CreateSubTitles(int p_page, int p_row, int p_column, string p_text, string p_initialColumn, string p_finalColumn)
        {
            try
            {
                pv_pages[p_page].Cells[p_row, p_column] = p_text;
                pv_worksheetRange = pv_pages[p_page].get_Range(p_initialColumn, p_finalColumn);
                pv_worksheetRange.Merge();
                pv_worksheetRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft; 
                pv_worksheetRange.Font.Size = 11;
                pv_worksheetRange.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
                pv_worksheetRange.Font.Bold = true;
            }
            catch (Exception ex)
            {
                pv_workbook = null;
                pb_app = null;
                throw (ex);
            }
        }
        private void SetEdges(string startCell, string endCell, string lineStyle, string borderWeight, string borderColorName)
        {
            Dictionary();
            pv_worksheetRange = pv_worksheet.get_Range(startCell, endCell);
            pv_worksheetRange.Borders.Weight = pv_xlBorderWeight[borderWeight];
            try
            {
                object borderColor = ColorTranslator.ToOle(Color.FromName(borderColorName));
                pv_worksheetRange.Borders[Excel.XlBordersIndex.xlInsideHorizontal].LineStyle = pv_xlLineStyle[lineStyle];
                pv_worksheetRange.Borders[Excel.XlBordersIndex.xlInsideHorizontal].Weight = pv_xlBorderWeight[borderWeight];
                pv_worksheetRange.Borders[Excel.XlBordersIndex.xlInsideHorizontal].Color = borderColor;
                pv_worksheetRange.Borders[Excel.XlBordersIndex.xlInsideVertical].LineStyle = pv_xlLineStyle[lineStyle];
                pv_worksheetRange.Borders[Excel.XlBordersIndex.xlInsideVertical].Weight = pv_xlBorderWeight[borderWeight];
                pv_worksheetRange.Borders[Excel.XlBordersIndex.xlInsideVertical].Color = borderColor;
            }
            catch (Exception ex)
            {
                pv_workbook = null;
                pb_app = null;
                throw (ex);
            }
        }
        private void Dictionary()
        {
            pv_xlLineStyle = new Dictionary<string, Excel.XlLineStyle>();
            pv_xlLineStyle.Add("Continua", Excel.XlLineStyle.xlContinuous);
            pv_xlLineStyle.Add("Punto", Excel.XlLineStyle.xlDot);
            pv_xlLineStyle.Add("Simple", Excel.XlLineStyle.xlLineStyleNone);
            pv_xlLineStyle.Add("Doble", Excel.XlLineStyle.xlDouble);
            pv_xlBorderWeight = new Dictionary<string, Excel.XlBorderWeight>();
            pv_xlBorderWeight.Add("Muy Delgado", Excel.XlBorderWeight.xlHairline);
            pv_xlBorderWeight.Add("Delgado", Excel.XlBorderWeight.xlThin);
            pv_xlBorderWeight.Add("Medio", Excel.XlBorderWeight.xlMedium);
            pv_xlHAlign = new Dictionary<string, Excel.XlHAlign>();
            pv_xlHAlign.Add("Center", Excel.XlHAlign.xlHAlignCenter);
            pv_xlVAlign = new Dictionary<string, Excel.XlVAlign>();
            pv_xlVAlign.Add("Center", Excel.XlVAlign.xlVAlignCenter);
        }
        private string Column(int p_number)
        {
            double l_number = p_number;
            double l_decimal;
            string l_new = string.Empty;
            string l_string = string.Empty;
            while (l_number > 26)
            {
                l_number = Convert.ToDouble(l_number) / Convert.ToDouble(26);
                l_decimal = Math.Abs(Math.Truncate(l_number) - l_number);
                l_new = Convert.ToString((char)(64 + (l_decimal * 26 == 0 ? 26 : Convert.ToInt16(l_decimal * 26))));
                l_string = l_new + l_string;
                l_number -= l_decimal;
                if (l_decimal == 0)
                { l_number -= 1; }
            }
            l_new = Convert.ToString((char)(64 + (Math.Truncate(l_number) == 0 ? 26 : Math.Truncate(l_number))));
            l_string = l_new + l_string;
            return l_string;
        }

        #endregion
    }
}
