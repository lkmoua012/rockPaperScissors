using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockPaperScissors
{
    class Program
    {
        public static void rps(string player1, string player2)
        {
            if ((player1 == "rock" && player2 == "rock")
                || (player1 == "scissors" && player2 == "scissors")
                || (player1 == "paper" && player2 == "paper"))
            {

                Console.WriteLine("TIE");

            } else if ((player1 == "rock" && player2 == "scissors")
                || (player1 == "scissors" && player2 == "paper")
                || (player1 == "paper" && player2 == "rock"))
            {

                Console.WriteLine("Player 1 wins");

            }
            else if ((player2 == "rock" && player1 == "scissors")
              || (player2 == "scissors" && player1 == "paper")
              || (player2 == "paper" && player1 == "rock"))
            {

                Console.WriteLine("Player 2 wins");

            }
            else
            {
                Console.WriteLine("Please enter 'rock' 'paper' or 'scissors'");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Player 1 Input: ");
            string p1 = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Player 2 Input: ");
            string p2 = Console.ReadLine();
            Console.Clear();
            rps(p1, p2);
            Console.WriteLine("Game over");
            Console.ReadLine();
        }
    }
}
