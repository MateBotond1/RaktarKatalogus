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

Console.WriteLine($"{osszes.Count}");