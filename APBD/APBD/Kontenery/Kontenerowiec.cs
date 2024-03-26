namespace APBD;

public class Kontenerowiec
{
    private List<Kontener> _kontenery = new List<Kontener>();

    public int maksymalnaPredkosc { get; set; } // w węzłach
    public int maksymalnaLiczbaKontenerow { get; set; }

    public Kontenerowiec(int maksymalnaPredkosc, int maksymalnaLiczbaKontenerow)
    {
        this.maksymalnaPredkosc = maksymalnaPredkosc;
        this.maksymalnaLiczbaKontenerow = maksymalnaLiczbaKontenerow;
    }

    public void DodajKontener(Kontener kontener)
    {
        if (_kontenery.Count >= maksymalnaLiczbaKontenerow)
        {
            throw new Exception(
                "Nie można dodać więcej kontenerów, przekroczono maksymalną liczbę kontenerów na kontenerowcu.");
        }
        else
        {
            _kontenery.Add(kontener);
        }
    }

    public List<Kontener> PobierzKontenery()
    {
        return _kontenery;
    }

    public double ObliczLacznaMaseLadunku()
    {
        double suma = 0;
        foreach (Kontener kontener in _kontenery)
        {
            suma += kontener.masaLadunku;
        }

        return suma;
    }

    public void UsunKontener(Kontener kontener)
    {
        _kontenery.Remove(kontener);
    }

    public void ZastapKontener(Kontener kontener1, Kontener kontener2)
    {
        _kontenery.Add(kontener2);
        _kontenery.Remove(kontener1);
    }

    public void DodajKontenery(List<Kontener> kontenery)
    {
        foreach(Kontener kontener in kontenery)
        {
            _kontenery.Add(kontener);
        }
    }

    public void Rozladowanie()
    {
        _kontenery.Clear();
    }
}