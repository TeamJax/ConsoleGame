using System.ComponentModel;

namespace TeamJaxConsoleGame.Lib.Enumerations
{
    public enum RaceType
    {
        Tauren = 1, 
        Human, 
        [Description("Troll Programmer")]
        TrollProgrammer,
        [Description("Undead Developer")]
        UndeadDeveloper,
        [Description("Pandaren Lecturer")]
        PandarenLecturer, 
        [Description("Orc Net Ninja")]
        OrcNetNinja 
    }
}
