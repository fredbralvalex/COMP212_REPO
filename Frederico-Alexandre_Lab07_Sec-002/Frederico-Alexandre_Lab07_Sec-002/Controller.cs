using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Numerics;

namespace Frederico_Alexandre_Lab07_Sec_002
{
    class Controller
    {

        Random Rand = new Random();

        private static Controller instance;

        /*Unique Instance */
        public static Controller GetInstance()
        {
            if (instance == null)
            {
                instance = new Controller();
            }
            return instance;
        }

        /*Factorial Funcion */       

        public ulong Factorial (ulong number)
        {
            if (number == 1)
            {
                return number;
            } else
            {
                return number * Factorial(number-1);
            }
        }

        /*Check for Odd or Even*/

        /* Using a delegate to perform the method */
        delegate bool FuncDelegate(int number);
        
        /* Check Even using Lambda Expression*/
        private bool IsEven(int number) => number % 2 == 0;
        /*Check odd using delegate */
        public bool IsOdd(int number) {
            FuncDelegate funcDelegate = IsEven;
            return !funcDelegate(number);
        }

        /*Display List Integers Doubles and Chars*/

        /*Generates a list of random integers*/
        public List<int> GenerateIntList(int size)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < size; i++)
            {
                list.Add(GenerateElement(list));
            }
            return list;
        }

        /*Generates a list of random doubles*/
        public List<Double> GenerateDoubleList(int size)
        {
            List<Double> list = new List<Double>();
            for (int i = 0; i < size; i++)
            {
                list.Add(GenerateElement(list));
            }
            return list;
        }

        /*Generates a list of random doubles*/
        public List<char> GenerateCharList(int size)
        {
            List<char> list = new List<char>();
            for (int i = 0; i < size; i++)
            {
                list.Add(GenerateElement(list));
            }
            return list;
        }

        /*Generate a valid random int value*/
        private int GenerateElement(List<int> list)
        {
            //random a mumber between 10 inclusive and 100 excluded
            int element = Rand.Next(10, 100);
            if (SearchData(list, element))
            {
                return GenerateElement(list);
            }
            else
            {
                return element;
            }
        }

        /*Generate a valid random double value*/
        private Double GenerateElement(List<Double> list)
        {
            //generate a random number between 0 and 100.00
            Double elementRand = Rand.NextDouble() * 100;
            //using only 2 decimal places
            Double element = Math.Round(elementRand, 2);
            //ignore a non desired number
            if (SearchData(list, element) && (element > 10 && element < 99))
            {
                return GenerateElement(list);
            }
            else
            {
                return element;
            }
        }     
        
        /*Generate a valid random double value*/
        private char GenerateElement(List<char> list)
        {
            //generate a random number between 0 and 25
            int pos = Rand.Next(0, 26);
            char element = (char)('a' + pos);
            //ignore an already used char
            if (list.Contains(element))
            {
                return GenerateElement(list);
            }
            else
            {
                return element;
            }
        }

        /*A simple search for a element position*/
        public bool SearchData<T>(List<T> list, T element)
        {
            //check if the list contains using own provided method
            return list.Contains(element);
        }

        /*Generate a List with only the elements between the provided range*/
        public List<T> PrintData<T>(List<T> list, int lowindex, int highindex)
        {

            //validations - outofrange 
            if (highindex < 0 || lowindex < 0 || highindex >= list.Count || lowindex > list.Count)
            {
                throw new ArgumentException("Index Out Bounds");
            }

            //validation hight <= low
            if (highindex <= lowindex)
            {
                throw new ArgumentException("Invalid parameters");
            }

            List<T> listToReturn = new List<T>();
            for (int pos = lowindex; pos <= highindex; pos++)
            {
                listToReturn.Add(list.ElementAt(pos));
            }
            return listToReturn;
        }

        /*Convert the elements in the list in a string of elements*/
        public string PrintData<T>(List<T> list)
        {
            string dataString = "";
            foreach (var element in list)
            {
                dataString += element + " ";
            }

            return dataString;
        }
    }
}
