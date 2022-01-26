namespace Projeto_RPG.src.Entities
{
    public class Knight : Heroes
    {
        public Knight(string heroName, int heroLevel, 
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
        public override string Defense(){
            return this.heroName + " - " + "Usou seu escudo para se defender!";
        }

        public override string heathPoints(){           
            return "A pontuação da vida de " + this.heroName + " é " + this.heroHP;
        }
        
    }
}