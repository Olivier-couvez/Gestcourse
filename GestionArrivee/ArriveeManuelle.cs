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

namespace GestionArrivee
{
    public partial class ArriveeManuelle : Form
    {
        DbInscriptions baseInscription;
        public ArriveeManuelle()
        {
            InitializeComponent();
        }

        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            int idInscrit = 0;
            Int32 numTranspondeur;
            int idArrivee = 0;
            bool ecrireEnreg = true;
            bool modifierEnreg = false;
            bool faireMaj = false;

            DateTime arriveeCoureur;
            if (comboBoxTranspondeur.SelectedIndex != -1)
            {
                // lecture de l'enregistrement de la table inscription.

                numTranspondeur = Convert.ToInt32(comboBoxTranspondeur.SelectedItem);

                DbInscriptions lectInscription = new DbInscriptions();
                // (bool opeOk, string messErreur, 
                MySqlDataReader readerInscrit = lectInscription.LectureunInscrit(Convert.ToInt32( comboBoxTranspondeur.SelectedItem));
                //if (opeOk == true)
                //{
                if (readerInscrit != null)          // on teste si la requete a bien retournée un résultat
                {
                    // Vérifie si des données sont présente dans reader

                    if (readerInscrit.HasRows)
                    {
                        readerInscrit.Read();
                        idInscrit = Convert.ToInt16(readerInscrit.GetString(0));
                        faireMaj = true;
                    }
                    else
                    {
                        MessageBox.Show("Une erreur s'est produite il n'y a pas d'inscrit pour le numero de transpondeur : " + numTranspondeur);
                    }
                }
                else
                {
                    MessageBox.Show("Une erreur s'est produite il n'y a pas d'inscrit pour le numero de transpondeur : " + numTranspondeur);
                }
                //}
                //else
                //{
                //    MessageBox.Show("Une erreur s'est produite lors de la lecture d'un inscrit, veuillez vérifier l'état dse votre base de Données, avec le message : " + messErreur);
                //}

                if (faireMaj == true)
                {
                    // Verification si transpondeur deja existant, ex : passé deux fois devant le portique.

                    DbArrivee dejaArrivee = new DbArrivee();
                    MySqlDataReader readerDejaArrivee = dejaArrivee.LectureUnArrivee(idInscrit);

                    if (readerDejaArrivee != null)          // on teste si la requete a bien retournéer un résultat
                    {
                        // Vérifie si des données sont présente dans reader

                        if (readerDejaArrivee.HasRows)
                        {
                            DialogResult refaireEnreg = MessageBox.Show("ATTENTION : ce badge est deja enregistré, refaire l'enregistrement ?", "Enregistrer encore !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (refaireEnreg == DialogResult.No)
                            {
                                modifierEnreg = false;
                                ecrireEnreg = false;
                            }
                            else
                            {
                                modifierEnreg = true;
                                readerDejaArrivee.Read();
                                idArrivee = Convert.ToInt16(readerDejaArrivee.GetString(0));
                            }

                        }
                    }

                    if (ecrireEnreg == true)
                    {
                        if (modifierEnreg == true)
                        {
                            arriveeCoureur = Convert.ToDateTime(maskedTextBoxHeureArrivee.Text);
                            Arrivee modifArrivee = new Arrivee(arriveeCoureur, idInscrit);
                            DbArrivee ModifierArrivee = new DbArrivee();
                            (bool result, string messErreur) = ModifierArrivee.ModifierArrivee(modifArrivee, idArrivee);
                            if (result == false)
                            {
                                MessageBox.Show("La création à échouée, veuillez vérifier l'état de votre base de Données" + messErreur);
                            }
                            else
                            {
                                MessageBox.Show("Arrivée du coureur mise à jour !");
                            }
                        }
                        else
                        {
                            arriveeCoureur = Convert.ToDateTime(maskedTextBoxHeureArrivee.Text);
                            Arrivee creeArrivee = new Arrivee(arriveeCoureur, idInscrit);
                            DbArrivee AjoutArrivee = new DbArrivee();
                            bool result = AjoutArrivee.AjouterArrivee(creeArrivee);
                            if (result == false)
                            {
                                MessageBox.Show("La création à échouée, veuillez vérifier l'état de votre base de Données");
                            }
                            else
                            {
                                MessageBox.Show("Arrivée du coureur effectuée !");
                            }
                        }

                    }
                }
            }
        }

        private void ArriveeManuelle_Load(object sender, EventArgs e)
        {

            //  lecture ionscription de la course choisie

            baseInscription = new DbInscriptions();
            MySqlDataReader readerCa = baseInscription.LectureInscriptioncourse(Convert.ToInt16(labelIdCourse.Text));

            if (readerCa != null)          // on teste si la requete a bien retournéer un résultat
            {
                // Vérifie si des données sont présente dans reader
                if (readerCa.HasRows)
                {
                    int i = 0;
                    while (readerCa.Read())
                    {
                        // Ajout de la ligne au liste transpondeur.
                        comboBoxTranspondeur.Items.Add(readerCa.GetString(3));
                        i++;
                    }
                }
            }

            maskedTextBoxHeureArrivee.Text = Convert.ToString(DateTime.Now);
        }


        public String Idourses
        {
            get
            {
                return labelIdCourse.Text;
            }
            set
            {
                labelIdCourse.Text = value;
            }
        }
    }
}
