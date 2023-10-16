using AhVerwaltung.Model;

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
                int vertragsdauer = rndm.Next(1, 2000);
                tmpList.Add(new Vertrag() { 
                    VertragsNr = count+1, 
                    Kdnr = rndm.Next(1, 999), 
                    RückgabeformularNr = rndm.Next(1, 999), 
                    AnhängerNr = rndm.Next(1, 999), 
                    AbschlussDatum = DateTime.Now.AddDays(-rndm.Next(1, 3000)),
                    Vertragsdauer = vertragsdauer,
                    Preis = rndm.Next(5, 20) * vertragsdauer
                });
                count++;
            }
            return tmpList;
        }
    }
}
