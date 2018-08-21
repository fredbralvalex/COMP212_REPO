using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedListLibrary;

/*
 * This class represents the driver for the question 1 of assignment 5
 */
namespace Frederico_Alexandre_Lab05_Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedListLibrary.List list = new LinkedListLibrary.List();
            Console.WriteLine("A list");
            list.InsertAtBack(2.4);
            list.InsertAtBack(4.5);
            list.InsertAtBack(2.7);
            list.InsertAtBack(1.9);
            list.InsertAtBack(7.2);
            list.Display();
            Console.WriteLine("Search for 7.3... It exists?");
            Console.WriteLine(list.Search(7.3) > 0?"Yes, it does!": "No, it does not!");
            Console.WriteLine("Search for 7.2... It exists?");
            Console.WriteLine(list.Search(7.2) > 0 ? "Yes, it does!" : "No, it does not!");
            Console.WriteLine("There are " + list.Count() + " in the List!");
            Console.WriteLine("The SUM of all elements in the list is: " + MyToString.ToString(list.Sum()));

        }
    }
}
