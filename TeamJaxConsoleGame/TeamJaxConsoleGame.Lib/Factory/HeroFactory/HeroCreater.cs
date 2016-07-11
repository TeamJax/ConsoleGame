namespace TeamJaxConsoleGame.Lib.Factory.HeroFactory
{
    using Entities;
    using Enumerations;
    using ClassesFactory;

    public class HeroCreater
    {
        public Hero CreateHero(string name, RaceType race, HeroType selectedHeroType)
        {
            HeroFactory heroFactory;

            switch (selectedHeroType)
            {
                case HeroType.DeathKnight:
                    heroFactory = new DeathKnightFactory();
                    return heroFactory.CreateHero(name, race);
                case HeroType.Hunter:
                    heroFactory = new HunterFactory();
                    return heroFactory.CreateHero(name, race);
                case HeroType.Mage:
                    heroFactory = new MageFactory();
                    return heroFactory.CreateHero(name, race);
                case HeroType.Monk:
                    heroFactory = new MonkFactory();
                    return heroFactory.CreateHero(name, race);
                case HeroType.Paladin:
                    heroFactory = new PaladinFactory();
                    return heroFactory.CreateHero(name, race);
                case HeroType.Priest:
                    heroFactory = new PriestFactory();
                    return heroFactory.CreateHero(name, race);
                case HeroType.Rogue:
                    heroFactory = new RogueFactory();
                    return heroFactory.CreateHero(name, race);
                case HeroType.Warlock:
                    heroFactory = new WarlockFactory();
                    return heroFactory.CreateHero(name, race);
                case HeroType.Warrior:
                    heroFactory = new WarriorFactory();
                    return heroFactory.CreateHero(name, race);
                default:
                    return null;
            }
        }
    }
}
