namespace Drommatchen
{
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

    public class Program
    {
        public static void Main()
        {
            Spelare spelare1 = new Spelare("Faker", 7, "Midlane");
            Spelare spelare2 = new Spelare("Caps", 10, "Midlane");

            Match match1 = new Match("T1", "G2", "2026-09-17");

            match1.Presentera();
            Console.WriteLine();

            match1.AnnounceraMålskytt(spelare1);
            match1.AnnounceraMålskytt(spelare2);
        }
    }
}