namespace TeamJaxConsoleGame.Lib.Entities.Skills
{
    using System.Collections.Generic; 
    using System.Linq;
    using Interfaces;
    using Skills.Abstract;

    public class ActiveSkill : Skill, IActivatable, IGameObject
    {
        public int Power { get; set; }

        public ActiveSkill(string name, int power, int successChance)
            : base(name, successChance)
        {
            this.Power = power;
        }

        public void Activate(IFighter target)
        {
            

            //todo get strongest stats and apply to this stats
           /* switch (this.Type)
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
            }*/
        }
    }
}
