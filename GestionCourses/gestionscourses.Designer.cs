namespace GestionCourses
{
    partial class gestionscourses
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
            this.classementDuneCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.parametreDeLaBaseToolStripMenuItem,
            this.fichiersToolStripMenuItem,
            this.gestionDuneCoursesToolStripMenuItem,
            this.classementDuneCourseToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
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
            this.coureursToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.coureursToolStripMenuItem.Text = "Coureurs";
            this.coureursToolStripMenuItem.Click += new System.EventHandler(this.coureursToolStripMenuItem_Click);
            // 
            // clubsToolStripMenuItem
            // 
            this.clubsToolStripMenuItem.Name = "clubsToolStripMenuItem";
            this.clubsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clubsToolStripMenuItem.Text = "Clubs";
            this.clubsToolStripMenuItem.Click += new System.EventHandler(this.clubsToolStripMenuItem_Click);
            // 
            // catégoriesToolStripMenuItem
            // 
            this.catégoriesToolStripMenuItem.Name = "catégoriesToolStripMenuItem";
            this.catégoriesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.catégoriesToolStripMenuItem.Text = "Catégories";
            this.catégoriesToolStripMenuItem.Click += new System.EventHandler(this.catégoriesToolStripMenuItem_Click);
            // 
            // coursesToolStripMenuItem
            // 
            this.coursesToolStripMenuItem.Name = "coursesToolStripMenuItem";
            this.coursesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.coursesToolStripMenuItem.Text = "Courses";
            this.coursesToolStripMenuItem.Click += new System.EventHandler(this.coursesToolStripMenuItem_Click);
            // 
            // transpondeursToolStripMenuItem
            // 
            this.transpondeursToolStripMenuItem.Name = "transpondeursToolStripMenuItem";
            this.transpondeursToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.transpondeursToolStripMenuItem.Text = "Transpondeurs";
            this.transpondeursToolStripMenuItem.Click += new System.EventHandler(this.transpondeursToolStripMenuItem_Click);
            // 
            // inscriptionsToolStripMenuItem
            // 
            this.inscriptionsToolStripMenuItem.Name = "inscriptionsToolStripMenuItem";
            this.inscriptionsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.inscriptionsToolStripMenuItem.Text = "Inscriptions";
            this.inscriptionsToolStripMenuItem.Click += new System.EventHandler(this.inscriptionsToolStripMenuItem_Click);
            // 
            // arrivéeToolStripMenuItem
            // 
            this.arrivéeToolStripMenuItem.Name = "arrivéeToolStripMenuItem";
            this.arrivéeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(279, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gestion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(336, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 55);
            this.label2.TabIndex = 2;
            this.label2.Text = "de";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(279, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 55);
            this.label3.TabIndex = 3;
            this.label3.Text = "courses";
            // 
            // classementDuneCourseToolStripMenuItem
            // 
            this.classementDuneCourseToolStripMenuItem.Name = "classementDuneCourseToolStripMenuItem";
            this.classementDuneCourseToolStripMenuItem.Size = new System.Drawing.Size(151, 20);
            this.classementDuneCourseToolStripMenuItem.Text = "Classement d\'une course";
            this.classementDuneCourseToolStripMenuItem.Click += new System.EventHandler(this.classementDuneCourseToolStripMenuItem_Click);
            // 
            // gestionscourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "gestionscourses";
            this.Text = "Gestion de Courses";
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
        private System.Windows.Forms.ToolStripMenuItem classementDuneCourseToolStripMenuItem;
    }
}

