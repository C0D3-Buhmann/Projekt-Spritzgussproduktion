using System;
using System.Windows.Forms;

namespace Projekt_Spritzgussproduktion
{
    public class Abteilung
    {
        public int Abteilung_ID 
        {
            get { return Abteilung_ID; }
            set { _Abteilung_ID = value; }
        } 
        private int _Abteilung_ID;
        
        public string AbteilungBez 
        {
            get { return AbteilungBez; }
            set { _AbteilungBez = value; }
        } 
        private string _AbteilungBez;
        
        ComboBox cBoxAbteilung 
        {
            get { return cBoxAbteilung; }
            set { _cBoxAbteilung = value; }
        } 
        private ComboBox _cBoxAbteilung;
        
        ListBox lBoxAbteilung 
        {
            get { return lBoxAbteilung; }
            set { _lBoxAbteilung = value; }
        } 
        private ListBox _lBoxAbteilung;
        
        public Abteilung()
        {

        }
        public Abteilung( int ID ) : this()
        {
            _Abteilung_ID = ID;
        }

    }
}