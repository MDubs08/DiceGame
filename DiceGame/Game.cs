using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
    class Game
    {
        GameDice Dice;
        GameRPSLS RPSLS;
        public void GameSelector()
        {
            SelectorHeader();
            GameOption();
        }
        public void SelectorHeader()
        {
            Console.WriteLine("Welcome to i++");
            Console.WriteLine("The two game test machine");

        }
        public void GameOption()
        {
            Console.WriteLine("Choose a game to play.");
            Console.WriteLine("Dice or RPSLS?");
            string gameOption = Console.ReadLine();
            switch (gameOption.ToLower())
            {
                case "dice":
                    Console.WriteLine("Dice is unavailable at this time.");
                    //Dice = new GameDice();
                    //Dice.PlayDice();
                    GameOption();
                    break;


                case "rpsls":
                    RPSLS = new GameRPSLS();
                    RPSLS.PlayRPSLS();
                    break;

                default:
                    Console.WriteLine("Invalid selection. Please try again.");
                    GameOption();
                    break;
            }
        }
    }
}
