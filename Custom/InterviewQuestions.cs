using System;

namespace InterviewQuestions
{
	/// <summary>
	/// Summary description for InterviewQuestions.
	/// </summary>
	public class InterviewQuestions
	{
		public InterviewQuestions()
		{}


		/// <summary>
		/// Fibonacci
		/// </summary>
		/// <param name="iterations">The number of times to loop calculating fibonacci</param>
		public void Fibonacci(int iterations)
		{
			int previous = -1;
			int result = 1;

			for (int i=1;i<=iterations;i++)
			{
				int sum = previous + result;
				Console.WriteLine(sum.ToString());
				previous = result;
				result = sum;
			}
		}

		/// <summary>
		/// Integer to Ascii
		/// </summary>
		/// <param name="intToConvert">The interger to convert to a string</param>
		/// <returns>String representation of the interger</returns>
		public string ItoA(int intToConvert)
		{
			string returnValue = String.Empty;
			byte asciiZero = 48;
			byte lsd;

			while (true)
			{
				if (intToConvert < 10)
				{
					returnValue = System.Text.Encoding.ASCII.GetString(new byte[] {(byte)(intToConvert + asciiZero)}) + returnValue;
					break;
				}

				lsd = (byte)(intToConvert % 10);

				returnValue = System.Text.Encoding.ASCII.GetString(new byte[] {(byte)(lsd + asciiZero)}) + returnValue;

				intToConvert /= 10;
			}

			return returnValue;
		}


		/// <summary>
		/// Is palindrome, same forward and back (simple fails for punctuation, case, spaces)
		/// </summary>
		/// <param name="str">The string to check</param>
		/// <returns>True/False</returns>
		public bool IsPalindrome(string str)
		{
			int len = str.Length-1;

			for (int i=0;i<=len;i++)
				if (str[i] != str[len-i])
					return false;

			return true;
		}


		/// <summary>
		/// Last index of
		/// </summary>
		/// <param name="text">The text to search</param>
		/// <param name="subString">The substring to find</param>
		/// <returns>The last location of the subString in the string</returns>
		public int LastIndexOf(string text, string subString)
		{
			if (text == null || subString == null || text.Length==0 || subString.Length==0)
				return -1;

			char[] charsToFind = subString.ToCharArray();
			char[] reverseText = text.ToCharArray();
			int foundChars = 0;

			for (int stringCounter=text.Length-1; stringCounter>=0; stringCounter--)
			{
				for (int subStringCounter=subString.Length-1; subStringCounter>=0; subStringCounter--)
				{
					if (reverseText[stringCounter] != charsToFind[subStringCounter])
					{
						stringCounter+=foundChars;
						foundChars=0;
						break;
					}
					else
					{
						stringCounter--;
						foundChars++;
					}

					if (foundChars == subString.Length)
					{
						return stringCounter + 1;
					}			
				}
			}

			return -1;
		}


		/// <summary>
		/// Reverse Sentence
		/// </summary>
		/// <param name="sentence">The sentence to reverse</param>
		/// <returns>The words in the sentence reverse</returns>
		public string ReverseSentence(string sentence)
		{
			System.Text.StringBuilder sb = new System.Text.StringBuilder();
			string[] words = sentence.Split(new char[] {' '});
			Array.Reverse(words);
	
			foreach (string word in words)
			{
				sb.Append(word);
				sb.Append(" ");
			}

			return sb.ToString();
		}

		public string FindInnerText()
		{
			System.Xml.XmlDocument xmlDocument = new System.Xml.XmlDocument();
			xmlDocument.LoadXml("<x><a>this></a><b id=\"1\">that</b><b id=\"3\">other</b></x>");

			return xmlDocument.SelectSingleNode("//x/b[@id=3]").InnerText;
		}

		public string[] StrTok(string stringToSplit, string token)
		{
			// TODO: this

			return new string[] {};
		}

		public void BinarySort(ref Array arrayToSort)
		{
			// TODO: this
		}

		public void QuickSort(ref Array arrayToSort, int first, int last)
		{
			// TODO: this
		}
	}
}
