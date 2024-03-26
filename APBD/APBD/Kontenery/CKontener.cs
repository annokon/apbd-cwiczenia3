using APBD.Exceptions;

namespace APBD;

public class CKontener : Kontener
{
    public string RodzajProduktu { get; set; }
    public double Temperatura { get; set; } // w stopniach Celsiusza

    public CKontener(double wagaWlasna, int wysokosc, double glebokosc, double maksymalnaLadownosc,
        string rodzajProduktu, double temperatura)
        : base(wagaWlasna, wysokosc, glebokosc, maksymalnaLadownosc)
    {
        RodzajProduktu = rodzajProduktu;
        Temperatura = temperatura;
    }

    public override void ZaladowanieLadunku(string typLadunku, int masaLadunku)
    {
        if (masaLadunku > maksymalnaLadownosc)
        {
            throw new OverfillException($"Przekroczono maksymalną ładowność kontenera chłodniczego {numerSeryjny}");
        }
        else if (!typLadunku.Equals(RodzajProduktu))
        {
            Notify($"Kontener przechowuje {RodzajProduktu}, a zostały włożone {typLadunku}");
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