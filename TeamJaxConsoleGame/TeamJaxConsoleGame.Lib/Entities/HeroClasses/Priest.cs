namespace TeamJaxConsoleGame.Lib.Entities.HeroClasses
{
    using Enumerations;

    public class Priest : Hero
    {
        public Priest(string name, RaceType race,  int stamina, int strenght, int intelligence, int agility, int armorRating)
            : base(name, race, HeroType.Priest, ResourceType.Mana, PrimaryHeroStatsType.Intelligence, stamina, strenght, intelligence, agility, armorRating)
        {
        }

        public override void UseSpecialAbility()
        {
            this.Intelligence += 100;
        }
    }
}
