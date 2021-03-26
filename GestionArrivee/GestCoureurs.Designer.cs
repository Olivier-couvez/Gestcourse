namespace GestionArrivee
{
    partial class GestCoureurs
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
            this.dataGridViewCoureurs = new System.Windows.Forms.DataGridView();
            this.buttonQuitter = new System.Windows.Forms.Button();
            this.buttonCreer = new System.Windows.Forms.Button();
            this.buttonModifier = new System.Windows.Forms.Button();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxPrenom = new System.Windows.Forms.TextBox();
            this.textBoxAdresse = new System.Windows.Forms.TextBox();
            this.textBoxVille = new System.Windows.Forms.TextBox();
            this.maskedTextBoxDateNaiss = new System.Windows.Forms.MaskedTextBox();
            this.labelDateNaiss = new System.Windows.Forms.Label();
            this.groupBoxSexe = new System.Windows.Forms.GroupBox();
            this.radioButtonMasculin = new System.Windows.Forms.RadioButton();
            this.radioButtonFeminin = new System.Windows.Forms.RadioButton();
            this.maskedTextBoxCP = new System.Windows.Forms.MaskedTextBox();
            this.labelCP = new System.Windows.Forms.Label();
            this.labelCategorie = new System.Windows.Forms.Label();
            this.labelClub = new System.Windows.Forms.Label();
            this.labelVille = new System.Windows.Forms.Label();
            this.labelAdresse = new System.Windows.Forms.Label();
            this.labelPrenom = new System.Windows.Forms.Label();
            this.labelNom = new System.Windows.Forms.Label();
            this.comboBoxCategorie = new System.Windows.Forms.ComboBox();
            this.comboBoxClub = new System.Windows.Forms.ComboBox();
            this.IdCategorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ville = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateNaiss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.club = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idxClub = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idxCat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCoureurs)).BeginInit();
            this.groupBoxSexe.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewCoureurs
            // 
            this.dataGridViewCoureurs.AllowUserToAddRows = false;
            this.dataGridViewCoureurs.AllowUserToDeleteRows = false;
            this.dataGridViewCoureurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCoureurs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCategorie,
            this.Nom,
            this.prenom,
            this.adresse,
            this.cp,
            this.ville,
            this.dateNaiss,
            this.sexe,
            this.club,
            this.idxClub,
            this.categorie,
            this.idxCat});
            this.dataGridViewCoureurs.Location = new System.Drawing.Point(12, 22);
            this.dataGridViewCoureurs.MultiSelect = false;
            this.dataGridViewCoureurs.Name = "dataGridViewCoureurs";
            this.dataGridViewCoureurs.ReadOnly = true;
            this.dataGridViewCoureurs.Size = new System.Drawing.Size(1060, 371);
            this.dataGridViewCoureurs.TabIndex = 0;
            this.dataGridViewCoureurs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCoureurs_CellContentClick);
            this.dataGridViewCoureurs.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCoureurs_CellContentClick);
            // 
            // buttonQuitter
            // 
            this.buttonQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuitter.Location = new System.Drawing.Point(958, 525);
            this.buttonQuitter.Name = "buttonQuitter";
            this.buttonQuitter.Size = new System.Drawing.Size(114, 34);
            this.buttonQuitter.TabIndex = 1;
            this.buttonQuitter.Text = "Quitter";
            this.buttonQuitter.UseVisualStyleBackColor = true;
            this.buttonQuitter.Click += new System.EventHandler(this.buttonQuitter_Click);
            // 
            // buttonCreer
            // 
            this.buttonCreer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreer.Location = new System.Drawing.Point(546, 522);
            this.buttonCreer.Name = "buttonCreer";
            this.buttonCreer.Size = new System.Drawing.Size(114, 34);
            this.buttonCreer.TabIndex = 2;
            this.buttonCreer.Text = "Créer";
            this.buttonCreer.UseVisualStyleBackColor = true;
            this.buttonCreer.Click += new System.EventHandler(this.buttonCreer_Click);
            // 
            // buttonModifier
            // 
            this.buttonModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModifier.Location = new System.Drawing.Point(666, 522);
            this.buttonModifier.Name = "buttonModifier";
            this.buttonModifier.Size = new System.Drawing.Size(114, 34);
            this.buttonModifier.TabIndex = 3;
            this.buttonModifier.Text = "Modifier";
            this.buttonModifier.UseVisualStyleBackColor = true;
            this.buttonModifier.Click += new System.EventHandler(this.buttonModifier_Click);
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSupprimer.Location = new System.Drawing.Point(786, 522);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(114, 34);
            this.buttonSupprimer.TabIndex = 4;
            this.buttonSupprimer.Text = "Supprimer";
            this.buttonSupprimer.UseVisualStyleBackColor = true;
            this.buttonSupprimer.Click += new System.EventHandler(this.buttonSupprimer_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.Enabled = false;
            this.textBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxID.Location = new System.Drawing.Point(12, 409);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.ReadOnly = true;
            this.textBoxID.Size = new System.Drawing.Size(68, 22);
            this.textBoxID.TabIndex = 5;
            this.textBoxID.Visible = false;
            // 
            // textBoxNom
            // 
            this.textBoxNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNom.Location = new System.Drawing.Point(86, 409);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(310, 22);
            this.textBoxNom.TabIndex = 6;
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrenom.Location = new System.Drawing.Point(402, 409);
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.Size = new System.Drawing.Size(208, 22);
            this.textBoxPrenom.TabIndex = 7;
            // 
            // textBoxAdresse
            // 
            this.textBoxAdresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAdresse.Location = new System.Drawing.Point(12, 454);
            this.textBoxAdresse.Name = "textBoxAdresse";
            this.textBoxAdresse.Size = new System.Drawing.Size(399, 22);
            this.textBoxAdresse.TabIndex = 8;
            // 
            // textBoxVille
            // 
            this.textBoxVille.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxVille.Location = new System.Drawing.Point(491, 454);
            this.textBoxVille.Name = "textBoxVille";
            this.textBoxVille.Size = new System.Drawing.Size(208, 22);
            this.textBoxVille.TabIndex = 10;
            // 
            // maskedTextBoxDateNaiss
            // 
            this.maskedTextBoxDateNaiss.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxDateNaiss.Location = new System.Drawing.Point(705, 454);
            this.maskedTextBoxDateNaiss.Mask = "00/00/0000";
            this.maskedTextBoxDateNaiss.Name = "maskedTextBoxDateNaiss";
            this.maskedTextBoxDateNaiss.Size = new System.Drawing.Size(91, 22);
            this.maskedTextBoxDateNaiss.TabIndex = 25;
            this.maskedTextBoxDateNaiss.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBoxDateNaiss.ValidatingType = typeof(System.DateTime);
            // 
            // labelDateNaiss
            // 
            this.labelDateNaiss.AutoSize = true;
            this.labelDateNaiss.Location = new System.Drawing.Point(702, 439);
            this.labelDateNaiss.Name = "labelDateNaiss";
            this.labelDateNaiss.Size = new System.Drawing.Size(96, 13);
            this.labelDateNaiss.TabIndex = 24;
            this.labelDateNaiss.Text = "Date de naissance";
            // 
            // groupBoxSexe
            // 
            this.groupBoxSexe.Controls.Add(this.radioButtonMasculin);
            this.groupBoxSexe.Controls.Add(this.radioButtonFeminin);
            this.groupBoxSexe.Location = new System.Drawing.Point(832, 409);
            this.groupBoxSexe.Name = "groupBoxSexe";
            this.groupBoxSexe.Size = new System.Drawing.Size(132, 85);
            this.groupBoxSexe.TabIndex = 26;
            this.groupBoxSexe.TabStop = false;
            this.groupBoxSexe.Text = "Sexe";
            // 
            // radioButtonMasculin
            // 
            this.radioButtonMasculin.AutoSize = true;
            this.radioButtonMasculin.Location = new System.Drawing.Point(6, 26);
            this.radioButtonMasculin.Name = "radioButtonMasculin";
            this.radioButtonMasculin.Size = new System.Drawing.Size(67, 17);
            this.radioButtonMasculin.TabIndex = 15;
            this.radioButtonMasculin.TabStop = true;
            this.radioButtonMasculin.Text = "Masculin";
            this.radioButtonMasculin.UseVisualStyleBackColor = true;
            // 
            // radioButtonFeminin
            // 
            this.radioButtonFeminin.AutoSize = true;
            this.radioButtonFeminin.Location = new System.Drawing.Point(6, 52);
            this.radioButtonFeminin.Name = "radioButtonFeminin";
            this.radioButtonFeminin.Size = new System.Drawing.Size(61, 17);
            this.radioButtonFeminin.TabIndex = 16;
            this.radioButtonFeminin.TabStop = true;
            this.radioButtonFeminin.Text = "Féminin";
            this.radioButtonFeminin.UseVisualStyleBackColor = true;
            // 
            // maskedTextBoxCP
            // 
            this.maskedTextBoxCP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxCP.Location = new System.Drawing.Point(417, 454);
            this.maskedTextBoxCP.Mask = "00000";
            this.maskedTextBoxCP.Name = "maskedTextBoxCP";
            this.maskedTextBoxCP.Size = new System.Drawing.Size(68, 22);
            this.maskedTextBoxCP.TabIndex = 28;
            this.maskedTextBoxCP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelCP
            // 
            this.labelCP.AutoSize = true;
            this.labelCP.Location = new System.Drawing.Point(414, 439);
            this.labelCP.Name = "labelCP";
            this.labelCP.Size = new System.Drawing.Size(63, 13);
            this.labelCP.TabIndex = 27;
            this.labelCP.Text = "Code postal";
            // 
            // labelCategorie
            // 
            this.labelCategorie.AutoSize = true;
            this.labelCategorie.Location = new System.Drawing.Point(277, 481);
            this.labelCategorie.Name = "labelCategorie";
            this.labelCategorie.Size = new System.Drawing.Size(52, 13);
            this.labelCategorie.TabIndex = 35;
            this.labelCategorie.Text = "Catégorie";
            // 
            // labelClub
            // 
            this.labelClub.AutoSize = true;
            this.labelClub.Location = new System.Drawing.Point(84, 481);
            this.labelClub.Name = "labelClub";
            this.labelClub.Size = new System.Drawing.Size(28, 13);
            this.labelClub.TabIndex = 33;
            this.labelClub.Text = "Club";
            // 
            // labelVille
            // 
            this.labelVille.AutoSize = true;
            this.labelVille.Location = new System.Drawing.Point(491, 439);
            this.labelVille.Name = "labelVille";
            this.labelVille.Size = new System.Drawing.Size(26, 13);
            this.labelVille.TabIndex = 32;
            this.labelVille.Text = "Ville";
            // 
            // labelAdresse
            // 
            this.labelAdresse.AutoSize = true;
            this.labelAdresse.Location = new System.Drawing.Point(12, 439);
            this.labelAdresse.Name = "labelAdresse";
            this.labelAdresse.Size = new System.Drawing.Size(45, 13);
            this.labelAdresse.TabIndex = 31;
            this.labelAdresse.Text = "Adresse";
            // 
            // labelPrenom
            // 
            this.labelPrenom.AutoSize = true;
            this.labelPrenom.Location = new System.Drawing.Point(402, 396);
            this.labelPrenom.Name = "labelPrenom";
            this.labelPrenom.Size = new System.Drawing.Size(43, 13);
            this.labelPrenom.TabIndex = 30;
            this.labelPrenom.Text = "Prénom";
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(83, 393);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(29, 13);
            this.labelNom.TabIndex = 29;
            this.labelNom.Text = "Nom";
            // 
            // comboBoxCategorie
            // 
            this.comboBoxCategorie.FormattingEnabled = true;
            this.comboBoxCategorie.Location = new System.Drawing.Point(281, 501);
            this.comboBoxCategorie.Name = "comboBoxCategorie";
            this.comboBoxCategorie.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCategorie.TabIndex = 37;
            // 
            // comboBoxClub
            // 
            this.comboBoxClub.FormattingEnabled = true;
            this.comboBoxClub.Location = new System.Drawing.Point(83, 501);
            this.comboBoxClub.Name = "comboBoxClub";
            this.comboBoxClub.Size = new System.Drawing.Size(121, 21);
            this.comboBoxClub.TabIndex = 36;
            // 
            // IdCategorie
            // 
            this.IdCategorie.Frozen = true;
            this.IdCategorie.HeaderText = "Ident.";
            this.IdCategorie.Name = "IdCategorie";
            this.IdCategorie.ReadOnly = true;
            this.IdCategorie.Width = 50;
            // 
            // Nom
            // 
            this.Nom.Frozen = true;
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            this.Nom.ReadOnly = true;
            this.Nom.Width = 150;
            // 
            // prenom
            // 
            this.prenom.HeaderText = "Prénom";
            this.prenom.Name = "prenom";
            this.prenom.ReadOnly = true;
            this.prenom.Width = 90;
            // 
            // adresse
            // 
            this.adresse.HeaderText = "Adresse";
            this.adresse.Name = "adresse";
            this.adresse.ReadOnly = true;
            this.adresse.Width = 230;
            // 
            // cp
            // 
            this.cp.HeaderText = "Code Postal";
            this.cp.Name = "cp";
            this.cp.ReadOnly = true;
            this.cp.Width = 50;
            // 
            // ville
            // 
            this.ville.HeaderText = "Ville";
            this.ville.Name = "ville";
            this.ville.ReadOnly = true;
            this.ville.Width = 150;
            // 
            // dateNaiss
            // 
            this.dateNaiss.HeaderText = "Date naissance";
            this.dateNaiss.Name = "dateNaiss";
            this.dateNaiss.ReadOnly = true;
            this.dateNaiss.Width = 90;
            // 
            // sexe
            // 
            this.sexe.HeaderText = "Sexe";
            this.sexe.Name = "sexe";
            this.sexe.ReadOnly = true;
            this.sexe.Width = 50;
            // 
            // club
            // 
            this.club.HeaderText = "Club";
            this.club.Name = "club";
            this.club.ReadOnly = true;
            this.club.Width = 80;
            // 
            // idxClub
            // 
            this.idxClub.HeaderText = "Index Club";
            this.idxClub.Name = "idxClub";
            this.idxClub.ReadOnly = true;
            this.idxClub.Visible = false;
            // 
            // categorie
            // 
            this.categorie.HeaderText = "Catégorie";
            this.categorie.Name = "categorie";
            this.categorie.ReadOnly = true;
            this.categorie.Width = 75;
            // 
            // idxCat
            // 
            this.idxCat.HeaderText = "Index Cat";
            this.idxCat.Name = "idxCat";
            this.idxCat.ReadOnly = true;
            this.idxCat.Visible = false;
            // 
            // GestCoureurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 571);
            this.Controls.Add(this.comboBoxCategorie);
            this.Controls.Add(this.comboBoxClub);
            this.Controls.Add(this.labelCategorie);
            this.Controls.Add(this.labelClub);
            this.Controls.Add(this.labelVille);
            this.Controls.Add(this.labelAdresse);
            this.Controls.Add(this.labelPrenom);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.maskedTextBoxCP);
            this.Controls.Add(this.labelCP);
            this.Controls.Add(this.groupBoxSexe);
            this.Controls.Add(this.maskedTextBoxDateNaiss);
            this.Controls.Add(this.labelDateNaiss);
            this.Controls.Add(this.textBoxVille);
            this.Controls.Add(this.textBoxAdresse);
            this.Controls.Add(this.textBoxPrenom);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.buttonSupprimer);
            this.Controls.Add(this.buttonModifier);
            this.Controls.Add(this.buttonCreer);
            this.Controls.Add(this.buttonQuitter);
            this.Controls.Add(this.dataGridViewCoureurs);
            this.Name = "GestCoureurs";
            this.Text = "Gestion des coureurs";
            this.Load += new System.EventHandler(this.GestCoureurs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCoureurs)).EndInit();
            this.groupBoxSexe.ResumeLayout(false);
            this.groupBoxSexe.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCoureurs;
        private System.Windows.Forms.Button buttonQuitter;
        private System.Windows.Forms.Button buttonCreer;
        private System.Windows.Forms.Button buttonModifier;
        private System.Windows.Forms.Button buttonSupprimer;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.TextBox textBoxPrenom;
        private System.Windows.Forms.TextBox textBoxAdresse;
        private System.Windows.Forms.TextBox textBoxVille;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDateNaiss;
        private System.Windows.Forms.Label labelDateNaiss;
        private System.Windows.Forms.GroupBox groupBoxSexe;
        private System.Windows.Forms.RadioButton radioButtonMasculin;
        private System.Windows.Forms.RadioButton radioButtonFeminin;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCP;
        private System.Windows.Forms.Label labelCP;
        private System.Windows.Forms.Label labelCategorie;
        private System.Windows.Forms.Label labelClub;
        private System.Windows.Forms.Label labelVille;
        private System.Windows.Forms.Label labelAdresse;
        private System.Windows.Forms.Label labelPrenom;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.ComboBox comboBoxCategorie;
        private System.Windows.Forms.ComboBox comboBoxClub;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCategorie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresse;
        private System.Windows.Forms.DataGridViewTextBoxColumn cp;
        private System.Windows.Forms.DataGridViewTextBoxColumn ville;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateNaiss;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexe;
        private System.Windows.Forms.DataGridViewTextBoxColumn club;
        private System.Windows.Forms.DataGridViewTextBoxColumn idxClub;
        private System.Windows.Forms.DataGridViewTextBoxColumn categorie;
        private System.Windows.Forms.DataGridViewTextBoxColumn idxCat;
    }
}