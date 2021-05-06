using System;
using System.Collections.Generic;
using System.Linq;

namespace C_ChallengeOne
{
    class Program
    {
        static void Main(string[] args)
        //     1.	Allow the user to roll dice
        //     2.	Store the dice rolls 
        //     3.	When user chooses, stop
        //     4.	Allow user to enter number of rolls to examine
        //     5.	From the stored rolls, calculate
        //     1.	Average
        //     2.	Total
        //     3.	List what the rolls were
        {
            Console.WriteLine("Rolling Dice Task Challenge");
            Console.WriteLine("Write start to Roll!");
            string word = Console.ReadLine();

            Random random = new System.Random();
            List<int> diceRolls = new List<int>();

            bool stop = false;

            while (!stop)
            {
                int number = (random.Next(1, 6));
                diceRolls.Add(number);
                Console.WriteLine("The random generated number is " + number);
                Console.WriteLine("For another dice roll enter -roll-, to exit enter -stop-");
                string a = Console.ReadLine();

                if (a == "stop")
                {
                    stop = true;
                    continue;
                }
            }

            
            bool total = true;

            while (!total)
            {
                Console.WriteLine("To find the total enter -total-");
                string b = Console.ReadLine();
                int sum = diceRolls.Sum();

                if (b == "total")
                {
                    Console.WriteLine("SUM:" + sum);
                    stop = false;
                }
            }
        }
    }
}
