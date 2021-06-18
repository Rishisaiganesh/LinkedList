using System;
using System.Collections.Generic;
using System.Text;

namespace DataStruchers
{
   public class Linked
    {
        Node head;
        public void Add(int data)
        {
            Node node = new Node();
            node.data = data;
            node.next = null;
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node node1 = head;
                while (node1.next != null)
                {
                    node1 = node1.next;
                }
                node1.next = node;
            }
        }
        public void Display()
        {
            Node node = head;
            while (node.next != null)
            {
                Console.WriteLine(node.data);
                node = node.next;
            }
            Console.WriteLine(node.data);
        }
        public void Insurt(int data)
        {
            Node node = new Node();
            node.data = data;
            node.next = null;
            node.next = head;
            head = node;
        }
        public void Adding(int index,int data)
        {
            Node node = new Node();
            node.data = data;
            node.next = null;
            Node node1 = head;
            for(int i = 0; i < index -1; i++)
            {
                node1 = node1.next;
            }
            node.next = node1.next;
            node1.next = node;

        }
        public void Pop()
        {
            head = head.next;
        }
        public void Delite(int index)
        {
            if(index == 0)
            {
                head = head.next;
            }
            else
            {
                Node node1 = head;
                for(int i = 0; i< index -1; i++)
                {
                    node1 = node1.next;
                }
                node1.next = node1.next.next;
            }
      
        }

        public int Search(int data)
        {
            Node node = new Node();
            Node node1 = head;
            int count = 0;
            while (node1 != null)
            {
                if (node1.data == data)
                {
                    Console.WriteLine("element is found" + data + "count is" + count);
                    return count;
                }
                count++;
                node1 = node1.next;

            }
            Console.WriteLine("element not found");
            return 0;
        }
    }
}
