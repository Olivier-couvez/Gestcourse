
namespace GestionArrivee
{
    partial class ArriveeManuelle
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
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.buttonQuitter = new System.Windows.Forms.Button();
            this.comboBoxTranspondeur = new System.Windows.Forms.ComboBox();
            this.labelTitre = new System.Windows.Forms.Label();
            this.labelIdCourse = new System.Windows.Forms.Label();
            this.maskedTextBoxHeureArrivee = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAjouter.Location = new System.Drawing.Point(464, 386);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(148, 36);
            this.buttonAjouter.TabIndex = 0;
            this.buttonAjouter.Text = "Ajouter";
            this.buttonAjouter.UseVisualStyleBackColor = true;
            this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click);
            // 
            // buttonQuitter
            // 
            this.buttonQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuitter.Location = new System.Drawing.Point(618, 386);
            this.buttonQuitter.Name = "buttonQuitter";
            this.buttonQuitter.Size = new System.Drawing.Size(148, 36);
            this.buttonQuitter.TabIndex = 1;
            this.buttonQuitter.Text = "Quitter";
            this.buttonQuitter.UseVisualStyleBackColor = true;
            this.buttonQuitter.Click += new System.EventHandler(this.buttonQuitter_Click);
            // 
            // comboBoxTranspondeur
            // 
            this.comboBoxTranspondeur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTranspondeur.FormattingEnabled = true;
            this.comboBoxTranspondeur.Location = new System.Drawing.Point(95, 163);
            this.comboBoxTranspondeur.Name = "comboBoxTranspondeur";
            this.comboBoxTranspondeur.Size = new System.Drawing.Size(263, 28);
            this.comboBoxTranspondeur.TabIndex = 2;
            // 
            // labelTitre
            // 
            this.labelTitre.AutoSize = true;
            this.labelTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitre.Location = new System.Drawing.Point(206, 56);
            this.labelTitre.Name = "labelTitre";
            this.labelTitre.Size = new System.Drawing.Size(423, 37);
            this.labelTitre.TabIndex = 3;
            this.labelTitre.Text = "Ajout manuel d\'une arrivée";
            // 
            // labelIdCourse
            // 
            this.labelIdCourse.AutoSize = true;
            this.labelIdCourse.Location = new System.Drawing.Point(13, 22);
            this.labelIdCourse.Name = "labelIdCourse";
            this.labelIdCourse.Size = new System.Drawing.Size(187, 13);
            this.labelIdCourse.TabIndex = 4;
            this.labelIdCourse.Text = "Id Course invisible pendant l\'execution";
            this.labelIdCourse.Visible = false;
            // 
            // maskedTextBoxHeureArrivee
            // 
            this.maskedTextBoxHeureArrivee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxHeureArrivee.Location = new System.Drawing.Point(432, 163);
            this.maskedTextBoxHeureArrivee.Mask = "00/00/0000 00:00:00.000000";
            this.maskedTextBoxHeureArrivee.Name = "maskedTextBoxHeureArrivee";
            this.maskedTextBoxHeureArrivee.Size = new System.Drawing.Size(216, 26);
            this.maskedTextBoxHeureArrivee.TabIndex = 5;
            this.maskedTextBoxHeureArrivee.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(428, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Saisir le Temps pour ce transpondeur";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(91, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Choisir un transpondeur";
            // 
            // ArriveeManuelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maskedTextBoxHeureArrivee);
            this.Controls.Add(this.labelIdCourse);
            this.Controls.Add(this.labelTitre);
            this.Controls.Add(this.comboBoxTranspondeur);
            this.Controls.Add(this.buttonQuitter);
            this.Controls.Add(this.buttonAjouter);
            this.Name = "ArriveeManuelle";
            this.Text = "ArriveeManuelle";
            this.Load += new System.EventHandler(this.ArriveeManuelle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.Button buttonQuitter;
        private System.Windows.Forms.ComboBox comboBoxTranspondeur;
        private System.Windows.Forms.Label labelTitre;
        protected System.Windows.Forms.Label labelIdCourse;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxHeureArrivee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}