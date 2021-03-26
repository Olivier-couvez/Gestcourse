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


namespace GestionCourses
{
    public partial class GestClubs : Form
    {
        DataGridViewRow ligneSelect;
        DbClubs BaseClub;
        int IdxLigneActuelle = -1;

        public GestClubs()
        {
            InitializeComponent();

        }

        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCreer_Click(object sender, EventArgs e)
        {
            AjoutClub fenAjoutClub = new AjoutClub();
            DialogResult Fermeture = fenAjoutClub.ShowDialog();
            MajGrid();
        }


        private void buttonModifier_Click(object sender, EventArgs e)
        {
            if (IdxLigneActuelle != -1)
            {
                DialogResult reponse = MessageBox.Show("Voulez vous vraiment modifier le club " + textBoxNom.Text + " ?", "modification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (reponse == DialogResult.Yes)
                {

                    Clubs creeClub = new Clubs(textBoxNom.Text, textBoxAdresse.Text, textBoxCP.Text, textBoxVille.Text);
                    DbClubs ModClub = new DbClubs();
                    (bool result, string MessErreur) = ModClub.ModifierClub(creeClub, Convert.ToInt16(textBoxID.Text));
                    if (result == false)
                    {
                        MessageBox.Show("La modification à échouée, veuillez vérifier l'état dse votre base de Données, avec le message : " + MessErreur);
                    }
                    else
                    {
                        MessageBox.Show("La modification du club " + textBoxNom.Text + " effectuée !");
                    }
                    MajGrid();
                }
            }
        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            if (IdxLigneActuelle != -1)
            {
                DialogResult reponse = MessageBox.Show("Voulez vous vraiment supprimer le club " + textBoxNom.Text + " ?", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (reponse == DialogResult.Yes)
                {
                    Clubs creeClub = new Clubs(ligneSelect.Cells[1].Value.ToString(), ligneSelect.Cells[2].Value.ToString(), ligneSelect.Cells[3].Value.ToString(), ligneSelect.Cells[4].Value.ToString());
                    DbClubs SupClub = new DbClubs();
                    (bool result, string MessErreur) = SupClub.SupprimerClub(creeClub, Convert.ToInt16(textBoxID.Text));
                    if (result == false)
                    {
                        MessageBox.Show("La suppression à échouée, veuillez vérifier l'état de votre base de Données, avec le message : "+ MessErreur);
                    }
                    else
                    {
                        MessageBox.Show("La suppression du club " + ligneSelect.Cells[1].Value.ToString() + " effectuée !");
                        MajGrid();
                    }
                }
            }
        }

        private void dataGridViewClubs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IdxLigneActuelle = e.RowIndex;
            ligneSelect = dataGridViewClubs.Rows[IdxLigneActuelle];
            textBoxID.Text =  ligneSelect.Cells[0].Value.ToString();
            textBoxNom.Text = ligneSelect.Cells[1].Value.ToString();
            textBoxAdresse.Text = ligneSelect.Cells[2].Value.ToString();
            textBoxCP.Text = ligneSelect.Cells[3].Value.ToString();
            textBoxVille.Text = ligneSelect.Cells[4].Value.ToString();
        }


        // Lecture base et mise a jour du datagrid

        private void MajGrid()
        {
            dataGridViewClubs.Rows.Clear();

            // lecture table complète de la base.
            BaseClub = new DbClubs();
            MySqlDataReader reader = BaseClub.LecturetoutClub();

            if (reader != null)          // on teste si la requete a bien retournéer un résultat
            {

                // Vérifie si des données sont présente dans reader

                if (reader.HasRows)
                {
                    int i = 0;
                    while (reader.Read())
                    {
                        // Ajout de la ligne au gridview.

                        dataGridViewClubs.Rows.Insert(i,Convert.ToInt16( reader.GetString(0)), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4));
                        i ++;
                    }

                }
            }
        }

        private void GestClubs_Load(object sender, EventArgs e)
        {
            MajGrid();
        }
    }
}
