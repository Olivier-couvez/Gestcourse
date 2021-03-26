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
    public partial class AjoutCategories : Form
    {
        public AjoutCategories()
        {
            InitializeComponent();
        }

        private void buttonCreer_Click(object sender, EventArgs e)
        {
            Categories creeCategories = new Categories(textBoxNom.Text, Convert.ToInt16(textBoxAgeMini.Text), Convert.ToInt16(textBoxAgeMaxi.Text), Convert.ToInt16(textBoxDistance.Text));
            DbCategories AjoutCategories = new DbCategories();
            bool result = AjoutCategories.AjouterCategories(creeCategories);
            if (result == false)
            {
                MessageBox.Show("La création à échouée, veuillez vérifier l'état de votre base de Données");
            }
            else
            {
                MessageBox.Show("Création catégories " + textBoxNom.Text + " effectué !");
                textBoxNom.Text = "";
                textBoxAgeMini.Text= "";
                textBoxAgeMaxi.Text = "";
                textBoxDistance.Text = "";
            }


        }

        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
