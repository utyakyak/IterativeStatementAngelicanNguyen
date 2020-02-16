using System;

namespace IterativeStatementAngelicanNguyen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer between 2 and 10");
            int UserNumber;
            while (int.TryParse(Console.ReadLine(), out UserNumber))
            {
                if (UserNumber >= 2 && UserNumber <= 10)
                {
                    if(UserNumber %2 ==1)
                    {
                        Console.WriteLine("You entered an odd number");
                    }
                    else
                    {
                        Console.WriteLine("You entered an even number");
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Enter an integer between 2 and 10");
                }
            }
        }
    }
}
           
