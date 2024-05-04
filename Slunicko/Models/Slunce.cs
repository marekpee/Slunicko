namespace Slunicko.Models
{
    public class Slunce
    {
        public Slunce() {
            AktualniPozice = 0;
        }
        public int AktualniPozice {  get; private set; }
        private int IndexDalsi { get; set; } = 1;
        public List<Vlastnosti> VlastnostiList { get; private set; } = new List<Vlastnosti>();
        public void PridejPozici(int stupne, int velikost, int doba)
        {
            var pom = new Vlastnosti(stupne, velikost, doba);
            VlastnostiList.Add(pom);
        }
        public string Style { get
            {
                if (AktualniPozice < 0)
                {
                    return "";
                } else
                {
                    var poz = VlastnostiList[AktualniPozice];
                    AktualniPozice++;
                    return poz.Style;
                    
                }
            }
        }
       /* public void Presun()
        {
            if (AktualniPozice == 0)
            {
                AktualniPozice++;
            }
            else
            {
                AktualniPozice--;
            }
        }
         */
        public void Presun()
        {
            if (AktualniPozice == VlastnostiList.Count)
            {
                AktualniPozice = 0;
            }
        }
        }
        
    }

