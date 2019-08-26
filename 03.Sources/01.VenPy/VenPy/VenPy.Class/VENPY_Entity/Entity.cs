using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace VenPy.Class
{
    #region [ TYPES OF INSTANCE ]

    [DataContract()]
    public enum InstanceEntity
    {
        [EnumMember()]
        Unchanged = 0,
        [EnumMember()]
        Insert = 1,
        [EnumMember()]
        Update = 2,
        [EnumMember()]
        Delete = 3
    }

    #endregion

    [DataContract]
    [Serializable()]
    public class MasterEntity : INotifyPropertyChanged, ICloneable
    {
        #region [ VARIABLES ]

        public InstanceEntity pb_instance;

        #endregion

        #region [ PROPERTIES ]

        [DataMember]
        public InstanceEntity Instance
        {
            get { return pb_instance; }
            set { pb_instance = value; }
        }

        #endregion

        #region [ EVENTS ]

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region [ METHODS ]

        protected virtual void OnAttributeChanged(String p_attributeName)
        {
            if (pb_instance != InstanceEntity.Insert && pb_instance != InstanceEntity.Delete)
            { pb_instance = InstanceEntity.Update; }
            PropertyChanged?.Invoke(null, new PropertyChangedEventArgs(p_attributeName));
        }
        public object Clone()
        {
            MasterEntity l_nuevo = (MasterEntity)this.MemberwiseClone();
            return l_nuevo;
        }

        #endregion
    }
}
