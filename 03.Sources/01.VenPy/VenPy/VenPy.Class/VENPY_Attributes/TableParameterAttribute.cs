using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VenPy.Class
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class TableParameterAttribute : Attribute
    {
        public bool Export { get; set; }
        public int Order { get; set; }
    }
}
