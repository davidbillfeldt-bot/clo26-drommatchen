using System;

public class Spelare
{
    public string Namn { get; private set; }
    public int Nummer { get; private set; }
    public string Position { get; private set; }

    public Spelare(string namn, int nummer, string position)
    {
        Namn = namn;
        Nummer = nummer;
        Position = position;
    }
}

public class Match
{
    public string Hemmalag { get; private set; }
    public string Bortalag { get; private set; }
    public string Datum { get; private set; }

    public Match(string hemmalag, string bortalag, string datum)
    {
        Hemmalag = hemmalag;
        Bortalag = bortalag;
        Datum = datum;
    }

    public void Presentera()
    {
        Console.WriteLine($"{Hemmalag} mot {Bortalag} - {Datum}");
    }

    public string AnnounceraMålskytt(Spelare spelare)
    {
        Console.WriteLine($"{spelare.Namn} {spelare.Nummer} {spelare.Position}");
        return spelare.Namn;
    }
}