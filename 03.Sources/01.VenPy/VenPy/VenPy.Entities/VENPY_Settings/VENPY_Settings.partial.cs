using System;
using System.Text;
using System.Linq;
using System.Globalization;
using System.ComponentModel;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Runtime.Serialization;

namespace VenPy.Entities
{
    public partial class VENPY_Settings
    {
        #region [ COPYTO ]

        public void CopyTo(ref VENPY_Settings Item)
        {
            try
            {
                if (Item == null) { Item = new VENPY_Settings(); }
                Item.BUSI_Code = this.BUSI_Code;
                Item.SETT_Key = this.SETT_Key;
                Item.SETT_Value = this.SETT_Value;
                Item.SETT_Description = this.SETT_Description;
                Item.AUDI_CreationUser = this.AUDI_CreationUser;
                Item.AUDI_CreationDate = this.AUDI_CreationDate;
                Item.AUDI_ModificationUser = this.AUDI_ModificationUser;
                Item.AUDI_ModificationDate = this.AUDI_ModificationDate;
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion
    }
}
