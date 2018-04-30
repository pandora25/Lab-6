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
            bool repeat = true;
            while (repeat)
            {
                Console.WriteLine("welcome to grand circus casino! Roll the dice?");

                Console.WriteLine("how many sides shoud each dice have?");

                Console.Write("first one: ");
                int dice1 = int.Parse(Console.ReadLine());
                Console.Write("second one: ");
                int dice2 = int.Parse(Console.ReadLine());

                Random rolling = new Random();

                int x = rolling.Next(1, dice1 + 1);
                int y = rolling.Next(1, dice2 +1);


                Console.WriteLine($"the number are\n{x}\n{y}");
                Console.WriteLine("welcome to grand circus casino! Roll the dice? (y/n)");
                string validation = Console.ReadLine().ToLower();
                if (validation == "y")
                {
                    continue;
                }
                repeat = false;
            }
        }
    }





  
}
