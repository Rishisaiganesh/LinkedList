using System;

namespace DataStruchers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LinkedList!");
            Linked list = new Linked();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.Display();
        }
    }
}
