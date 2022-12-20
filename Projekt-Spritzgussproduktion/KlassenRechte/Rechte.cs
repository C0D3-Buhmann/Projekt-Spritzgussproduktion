using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Projekt_Spritzgussproduktion
{
    public class Rechte : IEquatable<Rechte>
    {
        public int OctalNr 
        {
            get { return OctalNr; }
            set { _OctalNr = value; }
        } 
        private int _OctalNr;
        
        public string BezRechte 
        {
            get { return BezRechte; }
            set { _BezRechte = value; }
        } 
        private string _BezRechte;
        
        public ComboBox cBoxRechte 
        {
            get { return cBoxRechte; }
            set { _cBoxRechte = value; }
        } 
        private ComboBox _cBoxRechte;
        
        public ListBox lBoxRechte 
        {
            get { return lBoxRechte; }
            set { _lBoxRechte = value; }
        } 
        private ListBox _lBoxRechte;
        public List<Rechte> RechteItems
        {
            get { return RechteItems; }
            set { _RechteItems = value; }
        }
        private List<Rechte> _RechteItems;
        public Rechte()
        {
            
        }
        public Rechte( int ID, string bez ) : this()
        {
            _RechteItems = new List<Rechte>()
            {
                new Rechte() {_OctalNr = ID, _BezRechte = bez}
            };
        }

        public override string ToString()
        {
            return null;
        }
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Rechte objAsRechte = obj as Rechte;
            if (objAsRechte == null) return false;
            else return Equals(objAsRechte);
        }
        public override int GetHashCode()
        {
            return OctalNr;
        }

        public bool Equals(Rechte other)
        {
            if (other == null) return false;
            return (this.OctalNr.Equals(other.OctalNr));
        }
    }
}