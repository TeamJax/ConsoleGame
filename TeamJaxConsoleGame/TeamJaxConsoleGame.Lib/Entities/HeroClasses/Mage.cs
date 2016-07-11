namespace TeamJaxConsoleGame.Lib.Entities.HeroClasses
{
    using Enumerations;

    public class Mage : Hero
    {
        public Mage(string name, RaceType race, int stamina, int strenght, int intelligence, int agility, int armorRating)
            : base(name, race, HeroType.Mage, ResourceType.Mana, PrimaryHeroStatsType.Intelligence, stamina, strenght, intelligence, agility, armorRating)
        {            
        }

        public override void UseSpecialAbility()
        {
            this.Intelligence += 80;
        }
    }
}
