
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static int[,] boardStart = new int [9,9]
        {
            { 0,3,0, 0,0,0, 4,0,5},
            { 0,0,0, 0,0,0, 0,0,0},
{               0,0,7, 0,0,0, 0,1,0},
{               0,0,0, 7,9,0, 5,0,0},
{               0,0,6, 0,5,0, 8,0,0},
{               2,0,0, 0,4,0, 0,7,3},
{                0,0,0, 9,2,0, 0,0,7},
{                0,4,0, 3,0,0, 9,0,0},
{                0,0,0, 1,0,6, 0,0,0}
        };

                



        static int[,] boardFinish = new int[9, 9]
        {
            { 1,3,2,8,6,7,4,9,5 },
            { 9,6,4,5,1,2,7,3,8 },
            { 8,5,7,4,3,9,2,1,6 },
            { 4,8,1,7,9,3,5,6,2 },
            { 3,7,6,2,5,1,8,4,9 },
            { 2,9,5,6,4,8,1,7,3 },
            { 5,1,3,9,2,4,6,8,7 },
            { 6,4,8,3,7,5,9,2,1 },
            { 7,2,9,1,8,6,3,5,4 }
        };
            


        static void Main(string[] args)
        {
            //PrintBoard(boardStart);
            //if (VerifyBoard(boardStart))
            //    Console.WriteLine("Board is valid");
            //else
            //    Console.WriteLine("Board is NOT valid");


            Console.WriteLine();

            PrintBoard(boardFinish);
            if (VerifyBoardBruteForce(boardFinish))
                Console.WriteLine("Brute Force - Board is valid");
            else
                Console.WriteLine("Brute Force - Board is NOT valid");

            Console.WriteLine();


            if (VerifyBoardPredefinedArrays(boardFinish))
                Console.WriteLine("Predefined Arrays - Board is valid");
            else
                Console.WriteLine("Predefined Arrays - Board is NOT valid");


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("PrintBase FF in base 16");
            PrintBase(0xff, 16);
            Console.WriteLine();
            PrintBase(255, 16);
            Console.WriteLine();

            Console.WriteLine("PrintBase FF in base 10");
            PrintBase(0xff, 10);
            Console.WriteLine();
            PrintBase(255, 10);
            Console.WriteLine();

            Console.WriteLine("PrintBase FF in base 2");
            PrintBase(0xff, 2);
            Console.WriteLine();
            PrintBase(255, 2);
            Console.WriteLine();





            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("IsPalindrome(\"kaak\")");
            Console.WriteLine("---------------------");
            Console.WriteLine(IsPalindrome("kayak"));
            Console.WriteLine();

            Console.WriteLine("IsPalindrome(\"deed\")");
            Console.WriteLine("---------------------");
            Console.WriteLine(IsPalindrome("deed"));
            Console.WriteLine();
           
            Console.WriteLine("IsPalindrome(\"racecar\")");
            Console.WriteLine("---------------------");
            Console.WriteLine(IsPalindrome("racecar"));
            Console.WriteLine();

            Console.WriteLine("IsPalindrome(\"Dennis sinned\")");
            Console.WriteLine("---------------------");
            Console.WriteLine(IsPalindrome("Dennis sinned"));
            

            Console.ReadKey();
        }




        

        public static void PrintBase(long number, byte @base)
        {
            char[] digits = "0123456789ABCDEF".ToCharArray();

            if (number > @base)
                PrintBase(number / @base, @base);

            Console.Write(digits[number % @base]);
        }



        public static bool IsPalindrome(string str)
        {
            int len = str.Length - 1;

            for (int i = 0; i <= len; i++)
                if (Char.ToLower(str[i]) != Char.ToLower(str[len - i]))
                    return false;

            return true;
        }








        private static bool VerifyBoardPredefinedArrays(int[,] board)
        {
            int[,] rows = 
            {
                { board[0, 0], board[0, 1], board[0, 2], board[0, 3], board[0, 4], board[0, 5], board[0, 6], board[0, 7], board[0, 8] },
                { board[1, 0], board[1, 1], board[1, 2], board[1, 3], board[1, 4], board[1, 5], board[1, 6], board[1, 7], board[1, 8] },
                { board[2, 0], board[2, 1], board[2, 2], board[2, 3], board[2, 4], board[2, 5], board[2, 6], board[2, 7], board[2, 8] },
                { board[3, 0], board[3, 1], board[3, 2], board[3, 3], board[3, 4], board[3, 5], board[3, 6], board[3, 7], board[3, 8] },
                { board[4, 0], board[4, 1], board[4, 2], board[4, 3], board[4, 4], board[4, 5], board[4, 6], board[4, 7], board[4, 8] },
                { board[5, 0], board[5, 1], board[5, 2], board[5, 3], board[5, 4], board[5, 5], board[5, 6], board[5, 7], board[5, 8] },
                { board[6, 0], board[6, 1], board[6, 2], board[6, 3], board[6, 4], board[6, 5], board[6, 6], board[6, 7], board[6, 8] },
                { board[7, 0], board[7, 1], board[7, 2], board[7, 3], board[7, 4], board[7, 5], board[7, 6], board[7, 7], board[7, 8] },
                { board[8, 0], board[8, 1], board[8, 2], board[8, 3], board[8, 4], board[8, 5], board[8, 6], board[8, 7], board[8, 8] }
            };

            bool[] test;

            // rows
            for (int r = 0; r <= rows.GetUpperBound(0); r++)
            {
                test = new bool[9] { false, false, false, false, false, false, false, false, false };

                for (int c = 0; c <= rows.GetUpperBound(1); c++)
                {
                    //Console.Write(board[r, c].ToString());

                    if (board[r, c] == 0)
                        return false;

                    if (test[board[r, c] - 1])
                        return false;
                    else
                        test[board[r, c] - 1] = true;
                }

                //Console.WriteLine();
            }


            return true;
        }




        
private static bool VerifyBoardBruteForce(int[,] board)
{
    bool[] test;

    // vertical
    for (int r = 0; r <= board.GetUpperBound(0); r++)
    {
        test = new bool[9] { false, false, false, false, false, false, false, false, false };

        for (int c = 0; c <= board.GetUpperBound(1); c++)
        {
            //Console.Write(board[r, c].ToString());

            if (board[r, c] == 0)
                return false;

            if (test[board[r, c]-1])
                return false;
            else
                test[board[r, c]-1] = true;
        }

        //Console.WriteLine();
    }

            
    // horizontal
    for (int c = 0; c <= board.GetUpperBound(1); c++)
    {
        test = new bool[9] { false, false, false, false, false, false, false, false, false };
                
        for (int r = 0; r <= board.GetUpperBound(0); r++)
        {
            //Console.Write(board[r, c].ToString());

            if (board[r, c] == 0)
                return false;

            if (test[board[r, c] - 1])
                return false;
            else
                test[board[r, c] - 1] = true;
        }

        //Console.WriteLine();
    }


    // 3x3 grids
    for (int rStart = 0; rStart < board.GetUpperBound(0); rStart += 3)
    {
        for (int cStart = 0; cStart <  board.GetUpperBound(1); cStart += 3)
        {
            test = new bool[9] { false, false, false, false, false, false, false, false, false };

            for (int r = rStart; r < rStart + 3; r++)
            {
                for (int c = cStart; c < cStart + 3; c++)
                {
                    //Console.Write(board[r, c].ToString());

                    if (board[r, c] == 0)
                        return false;

                    if (test[board[r, c] - 1])
                        return false;
                    else
                        test[board[r, c] - 1] = true;
                }
            }

            //Console.WriteLine();
        }
    }

    return true;
}

        static void PrintBoard(int[,] board)
        {
            for (int r = 0; r <= board.GetUpperBound(0); r++)
            {
                for (int c = 0; c <= board.GetUpperBound(1); c++)
                {
                    Console.Write(board[r, c].ToString() + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
