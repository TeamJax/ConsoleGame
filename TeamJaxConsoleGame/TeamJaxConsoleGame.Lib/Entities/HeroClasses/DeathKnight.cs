namespace TeamJaxConsoleGame.Lib.Entities.HeroClasses
{
    using Enumerations;

    public class DeathKnight : Hero
    {
        public DeathKnight(string name, RaceType race, int stamina, int strenght, int intelligence, int agility, int armorRating)
            : base(name, race, HeroType.DeathKnight, ResourceType.RunicPower, PrimaryHeroStatsType.Strength, stamina, strenght, intelligence, agility, armorRating)
        {
        }

        public override void UseSpecialAbility()
        {
            this.Strenght += 100;
        }
    }
}
