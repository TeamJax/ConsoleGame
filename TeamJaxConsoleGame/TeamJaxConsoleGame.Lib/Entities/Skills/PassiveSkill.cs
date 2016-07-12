namespace TeamJaxConsoleGame.Lib.Entities.Skills
{
    using Interfaces;
    using Skills.Abstract;

    public class PassiveSkill : Skill, IGameObject
    {
        public PassiveSkill(string name, int successChance, string description)
            : base(name, successChance, description)
        {

        }
    }
}
