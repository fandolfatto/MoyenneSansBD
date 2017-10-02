using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moyenne
{
    /// <summary>
    /// Formulaire permettant la saisie de la note
    /// </summary>
    public partial class frmSaisieNote : Form
    {
        public Note note;  

        public frmSaisieNote()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Chargement du formulaire
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmSaisieNote_Load(object sender, EventArgs e)
        {
            if (note != null)
            {
                nudEntier.Value = note.ValeurDizieme / 10;
                nudDecimal.Value = note.ValeurDizieme % 10;
            }
        }

        private void cmdValider_Click(object sender, EventArgs e)
        {
            note.ValeurDizieme = (int)(nudEntier.Value * 10 + nudDecimal.Value);
            if (note.IsNoteCorrecte())
            {
                Dispose();
            } else
            {
                //DialogResult à none pour que le formulaire ne se ferme pas
                DialogResult = DialogResult.None;
                MessageBox.Show("La note doit être inférieure à 6");
            }
        }

        private void cmdAnnuler_Click(object sender, EventArgs e)
        {
            Dispose();
            
        }

        private void nudEntier_ValueChanged(object sender, EventArgs e)
        {
            if (nudEntier.Value > 6)
            {
                MessageBox.Show("Attention, valeur incorrecte : la note doit être inférieure à 6");
            }
        }
        
    }
}
