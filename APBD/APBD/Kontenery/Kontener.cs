using APBD.Exceptions;
using APBD.Interfaces;

namespace APBD;

public class Kontener : IKontener
{
    public double masaLadunku { get; set; } //w kilogramach
    public int wysokosc { get; set; } //w centymetrach
    public double wagaWlasna { get; set; } //waga samego kontenera, w kilogramach
    public double glebokosc { get; set; } //w centymetrach
    public string numerSeryjny { get; set; } //KON-C-1
    public double maksymalnaLadownosc { get; set; } //w kilogramach
    

    public Kontener(double wagaWlasna, int wysokosc, double glebokosc, double maksymalnaLadownosc)
    {
        this.wagaWlasna = wagaWlasna;
        this.wysokosc = wysokosc;
        this.glebokosc = glebokosc;
        this.maksymalnaLadownosc = maksymalnaLadownosc;
    }

    public void OproznianieLadunku()
    {
        throw new NotImplementedException();
    }

    public virtual void ZaladowanieLadunku(int masaLadunku)
    {
        this.masaLadunku = masaLadunku;
        throw new OverfillException();
    }
}