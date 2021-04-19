using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionCourses
{
    public partial class GestClassCourse : Form
    {
        DbCourses baseCourses;
        DbArrivee baseArrivee;
        MySqlDataReader readerAr;
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

                // Lecture de la table pour les arrivée
                baseArrivee = new DbArrivee();
                readerAr = baseArrivee.LectureArrivee(Convert.ToInt16( listeDesIdxCourses[comboBoxCourses.SelectedIndex]));

                if (readerAr != null)          // on teste si la requete a bien retournéer un résultat
                {
                    // Vérifie si des données sont présente dans reader

                    if (readerAr.HasRows)
                    {
                        int i = 0;
                        while (readerAr.Read())
                        {
                            // Ajout de la ligne à la liste view.

                            classement = Convert.ToString(i+1);
                            ListViewItem it = new ListViewItem(classement);
                            it2 = remplirliste(it);
                            listViewClassement.Items.Add(it2);
                            i++;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Vous n'avez pas sélectioné de course !");
            }
        }
        private ListViewItem remplirliste(ListViewItem listitem)
        {
            string dossard, nom, prenom, categorie, clubs, temps;
            ListViewItem it2;
            DateTime recupTemps;
            recupTemps = Convert.ToDateTime(readerAr.GetString(5));


            dossard = readerAr.GetString(0);
            nom = readerAr.GetString(1);
            prenom = readerAr.GetString(2);
            categorie = readerAr.GetString(3);
            clubs = readerAr.GetString(4);
            temps = recupTemps.ToString("T", DateTimeFormatInfo.InvariantInfo);
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
