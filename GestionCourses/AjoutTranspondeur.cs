using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionCourses
{
    public partial class AjoutTranspondeur : Form
    {
        public AjoutTranspondeur()
        {
            InitializeComponent();
            textBoxPerdu.Text = "0";
        }

        private void buttonCreer_Click(object sender, EventArgs e)
        {
            Transpondeurs creeTranspondeur = new Transpondeurs(Convert.ToInt16(textBoxId.Text), Convert.ToInt16(textBoxPerdu.Text));
            DbTranspondeurs AjoutTranspondeur = new DbTranspondeurs();
            bool result = AjoutTranspondeur.AjouterTranspondeur(creeTranspondeur);
            if (result == false)
            {
                MessageBox.Show("La création a échouée, veuillez vérifier l'état dse votre base de Données");
            }
            else
            {
                MessageBox.Show("Création transpondeur " + textBoxId.Text + " effectuée !");
                textBoxId.Text = "";
                textBoxPerdu.Text= "0";
            }


        }

        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
