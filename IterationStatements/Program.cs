using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;

namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000 - Done

        public static void Count()
        {
            var i = 0;


            for (i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }




            //Write a method that will print to the console numbers 3 through 999 by 3 each time


            for (i = 0; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }
        }



        //Write a method to accept two integers as parameterss and check whether they are equal or not

        public static void Check()
        {

            int int1, int2;

            Console.WriteLine("Please type your number:");
            int1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please type your next number:");
            int2 = Convert.ToInt32(Console.ReadLine());

            if (int1 == int2)
            {
                Console.WriteLine($"{int1} and {int2} are equal.");
            }
            else
            {
                Console.WriteLine($"{int1} and {int2} are not equal.");
            }

             //Write a method to check whether a given number is even or odd

            if (int1 % 2 == 0)
            {
                Console.WriteLine($"The number {int1} is even");
            }
            else
            {
                Console.WriteLine($"The number {int1} is odd");
            }
            if (int2 % 2 == 0)
            {
                Console.WriteLine($"The number {int2} is even");
            }
            else
            {
                Console.WriteLine($"The number {int2} is odd");
            }
        }

        //Write a method to check whether a given number is positive or negative

        public static void CheckNumbers()
        {
            int num;

            Console.WriteLine("Lets check if a number is positive or negative.");
            Console.WriteLine("Type an integer");
            num = Convert.ToInt32(Console.ReadLine());

            if (num > 0)
            {
                Console.WriteLine($"The number {num} is positive");
            }
            else if (num == 0)
            {
                Console.WriteLine("0 is 0");
            }
            else
            {
                Console.WriteLine($"The number {num} is negative");
            }

             //Write a method to read the age of a candidate and determine whether they can vote.
             //Hint: Use Parse or the safer TryParse() for an extra challenge
             //Parse()
             //TryParse()

            int age;

            Console.WriteLine("Please type your age: ");
            age = Convert.ToInt32(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine("You are eligible to vote!!");
            }
            else
            {
                Console.WriteLine("Please come back when you are over the age of 18.");
            }

            //Heatin Up Section:
            //Write a method to check if an integer(from the user) is in the range -10 to 10

            int number;
            Console.WriteLine("Type an integer");
            number = Convert.ToInt32(Console.ReadLine());

            if (number >= -10 && number <= 10)
            {
                Console.WriteLine($"{number} is between -10 and 10");
            }
            else
            {
                Console.WriteLine($"{number} is not between -10 and 10");
            }



        }

        public static bool CanVote()   
        {
            Console.WriteLine("Please enter your age:");
            var canParse = int.TryParse(Console.ReadLine(), out int age);

            while(canParse == false) 
            {
                Console.WriteLine("Please enter a valis age:");
                canParse = int.TryParse(Console.ReadLine(),out age);
            }

            if(age >= 18) 
            {
                return true;
            }
            else 
            {
                return false;
            }
        }

        //Write a method to display the multiplication table(from 1 to 12) of a given integer

        public static void Multiply()
        { 
            int a, b;
            Console.WriteLine("Type a number.");
            b = Convert.ToInt32(Console.ReadLine());

            for (a = 1; a <= 12; a++)
            {
                Console.Write($"{b} X {a} = {b * a}\n");
            }

        }


        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            //Count();

            //Check();

            //CheckNumbers();                    
            
            Multiply();



        }
    }
}
