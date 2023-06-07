using DataStructures;
public class Program
{
    public static void Main(string[] args)
    {
        LinkedList linkedList = new LinkedList();

        linkedList.AddLast(33);
        linkedList.AddLast(22);
        linkedList.AddLast(11);
        linkedList.AddLast(99);

        linkedList.PrintList();
    }
}