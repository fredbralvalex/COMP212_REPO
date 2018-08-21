using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class DelegateController
    {
        //Globalization to considere . dot as decimal mark
        private readonly System.Globalization.NumberFormatInfo NumberFormatEnUS = System.Globalization.CultureInfo.GetCultureInfo("en-US").NumberFormat;

        //Declare Delegate
        public delegate string CalculatorDelegate(string x, string y);

        public CalculatorDelegate GetDelegateRef(int intoperation)
        {
            switch (intoperation)
            {
                case 1:
                    return Add;
                case 2:
                    return Sub;
                case 3:
                    return Multi;
                case 4:
                    return Div;
                case 5:
                    return Srqt;
                case 6:
                    return Log;
                case 7:
                    return OneEks;
                default:
                    return null;
            }
        }

        private string Add(string x, string y)
        {
            if (x == "") x = "0";

            return Convert.ToString(
                Convert.ToDouble(x, NumberFormatEnUS) +
                Convert.ToDouble(y, NumberFormatEnUS),
                NumberFormatEnUS);
        }
        private string Sub(string x, string y)
        {
            if (x == "") x = "0";
            
            return Convert.ToString(
                Convert.ToDouble(x, NumberFormatEnUS) -
                Convert.ToDouble(y, NumberFormatEnUS),
                NumberFormatEnUS);
        }
        private string Multi(string x, string y)
        {
            if (x == "") x = "1";

            return Convert.ToString(
                Convert.ToDouble(x, NumberFormatEnUS) *
                Convert.ToDouble(y, NumberFormatEnUS),
                NumberFormatEnUS);

        }
        private string Div(string x, string y)
        {
            if (x == "") x = "1";

            return Convert.ToString(
                Convert.ToDouble(x, NumberFormatEnUS) /
                Convert.ToDouble(y, NumberFormatEnUS),
                NumberFormatEnUS);

        }
        private string Srqt(string x, string y)
        {
            return Convert.ToString(
                Math.Sqrt(Convert.ToDouble(x, NumberFormatEnUS)),
                NumberFormatEnUS);

        }
        private string Log(string x, string y)
        {
            return Convert.ToString(
                Math.Log10(Convert.ToDouble(x, NumberFormatEnUS)),
                NumberFormatEnUS);

        }
        private string OneEks(string x, string y)
        {
            return Convert.ToString(1 / Convert.ToDouble(x, NumberFormatEnUS),
                NumberFormatEnUS);

        }
    }
}
