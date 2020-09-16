namespace Semaine4_2
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
            this.comboBoxElection = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxCandidats = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // comboBoxElection
            // 
            this.comboBoxElection.FormattingEnabled = true;
            this.comboBoxElection.Location = new System.Drawing.Point(84, 104);
            this.comboBoxElection.Name = "comboBoxElection";
            this.comboBoxElection.Size = new System.Drawing.Size(328, 24);
            this.comboBoxElection.TabIndex = 0;
            this.comboBoxElection.SelectedIndexChanged += new System.EventHandler(this.comboBoxElection_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Circonscriptions - Élection:";
            // 
            // listBoxCandidats
            // 
            this.listBoxCandidats.FormattingEnabled = true;
            this.listBoxCandidats.ItemHeight = 16;
            this.listBoxCandidats.Location = new System.Drawing.Point(84, 161);
            this.listBoxCandidats.Name = "listBoxCandidats";
            this.listBoxCandidats.Size = new System.Drawing.Size(328, 116);
            this.listBoxCandidats.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxCandidats);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxElection);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxElection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxCandidats;
    }
}

