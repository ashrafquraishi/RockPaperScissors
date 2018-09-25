using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoPaScLiSp
{
    class HumanPlayer : Player
    {
        // member variables
        

        // constructor
        public void player1(string Choose)
        {
            this.choose = Choose;
        }

        //  member methods

        public static void makeChoice()
        {
            List<string> listOfGestures = new List<string>();
            listOfGestures.Add("rock");
            listOfGestures.Add("paper");
            listOfGestures.Add("scissors");
            listOfGestures.Add("lizard");
            listOfGestures.Add("spock");
            foreach (string listOfGesture in listOfGestures)
            {
                Console.WriteLine(listOfGesture);
            }







            Console.WriteLine("Please Enter your pick ");
            string choose = Console.ReadLine();
        }





    }
}
