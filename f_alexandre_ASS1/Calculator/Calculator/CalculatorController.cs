using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class CalculatorController
    {
        //Controller that keeps the delegate from the operations:
        //1:Add; 2:Sub; 3:Multi; 4:Div; 5:Srqt; 6:Log; 7:OneEks;
        DelegateController delegateController = new DelegateController();
        Operation Op;

        public CalculatorController()
        {
            Op = new Operation();
        }
        public string AppendDigit(String Digit)
        {
            Op.Append(Digit);
            return ConvertToDisplay(Op.ActualOperand());
        }

        //Globalization to considere . dot as decimal mark
        private readonly System.Globalization.NumberFormatInfo NumberFormatEnUS = System.Globalization.CultureInfo.GetCultureInfo("en-US").NumberFormat;
        private string ConvertToDisplay(String value)
        {
            if (value == "")
            {
                return "0";
            } else if(value == ".")
            {
                return "0.";
            } else if (value.Last() == '.')
            {
                return value;
            } else if (value.StartsWith("NaN"))
            {
                return "NaN";
            }

            return Convert.ToString(Convert.ToDouble(value, NumberFormatEnUS),
                NumberFormatEnUS);
        }
        public string AppendDot()
        {
            if (Op.ActualOperand().IndexOf('.') < 0)
            {
                Op.Append(".");
            }
            return ConvertToDisplay(Op.ActualOperand());
        }
        public string Back()
        {
            Op.RemoveLastDigit();
            return ConvertToDisplay(Op.ActualOperand());
        }
        public string Add()
        {
            Op.setOperation(delegateController.GetDelegateRef(1));
            String result = ConvertToDisplay(Op.ActualOperand());
            Op.NextOperand();
            return result;
        }

        public string Sub()
        {
            Op.setOperation(delegateController.GetDelegateRef(2));
            String result = ConvertToDisplay(Op.ActualOperand());
            Op.NextOperand();
            return result;
        }
        public string Mul()
        {
            Op.setOperation(delegateController.GetDelegateRef(3));
            String result = ConvertToDisplay(Op.ActualOperand());
            Op.NextOperand();
            return result;
        }
        public string Div()
        {
            Op.setOperation(delegateController.GetDelegateRef(4));
            String result = ConvertToDisplay(Op.ActualOperand());
            Op.NextOperand();
            return result;
        }
        public string Sqrt()
        {
            Op.setOperation(delegateController.GetDelegateRef(5));            
            return Eq();
        }
        public string Ce()
        {
            return ConvertToDisplay(Op.RemoveOperands());
        }
        public string Eks()
        {
            Op.setOperation(delegateController.GetDelegateRef(7));
            return Eq();
        }

        public string Log()
        {
            Op.setOperation(delegateController.GetDelegateRef(6));
            return Eq();
        }
        public string Eq()
        {
            return ConvertToDisplay(Op.ProcessResult());
        }
    }

}
