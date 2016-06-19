namespace TeamJaxConsoleGame.Lib.Entities
{
    public abstract class Skill : GameObject
    {
        public int EnergyNeeded { get; set; }

        public abstract void UseSkill();
    }
}