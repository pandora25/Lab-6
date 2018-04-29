using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to Roll And Dice Game");
            Console.WriteLine("please enter or press Enter to begin the Game ?");
            string entrance = Console.ReadLine();

            while (string.IsNullOrEmpty(entrance))
            {
                Console.WriteLine("roll the dice (y/n)");
                string input = Console.ReadLine();

                if (input == "y")
                {
                    Random up = new Random();
                  

                    int x = up.Next(1, 6);
                    int y = up.Next(1, 6);

                    Console.WriteLine($"the number are {x} {y}");
                }
                break;
            }      
        }
    }
}
