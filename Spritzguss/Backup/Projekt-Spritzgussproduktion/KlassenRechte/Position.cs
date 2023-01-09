using System;
using System.Windows.Forms;

namespace Projekt_Spritzgussproduktion
{
    public class Position
    {
        public int Position_ID 
        {
            get { return Position_ID; }
            set { _Position_ID = value; }
        } 
        private int _Position_ID;
        
        public string PositionBez 
        {
            get { return PositionBez; }
            set { _PositionBez = value; }
        } 
        private string _PositionBez;
        
        ComboBox cBoxPosition
        {
            get { return cBoxPosition; }
            set { _cBoxPosition = value; }
        } 
        private ComboBox _cBoxPosition;
        
        ListBox lBoxPosition
        {
            get { return lBoxPosition; }
            set { _lBoxPosition = value; }
        } 
        private ListBox _lBoxPosition;
        
        public Position()
        {

        }
        public Position( int ID ) : this()
        {
            _Position_ID = ID;
        }
    }
}