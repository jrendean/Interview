using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public static class HTMLParser
    {
        public class Node
        {
            string name;
            Node parent;

            public Node(string name, Node parent)
            {
                this.name = name;
                this.parent = parent;
            }

            public string Emit(bool open)
            {
                if (open == true)
                {
                    return "<" + name + ">";
                }
                else
                {
                    return "</" + name + ">";
                }
            }

            public Node Parent
            {
                get
                {
                    return parent;
                }
            }
        }
        
        public class Leaf
        {
            string content;
            Node parent;

            public Leaf(string content, Node parent)
            {
                this.content = content;
                this.parent = parent;
            }

            public string Emit()
            {
                return content;
            }


            public Node Parent
            {
                get
                {
                    return parent;
                }
            }
        }

        

        public static void BuildHTML(Leaf[] leaves)
        {
            Stack<Node> nodes = new Stack<Node>();
            StringBuilder sb = new StringBuilder();
            foreach (Leaf leaf in leaves)
            {
                Stack<Node> leafNodes = new Stack<Node>();
                StringBuilder leafBuilder = new StringBuilder(leaf.Emit());
                Node parent = leaf.Parent;
                while (parent != null)
                {
                    if (nodes.Contains(parent))
                    {
                        while (nodes.Peek() != parent)
                            sb.Append(nodes.Pop().Emit(false));
                        break;
                    }
                    else
                    {
                        leafBuilder.Insert(0, parent.Emit(true));
                        leafNodes.Push(parent);
                        parent = parent.Parent;
                    }
                }
                while (leafNodes.Count > 0)
                    nodes.Push(leafNodes.Pop());
                sb.Append(leafBuilder);
            }

            while (nodes.Count > 0)
                sb.Append(nodes.Pop().Emit(false));

            Console.WriteLine(sb.ToString());
        }


    }
}
