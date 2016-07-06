namespace TeamJaxConsoleGame.Lib.Entities.Skills
{
    using Interfaces;

    public class ActiveSkill : Skill, IActivatable, IGameObject
    {
        public ActiveSkill(string name, int successChance) 
            : base(name, successChance)
        {
        }

        public void Activate(IFighter target)
        {
            
        }
    }
}
