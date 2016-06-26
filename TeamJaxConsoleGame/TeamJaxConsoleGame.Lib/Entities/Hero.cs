namespace TeamJaxConsoleGame.Lib.Entities
{
    using System;
    using System.Collections.Generic;
    
    using Abilities;
    using Interfaces;
    using Skills;

    public class Hero : ItemHolder, IFighter
    {       
        public Hero(string name)
        {
            this.Name = name;
        }

        public int Health { get; set; }

        public int AttackDamage { get; set; }

        public int ArmorRating { get; set; }  

        public IList<ISkill> Skills { get; set; }

        public IList<Ability> Abilities { get; set; }

        public override string Describe()
        {
            return string.Format("You are {0}. Another great hero seeking fortune and fame in the land of Teleriknia.", this.Name);
        }
    }
}
