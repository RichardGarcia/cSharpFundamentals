using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decisions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Please type something and press the Enter key");
            //string userValue;
            //userValue = Console.ReadLine();
            //Console.WriteLine("You typed: {0}", userValue);


            // else-if statement

            //Console.WriteLine("Would you prefer what is behind door number 1, 2 or 3?");
            //string userValue = Console.ReadLine();

            /*
            if (userValue == "1")
            {
                Console.WriteLine("You won a car!");
                Console.ReadLine();
            }
            else if (userValue == "2")
            {
                Console.WriteLine("You won a Boat!");
                Console.ReadLine();
            }
            else if (userValue == "3")
            {
                Console.WriteLine("You won a cat!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Sorry we don't understand.. you lose!");
                Console.ReadLine();
            }
            */

            // else-if statement after refactoring..

            Console.WriteLine("Would you prefer what is behind door number 1, 2 or 3?");

            string userValue = Console.ReadLine();
            string prizeMessage = "";

            if (userValue == "1")
                prizeMessage = "you won a car!";
            else if (userValue == "2")
                prizeMessage = "you won a boat!";
            else if (userValue == "3")
                prizeMessage = "you won a cat!";
            else
                prizeMessage = "sorry we don't understand.. you lose!";


            Console.WriteLine(prizeMessage);
            Console.ReadLine();

            /*
            string prizeMessage = (userValue == "1") ? "boat" : "strand of lint";
            Console.WriteLine("You won {0}!", prizeMessage);
            */

        }
    }
}
