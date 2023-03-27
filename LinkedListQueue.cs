using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace QueueUsingLinkedList
{
        class LinkedListQueue
        {
        Node head = null;

            internal void Enqueue(int data)
            {
                Node node = new Node(data);
                if (head == null)
                    head = node;
                else
                {
                    Node temp = head;
                    while (temp.next != null)
                    {
                        temp = (Node)temp.next;
                    }
                    temp.next = node;
                    node.next = head;

                }
                Console.WriteLine($"{node.data} inserted into queue ");

            }

            internal void Display()
            {
                Node temp = this.head;
                if (temp == null)
                {
                    Console.WriteLine("Queue is empty");
                    return;

                }
                while (temp != null)
                {
                    Console.Write(temp.data + " ");
                    temp = (Node)temp.next;
                }
            }

        }

    internal class Node
    {
        internal object next;
        private int data;

        public Node(int data)
        {
            this.data = data;
        }
    }
}
