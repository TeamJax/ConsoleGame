using TeamJaxConsoleGame.Lib.Enumerations;

namespace TeamJaxConsoleGame.Lib.Entities.Skills
{
    public class ActiveSkill : Skill
    {
        public ActiveSkill(string name, SkillType type, int successChance) 
            : base(name, type, successChance)
        {
        }
    }
}
