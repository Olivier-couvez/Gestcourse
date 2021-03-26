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

namespace GestionArrivee
{
    public partial class DemarrageCourse : Form
    {
        DbCourses baseCourses;
        DbCourses courseEnCours;
        int idxCourseEC = 0;
        List<string> listeDesNomCourses = new List<string>();
        List<string> listeDesIdxCourses = new List<string>();

        Thread recupTranspondeur;
        ResteEnEveille jeScrute;

        public DemarrageCourse()
        {
            InitializeComponent();
        }

        private void DemarrageCourse_Load(object sender, EventArgs e)
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
                        comboBoxCourses.Items.Add(readercourse.GetString(1));
                        i++;
                    }
                }
            }

            // lesture si course en cours

            string courseEC = ConfigurationManager.AppSettings["idxcourse"];

            if (courseEC != "")
            {
                courseEnCours = new DbCourses();
                MySqlDataReader readercourseEnCours = courseEnCours.LectureUneCourse(Convert.ToInt16(courseEC));

                if (readercourseEnCours != null)          // on teste si la requete a bien retournéer un résultat
                {
                    // Vérifie si des données sont présente dans reader

                    if (readercourseEnCours.HasRows)
                    {
                        textBoxEnCours.Text = readercourse.GetString(1);
                        idxCourseEC = Convert.ToInt16(readercourse.GetString(0));

                        for (int i = 0; i < comboBoxCourses.Items.Count; i++)
                        {
                            if (textBoxEnCours.Text == comboBoxCourses.Items[i].ToString())
                            {
                                comboBoxCourses.SelectedIndex = i;
                            }
                        }
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
                textBoxEnCours.Text = listeDesNomCourses[comboBoxCourses.SelectedIndex];
                idxCourseEC = Convert.ToInt16(listeDesIdxCourses[comboBoxCourses.SelectedIndex]);
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.Settings.Remove("idxcourse");
                config.AppSettings.Settings.Add("idxcourse", listeDesIdxCourses[comboBoxCourses.SelectedIndex]);
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
                jeScrute = new ResteEnEveille();
                recupTranspondeur = new Thread(new ThreadStart(jeScrute.testSuspention));
                recupTranspondeur.Start();
                textBoxMessage.Text = "Lecture des transpondeurs en cours";
            }
            else
            {
                MessageBox.Show("Vous n'avez pas sélectioné de course !");
            }




        }

        private void buttonArret_Click(object sender, EventArgs e)
        {
            // arrêt de la course en cours

            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings.Remove("idxcourse");
            config.AppSettings.Settings.Add("idxcourse", "");
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
            //recupTranspondeur.Join();
            try
            {
                recupTranspondeur.Abort();
            }
            catch { }
            
            textBoxEnCours.Text = "";
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
            }catch { }
           
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
    }
}

