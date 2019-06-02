using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPractice
{
    class Recursion
    {
        private static StringBuilder output = new StringBuilder();
        private static bool[] used;
        private static string input;

        public static void StartPermute(string input)
        {
            Recursion.input = input;
            used = new bool[input.Length];
            output = new StringBuilder();

            Permute();
        }
        private static void Permute()
        {
            if (output.Length == input.Length)
            {
                Console.WriteLine(output);
                return;
            }

            for (int i = 0; i < input.Length; i++)
            {
                if (used[i])
                    continue;
                
                output.Append(input[i]);
                used[i] = true;
                
                Permute();
                
                used[i] = false;
                output.Length--;
            }
        }

        public static void StartCombine(string input)
        {
            Recursion.input = input;
            used = new bool[input.Length];
            output = new StringBuilder();

            Combine(0);
        }
        private static void Combine(int start)
        {
            for (int i = start; i < input.Length; i++)
            {
                output.Append(input[i]);
                Console.WriteLine(output);
                if (i < input.Length)
                    Combine(i+1);
                output.Length--;
            }
        }

        private static int[] number;
        private static char[] results;
        private static char[,] letters = { 
                { '0', '0', '0' },
                { '1', '1', '1' },
                { 'A', 'B', 'C' }, 
                { 'D', 'E', 'F' },
                { 'G', 'H', 'I' },
                { 'J', 'K', 'L' },
                { 'M', 'N', 'O' }, 
                { 'P', 'R', 'S' }, 
                { 'T', 'U', 'V' },
                { 'W', 'X', 'Y' } };

        public static void StartTelephoneNumberToWords(int[] number)
        {
            Recursion.number = number;
            results = new char[number.Length];
            TelephoneNumberToWords(0);
        }
        private static void TelephoneNumberToWords(int currentDigit)
        {
            if (currentDigit == number.Length)
            {
                Console.WriteLine(new string(results));
                return;
            }

            for (int i = 0; i < 3; i++)
            {
                results[currentDigit] = letters[number[currentDigit], i];

                TelephoneNumberToWords(currentDigit + 1);

                if (number[currentDigit] == 0 || number[currentDigit] == 1)
                    return;
            }
        }


        private static int[] coinDenominations = { 25, 10, 5, 1 };

        public static void StartGetChange(double amount)
        {
            int[] results = GetChange(amount);

            for (int i = 0; i < coinDenominations.Length; i++)
            {
                Console.WriteLine("Coin: " + coinDenominations[i] + ", Count: " + results[i]);
            }
        }
        private static int[] GetChange(double amount)
        {
            int[] numberOfEachCoin = new int[coinDenominations.Length];
            int totalAmountInCents = (int)(amount * 100);
            
            for (int i = 0; i < coinDenominations.Length; i++)
            {
                numberOfEachCoin[i] = totalAmountInCents / coinDenominations[i];
                totalAmountInCents = totalAmountInCents % coinDenominations[i];
            }

            return numberOfEachCoin;
        }

        //public static void StartGetChangeCombinations(double amount)
        //{
        //    int amountInCents = (int)(amount * 100);
        //    Console.WriteLine("Number of ways to make change for " + amount + " is " + GetChangeCombinations(amountInCents, coinDenominations.Length - 1));
        //}
        //private static int GetChangeCombinations(int amount, int coinLocation)
        //{
        //    if (amount == 0) return 1;
        //    if (amount < 0) return 0;
        //    if (coinLocation < 0 && amount >= 1) return 0;

        //    return 
        //        GetChangeCombinations(amount, coinLocation - 1) + 
        //        GetChangeCombinations(amount - coinDenominations[coinLocation], coinLocation);
        //}
        public static void StartGetChangeCombinations(double amount)
        {
            int amountInCents = (int)(amount * 100);
            Console.WriteLine("Number of ways to make change for " + amount + " is " + GetChangeCombinations(amountInCents, 0));
        }
        private static int GetChangeCombinations(int amount, int coinLocation)
        {
            if (amount == 0) return 1;
            if (amount < 0) return 0;
            if (coinLocation >= coinDenominations.Length && amount >= 1) return 0;

            return
                GetChangeCombinations(amount, coinLocation + 1) +
                GetChangeCombinations(amount - coinDenominations[coinLocation], coinLocation);
        }

        public static void StartGetOptimumChange(double amount)
        {

        }
        private static void GetOptimumChange()
        {
            int[] numberOfEachCoin = new int[coinDenominations.Length];

        }
    }
}
