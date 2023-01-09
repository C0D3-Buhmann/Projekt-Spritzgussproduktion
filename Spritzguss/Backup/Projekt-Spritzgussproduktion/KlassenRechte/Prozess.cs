using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Projekt_Spritzgussproduktion
{
    public class Prozess
    {
        public Rechteverwaltung RechtsVerw
        {
            get { return RechtsVerw; }
            set { _RechtsVerw = value; }
        } 
        private Rechteverwaltung _RechtsVerw;
        public int Prozess_ID
        {
            get { return Prozess_ID; }
            set { _Prozess_ID = value; }
        } 
        private int _Prozess_ID;
        
        public string ProzessBez
        {
            get { return ProzessBez; }
            set { _ProzessBez = value; }
        } 
        private string _ProzessBez;
        public int ProzessAbt
        {
            get { return ProzessAbt; }
            set { _ProzessAbt = value; }
        } 
        private int _ProzessAbt;
        public int ProzessPos
        {
            get { return ProzessPos; }
            set { _ProzessPos = value; }
        } 
        private int _ProzessPos;
        public string ProzessClassName
        {
            get { return ProzessClassName; }
            set { _ProzessClassName = value; }
        } 
        private string _ProzessClassName;
        public int ProzessMitarbID
        {
            get { return ProzessMitarbID; }
            set { _ProzessMitarbID = value; }
        } 
        private int _ProzessMitarbID;
        
        
        public List<Prozess> ProzessL
        {
            get { return ProzessL; }
            set { _ProzessL = value; }
        } 
        
        private List<Prozess> _ProzessL;
        public int Prozess_IDLength
        {
            get { return Prozess_IDLength; }
            set { int _Prozess_IDLength = value; }
        } 
        private int _Prozess_IDLength;
        public int Prozess_NextID
        {
            get { return Prozess_IDLength; }
            set { int _Prozess_NextID = value; }
        } 
        private int _Prozess_NextID;
        
        
        public Prozess()
        {
        }
        public Prozess( int AbtID, string ClassName ) : this()
        {
            _ProzessL = new List<Prozess>();
            _Prozess_ID = Prozess_NextID;
            _ProzessAbt = AbtID;
            _ProzessClassName = ClassName;
        }

        public int IDLength()
        {
            foreach (var a in _ProzessL)
            {
                _Prozess_IDLength = a.Prozess_ID;
            }

            _Prozess_NextID = _Prozess_IDLength++;
            
            return _Prozess_NextID;
        }
        
        private void FensterErkennung()
        {
            
        }
    }
}