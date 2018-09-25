using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoPaScLiSp
{
    class Game
    {
        //
        public Player player1;
        public Player player2;
        public Gestures gestures;
      
        int player1score = 0;
        int player2score = 0;
        int rnd = 3;

        // constructor




        public void Player1()

        {
            Console.WriteLine("Player : please Select your opponent [1]HumanPlayer or [2]ComputerPlayer ");
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    HumanPlayer.makeChoice();
                    break;
                case "2":
                    Player.RandomGesturesCpu();


                    break;


            }



        }

        public void ComparingGestures()
        {
            if (player1.choose == "rock")
            {
                if (player2.choose == "rock")
                {
                    Console.WriteLine("Its a tie");// tie
                }
                else if (player2.choose == "scisors" || player2.choose == "lizard")
                {
                    Console.WriteLine("player 1 win");
                    while (player1score < rnd && player2score < rnd)
                        player1score++;

                }
                else if (player2.choose == "paper" || player2.choose == "spock")
                {
                    Console.WriteLine("player 2 win");
                    while (player1score < rnd && player2score < rnd) ;
                    player2score++;
                }
            }
            if (player1.choose == "paper")
            {
                if (player2.choose == "paper")
                {
                    Console.WriteLine("Its a tie");
                }
                else if (player2.choose == "rock" || player2.choose == "spock")
                {
                    Console.WriteLine("player 1 win");
                    while (player1score < rnd && player2score < rnd) ;
                    player1score++;
                }
                else if (player2.choose == "scissors" || player2.choose == "lizard")
                {
                    Console.WriteLine("player 2 win");
                    while (player1score < rnd && player2score < rnd) ;
                    player2score++;


                }
            }
            if (player1.choose == "scissors")
            {
                if (player2.choose == "scissors")
                {
                    Console.WriteLine("Its a tie");

                }
                else if (player2.choose == "paper" || player2.choose == "lizard")
                {
                    Console.WriteLine("player 1 win");
                    while (player1score < rnd && player2score < rnd) ;
                    player1score++;
                }
                else if (player2.choose == "rock" || player2.choose == "spock")
                {
                    Console.WriteLine("player 2 win");
                    while (player1score < rnd && player2score < rnd) ;
                    player2score++;
                }
            }
            if (player1.choose == "lizard")
            {
                if (player2.choose == "lizard")
                {
                    Console.WriteLine("Its a tie");

                }
                else if (player2.choose == "spock" || player2.choose == "paper")
                {
                    Console.WriteLine("player 1 win");
                    while (player1score < rnd && player2score < rnd) ;
                    player1score++;
                }
                else if (player2.choose == "rock" || player2.choose == "scissors")
                {
                    Console.WriteLine("player 2 win");
                    while (player1score < rnd && player2score < rnd) ;
                    player2score++;
                }


            }
            if (player1.choose == "spock")
            {
                if (player2.choose == "spock")
                {
                    Console.WriteLine("Its a tie");
                }
                else if (player2.choose == "rock" || player2.choose == "scissors")
                {
                    Console.WriteLine("player 1 win");
                    while (player1score < rnd && player2score < rnd) ;
                    player2score++;
                }
                else if (player2.choose == "lizard" || player2.choose == "paper")
                {
                    Console.WriteLine("player 2 win");
                    while (player2score < rnd && player2score < rnd) ;
                    player2score++;
                }
                if (player1score == rnd)
                {
                    Console.WriteLine("Player 1 won");
                }
                else if (player2score == rnd)
                {
                    Console.WriteLine("player 2 won");
                }





            }
        }
    }
}
