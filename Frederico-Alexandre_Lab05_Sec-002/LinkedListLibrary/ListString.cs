using System;

namespace LinkedListLibrary
{
    public class ListString
    {
        private ListNodeString firstNode;
        private ListNodeString lastNode;
        private string name;

        public ListString(string listName)
        {
            name = listName;
            firstNode = lastNode = null;
        }

        public ListString() : this("list of string") { }

        public void InsertAtFront(string insertItem)
        {
            if (IsEmpty())
            {
                firstNode = lastNode = new ListNodeString(insertItem);
            }
            else
            {
                firstNode = new ListNodeString(insertItem, firstNode);
            }
        }

        public void InsertAtBack(string insertItem)
        {
            if (IsEmpty())
            {
                firstNode = lastNode = new ListNodeString(insertItem);
            }
            else
            {
                lastNode = lastNode.Next = new ListNodeString(insertItem);
            }
        }

        public string RemoveFromFront()
        {
            if (IsEmpty())
            {
                throw new EmptyListException(name);
            }

            string removeItem = firstNode.Data;

            if (firstNode == lastNode)
            {
                firstNode = lastNode = null;
            }
            else
            {
                firstNode = firstNode.Next;
            }

            return removeItem;
        }

        public string RemoveFromBack()
        {
            if (IsEmpty())
            {
                throw new EmptyListException(name);
            }

            string removeItem = lastNode.Data;

            if (firstNode == lastNode)
            {
                firstNode = lastNode = null;
            }
            else
            {
                ListNodeString current = firstNode;

                while (current.Next != lastNode)
                {
                    current = current.Next;
                }

                lastNode = current;
                current.Next = null;
            }

            return removeItem; 
        }

        public bool IsEmpty()
        {
            return firstNode == null;
        }

        public void Display()
        {
            if (IsEmpty())
            {
                Console.WriteLine($"Empty {name}");
            }
            else
            {
                Console.Write($"The {name} is: ");

                ListNodeString current = firstNode;

                while (current != null)
                {
                    Console.Write($"{current.Data} ");
                    current = current.Next;
                }

                Console.WriteLine("\n");
            }
        }
    }
}

