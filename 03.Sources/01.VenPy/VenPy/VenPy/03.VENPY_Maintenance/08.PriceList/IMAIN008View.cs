using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VenPy.Main
{
    public interface IMAIN008LView
    {
        void LViewLoad();
        void Search();
    }
    public interface IMAIN008MView
    {
        MAIN008PView Presenter { get; set; }
        void MViewLoad();
        void CleanControls();
        void SetItem();
        void GetItem();
    }
}
