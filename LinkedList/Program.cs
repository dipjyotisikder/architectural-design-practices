using System;
using static LinkedList.Practice;

namespace LinkedList
{

    class Implementation
    {
        static void Main(string[] args)
        {
            DJLinkedList linkedList = new DJLinkedList();
            linkedList.InsertData(1);
            linkedList.InsertData(2);
            linkedList.InsertData(3);
            linkedList.InsertData(4);
            linkedList.InsertData(5);


            linkedList.PrintData();

            //LinkedList MyList = new LinkedList();

            //MyList.push_back(10);
            //MyList.push_back(20);
            //MyList.push_back(30);

            //MyList.PrintList();
        }
    }


    //node structure
    class Node
    {
        public int data;
        public Node next;
    };

    class LinkedList
    {
        Node head;

        public LinkedList()
        {
            head = null;
        }

        //Add new element at the end of the list
        public void push_back(int newElement)
        {
            Node newNode = new Node();
            newNode.data = newElement;
            newNode.next = null;
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node temp = new Node();
                temp = head;
                while (temp.next != null)
                    temp = temp.next;
                temp.next = newNode;
            }
        }

        //display the content of the list
        public void PrintList()
        {
            Node temp = new Node();
            temp = this.head;
            if (temp != null)
            {
                Console.Write("The list contains: ");
                while (temp != null)
                {
                    Console.Write(temp.data + " ");
                    temp = temp.next;
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("The list is empty.");
            }
        }
    };

    // test the code

}
