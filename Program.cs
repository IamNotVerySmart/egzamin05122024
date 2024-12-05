using egzamin0512;
List<osoba> osobas = new List<osoba>();
using (var reader = new StreamReader(@"dane_pracownikow.csv"))
{
    while(!reader.EndOfStream)
    {
        var data = reader.ReadLine().Split(",");
        if (data[0] != "Imię" & data[1] != "Nazwisko" & data[2] != "Pensja")
            osobas.Add(new osoba(data[0], data[1], int.Parse(data[2])));
    }

    foreach (var osoba in osobas)
        Console.WriteLine(osoba.ToString());
}

using (var writer = new StreamWriter(@"filtrowani_pracownicy.csv"))
{
    List<osoba> humans = osoba.humans(osobas);
    foreach(var h in humans)
    {
        writer.WriteLine(h.ToString());
    }
    Console.WriteLine("AAAAAAAAAA");
}