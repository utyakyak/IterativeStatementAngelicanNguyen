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
                        if (UserNumber % 2 == 1)
                    {
                        if (UserNumber == 3)
                        {
                            Console.WriteLine("You entered an odd number");
                            Console.WriteLine("You entered an odd number");
                        }
                            if (UserNumber == 5)
                        {
                            Console.WriteLine("You entered an odd number");
                            Console.WriteLine("You entered an odd number");
                            Console.WriteLine("You entered an odd number");
                            Console.WriteLine("You entered an odd number");

                        }
                        if (UserNumber == 7)
                        {
                            Console.WriteLine("You entered an odd number");
                            Console.WriteLine("You entered an odd number");
                            Console.WriteLine("You entered an odd number");
                            Console.WriteLine("You entered an odd number");
                            Console.WriteLine("You entered an odd number");
                            Console.WriteLine("You entered an odd number");

                        }
                        if (UserNumber == 9)
                        {
                            Console.WriteLine("You entered an odd number");
                            Console.WriteLine("You entered an odd number");
                            Console.WriteLine("You entered an odd number");
                            Console.WriteLine("You entered an odd number");
                            Console.WriteLine("You entered an odd number");
                            Console.WriteLine("You entered an odd number");
                            Console.WriteLine("You entered an odd number");
                            Console.WriteLine("You entered an odd number");
                        }
                    }
                    else
                    {
                        if(UserNumber ==2)
                        {
                            Console.WriteLine("You entered an even number");
                            Console.WriteLine("You entered an even number");
                            Console.WriteLine("You entered an even number");
                        }
                        if(UserNumber ==4)
                        {
                            Console.WriteLine("You entered an even number");
                            Console.WriteLine("You entered an even number");
                            Console.WriteLine("You entered an even number");
                            Console.WriteLine("You entered an even number");
                            Console.WriteLine("You entered an even number");
                        }
                        if(UserNumber==6)
                        {
                            Console.WriteLine("You entered an even number");
                            Console.WriteLine("You entered an even number");
                            Console.WriteLine("You entered an even number");
                            Console.WriteLine("You entered an even number");
                            Console.WriteLine("You entered an even number");
                            Console.WriteLine("You entered an even number");
                            Console.WriteLine("You entered an even number");
                        }
                        if(UserNumber==8)
                        {
                            Console.WriteLine("You entered an even number");
                            Console.WriteLine("You entered an even number");
                            Console.WriteLine("You entered an even number");
                            Console.WriteLine("You entered an even number");
                            Console.WriteLine("You entered an even number");
                            Console.WriteLine("You entered an even number");
                            Console.WriteLine("You entered an even number");
                            Console.WriteLine("You entered an even number");
                            Console.WriteLine("You entered an even number");
                        }
                        if(UserNumber==10)
                        {
                            Console.WriteLine("You entered an even number");
                            Console.WriteLine("You entered an even number");
                            Console.WriteLine("You entered an even number");
                            Console.WriteLine("You entered an even number");
                            Console.WriteLine("You entered an even number");
                            Console.WriteLine("You entered an even number");
                            Console.WriteLine("You entered an even number");
                            Console.WriteLine("You entered an even number");
                            Console.WriteLine("You entered an even number");
                            Console.WriteLine("You entered an even number");
                            Console.WriteLine("You entered an even number");
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
           
