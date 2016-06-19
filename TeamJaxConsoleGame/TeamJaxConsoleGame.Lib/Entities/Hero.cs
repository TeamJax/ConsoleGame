namespace TeamJaxConsoleGame.Lib.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Hero : Person
    {
        public Hero(string name)
        {
            this.Name = name;
        }

        public IList<Skill> Skills { get; set; }

    }
}
