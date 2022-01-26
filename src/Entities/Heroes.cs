using System;

namespace Projeto_RPG.src
{
    public abstract class Heroes
    {
        public string heroName {get; set;}
        public int heroLevel {get; set;}
        public int heroHP {get; set;}
        public int heroMP {get; set;}

        /*
        public Heroes(string heroName, int heroLevel, 
        int heroHP, int heroMP)
        {
            this.heroName = heroName;
            this.heroLevel = heroLevel;
            this.heroHP = heroHP;
            this.heroMP = heroMP;
        }
        /*
        public override string ToString()
        {
            string newHero = "";
            newHero += "Nome do Heroi: " + this.heroName + Environment.NewLine;
            newHero += "Level do Heroi : " + this.heroLevel + Environment.NewLine;
            newHero += "HP do Heroi: " + this.heroHP + Environment.NewLine;
            newHero += "MP do Heroi: " + this.heroMP + Environment.NewLine;
            return newHero;
        }
        */

        public override string ToString(){
            return this.heroName + " " + this.heroLevel + " " + this.heroHP + " " + this.heroMP;
        }

        public virtual string Attack(){
            return this.heroName + " atacou.";
        }

        public virtual string Defense(){
            return this.heroName + " defendeu";
        }

        public virtual string heathPoints(){           
            return "A pontuação da vida de " + this.heroName + " é " + this.heroHP;
        }


        
    }

}