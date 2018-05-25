namespace Travel_Agent
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
            this.flwPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.grbKisisel = new System.Windows.Forms.GroupBox();
            this.txtTelNo = new DevExpress.XtraEditors.TextEdit();
            this.txtSoyad = new DevExpress.XtraEditors.TextEdit();
            this.txtAd = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.txtKoltuk = new System.Windows.Forms.TextBox();
            this.radioBayan = new System.Windows.Forms.RadioButton();
            this.radioBay = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.grbKisisel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoyad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAd.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // flwPanel
            // 
            this.flwPanel.Location = new System.Drawing.Point(12, 12);
            this.flwPanel.Name = "flwPanel";
            this.flwPanel.Size = new System.Drawing.Size(281, 672);
            this.flwPanel.TabIndex = 0;
            // 
            // grbKisisel
            // 
            this.grbKisisel.Controls.Add(this.txtTelNo);
            this.grbKisisel.Controls.Add(this.txtSoyad);
            this.grbKisisel.Controls.Add(this.txtAd);
            this.grbKisisel.Controls.Add(this.simpleButton1);
            this.grbKisisel.Controls.Add(this.txtKoltuk);
            this.grbKisisel.Controls.Add(this.radioBayan);
            this.grbKisisel.Controls.Add(this.radioBay);
            this.grbKisisel.Controls.Add(this.label5);
            this.grbKisisel.Controls.Add(this.label4);
            this.grbKisisel.Controls.Add(this.label3);
            this.grbKisisel.Controls.Add(this.label2);
            this.grbKisisel.Controls.Add(this.label1);
            this.grbKisisel.Location = new System.Drawing.Point(298, 14);
            this.grbKisisel.Name = "grbKisisel";
            this.grbKisisel.Size = new System.Drawing.Size(291, 223);
            this.grbKisisel.TabIndex = 56;
            this.grbKisisel.TabStop = false;
            this.grbKisisel.Text = "Kişisel Bilgiler";
            // 
            // txtTelNo
            // 
            this.txtTelNo.Location = new System.Drawing.Point(101, 110);
            this.txtTelNo.Name = "txtTelNo";
            this.txtTelNo.Size = new System.Drawing.Size(160, 22);
            this.txtTelNo.TabIndex = 2;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(101, 78);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(160, 22);
            this.txtSoyad.TabIndex = 1;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(101, 47);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(160, 22);
            this.txtAd.TabIndex = 0;
            // 
            // simpleButton1
            // 
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.simpleButton1.Location = new System.Drawing.Point(170, 184);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(91, 24);
            this.simpleButton1.TabIndex = 6;
            this.simpleButton1.Text = "Kaydet ";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // txtKoltuk
            // 
            this.txtKoltuk.Location = new System.Drawing.Point(101, 186);
            this.txtKoltuk.Name = "txtKoltuk";
            this.txtKoltuk.Size = new System.Drawing.Size(53, 22);
            this.txtKoltuk.TabIndex = 5;
            // 
            // radioBayan
            // 
            this.radioBayan.AutoSize = true;
            this.radioBayan.Location = new System.Drawing.Point(192, 145);
            this.radioBayan.Name = "radioBayan";
            this.radioBayan.Size = new System.Drawing.Size(69, 21);
            this.radioBayan.TabIndex = 4;
            this.radioBayan.TabStop = true;
            this.radioBayan.Text = "Bayan";
            this.radioBayan.UseVisualStyleBackColor = true;
            // 
            // radioBay
            // 
            this.radioBay.AutoSize = true;
            this.radioBay.Location = new System.Drawing.Point(101, 147);
            this.radioBay.Name = "radioBay";
            this.radioBay.Size = new System.Drawing.Size(53, 21);
            this.radioBay.TabIndex = 3;
            this.radioBay.TabStop = true;
            this.radioBay.Text = "Bay";
            this.radioBay.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Koltuk No : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cinsiyet : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tel No : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Soyadı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı :";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.Info;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(299, 243);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(290, 388);
            this.listBox1.TabIndex = 57;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 696);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.flwPanel);
            this.Controls.Add(this.grbKisisel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Travel Agent";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbKisisel.ResumeLayout(false);
            this.grbKisisel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoyad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAd.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flwPanel;
        private System.Windows.Forms.GroupBox grbKisisel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioBayan;
        private System.Windows.Forms.RadioButton radioBay;
        private System.Windows.Forms.TextBox txtKoltuk;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.TextEdit txtTelNo;
        private DevExpress.XtraEditors.TextEdit txtSoyad;
        private DevExpress.XtraEditors.TextEdit txtAd;
        private System.Windows.Forms.ListBox listBox1;
    }
}

