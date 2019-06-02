using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPractice
{
    class LLStack
    {
        private LLNode head;

        public void Push(int data)
        {
            var newNode = new LLNode() { Data = data, Next = this.head };
            this.head = newNode;
        }

        public int Pop()
        {
            if (this.head == null)
                throw new Exception();

            var popNode = this.head;
            this.head = this.head.Next;
            return popNode.Data;
        }
    }


    class LLQueue
    {
        private LLNode head;

        public void Enqueue(int data)
        {
            var newNode = new LLNode() { Data = data };

            if (this.head == null)
                this.head = newNode;
            else
            {
                var iter = this.head;
                while (iter.Next != null)
                {
                    iter = iter.Next;
                }

                iter.Next = newNode;
            }
        }

        public int Dequeue()
        {
            if (this.head == null)
                throw new Exception();

            var popNode = this.head;
            this.head = this.head.Next;
            return popNode.Data;
        }
    }
}
