// module 3 challenge

// code from assignment description
using System;

namespace ZooAnimalsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the animal's hunger level (1-10): ");
            int hungerLevel = int.Parse(Console.ReadLine());
            //Add code here for your if-else statement.
            if (hungerLevel >= 8)
            {
                Console.WriteLine("Lion: Roar! I need a big meal!");
            }
            else if (hungerLevel >= 5)
            {
                Console.WriteLine("Monkey: Ooh ooh! I'll take some bananas.");
            }
            else
            {
                Console.WriteLine("Tortoise: Slow and steady—I'll have some lettuce.");
            }

            // Ternary Operator simplfied if else statement more or less
            string message = (hungerLevel >= 8) ? "Listen to the Lion: Roar!" : "Listen to the Monkey: Ooh ooh!";

            //outputting message based on Ternary Operator
            Console.WriteLine(message);

            // weekday user input
            Console.WriteLine("What is the day of the week numberically? Begining at 1 for Sunday and ending at 7 for Saturday?: ");
            int weekday = int.Parse(Console.ReadLine());

            // switch statement. Zoo promotions based on which day of the week
            switch (weekday)
            {
                case 1:
                    Console.WriteLine("Shark Sunday!");
                    break;
                case 2:
                    Console.WriteLine("Monkey Monday!");
                    break;
                case 3:
                    Console.WriteLine("Turtle Tuesday");
                    break;
                case 4:
                    Console.WriteLine("Whale Wednesday");
                    break;
                case 5:
                    Console.WriteLine("Tiger Thursday");
                    break;
                case 6:
                    Console.WriteLine("Fox Friday");
                    break;
                case 7:
                    Console.WriteLine("Sheep Saturday");
                    break;
                default:
                    Console.WriteLine("Not a real day of the week");
                    break;
            }


        }
    }
}
