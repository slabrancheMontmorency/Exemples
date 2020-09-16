namespace Semaine3
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nom = new System.Windows.Forms.TextBox();
            this.prenom = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.radioBoutonRouge = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.defaut = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.oui = new System.Windows.Forms.RadioButton();
            this.non = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listeNoix = new System.Windows.Forms.CheckedListBox();
            this.buttonChoix = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Prénom";
            // 
            // nom
            // 
            this.nom.Location = new System.Drawing.Point(136, 121);
            this.nom.Name = "nom";
            this.nom.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.nom.Size = new System.Drawing.Size(100, 22);
            this.nom.TabIndex = 2;
            // 
            // prenom
            // 
            this.prenom.Location = new System.Drawing.Point(136, 188);
            this.prenom.Name = "prenom";
            this.prenom.Size = new System.Drawing.Size(100, 22);
            this.prenom.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(63, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 45);
            this.button1.TabIndex = 4;
            this.button1.Text = "Créer et afficher l\'objet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(298, 121);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(228, 121);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(63, 324);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(198, 66);
            this.button2.TabIndex = 6;
            this.button2.Text = "Test getters et setter";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // radioBoutonRouge
            // 
            this.radioBoutonRouge.AutoSize = true;
            this.radioBoutonRouge.Location = new System.Drawing.Point(566, 121);
            this.radioBoutonRouge.Name = "radioBoutonRouge";
            this.radioBoutonRouge.Size = new System.Drawing.Size(71, 21);
            this.radioBoutonRouge.TabIndex = 7;
            this.radioBoutonRouge.TabStop = true;
            this.radioBoutonRouge.Text = "Rouge";
            this.radioBoutonRouge.UseVisualStyleBackColor = true;
            this.radioBoutonRouge.CheckedChanged += new System.EventHandler(this.radioButtonRouge_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(566, 149);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(55, 21);
            this.radioButton2.TabIndex = 8;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Vert";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(566, 177);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(57, 21);
            this.radioButton3.TabIndex = 9;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Bleu";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // defaut
            // 
            this.defaut.AutoSize = true;
            this.defaut.Location = new System.Drawing.Point(566, 205);
            this.defaut.Name = "defaut";
            this.defaut.Size = new System.Drawing.Size(95, 21);
            this.defaut.TabIndex = 10;
            this.defaut.TabStop = true;
            this.defaut.Text = "Par défaut";
            this.defaut.UseVisualStyleBackColor = true;
            this.defaut.CheckedChanged += new System.EventHandler(this.defaut_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(751, 22);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(98, 21);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(751, 50);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(98, 21);
            this.checkBox2.TabIndex = 12;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(751, 78);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(98, 21);
            this.checkBox3.TabIndex = 13;
            this.checkBox3.Text = "checkBox3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // oui
            // 
            this.oui.AutoSize = true;
            this.oui.Location = new System.Drawing.Point(49, 21);
            this.oui.Name = "oui";
            this.oui.Size = new System.Drawing.Size(48, 21);
            this.oui.TabIndex = 14;
            this.oui.TabStop = true;
            this.oui.Text = "oui";
            this.oui.UseVisualStyleBackColor = true;
            this.oui.CheckedChanged += new System.EventHandler(this.oui_CheckedChanged);
            // 
            // non
            // 
            this.non.AutoSize = true;
            this.non.Location = new System.Drawing.Point(179, 21);
            this.non.Name = "non";
            this.non.Size = new System.Drawing.Size(53, 21);
            this.non.TabIndex = 15;
            this.non.TabStop = true;
            this.non.Text = "non";
            this.non.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.non);
            this.groupBox1.Controls.Add(this.oui);
            this.groupBox1.Location = new System.Drawing.Point(429, 295);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 49);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choix";
            // 
            // listeNoix
            // 
            this.listeNoix.CheckOnClick = true;
            this.listeNoix.Items.AddRange(new object[] {
            "Arachides",
            "Noisettes",
            "Pacanes"});
            this.listeNoix.Location = new System.Drawing.Point(716, 149);
            this.listeNoix.Name = "listeNoix";
            this.listeNoix.Size = new System.Drawing.Size(197, 89);
            this.listeNoix.TabIndex = 17;
            this.listeNoix.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // buttonChoix
            // 
            this.buttonChoix.Location = new System.Drawing.Point(429, 366);
            this.buttonChoix.Name = "buttonChoix";
            this.buttonChoix.Size = new System.Drawing.Size(288, 61);
            this.buttonChoix.TabIndex = 18;
            this.buttonChoix.Text = "Vérifier Choix";
            this.buttonChoix.UseVisualStyleBackColor = true;
            this.buttonChoix.Click += new System.EventHandler(this.buttonChoix_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1039, 430);
            this.Controls.Add(this.buttonChoix);
            this.Controls.Add(this.listeNoix);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.defaut);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioBoutonRouge);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.prenom);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nom;
        private System.Windows.Forms.TextBox prenom;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton radioBoutonRouge;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton defaut;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.RadioButton oui;
        private System.Windows.Forms.RadioButton non;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox listeNoix;
        private System.Windows.Forms.Button buttonChoix;
    }
}

