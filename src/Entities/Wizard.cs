namespace Projeto_RPG.src
{
    public class Wizard : Heroes
    {   
        
        public Wizard(string heroName, int heroLevel, 
        int heroHP, int heroMP)
        {
            this.heroName = heroName;
            this.heroLevel = heroLevel;
            this.heroHP = heroHP;
            this.heroMP = heroMP;
        }
        public override string Attack(){
           return this.heroName + " - " + "Lançou sua Magia!"; 
        }

        public override string Defense(){
            return this.heroName + " - " + "Se defendeu com escudo mágico!";
        }

        public string Attack(int Bonus){
            if (Bonus >= 4){
                return this.heroName + " - " + "Lançou sua Magia de " + Bonus; 
            } else {
                return this.heroName + " - " + "Falhou ao lançar a magia de " + Bonus; 
            }
        }
    }
}