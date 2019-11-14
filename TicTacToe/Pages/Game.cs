using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicTacToe.Pages
{
    public class Game
    {
        public Color CurrentTurn { get; set; }

        public Checker[,] Board = new Checker[8,8];

        public bool GameOn { get; set; }

        public Game()
        {
            GameOn = true;

            for(int i = 0; i < 7; i += 2)
            {
                Board[i, 0] = new Checker(Color.Black, i, 0);
                Board[i + 1, 1] = new Checker(Color.Black, i + 1, 1);
                Board[i, 2] = new Checker(Color.Black, i, 2);

                Board[i + 1, 5] = new Checker(Color.Red, i + 1, 5);
                Board[i, 6] = new Checker(Color.Red, i + 1, 6);
                Board[i + 1, 7] = new Checker(Color.Red, i + 1, 7);
            }

            CurrentTurn = Color.Red;
        }
    }
}
