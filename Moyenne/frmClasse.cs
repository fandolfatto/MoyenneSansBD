using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Moyenne
{
    public partial class frmClasse : Form
    {
       
        //on utilise cette liste pour sauvegarder les données des élèves
        List<Eleve> lstEleveStd = new List<Eleve>();
        public frmClasse()
        {
            InitializeComponent();
        }


        private void frmMoyenne_Load(object sender, EventArgs e)
        {
            //au chargement, bouton inactif
            cmdModifier.Enabled = false;
            cmdSupprimer.Enabled = false;
        }

        private void lstEleves_Click(object sender, EventArgs e)
        {
            //élève sélectionné => boutons actifs
            cmdModifier.Enabled = true;
            cmdSupprimer.Enabled = true;
        }


        private void cmdAjouter_Click(object sender, EventArgs e)
        {
            //Appel du formulaire "Eleve"
            frmEleve formEleve = new frmEleve();
            //Création d'un nouvel objet de type Eleve, on instancie la classe Eleve.
            formEleve.Eleve = new Eleve();
            if (formEleve.ShowDialog(this) == DialogResult.OK)
            {
                lstEleves.Items.Add(formEleve.Eleve);
            }
            formEleve.Dispose();
        }

        private void cmdModifier_Click(object sender, EventArgs e)
        {
            ouvrirFormEleve();
        }

        private void cmdSupprimer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirmez-vous la suppression?", "Suppression d'un élève", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (lstEleves.SelectedIndex > -1)
                {
                    
                    lstEleves.Items.Remove((Eleve)lstEleves.SelectedItem);
                }
                else
                {
                    MessageBox.Show("Elève non sélectionné");
                }
                if (lstEleves.Items.Count == 0)
                {
                    cmdModifier.Enabled = false;
                    cmdSupprimer.Enabled = false;
                }
            }            
        }

        private void lstEleves_DoubleClick(object sender, EventArgs e)
        {
            ouvrirFormEleve();
        }

        // Y: passer l'objet Eleve en parametre, si NULL => creation
        private void ouvrirFormEleve()
        {
            frmEleve formEleve = new frmEleve();
            if (lstEleves.SelectedIndex > -1)
            {
                formEleve.Eleve = (Eleve)lstEleves.SelectedItem;
                int pos = lstEleves.SelectedIndex;
                formEleve.ShowDialog(this);

                lstEleves.Items.RemoveAt(pos);
                lstEleves.Items.Insert(pos, formEleve.Eleve);
                lstEleves.SelectedIndex = pos;

                formEleve.Dispose();
            }
            else
            {
                MessageBox.Show("Elève non sélectionné, modification impossible");
            }

        }

    }
}
