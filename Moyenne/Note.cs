using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moyenne
{
    public class Note
    {
        private int _valeurDizieme;
        private int _idNote;       

        public int ValeurDizieme
        {
            get
            {
                return _valeurDizieme;
            }
            set
            {
                _valeurDizieme = value;
            }
        }

        public int IdNote
        {
            get
            {
                return _idNote;
            }
            set
            {
                _idNote = value;
            }
        }

        public Note(int dizieme)
        {
            _valeurDizieme = dizieme;
           
        }

        /// <summary>
        /// Calcule moyenne de l'élève
        /// </summary>
        /// <param name="listeNotes"></param>
        /// <returns>moyenne</returns>
        public static float CalculMoyenne(ListBox listeNotes)
        {
            float moyenne = 0;
            float somme = 0;
            if (listeNotes.Items.Count > 0)
            {
                somme = SommeNotes(listeNotes);
                moyenne = somme / listeNotes.Items.Count;
            }
            moyenne = (float) Math.Round(moyenne, 2);
            return moyenne;
        }

        private static float SommeNotes(ListBox listeNotes)
        {
            float somme = 0;
            foreach (Note note in listeNotes.Items)
            {
                somme += note.ValeurDizieme;
            }
            somme = somme / 10;
            return somme;
        }

        public static List<Note> GetListeNotes(ListBox listeNotes )
        {
            List<Note> lstNotes = new List<Note>();
            foreach (Note note in listeNotes.Items)
            {
                lstNotes.Add(note);
            }
            return lstNotes;
        }

        public override string ToString()
        {
            return (_valeurDizieme / 10).ToString() + "." + (_valeurDizieme % 10).ToString();
        }

        public bool IsNoteCorrecte() 
        {
            //Une note ne peut pas être supérieure à 6.0
            if (_valeurDizieme <= 60)
            {
                return true;
            } 
            return false;
        }

    }
}
