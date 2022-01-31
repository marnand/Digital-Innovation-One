namespace dotnet_poo.src.Entities
{
    public class Wizard : Hero 
    {
        public Wizard() {}

        public Wizard(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public override string Attack()
        {
            return this.Name + " Lançou magia.";
        }
        
        public string Attack(int bonus)
        {
            if(bonus > 6)
            {
                return this.Name + " Lançou magia super efetiva com bonus de " + bonus;
            }

            return this.Name + " Lançou magia com bonus de " + bonus;
        }
    }
}