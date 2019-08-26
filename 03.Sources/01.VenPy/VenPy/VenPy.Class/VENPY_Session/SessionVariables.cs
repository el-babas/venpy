using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VenPy.Class
{
    public class SessionVariables
    {
        #region [ VARIABLES ]

        private static String pv_version;
        private static String pv_server;
        private static String pv_dataBase;
        private static String pv_coneccionString;
        private static String pv_useFullName;
        private static String pv_userName;
        private static String pv_userType;
        private static String pv_businessRuc;
        private static String pv_businessName;
        private static String pv_branchName;
        private static String pv_pointSaleName;
        private static Int32 pv_pointSaleCode;
        private static Int32 pv_businessCode;
        private static Int32 pv_branchCode;
        private static Int32 pv_userCode;

        #endregion

        #region [ PROPERTIES ]

        public static String Version
        {
            get { return pv_version; }
            set { pv_version = value; }
        }
        public static String Server
        {
            get { return pv_server; }
            set { pv_server = value; }
        }
        public static String DataBase
        {
            get { return pv_dataBase; }
            set { pv_dataBase = value; }
        }
        public static String ConeccionString
        {
            get { return pv_coneccionString; }
            set { pv_coneccionString = value; }
        }
        public static String UserFullName
        {
            get { return pv_useFullName; }
            set { pv_useFullName = value; }
        }
        public static String UserName
        {
            get { return pv_userName; }
            set { pv_userName = value; }
        }
        public static String UserType
        {
            get { return pv_userType; }
            set { pv_userType = value; }
        }
        public static String BusinessRuc
        {
            get { return pv_businessRuc; }
            set { pv_businessRuc = value; }
        }
        public static String BusinessName
        {
            get { return pv_businessName; }
            set { pv_businessName = value; }
        }
        public static String BranchName
        {
            get { return pv_branchName; }
            set { pv_branchName = value; }
        }
        public static String PointSaleName
        {
            get { return pv_pointSaleName; }
            set { pv_pointSaleName = value; }
        }
        public static Int32 PointSaleCode
        {
            get { return pv_pointSaleCode; }
            set { pv_pointSaleCode = value; }
        }
        public static Int32 BusinessCode
        {
            get { return pv_businessCode; }
            set { pv_businessCode = value; }
        }
        public static Int32 BranchCode
        {
            get { return pv_branchCode; }
            set { pv_branchCode = value; }
        }
        public static Int32 UserCode
        {
            get { return pv_userCode; }
            set { pv_userCode = value; }
        }

        #endregion
    }
}
