using System;
using System.Collections;

namespace InterviewQuestion
{
	class Program
	{
		static void Main(string[] args)
		{
			BT bt = new BT();
			bt.Root = new BT.Node();
			bt.Root.Left = new BT.Node();
			bt.Root.Right = new BT.Node();
			bt.Root.Left.Left = new BT.Node();
			bt.Root.Left.Right = new BT.Node();
			bt.Root.Right.Left = new BT.Node();
			bt.Root.Right.Right = new BT.Node();

			Console.WriteLine("Binary Tree");
			Console.WriteLine("-----------");
			Console.WriteLine("IsFull: " + BT.IsFull(bt.Root));
			Console.WriteLine("Height: " + BT.Height(bt.Root));

			Console.WriteLine();
			Console.WriteLine();
			
			Console.WriteLine("Stack Parser");
			Console.WriteLine("------------");
			Console.WriteLine("ParseString('TH-I-SIS--ATE-ST---'): " + StackParser.ParseString("TH-I-SIS--ATE-ST---"));
			Console.WriteLine("ParseStringWithoutLibraries('TH-I-SIS--ATE-ST---'): " + StackParser.ParseStringWithoutLibraries("TH-I-SIS--ATE-ST---"));

			Console.ReadKey();
		}
	}


	public class StackParser
	{
		public static string ParseString(string stringToParse)
		{
			Stack s = new Stack();
			string output = null;

			foreach (char c in stringToParse.ToCharArray())
				if (c == '-')
					s.Pop();
				else
					s.Push(c);
			
			while (s.Count > 0)
				output += s.Pop();

			return output;
		}

		public static string ParseStringWithoutLibraries(string stringToParse)
		{
			string outputString = null;
			char[] output = new char[stringToParse.Length];
			int count = stringToParse.Length;

			for (int i = 0; i < stringToParse.Length; i++)
				if (stringToParse[i] == '-')
				{
					output[count] = ' ';
					count++;
				}
				else
				{
					count--;
					output[count] = stringToParse[i];
				}

			for (int i = count; i < stringToParse.Length; i++)
				outputString += output[i];
			
			return outputString;
		}
	}


	public class BT
	{
		public class Node
		{
			public Node Left;
			public Node Right;
		}
		
		public Node Root;

		public static bool IsFull(BT.Node node)
		{
			if (node == null)
				return false;

			if (node.Left != null && node.Right != null)
				return IsFull(node.Left) && IsFull(node.Right);
			else if (node.Left == null && node.Right == null)
				return true;
			else
				return false;
		}

		public static int Height(BT.Node node)
		{
			if (node == null)
				return 0;

			return 1 + Math.Max(Height(node.Left), Height(node.Right));
		}
	}
}
