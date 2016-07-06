using TeamJaxConsoleGame.Lib.Enumerations;

namespace TeamJaxConsoleGame.Lib.Entities.Skills
{
    public class PassiveSkill : Skill
    {
        public PassiveSkill(string name, SkillType type, int successChance)
            : base(name, type, successChance)
        {

        }
    }
}
