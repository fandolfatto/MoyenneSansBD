namespace Moyenne
{
    partial class frmEleve
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
            this.lblDonneesPersonnelles = new System.Windows.Forms.Label();
            this.pctEleve = new System.Windows.Forms.PictureBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.cmdAjouter = new System.Windows.Forms.Button();
            this.cmdModifier = new System.Windows.Forms.Button();
            this.cmdSupprimer = new System.Windows.Forms.Button();
            this.lstNotes = new System.Windows.Forms.ListBox();
            this.lblMoyenne = new System.Windows.Forms.Label();
            this.lblResMoyenne = new System.Windows.Forms.Label();
            this.cmdValider = new System.Windows.Forms.Button();
            this.cmdAnnuler = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctEleve)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDonneesPersonnelles
            // 
            this.lblDonneesPersonnelles.AutoSize = true;
            this.lblDonneesPersonnelles.Location = new System.Drawing.Point(25, 26);
            this.lblDonneesPersonnelles.Name = "lblDonneesPersonnelles";
            this.lblDonneesPersonnelles.Size = new System.Drawing.Size(112, 13);
            this.lblDonneesPersonnelles.TabIndex = 0;
            this.lblDonneesPersonnelles.Text = "Données personnelles";
            // 
            // pctEleve
            // 
            this.pctEleve.Location = new System.Drawing.Point(28, 59);
            this.pctEleve.Name = "pctEleve";
            this.pctEleve.Size = new System.Drawing.Size(119, 128);
            this.pctEleve.TabIndex = 1;
            this.pctEleve.TabStop = false;
            this.pctEleve.DoubleClick += new System.EventHandler(this.pctEleve_DoubleClick);
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(188, 64);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(35, 13);
            this.lblNom.TabIndex = 2;
            this.lblNom.Text = "Nom :";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(189, 112);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(49, 13);
            this.lblPrenom.TabIndex = 3;
            this.lblPrenom.Text = "Prénom :";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(258, 59);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(126, 20);
            this.txtNom.TabIndex = 4;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(258, 104);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(126, 20);
            this.txtPrenom.TabIndex = 5;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(33, 222);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(53, 13);
            this.lblNotes.TabIndex = 6;
            this.lblNotes.Text = "Les notes";
            // 
            // cmdAjouter
            // 
            this.cmdAjouter.Location = new System.Drawing.Point(36, 262);
            this.cmdAjouter.Name = "cmdAjouter";
            this.cmdAjouter.Size = new System.Drawing.Size(88, 29);
            this.cmdAjouter.TabIndex = 7;
            this.cmdAjouter.Text = "Ajouter";
            this.cmdAjouter.UseVisualStyleBackColor = true;
            this.cmdAjouter.Click += new System.EventHandler(this.cmdAjouter_Click);
            // 
            // cmdModifier
            // 
            this.cmdModifier.Location = new System.Drawing.Point(36, 306);
            this.cmdModifier.Name = "cmdModifier";
            this.cmdModifier.Size = new System.Drawing.Size(88, 29);
            this.cmdModifier.TabIndex = 8;
            this.cmdModifier.Text = "Modifier";
            this.cmdModifier.UseVisualStyleBackColor = true;
            this.cmdModifier.Click += new System.EventHandler(this.cmdModifier_Click);
            // 
            // cmdSupprimer
            // 
            this.cmdSupprimer.Location = new System.Drawing.Point(36, 348);
            this.cmdSupprimer.Name = "cmdSupprimer";
            this.cmdSupprimer.Size = new System.Drawing.Size(88, 29);
            this.cmdSupprimer.TabIndex = 9;
            this.cmdSupprimer.Text = "Supprimer";
            this.cmdSupprimer.UseVisualStyleBackColor = true;
            this.cmdSupprimer.Click += new System.EventHandler(this.cmdSupprimer_Click);
            // 
            // lstNotes
            // 
            this.lstNotes.FormattingEnabled = true;
            this.lstNotes.Location = new System.Drawing.Point(156, 265);
            this.lstNotes.Name = "lstNotes";
            this.lstNotes.Size = new System.Drawing.Size(97, 108);
            this.lstNotes.TabIndex = 10;
            this.lstNotes.Click += new System.EventHandler(this.lstNotes_Click);
            this.lstNotes.DoubleClick += new System.EventHandler(this.lstNotes_DoubleClick);
            // 
            // lblMoyenne
            // 
            this.lblMoyenne.AutoSize = true;
            this.lblMoyenne.Location = new System.Drawing.Point(278, 264);
            this.lblMoyenne.Name = "lblMoyenne";
            this.lblMoyenne.Size = new System.Drawing.Size(57, 13);
            this.lblMoyenne.TabIndex = 11;
            this.lblMoyenne.Text = "Moyenne :";
            // 
            // lblResMoyenne
            // 
            this.lblResMoyenne.AutoSize = true;
            this.lblResMoyenne.Location = new System.Drawing.Point(341, 264);
            this.lblResMoyenne.Name = "lblResMoyenne";
            this.lblResMoyenne.Size = new System.Drawing.Size(13, 13);
            this.lblResMoyenne.TabIndex = 12;
            this.lblResMoyenne.Text = "0";
            // 
            // cmdValider
            // 
            this.cmdValider.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.cmdValider.Location = new System.Drawing.Point(84, 408);
            this.cmdValider.Name = "cmdValider";
            this.cmdValider.Size = new System.Drawing.Size(107, 27);
            this.cmdValider.TabIndex = 13;
            this.cmdValider.Text = "Valider";
            this.cmdValider.UseVisualStyleBackColor = true;
            this.cmdValider.Click += new System.EventHandler(this.cmdValider_Click);
            // 
            // cmdAnnuler
            // 
            this.cmdAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdAnnuler.Location = new System.Drawing.Point(233, 408);
            this.cmdAnnuler.Name = "cmdAnnuler";
            this.cmdAnnuler.Size = new System.Drawing.Size(125, 26);
            this.cmdAnnuler.TabIndex = 14;
            this.cmdAnnuler.Text = "Annuler";
            this.cmdAnnuler.UseVisualStyleBackColor = true;
            this.cmdAnnuler.Click += new System.EventHandler(this.cmdAnnuler_Click);
            // 
            // frmEleve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 449);
            this.Controls.Add(this.cmdAnnuler);
            this.Controls.Add(this.cmdValider);
            this.Controls.Add(this.lblResMoyenne);
            this.Controls.Add(this.lblMoyenne);
            this.Controls.Add(this.lstNotes);
            this.Controls.Add(this.cmdSupprimer);
            this.Controls.Add(this.cmdModifier);
            this.Controls.Add(this.cmdAjouter);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.pctEleve);
            this.Controls.Add(this.lblDonneesPersonnelles);
            this.Name = "frmEleve";
            this.Text = "Elève";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmEleve_FormClosing);
            this.Load += new System.EventHandler(this.frmEleve_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctEleve)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDonneesPersonnelles;
        private System.Windows.Forms.PictureBox pctEleve;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Button cmdAjouter;
        private System.Windows.Forms.Button cmdModifier;
        private System.Windows.Forms.Button cmdSupprimer;
        private System.Windows.Forms.ListBox lstNotes;
        private System.Windows.Forms.Label lblMoyenne;
        private System.Windows.Forms.Button cmdValider;
        private System.Windows.Forms.Button cmdAnnuler;
        public System.Windows.Forms.TextBox txtNom;
        public System.Windows.Forms.TextBox txtPrenom;
        public System.Windows.Forms.Label lblResMoyenne;
    }
}