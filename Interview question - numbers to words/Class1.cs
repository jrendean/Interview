using System;

namespace ConsoleApplication1
{
	/// <summary>
	/// Summary description for Class1.
	/// </summary>
	class Class1
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
			Test test = new Test();

			Console.WriteLine("346374684568 = " + test.GetWords(346374684568));
			Console.WriteLine();
			Console.WriteLine("964970836 = " + test.GetWords(964970836));
			Console.WriteLine();
			Console.WriteLine("6975066 = " + test.GetWords(6975066));
			Console.WriteLine();
			Console.WriteLine("7694 = " + test.GetWords(7694));
			Console.WriteLine();
			Console.WriteLine("967 = " + test.GetWords(967));
			Console.WriteLine();
			Console.WriteLine("34 = " + test.GetWords(34));
			Console.WriteLine();
			Console.WriteLine("2 = " + test.GetWords(2));
			Console.WriteLine();

			Console.WriteLine("Press enter to end");
			Console.ReadLine();
		}
	}

	public class Test
	{
		public string GetWords(long number)
		{
			string temp = String.Empty;

			long billions = number / 1000000000;
			if (billions != 0)
			{
				temp += GetHundreds(billions) + "billion ";
				number %= 1000000000;
			}

			long millions = number / 1000000;
			if (millions != 0)
			{
				temp += GetHundreds(millions) + "million ";
				number %= 1000000;
			}

			long thousands = number / 1000;
			if (thousands != 0)
			{
				temp += GetHundreds(thousands) + "thousand ";
				number %= 1000;
			}
			
			temp += GetHundreds(number);

			return temp;
		}


		private string GetHundreds(long number)
		{
			string temp = String.Empty;
			
			if (number % 100 != number)
			{
				temp += GetOnes(number / 100) + "hundred ";
				number %= 100;
			}

			if (number % 10 != number)
			{
				string tens = GetTens(number / 10);
				if (tens == "teens")
					return GetTeens(number);
				else
					temp += tens + GetOnes(number % 10);
			}
			else
				temp += GetOnes(number % 10);

			return temp;
		}

		private string GetTens(long number)
		{
			switch (number)
			{
				case 1: 
					return "teen";
				case 2:
					return "twenty " + GetOnes(number / 10);
				case 3:
					return "thirty " + GetOnes(number / 10);
				case 4:
					return "fourty " + GetOnes(number / 10);
				case 5:
					return "fifty " + GetOnes(number / 10);
				case 6:
					return "sixty " + GetOnes(number / 10);
				case 7:
					return "seventy " + GetOnes(number / 10);
				case 8:
					return "eighty " + GetOnes(number / 10);
				case 9:
					return "ninety " + GetOnes(number / 10);
				default:
					return String.Empty;
			}
		}

		private string GetTeens(long number)
		{
			switch (number)
			{
				case 10: 
					return "ten ";
				case 11: 
					return "eleven ";
				case 12:
					return "twelve ";
				case 13:
					return "thirteen ";
				case 14:
					return "fourteen ";
				case 15:
					return "fifteen ";
				case 16:
					return "sixteen ";
				case 17:
					return "seventeen ";
				case 18:
					return "eighteen ";
				case 19:
					return "nineteen ";
				default:
					return String.Empty;
			}
		}


		private string GetOnes(long number)
		{
			switch (number)
			{
				case 1:
					return "one ";
				case 2:
					return "two ";
				case 3:
					return "three ";
				case 4:
					return "four ";
				case 5:
					return "five ";
				case 6:
					return "six ";
				case 7:
					return "seven ";
				case 8:
					return "eight ";
				case 9:
					return "nine ";
				default:
					return String.Empty;
			}
		}
	}
}
