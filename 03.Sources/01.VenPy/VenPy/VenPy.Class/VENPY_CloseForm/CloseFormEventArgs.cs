using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VenPy.Class
{
    public class CloseFormEventArgs : EventArgs
    {
        #region [ CONSTRUCTORS ]

        public CloseFormEventArgs(object p_tabPageControl, String p_formName)
        {
            TabPageControl = p_tabPageControl;
            FormName = p_formName;
        }

        #endregion

        #region [ PROPERTIES ]

        public Object TabPageControl { get; set; }
        public String FormName { get; set; }

        #endregion

        #region [ EVENTS ]

        public delegate void CloseFormEventHandler(object sender, CloseFormEventArgs e);

        #endregion
    }
}
