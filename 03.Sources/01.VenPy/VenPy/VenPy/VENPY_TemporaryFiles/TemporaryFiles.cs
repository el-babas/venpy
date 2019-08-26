using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Xml.Serialization;
using VenPy.Class;
using VenPy.Entities;
using VenPy.Connection;
using VenPy.Controls;

namespace VenPy.Main
{
    public class TemporaryFiles
    {
        #region [ VARIABLES ] 

        public static String pv_filename_personalconfiguration = "VENPY_PersonalConfiguration.xml";
        public static String pv_filename_ubigeos = "VENPY_Ubigeos.xml";
        public static String pv_filename_tables = "VENPY_Tables.xml";
        public static String pv_filename_settings = "VENPY_Settings.xml";

        #endregion

        #region [ PROPERTIES ]

        private static IBLVENPY_PersonalConfiguration BL_VENPY_PersonalConfiguration { get; set; }
        private static IBLVENPY_Ubigeos BL_VENPY_Ubigeos { get; set; }
        private static IBLVENPY_Tables BL_VENPY_Tables { get; set; }
        private static IBLVENPY_Settings BL_VENPY_Settings { get; set; }
        public static String PathTemporaryFile { get; set; }

        #endregion

        #region [ METHODS ]

        #region [ Personal Configuration ]

        public static void LoadPersonalConfiguration(Int32 p_BUSI_Code, Int32 p_USER_Code)
        {
            try
            {
                String l_path = Path.Combine(PathTemporaryFile, pv_filename_personalconfiguration);
                BL_VENPY_PersonalConfiguration = new BLVENPY_PersonalConfiguration();
                ObservableCollection<VENPY_PersonalConfiguration> Items = new ObservableCollection<VENPY_PersonalConfiguration>();
                Items = BL_VENPY_PersonalConfiguration.BLPCONS_ByUser(p_BUSI_Code, p_USER_Code);
                SerializeObservableCollection(l_path, Items);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public static ObservableCollection<VENPY_PersonalConfiguration> DeserializePersonalConfiguration()
        {
            try
            {
                String l_path = Path.Combine(PathTemporaryFile, pv_filename_personalconfiguration);
                ObservableCollection<VENPY_PersonalConfiguration> Items = new ObservableCollection<VENPY_PersonalConfiguration>();
                XmlSerializer xs = new XmlSerializer(typeof(ObservableCollection<VENPY_PersonalConfiguration>));
                using (StreamReader rd = new StreamReader(l_path))
                { Items = xs.Deserialize(rd) as ObservableCollection<VENPY_PersonalConfiguration>; }
                return Items;
            }
            catch (Exception ex)
            { throw ex; }
        }
        private static void SerializeObservableCollection(String Path, ObservableCollection<VENPY_PersonalConfiguration> Items)
        {
            try
            {
                XmlSerializer xs = new XmlSerializer(typeof(ObservableCollection<VENPY_PersonalConfiguration>));
                using (StreamWriter wr = new StreamWriter(Path))
                { xs.Serialize(wr, Items); }
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ Ubigeos ]

        public static void LoadUbigeos()
        {
            try
            {
                String l_path = Path.Combine(PathTemporaryFile, pv_filename_ubigeos);
                BL_VENPY_Ubigeos = new BLVENPY_Ubigeos();
                ObservableCollection<VENPY_Ubigeos> Items = new ObservableCollection<VENPY_Ubigeos>();
                Items = BL_VENPY_Ubigeos.BLUBIGS_All();
                SerializeObservableCollection(l_path, Items);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public static ObservableCollection<VENPY_Ubigeos> DeserializeUbigeos()
        {
            try
            {
                String l_path = Path.Combine(PathTemporaryFile, pv_filename_ubigeos);
                ObservableCollection<VENPY_Ubigeos> Items = new ObservableCollection<VENPY_Ubigeos>();
                XmlSerializer xs = new XmlSerializer(typeof(ObservableCollection<VENPY_Ubigeos>));
                using (StreamReader rd = new StreamReader(l_path))
                { Items = xs.Deserialize(rd) as ObservableCollection<VENPY_Ubigeos>; }
                return Items;
            }
            catch (Exception ex)
            { throw ex; }
        }
        private static void SerializeObservableCollection(String Path, ObservableCollection<VENPY_Ubigeos> Items)
        {
            try
            {
                XmlSerializer xs = new XmlSerializer(typeof(ObservableCollection<VENPY_Ubigeos>));
                using (StreamWriter wr = new StreamWriter(Path))
                { xs.Serialize(wr, Items); }
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ Tables ]

        public static void LoadTables(Int32 p_BUSI_Code)
        {
            try
            {
                String l_path = Path.Combine(PathTemporaryFile, pv_filename_tables);
                BL_VENPY_Tables = new BLVENPY_Tables();
                ObservableCollection<VENPY_Tables> Items = new ObservableCollection<VENPY_Tables>();
                Items = BL_VENPY_Tables.BLTBLES_All(p_BUSI_Code);
                SerializeObservableCollection(l_path, Items);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public static ObservableCollection<VENPY_Tables> DeserializeTables()
        {
            try
            {
                String l_path = Path.Combine(PathTemporaryFile, pv_filename_tables);
                ObservableCollection<VENPY_Tables> Items = new ObservableCollection<VENPY_Tables>();
                XmlSerializer xs = new XmlSerializer(typeof(ObservableCollection<VENPY_Tables>));
                using (StreamReader rd = new StreamReader(l_path))
                { Items = xs.Deserialize(rd) as ObservableCollection<VENPY_Tables>; }
                return Items;
            }
            catch (Exception ex)
            { throw ex; }
        }
        private static void SerializeObservableCollection(String Path, ObservableCollection<VENPY_Tables> Items)
        {
            try
            {
                XmlSerializer xs = new XmlSerializer(typeof(ObservableCollection<VENPY_Tables>));
                using (StreamWriter wr = new StreamWriter(Path))
                { xs.Serialize(wr, Items); }
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ Settings ]

        public static void LoadSettings(Int32 p_BUSI_Code)
        {
            try
            {
                String l_path = Path.Combine(PathTemporaryFile, pv_filename_settings);
                BL_VENPY_Settings = new BLVENPY_Settings();
                ObservableCollection<VENPY_Settings> Items = new ObservableCollection<VENPY_Settings>();
                Items = BL_VENPY_Settings.BLSETTS_ByBusiness(p_BUSI_Code);
                SerializeObservableCollection(l_path, Items);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public static ObservableCollection<VENPY_Settings> DeserializeSettings()
        {
            try
            {
                String l_path = Path.Combine(PathTemporaryFile, pv_filename_settings);
                ObservableCollection<VENPY_Settings> Items = new ObservableCollection<VENPY_Settings>();
                XmlSerializer xs = new XmlSerializer(typeof(ObservableCollection<VENPY_Settings>));
                using (StreamReader rd = new StreamReader(l_path))
                { Items = xs.Deserialize(rd) as ObservableCollection<VENPY_Settings>; }
                return Items;
            }
            catch (Exception ex)
            { throw ex; }
        }
        private static void SerializeObservableCollection(String Path, ObservableCollection<VENPY_Settings> Items)
        {
            try
            {
                XmlSerializer xs = new XmlSerializer(typeof(ObservableCollection<VENPY_Settings>));
                using (StreamWriter wr = new StreamWriter(Path))
                { xs.Serialize(wr, Items); }
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #endregion
    }
}
