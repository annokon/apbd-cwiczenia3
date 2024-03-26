using APBD.Exceptions;
using APBD.Interfaces;

namespace APBD;

public class LKontener : Kontener, IHazardNotifier
{
    public string typLadunku;

    public LKontener(double wagaWlasna, int wysokosc, double glebokosc, double maksymalnaLadownosc)
        : base(wagaWlasna, wysokosc, glebokosc, maksymalnaLadownosc)
    {
    }

    public override void ZaladowanieLadunku(string typLadunku, int masaLadunku)
    {
        if (masaLadunku > maksymalnaLadownosc)
        {
            throw new OverfillException($"Przekroczono pojemność kontenera na płyny {numerSeryjny}.");
        }
        else if (typLadunku.Equals("mleko") && masaLadunku > maksymalnaLadownosc * 0.9)
        {
            Notify("Przekroczenie pojemności bezpiecznego ładunku");
        }
        else if (typLadunku.Equals("paliwo") && masaLadunku > maksymalnaLadownosc * 0.5)
        {
            Notify("Przekroczenie pojemności niebezpiecznego ładunku");
        }
        else
        {
            base.ZaladowanieLadunku(typLadunku, masaLadunku);
        }
    }

    public void Notify(string message)
    {
        Console.WriteLine($"Niebezpieczna sytuaja: {message} w kontenerze {numerSeryjny}");
    }
}