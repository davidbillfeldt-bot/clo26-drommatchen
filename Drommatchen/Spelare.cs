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
public class Program
{
    public static void Main()
    {
        Match match1 = new Match("T1", "G2", "2026-09-17");
        Spelare spelare1 = new Spelare("Faker", 7, "Midlane");
        Spelare spelare2 = new Spelare("Caps", 10, "Midlane");
        match1.Presentera();
        Console.WriteLine();
        string v = match1.AnnounceraKillLeader("Nya killeader T1 Faker nr.7 " + spelare1.Namn);
    }
}
