using Slunicko.Models;

namespace Slunicko.Pages;

public partial class Home
{
    protected override void OnInitialized()
    {
        base.OnInitialized();
        Slunce = new Slunce();
        Slunce.PridejPozici(stupne: 180, velikost: 300, doba: 5);
        Slunce.PridejPozici(stupne: 360, velikost: 150, doba: 5);
    }
    public Slunce Slunce { get; set; }
    /*private void Inicializace() { 
        
    }
    */
}
