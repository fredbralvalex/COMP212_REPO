using System;
using QueueInheritanceLibrary;
/*
 * This class represents the driver for the question 3 of assignment 5
 */
namespace Frederico_Alexandre_Lab05_Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            QueueInheritance queue = new QueueInheritance();

            Console.WriteLine("Creating an empty Queue");
            queue.Display();
            Console.WriteLine("Enqueuing the name of the the second and last ruler of the Empire of Brazil:");
            queue.Enqueue("Pedro");
            queue.Enqueue("de Alcântara");
            queue.Enqueue("João");
            queue.Enqueue("Carlos");
            queue.Enqueue("Leopoldo");
            queue.Enqueue("Salvador");
            queue.Enqueue("Bibiano");
            queue.Enqueue("Francisco");
            Console.WriteLine("Half of his name");
            queue.Display();
            queue.Enqueue("Pedro");
            queue.Enqueue("Xavier");
            queue.Enqueue("de Paula");
            queue.Enqueue("Leocádio");
            queue.Enqueue("Miguel");
            queue.Enqueue("Gabriel");
            queue.Enqueue("Rafael");
            queue.Enqueue("Gonzaga");
            Console.WriteLine("Full name of D. Pedro II");
            Console.WriteLine("Dequeuing his name...");
            queue.Display();

            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();
            Console.WriteLine("Half of his name... again!");
            queue.Display();
        }
    }
}
