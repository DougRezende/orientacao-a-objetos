using RPG.src.Entities;

namespace RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero arus = new Knight("Arus", 42, "Knight", 749, 72);
            Wizard jennica = new Wizard("Jennica", 42, "White Wizard", 601, 482);
            Ninja wedge = new Ninja("Wedge", 42, "Ninja", 574, 89);
            Wizard topapa = new Wizard("Topapa", 42, "Black Wizard", 385, 641);


            Console.WriteLine(arus);
            Console.WriteLine(arus.Attack());

            Console.WriteLine(jennica);
            Console.WriteLine(jennica.Attack(1));
            Console.WriteLine(jennica.Attack(7));

            Console.WriteLine(wedge);
            Console.WriteLine(wedge.Attack(1));
            Console.WriteLine(wedge.Attack(7));

            Console.WriteLine(topapa);
            Console.WriteLine(topapa.Attack(1));
            Console.WriteLine(topapa.Attack(7));
        }
    }
}