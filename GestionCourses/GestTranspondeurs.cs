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
    public partial class GestTranspondeurs : Form
    {
        DataGridViewRow ligneSelect;
        DbTranspondeurs BaseTranspondeur;
        int IdxLigneActuelle = -1;

        public GestTranspondeurs()
        {
            InitializeComponent();

        }

        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCreer_Click(object sender, EventArgs e)
        {
            AjoutTranspondeur fenAjoutClub = new AjoutTranspondeur();
            DialogResult Fermeture = fenAjoutClub.ShowDialog();
            MajGrid();
        }


        private void buttonModifier_Click(object sender, EventArgs e)
        {
            if (IdxLigneActuelle != -1)
            {
                DialogResult reponse = MessageBox.Show("Voulez vous vraiment modifier le transpondeur " + textBoxID.Text + " ?", "modification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (reponse == DialogResult.Yes)
                {
                    
                    Transpondeurs creeTranspondeur = new Transpondeurs(Convert.ToInt32(textBoxID.Text), Convert.ToInt16(textBoxPerdu.Text));
                    DbTranspondeurs ModTranspondeur = new DbTranspondeurs();
                    (bool result, string MessErreur) = ModTranspondeur.ModifierTranspondeur(creeTranspondeur, Convert.ToInt16(textBoxID.Text));
                    if (result == false)
                    {
                        MessageBox.Show("La modification à échouée, veuillez vérifier l'état dse votre base de Données, avec le message : " + MessErreur);
                    }
                    else
                    {
                        MessageBox.Show("La modification du transpondeur " + textBoxID.Text + " effectuée !");
                    }
                    MajGrid();
                }
            }
        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            if (IdxLigneActuelle != -1)
            {
                DialogResult reponse = MessageBox.Show("Voulez vous vraiment supprimer le transpondeur " + textBoxID.Text + " ?", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (reponse == DialogResult.Yes)
                {
                    Transpondeurs creeTranspondeur = new Transpondeurs(Convert.ToInt16(ligneSelect.Cells[1].Value.ToString()), Convert.ToInt16(ligneSelect.Cells[2].Value.ToString()));
                    DbTranspondeurs SupTranspondeur = new DbTranspondeurs();
                    (bool result, string MessErreur) = SupTranspondeur.SupprimerTranspondeur(creeTranspondeur, Convert.ToInt16(textBoxID.Text));
                    if (result == false)
                    {
                        MessageBox.Show("La suppression à échouée, veuillez vérifier l'état de votre base de Données, avec le message : "+ MessErreur);
                    }
                    else
                    {
                        MessageBox.Show("La suppression du transpondeur " + ligneSelect.Cells[0].Value.ToString() + " effectuée !");
                        MajGrid();
                    }
                }
            }
        }

        private void dataGridViewClubs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IdxLigneActuelle = e.RowIndex;
            ligneSelect = dataGridViewTranspondeurs.Rows[IdxLigneActuelle];
            textBoxID.Text =  ligneSelect.Cells[0].Value.ToString();
            textBoxPerdu.Text = ligneSelect.Cells[1].Value.ToString();
        }


        // Lecture base et mise a jour du datagrid

        private void MajGrid()
        {
            dataGridViewTranspondeurs.Rows.Clear();
            int perdu;

            // lecture table complète de la base.
            BaseTranspondeur = new DbTranspondeurs();
            MySqlDataReader reader = BaseTranspondeur.LecturetoutTranspondeurs();

            if (reader != null)          // on teste si la requete a bien retournéer un résultat
            {

                // Vérifie si des données sont présente dans reader

                if (reader.HasRows)
                {
                    int i = 0;
                    while (reader.Read())
                    {
                        // Ajout de la ligne au gridview.
                        if ( Convert.ToBoolean(reader.GetString(1)))
                        {
                            perdu = 1;
                        }
                        else
                        {
                            perdu = 0;
                        }


                        dataGridViewTranspondeurs.Rows.Insert(i,Convert.ToInt32( reader.GetString(0)), perdu);
                        i ++;
                    }

                }
            }
        }

        private void GestTranspondeurs_Load(object sender, EventArgs e)
        {
            MajGrid();
        }
    }
}
