using System.Threading;

namespace Projekt_Spritzgussproduktion
{
    public class ProzesseFenster
    {
        public static bool Auftrag, Lieferschein, Mitarbeiter, User, Kunde, FirmenKontakt, Lager, Produkte, Rohstoffe;
        public static string FensterID
        {
            get { return FensterID; }
            set { _FensterID = value; }
        } 
        private static string _FensterID;
        
        public static string FensterBez
        {
            get { return FensterBez; }
            set { _FensterBez = value; }
        } 
        private static string _FensterBez;
        
        public static void FensterErkennung()
        {
            switch (FensterBez)
            {
                case "Auftrag":
                    Auftrag = true;
                    break;
                case "Lieferschein":
                    Lieferschein = true;
                    break;
                case "Mitarbeiter":
                    Mitarbeiter = true;
                    break;
                case "User":
                    User = true;
                    break;
                case "Kunde":
                    Kunde = true;
                    break;
                case "FirmenKontakt":
                    FirmenKontakt = true;
                    break;
                case "Lager":
                    Lager = true;
                    break;
                case "Produkte":
                    Produkte = true;
                    break;
                case "Rohstoffe":
                    Rohstoffe = true;
                    break;
                default:
                    Auftrag = false;
                    Lieferschein = false;
                    Mitarbeiter = false;
                    User = false;
                    Kunde = false;
                    FirmenKontakt = false; 
                    Lager = false;
                    Produkte = false;
                    Rohstoffe = false;
                    break;
            }
        }

        public static string tagDeclaration(string tag, int tagNum)
        {
            switch (tagNum)
            {
                case 0:
                    break;
                case 1:
                    tag = "Auftrag";
                    break;
            }
            _FensterBez = tag;
            return _FensterBez;
        }
    }
}