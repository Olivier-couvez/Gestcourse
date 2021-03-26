namespace GestionCourses
{
    partial class AjoutCategories
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
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.labelNom = new System.Windows.Forms.Label();
            this.labelAgeMini = new System.Windows.Forms.Label();
            this.textBoxAgeMini = new System.Windows.Forms.TextBox();
            this.labelAgeMaxi = new System.Windows.Forms.Label();
            this.textBoxAgeMaxi = new System.Windows.Forms.TextBox();
            this.labelDistance = new System.Windows.Forms.Label();
            this.textBoxDistance = new System.Windows.Forms.TextBox();
            this.buttonCreer = new System.Windows.Forms.Button();
            this.buttonQuitter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxNom
            // 
            this.textBoxNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNom.Location = new System.Drawing.Point(132, 114);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(269, 22);
            this.textBoxNom.TabIndex = 0;
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNom.Location = new System.Drawing.Point(132, 95);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(103, 16);
            this.labelNom.TabIndex = 1;
            this.labelNom.Text = "Nom  catégorie:";
            // 
            // labelAgeMini
            // 
            this.labelAgeMini.AutoSize = true;
            this.labelAgeMini.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAgeMini.Location = new System.Drawing.Point(129, 163);
            this.labelAgeMini.Name = "labelAgeMini";
            this.labelAgeMini.Size = new System.Drawing.Size(89, 16);
            this.labelAgeMini.TabIndex = 3;
            this.labelAgeMini.Text = "Age Minimum";
            // 
            // textBoxAgeMini
            // 
            this.textBoxAgeMini.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAgeMini.Location = new System.Drawing.Point(132, 182);
            this.textBoxAgeMini.Name = "textBoxAgeMini";
            this.textBoxAgeMini.Size = new System.Drawing.Size(130, 22);
            this.textBoxAgeMini.TabIndex = 1;
            // 
            // labelAgeMaxi
            // 
            this.labelAgeMaxi.AutoSize = true;
            this.labelAgeMaxi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAgeMaxi.Location = new System.Drawing.Point(284, 163);
            this.labelAgeMaxi.Name = "labelAgeMaxi";
            this.labelAgeMaxi.Size = new System.Drawing.Size(93, 16);
            this.labelAgeMaxi.TabIndex = 5;
            this.labelAgeMaxi.Text = "Age maximum";
            // 
            // textBoxAgeMaxi
            // 
            this.textBoxAgeMaxi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAgeMaxi.Location = new System.Drawing.Point(287, 182);
            this.textBoxAgeMaxi.Name = "textBoxAgeMaxi";
            this.textBoxAgeMaxi.Size = new System.Drawing.Size(128, 22);
            this.textBoxAgeMaxi.TabIndex = 2;
            // 
            // labelDistance
            // 
            this.labelDistance.AutoSize = true;
            this.labelDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDistance.Location = new System.Drawing.Point(132, 223);
            this.labelDistance.Name = "labelDistance";
            this.labelDistance.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelDistance.Size = new System.Drawing.Size(121, 16);
            this.labelDistance.TabIndex = 7;
            this.labelDistance.Text = "Distance Maximum";
            // 
            // textBoxDistance
            // 
            this.textBoxDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDistance.Location = new System.Drawing.Point(135, 242);
            this.textBoxDistance.Name = "textBoxDistance";
            this.textBoxDistance.Size = new System.Drawing.Size(269, 22);
            this.textBoxDistance.TabIndex = 3;
            // 
            // buttonCreer
            // 
            this.buttonCreer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreer.Location = new System.Drawing.Point(440, 388);
            this.buttonCreer.Name = "buttonCreer";
            this.buttonCreer.Size = new System.Drawing.Size(115, 32);
            this.buttonCreer.TabIndex = 4;
            this.buttonCreer.Text = "Créer";
            this.buttonCreer.UseVisualStyleBackColor = true;
            this.buttonCreer.Click += new System.EventHandler(this.buttonCreer_Click);
            // 
            // buttonQuitter
            // 
            this.buttonQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuitter.Location = new System.Drawing.Point(636, 388);
            this.buttonQuitter.Name = "buttonQuitter";
            this.buttonQuitter.Size = new System.Drawing.Size(115, 32);
            this.buttonQuitter.TabIndex = 8;
            this.buttonQuitter.Text = "Quitter";
            this.buttonQuitter.UseVisualStyleBackColor = true;
            this.buttonQuitter.Click += new System.EventHandler(this.buttonQuitter_Click);
            // 
            // AjoutCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonQuitter);
            this.Controls.Add(this.buttonCreer);
            this.Controls.Add(this.labelDistance);
            this.Controls.Add(this.textBoxDistance);
            this.Controls.Add(this.labelAgeMaxi);
            this.Controls.Add(this.textBoxAgeMaxi);
            this.Controls.Add(this.labelAgeMini);
            this.Controls.Add(this.textBoxAgeMini);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.textBoxNom);
            this.Name = "AjoutCategories";
            this.Text = "Ajouter une catégorie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label labelAgeMini;
        private System.Windows.Forms.TextBox textBoxAgeMini;
        private System.Windows.Forms.Label labelAgeMaxi;
        private System.Windows.Forms.TextBox textBoxAgeMaxi;
        private System.Windows.Forms.Label labelDistance;
        private System.Windows.Forms.TextBox textBoxDistance;
        private System.Windows.Forms.Button buttonCreer;
        private System.Windows.Forms.Button buttonQuitter;
    }
}