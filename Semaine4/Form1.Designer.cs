namespace Semaine4
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
            this.listBoxObjets = new System.Windows.Forms.ListBox();
            this.buttonAjoutObjet = new System.Windows.Forms.Button();
            this.buttonEnlever = new System.Windows.Forms.Button();
            this.buttonAfficher = new System.Windows.Forms.Button();
            this.buttonChercher = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxObjet = new System.Windows.Forms.TextBox();
            this.buttonForcer = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // listBoxObjets
            // 
            this.listBoxObjets.FormattingEnabled = true;
            this.listBoxObjets.ItemHeight = 16;
            this.listBoxObjets.Items.AddRange(new object[] {
            "Premier Objet"});
            this.listBoxObjets.Location = new System.Drawing.Point(58, 34);
            this.listBoxObjets.Name = "listBoxObjets";
            this.listBoxObjets.Size = new System.Drawing.Size(187, 180);
            this.listBoxObjets.TabIndex = 0;
            // 
            // buttonAjoutObjet
            // 
            this.buttonAjoutObjet.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAjoutObjet.Location = new System.Drawing.Point(58, 237);
            this.buttonAjoutObjet.Name = "buttonAjoutObjet";
            this.buttonAjoutObjet.Size = new System.Drawing.Size(187, 93);
            this.buttonAjoutObjet.TabIndex = 1;
            this.buttonAjoutObjet.Text = "Ajouter objet";
            this.buttonAjoutObjet.UseVisualStyleBackColor = true;
            this.buttonAjoutObjet.Click += new System.EventHandler(this.buttonAjoutObjet_Click);
            // 
            // buttonEnlever
            // 
            this.buttonEnlever.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEnlever.Location = new System.Drawing.Point(251, 237);
            this.buttonEnlever.Name = "buttonEnlever";
            this.buttonEnlever.Size = new System.Drawing.Size(187, 93);
            this.buttonEnlever.TabIndex = 2;
            this.buttonEnlever.Text = "Enlever objet";
            this.buttonEnlever.UseVisualStyleBackColor = true;
            this.buttonEnlever.Click += new System.EventHandler(this.buttonEnlever_Click);
            // 
            // buttonAfficher
            // 
            this.buttonAfficher.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAfficher.Location = new System.Drawing.Point(444, 237);
            this.buttonAfficher.Name = "buttonAfficher";
            this.buttonAfficher.Size = new System.Drawing.Size(187, 93);
            this.buttonAfficher.TabIndex = 3;
            this.buttonAfficher.Text = "Afficher Sélection";
            this.buttonAfficher.UseVisualStyleBackColor = true;
            this.buttonAfficher.Click += new System.EventHandler(this.buttonAfficher_Click);
            // 
            // buttonChercher
            // 
            this.buttonChercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChercher.Location = new System.Drawing.Point(251, 345);
            this.buttonChercher.Name = "buttonChercher";
            this.buttonChercher.Size = new System.Drawing.Size(187, 93);
            this.buttonChercher.TabIndex = 4;
            this.buttonChercher.Text = "Chercher Objet";
            this.buttonChercher.UseVisualStyleBackColor = true;
            this.buttonChercher.Click += new System.EventHandler(this.buttonChercher_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 345);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Objet à chercher";
            // 
            // textBoxObjet
            // 
            this.textBoxObjet.Location = new System.Drawing.Point(27, 390);
            this.textBoxObjet.Name = "textBoxObjet";
            this.textBoxObjet.Size = new System.Drawing.Size(218, 22);
            this.textBoxObjet.TabIndex = 6;
            // 
            // buttonForcer
            // 
            this.buttonForcer.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonForcer.Location = new System.Drawing.Point(444, 345);
            this.buttonForcer.Name = "buttonForcer";
            this.buttonForcer.Size = new System.Drawing.Size(187, 93);
            this.buttonForcer.TabIndex = 7;
            this.buttonForcer.Text = "Forcer Sélection";
            this.buttonForcer.UseVisualStyleBackColor = true;
            this.buttonForcer.Click += new System.EventHandler(this.buttonForcer_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Premier Objet"});
            this.comboBox1.Location = new System.Drawing.Point(252, 34);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(186, 24);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonForcer);
            this.Controls.Add(this.textBoxObjet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonChercher);
            this.Controls.Add(this.buttonAfficher);
            this.Controls.Add(this.buttonEnlever);
            this.Controls.Add(this.buttonAjoutObjet);
            this.Controls.Add(this.listBoxObjets);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxObjets;
        private System.Windows.Forms.Button buttonAjoutObjet;
        private System.Windows.Forms.Button buttonEnlever;
        private System.Windows.Forms.Button buttonAfficher;
        private System.Windows.Forms.Button buttonChercher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxObjet;
        private System.Windows.Forms.Button buttonForcer;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

