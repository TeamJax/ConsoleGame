namespace TeamJaxConsoleGame.Lib.Entities.Skills
{
    public abstract class Skill : GameObject
    {
        public string Description { get; set; }   

        public Skill(string name)
        {
            this.Name = name;
        }
    }
}