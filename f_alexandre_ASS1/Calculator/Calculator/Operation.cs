using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Calculator.DelegateController;

namespace Calculator
{
    class Operation
    {
        
        public Stack<String> Operands;

        public CalculatorDelegate CalculatorOperator;

        public Operation()
        {
            Operands = new Stack<string>();
            NextOperand();
        }

        public void setOperation(CalculatorDelegate CalculatorOperator)
        {
            //this code allow the calculator to perform a result OR change the operation when an new(or the same) operation is called
            if (Operands.ToArray().Length == 2 && this.CalculatorOperator != null)
            {
                //Update the result using the previous operator before set the actual operator
                if (ActualOperand() == "")
                {
                    Operands.Pop();
                    //Remove to be added again, important to keep just 2 operands in the stack
                } else
                {
                    ProcessResult();
                }
            }
            this.CalculatorOperator = CalculatorOperator;            
        }

        public void Append(String str)
        {
            if (Operands.ToArray().Length == 0)
            {
                NextOperand();
            }
            string result = Operands.Pop();
            result += str;
            Operands.Push(result);
        }

        public void RemoveLastDigit()
        {
            string result = Operands.Pop();
            if (result.Length <= 1)
            {
                result = "";
            } else
            {
                result = result.Substring(0, result.Length - 1);
            }
            Operands.Push(result);
        }

        //Clear the calculator
        public string RemoveOperands()
        {
            Operands.Clear();
            return NextOperand();
        }

        public string NextOperand()
        {
            string operand = "";
            Operands.Push(operand);
            return operand;
        }

        public string ActualOperand()
        {
            string operand = Operands.Pop();
            Operands.Push(operand);
            return operand;
        }

        //Method called when the equals our operation button is called
        public string ProcessResult()
        {

            /*
             Console.WriteLine("op2 " + op2);
                Console.WriteLine("op1 " + op1);

             
             */
            int len = Operands.ToArray().Length;
            if (len == 2)
            {
                //process the operation with two operand
                string op2 = Operands.Pop();
                string op1 = Operands.Pop();
                
                if (CalculatorOperator == null)
                {
                    //when result is called without setting the operation
                    return op2;
                } else
                {
                    String result;
                    if (op2.Length == 0)
                    {
                        if (op1.Length == 0)
                        {
                            //when result is called when a operation was set but there are no operands
                            return op1;
                        }
                        //when there is only the first operand
                        result = CalculatorOperator.Invoke(op1, op1);
                    } else
                    {
                        //when there are both operands and the process is regular
                        result = CalculatorOperator.Invoke(op1, op2);
                    }
                    Operands.Push(result);
                    return result;
                }

            }
            else if (len == 1)
            {
                //process the operation with only one operand
                string op1 = Operands.Pop();                
                if (CalculatorOperator == null)
                {
                    //when there is no operation set
                    return op1;
                }
                else
                {
                    String result;
                    if (op1.Length == 0)
                    {
                        //when the operand does not have value
                        result = op1;
                    }
                    else
                    {
                        //Regular process
                        result = CalculatorOperator.Invoke(op1, null);
                    }
                    Operands.Push(result);
                    return result;
                }
            }
            else //if (len == 0)
            {
                //Will never be called: the first operand is always set, if not here we are setting it
                return NextOperand();
            }

        }

    }
}
