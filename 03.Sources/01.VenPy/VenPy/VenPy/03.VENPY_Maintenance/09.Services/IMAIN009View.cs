using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VenPy.Main
{
    public interface IMAIN009LView
    {
        void LViewLoad();
        void Search();
    }
    public interface IMAIN009MView
    {
        void MViewLoad();
        void CleanControls();
        void SetItem();
        void GetItem();
    }
}

