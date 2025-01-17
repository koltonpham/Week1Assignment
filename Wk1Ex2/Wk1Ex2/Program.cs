using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk1Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first name?"); //writing to the console the questions to be asked
            string name = Console.ReadLine();              //saving the input from the user as variable
            Console.WriteLine("What is your last name?");  
            string lName = Console.ReadLine();
            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();
            Console.WriteLine("What is your favorite color?");
            string color = Console.ReadLine();

            //printing out the full sentence using all the varibles that was entered in by the user
            Console.WriteLine("Hello, " + name + " " + lName + "! You are " + age + " years old and your favorite color is " + color + ".");
            
        }
    }
}
