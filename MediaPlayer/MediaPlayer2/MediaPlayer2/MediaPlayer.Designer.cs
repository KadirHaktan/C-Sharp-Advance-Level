namespace MediaPlayer2
{
    partial class MediaPlayer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MediaPlayer));
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cal = new System.Windows.Forms.Button();
            this.dur = new System.Windows.Forms.Button();
            this.ileri = new System.Windows.Forms.Button();
            this.geri = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.ac = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.liste_kaydet = new System.Windows.Forms.Button();
            this.liste_ac = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(-3, -4);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(265, 229);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Parça Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Parça Süresi";
            // 
            // cal
            // 
            this.cal.Location = new System.Drawing.Point(242, 234);
            this.cal.Name = "cal";
            this.cal.Size = new System.Drawing.Size(75, 23);
            this.cal.TabIndex = 4;
            this.cal.Text = "Çal";
            this.cal.UseVisualStyleBackColor = true;
            this.cal.Click += new System.EventHandler(this.cal_Click);
            // 
            // dur
            // 
            this.dur.Location = new System.Drawing.Point(323, 234);
            this.dur.Name = "dur";
            this.dur.Size = new System.Drawing.Size(75, 23);
            this.dur.TabIndex = 5;
            this.dur.Text = "Dur";
            this.dur.UseVisualStyleBackColor = true;
            this.dur.Click += new System.EventHandler(this.dur_Click);
            // 
            // ileri
            // 
            this.ileri.Location = new System.Drawing.Point(323, 268);
            this.ileri.Name = "ileri";
            this.ileri.Size = new System.Drawing.Size(75, 23);
            this.ileri.TabIndex = 6;
            this.ileri.Text = "İleri";
            this.ileri.UseVisualStyleBackColor = true;
            this.ileri.Click += new System.EventHandler(this.ileri_Click);
            // 
            // geri
            // 
            this.geri.Location = new System.Drawing.Point(242, 267);
            this.geri.Name = "geri";
            this.geri.Size = new System.Drawing.Size(75, 23);
            this.geri.TabIndex = 7;
            this.geri.Text = "Geri";
            this.geri.UseVisualStyleBackColor = true;
            this.geri.Click += new System.EventHandler(this.geri_Click);
            // 
            // listBox1
            // 
            this.listBox1.AllowDrop = true;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(262, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(267, 225);
            this.listBox1.TabIndex = 8;
            this.listBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDoubleClick);
            this.listBox1.DragOver += new System.Windows.Forms.DragEventHandler(this.listBox1_DragOver);
            this.listBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox1_DragDrop);
            // 
            // ac
            // 
            this.ac.Location = new System.Drawing.Point(161, 267);
            this.ac.Name = "ac";
            this.ac.Size = new System.Drawing.Size(75, 23);
            this.ac.TabIndex = 9;
            this.ac.Text = "Dosya Aç";
            this.ac.UseVisualStyleBackColor = true;
            this.ac.Click += new System.EventHandler(this.ac_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(262, 221);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(267, 4);
            this.listBox2.TabIndex = 11;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Geçen Süre";
            // 
            // liste_kaydet
            // 
            this.liste_kaydet.Location = new System.Drawing.Point(404, 268);
            this.liste_kaydet.Name = "liste_kaydet";
            this.liste_kaydet.Size = new System.Drawing.Size(112, 23);
            this.liste_kaydet.TabIndex = 14;
            this.liste_kaydet.Text = "Parça Listesi Kaydet";
            this.liste_kaydet.UseVisualStyleBackColor = true;
            this.liste_kaydet.Click += new System.EventHandler(this.liste_kaydet_Click);
            // 
            // liste_ac
            // 
            this.liste_ac.Location = new System.Drawing.Point(404, 234);
            this.liste_ac.Name = "liste_ac";
            this.liste_ac.Size = new System.Drawing.Size(112, 23);
            this.liste_ac.TabIndex = 15;
            this.liste_ac.Text = "Parça Listesi Aç";
            this.liste_ac.UseVisualStyleBackColor = true;
            this.liste_ac.Click += new System.EventHandler(this.liste_ac_Click);
            // 
            // MediaPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 301);
            this.Controls.Add(this.liste_ac);
            this.Controls.Add(this.liste_kaydet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.ac);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.geri);
            this.Controls.Add(this.ileri);
            this.Controls.Add(this.dur);
            this.Controls.Add(this.cal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Name = "MediaPlayer";
            this.Text = "Media Player";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cal;
        private System.Windows.Forms.Button dur;
        private System.Windows.Forms.Button ileri;
        private System.Windows.Forms.Button geri;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button ac;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button liste_kaydet;
        private System.Windows.Forms.Button liste_ac;
    }
}

