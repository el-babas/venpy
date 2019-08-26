using System;
using System.Xml;
using System.Data;
using System.Reflection;
using System.Data.Common;
using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;

namespace VenPy.Class
{
    public class EntityLoader<TEntity>
    {
        #region [ PROPERTIES ]

        public Type EntityType { get; set; }

        #endregion

        #region [ CONSTRUCTORS ]

        public EntityLoader()
        {
            EntityType = typeof(TEntity);
        }

        #endregion

        #region [ METHODS ]

        public void LoadEntity(IDataReader p_reader, object p_scheme)
        {
            try
            {
                int _fields = p_reader.FieldCount - 1;
                for (int _index = 0; _index <= _fields; _index++)
                {
                    if (!p_reader.IsDBNull(_index))
                    {
                        object _value = p_reader.GetValue(_index);
                        string _field = p_reader.GetName(_index);
                        PropertyInfo _propertInfo = null;
                        _propertInfo = EntityType.GetProperty(_field);
                        if (!((_propertInfo == null)))
                        {
                            Type _tipoCampo = _propertInfo.PropertyType;
                            if (_propertInfo.CanWrite)
                            { this.SetValueEntity(ref _propertInfo, _tipoCampo.ToString(), _value, ref p_scheme); }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void LoadEntity(DataRow p_row, object p_scheme)
        {
            try
            {
                int _fields = p_row.Table.Columns.Count - 1;
                for (int _index = 0; _index <= _fields; _index++)
                {
                    if ((p_row[_index] != DBNull.Value))
                    {
                        object _value = p_row[_index];
                        string _field = p_row.Table.Columns[_index].ColumnName;
                        PropertyInfo _propertInfo = null;
                        _propertInfo = EntityType.GetProperty(_field);
                        if (!((_propertInfo == null)))
                        {
                            Type _tipoCampo = _propertInfo.PropertyType;
                            if (_propertInfo.CanWrite)
                            { SetValueEntity(ref _propertInfo, _tipoCampo.ToString(), _value, ref p_scheme); }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void SetValueEntity(ref PropertyInfo p_propertInfo, string p_typeVariable, object p_value, ref object p_scheme)
        {
            if (p_value != null)
            {
                switch (p_typeVariable)
                {
                    case "System.String":
                        p_propertInfo.SetValue(p_scheme, p_value.ToString(), null);
                        break;
                    case "System.Int16":
                        Int16 _value1;
                        if (Int16.TryParse(p_value.ToString(), out _value1))
                        { p_propertInfo.SetValue(p_scheme, _value1, null); }
                        break;
                    case "System.Nullable`1[System.Int16]":
                        Int16 _value2;
                        if (Int16.TryParse(p_value.ToString(), out _value2))
                        { p_propertInfo.SetValue(p_scheme, _value2, null); }
                        break;
                    case "System.Int32":
                        Int32 _value3;
                        if (Int32.TryParse(p_value.ToString(), out _value3))
                        { p_propertInfo.SetValue(p_scheme, _value3, null); }
                        break;
                    case "System.Nullable`1[System.Int32]":
                        Int32 _value4;
                        if (Int32.TryParse(p_value.ToString(), out _value4))
                        { p_propertInfo.SetValue(p_scheme, _value4, null); }
                        break;
                    case "System.Double":
                        Double _value5;
                        if (Double.TryParse(p_value.ToString(), out _value5))
                        { p_propertInfo.SetValue(p_scheme, _value5, null); }
                        break;
                    case "System.Nullable`1[System.Double]":
                        Double _value6;
                        if (Double.TryParse(p_value.ToString(), out _value6))
                        { p_propertInfo.SetValue(p_scheme, _value6, null); }
                        break;
                    case "System.Decimal":
                        Decimal _value7;
                        if (Decimal.TryParse(p_value.ToString(), out _value7))
                        { p_propertInfo.SetValue(p_scheme, _value7, null); }
                        break;
                    case "System.Nullable`1[System.Decimal]":
                        Decimal _value8;
                        if (Decimal.TryParse(p_value.ToString(), out _value8))
                        { p_propertInfo.SetValue(p_scheme, _value8, null); }
                        break;
                    case "System.DateTime":
                        DateTime _value9;
                        if (DateTime.TryParse(p_value.ToString(), out _value9))
                        { p_propertInfo.SetValue(p_scheme, _value9, null); }
                        break;
                    case "System.Nullable`1[System.DateTime]":
                        DateTime _value10;
                        if (DateTime.TryParse(p_value.ToString(), out _value10))
                        { p_propertInfo.SetValue(p_scheme, _value10, null); }
                        break;
                    case "System.Boolean":
                        Boolean _value11;
                        if (Boolean.TryParse(p_value.ToString(), out _value11))
                        { p_propertInfo.SetValue(p_scheme, _value11, null); }
                        break;
                    case "System.Nullable`1[System.Boolean]":
                        Boolean _value12;
                        if (Boolean.TryParse(p_value.ToString(), out _value12))
                        { p_propertInfo.SetValue(p_scheme, _value12, null); }
                        break;
                    case "System.Guid":
                        Guid _value13 = default(Guid);
                        if ((Guid.TryParse(p_value.ToString(), out _value13)))
                        { p_propertInfo.SetValue(p_scheme, _value13, null); }
                        break;
                    case "System.Nullable`1[System.Guid]":
                        Guid _value14 = default(Guid);
                        if ((Guid.TryParse(p_value.ToString(), out _value14)))
                        { p_propertInfo.SetValue(p_scheme, _value14, null); }
                        break;
                    case "System.Xml.XmlDocument":
                        try
                        {
                            XmlDocument _value15 = new XmlDocument();
                            _value15.LoadXml(p_value.ToString());
                            p_propertInfo.SetValue(p_scheme, _value15, null);
                        }
                        catch (Exception) { }
                        break;
                    case "System.TimeSpan":
                        TimeSpan _value17 = default(TimeSpan);
                        if ((TimeSpan.TryParse(p_value.ToString(), out _value17)))
                        { p_propertInfo.SetValue(p_scheme, _value17, null); }
                        break;
                    case "System.Nullable`1[System.TimeSpan]":
                        TimeSpan _value18;
                        if ((TimeSpan.TryParse(p_value.ToString(), out _value18)))
                        { p_propertInfo.SetValue(p_scheme, _value18, null); }
                        break;
                    case "System.Byte[]":
                        if (p_value != null)
                        { p_propertInfo.SetValue(p_scheme, (byte[])p_value, null); }
                        break;
                }
            }
        }

        #endregion
    }
}
