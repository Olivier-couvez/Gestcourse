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


namespace GestionArrivee
{
    public partial class GestCategories : Form
    {
        DataGridViewRow ligneSelect;
        DbCategories BaseCategories;
        int IdxLigneActuelle = -1;

        public GestCategories()
        {
            InitializeComponent();

        }

        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCreer_Click(object sender, EventArgs e)
        {
            AjoutCategories fenAjoutCategories = new AjoutCategories();
            DialogResult Fermeture = fenAjoutCategories.ShowDialog();
            MajGrid();
        }


        private void buttonModifier_Click(object sender, EventArgs e)
        {
            if (IdxLigneActuelle != -1)
            {
                DialogResult reponse = MessageBox.Show("Voulez vous vraiment modifier la Categorie " + textBoxNom.Text + " ?", "Modification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (reponse == DialogResult.Yes)
                {

                    Categories creeCategories = new Categories(textBoxNom.Text, Convert.ToInt16(textBoxAgeMin.Text), Convert.ToInt16(textBoxAgeMax.Text), Convert.ToInt16(textBoxDistance.Text));
                    DbCategories ModCategories = new DbCategories();
                    (bool result, string MessErreur) = ModCategories.ModifierCategories(creeCategories, Convert.ToInt16(textBoxID.Text));
                    if (result == false)
                    {
                        MessageBox.Show("La modification à échouée, veuillez vérifier l'état dse votre base de Données, avec le message : " + MessErreur);
                    }
                    else
                    {
                        MessageBox.Show("La modification de la Categorie " + textBoxNom.Text + " effectuée !");
                    }
                    MajGrid();
                }
            }
        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            if (IdxLigneActuelle != -1)
            {
                DialogResult reponse = MessageBox.Show("Voulez vous vraiment supprimer la Categories " + textBoxNom.Text + " ?", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (reponse == DialogResult.Yes)
                {
                    Categories creeCategories = new Categories(ligneSelect.Cells[1].Value.ToString(), Convert.ToInt16(ligneSelect.Cells[2].Value.ToString()), Convert.ToInt16(ligneSelect.Cells[3].Value.ToString()), Convert.ToInt16(ligneSelect.Cells[4].Value.ToString()));
                    DbCategories SupCategories = new DbCategories();
                    (bool result, string MessErreur) = SupCategories.SupprimerCategories(creeCategories, Convert.ToInt16(textBoxID.Text));
                    if (result == false)
                    {
                        MessageBox.Show("La suppression à échouée, veuillez vérifier l'état de votre base de Données, avec le message : "+ MessErreur);
                    }
                    else
                    {
                        MessageBox.Show("La suppression de la Categorie " + ligneSelect.Cells[1].Value.ToString() + " effectuée !");
                        MajGrid();
                    }
                }
            }
        }

       



        // Lecture base et mise a jour du datagrid

        private void MajGrid()
        {
            dataGridViewCategories.Rows.Clear();

            // lecture table complète de la base.
            BaseCategories = new DbCategories();
            MySqlDataReader reader = BaseCategories.LecturetoutCategories();

            if (reader != null)          // on teste si la requete a bien retournéer un résultat
            {

                // Vérifie si des données sont présente dans reader

                if (reader.HasRows)
                {
                    int i = 0;
                    while (reader.Read())
                    {
                        // Ajout de la ligne au gridview.

                        dataGridViewCategories.Rows.Insert(i,Convert.ToInt16( reader.GetString(0)), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4));
                        i ++;
                    }

                }
            }
        }

        
        private void GestCategories_Load(object sender, EventArgs e)
        {
            MajGrid();
        }

        private void dataGridViewCategories_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
                IdxLigneActuelle = e.RowIndex;
                ligneSelect = dataGridViewCategories.Rows[IdxLigneActuelle];
                textBoxID.Text = ligneSelect.Cells[0].Value.ToString();
                textBoxNom.Text = ligneSelect.Cells[1].Value.ToString();
                textBoxAgeMin.Text = ligneSelect.Cells[2].Value.ToString();
                textBoxAgeMax.Text = ligneSelect.Cells[3].Value.ToString();
                textBoxDistance.Text = ligneSelect.Cells[4].Value.ToString();
            
        }
    }
}
