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
    public partial class GestInscriptions : Form
    {
        DataGridViewRow ligneSelect;
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
        int IdxLigneActuelle = -1;

        public GestInscriptions()
        {
            InitializeComponent();

        }

        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GestCoureurs_Load(object sender, EventArgs e)
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
                        // Ajout de la ligne au liste clubs.
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

            // mise à jour de la ligne

            MajGrid();
        }

        private void buttonCreer_Click(object sender, EventArgs e)
        {
            InscriptionCourse fenInscription = new InscriptionCourse();
            DialogResult Fermeture = fenInscription.ShowDialog();
            MajGrid();
        }


        private void buttonModifier_Click(object sender, EventArgs e)
        {
            
            if (IdxLigneActuelle != -1)
            {
                DialogResult reponse = MessageBox.Show("Voulez vous vraiment modifier l'inscription " + textBoxDossard.Text + " ?", "Modification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (reponse == DialogResult.Yes)
                {
                    // récup  index 

                    Int32 idxCourse = 0, idxCoureur = 0, idxTransp = 0;

                    // recup index club et catégorie

                    idxCourse = Convert.ToInt16(listeDesIdxCourses[Convert.ToInt32(comboBoxCourse.SelectedIndex)]);
                    idxCoureur = Convert.ToInt16(listeDesIdxCoureurs[Convert.ToInt32(comboBoxCoureur.SelectedIndex)]);
                    idxTransp = Convert.ToInt16(listeDesIdxTranspondeurs[Convert.ToInt32(comboBoxTranspondeur.SelectedIndex)]);


                    Inscriptions creeInscriptions = new Inscriptions( Convert.ToInt32(textBoxDossard.Text), idxCoureur, idxTransp,idxCourse);
                    DbInscriptions ModInscriptions = new DbInscriptions();
                    (bool result, string MessErreur) = ModInscriptions.ModifierInscription(creeInscriptions, Convert.ToInt16(textBoxID.Text));
                    if (result == false)
                    {
                        MessageBox.Show("La modification à échouée, veuillez vérifier l'état dse votre base de Données, avec le message : " + MessErreur);
                    }
                    else
                    {
                        MessageBox.Show("La modification de l'inscription " + textBoxDossard.Text + " effectuée !");
                    }
                    MajGrid();
                }
            }
        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            if (IdxLigneActuelle != -1)
            {
                DialogResult reponse = MessageBox.Show("Voulez vous vraiment supprimer le Coureur " + textBoxDossard.Text + " ?", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (reponse == DialogResult.Yes)
                {
                    // récup index

                    Int32 idxCourse = 0, idxCoureur = 0, idxTransp = 0;

                    // recup index club et catégorie

                    idxCourse = Convert.ToInt32(listeDesIdxCoureurs[Convert.ToInt32(comboBoxCoureur.SelectedIndex)]);
                    idxCoureur = Convert.ToInt32(listeDesIdxCourses[Convert.ToInt32(comboBoxCourse.SelectedIndex)]);
                    idxTransp = Convert.ToInt32(listeDesIdxTranspondeurs[Convert.ToInt32(comboBoxTranspondeur.SelectedIndex)]);


                    Inscriptions creeInscriptions = new Inscriptions(Convert.ToInt32(textBoxDossard.Text), idxCourse, idxCoureur, idxTransp);
                    DbInscriptions SupInscriptions = new DbInscriptions();
                    (bool result, string MessErreur) = SupInscriptions.SupprimerInscription(creeInscriptions, Convert.ToInt32(textBoxID.Text));
                    if (result == false)
                    {
                        MessageBox.Show("La suppression à échouée, veuillez vérifier l'état de votre base de Données, avec le message : "+ MessErreur);
                    }
                    else
                    {
                        MessageBox.Show("La suppression du dossard " + ligneSelect.Cells[1].Value.ToString() + " effectuée !");
                        MajGrid();
                    }
                }
            }
        }

        // Lecture base et mise a jour du datagrid

        private void MajGrid()
        {
            dataGridViewCoureurs.Rows.Clear();
            int idxmodcourse = 0, idxmodcoureur = 0, idxmodtransp = 0;

            // lecture table complète de la base.
            baseInscriptions = new DbInscriptions();
            MySqlDataReader reader = baseInscriptions.LecturetoutInscription();

            if (reader != null)          // on teste si la requete a bien retournéer un résultat
            {

                // Vérifie si des données sont présente dans reader

                if (reader.HasRows)
                {
                    int i = 0;
                    while (reader.Read())
                    {
                        // transforme index 

                        for (int j = 0;j<listeDesIdxCourses.Count;j++)
                        {
                            if (reader.GetString(4) == listeDesIdxCourses[j])
                            {
                                idxmodcourse = j;
                            }
                        }
                        for (int x = 0; x < listeDesIdxCoureurs.Count; x++)
                        {
                            if (reader.GetString(2) == listeDesIdxCoureurs[x])
                            {
                                idxmodcoureur = x;
                            }
                        }
                        for(int y = 0; y < listeDesIdxTranspondeurs.Count; y++)
                        {
                            if (reader.GetString(3) == listeDesIdxTranspondeurs[y])
                            {
                                idxmodtransp = y;
                            }
                        }

                        // Ajout de la ligne au gridview.

                        dataGridViewCoureurs.Rows.Add(Convert.ToInt32(reader.GetString(0)), reader.GetString(1), listeDesNomCourses[idxmodcourse], reader.GetString(4), listeDesNomCoureurs[idxmodcoureur], reader.GetString(2), listeDesNomTranspondeurs[idxmodtransp], reader.GetString(3));
                        i ++;
                    }

                }
            }
        }

        private void dataGridViewCoureurs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IdxLigneActuelle = e.RowIndex;
            ligneSelect = dataGridViewCoureurs.Rows[IdxLigneActuelle];
            textBoxID.Text = ligneSelect.Cells[0].Value.ToString();
            // index 
            textBoxDossard.Text = ligneSelect.Cells[1].Value.ToString();



            // seclectionne le bon dans la combobox.

            string nomCourse = ligneSelect.Cells[2].Value.ToString();
            string nomCoureur = ligneSelect.Cells[4].Value.ToString();
            string nomtransp = ligneSelect.Cells[6].Value.ToString();

            for (int i=0;i<comboBoxCourse.Items.Count;i++)
            {
                if (nomCourse == comboBoxCourse.Items[i].ToString())
                {
                    comboBoxCourse.SelectedIndex = i;
                }
            }

            for (int i = 0; i < comboBoxCoureur.Items.Count; i++)
            {
                if (nomCoureur == comboBoxCoureur.Items[i].ToString())
                {
                    comboBoxCoureur.SelectedIndex = i;
                }
            }

            for (int i = 0; i < comboBoxTranspondeur.Items.Count; i++)
            {
                if (nomtransp == comboBoxTranspondeur.Items[i].ToString())
                {
                    comboBoxTranspondeur.SelectedIndex = i;
                }
            }

        }
    }
}
