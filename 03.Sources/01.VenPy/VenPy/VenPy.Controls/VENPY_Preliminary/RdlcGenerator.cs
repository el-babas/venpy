using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;
using VenPy.Controls.ReportDefinition;

namespace VenPy.Controls
{
    public class RdlcGenerator
    {
        #region [ VARIABLES ]

        private List<ReportColumns> pv_allcolumns;
        private List<String> pv_allfields;
        private String pv_pageheight;
        private String pv_pagewidth;
        private String pv_titlesize;

        #endregion

        #region [ PROPERTIES]

        public List<ReportColumns> AllColumns
        {
            get { return pv_allcolumns; }
            set { pv_allcolumns = value; }
        }
        public List<string> AllFields
        {
            get { return pv_allfields; }
            set { pv_allfields = value; }
        }

        #endregion

        #region [ METHODS ]

        public void WriteXml(Stream p_Stream, String p_Title, String p_User, String p_Company)
        {
            try
            {
                XmlSerializer l_XmlSerializer = new XmlSerializer(typeof(Report));
                l_XmlSerializer.Serialize(p_Stream, CreateReport(p_Title, p_User, p_Company));
            }
            catch (Exception ex)
            { throw ex; }
        }
        private Report CreateReport(String p_Title, String p_User, String p_Company)
        {
            try
            {
                /*Horizontal Orientation*/
                pv_titlesize = "29.5cm";
                pv_pagewidth = "29.7cm";
                pv_pageheight = "21.0cm"; 
                
                Report l_Report = new Report();
                l_Report.Items = new object[] {
                    CreateDataSources(),
                    CreateBody(),
                    CreateDataSets(),
                    CreatePageHeader(p_Title,p_Company, p_User),
                    CreatePageFooter(),
                    pv_pageheight,
                    pv_pagewidth,
                    "0.5cm",
                    "0.5cm",
                    "0.5cm",
                    "0.5cm",
                    pv_pagewidth,
                };
                l_Report.ItemsElementName = new ItemsChoiceType37[] {
                    ItemsChoiceType37.DataSources,
                    ItemsChoiceType37.Body,
                    ItemsChoiceType37.DataSets,
                    ItemsChoiceType37.PageHeader ,
                    ItemsChoiceType37.PageFooter,
                    ItemsChoiceType37.PageHeight,
                    ItemsChoiceType37.PageWidth,
                    ItemsChoiceType37.LeftMargin,
                    ItemsChoiceType37.RightMargin,
                    ItemsChoiceType37.TopMargin,
                    ItemsChoiceType37.BottomMargin,
                    ItemsChoiceType37.Width,
                };
                return l_Report;
            }
            catch (Exception ex)
            { throw ex; }
        }
        private DataSourcesType CreateDataSources()
        {
            try
            {
                DataSourcesType l_DataSourcesType = new DataSourcesType();
                l_DataSourcesType.DataSource = new DataSourceType[] { CreateDataSource() };
                return l_DataSourcesType;
            }
            catch (Exception ex)
            { throw ex; }
        }
        private DataSourceType CreateDataSource()
        {
            try
            {
                DataSourceType l_DataSourceType = new DataSourceType();
                l_DataSourceType.Name = "DummyDataSource";
                l_DataSourceType.Items = new object[] { CreateConnectionProperties() };
                return l_DataSourceType;
            }
            catch (Exception ex)
            { throw ex; }
        }
        private ConnectionPropertiesType CreateConnectionProperties()
        {
            try
            {
                ConnectionPropertiesType l_ConnectionPropertiesType = new ConnectionPropertiesType();
                l_ConnectionPropertiesType.Items = new object[] { "", "SQL" };
                l_ConnectionPropertiesType.ItemsElementName = new ItemsChoiceType[] {
                ItemsChoiceType.ConnectString,
                ItemsChoiceType.DataProvider
            };
                return l_ConnectionPropertiesType;
            }
            catch (Exception ex)
            { throw ex; }
        }
        private BodyType CreateBody()
        {
            try
            {
                BodyType l_BodyType = new BodyType();
                l_BodyType.Items = new object[] { CreateReportItems(), "1in", CreateTableStyle() };
                l_BodyType.ItemsElementName = new ItemsChoiceType30[] { ItemsChoiceType30.ReportItems, ItemsChoiceType30.Height, ItemsChoiceType30.Style };
                return l_BodyType;
            }
            catch (Exception ex)
            { throw ex; }
        }
        private ReportItemsType CreateReportItems()
        {
            try
            {
                ReportItemsType l_ReportItemsType = new ReportItemsType();
                RdlcTableGenerator tableGen = new RdlcTableGenerator();
                tableGen.Fields = pv_allcolumns;
                l_ReportItemsType.Items = new object[] { tableGen.CreateTable() };
                return l_ReportItemsType;
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
        private DataSetsType CreateDataSets()
        {
            try
            {
                DataSetsType l_DataSetsType = new DataSetsType();
                l_DataSetsType.DataSet = new DataSetType[] { CreateDataSet() };
                return l_DataSetsType;
            }
            catch (Exception ex)
            { throw ex; }
        }
        private DataSetType CreateDataSet()
        {
            try
            {
                DataSetType l_DataSetType = new DataSetType();
                l_DataSetType.Name = "MyData";
                l_DataSetType.Items = new object[] {
                    CreateQuery(),
                    CreateFields()
                };
                return l_DataSetType;
            }
            catch (Exception ex)
            { throw ex; }
        }
        private QueryType CreateQuery()
        {
            try
            {
                QueryType l_QueryType = new QueryType();
                l_QueryType.Items = new object[] { "DummyDataSource", "" };
                l_QueryType.ItemsElementName = new ItemsChoiceType2[] {
                    ItemsChoiceType2.DataSourceName,
                    ItemsChoiceType2.CommandText
                };
                return l_QueryType;
            }
            catch (Exception ex)
            { throw ex; }
        }
        private FieldsType CreateFields()
        {
            try
            {
                FieldsType l_FieldsType = new FieldsType();
                l_FieldsType.Field = new FieldType[pv_allfields.Count + 1];
                int i = 0;
                for (i = 0; i <= pv_allfields.Count - 1; i++)
                {
                    l_FieldsType.Field[i] = CreateField(pv_allfields[i]);
                }
                return l_FieldsType;
            }
            catch (Exception ex)
            { throw ex; }
        }
        private FieldType CreateField(String p_FieldName)
        {
            try
            {
                FieldType l_FieldType = new FieldType();
                l_FieldType.Name = p_FieldName;
                l_FieldType.Items = new object[] { p_FieldName };
                l_FieldType.ItemsElementName = new ItemsChoiceType1[] { ItemsChoiceType1.DataField };
                return l_FieldType;
            }
            catch (Exception ex)
            { throw ex; }
        }
        private PageHeaderFooterType CreatePageHeader(String p_Title, String p_Company, String p_User)
        {
            try
            {
                PageHeaderFooterType l_PageHeaderFooterType = new PageHeaderFooterType();
                l_PageHeaderFooterType.Items = new object[] {
                    "3.5cm",
                    true,
                    true,
                    CreateHeaderItems(p_Title, p_Company,p_User),
                };
                l_PageHeaderFooterType.ItemsElementName = new ItemsChoiceType34[]{
                    ItemsChoiceType34.Height,
                    ItemsChoiceType34.PrintOnFirstPage,
                    ItemsChoiceType34.PrintOnLastPage,
                    ItemsChoiceType34.ReportItems,
                };
                return l_PageHeaderFooterType;
            }
            catch (Exception ex)
            { throw ex; }
        }
        private ReportItemsType CreateHeaderItems(String p_Title, String p_Company, String p_User)
        {
            try
            {
                ReportItemsType l_ReportItemsType = new ReportItemsType();

                #region [ Title ]

                TextboxType l_TextboxTypeTitle = new TextboxType();
                l_TextboxTypeTitle.Name = "lblTitulo";
                l_TextboxTypeTitle.Items = new object[] {
                    p_Title.ToUpper(),
                    "0.5cm",
                    "0.5cm",
                    "1.0cm",
                    pv_titlesize,
                    CreateHeaderTextboxStyle("600", "12pt", "Center", "Middle"),
                };
                l_TextboxTypeTitle.ItemsElementName = new ItemsChoiceType14[] {
                    ItemsChoiceType14.Value,
                    ItemsChoiceType14.Left,
                    ItemsChoiceType14.Top,
                    ItemsChoiceType14.Height,
                    ItemsChoiceType14.Width,
                    ItemsChoiceType14.Style,
                };

                #endregion

                #region [ Company ]

                TextboxType l_TextboxTypeCompany = new TextboxType();
                l_TextboxTypeCompany.Name = "lblSubTitulo";
                l_TextboxTypeCompany.Items = new object[] {
                    "EMPRESA : " + p_Company,
                    "0.5cm",
                    "1.5cm",
                    "0.5cm",
                    pv_titlesize,
                    CreateHeaderTextboxStyle("400", "10pt", "Left", "Middle"),
                };
                l_TextboxTypeCompany.ItemsElementName = new ItemsChoiceType14[] {
                    ItemsChoiceType14.Value,
                    ItemsChoiceType14.Left,
                    ItemsChoiceType14.Top,
                    ItemsChoiceType14.Height,
                    ItemsChoiceType14.Width,
                    ItemsChoiceType14.Style,
                };

                #endregion

                #region [ User ]

                TextboxType l_TextboxTypeUser = new TextboxType();
                l_TextboxTypeUser.Name = "lblUsuario";
                l_TextboxTypeUser.Items = new object[] {
                    "USUARIO : " + p_User ,
                    "0.5cm",
                    "2.0cm",
                    "0.5cm",
                    pv_titlesize,
                    CreateHeaderTextboxStyle("400", "10pt", "Left", "Middle"),
                };
                l_TextboxTypeUser.ItemsElementName = new ItemsChoiceType14[] {
                    ItemsChoiceType14.Value,
                    ItemsChoiceType14.Left,
                    ItemsChoiceType14.Top,
                    ItemsChoiceType14.Height,
                    ItemsChoiceType14.Width,
                    ItemsChoiceType14.Style,
                };

                #endregion

                #region [ Data ]

                TextboxType l_TextboxTypeData = new TextboxType();
                l_TextboxTypeData.Name = "lblData";
                l_TextboxTypeData.Items = new object[] {
                    "FECHA : " + DateTime.Now.ToString("dd/MM/yyyy HH:mm"),
                    "0.5cm",
                    "2.5cm",
                    "0.5cm",
                    pv_titlesize,
                    CreateHeaderTextboxStyle("400", "10pt", "Left", "Middle"),
                };
                l_TextboxTypeData.ItemsElementName = new ItemsChoiceType14[] {
                    ItemsChoiceType14.Value,
                    ItemsChoiceType14.Left,
                    ItemsChoiceType14.Top,
                    ItemsChoiceType14.Height,
                    ItemsChoiceType14.Width,
                    ItemsChoiceType14.Style,
                };

                #endregion

                l_ReportItemsType.Items = new object[] { l_TextboxTypeTitle, l_TextboxTypeCompany, l_TextboxTypeUser, l_TextboxTypeData};
                return l_ReportItemsType;
            }
            catch (Exception ex)
            { throw ex; }
        }
        private StyleType CreateHeaderTextboxStyle(String p_Bold, String p_Company, String p_Alignment, String p_Positioning)
        {
            try
            {
                StyleType l_StyleType = new StyleType();
                l_StyleType.Items = new object[] {
                    p_Bold,
                    p_Company,
                    p_Alignment,
                    p_Positioning,
                };
                l_StyleType.ItemsElementName = new ItemsChoiceType5[] {
                    ItemsChoiceType5.FontWeight,
                    ItemsChoiceType5.FontSize,
                    ItemsChoiceType5.TextAlign,
                    ItemsChoiceType5.VerticalAlign,
                };
                return l_StyleType;
            }
            catch (Exception ex)
            { throw ex; }
        }
        private PageHeaderFooterType CreatePageFooter()
        {
            try
            {
                PageHeaderFooterType l_PageHeaderFooterType = new PageHeaderFooterType();
                l_PageHeaderFooterType.Items = new object[] {
                    "1.0cm",
                    true,
                    true,
                    CreateFooterItems(),
                };
                l_PageHeaderFooterType.ItemsElementName = new ItemsChoiceType34[] {
                    ItemsChoiceType34.Height,
                    ItemsChoiceType34.PrintOnFirstPage,
                    ItemsChoiceType34.PrintOnLastPage,
                    ItemsChoiceType34.ReportItems,
                };
                return l_PageHeaderFooterType;
            }
            catch (Exception ex)
            { throw ex; }
        }
        private ReportItemsType CreateFooterItems()
        {
            try
            {
                ReportItemsType l_ReportItemsType = new ReportItemsType();

                #region [ Page ]

                TextboxType l_TextboxTypePage = new TextboxType();
                l_TextboxTypePage.Name = "lblPageNumber";
                l_TextboxTypePage.Items = new object[] {
                    "=Globals!PageNumber",
                    "0.5cm",
                    "0.0cm",
                    "0.5cm",
                    pv_titlesize,
                    CreateHeaderTextboxStyle("600", "9pt", "Left", "Middle"),
                };
                l_TextboxTypePage.ItemsElementName = new ItemsChoiceType14[] {
                    ItemsChoiceType14.Value,
                    ItemsChoiceType14.Left,
                    ItemsChoiceType14.Top,
                    ItemsChoiceType14.Height,
                    ItemsChoiceType14.Width,
                    ItemsChoiceType14.Style,
                };

                #endregion

                l_ReportItemsType.Items = new object[] { l_TextboxTypePage };
                return l_ReportItemsType;
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion
    }
}
