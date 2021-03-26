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
using System.Configuration;
using System.Threading;
using System.Diagnostics;

namespace GestionCourses
{
    public partial class DemarrageCourse : Form
    {
        DbCourses baseCourses;
        int idxCourseEC = 0;
        List<string> listeDesNomCourses = new List<string>();
        List<string> listeDesIdxCourses = new List<string>();

        public DemarrageCourse()
        {
            InitializeComponent();
        }

        private void DemarrageCourse_Load(object sender, EventArgs e)
        {
            // remplir la liste des Courses avec memorisaion de l'id
            string messCombo = "";

            //  lecture toutes Courses

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

        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonDemarrer_Click(object sender, EventArgs e)
        {
            // démarrage de la course avec le thread

            if (comboBoxCourses.SelectedIndex != -1)
            {
                
                idxCourseEC = Convert.ToInt16(listeDesIdxCourses[comboBoxCourses.SelectedIndex]);

                // envoie de l'index dans le presse papier.

                Clipboard.SetData(DataFormats.Text, (string)listeDesIdxCourses[comboBoxCourses.SelectedIndex]);

                // démarrer l'application de gestion des arrivées !

                Process P = Process.Start("C:\\Users\\Virus\\Documents\\Stage TP CDA\\BDD\\Visual 2017\\gestcourses\\GestionArrivee\\bin\\Debug\\gestionArrivee.exe");
            }
            else
            {
                MessageBox.Show("Vous n'avez pas sélectioné de course !");
            }
        }
    }
}

