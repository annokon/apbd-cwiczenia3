using APBD.Exceptions;
using APBD.Interfaces;

namespace APBD;

public class GKontener : Kontener, IHazardNotifier
{
    public double Cisnienie { get; set; }

    public GKontener(double wagaWlasna, int wysokosc, double glebokosc, double maksymalnaLadownosc, double cisnienie)
        : base(wagaWlasna, wysokosc, glebokosc, maksymalnaLadownosc)
    {
        Cisnienie = cisnienie;
    }

    public override void ZaladowanieLadunku(string typLadunku, int masaLadunku)
    {
        if (masaLadunku > maksymalnaLadownosc)
        {
            throw new OverfillException($"Przekroczono maksymalną ładowność kontenera na gaz {numerSeryjny}");
        }
        else
        {
            base.ZaladowanieLadunku(typLadunku, masaLadunku);
        }
    }

    public override void OproznianieLadunku()
    {
        masaLadunku = masaLadunku * 0.05;
        typLadunku = typLadunku;
    }

    public void Notify(string message)
    {
        Console.WriteLine($"Niebezpieczna sytuaja: {message} w kontenerze {numerSeryjny}");
    }
}