namespace TeamJaxConsoleGame.Lib.Entities.Skills
{
    using Interfaces;
    using Enumerations;

    public class ActiveSkill : Skill, IAbility, IGameObject
    {
        public ActiveSkillTypes Type { get; set; }

        AbilityType IAbility.Type { get; set; }

        public int ResourceCost { get; set; }

        public int AbilityPower { get; set; }

        public string Description { get; set; }

        public ActiveSkill(string name, int power, int successChance, ActiveSkillTypes type)
            : base(name, power, successChance)
        {
            this.Type = type;
        }

        public void Activate(IFighter target)
        {
            switch (this.Type)
            {
                case ActiveSkillTypes.Haste:
                    target.Agility += this.Power;
                    break;
                case ActiveSkillTypes.Aggression:
                    target.Strenght += this.Power;
                    break;
                case ActiveSkillTypes.Adrenaline:
                    target.AttackDamage += this.Power;
                    break;
                default:
                    break;
            }
        }
    }
}
