using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VenPy.Entities;

namespace VenPy.Main
{
    public interface IMAIN002LView
    {
        void LViewLoad();
        void Search();
    }
    public interface IMAIN002MView
    {
        void MViewLoad();
        void CleanControls();
        void SetItem();
        void GetItem();
    }
}
