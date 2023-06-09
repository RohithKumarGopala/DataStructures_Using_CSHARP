using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class Node<T>
    {
        public T Data { get; set; }
        public Node<T> Next { get; set; }

        public Node(T data)
        {
            this.Data = data;
        }
    }
    public class LinkedList<T>
    {
        private Node<T> head;


        public void AddFirst(Node<T> newNode)
        {
            if (head == null)
            {
                head = newNode;
                return;
            }

            Node<T> previous = head;
            head = newNode;
            newNode.Next = previous;
        }


        public void AddLast(Node<T> newNode)
        {
            if (head == null)
            {
                head = newNode;
                return;
            }
            Node<T> temp = head;

            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            temp.Next = newNode;
        }


        public void AddAfter(Node<T> data, Node<T> newNode)
        {
            Node<T> temp = data;
            while (temp.Next == null)
            {
                temp.Next = newNode;
                return;
            }
            newNode.Next = temp.Next;
            temp.Next = newNode;
        }


        public void DeleteFirst()
        {
            if (head == null)
                return;

            Node<T> temp = head.Next;
            head = temp;
        }


        public void DeleteLast()
        {
            Node<T> temp = head;
            while (temp.Next.Next != null)
            {
                temp = temp.Next;
            }

            temp.Next = null;
        }


        public void DeleteAfter(Node<T> node)
        {
            Node<T> tempNode = node.Next;
            node.Next = tempNode.Next;
        }
        public void Display()
        {
            Node<T> temp = head;
            while (temp != null)
            {
                Console.Write(temp.Data + "->");
                temp = temp.Next;
            }
            Console.WriteLine("END");
        }
    }
    public class Stack
    {
        LinkedList<int> linkedlist = new LinkedList<int>();
        public void push(Node<int> node)
        {
            linkedlist.AddFirst(node);
            Console.WriteLine("Linked list after push operation");
            linkedlist.Display();
        }

        public void pop()
        {
            linkedlist.DeleteFirst();
            Console.WriteLine("Linked list after pop operation");
            linkedlist.Display();
        }
    }
    public class Queue
    {
        LinkedList<int> myQueue = new LinkedList<int>();

        public void enqueue(Node<int> node)
        {
            myQueue.AddFirst(node);
            Console.WriteLine("My Queue after enqueue");
            myQueue.Display();
        }

        public void dequeue()
        {
            myQueue.DeleteLast();
            Console.WriteLine("My Queue after dequeue");
            myQueue.Display();
        }
    }
}




