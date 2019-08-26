using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VenPy.Controls
{
    public enum AlignPreliminaryColumns
    {
        Right,
        Left,
        Center
    }

    public class PreliminaryColumns
    {
        public Int32 Index { get; set; }
        public Type DataType { get; set; }
        public String ColumnName { get; set; }
        public String ColumnCaption { get; set; }
        public String Format { get; set; }
        public AlignPreliminaryColumns Align { get; set; }
    }
}
