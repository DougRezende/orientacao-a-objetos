namespace RPG.src.Entities
{
    internal class Ninja : Hero
    {
        public Ninja(string name, int level, string heroType, int hp, int mp) : base(name, level, heroType, hp, mp)
        {
            Name = name;
            Level = level;
            HeroType = heroType;
            Hp = hp;
            Mp = mp;
        }

        public override string Attack()
        {
            return Name + " Lançou magia!";
        }

        public string Attack(int bonus)
        {
            if(bonus > 6)
            {
                return Name + " Lançou uma estrela ninja super efetiva com bonus de " + bonus;
            }
            else
            {
                return Name + " Lançou estrela ninja com força fraca com bonus de " + bonus;
            }            
        }
    }
}
