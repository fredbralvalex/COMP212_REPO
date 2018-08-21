using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frederico_Alexandre_Lab06_Ex04
{
    class EmployeeController
    {
        private static EmployeeController instance;

        public static EmployeeController GetInstance()
        {
            if (instance == null)
            {
                instance = new EmployeeController();
            }
            return instance;
        }
        private int GetNextDictionaryKey(SortedDictionary<int, Employee>.KeyCollection keys)
        {
            //Method that returns the max key, this way the key will be automatically obtained with no repetition.
            if (keys.Count == 0)
            {
                return 0;
            } else
            {
                return keys.Max() + 1;
            }
        }

        public void AddDictionaryItem(SortedDictionary<int, Employee> var, Employee emp)
        {
            var.Add(GetNextDictionaryKey(var.Keys), emp);
        }


        public bool RemoveDictionaryItem(SortedDictionary<int, Employee> var, Employee emp)
        {
            int index = SearchDictionaryItem(var, emp);
            if (index > -1)
            {
                return var.Remove(index);
            }
            return false;
        }

        public void PrintDictionary(SortedDictionary<int, Employee> var)
        {
            foreach (KeyValuePair<int, Employee> pair in var)
            {
                Console.WriteLine(pair);
            }
            Console.WriteLine();
        }

        public int SearchDictionaryItem(SortedDictionary<int, Employee> var, Employee emp)
        {
            int index = -1;
            foreach (KeyValuePair<int, Employee> pair in var)
            {
                if(pair.Value.Equals(emp))
                {
                    return pair.Key;
                }
            }
            return index;
        }

        public Employee MaxDictionaryItem(SortedDictionary<int, Employee> var)
        {
            Employee maxSalary = var.ElementAt(0).Value;
            foreach (KeyValuePair<int, Employee> pair in var)
            {
                if (pair.Value.CompareTo(maxSalary) > 0)
                {
                    return maxSalary = pair.Value;
                }
            }
            return maxSalary;
        }
    }
}
