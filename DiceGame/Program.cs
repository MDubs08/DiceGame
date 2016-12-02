using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Game selector = new Game();
            selector.GameSelector();
        }
    }
}
