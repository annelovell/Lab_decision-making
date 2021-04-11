using System;

namespace Lab3_Decision_Making
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string userInput = Console.ReadLine();
            
            bool LoopContinueYN = true;
            while (LoopContinueYN)
            {
                Console.WriteLine("Please enter a number between 1 and 100: ");
                string userInput2 = Console.ReadLine();

                double number = double.Parse(userInput2);

                if (number <= 0 || number >= 101)
                {
                    Console.WriteLine($"I'm sorry {userInput}, {userInput2} is not a number between 1 and 100.");
                }
                                
                if (number % 2 == 1)
                {
                    if (number >= 60 && number <= 100)
                    {
                        Console.WriteLine($"Thank you {userInput}, you entered {number}. This number is odd and greater than 60.");
                    }
                    else if (number >= 1 && number <= 59)
                    {
                        Console.WriteLine($"Thank you {userInput}, you entered {number}. This number is odd.");
                    }
                }

                if (number % 2 == 0)
                {
                    if (number >= 2 && number <= 25)
                    {
                        Console.WriteLine($" Thank you {userInput}, you entered {number}. This number is even and less than 25.");
                    }

                    if (number >= 26 && number <= 100)
                    {
                        Console.WriteLine($" Thank you {userInput}, you entered {number}. This number is even.");
                    }


                    Console.WriteLine("Would you like to do another calculation? (Y/N) ");
                    string userInput3 = Console.ReadLine();

                    if (userInput3.ToLower() == "y")
                    {
                        Console.WriteLine("Awesome!");
                    }
                    if (userInput3.ToLower() == "n")
                    {
                        Console.Write("Thank you!");
                        LoopContinueYN = false;
                    }


                }
            }
        }
    }
}
