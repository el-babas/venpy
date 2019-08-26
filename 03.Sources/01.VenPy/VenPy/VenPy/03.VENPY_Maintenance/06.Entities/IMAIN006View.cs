using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VenPy.Main
{
    public interface IMAIN006LView
    {
        void LViewLoad();
        void Search();
    }
    public interface IMAIN006MView
    {
        void MViewLoad();
        void CleanControls();
        void SetItem();
        void GetItem();
        void FillEntityTypes(Int32 p_ETYP_Code);
    }
}

