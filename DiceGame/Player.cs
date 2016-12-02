using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
    public class Player
    {
        public string PlayerName;
        public int PlayerScore;
        public string PlayerChoice;

        int rock = 1;
        int paper = 2;
        int scissors = 3;
        int lizard = 4;
        int spock = 5;

        public Player()
        {
            
        }
        public void GetPlayerName()
        {
            Console.WriteLine("What is your name?");
            PlayerName = Console.ReadLine();
        }
        public string SetPlayerPick()
        {
            Console.WriteLine("{0}'s turn. Please choose one of the following options: ", PlayerName);
            Console.WriteLine("Rock, Paper, Scissors, Lizard, Spock");
            PlayerChoice = Console.ReadLine();
            return PlayerChoice;
        }
        public int ConvertPlayerPick(string PlayerChoice)
        {
            int result = 0;
            if (PlayerChoice == "rock")
            {
                result = rock;
            }
            else if (PlayerChoice == "paper")
            {
                result = paper;
            }
            else if (PlayerChoice == "scissors")
            {
                result = scissors;
            }
            else if (PlayerChoice == "lizard")
            {
                result = lizard;
            }
            else if (PlayerChoice == "spock")
            {
                result = spock;
            }
            return result;
        }
        public int GetPlayerScore()
        {
            return PlayerScore;
        }
        public string GetPlayerChoice()
        {
            return PlayerChoice;
        }
    }
}
