namespace Moyenne
{
    partial class frmSaisieNote
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
            this.nudEntier = new System.Windows.Forms.NumericUpDown();
            this.nudDecimal = new System.Windows.Forms.NumericUpDown();
            this.cmdValider = new System.Windows.Forms.Button();
            this.cmdAnnuler = new System.Windows.Forms.Button();
            this.lblSeparation = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudEntier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDecimal)).BeginInit();
            this.SuspendLayout();
            // 
            // nudEntier
            // 
            this.nudEntier.Location = new System.Drawing.Point(23, 31);
            this.nudEntier.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudEntier.Name = "nudEntier";
            this.nudEntier.Size = new System.Drawing.Size(79, 20);
            this.nudEntier.TabIndex = 0;
            this.nudEntier.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudEntier.ValueChanged += new System.EventHandler(this.nudEntier_ValueChanged);
            // 
            // nudDecimal
            // 
            this.nudDecimal.Location = new System.Drawing.Point(145, 30);
            this.nudDecimal.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudDecimal.Name = "nudDecimal";
            this.nudDecimal.Size = new System.Drawing.Size(83, 20);
            this.nudDecimal.TabIndex = 1;
            // 
            // cmdValider
            // 
            this.cmdValider.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.cmdValider.Location = new System.Drawing.Point(24, 89);
            this.cmdValider.Name = "cmdValider";
            this.cmdValider.Size = new System.Drawing.Size(89, 21);
            this.cmdValider.TabIndex = 2;
            this.cmdValider.Text = "Valider";
            this.cmdValider.UseVisualStyleBackColor = true;
            this.cmdValider.Click += new System.EventHandler(this.cmdValider_Click);
            // 
            // cmdAnnuler
            // 
            this.cmdAnnuler.Location = new System.Drawing.Point(142, 87);
            this.cmdAnnuler.Name = "cmdAnnuler";
            this.cmdAnnuler.Size = new System.Drawing.Size(76, 22);
            this.cmdAnnuler.TabIndex = 3;
            this.cmdAnnuler.Text = "Annuler";
            this.cmdAnnuler.UseVisualStyleBackColor = true;
            this.cmdAnnuler.Click += new System.EventHandler(this.cmdAnnuler_Click);
            // 
            // lblSeparation
            // 
            this.lblSeparation.AutoSize = true;
            this.lblSeparation.Location = new System.Drawing.Point(115, 32);
            this.lblSeparation.Name = "lblSeparation";
            this.lblSeparation.Size = new System.Drawing.Size(10, 13);
            this.lblSeparation.TabIndex = 4;
            this.lblSeparation.Text = ".";
            // 
            // frmSaisieNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 132);
            this.Controls.Add(this.lblSeparation);
            this.Controls.Add(this.cmdAnnuler);
            this.Controls.Add(this.cmdValider);
            this.Controls.Add(this.nudDecimal);
            this.Controls.Add(this.nudEntier);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSaisieNote";
            this.Text = "Saisie de note";
            this.Load += new System.EventHandler(this.frmSaisieNote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudEntier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDecimal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cmdValider;
        private System.Windows.Forms.Button cmdAnnuler;
        private System.Windows.Forms.Label lblSeparation;
        public System.Windows.Forms.NumericUpDown nudEntier;
        public System.Windows.Forms.NumericUpDown nudDecimal;
    }
}