namespace Fenêtre_Bleue_Rouge
{
    partial class Form1
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
            this.BtnHautGauche = new System.Windows.Forms.Button();
            this.BtnHautDroite = new System.Windows.Forms.Button();
            this.BtnBasGauche = new System.Windows.Forms.Button();
            this.BtnBasDroite = new System.Windows.Forms.Button();
            this.BtnBleu = new System.Windows.Forms.Button();
            this.BtnRouge = new System.Windows.Forms.Button();
            this.BtnStats = new System.Windows.Forms.Button();
            this.BtnQuitter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnHautGauche
            // 
            this.BtnHautGauche.Location = new System.Drawing.Point(2, 3);
            this.BtnHautGauche.Name = "BtnHautGauche";
            this.BtnHautGauche.Size = new System.Drawing.Size(116, 24);
            this.BtnHautGauche.TabIndex = 0;
            this.BtnHautGauche.Text = "Haut/Gauche";
            this.BtnHautGauche.UseVisualStyleBackColor = true;
            this.BtnHautGauche.Click += new System.EventHandler(this.BtnHautGauche_Click);
            // 
            // BtnHautDroite
            // 
            this.BtnHautDroite.Location = new System.Drawing.Point(339, 3);
            this.BtnHautDroite.Name = "BtnHautDroite";
            this.BtnHautDroite.Size = new System.Drawing.Size(114, 23);
            this.BtnHautDroite.TabIndex = 1;
            this.BtnHautDroite.Text = "Haut/Droite";
            this.BtnHautDroite.UseVisualStyleBackColor = true;
            this.BtnHautDroite.Click += new System.EventHandler(this.BtnHautDroite_Click);
            // 
            // BtnBasGauche
            // 
            this.BtnBasGauche.Location = new System.Drawing.Point(2, 424);
            this.BtnBasGauche.Name = "BtnBasGauche";
            this.BtnBasGauche.Size = new System.Drawing.Size(114, 23);
            this.BtnBasGauche.TabIndex = 2;
            this.BtnBasGauche.Text = "Bas/Gauche";
            this.BtnBasGauche.UseVisualStyleBackColor = true;
            this.BtnBasGauche.Click += new System.EventHandler(this.BtnBasGauche_Click);
            // 
            // BtnBasDroite
            // 
            this.BtnBasDroite.Location = new System.Drawing.Point(343, 422);
            this.BtnBasDroite.Name = "BtnBasDroite";
            this.BtnBasDroite.Size = new System.Drawing.Size(110, 26);
            this.BtnBasDroite.TabIndex = 3;
            this.BtnBasDroite.Text = "Bas/Droite";
            this.BtnBasDroite.UseVisualStyleBackColor = true;
            this.BtnBasDroite.Click += new System.EventHandler(this.BtnBasDroite_Click);
            // 
            // BtnBleu
            // 
            this.BtnBleu.Location = new System.Drawing.Point(188, 150);
            this.BtnBleu.Name = "BtnBleu";
            this.BtnBleu.Size = new System.Drawing.Size(85, 25);
            this.BtnBleu.TabIndex = 4;
            this.BtnBleu.Text = "Bleu";
            this.BtnBleu.UseVisualStyleBackColor = true;
            this.BtnBleu.Click += new System.EventHandler(this.BtnBleu_Click);
            // 
            // BtnRouge
            // 
            this.BtnRouge.Location = new System.Drawing.Point(188, 181);
            this.BtnRouge.Name = "BtnRouge";
            this.BtnRouge.Size = new System.Drawing.Size(85, 24);
            this.BtnRouge.TabIndex = 5;
            this.BtnRouge.Text = "Rouge";
            this.BtnRouge.UseVisualStyleBackColor = true;
            this.BtnRouge.Click += new System.EventHandler(this.BtnRouge_Click);
            // 
            // BtnStats
            // 
            this.BtnStats.Location = new System.Drawing.Point(188, 265);
            this.BtnStats.Name = "BtnStats";
            this.BtnStats.Size = new System.Drawing.Size(85, 25);
            this.BtnStats.TabIndex = 6;
            this.BtnStats.Text = "Stats";
            this.BtnStats.UseVisualStyleBackColor = true;
            this.BtnStats.Click += new System.EventHandler(this.BtnStats_Click);
            // 
            // BtnQuitter
            // 
            this.BtnQuitter.Location = new System.Drawing.Point(188, 326);
            this.BtnQuitter.Name = "BtnQuitter";
            this.BtnQuitter.Size = new System.Drawing.Size(85, 24);
            this.BtnQuitter.TabIndex = 7;
            this.BtnQuitter.Text = "Quitter";
            this.BtnQuitter.UseVisualStyleBackColor = true;
            this.BtnQuitter.Click += new System.EventHandler(this.BtnQuitter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 450);
            this.Controls.Add(this.BtnQuitter);
            this.Controls.Add(this.BtnStats);
            this.Controls.Add(this.BtnRouge);
            this.Controls.Add(this.BtnBleu);
            this.Controls.Add(this.BtnBasDroite);
            this.Controls.Add(this.BtnBasGauche);
            this.Controls.Add(this.BtnHautDroite);
            this.Controls.Add(this.BtnHautGauche);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fenetre";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnHautGauche;
        private System.Windows.Forms.Button BtnHautDroite;
        private System.Windows.Forms.Button BtnBasGauche;
        private System.Windows.Forms.Button BtnBasDroite;
        private System.Windows.Forms.Button BtnBleu;
        private System.Windows.Forms.Button BtnRouge;
        private System.Windows.Forms.Button BtnStats;
        private System.Windows.Forms.Button BtnQuitter;
    }
}

