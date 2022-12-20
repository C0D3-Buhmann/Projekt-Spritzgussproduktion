using System;
using System.Collections.Generic;

namespace Projekt_Spritzgussproduktion
{
    public class Create : IEquatable<Create>
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Preis { get; set; }
        public decimal Menge { get; set; }
        public decimal Gesammtpreis { get; set; }
        public bool Saved { get; set; }
        
        public int getID()
        {
            return ID;
        }
        public decimal getMenge()
        {
            return Menge;
        }
        public decimal getPreis()
        {
            return Preis;
        }
        public bool isSaved()
        {
            return Saved;
        }


        public override string ToString()
        {
            return "\n" + outputID() + "\n" + outputName() + "\n" + outputMenge() + "\n" + outputPreis() + "\n" + outputGesammtpreis() + "\n" + outputSaved() + "\n";
        }
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Create objAsCreate = obj as Create;
            if (objAsCreate == null) return false;
            else return Equals(objAsCreate);
        }
        public override int GetHashCode()
        {
            return ID;
        }
        public bool Equals(Create other)
        {
            if (other == null) return false;
            return (this.ID.Equals(other.ID));
        }
        public string outputID()
        {
            return ID.ToString();           
        }
        public string outputName()
        {
            return Name;
        }
        public string outputPreis()
        {
            return Preis.ToString();
        }

        public string outputMenge()
        {
            return Menge.ToString();
        }

        public string outputSaved()
        {
            return Saved.ToString();
        }

        public string outputGesammtpreis()
        {
            return Gesammtpreis.ToString();
        }
    }
}