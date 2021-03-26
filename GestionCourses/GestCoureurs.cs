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
    public partial class GestCoureurs : Form
    {
        DataGridViewRow ligneSelect;
        DbCoureurs BaseCoureurs;
        DbClubs baseClubs;
        DbCategories baseCategories;
        int IdxLigneActuelle = -1;
        List<string> listeDesNomClubs = new List<string>();
        List<string> listeDesIdxClubs = new List<string>();
        List<string> listeDesNomCategories = new List<string>();
        List<string> listeDesIdxCategories = new List<string>();

        public GestCoureurs()
        {
            InitializeComponent();

        }

        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GestCoureurs_Load(object sender, EventArgs e)
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

            // mise à jour de la ligne

            MajGrid();
        }

        private void buttonCreer_Click(object sender, EventArgs e)
        {
            AjoutCoureur fenAjoutCoureur = new AjoutCoureur();
            DialogResult Fermeture = fenAjoutCoureur.ShowDialog();
            MajGrid();
        }


        private void buttonModifier_Click(object sender, EventArgs e)
        {
            
            if (IdxLigneActuelle != -1)
            {
                DialogResult reponse = MessageBox.Show("Voulez vous vraiment modifier le coureur " + textBoxNom.Text + " ?", "Modification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (reponse == DialogResult.Yes)
                {
                    // récup booléen sexe et index club et categorie

                    char sexe = '0';
                    int idxClub = 0, idxCat = 0;

                    // recup index club et catégorie

                    idxClub = Convert.ToInt16(listeDesIdxClubs[Convert.ToInt16(comboBoxClub.SelectedIndex)]);
                    idxCat = Convert.ToInt16(listeDesIdxCategories[Convert.ToInt16(comboBoxCategorie.SelectedIndex)]);

                    // recup sexe 

                    if (radioButtonFeminin.Checked == true)
                    {
                        sexe = '1';
                    }

                    // formattage date de naissance en date time

                    string datnais = Convert.ToDateTime(maskedTextBoxDateNaiss.Text).ToString("s", DateTimeFormatInfo.InvariantInfo);
                    datnais = datnais.Replace("T", " ");
                    DateTime datnaisformater = DateTime.ParseExact(datnais, "yyyy-MM-dd h:mm:ss", CultureInfo.InvariantCulture);


                    Coureurs creeCoureurs = new Coureurs(idxClub, textBoxNom.Text, textBoxPrenom.Text, textBoxAdresse.Text, Convert.ToInt32(maskedTextBoxCP.Text), textBoxVille.Text, datnaisformater, sexe, idxCat);
                    DbCoureurs ModCoureurs = new DbCoureurs();
                    (bool result, string MessErreur) = ModCoureurs.ModifierCoureurs(creeCoureurs, Convert.ToInt16(textBoxID.Text));
                    if (result == false)
                    {
                        MessageBox.Show("La modification à échouée, veuillez vérifier l'état dse votre base de Données, avec le message : " + MessErreur);
                    }
                    else
                    {
                        MessageBox.Show("La modification du coureur " + textBoxNom.Text + " effectuée !");
                    }
                    MajGrid();
                }
            }
        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            if (IdxLigneActuelle != -1)
            {
                DialogResult reponse = MessageBox.Show("Voulez vous vraiment supprimer le Coureur " + textBoxNom.Text + " ?", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (reponse == DialogResult.Yes)
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

                    Coureurs creeCoureurs = new Coureurs(idxClub, textBoxNom.Text, textBoxPrenom.Text, textBoxAdresse.Text, Convert.ToInt32(maskedTextBoxCP.Text), textBoxVille.Text, datnaisformater, sexe, idxCat); DbCoureurs SupCoureurs = new DbCoureurs();
                    (bool result, string MessErreur) = SupCoureurs.SupprimerCoureurs(creeCoureurs, Convert.ToInt16(textBoxID.Text));
                    if (result == false)
                    {
                        MessageBox.Show("La suppression à échouée, veuillez vérifier l'état de votre base de Données, avec le message : "+ MessErreur);
                    }
                    else
                    {
                        MessageBox.Show("La suppression du coureur " + ligneSelect.Cells[1].Value.ToString() + " effectuée !");
                        MajGrid();
                    }
                }
            }
        }

        // Lecture base et mise a jour du datagrid

        private void MajGrid()
        {
            dataGridViewCoureurs.Rows.Clear();
            int idxmodclub = 0, idxmodcategorie = 0;

            // lecture table complète de la base.
            BaseCoureurs = new DbCoureurs();
            MySqlDataReader reader = BaseCoureurs.LecturetoutCoureurs();

            if (reader != null)          // on teste si la requete a bien retournéer un résultat
            {

                // Vérifie si des données sont présente dans reader

                if (reader.HasRows)
                {
                    int i = 0;
                    while (reader.Read())
                    {
                        // transforme sexe et index club et catégorie

                        for (int j = 0;j<listeDesIdxClubs.Count;j++)
                        {
                            if (reader.GetString(1) == listeDesIdxClubs[j])
                            {
                                idxmodclub = j;
                            }
                        }
                        for (int x = 0; x < listeDesIdxCategories.Count; x++)
                        {
                            if (reader.GetString(9) == listeDesIdxCategories[x])
                            {
                                idxmodcategorie = x;
                            }
                        }

                        // Ajout de la ligne au gridview.

                        dataGridViewCoureurs.Rows.Add(Convert.ToInt16(reader.GetString(0)), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetString(8), listeDesNomClubs[idxmodclub], reader.GetString(1), listeDesNomCategories[idxmodcategorie], reader.GetString(9));
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
            // index club
            textBoxNom.Text = ligneSelect.Cells[1].Value.ToString();
            textBoxPrenom.Text = ligneSelect.Cells[2].Value.ToString();
            textBoxAdresse.Text = ligneSelect.Cells[3].Value.ToString();
            maskedTextBoxCP.Text = ligneSelect.Cells[4].Value.ToString();
            textBoxVille.Text = ligneSelect.Cells[5].Value.ToString();
            maskedTextBoxDateNaiss.Text = ligneSelect.Cells[6].Value.ToString();

            // seclectionne le bon dans la combobox.

            string nomClub = ligneSelect.Cells[8].Value.ToString();
            string nomCat = ligneSelect.Cells[10].Value.ToString();

            for (int i=0;i<comboBoxClub.Items.Count;i++)
            {
                if (nomClub == comboBoxClub.Items[i].ToString())
                {
                    comboBoxClub.SelectedIndex = i;
                }
            }

            for (int i = 0; i < comboBoxCategorie.Items.Count; i++)
            {
                if (nomCat == comboBoxCategorie.Items[i].ToString())
                {
                    comboBoxCategorie.SelectedIndex = i;
                }
            }

            // transforme sexe et index club et cat.

            char sexe = Convert.ToChar(ligneSelect.Cells[7].Value.ToString());

            if (sexe == '1')
            {
                radioButtonFeminin.Checked = true;
            }else
            {
                radioButtonMasculin.Checked = true;
            }
        }  
    }
}
