using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineInventory
{
    class SampleItemService
    {
        public static List<Item> GetSample() =>

           new List<Item>() {               
                new Item(83,   "Electric sander", 59.98,   7),
                new Item(24,  "Power saw",   99.99,   18),
                new Item(7,   "Sledge hammer",   21.55,   11),
                new Item(77,  "Hammer",  11.99,   76),
                new Item(39, "Lawn mower",  79.95,   3),
                new Item(68,  "Screwdriver", 7.99,    106),
                new Item(56,  "Jig Saw", 11.95,   21),
                new Item(3,   "Wrench",  7.95,    34),
           };
    }
}
