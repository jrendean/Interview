using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    public static class Trees
    {
        public class TreeNode
        {
            public TreeNode(char value)
            {
                Value = value;
            }
            public char Value;
            public TreeNode Left;
            public TreeNode Right;
        }

        public static void TreeDFS(TreeNode start)
        {
            Stack<TreeNode> s = new Stack<TreeNode>();
            s.Push(start);

            while (s.Count > 0)
            {
                TreeNode t = s.Pop();
                Console.Write(t.Value);

                if (t.Right != null)
                    s.Push(t.Right);

                if (t.Left != null)
                    s.Push(t.Left);
            }
        }
        public static void TreeBFS(TreeNode start)
        {
            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(start);

            while (q.Count > 0)
            {
                TreeNode t = q.Dequeue();
                Console.Write(t.Value);

                if (t.Left != null)
                    q.Enqueue(t.Left);

                if (t.Right != null)
                    q.Enqueue(t.Right);
            }
        }
    }
}
