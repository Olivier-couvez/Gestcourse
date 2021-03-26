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

namespace GestionArrivee
{
    public partial class AjoutCoureur : Form
    {
        DbClubs baseClubs;
        DbCategories baseCategories;
        List<string> listeDesNomClubs = new List<string>();
        List<string> listeDesIdxClubs = new List<string>();
        List<string> listeDesNomCategories = new List<string>();
        List<string> listeDesIdxCategories = new List<string>();


        public AjoutCoureur()
        {
            InitializeComponent();
        }
        
        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TableCoureurAjout_Load(object sender, EventArgs e)
        {

            // remplir la liste des clubs avec memorisaion de l'id

            //  lecture tous Club

            baseClubs = new DbClubs();
            MySqlDataReader readerCl = baseClubs.LecturetoutClub();

            if (readerCl != null)          // on teste si la requete a bien retournéer un résultat
            {
                // Vérifie si des données sont présente dans reader
                if (readerCl.HasRows)
                {
                    int i = 0;
                    while (readerCl.Read())
                    {
                        // Ajout de la ligne au liste clubs.

                        listeDesNomClubs.Add(readerCl.GetString(1));
                        listeDesIdxClubs.Add(readerCl.GetString(0));
                        comboBoxClub.Items.Add(readerCl.GetString(1));
                        i++;
                    }
                    //comboBoxClub.SelectedIndex = 0;
                }
            }

            //  lecture toutes catégories

            baseCategories = new DbCategories();
            MySqlDataReader readerCa = baseCategories.LecturetoutCategories();

            if (readerCa != null)          // on teste si la requete a bien retournéer un résultat
            {
                // Vérifie si des données sont présente dans reader
                if (readerCa.HasRows)
                {
                    int i = 0;
                    while (readerCa.Read())
                    {
                        // Ajout de la ligne au liste clubs.
                        listeDesNomCategories.Add(readerCa.GetString(1));
                        listeDesIdxCategories.Add(readerCa.GetString(0));
                        comboBoxCategorie.Items.Add(readerCa.GetString(1));
                        i++;
                    }
                    //comboBoxCategorie.SelectedIndex = 0;
                }
            }
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            // récup booléen sexe et index club et categorie

            char sexe = '1';
            int idxClub = 0, idxCat = 0;

            // recup index club et catégorie

            idxClub = Convert.ToInt16(listeDesIdxClubs[Convert.ToInt16(comboBoxClub.SelectedIndex)]);
            idxCat = Convert.ToInt16(listeDesIdxCategories[Convert.ToInt16(comboBoxCategorie.SelectedIndex)]);

            // recup sexe 

            if (radioButtonFeminin.Checked == true)
            {
                sexe = '0';
            }

            // formattage date de naissance en date time

            string datnais = Convert.ToDateTime(maskedTextBoxDateNaiss.Text).ToString("s", DateTimeFormatInfo.InvariantInfo);
            datnais = datnais.Replace("T", " ");
            DateTime datnaisformater = DateTime.ParseExact(datnais, "yyyy-MM-dd h:mm:ss", CultureInfo.InvariantCulture);


            Coureurs creeCoureurs = new Coureurs(idxClub, textBoxNom.Text, textBoxprenom.Text, textBoxAdresse.Text, Convert.ToInt32(maskedTextBoxCP.Text), textBoxVille.Text, datnaisformater, sexe, idxCat);
            DbCoureurs AjoutCoureurs = new DbCoureurs();
            bool result = AjoutCoureurs.AjouterCoureur(creeCoureurs);
            if (result == false)
            {
                MessageBox.Show("La création à échouée, veuillez vérifier l'état de votre base de Données");
            }
            else
            {
                MessageBox.Show("Création coureur " + textBoxNom.Text + " effectuée !");
                comboBoxClub.SelectedIndex = 0;
                textBoxNom.Text = "";
                textBoxprenom.Text = "";
                textBoxAdresse.Text = "";
                maskedTextBoxCP.Text = "";
                textBoxVille.Text = "";
                maskedTextBoxDateNaiss.Text = "";
                radioButtonMasculin.Checked = false;
                radioButtonFeminin.Checked = false;
                comboBoxCategorie.SelectedIndex = 0;
            }
        }
    }
}
