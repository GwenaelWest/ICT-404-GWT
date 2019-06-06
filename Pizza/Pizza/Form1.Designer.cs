namespace Pizza
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
            this.txtTable = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAnchois = new System.Windows.Forms.CheckBox();
            this.btnCapre = new System.Windows.Forms.CheckBox();
            this.btnJambon = new System.Windows.Forms.CheckBox();
            this.btnCrevettes = new System.Windows.Forms.CheckBox();
            this.btnCommander = new System.Windows.Forms.Button();
            this.btnExtrafine = new System.Windows.Forms.RadioButton();
            this.btnfine = new System.Windows.Forms.RadioButton();
            this.btnNormale = new System.Windows.Forms.RadioButton();
            this.btnEpaisse = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCommande = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTable
            // 
            this.txtTable.Location = new System.Drawing.Point(87, 33);
            this.txtTable.Name = "txtTable";
            this.txtTable.Size = new System.Drawing.Size(41, 20);
            this.txtTable.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Table";
            // 
            // btnAnchois
            // 
            this.btnAnchois.AutoSize = true;
            this.btnAnchois.Location = new System.Drawing.Point(260, 124);
            this.btnAnchois.Name = "btnAnchois";
            this.btnAnchois.Size = new System.Drawing.Size(64, 17);
            this.btnAnchois.TabIndex = 2;
            this.btnAnchois.Text = "Anchois";
            this.btnAnchois.UseVisualStyleBackColor = true;
            // 
            // btnCapre
            // 
            this.btnCapre.AutoSize = true;
            this.btnCapre.Location = new System.Drawing.Point(260, 147);
            this.btnCapre.Name = "btnCapre";
            this.btnCapre.Size = new System.Drawing.Size(59, 17);
            this.btnCapre.TabIndex = 3;
            this.btnCapre.Text = "Câpres";
            this.btnCapre.UseVisualStyleBackColor = true;
            // 
            // btnJambon
            // 
            this.btnJambon.AutoSize = true;
            this.btnJambon.Location = new System.Drawing.Point(260, 170);
            this.btnJambon.Name = "btnJambon";
            this.btnJambon.Size = new System.Drawing.Size(63, 17);
            this.btnJambon.TabIndex = 4;
            this.btnJambon.Text = "Jambon";
            this.btnJambon.UseVisualStyleBackColor = true;
            // 
            // btnCrevettes
            // 
            this.btnCrevettes.AutoSize = true;
            this.btnCrevettes.Location = new System.Drawing.Point(260, 193);
            this.btnCrevettes.Name = "btnCrevettes";
            this.btnCrevettes.Size = new System.Drawing.Size(71, 17);
            this.btnCrevettes.TabIndex = 5;
            this.btnCrevettes.Text = "Crevettes";
            this.btnCrevettes.UseVisualStyleBackColor = true;
            // 
            // btnCommander
            // 
            this.btnCommander.Location = new System.Drawing.Point(304, 296);
            this.btnCommander.Name = "btnCommander";
            this.btnCommander.Size = new System.Drawing.Size(111, 27);
            this.btnCommander.TabIndex = 6;
            this.btnCommander.Text = "Commander";
            this.btnCommander.UseVisualStyleBackColor = true;
            this.btnCommander.Click += new System.EventHandler(this.btnCommander_Click);
            // 
            // btnExtrafine
            // 
            this.btnExtrafine.AutoSize = true;
            this.btnExtrafine.Location = new System.Drawing.Point(87, 133);
            this.btnExtrafine.Name = "btnExtrafine";
            this.btnExtrafine.Size = new System.Drawing.Size(69, 17);
            this.btnExtrafine.TabIndex = 7;
            this.btnExtrafine.TabStop = true;
            this.btnExtrafine.Text = "Extra-fine";
            this.btnExtrafine.UseVisualStyleBackColor = true;
            // 
            // btnfine
            // 
            this.btnfine.AutoSize = true;
            this.btnfine.Location = new System.Drawing.Point(87, 157);
            this.btnfine.Name = "btnfine";
            this.btnfine.Size = new System.Drawing.Size(45, 17);
            this.btnfine.TabIndex = 8;
            this.btnfine.TabStop = true;
            this.btnfine.Text = "Fine";
            this.btnfine.UseVisualStyleBackColor = true;
            // 
            // btnNormale
            // 
            this.btnNormale.AutoSize = true;
            this.btnNormale.Location = new System.Drawing.Point(87, 181);
            this.btnNormale.Name = "btnNormale";
            this.btnNormale.Size = new System.Drawing.Size(64, 17);
            this.btnNormale.TabIndex = 9;
            this.btnNormale.TabStop = true;
            this.btnNormale.Text = "Normale";
            this.btnNormale.UseVisualStyleBackColor = true;
            // 
            // btnEpaisse
            // 
            this.btnEpaisse.AutoSize = true;
            this.btnEpaisse.Location = new System.Drawing.Point(87, 205);
            this.btnEpaisse.Name = "btnEpaisse";
            this.btnEpaisse.Size = new System.Drawing.Size(62, 17);
            this.btnEpaisse.TabIndex = 10;
            this.btnEpaisse.TabStop = true;
            this.btnEpaisse.Text = "Epaisse";
            this.btnEpaisse.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Commande";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Pâte";
            // 
            // lblCommande
            // 
            this.lblCommande.AutoSize = true;
            this.lblCommande.BackColor = System.Drawing.Color.Yellow;
            this.lblCommande.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCommande.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommande.Location = new System.Drawing.Point(65, 349);
            this.lblCommande.Name = "lblCommande";
            this.lblCommande.Size = new System.Drawing.Size(67, 24);
            this.lblCommande.TabIndex = 13;
            this.lblCommande.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 450);
            this.Controls.Add(this.lblCommande);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEpaisse);
            this.Controls.Add(this.btnNormale);
            this.Controls.Add(this.btnfine);
            this.Controls.Add(this.btnExtrafine);
            this.Controls.Add(this.btnCommander);
            this.Controls.Add(this.btnCrevettes);
            this.Controls.Add(this.btnJambon);
            this.Controls.Add(this.btnCapre);
            this.Controls.Add(this.btnAnchois);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTable);
            this.Name = "Form1";
            this.Text = "Pizza";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox btnAnchois;
        private System.Windows.Forms.CheckBox btnCapre;
        private System.Windows.Forms.CheckBox btnJambon;
        private System.Windows.Forms.CheckBox btnCrevettes;
        private System.Windows.Forms.Button btnCommander;
        private System.Windows.Forms.RadioButton btnExtrafine;
        private System.Windows.Forms.RadioButton btnfine;
        private System.Windows.Forms.RadioButton btnNormale;
        private System.Windows.Forms.RadioButton btnEpaisse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCommande;
    }
}

