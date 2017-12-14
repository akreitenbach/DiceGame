using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
    class Program
    {
        static Random randomRoll = new Random(); //need to put "static" here or it doesn't work
        static void Main(string[] args)
        {
            Console.WriteLine("Let's play a game.  First player to 40 wins!");
            int myTotal = 0;
            int computerTotal = 0;

            while (myTotal < 40 && computerTotal < 40)
            {
                myTotal = myTotal + (RollDice());
                if (myTotal < 40)
                    Console.WriteLine($"My total is {myTotal}");
                else
                {
                    Console.WriteLine($"I win! My final total is {myTotal}");
                }
                Console.ReadLine();

                if (myTotal < 40)
                {
                    computerTotal = computerTotal + (RollDice());
                    if (computerTotal < 40)
                        Console.WriteLine($"Your total is {computerTotal}");
                    else
                    {
                        Console.WriteLine($"You win! Your total is {computerTotal}");
                    }
                    Console.ReadLine();
                }

            }             
        }

        
        private static int RollDice()
        {
            int dieRollOne = randomRoll.Next(1, 7);
            int dieRollTwo = randomRoll.Next(1, 7);
            int dieSum = dieRollOne + dieRollTwo;
            //Console.WriteLine($"die 1 is {dieRollOne}");
            //Console.WriteLine($"die 2 is {dieRollTwo}");
            return dieSum;
        }
    }
}
