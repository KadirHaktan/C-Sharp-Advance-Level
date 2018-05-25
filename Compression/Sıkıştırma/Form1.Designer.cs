namespace Sıkıştırma
{
    partial class Form1
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
            this.btnSikistirma = new System.Windows.Forms.Button();
            this.btnAc = new System.Windows.Forms.Button();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // btnSikistirma
            // 
            this.btnSikistirma.Location = new System.Drawing.Point(29, 30);
            this.btnSikistirma.Name = "btnSikistirma";
            this.btnSikistirma.Size = new System.Drawing.Size(75, 23);
            this.btnSikistirma.TabIndex = 0;
            this.btnSikistirma.Text = "Sıkıştırma";
            this.btnSikistirma.UseVisualStyleBackColor = true;
            this.btnSikistirma.Click += new System.EventHandler(this.btnSikistirma_Click);
            // 
            // btnAc
            // 
            this.btnAc.Location = new System.Drawing.Point(147, 30);
            this.btnAc.Name = "btnAc";
            this.btnAc.Size = new System.Drawing.Size(75, 23);
            this.btnAc.TabIndex = 1;
            this.btnAc.Text = "Aç";
            this.btnAc.UseVisualStyleBackColor = true;
            this.btnAc.Click += new System.EventHandler(this.btnAc_Click);
            // 
            // ofd
            // 
            this.ofd.FileName = "ofd";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 93);
            this.Controls.Add(this.btnAc);
            this.Controls.Add(this.btnSikistirma);
            this.Name = "Form1";
            this.Text = "Dosya Sıkıştırma";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSikistirma;
        private System.Windows.Forms.Button btnAc;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.SaveFileDialog sfd;
    }
}

