namespace RPG.src.Entities
{
    public abstract class Hero
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public string HeroType { get; set; }
        public int Hp { get; set; }
        public int Mp { get; set; }

        public Hero (string name, int level, string heroType, int hp, int mp)
        {
            Name = name;
            Level = level;
            HeroType = heroType;
            Hp = hp;
            Mp = mp;
        }

        protected Hero(string name, int level, string heroType)
        {
            Name = name;
            Level = level;
            HeroType = heroType;
        }

        public override string ToString()
        {
            return "Name: " + Name 
                + " Level: " + Level
                + " Type: " + HeroType
                + " HP: " + Hp
                + " MP: " + Mp;
        }

        public virtual string Attack()
        {
            return Name + " Atacou com a sua espada!";
        }
    }
}
