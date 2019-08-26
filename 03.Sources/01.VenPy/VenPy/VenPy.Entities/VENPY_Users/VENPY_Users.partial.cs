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
    public partial class VENPY_Users
    {
        #region [ VARIABLES ]

        private String pv_user_type;
        private String pv_user_fullName;

        #endregion

        #region [ PROPIEDADES ]

        [DataMember]
        public String USER_Type
        {
            get { return pv_user_type; }
            set
            {
                if (pv_user_type != value)
                {
                    pv_user_type = value;
                    OnAttributeChanged("USER_Type");
                }
            }
        }
        [DataMember]
        public String USER_FullName
        {
            get { return pv_user_fullName; }
            set
            {
                if (pv_user_fullName != value)
                {
                    pv_user_fullName = value;
                    OnAttributeChanged("USER_FullName");
                }
            }
        }

        #endregion

        #region [ COPYTO ]

        public void CopyTo(ref VENPY_Users Item)
        {
            try
            {
                if (Item == null) { Item = new VENPY_Users(); }
                Item.USER_Code = this.USER_Code;
                Item.USER_UserId = this.USER_UserId;
                Item.USER_Password = this.USER_Password;
                Item.USER_UserName = this.USER_UserName;
                Item.USER_LastName = this.USER_LastName;
                Item.USER_Description = this.USER_Description;
                Item.USER_Active = this.USER_Active;
                Item.USER_Mail = this.USER_Mail;
                Item.GROU_Code = this.GROU_Code;
                Item.AUDI_CreationUser = this.AUDI_CreationUser;
                Item.AUDI_CreationDate = this.AUDI_CreationDate;
                Item.AUDI_ModificationUser = this.AUDI_ModificationUser;
                Item.AUDI_ModificationDate = this.AUDI_ModificationDate;

                Item.USER_Type = this.USER_Type;
                Item.USER_FullName = this.USER_FullName;
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion
    }
}
