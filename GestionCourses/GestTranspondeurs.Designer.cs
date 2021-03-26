namespace GestionCourses
{
    partial class GestTranspondeurs
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
            this.dataGridViewTranspondeurs = new System.Windows.Forms.DataGridView();
            this.buttonQuitter = new System.Windows.Forms.Button();
            this.buttonCreer = new System.Windows.Forms.Button();
            this.buttonModifier = new System.Windows.Forms.Button();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxPerdu = new System.Windows.Forms.TextBox();
            this.Id_Transpondeur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Perdu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTranspondeurs)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTranspondeurs
            // 
            this.dataGridViewTranspondeurs.AllowUserToAddRows = false;
            this.dataGridViewTranspondeurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTranspondeurs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Transpondeur,
            this.Perdu});
            this.dataGridViewTranspondeurs.Location = new System.Drawing.Point(115, 25);
            this.dataGridViewTranspondeurs.MultiSelect = false;
            this.dataGridViewTranspondeurs.Name = "dataGridViewTranspondeurs";
            this.dataGridViewTranspondeurs.ReadOnly = true;
            this.dataGridViewTranspondeurs.Size = new System.Drawing.Size(288, 434);
            this.dataGridViewTranspondeurs.TabIndex = 0;
            this.dataGridViewTranspondeurs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewClubs_CellContentClick);
            this.dataGridViewTranspondeurs.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewClubs_CellContentClick);
            // 
            // buttonQuitter
            // 
            this.buttonQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuitter.Location = new System.Drawing.Point(387, 513);
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
            this.buttonCreer.Location = new System.Drawing.Point(12, 513);
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
            this.buttonModifier.Location = new System.Drawing.Point(132, 513);
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
            this.buttonSupprimer.Location = new System.Drawing.Point(252, 513);
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
            this.textBoxID.Location = new System.Drawing.Point(115, 475);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.ReadOnly = true;
            this.textBoxID.Size = new System.Drawing.Size(118, 22);
            this.textBoxID.TabIndex = 5;
            this.textBoxID.Visible = false;
            // 
            // textBoxPerdu
            // 
            this.textBoxPerdu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPerdu.Location = new System.Drawing.Point(272, 475);
            this.textBoxPerdu.Name = "textBoxPerdu";
            this.textBoxPerdu.Size = new System.Drawing.Size(131, 22);
            this.textBoxPerdu.TabIndex = 6;
            // 
            // Id_Transpondeur
            // 
            this.Id_Transpondeur.Frozen = true;
            this.Id_Transpondeur.HeaderText = "Identifiant";
            this.Id_Transpondeur.Name = "Id_Transpondeur";
            this.Id_Transpondeur.ReadOnly = true;
            // 
            // Perdu
            // 
            this.Perdu.Frozen = true;
            this.Perdu.HeaderText = "Perdu ?";
            this.Perdu.Name = "Perdu";
            this.Perdu.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(409, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Pour la colonne Perdu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(409, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mettre 0 si pas perdu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(409, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ou mettre 1 si perdu";
            // 
            // GestTranspondeurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 571);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPerdu);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.buttonSupprimer);
            this.Controls.Add(this.buttonModifier);
            this.Controls.Add(this.buttonCreer);
            this.Controls.Add(this.buttonQuitter);
            this.Controls.Add(this.dataGridViewTranspondeurs);
            this.Name = "GestTranspondeurs";
            this.Text = "Gestion des Transpondeurs";
            this.Load += new System.EventHandler(this.GestTranspondeurs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTranspondeurs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTranspondeurs;
        private System.Windows.Forms.Button buttonQuitter;
        private System.Windows.Forms.Button buttonCreer;
        private System.Windows.Forms.Button buttonModifier;
        private System.Windows.Forms.Button buttonSupprimer;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxPerdu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Transpondeur;
        private System.Windows.Forms.DataGridViewTextBoxColumn Perdu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}