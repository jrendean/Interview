using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public static class LinkedList
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
        }

        public static void Print(Node head)
        {
            Node temp = head;

            while (temp != null)
            {
                Console.WriteLine("Int: " + temp.Int + " -- String: " + temp.String);
                temp = temp.Next;
            }
        }

        public static Node Reverse(Node head)
        {
            Node newhead = null;

            while (head != null)
            {
                Node temp = head;
                head = head.Next;

                temp.Next = newhead;

                newhead = temp;
            }

            return newhead;
        }

        //public static void Delete(ref Node node)
        //{
        //    node = node.Next;
        //}

        public static Node DeepClone(Node head)
        {
            Node newHead = new Node(head.Int, head.String);
            Node newPointer = newHead;

            Node pointer = head.Next;
            while (pointer != null)
            {
                newPointer.Next = new Node(pointer.Int, String.Copy(pointer.String));

                pointer = pointer.Next;
                newPointer = newPointer.Next;
            }

            return newHead;
        }
    }
}
