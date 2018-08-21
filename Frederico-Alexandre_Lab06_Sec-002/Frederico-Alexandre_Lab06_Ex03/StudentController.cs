using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frederico_Alexandre_Lab06_Ex03
{
    public class StudentController
    {
        private static  StudentController instance;

        public static StudentController GetInstance()
        {
            if (instance == null)
            {
                instance = new StudentController();
            }
            return instance;
        }

        public void AddLinkedListItem(LinkedList<Student> StudentList, Student StudentObject)
        {
            if (StudentList == null)
            {
                StudentList = new LinkedList<Student>();
            }

            StudentList.AddLast(StudentObject);
        }


        public void RemoveLinkedListItem(LinkedList<Student> StudentList, Student StudentObject)
        {
            if (StudentList == null)
            {
                StudentList = new LinkedList<Student>();
            }

            StudentList.Remove(StudentObject);
        }

        public void PrintLinkedList(LinkedList<Student> StudentList)
        {
            if (StudentList == null)
            {
                StudentList = new LinkedList<Student>();
            }

            LinkedListNode<Student> currentNode = StudentList.First;

            Console.WriteLine("The list content is: ");
            while (currentNode != null)
            {
                Console.WriteLine(currentNode.Value);
                currentNode = currentNode.Next;
            }
            Console.WriteLine();
        }

        public bool SearchLinkedListItem(LinkedList<Student> StudentList, Student StudentObject)
        {
            if (StudentList == null)
            {
                StudentList = new LinkedList<Student>();
            }

            return StudentList.Contains(StudentObject);
        }

        public void RemoveAllLinkedListItems(LinkedList<Student> StudentList)
        {
            if (StudentList == null)
            {
                StudentList = new LinkedList<Student>();
            }

            LinkedListNode<Student> currentNode = StudentList.Last;

            while (currentNode != null)
            {
                StudentList.RemoveLast();
                currentNode = StudentList.Last;
            }
        }
    }
}
