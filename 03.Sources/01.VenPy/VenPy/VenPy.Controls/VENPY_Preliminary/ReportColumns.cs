using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VenPy.Controls
{
    public class ReportColumns
    {
        #region [ PROPERTIES ]

        public String Name { get; set; }
        public String Description { get; set; }
        public AlignPreliminaryColumns Align { get; set; }

        #endregion

        #region [ CONSTRUCTORS ]

        public ReportColumns(String p_Name, String p_Description, AlignPreliminaryColumns p_Align = AlignPreliminaryColumns.Left)
        {
            Name = p_Name;
            Description = p_Description;
            Align = p_Align;
        }

        #endregion
    }
}
