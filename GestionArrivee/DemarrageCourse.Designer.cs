namespace GestionArrivee
{
    partial class DemarrageCourse
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
            this.comboBoxCourses = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDemarrer = new System.Windows.Forms.Button();
            this.textBoxEnCours = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonArret = new System.Windows.Forms.Button();
            this.buttonQuitter = new System.Windows.Forms.Button();
            this.buttonSuspendre = new System.Windows.Forms.Button();
            this.buttonRedemarrer = new System.Windows.Forms.Button();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.labelMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxCourses
            // 
            this.comboBoxCourses.FormattingEnabled = true;
            this.comboBoxCourses.Location = new System.Drawing.Point(76, 132);
            this.comboBoxCourses.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxCourses.Name = "comboBoxCourses";
            this.comboBoxCourses.Size = new System.Drawing.Size(214, 25);
            this.comboBoxCourses.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(621, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Course en cours";
            // 
            // buttonDemarrer
            // 
            this.buttonDemarrer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDemarrer.Location = new System.Drawing.Point(379, 132);
            this.buttonDemarrer.Name = "buttonDemarrer";
            this.buttonDemarrer.Size = new System.Drawing.Size(114, 33);
            this.buttonDemarrer.TabIndex = 2;
            this.buttonDemarrer.Text = "Démarrer";
            this.buttonDemarrer.UseVisualStyleBackColor = true;
            this.buttonDemarrer.Click += new System.EventHandler(this.buttonDemarrer_Click);
            // 
            // textBoxEnCours
            // 
            this.textBoxEnCours.Location = new System.Drawing.Point(624, 75);
            this.textBoxEnCours.Name = "textBoxEnCours";
            this.textBoxEnCours.Size = new System.Drawing.Size(257, 23);
            this.textBoxEnCours.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Choix de la course";
            // 
            // buttonArret
            // 
            this.buttonArret.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonArret.Location = new System.Drawing.Point(379, 267);
            this.buttonArret.Name = "buttonArret";
            this.buttonArret.Size = new System.Drawing.Size(114, 33);
            this.buttonArret.TabIndex = 5;
            this.buttonArret.Text = "Arrêter";
            this.buttonArret.UseVisualStyleBackColor = true;
            this.buttonArret.Click += new System.EventHandler(this.buttonArret_Click);
            // 
            // buttonQuitter
            // 
            this.buttonQuitter.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuitter.Location = new System.Drawing.Point(767, 420);
            this.buttonQuitter.Name = "buttonQuitter";
            this.buttonQuitter.Size = new System.Drawing.Size(114, 33);
            this.buttonQuitter.TabIndex = 6;
            this.buttonQuitter.Text = "Quitter";
            this.buttonQuitter.UseVisualStyleBackColor = true;
            this.buttonQuitter.Click += new System.EventHandler(this.buttonQuitter_Click);
            // 
            // buttonSuspendre
            // 
            this.buttonSuspendre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSuspendre.Location = new System.Drawing.Point(379, 201);
            this.buttonSuspendre.Name = "buttonSuspendre";
            this.buttonSuspendre.Size = new System.Drawing.Size(114, 33);
            this.buttonSuspendre.TabIndex = 7;
            this.buttonSuspendre.Text = "Suspendre";
            this.buttonSuspendre.UseVisualStyleBackColor = true;
            this.buttonSuspendre.Click += new System.EventHandler(this.buttonSuspendre_Click);
            // 
            // buttonRedemarrer
            // 
            this.buttonRedemarrer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRedemarrer.Location = new System.Drawing.Point(536, 201);
            this.buttonRedemarrer.Name = "buttonRedemarrer";
            this.buttonRedemarrer.Size = new System.Drawing.Size(114, 33);
            this.buttonRedemarrer.TabIndex = 8;
            this.buttonRedemarrer.Text = "Redémarrer";
            this.buttonRedemarrer.UseVisualStyleBackColor = true;
            this.buttonRedemarrer.Click += new System.EventHandler(this.buttonRedemarrer_Click);
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Location = new System.Drawing.Point(379, 360);
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(502, 23);
            this.textBoxMessage.TabIndex = 9;
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Location = new System.Drawing.Point(376, 340);
            this.labelMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(63, 17);
            this.labelMessage.TabIndex = 10;
            this.labelMessage.Text = "Message";
            // 
            // DemarrageCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 474);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.buttonRedemarrer);
            this.Controls.Add(this.buttonSuspendre);
            this.Controls.Add(this.buttonQuitter);
            this.Controls.Add(this.buttonArret);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxEnCours);
            this.Controls.Add(this.buttonDemarrer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxCourses);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DemarrageCourse";
            this.Text = "Gestion d\'une Course";
            this.Load += new System.EventHandler(this.DemarrageCourse_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCourses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDemarrer;
        private System.Windows.Forms.TextBox textBoxEnCours;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonArret;
        private System.Windows.Forms.Button buttonQuitter;
        private System.Windows.Forms.Button buttonSuspendre;
        private System.Windows.Forms.Button buttonRedemarrer;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.Label labelMessage;
    }
}