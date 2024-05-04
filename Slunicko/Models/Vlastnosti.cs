namespace Slunicko.Models
{
    public class Vlastnosti
    {
        public Vlastnosti(int stupne, int velikost, int doba) { 
            Stupne = stupne;
            Velikost = velikost;
            Doba = doba;
        }
        public int Stupne { get; }
        public int Velikost { get; }
        public int Doba { get; }
        public string Style => $"rotate: {Stupne}deg; width: {Velikost}px; transition: {Doba}s";
    }
}
