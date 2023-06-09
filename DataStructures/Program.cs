using DataStructures;
using System.Collections.Generic;

public class Program
{
    static void Main(string[] args)
    {
        Node<int> FirstNode = new Node<int>(60);
        Node<int> SecondNode = new Node<int>(12);
        Node<int> ThirdNode = new Node<int>(22);
        Node<int> FourthNode = new Node<int>(33);
        Node<int> FifthNode = new Node<int>(44);

        DataStructures.LinkedList<int> LinkedList = new DataStructures.LinkedList<int>();
        LinkedList.AddLast(FirstNode);
        LinkedList.AddLast(SecondNode);
        LinkedList.AddLast(ThirdNode);
        LinkedList.AddLast(FifthNode);

        LinkedList.AddAfter(SecondNode, FourthNode);

        LinkedList.DeleteFirst();
        LinkedList.DeleteLast();

        LinkedList.DeleteAfter(SecondNode);

        LinkedList.Display();

        Stack stack = new Stack();
        stack.push(ThirdNode);
        stack.push(FourthNode);
        stack.push(FifthNode);

        stack.pop();

        Queue queue = new Queue();
        queue.enqueue(ThirdNode);
        queue.enqueue(SecondNode);
        queue.enqueue(FirstNode);

        queue.dequeue();

    }
}



