namespace GestionCourses
{
    partial class AjoutCourses
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
            this.labelAdr = new System.Windows.Forms.Label();
            this.textBoxAdr = new System.Windows.Forms.TextBox();
            this.labelCP = new System.Windows.Forms.Label();
            this.textBoxCP = new System.Windows.Forms.TextBox();
            this.labelVille = new System.Windows.Forms.Label();
            this.textBoxVille = new System.Windows.Forms.TextBox();
            this.buttonCreer = new System.Windows.Forms.Button();
            this.buttonQuitter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxNom
            // 
            this.textBoxNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNom.Location = new System.Drawing.Point(132, 114);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(211, 22);
            this.textBoxNom.TabIndex = 0;
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNom.Location = new System.Drawing.Point(132, 95);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(43, 16);
            this.labelNom.TabIndex = 1;
            this.labelNom.Text = "Nom :";
            // 
            // labelAdr
            // 
            this.labelAdr.AutoSize = true;
            this.labelAdr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdr.Location = new System.Drawing.Point(129, 163);
            this.labelAdr.Name = "labelAdr";
            this.labelAdr.Size = new System.Drawing.Size(91, 16);
            this.labelAdr.TabIndex = 3;
            this.labelAdr.Text = "Date prévue : ";
            // 
            // textBoxAdr
            // 
            this.textBoxAdr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAdr.Location = new System.Drawing.Point(132, 182);
            this.textBoxAdr.Name = "textBoxAdr";
            this.textBoxAdr.Size = new System.Drawing.Size(119, 22);
            this.textBoxAdr.TabIndex = 1;
            // 
            // labelCP
            // 
            this.labelCP.AutoSize = true;
            this.labelCP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCP.Location = new System.Drawing.Point(130, 220);
            this.labelCP.Name = "labelCP";
            this.labelCP.Size = new System.Drawing.Size(82, 16);
            this.labelCP.TabIndex = 5;
            this.labelCP.Text = "Date prévue";
            // 
            // textBoxCP
            // 
            this.textBoxCP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCP.Location = new System.Drawing.Point(132, 239);
            this.textBoxCP.Name = "textBoxCP";
            this.textBoxCP.Size = new System.Drawing.Size(119, 22);
            this.textBoxCP.TabIndex = 2;
            // 
            // labelVille
            // 
            this.labelVille.AutoSize = true;
            this.labelVille.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVille.Location = new System.Drawing.Point(132, 273);
            this.labelVille.Name = "labelVille";
            this.labelVille.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelVille.Size = new System.Drawing.Size(149, 16);
            this.labelVille.TabIndex = 7;
            this.labelVille.Text = "Date et heure de départ";
            // 
            // textBoxVille
            // 
            this.textBoxVille.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxVille.Location = new System.Drawing.Point(132, 292);
            this.textBoxVille.Name = "textBoxVille";
            this.textBoxVille.Size = new System.Drawing.Size(119, 22);
            this.textBoxVille.TabIndex = 3;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(276, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Format DD/MM/YYYY";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(276, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Format DD/MM/YYYY";
            // 
            // AjoutCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonQuitter);
            this.Controls.Add(this.buttonCreer);
            this.Controls.Add(this.labelVille);
            this.Controls.Add(this.textBoxVille);
            this.Controls.Add(this.labelCP);
            this.Controls.Add(this.textBoxCP);
            this.Controls.Add(this.labelAdr);
            this.Controls.Add(this.textBoxAdr);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.textBoxNom);
            this.Name = "AjoutCourses";
            this.Text = "Ajouter un club";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label labelAdr;
        private System.Windows.Forms.TextBox textBoxAdr;
        private System.Windows.Forms.Label labelCP;
        private System.Windows.Forms.TextBox textBoxCP;
        private System.Windows.Forms.Label labelVille;
        private System.Windows.Forms.TextBox textBoxVille;
        private System.Windows.Forms.Button buttonCreer;
        private System.Windows.Forms.Button buttonQuitter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}