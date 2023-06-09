using DataStructures;
using System.Collections.Generic;

public class Program
{
    static void Main(string[] args)
    {
        Node<int> FirstNode = new Node<int>(70);
        Node<int> SecondNode = new Node<int>(40);
        Node<int> ThirdNode = new Node<int>(30);
        Node<int> FourthNode = new Node<int>(20);
        Node<int> FifthNode = new Node<int>(50);

        DataStructures.LinkedList<int> LinkedList = new DataStructures.LinkedList<int>();
        LinkedList.Display();
        LinkedList.AddLast(FirstNode);
        LinkedList.AddLast(SecondNode);
        LinkedList.AddLast(ThirdNode);
        LinkedList.AddLast(FifthNode);

        LinkedList.AddAfter(SecondNode, FourthNode);

        LinkedList.DeleteFirst();
        LinkedList.DeleteLast();

        LinkedList.DeleteAfter(SecondNode);

        LinkedList.Display();

    }
}



