using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using VenPy.Entities;
using VenPy.Class;

namespace VenPy.Connection
{
    public partial class BLVENPY_ProformaDetails : IBLVENPY_ProformaDetails
    {
        #region [ QUERIES ]

        public ObservableCollection<VENPY_ProformaDetails> BLPFDES_ByProforma(Int32 p_BUSI_Code, Int32 p_PROF_Code)
        {
            try
            {
                return PFDES_ByProforma(p_BUSI_Code, p_PROF_Code);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ METHODS ]

        public String BLPFDE_Save(ref ObservableCollection<VENPY_ProformaDetails> p_Items, String p_User)
        {
            try
            {
                string l_message = null;
                string l_item = null;
                for (int i = 0; i < p_Items.Count; i++)
                {
                    var Item = p_Items.ElementAt(i);
                    switch (Item.Instance)
                    {
                        case InstanceEntity.Insert:
                            Item.AUDI_CreationUser = p_User;
                            l_message = PFDEI_AProformaDetail(ref Item);
                            break;
                        case InstanceEntity.Update:
                            Item.AUDI_ModificationUser = p_User;
                            l_message = PFDEU_AProformaDetail(ref Item);
                            break;
                    }
                    l_item = (i + 1).ToString();
                    if (!string.IsNullOrEmpty(l_message))
                    { break; }
                }
                if (!string.IsNullOrEmpty(l_message))
                { l_message = l_item + ": " + l_message; }
                return l_message;
            }
            catch (Exception ex)
            { throw ex; }
        }
        public String BLPFDED_AProformaDetail(ref ObservableCollection<VENPY_ProformaDetails> p_Items)
        {
            try
            {
                string l_message = null;
                string l_item = null;
                for (int i = 0; i < p_Items.Count; i++)
                {
                    var Item = p_Items.ElementAt(i);
                    l_message = PFDED_AProformaDetail(ref Item);
                    l_item = (i + 1).ToString();
                    if (!string.IsNullOrEmpty(l_message))
                    { break; }
                }
                if (!string.IsNullOrEmpty(l_message))
                { l_message = l_item + ": " + l_message; }
                return l_message;
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion
    }
}
