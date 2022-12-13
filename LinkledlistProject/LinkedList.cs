using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkledlistProject
{
    public class LinkedList
    {
        Node head;
        public void Addnote(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into linked list",node.data);
        }
        public void Display()
        {
            if (head == null)
            {
                Console.WriteLine("List is Empty");
            }
            else
            {
                Console.WriteLine("list contains");
                Node tempnode = head;
                    while (tempnode != null)
                    {
                        Console.WriteLine(tempnode.data + " ");
                        tempnode = tempnode.next;
                    }
                    Console.WriteLine("\n");
                
            }
        }
        public void Addreverse(int data)
        {
            Node node = new Node(data);
            if(head==null)
            {
                head = node;
            }
            else
            {
                Node temp = head;
                head = node;
                head.next= temp;
            }
        }
   
    }
}


    