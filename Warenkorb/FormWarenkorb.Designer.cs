namespace Warenkorb
{
    partial class FormWarenkorb
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
            this.pictureBoxWarenkorbBildFormWarenkorb = new System.Windows.Forms.PictureBox();
            this.labelWarenborbFormWarenkorb = new System.Windows.Forms.Label();
            this.textBoxWarenkorbProdukte = new System.Windows.Forms.TextBox();
            this.labelSumme = new System.Windows.Forms.Label();
            this.labelSummeValue = new System.Windows.Forms.Label();
            this.buttonabbrechen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWarenkorbBildFormWarenkorb)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxWarenkorbBildFormWarenkorb
            // 
            this.pictureBoxWarenkorbBildFormWarenkorb.Image = global::Warenkorb.Properties.Resources.Warenkorbbild;
            this.pictureBoxWarenkorbBildFormWarenkorb.Location = new System.Drawing.Point(103, 37);
            this.pictureBoxWarenkorbBildFormWarenkorb.Name = "pictureBoxWarenkorbBildFormWarenkorb";
            this.pictureBoxWarenkorbBildFormWarenkorb.Size = new System.Drawing.Size(69, 67);
            this.pictureBoxWarenkorbBildFormWarenkorb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxWarenkorbBildFormWarenkorb.TabIndex = 6;
            this.pictureBoxWarenkorbBildFormWarenkorb.TabStop = false;
            // 
            // labelWarenborbFormWarenkorb
            // 
            this.labelWarenborbFormWarenkorb.AutoSize = true;
            this.labelWarenborbFormWarenkorb.Location = new System.Drawing.Point(194, 61);
            this.labelWarenborbFormWarenkorb.Name = "labelWarenborbFormWarenkorb";
            this.labelWarenborbFormWarenkorb.Size = new System.Drawing.Size(105, 16);
            this.labelWarenborbFormWarenkorb.TabIndex = 7;
            this.labelWarenborbFormWarenkorb.Text = "Dein Warenkorb";
            // 
            // textBoxWarenkorbProdukte
            // 
            this.textBoxWarenkorbProdukte.Location = new System.Drawing.Point(103, 127);
            this.textBoxWarenkorbProdukte.Multiline = true;
            this.textBoxWarenkorbProdukte.Name = "textBoxWarenkorbProdukte";
            this.textBoxWarenkorbProdukte.Size = new System.Drawing.Size(460, 291);
            this.textBoxWarenkorbProdukte.TabIndex = 8;
            // 
            // labelSumme
            // 
            this.labelSumme.AutoSize = true;
            this.labelSumme.Location = new System.Drawing.Point(100, 448);
            this.labelSumme.Name = "labelSumme";
            this.labelSumme.Size = new System.Drawing.Size(140, 20);
            this.labelSumme.TabIndex = 9;
            this.labelSumme.Text = "Gesammtsumme:";
            // 
            // labelSummeValue
            // 
            this.labelSummeValue.AutoSize = true;
            this.labelSummeValue.Location = new System.Drawing.Point(212, 448);
            this.labelSummeValue.Name = "labelSummeValue";
            this.labelSummeValue.Size = new System.Drawing.Size(18, 20);
            this.labelSummeValue.TabIndex = 10;
            this.labelSummeValue.Text = "0";
            // 
            // buttonabbrechen
            // 
            this.buttonabbrechen.Location = new System.Drawing.Point(452, 441);
            this.buttonabbrechen.Name = "buttonabbrechen";
            this.buttonabbrechen.Size = new System.Drawing.Size(111, 27);
            this.buttonabbrechen.TabIndex = 11;
            this.buttonabbrechen.Text = "Abbrechen";
            this.buttonabbrechen.UseVisualStyleBackColor = true;
            this.buttonabbrechen.Click += new System.EventHandler(this.buttonabbrechen_Click);
            // 
            // FormWarenkorb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 560);
            this.Controls.Add(this.buttonabbrechen);
            this.Controls.Add(this.labelSummeValue);
            this.Controls.Add(this.labelSumme);
            this.Controls.Add(this.textBoxWarenkorbProdukte);
            this.Controls.Add(this.labelWarenborbFormWarenkorb);
            this.Controls.Add(this.pictureBoxWarenkorbBildFormWarenkorb);
            this.Name = "FormWarenkorb";
            this.Text = "FormWarenkorb";
            this.Load += new System.EventHandler(this.FormWarenkorb_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWarenkorbBildFormWarenkorb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxWarenkorbBildFormWarenkorb;
        private System.Windows.Forms.Label labelWarenborbFormWarenkorb;
        private System.Windows.Forms.TextBox textBoxWarenkorbProdukte;
        private System.Windows.Forms.Label labelSumme;
        private System.Windows.Forms.Label labelSummeValue;
        private System.Windows.Forms.Button buttonabbrechen;
    }
}