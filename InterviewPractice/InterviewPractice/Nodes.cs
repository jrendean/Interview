using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPractice
{
    class LLNode
    {
        public LLNode Next;
        public int Data;

        public override string ToString()
        {
            return Data.ToString();
        }
    }

    class DLLNode
    {
        public DLLNode Prev;
        public DLLNode Next;
        public int Data;

        public override string ToString()
        {
            return Data.ToString();
        }
    }

    class TNode
    {
        public TNode Left;
        public TNode Right;
        public int Data;

        public override string ToString()
        {
            return Data.ToString();
        }
    }
}
