using AhVerwaltung.Model;

namespace AhVerwaltung.Data
{
    public class RückgabeformularData
    {
        Rückgabeformular rückgabeformular1 = new Rückgabeformular()
        {
            RückgabeFormularNr = 1,
            Anhänger = new Model.Anhänger() { Kennzeichen = "" },
            Vertrag = new Vertrag() { VertragsNr = 1 },
            Vertragskunden = new Kunden() { Kurzname = "BGa" }
        };
        Rückgabeformular rückgabeformular2 = new Rückgabeformular()
        {
            RückgabeFormularNr = 2,
            Anhänger = new Anhänger() { Kennzeichen = "" },
            Vertrag = new Vertrag() { VertragsNr = 1 },
            Vertragskunden = new Kunden() { Kdnr = 1 }
        };
        Rückgabeformular rückgabeformular3 = new Rückgabeformular()
        {
            RückgabeFormularNr = 3,
            Anhänger = new Anhänger() { Kennzeichen = "" },
            Vertrag = new Vertrag() { VertragsNr = 1 },
            Vertragskunden = new Kunden() { Kdnr = 1 }
        };
        Rückgabeformular rückgabeformular4 = new Rückgabeformular()
        {
            RückgabeFormularNr = 4,
            Anhänger = new Anhänger() { Kennzeichen = "" },
            Vertrag = new Vertrag() { VertragsNr = 1 },
            Vertragskunden = new Kunden() { Kdnr = 1 }
        };
        Rückgabeformular rückgabeformular5 = new Rückgabeformular()
        {
            RückgabeFormularNr = 5,
            Anhänger = new Anhänger() { Kennzeichen = "" },
            Vertrag = new Vertrag() { VertragsNr = 1 },
            Vertragskunden = new Kunden() { Kdnr = 1 }
        };

        public static List<Rückgabeformular> GetRückgabeformular()
        {
            List<Rückgabeformular> rückgabeListe = new();
            rückgabeListe.Add(new Rückgabeformular()
            {
                RückgabeFormularNr = 1,
                Anhänger = new Anhänger() { Kennzeichen = "" },
                Vertrag = new Vertrag() { VertragsNr = 1 },
                Vertragskunden = new Kunden() { Kurzname = "BGa" }
            });
            rückgabeListe.Add(new Rückgabeformular()
            {
                RückgabeFormularNr = 2,
                Anhänger = new Anhänger() { Kennzeichen = "" },
                Vertrag = new Vertrag() { VertragsNr = 1 },
                Vertragskunden = new Kunden() { Kurzname = "MZu" }
            });
            rückgabeListe.Add(new Rückgabeformular()
            {
                RückgabeFormularNr = 3,
                Anhänger = new Anhänger() { Kennzeichen = "" },
                Vertrag = new Vertrag() { VertragsNr = 1 },
                Vertragskunden = new Kunden() { Kurzname = "BOb" }
            });
            rückgabeListe.Add(new Rückgabeformular()
            {
                RückgabeFormularNr = 4,
                Anhänger = new Anhänger() { Kennzeichen = "" },
                Vertrag = new Vertrag() { VertragsNr = 1 },
                Vertragskunden = new Kunden() { Kurzname = "CMa" }
            });
            rückgabeListe.Add(new Rückgabeformular()
            {
                RückgabeFormularNr = 5,
                Anhänger = new Anhänger() { Kennzeichen = "" },
                Vertrag = new Vertrag() { VertragsNr = 1 },
                Vertragskunden = new Kunden() { Kurzname = "JWh" }
            });
            return rückgabeListe;
        }
    }
}
