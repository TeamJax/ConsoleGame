namespace TeamJaxConsoleGame.Lib.Entities.HeroClasses
{
    using Enumerations;

    public class Rogue : Hero
    {
        public Rogue(string name, RaceType race, int stamina, int strenght, int intelligence, int agility, int armorRating) 
            : base(name, race, HeroType.Rogue, ResourceType.Energy, PrimaryHeroStatsType.Agility, stamina,  strenght,  intelligence,  agility,  armorRating)
        {            
        }

        public override void UseSpecialAbility()
        {
            this.Agility += 85;
        }
    }
}
