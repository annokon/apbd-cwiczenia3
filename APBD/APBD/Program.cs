using APBD;

Kontenerowiec kontenerowiec = new Kontenerowiec(30, 10);

LKontener kontener1 = new LKontener(500, 200, 300, 1000);
kontener1.ZaladowanieLadunku("mleko", 50);
kontenerowiec.DodajKontener(kontener1);

GKontener kontener2 = new GKontener(600, 250, 350, 1500, 2);
kontener2.ZaladowanieLadunku("azot", 100);
kontenerowiec.DodajKontener(kontener2);

CKontener kontener3 = new CKontener(700, 300, 400, 2000, "mięso", 2);
kontener3.ZaladowanieLadunku("mięso", 75);
kontenerowiec.DodajKontener(kontener3);

Console.WriteLine($"Łączna masa ładunku na kontenerowcu: {kontenerowiec.ObliczLacznaMaseLadunku()} kg");

kontener1.ZaladowanieLadunku("mleko", 901);
kontener1.OproznianieLadunku();
kontener1.ZaladowanieLadunku("paliwo", 550);

kontener2.OproznianieLadunku();
Console.WriteLine($"Masa kontenera {kontener2.numerSeryjny} po opróżnieniu: " + kontener2.masaLadunku);

kontener3.ZaladowanieLadunku("banany", 200);

List<Kontener> kontenery = new List<Kontener>();
kontenery.Add(kontener2);
kontenery.Add(kontener3);

Kontenerowiec kontenerowiec2 = new Kontenerowiec(50, 5);
kontenerowiec2.DodajKontenery(kontenery);
Console.WriteLine(kontenerowiec2.ObliczLacznaMaseLadunku());

kontenerowiec2.ZastapKontener(kontener2, kontener1);
Console.WriteLine(kontenerowiec2.ObliczLacznaMaseLadunku());

kontenerowiec2.Rozladowanie();