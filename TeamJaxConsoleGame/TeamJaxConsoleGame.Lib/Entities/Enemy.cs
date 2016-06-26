using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamJaxConsoleGame.Lib.Interfaces;

namespace TeamJaxConsoleGame.Lib.Entities
{
    public class Enemy : ItemHolder, IFighter
    {
        public Enemy(string name, int armorRating, int attackDamage, int health)
        {
            this.ArmorRating = armorRating;
            this.Health = health;
            this.AttackDamage = attackDamage;
            this.Name = name;
        }

        public int ArmorRating { get; set; }

        public int AttackDamage { get; set; }

        public int Health { get; set; }
    }
}
