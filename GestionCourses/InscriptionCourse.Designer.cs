namespace GestionCourses
{
    partial class InscriptionCourse
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
            this.LabelDossard = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.buttonQuitter = new System.Windows.Forms.Button();
            this.comboBoxDossard = new System.Windows.Forms.ComboBox();
            this.comboBoxCourse = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxTranspondeur = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxCoureur = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelDossard
            // 
            this.LabelDossard.AutoSize = true;
            this.LabelDossard.Location = new System.Drawing.Point(9, 146);
            this.LabelDossard.Name = "LabelDossard";
            this.LabelDossard.Size = new System.Drawing.Size(128, 16);
            this.LabelDossard.TabIndex = 5;
            this.LabelDossard.Text = "Numéro de dossard";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(227, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Course";
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAjouter.Location = new System.Drawing.Point(376, 250);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(98, 28);
            this.buttonAjouter.TabIndex = 18;
            this.buttonAjouter.Text = "Créer";
            this.buttonAjouter.UseVisualStyleBackColor = true;
            this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click);
            // 
            // buttonQuitter
            // 
            this.buttonQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuitter.Location = new System.Drawing.Point(663, 250);
            this.buttonQuitter.Name = "buttonQuitter";
            this.buttonQuitter.Size = new System.Drawing.Size(98, 28);
            this.buttonQuitter.TabIndex = 19;
            this.buttonQuitter.Text = "Quitter";
            this.buttonQuitter.UseVisualStyleBackColor = true;
            this.buttonQuitter.Click += new System.EventHandler(this.buttonQuitter_Click);
            // 
            // comboBoxDossard
            // 
            this.comboBoxDossard.FormattingEnabled = true;
            this.comboBoxDossard.Location = new System.Drawing.Point(12, 165);
            this.comboBoxDossard.Name = "comboBoxDossard";
            this.comboBoxDossard.Size = new System.Drawing.Size(170, 24);
            this.comboBoxDossard.TabIndex = 20;
            // 
            // comboBoxCourse
            // 
            this.comboBoxCourse.FormattingEnabled = true;
            this.comboBoxCourse.Location = new System.Drawing.Point(188, 165);
            this.comboBoxCourse.Name = "comboBoxCourse";
            this.comboBoxCourse.Size = new System.Drawing.Size(239, 24);
            this.comboBoxCourse.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(225, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 28);
            this.label1.TabIndex = 25;
            this.label1.Text = "Inscription à une course";
            // 
            // comboBoxTranspondeur
            // 
            this.comboBoxTranspondeur.FormattingEnabled = true;
            this.comboBoxTranspondeur.Location = new System.Drawing.Point(630, 165);
            this.comboBoxTranspondeur.Name = "comboBoxTranspondeur";
            this.comboBoxTranspondeur.Size = new System.Drawing.Size(131, 24);
            this.comboBoxTranspondeur.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(644, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "Transpondeur";
            // 
            // comboBoxCoureur
            // 
            this.comboBoxCoureur.FormattingEnabled = true;
            this.comboBoxCoureur.Location = new System.Drawing.Point(433, 165);
            this.comboBoxCoureur.Name = "comboBoxCoureur";
            this.comboBoxCoureur.Size = new System.Drawing.Size(191, 24);
            this.comboBoxCoureur.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(455, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "Coureur";
            // 
            // InscriptionCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 294);
            this.Controls.Add(this.comboBoxCoureur);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxTranspondeur);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxCourse);
            this.Controls.Add(this.comboBoxDossard);
            this.Controls.Add(this.buttonQuitter);
            this.Controls.Add(this.buttonAjouter);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.LabelDossard);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "InscriptionCourse";
            this.Text = "Inscription à une course";
            this.Load += new System.EventHandler(this.TableCoureurAjout_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LabelDossard;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.Button buttonQuitter;
        private System.Windows.Forms.ComboBox comboBoxDossard;
        private System.Windows.Forms.ComboBox comboBoxCourse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxTranspondeur;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxCoureur;
        private System.Windows.Forms.Label label3;
    }
}