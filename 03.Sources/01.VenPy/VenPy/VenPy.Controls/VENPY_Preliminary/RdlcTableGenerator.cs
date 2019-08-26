using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VenPy.Controls.ReportDefinition;

namespace VenPy.Controls
{
    public class RdlcTableGenerator
    {
        #region [ VARIABLES ]

        private List<ReportColumns> pv_reportcolumns;

        #endregion

        #region [ PROPERTIES ]

        public List<ReportColumns> Fields
        {
            get { return pv_reportcolumns; }
            set { pv_reportcolumns = value; }
        }

        #endregion

        #region [ METHODS ]

        public TableType CreateTable()
        {
            try
            {
                TableType l_TableType = new TableType();
                l_TableType.Name = "Table1";
                l_TableType.Items = new object[] {
                    CreateTableColumns(),
                    CreateHeader(),
                    CreateDetails(),
                    "3in",
                    "3in",
                    CreateTableStyle()
                };
                l_TableType.ItemsElementName = new ItemsChoiceType21[] {
                     ItemsChoiceType21.TableColumns,
                     ItemsChoiceType21.Header,
                     ItemsChoiceType21.Details,
                     ItemsChoiceType21.Width,
                     ItemsChoiceType21.Height,
                     ItemsChoiceType21.Style,
                     ItemsChoiceType21.PageBreakAtStart,
                     ItemsChoiceType21.PageBreakAtEnd,
                };
                return l_TableType;
            }
            catch (Exception ex)
            { throw ex; }
        }
        private TableRowsType CreateHeaderTableRows()
        {
            try
            {
                TableRowsType l_TableRowsType = new TableRowsType();
                l_TableRowsType.TableRow = new TableRowType[] { CreateHeaderTableRow() };
                return l_TableRowsType;
            }
            catch (Exception ex)
            { throw ex; }
        }
        private TableRowsType CreateTableRows()
        {
            try
            {
                TableRowsType l_TableRowsType = new TableRowsType();
                l_TableRowsType.TableRow = new TableRowType[] { CreateTableRow() };
                return l_TableRowsType;
            }
            catch (Exception ex)
            { throw ex; }
        }
        private TableRowType CreateHeaderTableRow()
        {
            try
            {
                TableRowType l_TableRowType = new TableRowType();
                l_TableRowType.Items = new object[] {
                    CreateHeaderTableCells(),
                    "0.25in"
                };
                return l_TableRowType;
            }
            catch (Exception ex)
            { throw ex; }
        }
        private TableRowType CreateTableRow()
        {
            try
            {
                TableRowType l_TableRowType = new TableRowType();
                l_TableRowType.Items = new object[] { CreateTableCells(), "0.25in" };
                return l_TableRowType;
            }
            catch (Exception ex)
            { throw ex; }
        }
        private TableCellsType CreateHeaderTableCells()
        {
            try
            {
                TableCellsType l_TableCellsType = new TableCellsType();
                l_TableCellsType.TableCell = new TableCellType[pv_reportcolumns.Count + 1];
                int i = 0;
                for (i = 0; i <= pv_reportcolumns.Count - 1; i++)
                {
                    l_TableCellsType.TableCell[i] = CreateHeaderTableCell(pv_reportcolumns[i]);
                }
                return l_TableCellsType;
            }
            catch (Exception ex)
            { throw ex; }
        }
        private TableCellsType CreateTableCells()
        {
            try
            {
                TableCellsType l_TableCellsType = new TableCellsType();
                l_TableCellsType.TableCell = new TableCellType[pv_reportcolumns.Count + 1];
                int i = 0;
                for (i = 0; i <= pv_reportcolumns.Count - 1; i++)
                {
                    l_TableCellsType.TableCell[i] = CreateTableCell(pv_reportcolumns[i].Name, pv_reportcolumns[i]);
                }
                return l_TableCellsType;
            }
            catch (Exception ex)
            { throw ex; }
        }
        private TableCellType CreateHeaderTableCell(ReportColumns p_ReportColumns)
        {
            try
            {
                TableCellType l_TableCellType = new TableCellType();
                l_TableCellType.Items = new object[] { CreateHeaderTableCellReportItems(p_ReportColumns) };
                return l_TableCellType;
            }
            catch (Exception ex)
            { throw ex; }
        }
        private TableCellType CreateTableCell(String p_FieldName, ReportColumns p_ReportColumns)
        {
            try
            {
                TableCellType l_TableCellType = new TableCellType();
                l_TableCellType.Items = new object[] { CreateTableCellReportItems(p_FieldName, p_ReportColumns) };
                return l_TableCellType;
            }
            catch (Exception ex)
            { throw ex; }
        }
        private TableColumnsType CreateTableColumns()
        {
            try
            {
                TableColumnsType l_TableColumnsType = new TableColumnsType();
                l_TableColumnsType.TableColumn = new TableColumnType[pv_reportcolumns.Count + 1];
                int i = 0;
                for (i = 0; i <= pv_reportcolumns.Count - 1; i++)
                {
                    l_TableColumnsType.TableColumn[i] = CreateTableColumn();
                }
                return l_TableColumnsType;
            }
            catch (Exception ex)
            { throw ex; }
        }
        private TableColumnType CreateTableColumn()
        {
            try
            {
                TableColumnType l_TableColumnType = new TableColumnType();
                l_TableColumnType.Items = new object[] { "2in" };
                return l_TableColumnType;
            }
            catch (Exception ex)
            { throw ex; }
        }
        private StyleType CreateHeaderTableCellTextboxStyle()
        {
            try
            {
                StyleType StyleType = new StyleType();
                StyleType.Items = new object[] {
                    "700",
                    "9pt",
                    "Center",
                    "Middle",
                    CreateBorderColorStyleWidth("#74A4D4"),
                    CreateBorderColorStyleWidth("Solid")
                };
                StyleType.ItemsElementName = new ItemsChoiceType5[] {
                    ItemsChoiceType5.FontWeight,
                    ItemsChoiceType5.FontSize,
                    ItemsChoiceType5.TextAlign ,
                    ItemsChoiceType5.VerticalAlign,
                    ItemsChoiceType5.BorderColor,
                    ItemsChoiceType5.BorderStyle
                };
                return StyleType;
            }
            catch (Exception ex)
            { throw ex; }
        }
        private StyleType CreateTableStyle()
        {
            try
            {
                StyleType l_StyleType = new StyleType();
                l_StyleType.Items = new object[]{
                    "Center",
                    "Middle",
                };
                l_StyleType.ItemsElementName = new ItemsChoiceType5[]{
                    ItemsChoiceType5.TextAlign,
                    ItemsChoiceType5.VerticalAlign,
                };
                return l_StyleType;
            }
            catch (Exception ex)
            { throw ex; }
        }
        private StyleType CreateTableCellTextboxStyle(ReportColumns p_ReportColumns)
        {
            try
            {
                StyleType l_StyleType = new StyleType();
                l_StyleType.Items = new object[] {
                    "=iif(RowNumber(Nothing) mod 2, \"AliceBlue\", \"White\")",
                    p_ReportColumns.Align.ToString() ,
                    "8pt",
                    CreateBorderColorStyleWidth("#74A4D4"),
                    CreateBorderColorStyleWidth("Solid"),
                    "3pt",
                    "3pt",
                    "Middle"
                };
                l_StyleType.ItemsElementName = new ItemsChoiceType5[] {
                    ItemsChoiceType5.BackgroundColor,
                    ItemsChoiceType5.TextAlign,
                    ItemsChoiceType5.FontSize,
                    ItemsChoiceType5.BorderColor,
                    ItemsChoiceType5.BorderStyle,
                    ItemsChoiceType5.PaddingLeft,
                    ItemsChoiceType5.PaddingRight ,
                    ItemsChoiceType5.VerticalAlign
                };
                return l_StyleType;
            }
            catch (Exception ex)
            { throw ex; }
        }
        private ReportItemsType CreateHeaderTableCellReportItems(ReportColumns p_ReportColumns)
        {
            try
            {
                ReportItemsType l_ReportItemsType = new ReportItemsType();
                l_ReportItemsType.Items = new object[] { CreateHeaderTableCellTextbox(p_ReportColumns) };
                return l_ReportItemsType;
            }
            catch (Exception ex)
            { throw ex; }
        }
        private ReportItemsType CreateTableCellReportItems(String p_FieldName, ReportColumns field)
        {
            try
            {
                ReportItemsType l_ReportItemsType = new ReportItemsType();
                l_ReportItemsType.Items = new object[] { CreateTableCellTextbox(p_FieldName, field) };
                return l_ReportItemsType;
            }
            catch (Exception ex)
            { throw ex; }
        }
        private TextboxType CreateHeaderTableCellTextbox(ReportColumns p_ReportColumns)
        {
            try
            {
                TextboxType l_TextboxType = new TextboxType();
                l_TextboxType.Name = p_ReportColumns.Name + "_Header";
                l_TextboxType.Items = new object[] {
                p_ReportColumns.Description ,
                CreateHeaderTableCellTextboxStyle(),
                true
            };
                l_TextboxType.ItemsElementName = new ItemsChoiceType14[] {
                ItemsChoiceType14.Value,
                ItemsChoiceType14.Style,
                ItemsChoiceType14.CanGrow
            };
                return l_TextboxType;
            }
            catch (Exception ex)
            { throw ex; }
        }
        private TextboxType CreateTableCellTextbox(String p_FieldName, ReportColumns p_ReportColumns)
        {
            try
            {
                TextboxType l_TextboxType = new TextboxType();
                l_TextboxType.Name = p_FieldName;
                l_TextboxType.Items = new object[] {
                    "=Fields!" + p_FieldName + ".Value",
                    CreateTableCellTextboxStyle(p_ReportColumns),
                    true
                };
                l_TextboxType.ItemsElementName = new ItemsChoiceType14[] {
                    ItemsChoiceType14.Value,
                    ItemsChoiceType14.Style,
                    ItemsChoiceType14.CanGrow
                };
                return l_TextboxType;
            }
            catch (Exception ex)
            { throw ex; }
        }
        private DetailsType CreateDetails()
        {
            try
            {
                DetailsType l_DetailsType = new DetailsType();
                l_DetailsType.Items = new object[] { CreateTableRows() };
                return l_DetailsType;
            }
            catch (Exception ex)
            { throw ex; }
        }
        private HeaderType CreateHeader()
        {
            try
            {
                HeaderType l_HeaderType = new HeaderType();
                l_HeaderType.Items = new object[] {
                    CreateHeaderTableRows() ,
                    true
                };
                l_HeaderType.ItemsElementName = new ItemsChoiceType20[] {
                    ItemsChoiceType20.TableRows,
                    ItemsChoiceType20.RepeatOnNewPage
                };
                return l_HeaderType;
            }
            catch (Exception ex)
            { throw ex; }
        }
        private BorderColorStyleWidthType CreateBorderColorStyleWidth(String p_Color)
        {
            try
            {
                BorderColorStyleWidthType l_BorderColorStyleWidthType = new BorderColorStyleWidthType();
                l_BorderColorStyleWidthType.Items = new object[]{
                    p_Color,
                };
                l_BorderColorStyleWidthType.ItemsElementName = new ItemsChoiceType3[] {
                    ItemsChoiceType3.Default,
                };
                return l_BorderColorStyleWidthType;
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion
    }
}
