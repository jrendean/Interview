using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Path 3x4");
            Console.WriteLine(Path(3, 4));
            Console.WriteLine();
            Console.WriteLine();



            Trees.TreeNode a = new Trees.TreeNode('A');
            Trees.TreeNode b = new Trees.TreeNode('B');
            Trees.TreeNode c = new Trees.TreeNode('C');
            Trees.TreeNode d = new Trees.TreeNode('D');
            Trees.TreeNode e = new Trees.TreeNode('E');
            Trees.TreeNode f = new Trees.TreeNode('F');
            a.Left = b;
            a.Right = e;
            b.Left = c;
            b.Right = d;
            e.Right = f;
            Console.WriteLine("    A    ");
            Console.WriteLine(" B     E ");
            Console.WriteLine("C D     F");
            Console.WriteLine();
            Console.Write("DFS: ");
            Trees.TreeDFS(a);
            Console.WriteLine();
            Console.Write("BFS: ");
            Trees.TreeBFS(a);
            Console.WriteLine();
            Console.WriteLine();




            Console.WriteLine("PrintBase FF in base 16");
            PrintBase(0xff, 16);
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("PrintBase FF in base 10");
            PrintBase(0xff, 10);
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("PrintBase FF in base 2");
            PrintBase(0xff, 2);
            Console.WriteLine();
            Console.WriteLine();



            //Console.WriteLine("Perm('ABC')");
            //Perm("ABC".ToCharArray());
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine("Perm('ABCD')");
            //Perm("ABCD".ToCharArray());
            //Console.WriteLine();
            //Console.WriteLine();




            // you are given an array of the leafs with each leaf being a single linked list to its
            // hierarchy of parents and all eventually point to <html>
            HTMLParser.Node html = new HTMLParser.Node("html", null);
            HTMLParser.Node p1 = new HTMLParser.Node("p", html);  // 1st paragraph node p1's parent is html
            HTMLParser.Node u1 = new HTMLParser.Node("u", p1);    // u1's parent is p1
            HTMLParser.Node p2 = new HTMLParser.Node("p", html);  // 2nd paragraphs node p2's parent is html
            HTMLParser.Node u2 = new HTMLParser.Node("u", p2);    // u2's parent is p2
            HTMLParser.Leaf foo = new HTMLParser.Leaf("foo", p1); // 1st content parent is p1
            HTMLParser.Leaf bar = new HTMLParser.Leaf("bar", u1); // 2nd content parent is u1 
            HTMLParser.Leaf baz = new HTMLParser.Leaf("baz", u2); // 3rd content parent is u2
            // <html><p>foo<u>bar</u></p><p><u>baz</u></p></html>
            HTMLParser.BuildHTML(new HTMLParser.Leaf[] { foo, bar, baz });
            Console.WriteLine();
            Console.WriteLine();




            int[] values = { -2, -5, 5, 2, -5, 10, -15, 5 };
            Console.WriteLine("Max sum - O(N^3)");
            int startN3 = 0;
            int endN3 = 0;
            int sumN3 = MaxSumN3(values, ref startN3, ref endN3);
            Console.WriteLine("Sum N^3 = {0}. Start = {1}, End = {2}", sumN3, startN3, endN3);
            Console.WriteLine();
            Console.WriteLine("Max sum - O(N^2)");
            int startN2 = 0;
            int endN2 = 0;
            int sumN2 = MaxSumN2(values, ref startN2, ref endN2);
            Console.WriteLine("Sum N^2 = {0}. Start = {1}, End = {2}", sumN2, startN2, endN2);
            Console.WriteLine();
            Console.WriteLine("Max sum - O(N)");
            int startN = 0;
            int endN = 0;
            int sumN = MaxSumN(values, ref startN, ref endN);
            Console.WriteLine("Sum N = {0}. Start = {1}, End = {2}", sumN, startN, endN);
            Console.WriteLine();
            Console.WriteLine();





            Console.WriteLine("Linked List");
            LinkedList.Node n1 = new LinkedList.Node(1, "1");
            n1.Next = new LinkedList.Node(2, "2");
            n1.Next.Next = new LinkedList.Node(3, "3");
            LinkedList.Print(n1);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Reverse Linked List");
            LinkedList.Print(LinkedList.Reverse(n1));
            Console.WriteLine();
            Console.WriteLine();

            //LLNode n2 = n1;
            //LLNode n3 = DeepClone(n1);
            //n1.Next.Int = -99;
            //n1.Next.String = "A";
            //Print(n2);
            //Print(n3);
            //Console.WriteLine();
            //Console.WriteLine();

            



            


            Console.WriteLine("Double Linked List");
            DoubleLinkedList.Node dn1 = new DoubleLinkedList.Node(1, "1");
            DoubleLinkedList.Node dn2 = new DoubleLinkedList.Node(2, "2");
            DoubleLinkedList.Node dn3 = new DoubleLinkedList.Node(3, "3");
            dn1.Next = dn2;
            dn2.Prev = dn1;
            dn2.Next = dn3;
            dn3.Prev = dn2;
            DoubleLinkedList.Print(dn1);
            Console.WriteLine();
            Console.WriteLine();
            
            //Console.WriteLine("DN1's Int = {0}, String = {1}", dn1.Next.Int, dn1.Next.String);
            //DLLNode dn1a = dn1;
            //DLLNode dn1b = DeepClone(dn1);

            //dn2.Int = -99;
            //dn2.String = "AA";
            //Console.WriteLine("After change - DN1a's Int = {0}, String = {1}", dn1a.Next.Int, dn1a.Next.String);
            //Console.WriteLine("After change - DN1b's Int = {0}, String = {1}", dn1b.Next.Int, dn1b.Next.String);
            //Console.WriteLine();

            //Delete(ref dn1.Next);
            Console.WriteLine("Reverse Double Linked List");
            DoubleLinkedList.Print(DoubleLinkedList.Reverse(dn1));
            Console.WriteLine();
            Console.WriteLine();







            //http://thedailywtf.com/Articles/Nerds,-Jocks,-and-Lockers.aspx
            const int doors = 100;
            int i = 1;
            while (i * i <= doors)
            {
                Console.Write(i*i + " ");
                i++;
            }
            Console.WriteLine();
            Console.WriteLine();

            for (int j = 1; j <= Math.Sqrt(doors); j++)
            {
                Console.Write(Math.Pow(j, 2) + " ");
            }
            Console.WriteLine();
            Console.WriteLine();




            int[] input = { 1, 2, 3, 4, 5 };
            int[] index = { 0, 1, 2, 2, 2 };
            int[] result = ProductOfArraysWithExclusion(input, index);
            




            Console.ReadKey();
        }

        private static int[] ProductOfArraysWithExclusion(int[] input, int[] exclusionIndex)
        {
            int[] result = { 1, 1, 1, 1, 1 };

            for (int i = 0; i < exclusionIndex.Length; i++)
            {
                for (int j = 0; j < input.Length; j++)
                    if (exclusionIndex[i] != j)
                        result[i] *= input[j];
            }

            return result;
        }


        private static int MaxSumN3(int[] values, ref int start, ref int end)
        {
            int max = 0;

            for (int i=0;i<values.Length;i++)
                for (int j = i; j < values.Length; j++)
                {
                    int sum = 0;
                    for (int k = i; k <= j; k++)
                        sum += values[k];

                    if (sum > max)
                    {
                        max = sum;
                        start = i;
                        end = j;
                    }
                }

            return max;
        }
        private static int MaxSumN2(int[] values, ref int start, ref int end)
        {
            int max = 0;

            for (int i = 0; i < values.Length; i++)
            {
                int sum = 0;
                for (int j = i; j < values.Length; j++)
                {
                    sum += values[j];

                    if (sum > max)
                    {
                        max = sum;
                        start = i;
                        end = j;
                    }
                }
            }

            return max;
        }
        private static int MaxSumN(int[] values, ref int start, ref int end)
        {
            int max = 0;
            int sum = 0;

            int i = 0;
            for (int j = 0; j < values.Length; j++)
            {
                sum += values[j];

                if (sum > max)
                {
                    max = sum;
                    start = i;
                    end = j;
                }
                else if (sum < 0)
                {
                    i = j + 1;
                    sum = 0;
                }
            }

            return max;
        }




        public static int Path(int x, int y)
        {
            if (x == 1 || y == 1)
                return 1;

            return Path(x - 1, y) + Path(x, y - 1);
        }

     
        

        public static void PrintBase(long number, byte @base)
        {
            char[] digits = "0123456789ABCDEF".ToCharArray();

            if (number > @base)
                PrintBase(number / @base, @base);

            Console.Write(digits[number % @base]);
        }



        public static void Perm(char[] phrase)
        {
            //1=1
            //2=2
            //3=6
            //4=24
            //n=m
            //n+1=n*m
            int permCount = 1;
            for (int c = 1; c <= phrase.Length; c++)
            {
                permCount *= c;
            }


            int multiple = 2;

            for (int count = 1; count < permCount; count+=2)
            {
                // swap last 2
                swap(phrase, phrase.Length - 1, phrase.Length - 2);
                Console.WriteLine(phrase);

                if (count / 2 == 0)
                    multiple++;

                // swap last one with increasing count towards 0
                swap(phrase, phrase.Length - 1, phrase.Length - multiple);
                Console.WriteLine(phrase);
            }
        }
        private static void swap(char[] phrase, int what, int with)
        {
            char temp = phrase[what];
            phrase[what] = phrase[with];
            phrase[with] = temp;
        }

    }
}
