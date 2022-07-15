using System;

namespace LinkedList
{
    public class Practice
    {
        public class DJNode
        {
            public int Data;
            public DJNode nextNode;
        }


        public class DJLinkedList
        {
            DJNode head = null;


            public void InsertData(int data)
            {
                DJNode newNode = new DJNode();
                newNode.Data = data;
                newNode.nextNode = null;


                //DJNode newNode = new DJNode()
                //{
                //    Data = data,
                //    nextNode = null
                //};
                if (head == null)
                {
                    head = newNode;
                }

                if (head != null)
                {
                    DJNode tempNode = new DJNode();
                    tempNode = head;
                    while (tempNode.nextNode is not null)
                    {
                        tempNode = tempNode.nextNode;
                    }
                    tempNode.nextNode = newNode;
                }
            }



            public void PrintData()
            {

                var temp = head;

                while (temp.nextNode != null)
                {
                    Console.WriteLine(temp.nextNode.Data);
                }
            }

        }


    }
}
