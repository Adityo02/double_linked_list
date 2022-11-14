using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace double_linked_list
{
    class Node
    {
        /* Node class repsents the node of doubly linked list
        * it consist of the information part and links to
        * its succeeding and preceeding
        * in terms of nextand previous */
        public int noMhs;
        public string name;
        //point to the succeding node
        public Node next;
        //point to the precceding node
        public Node prev;
    }

    class DoubleLinkedList
    {
        Node START;

        //Constructor
        public DoubleLinkedList()
        {
            START = null;
        }
        public void addNote()
        {
            int nim;
            string nim;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
