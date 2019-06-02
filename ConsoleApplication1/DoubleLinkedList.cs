using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public static class DoubleLinkedList
    {
        public class Node
        {
            public Node(int i, string s)
            {
                Int = i;
                String = s;
            }

            public int Int;
            public string String;

            public Node Next;
            public Node Prev;
        }

        public static void Print(Node head)
        {
            Node temp = head;

            var a = new[] { "a", "b" };
            //Array.
            while (temp != null)
            {
                Console.WriteLine("Int: " + temp.Int + " -- String: " + temp.String);
                temp = temp.Next;
            }
        }

        public static Node Reverse(Node head)
        {
            Node newhead = head.Prev;

            while (head != null)
            {
                Node temp = head.Next;
                head.Next = head.Prev;
                head.Prev = temp;


                if (head.Prev == null)
                    newhead.Next = head;

                head = head.Prev;
            }

            return newhead;
        }

        //public static void Delete(ref Node node)
        //{
        //    node.Next.Prev = node.Prev;
        //    node.Prev.Next = node.Next;
        //}

        public static Node DeepClone(Node head)
        {
            Node newHead = new Node(head.Int, head.String);
            Node newPointer = newHead;

            Node pointer = head.Next;
            while (pointer != null)
            {
                Node tempPrev = newPointer;
                newPointer.Next = new Node(pointer.Int, String.Copy(pointer.String));

                pointer = pointer.Next;
                newPointer = newPointer.Next;

                newPointer.Prev = tempPrev;
            }

            return newHead;
        }
    }
}
