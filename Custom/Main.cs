using System;

namespace InterviewQuestions
{
	/// <summary>
	/// Summary description for Class1.
	/// </summary>
	class MainClass
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
			InterviewQuestions im = new InterviewQuestions();
			
			// Fibonacci
			Console.WriteLine("Fibonacci(10)");
			Console.WriteLine("-------------");
			im.Fibonacci(10);
			Console.WriteLine();

			// ItoA
			Console.WriteLine("ItoA");
			Console.WriteLine("----");
			Console.WriteLine(im.ItoA(664));
			Console.WriteLine();

			// IsPalindrome
			Console.WriteLine("IsPalindrome(\"kayak\")");
			Console.WriteLine("---------------------");
			Console.WriteLine(im.IsPalindrome("kayak"));
			Console.WriteLine();

			// LastIndexOf
			Console.WriteLine("LastIndexOf(\"abcdba\", \"b\")");
			Console.WriteLine("--------------------------");
			Console.WriteLine(im.LastIndexOf("abcdba", "b"));
			Console.WriteLine();

			// IsPalindrome
			Console.WriteLine("ReverseSentence(\"The brown dog jumped over the log\")");
			Console.WriteLine("---------------------");
			Console.WriteLine(im.ReverseSentence("The brown dog jumped over the log"));
			Console.WriteLine();

			Console.WriteLine("FindInnerText");
			Console.WriteLine("---------------------");
			Console.WriteLine(im.FindInnerText());
			Console.WriteLine();

//			// QuickSort
//			int size = 50;
//			Random r = new Random(236);
//			Array array = Array.CreateInstance(typeof(int),size);
//			
//			Console.WriteLine("QuickSort - " + size);
//			Console.WriteLine("---------------------");
//						
//			Console.WriteLine("Unsorted");
//			Console.WriteLine("--------");
//			for (int i=0;i<size;i++)
//			{
//				array.SetValue(r.Next(100), i);
//				Console.Write(array.GetValue(i).ToString() + ", ");
//			}
//
//			im.QuickSort(ref array, 0, size-1);
//			
//			Console.WriteLine();
//			Console.WriteLine("Sorted");
//			Console.WriteLine("------");
//			for (int i=0;i<size;i++)
//			{
//				Console.Write(array.GetValue(i).ToString() + ", ");
//			}




			Console.ReadLine();
		}
	}
}
