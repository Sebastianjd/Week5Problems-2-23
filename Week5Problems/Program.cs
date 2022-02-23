using System;

namespace Week5Problems
{
    class Program
    {
        public static Random random;
        static void Main(string[] args)
        {
            /*
            1) Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder.
            Display the count on the console.
            */
            ProblemOne();

            /*
            4) Write a program that picks a random number between 1 and 10. Give the user 4 chances to guess the number.
            If the user guesses the number, display “You won"; otherwise, display “You lost".
           */
            ProblemFour();

            /*
            Write a program and ask the user to enter a series of numbers separated by comma.
            Find the maximum of the numbers and display it on the console.
           */
            ProblemFive();
        }

        static void ProblemOne()
        {
            int count = 0;

            //The for loop will repeat 100 times from 1 to 100.
            for (int i = 1; i <= 100; i++)
            {
                //If the current number is divisible by 3 with no remainder, add 1 to the count.
                if (i % 3 == 0)
                {
                    count += 1;
                }
            }

            Console.WriteLine("Problem 1: ");
            Console.WriteLine("\nCount: " + count);
        }

        static void ProblemFour()
        {
            random = new Random();
            int num = 0;
            int guess = 0;
            int chances = 3;

            //Get a random number between 1 and 10
            num = random.Next(1, 10);

            Console.WriteLine("\nProblem 4: ");
            Console.Write("\nYou have 4 chances to guess a number between 1 and 10: ");
            guess = Convert.ToInt32(Console.ReadLine());

            //Repeat the loop while the user's guess is not equal the random number and the chances to guess is not zero.
            while (num != guess && chances != 0)
            {
                Console.Write("Wrong guess, try again: ");
                guess = Convert.ToInt32(Console.ReadLine());
                chances -= 1;
            }

            if (num == guess)
            {
                Console.WriteLine("\nYou won!");
            }
            else
            {
                Console.WriteLine("\nYou lost!");
                Console.WriteLine("The number was " + num + ".");
            }
        }

        static void ProblemFive()
        {
            string seriesNum = "";
            int max = 0;

            Console.WriteLine("\nProblem 5: ");
            Console.Write("\nPlease enter a series of numbers separated by comma (Ex: \"5, 3, 8, 1, 4\"): ");
            seriesNum = Console.ReadLine();

            //The string given by the user will be split based on the commas, and each substring will be store in the "numbers" array.
            string[] numbers = seriesNum.Split(',');

            //the "max" variable will hold the first value in the "numbers" array 
            max = Convert.ToInt32(numbers[0]);

            /*The for loop will then compare each value in the array with the "max" variable.
            If the current array value is greater than the "max" variable, then the "max" variable will hold the greater value.*/
            for (int i = 0; i < numbers.Length; i++)
            {
                if (Convert.ToInt32(numbers[i]) > max)
                {
                    max = (Convert.ToInt32(numbers[i]));
                }
            }

            Console.WriteLine("\nMaximum Number: " + max);
        }
    }
}
