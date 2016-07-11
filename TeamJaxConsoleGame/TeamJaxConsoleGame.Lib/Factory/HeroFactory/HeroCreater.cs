using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamJaxConsoleGame.Lib.Entities;
using TeamJaxConsoleGame.Lib.Enumerations;

namespace TeamJaxConsoleGame.Lib.Factory.HeroFactory
{
    public class HeroCreater
    {
        public Hero CreateHero(string name, RaceType race, HeroType selectedHeroType)
        {
            HeroFactory heroFactory;

            //TODO: imlement other factories
            switch (selectedHeroType)
            {
                case HeroType.DeathKnight:
                    heroFactory = new DeathKnightFactory();
                    return heroFactory.CreateHero(name, race);
                //case HeroType.Hunter:
                //    break;
                //case HeroType.Mage:
                //    break;
                //case HeroType.Monk:
                //    break;
                //case HeroType.Paladin:
                //    break;
                //case HeroType.Priest:
                //    break;
                //case HeroType.Rogue:
                //    break;
                //case HeroType.Warlock:
                //    break;
                //case HeroType.Warrior:
                //    break;
                default:
                    return null;
            }
        }
    }
}
