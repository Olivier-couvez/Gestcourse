using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionArrivee
{

    public partial class gestionsArrivee : Form
    {
        Dbconnect Bdd;
        string serveurBdd = "", baseBdd = "", utilisateurBdd = "", motDePasseBdd = "";
        int portBdd = 0;
        ParametreServeur ParamServer;
        string idxCourseEnCours = "";
        Thread recupTranspondeur;
        ResteEnEveille jeScrute;
        DbCourses courseEnCours;
        string dataCourseNom = "";
        DateTime dataCourseDate;
        string dataCourseDistance = "";
        DateTime dataCourseHeure;
        bool courseDemarree = false;

        public gestionsArrivee()
        {
            InitializeComponent();
        }


        private void gestionsArrivee_Load(object sender, EventArgs e)
        {
            // Lecture presse papier


            idxCourseEnCours = Clipboard.GetText();
            idxCourseEnCours = "3";
            courseEnCours = new DbCourses();
            MySqlDataReader readercourseEnCours = courseEnCours.LectureUneCourse(Convert.ToInt16(idxCourseEnCours));

            if (readercourseEnCours != null)          // on teste si la requete a bien retournéer un résultat
            {
                // Vérifie si des données sont présente dans reader

                if (readercourseEnCours.HasRows)
                {
                    readercourseEnCours.Read();
                    textBoxCourseEnCours.Text = readercourseEnCours.GetString(1);
                    dataCourseNom = readercourseEnCours.GetString(1);
                    dataCourseDate = Convert.ToDateTime(readercourseEnCours.GetString(2));
                    dataCourseDistance = readercourseEnCours.GetString(3);
                    dataCourseHeure = Convert.ToDateTime(readercourseEnCours.GetString(4));
                }
            }
        }




        private void buttonDemarrer_Click(object sender, EventArgs e)
        {
            // démarrage de la course
            dataCourseHeure = DateTime.Now;

            Courses creeCourse = new Courses(dataCourseNom, dataCourseDate, dataCourseDistance, dataCourseHeure);
            DbCourses ModCourse = new DbCourses();
            (bool result, string MessErreur) = ModCourse.ModifierCourse(creeCourse, Convert.ToInt16(idxCourseEnCours));
            if (result == false)
            {
                MessageBox.Show("Une erreur c'est produit lors de la mise a jour de l'heure de départ de la course, veuillez vérifier l'état dse votre base de Données, avec le message : " + MessErreur);
            }
            textBoxHeureDemar.Text = dataCourseHeure.ToLongTimeString();
            courseDemarree = true;

        }

        private void buttonArrivees_Click(object sender, EventArgs e)
        {
            jeScrute = new ResteEnEveille();
            recupTranspondeur = new Thread(new ThreadStart(jeScrute.testSuspention));
            recupTranspondeur.Start();
            textBoxMessage.Text = "Lecture des transpondeurs en cours";
        }

        private void buttonArret_Click(object sender, EventArgs e)
        {
            // arrêt de la course en cours

            try
            {
                recupTranspondeur.Abort();
            }
            catch { }

            textBoxMessage.Text = "Lecture des transpondeurs arrêtés";

        }

        private void LectureDuTranspondeur()
        {
            string chaineLu = "";
            while (Thread.CurrentThread.IsAlive)
            {
                Thread.Sleep(500);
                // lecture badgeage transpondeur
                lock (this)
                {
                    if (chaineLu != "")
                    {
                        // Mettre à jour le tuple de l'arrivée du coureur en récupérant son ID dans inscription avec le numéro de transpondeur

                    }
                }
            }
        }

        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            if (courseDemarree == true)
            {
                DialogResult quitterAppli =  MessageBox.Show("La course est démarrée, voulez-vous vraiment quitter l'application ?", "Quitter ?", MessageBoxButtons.YesNo); 
                if (quitterAppli == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }

        }



        private void buttonSuspendre_Click(object sender, EventArgs e)
        {
            try
            {
                jeScrute.SleepSwitch = true;
                textBoxMessage.Text = "Lecture des transpondeurs suspendu";
            }
            catch { }

        }

        private void buttonRedemarrer_Click(object sender, EventArgs e)
        {
            try
            {
                jeScrute.SleepSwitch = false;
                textBoxMessage.Text = "Lecture des transpondeurs en cours";
            }
            catch { }

        }


        class ResteEnEveille
        {
            bool sleepSwitch = false;

            public bool SleepSwitch
            {
                set { sleepSwitch = value; }
            }

            public ResteEnEveille() { }

            public void testSuspention()
            {
                while (!sleepSwitch)
                {
                    string chaineLu = "";

                    // lecture badgeage transpondeur

                    lock (this)
                    {
                        if (chaineLu != "")
                        {
                            // Mettre à jour le tuple de l'arrivée du coureur en récupérant son ID dans inscription avec le numéro de transpondeur

                        }
                    }
                }
                try
                {
                    Thread.Sleep(Timeout.Infinite);
                }
                catch (ThreadInterruptedException e)
                {

                }
            }
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
