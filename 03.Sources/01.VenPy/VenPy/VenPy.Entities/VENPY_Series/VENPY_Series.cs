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
    [Serializable()]
    public partial class VENPY_Series : MasterEntity, INotifyPropertyChanged
    {
        #region [ VARIABLES ]

        private Int32 pv_busi_code;
		private Int32 pv_seri_code;
		private String pv_tble_tabletdo;
		private String pv_tble_codetdo;
		private String pv_seri_serie;
		private Int32 pv_seri_number;
		private String pv_seri_description;
		private String pv_audi_creationuser;
		private DateTime pv_audi_creationdate;
		private String pv_audi_modificationuser;
		private Nullable<DateTime> pv_audi_modificationdate;

        #endregion

        #region [ CONSTRUCTORS ]

        public VENPY_Series()
		{  }

        #endregion

        #region [ PROPERTIES ]
        
        [DataMember]
		public Int32 BUSI_Code
		{
			get { return pv_busi_code; }
			set
			{
				if (pv_busi_code != value)
				{
					pv_busi_code = value;
					OnAttributeChanged("BUSI_Code");
				}
			}
		}
		[DataMember]
		public Int32 SERI_Code
		{
			get { return pv_seri_code; }
			set
			{
				if (pv_seri_code != value)
				{
					pv_seri_code = value;
					OnAttributeChanged("SERI_Code");
				}
			}
		}
		[DataMember]
		public String TBLE_TableTDO
		{
			get { return pv_tble_tabletdo; }
			set
			{
				if (pv_tble_tabletdo != value)
				{
					pv_tble_tabletdo = value;
					OnAttributeChanged("TBLE_TableTDO");
				}
			}
		}
		[DataMember]
		public String TBLE_CodeTDO
		{
			get { return pv_tble_codetdo; }
			set
			{
				if (pv_tble_codetdo != value)
				{
					pv_tble_codetdo = value;
					OnAttributeChanged("TBLE_CodeTDO");
				}
			}
		}
		[DataMember]
		public String SERI_Serie
		{
			get { return pv_seri_serie; }
			set
			{
				if (pv_seri_serie != value)
				{
					pv_seri_serie = value;
					OnAttributeChanged("SERI_Serie");
				}
			}
		}
		[DataMember]
		public Int32 SERI_Number
		{
			get { return pv_seri_number; }
			set
			{
				if (pv_seri_number != value)
				{
					pv_seri_number = value;
					OnAttributeChanged("SERI_Number");
				}
			}
		}
		[DataMember]
		public String SERI_Description
		{
			get { return pv_seri_description; }
			set
			{
				if (pv_seri_description != value)
				{
					pv_seri_description = value;
					OnAttributeChanged("SERI_Description");
				}
			}
		}
		[DataMember]
		public String AUDI_CreationUser
		{
			get { return pv_audi_creationuser; }
			set
			{
				if (pv_audi_creationuser != value)
				{
					pv_audi_creationuser = value;
					OnAttributeChanged("AUDI_CreationUser");
				}
			}
		}
		[DataMember]
		public DateTime AUDI_CreationDate
		{
			get { return pv_audi_creationdate; }
			set
			{
				if (pv_audi_creationdate != value)
				{
					pv_audi_creationdate = value;
					OnAttributeChanged("AUDI_CreationDate");
				}
			}
		}
		[DataMember]
		public String AUDI_ModificationUser
		{
			get { return pv_audi_modificationuser; }
			set
			{
				if (pv_audi_modificationuser != value)
				{
					pv_audi_modificationuser = value;
					OnAttributeChanged("AUDI_ModificationUser");
				}
			}
		}
		[DataMember]
		public Nullable<DateTime> AUDI_ModificationDate
		{
			get { return pv_audi_modificationdate; }
			set
			{
				if (pv_audi_modificationdate != value)
				{
					pv_audi_modificationdate = value;
					OnAttributeChanged("AUDI_ModificationDate");
				}
			}
		}

		#endregion
	}
}
