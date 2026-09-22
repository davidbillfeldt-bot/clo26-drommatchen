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
}