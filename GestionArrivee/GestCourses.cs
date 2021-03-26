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
    public partial class GestCourses : Form
    {
        DataGridViewRow ligneSelect;
        DbCourses BaseCourse;
        int IdxLigneActuelle = -1;

        public GestCourses()
        {
            InitializeComponent();

        }

        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCreer_Click(object sender, EventArgs e)
        {
            AjoutCourses fenAjoutCourse = new AjoutCourses();
            DialogResult Fermeture = fenAjoutCourse.ShowDialog();
            MajGrid();
        }


        private void buttonModifier_Click(object sender, EventArgs e)
        {
            if (IdxLigneActuelle != -1)
            {
                DialogResult reponse = MessageBox.Show("Voulez vous vraiment modifier le club " + textBoxNom.Text + " ?", "modification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (reponse == DialogResult.Yes)
                {

                    Courses creeCourse = new Courses(textBoxNom.Text, Convert.ToDateTime(textBoxDate.Text), textBoxDistance.Text, Convert.ToDateTime(textBoxHeureDep.Text));
                    DbCourses ModCourse = new DbCourses();
                    (bool result, string MessErreur) = ModCourse.ModifierCourse(creeCourse, Convert.ToInt16(textBoxID.Text));
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
                    Courses creeCourse = new Courses(ligneSelect.Cells[1].Value.ToString(), Convert.ToDateTime(ligneSelect.Cells[2].Value.ToString()), ligneSelect.Cells[3].Value.ToString(), Convert.ToDateTime(ligneSelect.Cells[4].Value.ToString()));
                    DbCourses SupCourse = new DbCourses();
                    (bool result, string MessErreur) = SupCourse.SupprimerCourse(creeCourse, Convert.ToInt16(textBoxID.Text));
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
            ligneSelect = dataGridViewCourses.Rows[IdxLigneActuelle];
            textBoxID.Text =  ligneSelect.Cells[0].Value.ToString();
            textBoxNom.Text = ligneSelect.Cells[1].Value.ToString();
            textBoxDate.Text = ligneSelect.Cells[2].Value.ToString();
            textBoxDistance.Text = ligneSelect.Cells[3].Value.ToString();
            textBoxHeureDep.Text = ligneSelect.Cells[4].Value.ToString();
        }


        // Lecture base et mise a jour du datagrid

        private void MajGrid()
        {
            dataGridViewCourses.Rows.Clear();

            // lecture table complète de la base.
            BaseCourse = new DbCourses();
            MySqlDataReader reader = BaseCourse.LecturetoutCourse();

            if (reader != null)          // on teste si la requete a bien retournéer un résultat
            {

                // Vérifie si des données sont présente dans reader

                if (reader.HasRows)
                {
                    int i = 0;
                    while (reader.Read())
                    {
                        // Ajout de la ligne au gridview.

                        dataGridViewCourses.Rows.Insert(i,Convert.ToInt16( reader.GetString(0)), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4));
                        i ++;
                    }

                }
            }
        }

        private void GestCourses_Load(object sender, EventArgs e)
        {
            MajGrid();
        }
    }
}
