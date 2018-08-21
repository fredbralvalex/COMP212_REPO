using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frederico_alexandre_Sec002_COMP212_Ex_01
{
    class ValuesController
    {
        private static ValuesController instance;
        public LinkedList<int> ListOfIntegers = new LinkedList<int>();
        Random Rand = new Random();

        public static ValuesController GetInstance()
        {
            if (instance == null)
            {
                instance = new ValuesController();
            }
            return instance;
        }

        public void GenerateList(int size)
        {
            ListOfIntegers = new LinkedList<int>();
            for (int i = 0; i < size; i++)
            {
                ListOfIntegers.AddLast(GenerateElement(ListOfIntegers));
            }
        }

        public int GenerateElement()
        {
            return GenerateElement(ListOfIntegers);
        }

        private int GenerateElement(LinkedList<int> list)
        {
            //random a mumber between 11 inclusive and 100 excluded
            int element = Rand.Next(11, 100);
            if (SearchData(list, element))
            {
                return GenerateElement(list);
            }
            else
            {
                return element;
            }
        }
        public bool SearchData<T>(LinkedList<T> list, T element)
        {
            return list.Contains(element);
        }

        public void AddAtFront ()
        {
            ListOfIntegers.AddFirst(GenerateElement());
        }

        public void RemoveFromFront ()
        {
            if (ListOfIntegers.Count > 0)
            {
                ListOfIntegers.RemoveFirst();
            } else
            {
                throw new ArgumentException("There is no element to be removed from the list!!");
            }
        }

        public int LargestInteger()
        {
            if (ListOfIntegers.Count <= 0)            
            {
                throw new ArgumentException("There is no element in the list!!");
            }

            int largest = ListOfIntegers.ElementAt(0);
            foreach(int el in ListOfIntegers)
            {
                if (el > largest)
                {
                    largest = el;
                }
            }
            return largest;
        }
    }
}
