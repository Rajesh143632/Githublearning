using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
  public   class Program
    {
        static void Main(string[] args)
        {

            //Write a C program to get the absolute difference between n and 51.If n is greater than 51 return triple the absolute difference.
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


            //10.Write a C program to find the largest of three numbers.

            int num1 = 20, num2 = 30, num3 = 40;
            if (num1 > num2)
                if (num1 > num3)
                {
                    Console.WriteLine("The 1st number is grater than among all ");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("The 3rd number is grater than among all");
                    Console.ReadLine();
                }

            else if (num2 > num3)
            {
                Console.WriteLine("The 2nd number is grater among all");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("The 3rd number is grater than among all");
                Console.ReadLine();
            }



        //7. Write a C program to find whether a given year is a leap year or not.

             int year;
            Console.Write("Enter year:");
            year = Convert.ToInt32(Console.ReadLine());
            if (year % 100 == 0 || year % 400 == 0)
            {
                Console.WriteLine("Year is leap year");
            }
            else
            {
                Console.WriteLine("Year is not leap year");
            }
            Console.ReadLine();
        }
    }
}



