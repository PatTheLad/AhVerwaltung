using AhVerwaltung.Model;

namespace AhVerwaltung.Data
{
    public class RückgabeformularData
    {
        public static List<Rückgabeformular> GetRueckgabeformular(int anzahl)
        {
            Random rndm = new();
            List<Rückgabeformular> tmpList = new();
            int count = 0;
            while (anzahl > count)
            {
                tmpList.Add(new Rückgabeformular() { RückgabeFormularNr = rndm.Next(1, 999), Anhänger = new Anhänger() { Kennzeichen = $"OE-AB-{rndm.Next(1, 999)}" }, Vertrag = new Vertrag() { VertragsNr = rndm.Next(1, 999) }, Vertragskunden = new Kunden() { Kdnr = rndm.Next(1, 999) } });
                count++;
            }
            return tmpList;
        }
    }
}
