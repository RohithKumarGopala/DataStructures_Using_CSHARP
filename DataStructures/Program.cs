using DataStructures;
public class Program
{
    public static void Main(string[] args)
    {
        LinkedList linkedList = new LinkedList();

        linkedList.AddFirst(33);
        linkedList.AddFirst(22);
        linkedList.AddFirst(11);
        linkedList.AddFirst(99);

        linkedList.PrintList();
    }
}