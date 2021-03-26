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
    public partial class AjoutCourses : Form
    {
        public AjoutCourses()
        {
            InitializeComponent();
        }

        private void buttonCreer_Click(object sender, EventArgs e)
        {
            Courses creeCourse = new Courses(textBoxNom.Text, Convert.ToDateTime(textBoxAdr.Text), textBoxCP.Text, Convert.ToDateTime(textBoxVille.Text), Convert.ToInt16("0"));
            DbCourses AjoutCourses = new DbCourses();
            bool result = AjoutCourses.AjouterCourse(creeCourse);
            if (result == false)
            {
                MessageBox.Show("La création à échouée, veuillez vérifier l'état de votre base de Données");
            }
            else
            {
                MessageBox.Show("Création course " + textBoxNom.Text + " effectuée !");
                textBoxNom.Text = "";
                textBoxAdr.Text= "";
                textBoxCP.Text = "";
                textBoxVille.Text = "";
            }


        }

        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
