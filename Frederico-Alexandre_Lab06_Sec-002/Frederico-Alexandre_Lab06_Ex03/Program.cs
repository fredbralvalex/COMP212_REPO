using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frederico_Alexandre_Lab06_Ex03
{
    class Program
    {
        static void Main(string[] args)
        {

            StudentController controller = StudentController.GetInstance();
            LinkedList<Student> StudentList = new LinkedList<Student>();


            Student std01 = new Student(1, "Frederico Alexandre");
            Student std02 = new Student(2, "Bruno Alves");
            Student std03 = new Student(3, "Alexandre Alves");
            Student std04 = new Student(4, "Alex Alves");
            Student std05 = new Student(5, "Fred Bruno");

            controller.AddLinkedListItem(StudentList, std01);
            controller.AddLinkedListItem(StudentList, std02);
            controller.AddLinkedListItem(StudentList, std03);
            controller.AddLinkedListItem(StudentList, std04);
            controller.AddLinkedListItem(StudentList, std05);

            controller.PrintLinkedList(StudentList);

            controller.RemoveLinkedListItem(StudentList, std04);
            controller.RemoveLinkedListItem(StudentList, std03);

            controller.PrintLinkedList(StudentList);
            
            Console.WriteLine("Student 03 is in the List: " + (controller.SearchLinkedListItem(StudentList, std03)? "Yes!": "No!"));
            Console.WriteLine("Student 02 is in the List: " + (controller.SearchLinkedListItem(StudentList, std02)? "Yes!": "No!"));

            Console.WriteLine("Removing all Students!");
            controller.RemoveAllLinkedListItems(StudentList);

            Console.WriteLine("Student 01 is in the List: " + (controller.SearchLinkedListItem(StudentList, std01) ? "Yes!" : "No!"));
            Console.WriteLine("Student 02 is in the List: " + (controller.SearchLinkedListItem(StudentList, std02) ? "Yes!" : "No!"));
            Console.WriteLine("Student 03 is in the List: " + (controller.SearchLinkedListItem(StudentList, std03) ? "Yes!" : "No!"));
            Console.WriteLine("Student 03 is in the List: " + (controller.SearchLinkedListItem(StudentList, std04) ? "Yes!" : "No!"));
            Console.WriteLine("Student 05 is in the List: " + (controller.SearchLinkedListItem(StudentList, std05) ? "Yes!" : "No!"));

            controller.PrintLinkedList(StudentList);

        }
    }
}
