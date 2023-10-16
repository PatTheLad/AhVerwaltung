
namespace AhVerwaltung.Model
{
    public class Vertrag
    {
        public int VertragsNr { get; set; }
        public int Kdnr { get; set; }
        public int RückgabeformularNr { get; set; }
        public int AnhängerNr { get; set; }
        public DateTime AbschlussDatum { get; set; }
        public int Vertragsdauer { get; set; }
        public int Preis { get; set; }
    }
}
