namespace TeamJaxConsoleGame.Lib.Entities.Skills
{
    using System;
    using Interfaces;
    using Skills.Abstract;
    using Enumerations;

    public class ActiveSkill : Skill, IActivatable, IGameObject
    {
        public int Power { get; set; }

        public ActiveSkill(string name, int power, int successChance, string description)
            : base(name, successChance, description)
        {
            this.Power = power;
        }

        public void Activate(IFighter target)
        {
            var primarySkill = target.PrimaryStats;

            switch (primarySkill)
            {
                case PrimaryHeroStatsType.Strength:
                    target.Strenght += this.Power;
                    break;
                case PrimaryHeroStatsType.Intelligence:
                    target.Intelligence += this.Power;
                    break;
                case PrimaryHeroStatsType.Agility:
                    target.Agility += this.Power;
                    break;
                case PrimaryHeroStatsType.AttackDamage:
                    target.AttackDamage += this.Power;
                    break;
                default:
                    throw new InvalidOperationException();
            }
        }
    }
}
