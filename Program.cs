using RaktarKatalogus;

List<Termek> osszes = new List<Termek>();
Console.WriteLine("=== Raktárkészlet Rögzítése ===\n");

for (int i = 0; i<3; i++)
{
    Console.WriteLine($"Kérem az {i + 1}. termék adatait:");
    Termek ujTermek = new Termek();
    Console.Write("\tNév: ");
    ujTermek.Nev = Console.ReadLine();
    Console.Write("\tEgységár (Ft): ");
    ujTermek.Ar = int.Parse(Console.ReadLine());
    Console.Write("\tRaktárkészlet (db): ");
    ujTermek.Mennyiseg = int.Parse(Console.ReadLine());
    
    osszes.Add(ujTermek);
    Console.WriteLine();
}
int osszertek = osszes[0].Ar * osszes[0].Mennyiseg + osszes[1].Ar * osszes[1].Mennyiseg + osszes[2].Ar * osszes[2].Mennyiseg;
double atlag = (osszes[0].Ar + osszes[1].Ar + osszes[2].Ar) / osszes.Count;
