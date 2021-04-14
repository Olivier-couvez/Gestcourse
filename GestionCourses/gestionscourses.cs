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
    
    public partial class gestionscourses : Form
    {
        Dbconnect Bdd;
        string serveurBdd = "", baseBdd = "", utilisateurBdd = "", motDePasseBdd = "";
        int portBdd = 0;
        ParametreServeur ParamServer;

        public gestionscourses()
        {
            InitializeComponent();
        }

        private void parametreDeLaBaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ParamServer = new ParametreServeur();
            ParamServer.Serveur = serveurBdd;
            ParamServer.Base = baseBdd;
            ParamServer.Port = Convert.ToString(portBdd);
            ParamServer.Utilisateur = utilisateurBdd;
            ParamServer.Mdp = motDePasseBdd;

            DialogResult Fermeture = ParamServer.ShowDialog();

            if (Fermeture == DialogResult.OK)
            {
                serveurBdd = ParamServer.Serveur;
                baseBdd = ParamServer.Base;
                portBdd = Convert.ToInt16(ParamServer.Port);
                utilisateurBdd = ParamServer.Utilisateur;
                motDePasseBdd = ParamServer.Mdp;
            }
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonDeconnexion_Click(sender, e);
            this.Close();
        }

        private void clubsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestClubs fenGestClubs = new GestClubs();
            DialogResult fermeture = fenGestClubs.ShowDialog();

        }

        private void catégoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestCategories fenGestClubs = new GestCategories();
            DialogResult fermeture = fenGestClubs.ShowDialog();
        }

        private void coursesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestCourses fenGestCourses = new GestCourses();
            DialogResult fermeture = fenGestCourses.ShowDialog();
        }

        private void transpondeursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestTranspondeurs fenGestTranspondeurs = new GestTranspondeurs();
            DialogResult fermeture = fenGestTranspondeurs.ShowDialog();
        }

        private void gestionDuneCoursesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DemarrageCourse fenGestTranspondeurs = new DemarrageCourse();
            DialogResult fermeture = fenGestTranspondeurs.ShowDialog();
        }

        private void inscriptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestInscriptions fenGestCoureurs = new GestInscriptions();
            DialogResult fermeture = fenGestCoureurs.ShowDialog();
        }

        private void classementDuneCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestClassCourse fenClassCourse = new GestClassCourse();
            DialogResult fermeture = fenClassCourse.ShowDialog();
        }

        private void coureursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestCoureurs fenGestCoureurs = new GestCoureurs();
            DialogResult fermeture = fenGestCoureurs.ShowDialog();

        }

        // methodes de gestion.

        // ouverture de la base

        private void buttonConnxion_Click(object sender, EventArgs e)
        {
            if ((serveurBdd == "") || (baseBdd == "") || (utilisateurBdd == "") || (portBdd == 0))
            {
                MessageBox.Show("Vous n'avez pas saisie les paramêtres du serveur SQL !!");
            }
            else
            {
                Bdd = new Dbconnect(serveurBdd, portBdd, baseBdd, utilisateurBdd, motDePasseBdd);

                bool OuvertureOk = Bdd.OuvrirConnexion();
                if (OuvertureOk != true)
                {
                    MessageBox.Show("Echec de connexion à la base de données :" +
                                        "Exception retournée = " + Bdd.Erreur);
                }
            }
        }

        //Fermeture base

        private void buttonDeconnexion_Click(object sender, EventArgs e)
        {
            try
            {
                bool OuvertureOk = Bdd.FermerConnexion();
                if (OuvertureOk != false)
                {
                    MessageBox.Show("Echec de la déconnexion de la base de données :" +
                                       "Exception retournée = " + Bdd.Erreur);
                }
            }
            catch { }
            
          
        }
    }
}
