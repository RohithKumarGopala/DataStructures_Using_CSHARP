using System.Text;

namespace DataStructures
{

    public class Node
    {
         public int Data;
         public Node Next;

            public Node(int data)
            {
                Data = data;
                Next = null;
            }
        }

        class LinkedList
        {
            private Node head;

            public LinkedList()
            {
                head = null;
            }

            public void Insert(int data)
            {
                Node newNode = new Node(data);

                if (head == null)
                {
                    head = newNode;
                }
                else
                {
                    Node current = head;

                    while (current.Next != null)
                    {
                        current = current.Next;
                    }

                    current.Next = newNode;
                }

                Console.WriteLine("Inserted: " + data);
            }

            public void DeleteFirst()
            {
                if (head == null)
                {
                    Console.WriteLine("Linked list is empty. Nothing to delete.");
                    return;
                }

                Console.WriteLine("Deleted: " + head.Data);
                head = head.Next;
            }

            public void Display()
            {
                Node current = head;

                if (current == null)
                {
                    Console.WriteLine("Linked list is empty.");
                    return;
                }

                Console.Write("Linked List: ");

                while (current != null)
                {
                    Console.Write(current.Data + "->");
                    current = current.Next;
                }

                Console.WriteLine("End");
            }
        }
    }


