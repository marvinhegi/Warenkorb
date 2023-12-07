namespace Warenkorb
{
    partial class FormProduktliste
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonHinzufugen = new System.Windows.Forms.Button();
            this.comboBoxProdukt = new System.Windows.Forms.ComboBox();
            this.labelProdukt = new System.Windows.Forms.Label();
            this.labelAnzahl = new System.Windows.Forms.Label();
            this.numericUpDown1Anzahl = new System.Windows.Forms.NumericUpDown();
            this.pictureBoxWarenkorbBildFormProduktliste = new System.Windows.Forms.PictureBox();
            this.labelWarenkorbAnzahl = new System.Windows.Forms.Label();
            this.linkLabelWarenkorb = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1Anzahl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWarenkorbBildFormProduktliste)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonHinzufugen
            // 
            this.buttonHinzufugen.Location = new System.Drawing.Point(188, 293);
            this.buttonHinzufugen.Name = "buttonHinzufugen";
            this.buttonHinzufugen.Size = new System.Drawing.Size(283, 39);
            this.buttonHinzufugen.TabIndex = 0;
            this.buttonHinzufugen.Text = "Zum Warenkorb hinzufügen";
            this.buttonHinzufugen.UseVisualStyleBackColor = true;
            // 
            // comboBoxProdukt
            // 
            this.comboBoxProdukt.FormattingEnabled = true;
            this.comboBoxProdukt.Location = new System.Drawing.Point(188, 115);
            this.comboBoxProdukt.Name = "comboBoxProdukt";
            this.comboBoxProdukt.Size = new System.Drawing.Size(283, 24);
            this.comboBoxProdukt.TabIndex = 1;
            // 
            // labelProdukt
            // 
            this.labelProdukt.AutoSize = true;
            this.labelProdukt.Location = new System.Drawing.Point(75, 123);
            this.labelProdukt.Name = "labelProdukt";
            this.labelProdukt.Size = new System.Drawing.Size(70, 20);
            this.labelProdukt.TabIndex = 2;
            this.labelProdukt.Text = "Produkt:";
            // 
            // labelAnzahl
            // 
            this.labelAnzahl.AutoSize = true;
            this.labelAnzahl.Location = new System.Drawing.Point(75, 204);
            this.labelAnzahl.Name = "labelAnzahl";
            this.labelAnzahl.Size = new System.Drawing.Size(63, 20);
            this.labelAnzahl.TabIndex = 3;
            this.labelAnzahl.Text = "Anzahl:";
            // 
            // numericUpDown1Anzahl
            // 
            this.numericUpDown1Anzahl.Location = new System.Drawing.Point(351, 202);
            this.numericUpDown1Anzahl.Name = "numericUpDown1Anzahl";
            this.numericUpDown1Anzahl.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1Anzahl.TabIndex = 4;
            // 
            // pictureBoxWarenkorbBildFormProduktliste
            // 
            this.pictureBoxWarenkorbBildFormProduktliste.Image = global::Warenkorb.Properties.Resources.Warenkorbbild;
            this.pictureBoxWarenkorbBildFormProduktliste.Location = new System.Drawing.Point(264, 32);
            this.pictureBoxWarenkorbBildFormProduktliste.Name = "pictureBoxWarenkorbBildFormProduktliste";
            this.pictureBoxWarenkorbBildFormProduktliste.Size = new System.Drawing.Size(69, 67);
            this.pictureBoxWarenkorbBildFormProduktliste.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxWarenkorbBildFormProduktliste.TabIndex = 5;
            this.pictureBoxWarenkorbBildFormProduktliste.TabStop = false;
            // 
            // labelWarenkorbAnzahl
            // 
            this.labelWarenkorbAnzahl.AutoSize = true;
            this.labelWarenkorbAnzahl.Location = new System.Drawing.Point(244, 60);
            this.labelWarenkorbAnzahl.Name = "labelWarenkorbAnzahl";
            this.labelWarenkorbAnzahl.Size = new System.Drawing.Size(14, 16);
            this.labelWarenkorbAnzahl.TabIndex = 6;
            this.labelWarenkorbAnzahl.Text = "0";
            // 
            // linkLabelWarenkorb
            // 
            this.linkLabelWarenkorb.AutoSize = true;
            this.linkLabelWarenkorb.Location = new System.Drawing.Point(339, 60);
            this.linkLabelWarenkorb.Name = "linkLabelWarenkorb";
            this.linkLabelWarenkorb.Size = new System.Drawing.Size(132, 16);
            this.linkLabelWarenkorb.TabIndex = 7;
            this.linkLabelWarenkorb.TabStop = true;
            this.linkLabelWarenkorb.Text = "Warenkorb anzeigen";
            // 
            // FormProduktliste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkLabelWarenkorb);
            this.Controls.Add(this.labelWarenkorbAnzahl);
            this.Controls.Add(this.pictureBoxWarenkorbBildFormProduktliste);
            this.Controls.Add(this.numericUpDown1Anzahl);
            this.Controls.Add(this.labelAnzahl);
            this.Controls.Add(this.labelProdukt);
            this.Controls.Add(this.comboBoxProdukt);
            this.Controls.Add(this.buttonHinzufugen);
            this.Name = "FormProduktliste";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1Anzahl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWarenkorbBildFormProduktliste)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonHinzufugen;
        private System.Windows.Forms.ComboBox comboBoxProdukt;
        private System.Windows.Forms.Label labelProdukt;
        private System.Windows.Forms.Label labelAnzahl;
        private System.Windows.Forms.NumericUpDown numericUpDown1Anzahl;
        private System.Windows.Forms.PictureBox pictureBoxWarenkorbBildFormProduktliste;
        private System.Windows.Forms.Label labelWarenkorbAnzahl;
        private System.Windows.Forms.LinkLabel linkLabelWarenkorb;
    }
}

