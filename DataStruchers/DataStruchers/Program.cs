﻿using System;

namespace DataStruchers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LinkedList !");
            Linked list = new Linked();
            list.Add(56);
            list.Add(70);
            Console.WriteLine("Linked list Element Before Adding");
            list.Display();
            list.Adding(1, 30);
            Console.WriteLine("list After Adding");
            list.Display();
            list.Delite(2);
            Console.WriteLine("List after Deliting");
            list.Display();
            list.Search(30);
            Console.WriteLine("After searching");
            list.Display();
        }
    }
}
