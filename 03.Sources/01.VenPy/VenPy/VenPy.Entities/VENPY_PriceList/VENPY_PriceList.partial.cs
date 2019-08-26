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
    public partial class VENPY_PriceList
    {
        #region [ VARIABLES ]

        private String pv_tble_namemnd;
        private ObservableCollection<VENPY_PriceListDetail> pv_prli_pricelistdetail;
        private String pv_prli_errormessage;

        #endregion

        #region [ PROPERTIES ]

        [DataMember]
        public String TBLE_NameMND
        {
            get { return pv_tble_namemnd; }
            set
            {
                if (pv_tble_namemnd != value)
                {
                    pv_tble_namemnd = value;
                    OnAttributeChanged("TBLE_NameMND");
                }
            }
        }
        [DataMember]
        public ObservableCollection<VENPY_PriceListDetail> PRLI_PriceListDetail
        {
            get { return pv_prli_pricelistdetail; }
            set { pv_prli_pricelistdetail = value; }
        }
        [DataMember]
        public String PRLI_ErrorMessage
        {
            get { return pv_prli_errormessage; }
        }

        #endregion

        #region [ COPYTO ]

        public void CopyTo(ref VENPY_PriceList Item)
        {
            try
            {
                if (Item == null) { Item = new VENPY_PriceList(); }
                Item.BUSI_Code = this.BUSI_Code;
                Item.PRLI_Code = this.PRLI_Code;
                Item.PRLI_Active = this.PRLI_Active;
                Item.TBLE_TableMND = this.TBLE_TableMND;
                Item.TBLE_CodeMND = this.TBLE_CodeMND;
                Item.PRLI_Name = this.PRLI_Name;
                Item.TBLE_TableTAI = this.TBLE_TableTAI;
                Item.TBLE_CodeTAI = this.TBLE_CodeTAI;
                Item.PRLI_Description = this.PRLI_Description;
                Item.AUDI_CreationUser = this.AUDI_CreationUser;
                Item.AUDI_CreationDate = this.AUDI_CreationDate;
                Item.AUDI_ModificationUser = this.AUDI_ModificationUser;
                Item.AUDI_ModificationDate = this.AUDI_ModificationDate;

                Item.TBLE_NameMND = this.TBLE_NameMND;
                Item.PRLI_PriceListDetail = this.PRLI_PriceListDetail;
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
                pv_prli_errormessage = null;
                if (BUSI_Code.Equals(0))
                {
                    l_correct = false;
                    pv_prli_errormessage += "* Debe ingresar un Código de Empresa" + Environment.NewLine;
                }
                if (string.IsNullOrEmpty(TBLE_TableMND) || string.IsNullOrEmpty(TBLE_CodeMND))
                {
                    l_correct = false;
                    pv_prli_errormessage += "* Debe seleccionar una Moneda" + Environment.NewLine;
                }
                if (string.IsNullOrEmpty(PRLI_Name))
                {
                    l_correct = false;
                    pv_prli_errormessage += "* Debe ingresar un Nombre" + Environment.NewLine;
                }
                if (PRLI_PriceListDetail == null || PRLI_PriceListDetail.Count() == 0)
                {
                    l_correct = false;
                    pv_prli_errormessage += "* Debe agregar por lo menos un Detalle" + Environment.NewLine;
                }
                else
                {
                    int l_index = 1;
                    foreach (var l_item in PRLI_PriceListDetail)
                    {
                        if (!l_item.Check())
                        {
                            l_correct = false;
                            pv_prli_errormessage += "Item " + l_index.ToString() + ":" + Environment.NewLine + l_item.PLDE_ErrorMessage;
                        }
                        l_index++;
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
