using System;
using Projeto_RPG.src;
using Projeto_RPG.src.Entities;
using static System.Console;

namespace Projeto_RPG
{
    class Program
    {
        static void Main(string[] args)
        {

            Warrior Daimon = new Warrior("Daimon", 15, 250, 75);
            Wizard Janna = new Wizard("Janna", 14, 175, 210);
            Wizard Peter = new Wizard("Peter", 16, 185, 250);
            Knight Dimas = new Knight("Dimas", 20, 250, 125);

            Console.WriteLine($@"{Daimon.heroName} sacou sua espada.");
            Console.WriteLine(Daimon.Attack());

            Console.WriteLine($@"{Janna.heroName} pegou seu cajado.");
            Console.WriteLine(Janna.Attack(3));
            Console.WriteLine(Janna.Defense());

            Console.WriteLine($@"{Peter.heroName} pegou seu cajado.");
            Console.WriteLine(Peter.Attack(5));

            Console.WriteLine($@"{Dimas.heroName} sacou sua espada para a batalha!");
            Console.WriteLine(Dimas.Defense());

            Console.WriteLine(Dimas.heathPoints());

        }
    }
}
