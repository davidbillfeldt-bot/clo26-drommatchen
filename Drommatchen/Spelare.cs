public class Spelare
{
    // Privata fält
    private string _namn;
    private int _nummer;
    private string _position;

    // Properties — publik get, privat set

    public string Namn { get; private set; }


    public int Nummer { get; private set; }
    // Skapa get och privat set för Nummer

    public string Position { get; private set; }
    // Skapa get och privat set för Position


    // Konstruktor
    public Spelare(string namn, int nummer, string position);
       Spelare spelare1 = new Spelare("Faker", 7, "Midlane");
    Spelare spelare2 = new Spelare("Caps", 10, "Midlane");
        // TODO: tilldela de privata fälten
}
