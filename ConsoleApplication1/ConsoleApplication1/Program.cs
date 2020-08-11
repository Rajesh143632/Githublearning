using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Program
    {
        static void Main(string[] args)
        {

            //write a c program to get the absolute difference between n and 51.if n is greater than 51 return triple the absolute difference.
            int x = 51, y = 53;

            if (y > x)
            {
                Console.WriteLine((y - x) * 3);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(y - x);
                Console.ReadLine();
            }


            //10.write a c program to find the largest of three numbers.

            int num1 = 20, num2 = 30, num3 = 40;
            if (num1 > num2)
                if (num1 > num3)
                {
                    Console.WriteLine("the 1st number is grater than among all ");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("the 3rd number is grater than among all");
                    Console.ReadLine();
                }

            else if (num2 > num3)
            {
                Console.WriteLine("the 2nd number is grater among all");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("the 3rd number is grater than among all");
                Console.ReadLine();
            }



            //7. write a c program to find whether a given year is a leap year or not.

            int year;
            Console.Write("enter year:");
            year = Convert.ToInt32(Console.ReadLine());
            if (year % 100 == 0 || year % 400 == 0)
            {
                Console.WriteLine("year is leap year");
            }
            else
            {
                Console.WriteLine("year is not leap year");
            }
            Console.ReadLine();

            //. Write a program in C to display n terms of natural number and their sum.

            int Naturalnumbers;
            Console.Write("Enter natural number:");
            Naturalnumbers = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= Naturalnumbers; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}




