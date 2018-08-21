using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frederico_Alexandre_Lab06_Ex02
{
    class GenericMethod
    {
        public static void Main(string[] args)
        {
            // create arrays of int, double and char
            int[] intArray = { 1, 2, 3, 4, 5, 6 };
            double[] doubleArray = { 1.1, 2.2, 3.3, 4.4, 5.5, 6.6, 7.7 };
            char[] charArray = { 'H', 'E', 'L', 'L', 'O' };

            Console.Write("Array intArray: ");
            DisplayArray(intArray); // pass an int array argument
            Console.WriteLine("DisplayArray (0, 2) : ");
            Console.WriteLine("Elements: " + DisplayArray(intArray, 0, 2));

            Console.Write("Array doubleArray: ");
            DisplayArray(doubleArray); // pass a double array argument
            Console.WriteLine("DisplayArray (2, 5) : ");
            Console.WriteLine("Elements: " + DisplayArray(doubleArray, 2, 5));

            Console.Write("Array charArray: ");
            DisplayArray(charArray); // pass a char array argument
            Console.WriteLine("DisplayArray (2, 3) : ");
            Console.WriteLine("Elements: " + DisplayArray(charArray, 2, 3));


            Console.Write("For Array: ");
            DisplayArray(charArray);
            // Display errors
            try
            {
                Console.WriteLine("DisplayArray (-1, 0) : ");
                DisplayArray(charArray, -1, 0);
            } catch (ArgumentException a)
            {
                Console.WriteLine(a.Message);
            }
            try
            {
                Console.WriteLine("DisplayArray (0, -1) : ");
                DisplayArray(charArray, 0, -1);
            }
            catch (ArgumentException a)
            {
                Console.WriteLine(a.Message);
            }
            try
            {
                Console.WriteLine("DisplayArray (0, 6) : ");
                DisplayArray(charArray, 0, 6);
            }
            catch (ArgumentException a)
            {
                Console.WriteLine(a.Message);
            }
            try
            {
                Console.WriteLine("DisplayArray (6, 0) : ");
                DisplayArray(charArray, 6, 0);
            }
            catch (ArgumentException a)
            {
                Console.WriteLine(a.Message);
            }
            try
            {
                Console.WriteLine("DisplayArray (2, 1) : ");
                DisplayArray(charArray, 2, 1);
            }
            catch (ArgumentException a)
            {
                Console.WriteLine(a.Message);
            }
            try
            {
                Console.WriteLine("DisplayArray (20, 100) : ");
                DisplayArray(charArray, 20, 100);
            }
            catch (ArgumentException a)
            {
                Console.WriteLine(a.Message);
            }
        }

        // output array of all types                           
        private static void DisplayArray<T>(T[] inputArray)
        {
            foreach (var element in inputArray)
            {
                Console.Write($"{element} ");
            }

            Console.WriteLine();
        }
        private static void DisplayArray(int[] inputArray)
        {
            foreach (var element in inputArray)
            {
                Console.Write($"{element} ");
            }

            Console.WriteLine();
        }

        private static int DisplayArray<T>(T[] inputArray, int lowindex, int highindex)
        {

            //validations - outofrange 
            if (highindex < 0 || lowindex < 0 || highindex > inputArray.Length || lowindex > inputArray.Length)
            {
                throw new ArgumentException("DisplayArray out bounds");
            }

            //validation hight <= low
            if (highindex <= lowindex)
            {
                throw new ArgumentException("DisplayArray invalid parameters");
            }

            int count = 0, countDisplayed = 0;
            foreach (var element in inputArray)
            {
                if (count >= lowindex && count <= highindex)
                {
                    Console.Write($"{element} ");
                    countDisplayed++;
                }
                count++;
            }

            Console.WriteLine();
            return countDisplayed;
        }
    }
}
