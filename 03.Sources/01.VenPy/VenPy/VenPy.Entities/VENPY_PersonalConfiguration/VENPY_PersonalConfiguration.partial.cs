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
    public partial class VENPY_PersonalConfiguration
    {
        #region [ COPYTO ]

        public void CopyTo(ref VENPY_PersonalConfiguration Item)
        {
            try
            {
                if (Item == null) { Item = new VENPY_PersonalConfiguration(); }
                Item.BUSI_Code = this.BUSI_Code;
                Item.USER_Code = this.USER_Code;
                Item.PCON_Key = this.PCON_Key;
                Item.PCON_Value = this.PCON_Value;
                Item.PCON_Description = this.PCON_Description;
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
