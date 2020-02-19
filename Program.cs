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
                    int i;
                    if (UserNumber % 2 == 1)
                    {
                        int x = UserNumber - 1;
                        for(i = 1; i<=x; i++)
                        {
                            Console.WriteLine(i + ". " + "You entered an odd number");
                        }
                    }
                    else
                    {
                        int y = UserNumber + 1;
                        for(i = 1; i <=y; i++)
                        {
                            Console.WriteLine(i + ". " + "You entered an even number");
                        }
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
           
