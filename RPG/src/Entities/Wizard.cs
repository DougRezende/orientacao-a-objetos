namespace RPG.src.Entities
{
    internal class Wizard : Hero
    {
        public Wizard(string name, int level, string heroType, int hp, int mp) : base(name, level, heroType, hp, mp)
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
                return Name + " Lançou magia super efetiva com bonus de " + bonus;
            }
            else
            {
                return Name + " Lançou magia com força fraca com bonus de " + bonus;
            }            
        }
    }
}
