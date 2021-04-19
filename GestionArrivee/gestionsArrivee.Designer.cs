namespace GestionArrivee
{
    partial class gestionsArrivee
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fichiersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coureursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clubsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catégoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coursesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transpondeursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inscriptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arrivéeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDuneCoursesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parametreDeLaBaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCourseEnCours = new System.Windows.Forms.TextBox();
            this.labelMessage = new System.Windows.Forms.Label();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.buttonRedemarrer = new System.Windows.Forms.Button();
            this.buttonSuspendre = new System.Windows.Forms.Button();
            this.buttonQuitter = new System.Windows.Forms.Button();
            this.buttonArret = new System.Windows.Forms.Button();
            this.buttonDemarrer = new System.Windows.Forms.Button();
            this.textBoxHeureDemar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonArrivees = new System.Windows.Forms.Button();
            this.buttonArriveeManuelle = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.fichiersToolStripMenuItem,
            this.gestionDuneCoursesToolStripMenuItem,
            this.parametreDeLaBaseToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // fichiersToolStripMenuItem
            // 
            this.fichiersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.coureursToolStripMenuItem,
            this.clubsToolStripMenuItem,
            this.catégoriesToolStripMenuItem,
            this.coursesToolStripMenuItem,
            this.transpondeursToolStripMenuItem,
            this.inscriptionsToolStripMenuItem,
            this.arrivéeToolStripMenuItem});
            this.fichiersToolStripMenuItem.Name = "fichiersToolStripMenuItem";
            this.fichiersToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.fichiersToolStripMenuItem.Text = "Fichiers Course";
            // 
            // coureursToolStripMenuItem
            // 
            this.coureursToolStripMenuItem.Name = "coureursToolStripMenuItem";
            this.coureursToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.coureursToolStripMenuItem.Text = "Coureurs";
            this.coureursToolStripMenuItem.Click += new System.EventHandler(this.coureursToolStripMenuItem_Click);
            // 
            // clubsToolStripMenuItem
            // 
            this.clubsToolStripMenuItem.Name = "clubsToolStripMenuItem";
            this.clubsToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.clubsToolStripMenuItem.Text = "Clubs";
            this.clubsToolStripMenuItem.Click += new System.EventHandler(this.clubsToolStripMenuItem_Click);
            // 
            // catégoriesToolStripMenuItem
            // 
            this.catégoriesToolStripMenuItem.Name = "catégoriesToolStripMenuItem";
            this.catégoriesToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.catégoriesToolStripMenuItem.Text = "Catégories";
            this.catégoriesToolStripMenuItem.Click += new System.EventHandler(this.catégoriesToolStripMenuItem_Click);
            // 
            // coursesToolStripMenuItem
            // 
            this.coursesToolStripMenuItem.Name = "coursesToolStripMenuItem";
            this.coursesToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.coursesToolStripMenuItem.Text = "Courses";
            this.coursesToolStripMenuItem.Click += new System.EventHandler(this.coursesToolStripMenuItem_Click);
            // 
            // transpondeursToolStripMenuItem
            // 
            this.transpondeursToolStripMenuItem.Name = "transpondeursToolStripMenuItem";
            this.transpondeursToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.transpondeursToolStripMenuItem.Text = "Transpondeurs";
            this.transpondeursToolStripMenuItem.Click += new System.EventHandler(this.transpondeursToolStripMenuItem_Click);
            // 
            // inscriptionsToolStripMenuItem
            // 
            this.inscriptionsToolStripMenuItem.Name = "inscriptionsToolStripMenuItem";
            this.inscriptionsToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.inscriptionsToolStripMenuItem.Text = "Inscriptions";
            this.inscriptionsToolStripMenuItem.Click += new System.EventHandler(this.inscriptionsToolStripMenuItem_Click);
            // 
            // arrivéeToolStripMenuItem
            // 
            this.arrivéeToolStripMenuItem.Name = "arrivéeToolStripMenuItem";
            this.arrivéeToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.arrivéeToolStripMenuItem.Text = "Arrivée";
            // 
            // gestionDuneCoursesToolStripMenuItem
            // 
            this.gestionDuneCoursesToolStripMenuItem.Name = "gestionDuneCoursesToolStripMenuItem";
            this.gestionDuneCoursesToolStripMenuItem.Size = new System.Drawing.Size(130, 20);
            this.gestionDuneCoursesToolStripMenuItem.Text = "Gestion d\'une course";
            this.gestionDuneCoursesToolStripMenuItem.Click += new System.EventHandler(this.gestionDuneCoursesToolStripMenuItem_Click);
            // 
            // parametreDeLaBaseToolStripMenuItem
            // 
            this.parametreDeLaBaseToolStripMenuItem.Name = "parametreDeLaBaseToolStripMenuItem";
            this.parametreDeLaBaseToolStripMenuItem.Size = new System.Drawing.Size(128, 20);
            this.parametreDeLaBaseToolStripMenuItem.Text = "Parametre de la base";
            this.parametreDeLaBaseToolStripMenuItem.Click += new System.EventHandler(this.parametreDeLaBaseToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(44, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 56);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gestion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(326, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 56);
            this.label2.TabIndex = 2;
            this.label2.Text = "des";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(535, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 56);
            this.label3.TabIndex = 3;
            this.label3.Text = "arrivees";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(75, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Course en cours :";
            // 
            // textBoxCourseEnCours
            // 
            this.textBoxCourseEnCours.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCourseEnCours.Location = new System.Drawing.Point(248, 243);
            this.textBoxCourseEnCours.Name = "textBoxCourseEnCours";
            this.textBoxCourseEnCours.Size = new System.Drawing.Size(357, 31);
            this.textBoxCourseEnCours.TabIndex = 5;
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMessage.Location = new System.Drawing.Point(50, 391);
            this.labelMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(63, 17);
            this.labelMessage.TabIndex = 17;
            this.labelMessage.Text = "Message";
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMessage.Location = new System.Drawing.Point(53, 411);
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(502, 23);
            this.textBoxMessage.TabIndex = 16;
            // 
            // buttonRedemarrer
            // 
            this.buttonRedemarrer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRedemarrer.Location = new System.Drawing.Point(398, 140);
            this.buttonRedemarrer.Name = "buttonRedemarrer";
            this.buttonRedemarrer.Size = new System.Drawing.Size(114, 33);
            this.buttonRedemarrer.TabIndex = 15;
            this.buttonRedemarrer.Text = "Redémarrer";
            this.buttonRedemarrer.UseVisualStyleBackColor = true;
            this.buttonRedemarrer.Click += new System.EventHandler(this.buttonRedemarrer_Click);
            // 
            // buttonSuspendre
            // 
            this.buttonSuspendre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSuspendre.Location = new System.Drawing.Point(237, 140);
            this.buttonSuspendre.Name = "buttonSuspendre";
            this.buttonSuspendre.Size = new System.Drawing.Size(114, 33);
            this.buttonSuspendre.TabIndex = 14;
            this.buttonSuspendre.Text = "Suspendre";
            this.buttonSuspendre.UseVisualStyleBackColor = true;
            this.buttonSuspendre.Click += new System.EventHandler(this.buttonSuspendre_Click);
            // 
            // buttonQuitter
            // 
            this.buttonQuitter.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuitter.Location = new System.Drawing.Point(663, 395);
            this.buttonQuitter.Name = "buttonQuitter";
            this.buttonQuitter.Size = new System.Drawing.Size(114, 33);
            this.buttonQuitter.TabIndex = 13;
            this.buttonQuitter.Text = "Quitter";
            this.buttonQuitter.UseVisualStyleBackColor = true;
            this.buttonQuitter.Click += new System.EventHandler(this.buttonQuitter_Click);
            // 
            // buttonArret
            // 
            this.buttonArret.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonArret.Location = new System.Drawing.Point(398, 101);
            this.buttonArret.Name = "buttonArret";
            this.buttonArret.Size = new System.Drawing.Size(187, 33);
            this.buttonArret.TabIndex = 12;
            this.buttonArret.Text = "Fin de course";
            this.buttonArret.UseVisualStyleBackColor = true;
            this.buttonArret.Click += new System.EventHandler(this.buttonArret_Click);
            // 
            // buttonDemarrer
            // 
            this.buttonDemarrer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDemarrer.Location = new System.Drawing.Point(156, 101);
            this.buttonDemarrer.Name = "buttonDemarrer";
            this.buttonDemarrer.Size = new System.Drawing.Size(195, 33);
            this.buttonDemarrer.TabIndex = 11;
            this.buttonDemarrer.Text = "Démarrer la course";
            this.buttonDemarrer.UseVisualStyleBackColor = true;
            this.buttonDemarrer.Click += new System.EventHandler(this.buttonDemarrer_Click);
            // 
            // textBoxHeureDemar
            // 
            this.textBoxHeureDemar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHeureDemar.Location = new System.Drawing.Point(248, 293);
            this.textBoxHeureDemar.Name = "textBoxHeureDemar";
            this.textBoxHeureDemar.Size = new System.Drawing.Size(138, 31);
            this.textBoxHeureDemar.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 22);
            this.label5.TabIndex = 18;
            this.label5.Text = "Course démarrée à :";
            // 
            // buttonArrivees
            // 
            this.buttonArrivees.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonArrivees.Location = new System.Drawing.Point(278, 190);
            this.buttonArrivees.Name = "buttonArrivees";
            this.buttonArrivees.Size = new System.Drawing.Size(195, 33);
            this.buttonArrivees.TabIndex = 20;
            this.buttonArrivees.Text = "Lecture des arrivees";
            this.buttonArrivees.UseVisualStyleBackColor = true;
            this.buttonArrivees.Click += new System.EventHandler(this.buttonArrivees_Click);
            // 
            // buttonArriveeManuelle
            // 
            this.buttonArriveeManuelle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonArriveeManuelle.Location = new System.Drawing.Point(532, 190);
            this.buttonArriveeManuelle.Name = "buttonArriveeManuelle";
            this.buttonArriveeManuelle.Size = new System.Drawing.Size(245, 33);
            this.buttonArriveeManuelle.TabIndex = 21;
            this.buttonArriveeManuelle.Text = "Saisie manuelle des arrivees";
            this.buttonArriveeManuelle.UseVisualStyleBackColor = true;
            this.buttonArriveeManuelle.Click += new System.EventHandler(this.buttonArriveeManuelle_Click);
            // 
            // gestionsArrivee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonArriveeManuelle);
            this.Controls.Add(this.buttonArrivees);
            this.Controls.Add(this.textBoxHeureDemar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.buttonRedemarrer);
            this.Controls.Add(this.buttonSuspendre);
            this.Controls.Add(this.buttonQuitter);
            this.Controls.Add(this.buttonArret);
            this.Controls.Add(this.buttonDemarrer);
            this.Controls.Add(this.textBoxCourseEnCours);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "gestionsArrivee";
            this.Text = "Gestion des arrivees";
            this.Load += new System.EventHandler(this.gestionsArrivee_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fichiersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coureursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clubsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catégoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coursesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transpondeursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inscriptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arrivéeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDuneCoursesToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem parametreDeLaBaseToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxCourseEnCours;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.Button buttonRedemarrer;
        private System.Windows.Forms.Button buttonSuspendre;
        private System.Windows.Forms.Button buttonQuitter;
        private System.Windows.Forms.Button buttonArret;
        private System.Windows.Forms.Button buttonDemarrer;
        private System.Windows.Forms.TextBox textBoxHeureDemar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonArrivees;
        private System.Windows.Forms.Button buttonArriveeManuelle;
    }
}

