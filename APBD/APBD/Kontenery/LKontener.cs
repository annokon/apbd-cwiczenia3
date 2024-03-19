namespace APBD;

public class LKontener : Kontener
{
    public LKontener(double wagaWlasna, int wysokosc, double glebokosc, double maksymalnaLadownosc) : base(wagaWlasna, wysokosc, glebokosc, maksymalnaLadownosc)
    {
        
    }
    
    public override void ZaladowanieLadunku(int masaLadunku)
    {
        base.ZaladowanieLadunku(masaLadunku);
    }
}