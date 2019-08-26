using System;
using System.Text;
using System.Linq;
using System.Globalization;
using System.ComponentModel;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Runtime.Serialization;
using System.Data;
using VenPy.Class;

namespace VenPy.Entities
{
    public partial class VENPY_Products
    {
        #region [ VARIABLES ]

        private String pv_tble_namefap;
        private String pv_tble_nameunm;
        private String pv_tble_namemar;
        private ObservableCollection<VENPY_MeasurementUnitsProducts> pv_prod_measurementunitsproducts;
        private DataTable pv_udtt_measurementunitsproducts;
        private String pv_prod_errormessage;

        #endregion

        #region [ PROPERTIES ]

        [DataMember]
        public String TBLE_NameFAP
        {
            get { return pv_tble_namefap; }
            set
            {
                if (pv_tble_namefap != value)
                {
                    pv_tble_namefap = value;
                    OnAttributeChanged("TBLE_NameFAP");
                }
            }
        }
        [DataMember]
        public String TBLE_NameUNM
        {
            get { return pv_tble_nameunm; }
            set
            {
                if (pv_tble_nameunm != value)
                {
                    pv_tble_nameunm = value;
                    OnAttributeChanged("TBLE_NameUNM");
                }
            }
        }
        [DataMember]
        public String TBLE_NameMAR
        {
            get { return pv_tble_namemar; }
            set
            {
                if (pv_tble_namemar != value)
                {
                    pv_tble_namemar = value;
                    OnAttributeChanged("TBLE_NameMAR");
                }
            }
        }
        [DataMember]
        public ObservableCollection<VENPY_MeasurementUnitsProducts> PROD_MeasurementUnitsProducts
        {
            get { return pv_prod_measurementunitsproducts; }
            set { pv_prod_measurementunitsproducts = value; }
        }
        [DataMember]
        public DataTable UDTT_MeasurementUnitsProducts
        {
            get { return pv_udtt_measurementunitsproducts; }
            set { pv_udtt_measurementunitsproducts = value; }
        }
        [DataMember]
        public String PROD_ErrorMessage
        {
            get { return pv_prod_errormessage; }
        }

        #endregion

        #region [ COPYTO ]

        public void CopyTo(ref VENPY_Products Item)
        {
            try
            {
                if (Item == null) { Item = new VENPY_Products(); }
                Item.BUSI_Code = this.BUSI_Code;
                Item.PROD_Code = this.PROD_Code;
                Item.PROD_Active = this.PROD_Active;
                Item.TBLE_TableFAP = this.TBLE_TableFAP;
                Item.TBLE_CodeFAP = this.TBLE_CodeFAP;
                Item.TBLE_TableUNM = this.TBLE_TableUNM;
                Item.TBLE_CodeUNM = this.TBLE_CodeUNM;
                Item.PROD_Name = this.PROD_Name;
                Item.PROD_Description = this.PROD_Description;
                Item.PROD_Original = this.PROD_Original;
                Item.TBLE_TableMAR = this.TBLE_TableMAR;
                Item.TBLE_CodeMAR = this.TBLE_CodeMAR;
                Item.PROD_Model = this.PROD_Model;
                Item.PROD_Serie = this.PROD_Serie;
                Item.AUDI_CreationUser = this.AUDI_CreationUser;
                Item.AUDI_CreationDate = this.AUDI_CreationDate;
                Item.AUDI_ModificationUser = this.AUDI_ModificationUser;
                Item.AUDI_ModificationDate = this.AUDI_ModificationDate;

                Item.TBLE_NameFAP = this.TBLE_NameFAP;
                Item.TBLE_NameUNM = this.TBLE_NameUNM;
                Item.TBLE_NameMAR = this.TBLE_NameMAR;
                Item.PROD_MeasurementUnitsProducts = this.PROD_MeasurementUnitsProducts;
                Item.UDTT_MeasurementUnitsProducts = this.UDTT_MeasurementUnitsProducts;

            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ CHECK ]

        public bool Check()
        {
            try
            {
                bool l_correct = true;
                pv_prod_errormessage = null;
                if (BUSI_Code.Equals(0))
                {
                    l_correct = false;
                    pv_prod_errormessage += "* Debe ingresar un Código de Empresa" + Environment.NewLine;
                }
                if (string.IsNullOrEmpty(TBLE_TableFAP) || string.IsNullOrEmpty(TBLE_CodeFAP))
                {
                    l_correct = false;
                    pv_prod_errormessage += "* Debe seleccionar una Familia" + Environment.NewLine;
                }
                if (string.IsNullOrEmpty(TBLE_TableUNM) || string.IsNullOrEmpty(TBLE_CodeUNM))
                {
                    l_correct = false;
                    pv_prod_errormessage += "* Debe seleccionar una Unidad de Medida Mínima" + Environment.NewLine;
                }
                if (string.IsNullOrEmpty(PROD_Name))
                {
                    l_correct = false;
                    pv_prod_errormessage += "* Debe ingresar un Nombre" + Environment.NewLine;
                }
                if (PROD_MeasurementUnitsProducts == null || PROD_MeasurementUnitsProducts.Count() == 0)
                {
                    l_correct = false;
                    pv_prod_errormessage += "* Debe agregar por lo menos una Unidad de Medida" + Environment.NewLine;
                }
                else
                {
                    int l_index = 1;
                    bool l_reviewdetail = true;
                    foreach (var l_item in PROD_MeasurementUnitsProducts)
                    {
                        if (!l_item.Check())
                        {
                            l_correct = false;
                            l_reviewdetail = false;
                            pv_prod_errormessage += "Item " + l_index.ToString() + ":" + Environment.NewLine + l_item.MUPR_ErrorMessage;
                        }
                        l_index++;
                    }
                    if (l_reviewdetail)
                    {
                        foreach (var l_itemduplicates in PROD_MeasurementUnitsProducts)
                        {
                            var l_measurementunitsproducts = PROD_MeasurementUnitsProducts.Where(Table => Table.BUSI_Code == l_itemduplicates.BUSI_Code && Table.TBLE_TableUNM == l_itemduplicates.TBLE_TableUNM && Table.TBLE_CodeUNM == l_itemduplicates.TBLE_CodeUNM).ToObservableCollection();
                            if (l_measurementunitsproducts != null && l_measurementunitsproducts.Count() > 1)
                            {
                                l_correct = false;
                                pv_prod_errormessage += "* Existe Unidades de Medida duplicadas en el detalle" + Environment.NewLine;
                                break;
                            }
                        }
                    }
                }

                return l_correct;
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion
    }
}
