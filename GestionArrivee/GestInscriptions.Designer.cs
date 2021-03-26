namespace GestionArrivee
{
    partial class GestInscriptions
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
            this.IdCategorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dossard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.course = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idxCourse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coureur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idxCoureur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transpondeur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idxTranspondeur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonQuitter = new System.Windows.Forms.Button();
            this.buttonCreer = new System.Windows.Forms.Button();
            this.buttonModifier = new System.Windows.Forms.Button();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.comboBoxCoureur = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxTranspondeur = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxCourse = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.LabelDossard = new System.Windows.Forms.Label();
            this.textBoxDossard = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCoureurs)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCoureurs
            // 
            this.dataGridViewCoureurs.AllowUserToAddRows = false;
            this.dataGridViewCoureurs.AllowUserToDeleteRows = false;
            this.dataGridViewCoureurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCoureurs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCategorie,
            this.dossard,
            this.course,
            this.idxCourse,
            this.coureur,
            this.idxCoureur,
            this.transpondeur,
            this.idxTranspondeur});
            this.dataGridViewCoureurs.Location = new System.Drawing.Point(12, 22);
            this.dataGridViewCoureurs.MultiSelect = false;
            this.dataGridViewCoureurs.Name = "dataGridViewCoureurs";
            this.dataGridViewCoureurs.ReadOnly = true;
            this.dataGridViewCoureurs.Size = new System.Drawing.Size(694, 371);
            this.dataGridViewCoureurs.TabIndex = 0;
            this.dataGridViewCoureurs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCoureurs_CellContentClick);
            this.dataGridViewCoureurs.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCoureurs_CellContentClick);
            // 
            // IdCategorie
            // 
            this.IdCategorie.Frozen = true;
            this.IdCategorie.HeaderText = "Ident.";
            this.IdCategorie.Name = "IdCategorie";
            this.IdCategorie.ReadOnly = true;
            this.IdCategorie.Width = 50;
            // 
            // dossard
            // 
            this.dossard.FillWeight = 80F;
            this.dossard.Frozen = true;
            this.dossard.HeaderText = "Dossard";
            this.dossard.Name = "dossard";
            this.dossard.ReadOnly = true;
            // 
            // course
            // 
            this.course.FillWeight = 150F;
            this.course.HeaderText = "Courses";
            this.course.Name = "course";
            this.course.ReadOnly = true;
            this.course.Width = 200;
            // 
            // idxCourse
            // 
            this.idxCourse.FillWeight = 50F;
            this.idxCourse.HeaderText = "Index Course";
            this.idxCourse.Name = "idxCourse";
            this.idxCourse.ReadOnly = true;
            this.idxCourse.Visible = false;
            // 
            // coureur
            // 
            this.coureur.FillWeight = 150F;
            this.coureur.HeaderText = "Coureurs";
            this.coureur.Name = "coureur";
            this.coureur.ReadOnly = true;
            this.coureur.Width = 200;
            // 
            // idxCoureur
            // 
            this.idxCoureur.FillWeight = 50F;
            this.idxCoureur.HeaderText = "Index Coureurs";
            this.idxCoureur.Name = "idxCoureur";
            this.idxCoureur.ReadOnly = true;
            this.idxCoureur.Visible = false;
            // 
            // transpondeur
            // 
            this.transpondeur.FillWeight = 70F;
            this.transpondeur.HeaderText = "Transpondeur";
            this.transpondeur.Name = "transpondeur";
            this.transpondeur.ReadOnly = true;
            // 
            // idxTranspondeur
            // 
            this.idxTranspondeur.FillWeight = 50F;
            this.idxTranspondeur.HeaderText = "Index transpondeur";
            this.idxTranspondeur.Name = "idxTranspondeur";
            this.idxTranspondeur.ReadOnly = true;
            this.idxTranspondeur.Visible = false;
            // 
            // buttonQuitter
            // 
            this.buttonQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuitter.Location = new System.Drawing.Point(592, 493);
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
            this.buttonCreer.Location = new System.Drawing.Point(9, 493);
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
            this.buttonModifier.Location = new System.Drawing.Point(129, 493);
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
            this.buttonSupprimer.Location = new System.Drawing.Point(249, 493);
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
            this.textBoxID.Location = new System.Drawing.Point(12, 399);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.ReadOnly = true;
            this.textBoxID.Size = new System.Drawing.Size(68, 22);
            this.textBoxID.TabIndex = 5;
            this.textBoxID.Visible = false;
            // 
            // comboBoxCoureur
            // 
            this.comboBoxCoureur.FormattingEnabled = true;
            this.comboBoxCoureur.Location = new System.Drawing.Point(381, 446);
            this.comboBoxCoureur.Name = "comboBoxCoureur";
            this.comboBoxCoureur.Size = new System.Drawing.Size(191, 21);
            this.comboBoxCoureur.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(381, 430);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Coureur";
            // 
            // comboBoxTranspondeur
            // 
            this.comboBoxTranspondeur.FormattingEnabled = true;
            this.comboBoxTranspondeur.Location = new System.Drawing.Point(578, 446);
            this.comboBoxTranspondeur.Name = "comboBoxTranspondeur";
            this.comboBoxTranspondeur.Size = new System.Drawing.Size(131, 21);
            this.comboBoxTranspondeur.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(578, 430);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Transpondeur";
            // 
            // comboBoxCourse
            // 
            this.comboBoxCourse.FormattingEnabled = true;
            this.comboBoxCourse.Location = new System.Drawing.Point(136, 445);
            this.comboBoxCourse.Name = "comboBoxCourse";
            this.comboBoxCourse.Size = new System.Drawing.Size(239, 21);
            this.comboBoxCourse.TabIndex = 33;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(136, 430);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "Course";
            // 
            // LabelDossard
            // 
            this.LabelDossard.AutoSize = true;
            this.LabelDossard.Location = new System.Drawing.Point(4, 430);
            this.LabelDossard.Name = "LabelDossard";
            this.LabelDossard.Size = new System.Drawing.Size(99, 13);
            this.LabelDossard.TabIndex = 30;
            this.LabelDossard.Text = "Numéro de dossard";
            // 
            // textBoxDossard
            // 
            this.textBoxDossard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDossard.Location = new System.Drawing.Point(7, 444);
            this.textBoxDossard.Name = "textBoxDossard";
            this.textBoxDossard.Size = new System.Drawing.Size(123, 22);
            this.textBoxDossard.TabIndex = 38;
            // 
            // GestInscriptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 540);
            this.Controls.Add(this.textBoxDossard);
            this.Controls.Add(this.comboBoxCoureur);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxTranspondeur);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxCourse);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.LabelDossard);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.buttonSupprimer);
            this.Controls.Add(this.buttonModifier);
            this.Controls.Add(this.buttonCreer);
            this.Controls.Add(this.buttonQuitter);
            this.Controls.Add(this.dataGridViewCoureurs);
            this.Name = "GestInscriptions";
            this.Text = "Gestion des inscriptions";
            this.Load += new System.EventHandler(this.GestCoureurs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCoureurs)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCategorie;
        private System.Windows.Forms.DataGridViewTextBoxColumn dossard;
        private System.Windows.Forms.DataGridViewTextBoxColumn course;
        private System.Windows.Forms.DataGridViewTextBoxColumn idxCourse;
        private System.Windows.Forms.DataGridViewTextBoxColumn coureur;
        private System.Windows.Forms.DataGridViewTextBoxColumn idxCoureur;
        private System.Windows.Forms.DataGridViewTextBoxColumn transpondeur;
        private System.Windows.Forms.DataGridViewTextBoxColumn idxTranspondeur;
        private System.Windows.Forms.ComboBox comboBoxCoureur;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxTranspondeur;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxCourse;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LabelDossard;
        private System.Windows.Forms.TextBox textBoxDossard;
    }
}