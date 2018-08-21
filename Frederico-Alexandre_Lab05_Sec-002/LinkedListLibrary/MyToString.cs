using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListLibrary
{
    public static class MyToString
    {
        public static string ToString(this double str)
        {
            return Convert.ToString(str, System.Globalization.CultureInfo.GetCultureInfo("en-US").NumberFormat);
        }
    }
}
