using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace GestionCourses
{
    public partial class ParametreServeur : Form
    {
        
        public ParametreServeur()
        {
            InitializeComponent();
        }
        public string Serveur
        {
            get
            {
                return textBoxServeur.Text;
            }

            set
            {
                textBoxServeur.Text = value;

            }
        }
        public string Base
        {
            get
            {
                return textBoxBase.Text;
            }

            set
            {
                textBoxBase.Text = value;

            }
        }
        public string Port
        {
            get
            {
                return textBoxPort.Text;
            }

            set
            {
                textBoxPort.Text = value;

            }
        }
        public string Utilisateur
        {
            get
            {
                return textBoxUtilisateur.Text;
            }

            set
            {
                textBoxUtilisateur.Text = value;

            }
        }
        public string Mdp
        {
            get
            {
                return textBoxMdp.Text;
            }

            set
            {
                textBoxMdp.Text = value;

            }
        }


        private void ParametreServeur_Load(object sender, EventArgs e)
        {

            // lecture app config

            string bddServeur = ConfigurationManager.AppSettings["serveur"];
            string sBddPort = ConfigurationManager.AppSettings["port"];
            int bddPort = Convert.ToInt16(sBddPort);
            string bddBase = ConfigurationManager.AppSettings["base"];
            string bddIdent = ConfigurationManager.AppSettings["identificateur"];
            string bddMdp = ConfigurationManager.AppSettings["mdp"];

            textBoxServeur.Text = bddServeur;
            textBoxPort.Text = sBddPort;
            textBoxBase.Text = bddBase;
            textBoxUtilisateur.Text = bddIdent;
            textBoxMdp.Text = bddMdp;
        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings.Remove("serveur");
            config.AppSettings.Settings.Add("serveur", textBoxServeur.Text);
            config.AppSettings.Settings.Remove("port");
            config.AppSettings.Settings.Add("port", textBoxPort.Text);
            config.AppSettings.Settings.Remove("base");
            config.AppSettings.Settings.Add("base", textBoxBase.Text);
            config.AppSettings.Settings.Remove("identificateur");
            config.AppSettings.Settings.Add("identificateur", textBoxUtilisateur.Text);
            config.AppSettings.Settings.Remove("mdp");
            config.AppSettings.Settings.Add("mdp", textBoxMdp.Text);
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }
    }
}
