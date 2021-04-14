using MySql.Data.MySqlClient;
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
    public partial class GestClassCourse : Form
    {
        DbCourses baseCourses;
        int idxCourseEC = 0;
        List<string> listeDesNomCourses = new List<string>();
        List<string> listeDesIdxCourses = new List<string>();
        public GestClassCourse()
        {
            InitializeComponent();
        }

        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAfficher_Click(object sender, EventArgs e)
        {
            string classement;
            
            ListViewItem it2;
            if (comboBoxCourses.SelectedIndex != -1)
            {
                listViewClassement.View = View.Details;

                for (int i=0; i<40;i++)
            {
                classement = Convert.ToString(i);
                ListViewItem it = new ListViewItem(classement);
                it2 = remplirliste(it, i);
                listViewClassement.Items.Add(it2);
            }
            }
            else
            {
                MessageBox.Show("Vous n'avez pas sélectioné de course !");
            }
        }
        private ListViewItem remplirliste(ListViewItem listitem, int i)
        {
            string dossard, nom, prenom, categorie, clubs, temps;
            ListViewItem it2;
            dossard = "dossard" + Convert.ToString(i);
            nom = "Nom" + Convert.ToString(i);
            prenom = "Prénom" + Convert.ToString(i);
            categorie = "Catégorie" + Convert.ToString(i);
            clubs = "Club" + Convert.ToString(i);
            temps = "Temps 12 H 10 Mn " + Convert.ToString(i) + "sec";
            it2 = listitem;
            it2.SubItems.Add(dossard);
            it2.SubItems.Add(nom);
            it2.SubItems.Add(prenom);
            it2.SubItems.Add(categorie);
            it2.SubItems.Add(clubs);
            it2.SubItems.Add(temps);
            return it2;
        }

        private void GestClassCourse_Load(object sender, EventArgs e)
        {
            // remplir la liste des Courses avec memorisaion de l'id
            string messCombo = "";

            baseCourses = new DbCourses();
            MySqlDataReader readercourse = baseCourses.LecturetoutCourse();

            if (readercourse != null)          // on teste si la requete a bien retournéer un résultat
            {
                // Vérifie si des données sont présente dans reader
                if (readercourse.HasRows)
                {
                    int i = 0;
                    while (readercourse.Read())
                    {
                        // Ajout de la ligne au liste clubs.
                        if (readercourse.GetString(5) == "True")
                        {
                            messCombo = readercourse.GetString(1) + "(En cours)";
                        }
                        else
                        {
                            messCombo = readercourse.GetString(1);
                        }
                        listeDesNomCourses.Add(readercourse.GetString(1));
                        listeDesIdxCourses.Add(readercourse.GetString(0));
                        comboBoxCourses.Items.Add(messCombo);
                        i++;
                    }
                }
            }
        }
    }
}
