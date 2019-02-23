using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool goodAnswerReceived = false;
            int answer1 = 0;
            while (!goodAnswerReceived)
            {
                Console.WriteLine("What is your age?");
                try
                {
                    answer1 = Convert.ToInt16(Console.ReadLine());
                    if (answer1 <= 0) Console.WriteLine(answer1.ToString() + "?! Inconceivable!");
                    else
                        goodAnswerReceived = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("I'm sorry I didn't get that");
                }
            }

            bool goodAnswer2Received = false;
            while (!goodAnswer2Received)
            {
                Console.WriteLine("Did you have your birthday yet this year? y/n");
                string input2 = Console.ReadLine().ToLower();
                if (input2 == "y")
                {
                    goodAnswer2Received = true;
                }
                else if (input2 == "n")
                {
                    answer1++;
                    goodAnswer2Received = true;
                }
                else Console.WriteLine("input " + input2 + " not understood, please just use 'y' or 'n'");
            }

            Console.WriteLine("You were born in the year " + DateTime.Today.AddYears(-answer1).Year.ToString());
            Console.ReadLine();
        }
    }
}
