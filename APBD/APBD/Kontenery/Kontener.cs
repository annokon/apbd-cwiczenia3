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
    public string typLadunku { get; set; }


    public Kontener(double wagaWlasna, int wysokosc, double glebokosc, double maksymalnaLadownosc)
    {
        this.wagaWlasna = wagaWlasna;
        this.wysokosc = wysokosc;
        this.glebokosc = glebokosc;
        this.maksymalnaLadownosc = maksymalnaLadownosc;

        Random rand = new Random();
        numerSeryjny = "KON-" + GetType().Name[0] + "-" + rand.Next(1, 1000).ToString("D3");
    }

    public virtual void OproznianieLadunku()
    {
        masaLadunku = 0;
        typLadunku = null;
    }

    public virtual void ZaladowanieLadunku(string typLadunku, int masaLadunku)
    {
        if (masaLadunku > maksymalnaLadownosc)
        {
            throw new OverfillException("Przekroczono maksymalną wagę.");
        }

        this.masaLadunku = masaLadunku;
    }
}