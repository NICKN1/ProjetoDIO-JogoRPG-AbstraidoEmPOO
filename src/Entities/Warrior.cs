using System;
namespace Projeto_RPG.src

{
    public class Warrior : Heroes
    {
        public Warrior(string heroName, int heroLevel, 
        int heroHP, int heroMP)
        {
            this.heroName = heroName;
            this.heroLevel = heroLevel;
            this.heroHP = heroHP;
            this.heroMP = heroMP;
        }
        public override string Attack(){
           return this.heroName + " - " + "Atacou com sua espada!"; 
        }
    }
}