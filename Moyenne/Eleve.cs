using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moyenne
{
    public class Eleve
    {
        // Y: ID
        private string _nom;
        private string _prenom;
        private string _pathImage;
        // Y: objets Note
        private List<Note> _lstNotes;
        private float _moyenne;

        public string Nom
        {
            get
            {
                return _nom;
            }
            set
            {
                _nom = value;
            }
        }

        public string Prenom
        {
            get
            {
                return _prenom;
            }
            set
            {
                _prenom = value;
            }
        }

        public string pathImage
        {
            get
            {
                return _pathImage;
            }
            set
            {
                _pathImage = value;
            }
        }
        public float Moyenne
        {
            get
            {
                return _moyenne;
            }
            set
            {
                _moyenne = value;
            }
        }

        public override string ToString()
        {
            return _nom + " " + _prenom + " - " + _moyenne;
        }

        public List<Note> LstNotes
        {
            get
            {
                return _lstNotes;
            }
            set
            {
                _lstNotes = value;
            }
        }
    }
}
