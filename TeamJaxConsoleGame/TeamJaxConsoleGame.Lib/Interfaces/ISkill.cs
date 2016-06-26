namespace TeamJaxConsoleGame.Lib.Interfaces
{
    using Enumerations;

    public interface ISkill
    {        
        SkillType Type { get; set; }

        int SuccessChance { get; set; }
    }
}
