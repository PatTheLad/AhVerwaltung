namespace AhVerwaltung.Model
{
    public class Rückgabeformular
    {
        public int RückgabeFormularNr { get; set; }
        public Anhänger Anhänger { get; set; }
        public Vertrag Vertrag { get; set; }
        public Kunden Vertragskunden { get; set; }
    }
}
