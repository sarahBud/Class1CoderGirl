using System;

namespace Class1CoderGirl
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            string standardGreeting = "Hello, " + name + ".";

           if (name == "Amar")
            {
                Console.WriteLine(standardGreeting + "You have nice shoes.");
            }
            
            else if(name == "Brandy")
            {

                Console.WriteLine(standardGreeting + "You are awesome!");

            }
            else
            {
                Console.WriteLine(standardGreeting);
            }
            Console.ReadLine();
            



         
        }
    }
}
