namespace AhVerwaltung.Model
{
    public class Kunden
    {
        public int Kdnr { get; set; }
        public string Kurzname { get; set; }
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public DateTime Geburtsdatum { get; set; }
        public string persoNr { get; set; }
        public string FührerscheinNr { get; set; }
        public string Email { get; set; }
        public string TelNr { get; set; }
    }
}
