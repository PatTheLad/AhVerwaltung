using AhVerwaltung.Model;
using AhVerwaltung.Pages;

namespace AhVerwaltung.Data
{
    public class VerträgeData
    {
        public List<Vertrag> GetVerträge(int anzahl)
        {
            Random rndm = new();
            List<Vertrag> tmpList = new();
            int count = 0;
            while(anzahl > count)
            {
                tmpList.Add(new Vertrag() { VertragsNr = rndm.Next(1, 999), Kdnr = rndm.Next(1, 999), RückgabeformularNr = rndm.Next(1, 999), AnhängerNr = rndm.Next(1, 999) });
                count++;
            }
            return tmpList;
        }
    }
}
