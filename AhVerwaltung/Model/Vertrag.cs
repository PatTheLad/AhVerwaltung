
namespace AhVerwaltung.Model
{
    public class Vertrag
    {
        public int VertragsNr { get; set; }
        public string KurzName { get; set; }
        public int RückgabeformularNr { get; set; }
        public string Kennzeichen { get; set; }
        public DateTime AbschlussDatum { get; set; }
        public int Vertragsdauer { get; set; }
        public int Preis { get; set; }
    }
}
