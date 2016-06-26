using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamJaxConsoleGame.Lib.Entities;

namespace TeamJaxConsoleGame.Lib
{
    public class GameScene
    {
        //TODO: Use interfaces
        public GameScene(Location currentLocation, Hero hero)
        {
            this.CurrentLocation = currentLocation;
            this.Hero = hero;
        }

        public Location CurrentLocation { get; set; }

        public Hero Hero { get; set; }
    }
}
