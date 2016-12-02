using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
    class GameDice : Game
    {
        Player PlayerOne;
        Player PlayerTwo;
        Player Computer;
        public void PlayDice()
        {
            Header();
            PlayOption();
            //GamePlay();
            //GameResults();
            //Footer();
        }
        public void Header()
        {
            string gameName = "Dice Game";
            Console.WriteLine("Welcome to {0}", gameName);
            Console.WriteLine("Who would you like to play today?");
            Console.WriteLine("Computer or Human?");
        }
        public void PlayOption()
        {
            string OpponentOption = (Console.ReadLine());
            switch (OpponentOption.ToLower())
            {
                case "Human":
                    PlayerOne = new Player();
                    PlayerOne = new Player();
                    break;

                case "Computer":
                    PlayerOne = new Player();
                    Computer = new Computer();
                    break;

                default:
                    Console.WriteLine();
                    PlayOption();
                    break;
            }

        }
        public void GamePlay()
        {
            //string playerOneRoll();
            
        }
        public void GameResults()
        {
            //return ComputerPick;
        }
        public void Footer()
        {

        }
    }
}
