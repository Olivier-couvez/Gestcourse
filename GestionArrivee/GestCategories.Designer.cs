namespace GestionArrivee
{
    partial class GestCategories
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
            this.dataGridViewCategories = new System.Windows.Forms.DataGridView();
            this.buttonQuitter = new System.Windows.Forms.Button();
            this.buttonCreer = new System.Windows.Forms.Button();
            this.buttonModifier = new System.Windows.Forms.Button();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxAgeMin = new System.Windows.Forms.TextBox();
            this.textBoxAgeMax = new System.Windows.Forms.TextBox();
            this.textBoxDistance = new System.Windows.Forms.TextBox();
            this.IdCategorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AgeMini = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AgeMaxi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DistMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategories)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCategories
            // 
            this.dataGridViewCategories.AllowUserToAddRows = false;
            this.dataGridViewCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCategories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCategorie,
            this.Nom,
            this.AgeMini,
            this.AgeMaxi,
            this.DistMax});
            this.dataGridViewCategories.Location = new System.Drawing.Point(12, 22);
            this.dataGridViewCategories.MultiSelect = false;
            this.dataGridViewCategories.Name = "dataGridViewCategories";
            this.dataGridViewCategories.ReadOnly = true;
            this.dataGridViewCategories.Size = new System.Drawing.Size(926, 434);
            this.dataGridViewCategories.TabIndex = 0;
            this.dataGridViewCategories.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCategories_CellContentClick);
            this.dataGridViewCategories.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCategories_CellContentClick);
            // 
            // buttonQuitter
            // 
            this.buttonQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuitter.Location = new System.Drawing.Point(859, 513);
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
            this.buttonCreer.Location = new System.Drawing.Point(134, 513);
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
            this.buttonModifier.Location = new System.Drawing.Point(297, 513);
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
            this.buttonSupprimer.Location = new System.Drawing.Point(458, 513);
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
            this.textBoxID.Location = new System.Drawing.Point(41, 477);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.ReadOnly = true;
            this.textBoxID.Size = new System.Drawing.Size(68, 22);
            this.textBoxID.TabIndex = 5;
            this.textBoxID.Visible = false;
            // 
            // textBoxNom
            // 
            this.textBoxNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNom.Location = new System.Drawing.Point(115, 477);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(310, 22);
            this.textBoxNom.TabIndex = 6;
            // 
            // textBoxAgeMin
            // 
            this.textBoxAgeMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAgeMin.Location = new System.Drawing.Point(431, 477);
            this.textBoxAgeMin.Name = "textBoxAgeMin";
            this.textBoxAgeMin.Size = new System.Drawing.Size(141, 22);
            this.textBoxAgeMin.TabIndex = 7;
            // 
            // textBoxAgeMax
            // 
            this.textBoxAgeMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAgeMax.Location = new System.Drawing.Point(578, 477);
            this.textBoxAgeMax.Name = "textBoxAgeMax";
            this.textBoxAgeMax.Size = new System.Drawing.Size(166, 22);
            this.textBoxAgeMax.TabIndex = 8;
            // 
            // textBoxDistance
            // 
            this.textBoxDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDistance.Location = new System.Drawing.Point(750, 477);
            this.textBoxDistance.Name = "textBoxDistance";
            this.textBoxDistance.Size = new System.Drawing.Size(172, 22);
            this.textBoxDistance.TabIndex = 9;
            // 
            // IdCategorie
            // 
            this.IdCategorie.Frozen = true;
            this.IdCategorie.HeaderText = "Identifiant";
            this.IdCategorie.Name = "IdCategorie";
            this.IdCategorie.ReadOnly = true;
            this.IdCategorie.Width = 60;
            // 
            // Nom
            // 
            this.Nom.Frozen = true;
            this.Nom.HeaderText = "Nom catégories";
            this.Nom.Name = "Nom";
            this.Nom.ReadOnly = true;
            this.Nom.Width = 300;
            // 
            // AgeMini
            // 
            this.AgeMini.HeaderText = "Age minimum";
            this.AgeMini.Name = "AgeMini";
            this.AgeMini.ReadOnly = true;
            this.AgeMini.Width = 150;
            // 
            // AgeMaxi
            // 
            this.AgeMaxi.HeaderText = "Age maximum";
            this.AgeMaxi.Name = "AgeMaxi";
            this.AgeMaxi.ReadOnly = true;
            this.AgeMaxi.Width = 150;
            // 
            // DistMax
            // 
            this.DistMax.HeaderText = "Distance Maximum";
            this.DistMax.Name = "DistMax";
            this.DistMax.ReadOnly = true;
            this.DistMax.Width = 200;
            // 
            // GestCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 571);
            this.Controls.Add(this.textBoxDistance);
            this.Controls.Add(this.textBoxAgeMax);
            this.Controls.Add(this.textBoxAgeMin);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.buttonSupprimer);
            this.Controls.Add(this.buttonModifier);
            this.Controls.Add(this.buttonCreer);
            this.Controls.Add(this.buttonQuitter);
            this.Controls.Add(this.dataGridViewCategories);
            this.Name = "GestCategories";
            this.Text = "Gestion des catégories";
            this.Load += new System.EventHandler(this.GestCategories_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategories)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCategories;
        private System.Windows.Forms.Button buttonQuitter;
        private System.Windows.Forms.Button buttonCreer;
        private System.Windows.Forms.Button buttonModifier;
        private System.Windows.Forms.Button buttonSupprimer;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.TextBox textBoxAgeMin;
        private System.Windows.Forms.TextBox textBoxAgeMax;
        private System.Windows.Forms.TextBox textBoxDistance;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCategorie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn AgeMini;
        private System.Windows.Forms.DataGridViewTextBoxColumn AgeMaxi;
        private System.Windows.Forms.DataGridViewTextBoxColumn DistMax;
    }
}