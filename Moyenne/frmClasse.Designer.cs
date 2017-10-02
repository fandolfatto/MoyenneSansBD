namespace Moyenne
{
    partial class frmClasse
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
            this.lstEleves = new System.Windows.Forms.ListBox();
            this.lblEleves = new System.Windows.Forms.Label();
            this.cmdAjouter = new System.Windows.Forms.Button();
            this.cmdModifier = new System.Windows.Forms.Button();
            this.cmdSupprimer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstEleves
            // 
            this.lstEleves.FormattingEnabled = true;
            this.lstEleves.Location = new System.Drawing.Point(37, 44);
            this.lstEleves.Name = "lstEleves";
            this.lstEleves.Size = new System.Drawing.Size(196, 225);
            this.lstEleves.TabIndex = 0;
            this.lstEleves.Click += new System.EventHandler(this.lstEleves_Click);
            this.lstEleves.DoubleClick += new System.EventHandler(this.lstEleves_DoubleClick);
            // 
            // lblEleves
            // 
            this.lblEleves.AutoSize = true;
            this.lblEleves.Location = new System.Drawing.Point(34, 19);
            this.lblEleves.Name = "lblEleves";
            this.lblEleves.Size = new System.Drawing.Size(39, 13);
            this.lblEleves.TabIndex = 1;
            this.lblEleves.Text = "Elèves";
            // 
            // cmdAjouter
            // 
            this.cmdAjouter.Location = new System.Drawing.Point(282, 64);
            this.cmdAjouter.Name = "cmdAjouter";
            this.cmdAjouter.Size = new System.Drawing.Size(103, 47);
            this.cmdAjouter.TabIndex = 2;
            this.cmdAjouter.Text = "Ajouter";
            this.cmdAjouter.UseVisualStyleBackColor = true;
            this.cmdAjouter.Click += new System.EventHandler(this.cmdAjouter_Click);
            // 
            // cmdModifier
            // 
            this.cmdModifier.Location = new System.Drawing.Point(285, 129);
            this.cmdModifier.Name = "cmdModifier";
            this.cmdModifier.Size = new System.Drawing.Size(102, 48);
            this.cmdModifier.TabIndex = 3;
            this.cmdModifier.Text = "Modifier";
            this.cmdModifier.UseVisualStyleBackColor = true;
            this.cmdModifier.Click += new System.EventHandler(this.cmdModifier_Click);
            // 
            // cmdSupprimer
            // 
            this.cmdSupprimer.Location = new System.Drawing.Point(285, 197);
            this.cmdSupprimer.Name = "cmdSupprimer";
            this.cmdSupprimer.Size = new System.Drawing.Size(100, 47);
            this.cmdSupprimer.TabIndex = 4;
            this.cmdSupprimer.Text = "Supprimer";
            this.cmdSupprimer.UseVisualStyleBackColor = true;
            this.cmdSupprimer.Click += new System.EventHandler(this.cmdSupprimer_Click);
            // 
            // frmMoyenne
            // 
            this.AcceptButton = this.cmdAjouter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 321);
            this.Controls.Add(this.cmdSupprimer);
            this.Controls.Add(this.cmdModifier);
            this.Controls.Add(this.cmdAjouter);
            this.Controls.Add(this.lblEleves);
            this.Controls.Add(this.lstEleves);
            this.Name = "frmMoyenne";
            this.Text = "Moyenne";
            this.Load += new System.EventHandler(this.frmMoyenne_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstEleves;
        private System.Windows.Forms.Label lblEleves;
        private System.Windows.Forms.Button cmdAjouter;
        private System.Windows.Forms.Button cmdModifier;
        private System.Windows.Forms.Button cmdSupprimer;
    }
}

