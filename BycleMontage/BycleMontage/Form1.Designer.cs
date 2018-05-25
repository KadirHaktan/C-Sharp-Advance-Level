namespace BycleMontage
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
            this.comboBoxFrenTipi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxKadroTipi = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtYasi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxFrenTipi
            // 
            this.comboBoxFrenTipi.FormattingEnabled = true;
            this.comboBoxFrenTipi.Items.AddRange(new object[] {
            "Hidrolik",
            "Mekanik",
            "Kontra"});
            this.comboBoxFrenTipi.Location = new System.Drawing.Point(110, 15);
            this.comboBoxFrenTipi.Name = "comboBoxFrenTipi";
            this.comboBoxFrenTipi.Size = new System.Drawing.Size(227, 24);
            this.comboBoxFrenTipi.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fren Tipi : ";
            // 
            // comboBoxKadroTipi
            // 
            this.comboBoxKadroTipi.FormattingEnabled = true;
            this.comboBoxKadroTipi.Items.AddRange(new object[] {
            "Alüminyum",
            "Çelik"});
            this.comboBoxKadroTipi.Location = new System.Drawing.Point(110, 54);
            this.comboBoxKadroTipi.Name = "comboBoxKadroTipi";
            this.comboBoxKadroTipi.Size = new System.Drawing.Size(227, 24);
            this.comboBoxKadroTipi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kadro Tipi : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Model Yılı :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(110, 104);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(227, 22);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Yaş : ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(142, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "Class\'a Gönder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtYasi
            // 
            this.txtYasi.AutoSize = true;
            this.txtYasi.Location = new System.Drawing.Point(110, 143);
            this.txtYasi.Name = "txtYasi";
            this.txtYasi.Size = new System.Drawing.Size(32, 17);
            this.txtYasi.TabIndex = 3;
            this.txtYasi.Text = "......";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 210);
            this.Controls.Add(this.txtYasi);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxKadroTipi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxFrenTipi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxFrenTipi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxKadroTipi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label txtYasi;
    }
}

