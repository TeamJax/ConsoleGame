using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamJaxConsoleGame.Lib.Constants;
using TeamJaxConsoleGame.Lib.Entities;
using TeamJaxConsoleGame.Lib.Entities.HeroClasses;
using TeamJaxConsoleGame.Lib.Enumerations;

namespace TeamJaxConsoleGame.Lib.Factory.HeroFactory
{
    public class DeathKnightFactory : HeroFactory
    {
        public override Hero CreateHero(string name, RaceType race)
        {
            return new DeathKnight(
                name,
                race,
                HeroConstants.DEATH_KNIGHT_STAMINA,
                HeroConstants.DEATH_KNIGHT_STRENGHT,
                HeroConstants.DEATH_KNIGHT_INTELLIGENCE,
                HeroConstants.DEATH_KNIGHT_AGILITY,
                HeroConstants.DEATH_KNIGHT_ARMOR_RATING);
        }
    }
}
