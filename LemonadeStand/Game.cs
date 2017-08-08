using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
        public Game()
        {
            Player StartGame = new Player();
            StartGame.Rules();
            Week BeginWeek = new Week();
            BeginWeek.DaysOfTheWeek();
        }

    }
}
