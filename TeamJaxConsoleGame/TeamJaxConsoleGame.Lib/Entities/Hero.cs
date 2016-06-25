namespace TeamJaxConsoleGame.Lib.Entities
{
    using System;
    using System.Collections.Generic;
    using Abilities;
    using Skills;

    public class Hero : Person
    {       
        public Hero(string name)
        {
            this.Name = name;
        }

        public int Health { get; set; }

        public IList<Skill> Skills { get; set; }

        public IList<Ability> Abilities { get; set; }
    }
}
