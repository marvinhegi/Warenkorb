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
            // FormWarenkorb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelWarenborbFormWarenkorb);
            this.Controls.Add(this.pictureBoxWarenkorbBildFormWarenkorb);
            this.Name = "FormWarenkorb";
            this.Text = "FormWarenkorb";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWarenkorbBildFormWarenkorb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxWarenkorbBildFormWarenkorb;
        private System.Windows.Forms.Label labelWarenborbFormWarenkorb;
    }
}