namespace RPG.src.Entities
{
    internal class Knight : Hero 
    {
        public Knight(string name, int level, string heroType, int hp, int mp) : base(name, level, heroType, hp, mp)
        {
            Name = name;
            Level = level;
            HeroType = heroType;
            Hp = hp;
            Mp = mp;
        }
    }
}
