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
    public partial class frmEleve : Form
    {
        private Eleve eleve;
        public Eleve Eleve {
            get {
                return eleve;
            }

            set {
                eleve = value;
            }
        }
        private bool validation;
        
        public frmEleve()
        {
            InitializeComponent();
        }

        private void cmdAjouter_Click(object sender, EventArgs e)
        {
            frmSaisieNote formNote = new frmSaisieNote();
            formNote.note = new Note(0);
            if (formNote.ShowDialog() == DialogResult.OK)
            {
                lstNotes.Items.Add(formNote.note);
                lblResMoyenne.Text = Note.CalculMoyenne(lstNotes).ToString();
            }

        }

        private void cmdModifier_Click(object sender, EventArgs e)
        {
            //appel de la méthode qui gère le formulaire de saisie de note
            ouvrirFormNote();
        }

        private void cmdSupprimer_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Confirmez-vous la suppression?", "Suppression d'une note", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (lstNotes.SelectedIndex > -1)
                {
                    lstNotes.Items.Remove((Note)lstNotes.SelectedItem);
                    lblResMoyenne.Text = Note.CalculMoyenne(lstNotes).ToString();
                }
                else
                {
                    MessageBox.Show("Elève non sélectionné");
                }
                if (lstNotes.Items.Count == 0)
                {
                    cmdSupprimer.Enabled = false;
                    cmdModifier.Enabled = false;
                }
            }

            
        }

        private void lstNotes_Click(object sender, EventArgs e)
        {
            cmdModifier.Enabled = true;
            cmdSupprimer.Enabled = true;
        }

        private void lstNotes_DoubleClick(object sender, EventArgs e)
        {
            ouvrirFormNote();
        }

        private void ouvrirFormNote()
        {
            frmSaisieNote formNote = new frmSaisieNote();

            if (lstNotes.SelectedIndex > -1)
            {
                formNote.note = (Note)lstNotes.SelectedItem;
                int oldNote = ((Note)lstNotes.SelectedItem).ValeurDizieme;

                int pos = lstNotes.SelectedIndex;
                formNote.ShowDialog();

                lblResMoyenne.Text = Note.CalculMoyenne(lstNotes).ToString();
                lstNotes.Items.RemoveAt(pos);
                lstNotes.Items.Insert(pos, formNote.note);
                lstNotes.SelectedIndex = pos;
            }
        }

        private void cmdAnnuler_Click(object sender, EventArgs e)
        {
            validation = false;
            Annulation();
        }

        private void cmdValider_Click(object sender, EventArgs e)
        {
            eleve.Nom = txtNom.Text;
            eleve.Prenom = txtPrenom.Text;
            eleve.pathImage = pctEleve.ImageLocation;
            eleve.LstNotes = Note.GetListeNotes(lstNotes);

            float moyenneRes = 0.0f;
            if (float.TryParse(lblResMoyenne.Text, out moyenneRes))
            {
                eleve.Moyenne = moyenneRes;
            } else
            {
                eleve.Moyenne = 0.0f;
            }
          
        }

        private void frmEleve_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!validation)
            {
                Annulation();
            }
        }

        private void Annulation() {

            DialogResult res = MessageBox.Show("Confirmez-vous l'annulation?", "Suppression de la saisie", MessageBoxButtons.OKCancel);
            if (res == DialogResult.OK)
            {
                validation = true;
                Close();
            } else
            {
                //la fenêtre "Eleve" ne se ferme pas
                DialogResult = DialogResult.None;
                validation = true;
            }
        }

        private void frmEleve_Load(object sender, EventArgs e)
        {
            validation = true;
            txtNom.Text = eleve.Nom;
            txtPrenom.Text = eleve.Prenom;
            pctEleve.ImageLocation = eleve.pathImage;
            foreach (Note note in eleve.LstNotes)
            {
                lstNotes.Items.Add(note);
            }
            lblResMoyenne.Text = eleve.Moyenne.ToString();

            cmdSupprimer.Enabled = false;
            cmdModifier.Enabled = false;
        }

        private void pctEleve_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            
            openFileDialog1.InitialDirectory = @"C:\Data";
            openFileDialog1.Title = "Browse pictures";
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)

            {

                pctEleve.ImageLocation = openFileDialog1.FileName;
                pctEleve.SizeMode = PictureBoxSizeMode.StretchImage;

            }
        }
    }
}
