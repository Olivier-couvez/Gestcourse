
namespace GestionCourses
{
    partial class GestClassCourse
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxCourses = new System.Windows.Forms.ComboBox();
            this.labeltitre = new System.Windows.Forms.Label();
            this.buttonAfficher = new System.Windows.Forms.Button();
            this.buttonQuitter = new System.Windows.Forms.Button();
            this.listViewClassement = new System.Windows.Forms.ListView();
            this.Classement = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Dossard = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prenom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Categorie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Clubs = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Temps = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Choix de la course";
            // 
            // comboBoxCourses
            // 
            this.comboBoxCourses.FormattingEnabled = true;
            this.comboBoxCourses.Location = new System.Drawing.Point(22, 101);
            this.comboBoxCourses.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxCourses.Name = "comboBoxCourses";
            this.comboBoxCourses.Size = new System.Drawing.Size(315, 21);
            this.comboBoxCourses.TabIndex = 5;
            // 
            // labeltitre
            // 
            this.labeltitre.AutoSize = true;
            this.labeltitre.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltitre.Location = new System.Drawing.Point(129, 9);
            this.labeltitre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labeltitre.Name = "labeltitre";
            this.labeltitre.Size = new System.Drawing.Size(707, 44);
            this.labeltitre.TabIndex = 7;
            this.labeltitre.Text = "Affichage du classement d\'une course";
            // 
            // buttonAfficher
            // 
            this.buttonAfficher.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAfficher.Location = new System.Drawing.Point(435, 90);
            this.buttonAfficher.Name = "buttonAfficher";
            this.buttonAfficher.Size = new System.Drawing.Size(114, 33);
            this.buttonAfficher.TabIndex = 8;
            this.buttonAfficher.Text = "Afficher";
            this.buttonAfficher.UseVisualStyleBackColor = true;
            this.buttonAfficher.Click += new System.EventHandler(this.buttonAfficher_Click);
            // 
            // buttonQuitter
            // 
            this.buttonQuitter.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuitter.Location = new System.Drawing.Point(868, 514);
            this.buttonQuitter.Name = "buttonQuitter";
            this.buttonQuitter.Size = new System.Drawing.Size(114, 33);
            this.buttonQuitter.TabIndex = 9;
            this.buttonQuitter.Text = "Quitter";
            this.buttonQuitter.UseVisualStyleBackColor = true;
            this.buttonQuitter.Click += new System.EventHandler(this.buttonQuitter_Click);
            // 
            // listViewClassement
            // 
            this.listViewClassement.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Classement,
            this.Dossard,
            this.Nom,
            this.Prenom,
            this.Categorie,
            this.Clubs,
            this.Temps});
            this.listViewClassement.HideSelection = false;
            this.listViewClassement.Location = new System.Drawing.Point(22, 129);
            this.listViewClassement.Name = "listViewClassement";
            this.listViewClassement.Size = new System.Drawing.Size(960, 379);
            this.listViewClassement.TabIndex = 10;
            this.listViewClassement.UseCompatibleStateImageBehavior = false;
            // 
            // Classement
            // 
            this.Classement.Text = "Classement";
            this.Classement.Width = 70;
            // 
            // Dossard
            // 
            this.Dossard.Text = "Dossard";
            this.Dossard.Width = 70;
            // 
            // Nom
            // 
            this.Nom.Text = "Nom";
            this.Nom.Width = 170;
            // 
            // Prenom
            // 
            this.Prenom.Text = "Prénom";
            this.Prenom.Width = 170;
            // 
            // Categorie
            // 
            this.Categorie.Text = "Catégorie";
            this.Categorie.Width = 120;
            // 
            // Clubs
            // 
            this.Clubs.Text = "Clubs";
            this.Clubs.Width = 120;
            // 
            // Temps
            // 
            this.Temps.Text = "Temps";
            this.Temps.Width = 150;
            // 
            // GestClassCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 559);
            this.Controls.Add(this.listViewClassement);
            this.Controls.Add(this.buttonQuitter);
            this.Controls.Add(this.buttonAfficher);
            this.Controls.Add(this.labeltitre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxCourses);
            this.Name = "GestClassCourse";
            this.Text = "Classement d\'une course";
            this.Load += new System.EventHandler(this.GestClassCourse_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxCourses;
        private System.Windows.Forms.Label labeltitre;
        private System.Windows.Forms.Button buttonAfficher;
        private System.Windows.Forms.Button buttonQuitter;
        private System.Windows.Forms.ListView listViewClassement;
        private System.Windows.Forms.ColumnHeader Classement;
        private System.Windows.Forms.ColumnHeader Dossard;
        private System.Windows.Forms.ColumnHeader Nom;
        private System.Windows.Forms.ColumnHeader Prenom;
        private System.Windows.Forms.ColumnHeader Categorie;
        private System.Windows.Forms.ColumnHeader Clubs;
        private System.Windows.Forms.ColumnHeader Temps;
    }
}