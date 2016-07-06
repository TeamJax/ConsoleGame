namespace TeamJaxConsoleGame.Lib.Entities.Skills
{
    using Interfaces;

    public class PassiveSkill : Skill, IGameObject
    {
        public PassiveSkill(string name, int successChance)
            : base(name, successChance)
        {

        }
    }
}
