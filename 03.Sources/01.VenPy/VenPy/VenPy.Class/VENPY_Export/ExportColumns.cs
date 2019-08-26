using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VenPy.Class
{
    public class ExportColumns
    {
        /// <summary>
        /// Data Type of the table
        /// </summary>
        public Type DataType { get; set; }
        /// <summary>
        /// Name of the Column in the table
        /// </summary>
        public String ColumnName { get; set; }
        /// <summary>
        /// Caption of the Column in the table
        /// </summary>
        public String ColumnCaption { get; set; }
        /// <summary>
        /// Column format ( only for txt files )
        /// </summary>
        public String Format { get; set; }
    }
}
