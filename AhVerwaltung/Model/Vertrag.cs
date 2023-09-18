
namespace AhVerwaltung.Model
{
    public class Vertrag
    {
        public int VertragsNr { get; set; }
        public Anhänger Anhänger { get; set; }
        public Rückgabeformular Rückgabeformular { get; set; }
        public Kunden Vertragskunden { get; set; }
    }
}
