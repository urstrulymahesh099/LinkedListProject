using System;

namespace LinkledlistProject
{
    public class Program 
    {
        public static void Main(string[] args)
        {
            {
                LinkedList list = new LinkedList();
                list.Addnote(10);
                list.Addnote(20);
                list.Addnote(30);
                list.Addreverse(10);
                list.Addreverse(20);
                list.Addreverse(30);
                list.Display();
            }
        }
    }
}