namespace TeamJaxConsoleGame.Lib.Entities.HeroClasses
{
    using Enumerations;

    public class Paladin : Hero
    {
        public Paladin(string name, RaceType race, int stamina, int strenght, int intelligence, int agility, int armorRating)
            : base(name, race, HeroType.Paladin, ResourceType.Mana, PrimaryHeroStatsType.Intelligence, stamina, strenght, intelligence, agility, armorRating)
        {
        }

        public override void UseSpecialAbility()
        {
            this.Health += 50;
        }
    }
}
