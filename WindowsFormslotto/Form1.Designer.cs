namespace WindowsFormslotto
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.l_chiffreChoisis = new System.Windows.Forms.Label();
            this.l_chiffreGagnants = new System.Windows.Forms.Label();
            this.l_listeDesChiffresGagnant = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(62, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(580, 569);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 625);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chiffre Choisis: ";
            // 
            // l_chiffreChoisis
            // 
            this.l_chiffreChoisis.AutoSize = true;
            this.l_chiffreChoisis.Location = new System.Drawing.Point(183, 625);
            this.l_chiffreChoisis.Name = "l_chiffreChoisis";
            this.l_chiffreChoisis.Size = new System.Drawing.Size(0, 20);
            this.l_chiffreChoisis.TabIndex = 2;
            // 
            // l_chiffreGagnants
            // 
            this.l_chiffreGagnants.AutoSize = true;
            this.l_chiffreGagnants.Location = new System.Drawing.Point(58, 678);
            this.l_chiffreGagnants.Name = "l_chiffreGagnants";
            this.l_chiffreGagnants.Size = new System.Drawing.Size(51, 20);
            this.l_chiffreGagnants.TabIndex = 3;
            this.l_chiffreGagnants.Text = "label2";
            // 
            // l_listeDesChiffresGagnant
            // 
            this.l_listeDesChiffresGagnant.AutoSize = true;
            this.l_listeDesChiffresGagnant.Location = new System.Drawing.Point(197, 678);
            this.l_listeDesChiffresGagnant.Name = "l_listeDesChiffresGagnant";
            this.l_listeDesChiffresGagnant.Size = new System.Drawing.Size(51, 20);
            this.l_listeDesChiffresGagnant.TabIndex = 4;
            this.l_listeDesChiffresGagnant.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 775);
            this.Controls.Add(this.l_listeDesChiffresGagnant);
            this.Controls.Add(this.l_chiffreGagnants);
            this.Controls.Add(this.l_chiffreChoisis);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label l_chiffreChoisis;
        private System.Windows.Forms.Label l_chiffreGagnants;
        private System.Windows.Forms.Label l_listeDesChiffresGagnant;
    }
}

