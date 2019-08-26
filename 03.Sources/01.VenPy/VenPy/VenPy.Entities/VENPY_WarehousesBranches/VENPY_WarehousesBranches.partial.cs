using System;
using System.Text;
using System.Linq;
using System.Globalization;
using System.ComponentModel;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Runtime.Serialization;
using VenPy.Class;

namespace VenPy.Entities
{
    public partial class VENPY_WarehousesBranches
    {
        #region [ VARIABLES ]

        private String pv_tble_namealm;
        private Boolean pv_wabr_select;

        #endregion

        #region [ PROPERTIES ]

        [DataMember]
        public String TBLE_NameALM
        {
            get { return pv_tble_namealm; }
            set
            {
                if (pv_tble_namealm != value)
                {
                    pv_tble_namealm = value;
                    OnAttributeChanged("TBLE_NameALM");
                }
            }
        }
        [DataMember]
        public Boolean WABR_Select
        {
            get { return pv_wabr_select; }
            set
            {
                if (pv_wabr_select != value)
                {
                    pv_wabr_select = value;
                    OnAttributeChanged("WABR_Select");
                }
            }
        }

        #endregion

        #region [ COPYTO ]

        public void CopyTo(ref VENPY_WarehousesBranches Item)
        {
            try
            {
                if (Item == null) { Item = new VENPY_WarehousesBranches(); }
                Item.BUSI_Code = this.BUSI_Code;
                Item.BOFF_Code = this.BOFF_Code;
                Item.TBLE_TableALM = this.TBLE_TableALM;
                Item.TBLE_CodeALM = this.TBLE_CodeALM;
                Item.AUDI_CreationUser = this.AUDI_CreationUser;
                Item.AUDI_CreationDate = this.AUDI_CreationDate;
                Item.AUDI_ModificationUser = this.AUDI_ModificationUser;
                Item.AUDI_ModificationDate = this.AUDI_ModificationDate;

                Item.TBLE_NameALM = this.TBLE_NameALM;
                Item.WABR_Select = this.WABR_Select;
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion
    }
}
