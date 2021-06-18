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
            
    }
}
