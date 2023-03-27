using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    internal class LinkedListss
    {
        public static void BuiltinLinkedlist()
        {
            LinkedList<int> list = new LinkedList<int>();
            list.AddFirst(50);
            list.AddLast(100);

            LinkedListNode<int> node = list.First;

            list.AddAfter(node, 200);
            list.AddBefore(node, 500);

            list.Remove(50); // Like this we have the same

        //    list.RemoveFirst();
          //  list.RemoveLast();

            foreach(var values in list)
            {
                Console.WriteLine(values);
            }
        }

        public static void BuiltinStack()
        {
            Stack<int> stack=new Stack<int>();

            stack.Push(50);
            stack.Push(100);
            stack.Push(500);

            stack.Peek();

            stack.Pop();

            foreach (var values in stack) { Console.WriteLine(values); }
        }

        public static void BuiltinQueue() 
        {
            Queue<int> queue = new Queue<int>();

            queue.Enqueue(50);
            queue.Enqueue(100);
            queue.Enqueue(500);

            queue.Dequeue();

            foreach(var values in queue) { Console.WriteLine(values); }
        }

        public static void BuiltinSortedList()
        {
            SortedList<int,int> sorted = new SortedList<int,int>();

            sorted.Add(1, 50);
            sorted.Add(2,100);
            sorted.Add(3,500);

            for(int i=sorted.Count-1;i>=0;i--)
            {
                int key = sorted.Keys[i];
                int value = sorted[key];

                Console.WriteLine($"{key} {value}");
            }
        }
    }
}
