using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackInheritanceLibrary;

/*
 * This class represents the driver for the question 2 of assignment 5
 */
namespace Frederico_Alexandre_Lab05_Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            StackInheritance stack = new StackInheritance();
            Console.WriteLine("Stacking Fibonatti's numbers divided by 10");
            stack.Push(0.1);
            stack.Push(0.1);
            stack.Push(0.2);
            stack.Push(0.3);
            stack.Push(0.5);
            stack.Push(0.8);
            stack.Push(1.3);
            stack.Push(2.1);
            Console.WriteLine("First 8 Fibonatti's numbers divided by 10");
            stack.Display();
            Console.WriteLine("Popping 4");
            stack.Pop();
            stack.Pop();
            stack.Pop();
            stack.Pop();
            stack.Display();
            Console.WriteLine("Peeking the result..." + LinkedListLibrary.MyToString.ToString(stack.Peek()));
            Console.WriteLine("Popping 2 more...");
            stack.Pop();
            stack.Pop();
            Console.WriteLine("Showing the stack.");
            stack.Display();

        }
    }
}
