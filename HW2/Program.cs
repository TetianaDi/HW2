using static System.Net.Mime.MediaTypeNames;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System;

namespace HW2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //-- print the sum of two numbers
            //-- print the result of dividing two numbers

            int a = 15, b = 5;
            int c;

            Console.WriteLine($"a = 15, b = 5, c = ?");

            Console.WriteLine($"c = a + b = {c = a + b}");

            Console.WriteLine($"c = a / b = {c = a / b}");

            //--print the result of the specified operations

            Console.WriteLine("---------------------");

            Console.WriteLine($"-1 + 4 * 6 =  {-1 + 4 * 6}");
            Console.WriteLine($"(35 + 5) * 7 = {(35 + 5) * 7}");
            Console.WriteLine($"14 + -4 * 6 / 11 = {14 + -4 * 6 / 11}");
            Console.WriteLine($"2 + 15 / 6 * 1 - 7 % 2 = {2 + 15 / 6 * 1 - 7 % 2}");

            //--swap two numbers
            //        Test Data:
            //        Input the First Number : 5
            //        Input the Second Number : 6
            //        Expected Output:
            //        After Swapping :
            //        First Number : 6
            //        Second Number : 5

            Console.WriteLine("---------------------");

            Console.WriteLine($"Input the First Number");
            var FirstNum = Console.ReadLine();

            Console.WriteLine($"Input the Second Number");
            var SecondNum = Console.ReadLine();

            Console.WriteLine($"After Swapping First Number {FirstNum = SecondNum}");

            Console.WriteLine($"After Swapping Second Number {SecondNum = FirstNum}");

            // I have a question here ^^^


            // -- print the output of multiplication of three numbers which will be entered by the user 
            //Test Data:
            //        Input the first number to multiply: 2
            //        Input the second number to multiply: 3
            //        Input the third number to multiply: 6

            Console.WriteLine("---------------------");

            int MultiplyNum1;
            Console.WriteLine($"Input the first number to multiply:");
            MultiplyNum1 = Convert.ToInt32(Console.ReadLine());

            int MultiplyNum2;
            Console.WriteLine($"Input the second number to multiply:");
            MultiplyNum2 = Convert.ToInt32(Console.ReadLine());

            int MultiplyNum3;
            Console.WriteLine($"Input the third number to multiply:");
            MultiplyNum3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Result= {MultiplyNum1 * MultiplyNum2 * MultiplyNum3}");



        }
    }
}