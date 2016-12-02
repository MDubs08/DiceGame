using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
    class GameRPSLS : Game
    {
        Player PlayerOne;
        Player PlayerTwo;
        Computer Computer;
        List<Player> PlayerName;
        List<int> PlayerScore;

        public void PlayRPSLS()
        {
            PlayerName = new List<Player>();
            PlayerScore = new List<int>();
            Introduction();
            PlayOption();
            GetUserName();
            GamePlay();
            GetResults();
            DisplayScores();
            Replay();
        }
        public string Introduction()
        {
            Console.Clear();
            string gameName = "Rock, Paper, Scissors, Lizard, Spock";
            Console.WriteLine("Welcome to {0}", gameName);
            return gameName;
        }
        public void PlayOption()
        {
            Console.WriteLine("Who would you like to play today?");
            Console.WriteLine("Computer or Human?");

            string OpponentOption = Console.ReadLine();
            switch (OpponentOption.ToLower())
            {
                case "human":
                    Console.Clear();
                    PlayerOne = new Player();
                    PlayerName.Add(PlayerOne);
                    PlayerScore.Add(PlayerOne.PlayerScore);
                    PlayerTwo = new Player();
                    PlayerName.Add(PlayerTwo);
                    PlayerScore.Add(PlayerTwo.PlayerScore);
                    break;

                case "computer":
                    Console.Clear();
                    PlayerOne = new Player();
                    PlayerName.Add(PlayerOne);
                    PlayerScore.Add(PlayerOne.PlayerScore);
                    Computer = new Computer();
                    PlayerName.Add(Computer);
                    PlayerScore.Add(Computer.PlayerScore);
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("Invalid selection. Please try again.");
                    PlayOption();
                    break;
            }
        }
        public void GetUserName()
        {
            Console.Clear();
            foreach (Player player in PlayerName)
            {
                if (player == Computer)
                {
                    continue;
                }
                else player.GetPlayerName();
            }
        }
        public void GamePlay()
        { 
            foreach (Player player in PlayerName)
            {
                if (player == Computer)
                {
                    Computer.GetComputerPick();
                }
                else player.SetPlayerPick();
            }
            foreach (Player player in PlayerName)
            {
                Console.WriteLine("{0} picked {1}", player.PlayerName, player.PlayerChoice);
            }
        }
        public void GetResults()
        {
            int outcome = 0;
            int playerPick;
            int opponentPick;
            //foreach (Player player in PlayerName)
            //{
                if (PlayerName.Contains(PlayerOne) && PlayerName.Contains(Computer))
                {
                    playerPick = PlayerOne.ConvertPlayerPick(PlayerOne.PlayerChoice);
                    opponentPick = Computer.ConvertPlayerPick(Computer.PlayerChoice);
                    outcome = ComputeResults(playerPick, opponentPick);
                    DisplayWinner(outcome, PlayerOne, Computer);

                }
                else if (PlayerName.Contains(PlayerOne) && PlayerName.Contains(PlayerTwo))
                {
                    playerPick = PlayerOne.ConvertPlayerPick(PlayerOne.PlayerChoice);
                    opponentPick = PlayerTwo.ConvertPlayerPick(PlayerTwo.PlayerChoice);
                    outcome = ComputeResults(playerPick, opponentPick);
                    DisplayWinner(outcome, PlayerOne, PlayerTwo);
                }
            //}
        }
        public int ComputeResults(int playerChoice, int opponentChoice)
        {
            int results = (5 + playerChoice - opponentChoice) % 5;
            return results;
        }
        public void DisplayWinner(int outcome, Player player, Player opponent)
        {
            if (outcome == 0)
            {
                Console.WriteLine("It ended in a tie!");
            }
            else if (outcome == 1 || outcome == 3)
            {
                Console.WriteLine("{0} won!", player.PlayerName);
                player.PlayerScore += 1;
            }
            else if (outcome == 2  || outcome == 4)
            {
                Console.WriteLine("{0} won!", opponent.PlayerName);
                opponent.PlayerScore += 1;
            }
        }
        public void DisplayScores()
        {
            foreach (Player player in PlayerName)
            {
                Console.WriteLine("{0} score:  {1}", player.PlayerName, player.PlayerScore);
            }
        }
        public void Replay()
        {
            Console.WriteLine("Would you like to play again?");
            Console.WriteLine("\nYes \nNo");
            string replayValue = Console.ReadLine();
            switch (replayValue.ToLower())
            {
                case "yes":
                    GamePlay();
                    break;

                case "no":
                    Console.WriteLine("Thank you for Playing!");
                    break;

                default:
                    Console.WriteLine("Invalid Selection.");
                    Replay();
                    break;
            }
        }
    }
}
