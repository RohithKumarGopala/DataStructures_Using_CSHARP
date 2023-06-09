using DataStructures;
using System.Collections.Generic;

public class Program
{
    static void Main(string[] args)
    {
        DataStructures.LinkedList<int> list = new DataStructures.LinkedList<int>();
            Node<int> firstNode = new Node<int>(23);
            Node<int> secondNode = new Node<int>(34);
            Node<int> thirdNode = new Node<int>(29);
            Node<int> fourthNode = new Node<int>(15);
            Node<int> fifthNode = new Node<int>(42);

        list.AddLast(thirdNode);
        list.AddLast(fourthNode);
        list.AddLast(firstNode);
        list.AddLast(fifthNode);

        list.AddAfter(fourthNode, secondNode);

        list.DeleteFirst();
        list.DeleteLast();
        list.Display();
        }
    }


