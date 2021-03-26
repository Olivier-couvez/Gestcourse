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
using MySql.Data.MySqlClient;

namespace GestionCourses
{
    public partial class InscriptionCourse : Form
    {
        DbCourses baseCourses;
        DbCoureurs baseCoureurs;
        DbTranspondeurs baseTranspondeurs;
        DbInscriptions baseInscriptions;
        List<string> listeDesNomCoureurs = new List<string>();
        List<string> listeDesIdxCoureurs = new List<string>();
        List<string> listeDesNomCourses = new List<string>();
        List<string> listeDesIdxCourses = new List<string>();
        List<string> listeDesNomTranspondeurs = new List<string>();
        List<string> listeDesIdxTranspondeurs = new List<string>();


        public InscriptionCourse()
        {
            InitializeComponent();
        }
        
        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TableCoureurAjout_Load(object sender, EventArgs e)
        {

            // remplir la liste des Courses avec memorisaion de l'id

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

                        listeDesNomCourses.Add(readercourse.GetString(1));
                        listeDesIdxCourses.Add(readercourse.GetString(0));
                        comboBoxCourse.Items.Add(readercourse.GetString(1));
                        i++;
                    }
                }
            }

            //  lecture tous coureurs

            baseCoureurs = new DbCoureurs();
            MySqlDataReader readerCoureur = baseCoureurs.LecturetoutCoureurs();

            if (readerCoureur != null)          // on teste si la requete a bien retournéer un résultat
            {
                // Vérifie si des données sont présente dans reader
                if (readerCoureur.HasRows)
                {
                    int i = 0;
                    while (readerCoureur.Read())
                    {
                        // Ajout de la ligne au liste coureur.
                        listeDesNomCoureurs.Add(readerCoureur.GetString(2));
                        listeDesIdxCoureurs.Add(readerCoureur.GetString(0));
                        comboBoxCoureur.Items.Add(readerCoureur.GetString(2));
                        i++;
                    }
                }
            }

            //  lecture tous Transpondeurs

            baseTranspondeurs = new DbTranspondeurs();
            MySqlDataReader readerTrans = baseTranspondeurs.LecturetoutTranspondeurs();

            if (readerTrans != null)          // on teste si la requete a bien retournéer un résultat
            {
                // Vérifie si des données sont présente dans reader
                if (readerTrans.HasRows)
                {
                    int i = 0;
                    while (readerTrans.Read())
                    {
                        // Ajout de la ligne au liste clubs.
                        listeDesNomTranspondeurs.Add(readerTrans.GetString(0));
                        listeDesIdxTranspondeurs.Add(readerTrans.GetString(0));
                        comboBoxTranspondeur.Items.Add(readerTrans.GetString(0));
                        i++;
                    }
                }
            }

            // Lecture dernier dossard

            LectureDernierDossard();
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            // récup booléen sexe et index club et categorie

            int idxCoureur = 0, idxTranspondeur = 0, idxcourse = 0;

            // recup index club et catégorie

            idxCoureur = Convert.ToInt32(listeDesIdxCoureurs[Convert.ToInt32(comboBoxCoureur.SelectedIndex)]);
            idxTranspondeur = Convert.ToInt32(listeDesIdxTranspondeurs[Convert.ToInt32(comboBoxTranspondeur.SelectedIndex)]);
            idxcourse = Convert.ToInt32(listeDesIdxCourses[Convert.ToInt32(comboBoxCourse.SelectedIndex)]);




            Inscriptions creeInscription = new Inscriptions(Convert.ToInt32(comboBoxDossard.Text), idxCoureur, idxTranspondeur, idxcourse);
            DbInscriptions AjoutInscription = new DbInscriptions();
            bool result = AjoutInscription.AjouterInscription(creeInscription);
            if (result == false)
            {
                MessageBox.Show("La création à échouée, veuillez vérifier l'état de votre base de Données");
            }
            else
            {
                MessageBox.Show("Création inscription Dossard numéro " + comboBoxDossard.Text + " effectuée !");
                LectureDernierDossard();
                comboBoxDossard.SelectedIndex = 0;
                comboBoxCourse.SelectedIndex = 0;
                comboBoxCoureur.SelectedIndex = 0;
                comboBoxTranspondeur.SelectedIndex = 0;
            }
        }


        private void LectureDernierDossard()
        {
            Int32 dernierDossard = 0;
            comboBoxDossard.Items.Clear();
            baseInscriptions = new DbInscriptions();
            MySqlDataReader readerInscr = baseInscriptions.LectureDernierInscription();

            if (readerInscr != null)          // on teste si la requete a bien retournéer un résultat
            {
                // Vérifie si des données sont présente dans reader
                if (readerInscr.HasRows)
                {
                    int i = 0;
                    while (readerInscr.Read())
                    {
                        // Ajout de la ligne au liste clubs.
                        dernierDossard = Convert.ToInt32(readerInscr.GetString(0));
                        i++;
                    }
                }
            }
            for (int i = (dernierDossard+1); i < (10000-dernierDossard); i++)
            {
                comboBoxDossard.Items.Add(i);
            }

        }
    }
}
