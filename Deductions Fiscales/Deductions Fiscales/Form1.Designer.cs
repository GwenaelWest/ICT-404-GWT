namespace Deductions_Fiscales
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtBrut = new System.Windows.Forms.TextBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.txtCoefficient = new System.Windows.Forms.TextBox();
            this.Check1 = new System.Windows.Forms.CheckBox();
            this.Check2 = new System.Windows.Forms.CheckBox();
            this.Check3 = new System.Windows.Forms.CheckBox();
            this.txtJeune = new System.Windows.Forms.TextBox();
            this.txtFidelite = new System.Windows.Forms.TextBox();
            this.txtTransport = new System.Windows.Forms.TextBox();
            this.btnCalcul = new System.Windows.Forms.Button();
            this.lblImposable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(37, 36);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(101, 13);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Revenu annuel brut";
            // 
            // txtBrut
            // 
            this.txtBrut.Location = new System.Drawing.Point(164, 33);
            this.txtBrut.Name = "txtBrut";
            this.txtBrut.Size = new System.Drawing.Size(143, 20);
            this.txtBrut.TabIndex = 1;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(40, 80);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(91, 13);
            this.lbl2.TabIndex = 2;
            this.lbl2.Text = "Coefficient familial";
            // 
            // txtCoefficient
            // 
            this.txtCoefficient.Location = new System.Drawing.Point(262, 73);
            this.txtCoefficient.Name = "txtCoefficient";
            this.txtCoefficient.Size = new System.Drawing.Size(45, 20);
            this.txtCoefficient.TabIndex = 3;
            // 
            // Check1
            // 
            this.Check1.AutoSize = true;
            this.Check1.Location = new System.Drawing.Point(62, 145);
            this.Check1.Name = "Check1";
            this.Check1.Size = new System.Drawing.Size(104, 17);
            this.Check1.TabIndex = 4;
            this.Check1.Text = "Déduction jeune";
            this.Check1.UseVisualStyleBackColor = true;
            // 
            // Check2
            // 
            this.Check2.AutoSize = true;
            this.Check2.Location = new System.Drawing.Point(62, 172);
            this.Check2.Name = "Check2";
            this.Check2.Size = new System.Drawing.Size(119, 17);
            this.Check2.TabIndex = 5;
            this.Check2.Text = "Déduction transport";
            this.Check2.UseVisualStyleBackColor = true;
            // 
            // Check3
            // 
            this.Check3.AutoSize = true;
            this.Check3.Location = new System.Drawing.Point(62, 198);
            this.Check3.Name = "Check3";
            this.Check3.Size = new System.Drawing.Size(109, 17);
            this.Check3.TabIndex = 6;
            this.Check3.Text = "Rabais fidélité (%)";
            this.Check3.UseVisualStyleBackColor = true;
            // 
            // txtJeune
            // 
            this.txtJeune.Location = new System.Drawing.Point(207, 143);
            this.txtJeune.Name = "txtJeune";
            this.txtJeune.Size = new System.Drawing.Size(55, 20);
            this.txtJeune.TabIndex = 7;
            this.txtJeune.Text = "900";
            // 
            // txtFidelite
            // 
            this.txtFidelite.Location = new System.Drawing.Point(207, 195);
            this.txtFidelite.Name = "txtFidelite";
            this.txtFidelite.Size = new System.Drawing.Size(55, 20);
            this.txtFidelite.TabIndex = 8;
            this.txtFidelite.Text = "0";
            // 
            // txtTransport
            // 
            this.txtTransport.Location = new System.Drawing.Point(207, 169);
            this.txtTransport.Name = "txtTransport";
            this.txtTransport.Size = new System.Drawing.Size(55, 20);
            this.txtTransport.TabIndex = 9;
            this.txtTransport.Text = "650";
            // 
            // btnCalcul
            // 
            this.btnCalcul.Location = new System.Drawing.Point(104, 265);
            this.btnCalcul.Name = "btnCalcul";
            this.btnCalcul.Size = new System.Drawing.Size(75, 23);
            this.btnCalcul.TabIndex = 10;
            this.btnCalcul.Text = "Calcul";
            this.btnCalcul.UseVisualStyleBackColor = true;
            this.btnCalcul.Click += new System.EventHandler(this.btnCalcul_Click);
            // 
            // lblImposable
            // 
            this.lblImposable.AutoSize = true;
            this.lblImposable.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImposable.Location = new System.Drawing.Point(95, 328);
            this.lblImposable.Name = "lblImposable";
            this.lblImposable.Size = new System.Drawing.Size(156, 23);
            this.lblImposable.TabIndex = 11;
            this.lblImposable.Text = "Revenu imposable: ";
            this.lblImposable.Visible = false;
            this.lblImposable.Click += new System.EventHandler(this.lblImposable_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 390);
            this.Controls.Add(this.lblImposable);
            this.Controls.Add(this.btnCalcul);
            this.Controls.Add(this.txtTransport);
            this.Controls.Add(this.txtFidelite);
            this.Controls.Add(this.txtJeune);
            this.Controls.Add(this.Check3);
            this.Controls.Add(this.Check2);
            this.Controls.Add(this.Check1);
            this.Controls.Add(this.txtCoefficient);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.txtBrut);
            this.Controls.Add(this.lbl1);
            this.Name = "Form1";
            this.Text = "Déductions";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txtBrut;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox txtCoefficient;
        private System.Windows.Forms.CheckBox Check1;
        private System.Windows.Forms.CheckBox Check2;
        private System.Windows.Forms.CheckBox Check3;
        private System.Windows.Forms.TextBox txtJeune;
        private System.Windows.Forms.TextBox txtFidelite;
        private System.Windows.Forms.TextBox txtTransport;
        private System.Windows.Forms.Button btnCalcul;
        private System.Windows.Forms.Label lblImposable;
    }
}

