using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
    public class Computer : Player
    {
        public int ComputerScore = 0;
        public string ComputerName = "Computer";
        public string ComputerChoice;

        public Computer()
        {
            PlayerName = ComputerName;
            PlayerScore = ComputerScore;
            PlayerChoice = ComputerChoice;
        }
        public string GetComputerPick()
        {
            Random computerPick = new Random();
            int computerChoice = computerPick.Next(1, 6);
            ComputerChoice = ConvertComputerPick(computerChoice);
            PlayerChoice = ComputerChoice;
            return ComputerChoice;
        }
        public string ConvertComputerPick(int computerChoice)
        {
            if (computerChoice == 1)
            {
                ComputerChoice = "rock";
            }
            else if (computerChoice == 2)
            {
                ComputerChoice = "paper";
            }
            else if (computerChoice == 3)
            {
                ComputerChoice = "scissors";
            }
            else if (computerChoice == 4)
            {
                ComputerChoice = "lizard";
            }
            else if (computerChoice == 5)
            {
                ComputerChoice = "spock";
            }
            return ComputerChoice;
        }
    }
}
