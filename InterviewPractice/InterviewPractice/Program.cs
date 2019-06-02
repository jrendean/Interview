using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //LLStackAndQueueTest();


            Recursion.StartPermute("abcd");
            Console.WriteLine();
            Console.WriteLine();

            Recursion.StartCombine("abcd");
            Console.WriteLine();
            Console.WriteLine();

            Recursion.StartTelephoneNumberToWords(new[] { 4, 9, 7, 1, 9, 2, 7 });
            Console.WriteLine();
            Console.WriteLine();

            Recursion.StartGetChange(3.46);
            Console.WriteLine();
            Console.WriteLine();
            Recursion.StartGetChangeCombinations(0.25);
            Console.WriteLine();
            Console.WriteLine();

            var root = CreateLinkedList();
            PrintList(root);
            Console.ReadKey();

            //var mth = FindMthFromEnd(root, 5);
            //Console.WriteLine(mth.Data);
            //Console.WriteLine();

            //var shouldNotCycle = HasCycle(root);
            //Console.WriteLine(shouldNotCycle);
            //Console.WriteLine();
            //var cycleList = CreateLinkedList(true);
            //var shouldCycle = HasCycle(cycleList);
            //Console.WriteLine(shouldCycle);
            //Console.WriteLine();

            //Console.WriteLine();


            //RemoveNodeByData(ref root, 1);

            PrintList(root);

            Console.ReadKey();
        }



        


        private static void RemoveNodeByData(ref LLNode root, int data)
        {
            if (root == null)
                return;

            if (root.Data == data)
            {
                root = root.Next;
                return;
            }

            var iter = root;
            while (iter != null)
            {
                if (iter.Next.Data == data)
                {
                    iter.Next = iter.Next.Next;
                    return;
                }

                iter = iter.Next;
            }
        }


        static void PrintList(LLNode head)
        {
            while (head != null)
            {
                Console.WriteLine(head.Data);

                head = head.Next;
            }

            Console.WriteLine();
        }

        static LLNode CreateLinkedList()
        {
            return CreateLinkedList(false);
        }
        static LLNode CreateLinkedList(bool cycle)
        {
            var startOfList = new LLNode
            {
                Data = 1
            };

            var restOfList = new LLNode
                {
                    Data = 2,
                    Next = new LLNode
                    {
                        Data = 3,
                        Next = new LLNode
                        {
                            Data = 4,
                            Next = new LLNode
                            {
                                Data = 5,
                                Next = cycle ? startOfList : null,
                            }
                        }
                    }
                };

            startOfList.Next = restOfList;

            return startOfList;
        }

        static DLLNode CreateDLinkedList()
        {
            return new DLLNode
            {
                Data = 1,
                Prev = null,
                Next = new DLLNode
                {
                    Data = 2,
                    Next = new DLLNode
                    {
                        Data = 3,
                        Next = new DLLNode
                        {
                            Data = 4,
                            Next = new DLLNode
                            {
                                Data = 5,
                                Next = null,
                            }
                        }
                    }
                }
            };
        }


        static void LLStackAndQueueTest()
        {
            var stack = new LLStack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            //throws
            //Console.WriteLine(stack.Pop());

            Console.WriteLine();

            var queue = new LLQueue();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);

            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            //throws
            //Console.WriteLine(queue.Dequeue());
        }

        static bool HasCycle(LLNode head)
        {
            if (head == null || head.Next == null)
                return false;

            var slowIter = head;
            var fastIter = head.Next;

            while (true)
            {
                if (fastIter == null || fastIter.Next == null)
                    return false;
                
                if (slowIter == fastIter || slowIter == fastIter.Next)
                    return true;
                
                slowIter = slowIter.Next;
                fastIter = fastIter.Next.Next;
            }
        }

        static LLNode FindMthFromEnd(LLNode head, int m)
        {
            if (head == null)
                throw new Exception();

            int counter = 1;
            var iter = head;
            var miter = head;

            while (iter.Next != null)
            {
                iter = iter.Next;

                if (counter >= m)
                {
                    miter = miter.Next;
                }

                counter++;
            }

            if (++counter < m)
                throw new Exception();

            return miter;
        }
    }
}
