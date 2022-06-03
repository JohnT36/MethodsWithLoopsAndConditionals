using System;

namespace MethodsWithLoopsAndConditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintThousand();
            Multiple3();
            IsEqual(25, 26);
            EvenOdd(25);
            PON(-1);
            Console.WriteLine($"Hello, and Welcome!");
            Console.WriteLine($"Before continuing, tell us your age. How old are you?");
            int number = int.Parse(Console.ReadLine());
            AgeChecker(number);
            InRange();

        }

        public static void PrintThousand()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);

            }
        }
        //Write a method that will print to the
        //console numbers 3 through 999 by 3 each time.

        public static void Multiple3()
        {
            for (int k = 3; k <= 999; k += 3)
            {
                Console.WriteLine(k);
            }
        }

        //Write a method to accept two integers as parameters
        //and check whether they are equal or not.

        public static void IsEqual(int a, int b)
        {
            if (a == b)
            {
                Console.WriteLine($"True!");
            }
            else
            {
                Console.WriteLine($"False!");
            }

            //Write a method to check whether
            //a given number is even or odd.
        }
        public static void EvenOdd(int num)
        {
            if (num % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }


        }

        //Write a method to check whether a given
        //number is positive or negative.
        public static void PON(int numb)
        {
            if (numb >= 0)
            { Console.WriteLine("Positive"); }
            else
            { Console.WriteLine($"Negative"); }
        }

        //Write a method to read the age of a candidate and
        //determine whether they can vote.Hint: use Parse()...
        //or the safer TryParse() for an extra challenge!!

        public static void AgeChecker(int number)
        {
            if (number >= 18)
            {
                Console.WriteLine("You are old enough to vote!");
            }
            else
            {
                Console.WriteLine("Sorry, you are not old enough to vote");
            }
        }

        //Write a method to check if an integer
        //(from the user) is in the range -10 to 10.
        public static void InRange()
        {


            Console.WriteLine("Choose a number between -10 and 10.");
            int numbers = int.Parse(Console.ReadLine());

            if (numbers >= -10 && numbers <= 10)
            {
                Console.WriteLine("You are in the right range good job!");
            }
            else
            {
                Console.WriteLine("You are not in the right range!");
            }

        }
            //Write a method to display the multiplication
            //table(from 1 to 12) of a given integer.
           public static void MultiplyTable()
        { }
        

    }

}
