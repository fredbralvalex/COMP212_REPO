using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineInventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Item> items = SampleItemService.GetSample();
            /*
                1.	Use LINQ to sort the data by item description [1 mark]                
             */
            Console.Write("1.  Use LINQ to sort the data by item description [1 mark]\n");
            var r1 = items.OrderBy(x => x.Description).ThenBy(x => x);
            Print(r1);
            Console.WriteLine();
            /*
                2.	Use LINQ to select the item description and quantity, and sort the results by quantity[1 mark]
             */
            Console.Write("2.  Use LINQ to select the item description and quantity, and sort the results by quantity[1 mark]\n");
            var r2 = from item in items
                     orderby item.Quantity
                     select new
                     {
                         item.Description,
                         item.Quantity
                     };
            foreach (var i in r2)
                Console.WriteLine($"{i}");
            Console.WriteLine("\n");
            /*
               3.	Use LINQ to select the item description and its total value (i.e., quantity * unit price), order the results by total value [1.5 marks]
            */
            Console.Write("3.  Use LINQ to select the item description and its total value (i.e., quantity * unit price), order the results by total value [1.5 marks]\n");
            var r3 = from item in items
                     let T = item.Quantity * item.Price
                     orderby T descending
                     select new
                     {
                         item.Description,
                         Total = T
                     };
            foreach (var i in r3)
                Console.WriteLine($"{i}");
            Console.WriteLine();
            /*
                4.	Use LINQ to retrieve and display top two expensive items [0.5 mark]
             */
            Console.Write("4.  Use LINQ to retrieve and display top two expensive items [0.5 mark]\n");
            var r4 = (from item in items                     
                     orderby item.Price descending
                     select item).Take(2);

            foreach (var i in r4)
                Console.WriteLine($"{i}");
            Console.WriteLine();

            Console.ReadKey();
        }

        private static void Print(IEnumerable<Item> list)
        {
            foreach (var i in list)
                Console.WriteLine($"{i}");
        }
    }
}
