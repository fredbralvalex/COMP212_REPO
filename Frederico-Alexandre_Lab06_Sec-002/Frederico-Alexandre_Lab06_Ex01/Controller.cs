using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frederico_Alexandre_Lab06_Ex01
{
    class Controller
    {
        Random Rand = new Random();
        private static Controller instance;        

        public static Controller GetInstance()
        {
            if (instance == null)
            {
                instance = new Controller();
            }
            return instance;
        }

        public int[] GenerateIntArrayList(int size)
        {
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = GenerateElement(array);
            }
            return array;
        }

        public Double [] GenerateDoubleArrayList(int size)
        {
            Double[] array = new Double[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = GenerateElement(array);
            }
            return array;
        }

        private int GenerateElement(int[] array)
        {
            int element = Rand.Next(1, 99);
            if (SearchElement(array, element) > -1)
            {
                return GenerateElement(array);
            } else
            {
                return element;
            }
        }

        private Double GenerateElement(Double[] array)
        {
            Double element = Math.Round(Rand.NextDouble(), 2);
            if (SearchElement(array, element) > -1)
            {
                return GenerateElement(array);
            } else
            {
                return element;
            }
        }

        public string PrintOutArray <T>(T [] array)
        {
            string printOut = "";
            for(int i = 0; i < array.Length - 1; i++)
            {
                printOut += array[i] + "   ";
            }
            return printOut += array[array.Length - 1];

        }        

        public int SearchElement<T>(T [] array, T element) where T : IComparable<T>
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]!= null && array[i].CompareTo(element) == 0)
                {
                    return i;
                }
            }
            return -1;
        }
    }    
}
