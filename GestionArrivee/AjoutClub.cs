using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionArrivee
{
    public partial class AjoutClub : Form
    {
        public AjoutClub()
        {
            InitializeComponent();
        }

        private void buttonCreer_Click(object sender, EventArgs e)
        {
            Clubs creeClub = new Clubs(textBoxNom.Text, textBoxAdr.Text, textBoxCP.Text, textBoxVille.Text);
            DbClubs AjoutClub = new DbClubs();
            bool result = AjoutClub.AjouterClub(creeClub);
            if (result == false)
            {
                MessageBox.Show("La création à échouée, veuillez vérifier l'état dse votre base de Données");
            }
            else
            {
                MessageBox.Show("Création club " + textBoxNom.Text + " effectué !");
                textBoxNom.Text = "";
                textBoxAdr.Text= "";
                textBoxCP.Text = "";
                textBoxVille.Text = "";
            }


        }

        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
