namespace dotnet_poo.src.Entities
{
    public class Knight : Hero 
    {
        public Knight() {}

        public Knight(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
    }
}