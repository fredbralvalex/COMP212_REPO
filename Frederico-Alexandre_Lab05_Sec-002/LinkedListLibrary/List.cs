using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListLibrary
{
    public class List
    {
        private ListNode firstNode;
        private ListNode lastNode;
        private string name; // string like "list" to display

        // construct empty List with specified name
        public List(string listName)
        {
            name = listName;
            firstNode = lastNode = null;
        }

        // construct empty List with "list" as its name 
        public List() : this("list") { }

        // Insert double at front of List. If List is empty, 
        // firstNode and lastNode will refer to same double.
        // Otherwise, firstNode refers to new node.
        public void InsertAtFront(double insertItem)
        {
            if (IsEmpty())
            {
                firstNode = lastNode = new ListNode(insertItem);
            }
            else
            {
                firstNode = new ListNode(insertItem, firstNode);
            }
        }

        // Insert double at end of List. If List is empty, 
        // firstNode and lastNode will refer to same double.
        // Otherwise, lastNode's Next property refers to new node.
        public void InsertAtBack(double insertItem)
        {
            if (IsEmpty())
            {
                firstNode = lastNode = new ListNode(insertItem);
            }
            else
            {
                lastNode = lastNode.Next = new ListNode(insertItem);
            }
        }

        // remove first node from List
        public double RemoveFromFront()
        {
            if (IsEmpty())
            {
                throw new EmptyListException(name);
            }

            double removeItem = firstNode.Data; // retrieve data

            // reset firstNode and lastNode references
            if (firstNode == lastNode)
            {
                firstNode = lastNode = null;
            }
            else
            {
                firstNode = firstNode.Next;
            }

            return removeItem; // return removed data
        }

        // remove last node from List
        public double RemoveFromBack()
        {
            if (IsEmpty())
            {
                throw new EmptyListException(name);
            }

            double removeItem = lastNode.Data; // retrieve data

            // reset firstNode and lastNode references
            if (firstNode == lastNode)
            {
                firstNode = lastNode = null;
            }
            else
            {
                ListNode current = firstNode;

                // loop while current.Next is not lastNode
                while (current.Next != lastNode)
                {
                    current = current.Next; // move to next node
                }

                // current is new lastNode
                lastNode = current;
                current.Next = null;
            }

            return removeItem; // return removed data
        }

        // return true if List is empty
        public bool IsEmpty()
        {
            return firstNode == null;
        }

        // output List contents
        public void Display()
        {
            if (IsEmpty())
            {
                Console.WriteLine($"Empty {name}");
            }
            else
            {
                Console.Write($"The {name} is: ");

                ListNode current = firstNode;

                // output current node data while not at end of list
                while (current != null)
                {
                    Console.Write($"{MyToString.ToString(current.Data)} ");
                    current = current.Next;
                }

                Console.WriteLine("\n");
            }
        }

        public double First()
        {
            return firstNode.Data;
        }

        public int Search(double value)
        {
            ListNode current = firstNode;

            int count = 0;
            while (current != null)
            {
                count++;
                if (current.Data == value)
                {
                    return count;
                }
                current = current.Next;
            }
            return -1;
        }

        public int Count()
        {
            ListNode current = firstNode;

            int count = 0;
            while (current != null)
            {
                count++;
                current = current.Next;
            }
            return count;
        }

        public double Sum()
        {
            ListNode current = firstNode;

            double sum = 0;
            while (current != null)
            {
                sum+=current.Data;
                current = current.Next;
            }
            return sum;
        }
    }
}

