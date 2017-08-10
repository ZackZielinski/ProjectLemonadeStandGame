using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
        Player playerOne;
        Week BeginWeek;
        public Game()
        {
        }

        public void StartGame()
        {
            playerOne = new Player();
            playerOne.StartingNewGame();

            BeginWeek = new Week();
            BeginWeek.DaysOfTheWeek(playerOne);
        }

    }
}
