namespace TeamJaxConsoleGame.Lib.Entities
{
    using Interfaces;

    public class Enemy : ItemHolder, IFighter
    {
        public Enemy(string name, int armorRating, int attackDamage, int health)
        {
            this.ArmorRating = armorRating;
            this.Health = health;
            this.AttackDamage = attackDamage;
            this.Name = name;
        }

        public int Agility { get; set; }

        public int ArmorRating { get; set; }

        public int AttackDamage { get; set; }

        public int Health { get; set; }

        public int Intelligence { get; set; }

        public int Stamina { get; set; }

        public int Strenght { get; set; }
    }
}
