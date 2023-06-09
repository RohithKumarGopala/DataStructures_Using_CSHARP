using DataStructures;
using System.Collections.Generic;

public class Program
{
    static void Main(string[] args)
    {
        {
            LinkedList linkedList = new LinkedList();

            linkedList.Display();  

            linkedList.Insert(10);
            linkedList.Insert(20);
            linkedList.Insert(30);

            linkedList.Display();  

            linkedList.DeleteFirst();  

            linkedList.Display();  
        }
    }
}

