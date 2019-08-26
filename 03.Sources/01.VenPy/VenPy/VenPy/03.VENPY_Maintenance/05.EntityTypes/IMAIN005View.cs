using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VenPy.Main
{
    public interface IMAIN005LView
    {
        void LViewLoad();
        void Search();
    }
    public interface IMAIN005MView
    {
        void MViewLoad();
        void CleanControls();
        void BlockControls();
        void SetItem();
        void GetItem();
    }
}

