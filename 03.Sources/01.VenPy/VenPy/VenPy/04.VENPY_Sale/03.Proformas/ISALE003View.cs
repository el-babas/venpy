using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VenPy.Main
{
    public interface ISALE003LView
    {
        void LViewLoad();
        void Search();
    }
    public interface ISALE003MView
    {
        SALE003PView Presenter { get; set; }
        void MViewLoad();
        void CleanControls();
        void SetItem();
        void GetItem();
    }
}
