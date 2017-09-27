using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace LoopsBranching
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("What is your age?");
            //int answer = int.Parse(Console.ReadLine()); //take input, make it an integer

            //switch case
            //switch (answer)
            //{
            //    case 12:
            //        Console.WriteLine("You are a child");
            //        break;
            //    case 19:
            //        Console.WriteLine("You are a teenager");
            //        break;
            //    case 30:
            //        Console.WriteLine("You are young");
            //        break;
            //    case 65:
            //        Console.WriteLine("You are an adult");
            //        break;
            //    default:
            //        Console.WriteLine("I don't care about your age");
            //        break;
            //}

            // if/else
            //if (answer <= 12)
            //{
            //    Console.WriteLine("You are a child");
            //}
            //else if (answer > 12 && answer <= 19)
            //{
            //    Console.WriteLine("You are a teenager");
            //}
            //else if (answer > 19 && answer <= 30)
            //{
            //    Console.WriteLine("You are young");
            //}
            //else if (answer > 30 && answer <= 65)
            //{
            //    Console.WriteLine("You are an adult");
            //}
            //else
            //{
            //    Console.WriteLine("You are old");
            //}

            //for loop - count from 1 to 100
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
