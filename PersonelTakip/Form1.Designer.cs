namespace PersonelTakip
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            lboxPersoneller = new ListBox();
            label2 = new Label();
            splitContainer1 = new SplitContainer();
            btnYeni = new Button();
            button1 = new Button();
            toolStrip1 = new ToolStrip();
            tsbKaydet = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            tsbSil = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            rdÖzel = new RadioButton();
            label8 = new Label();
            rdSgk = new RadioButton();
            chkPaz = new CheckBox();
            chkCmt = new CheckBox();
            chkCum = new CheckBox();
            chkPer = new CheckBox();
            chkCar = new CheckBox();
            chkSal = new CheckBox();
            label7 = new Label();
            chkPzt = new CheckBox();
            label6 = new Label();
            cboxPersonelTürü = new ComboBox();
            label5 = new Label();
            cboxCinsiyet = new ComboBox();
            txtCalistigiBirim = new TextBox();
            label4 = new Label();
            txtAdSoyad = new TextBox();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 125);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(94, 28);
            label1.Name = "label1";
            label1.Size = new Size(379, 60);
            label1.TabIndex = 1;
            label1.Text = "Personel Bilgileri";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = Properties.Resources.man;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(71, 125);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lboxPersoneller
            // 
            lboxPersoneller.Dock = DockStyle.Fill;
            lboxPersoneller.FormattingEnabled = true;
            lboxPersoneller.ItemHeight = 20;
            lboxPersoneller.Location = new Point(0, 20);
            lboxPersoneller.Name = "lboxPersoneller";
            lboxPersoneller.Size = new Size(266, 362);
            lboxPersoneller.TabIndex = 1;
            lboxPersoneller.SelectedIndexChanged += lboxPersoneller_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(121, 20);
            label2.TabIndex = 2;
            label2.Text = "Personel Listesi ";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 125);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(lboxPersoneller);
            splitContainer1.Panel1.Controls.Add(label2);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(btnYeni);
            splitContainer1.Panel2.Controls.Add(button1);
            splitContainer1.Panel2.Controls.Add(toolStrip1);
            splitContainer1.Panel2.Controls.Add(rdÖzel);
            splitContainer1.Panel2.Controls.Add(label8);
            splitContainer1.Panel2.Controls.Add(rdSgk);
            splitContainer1.Panel2.Controls.Add(chkPaz);
            splitContainer1.Panel2.Controls.Add(chkCmt);
            splitContainer1.Panel2.Controls.Add(chkCum);
            splitContainer1.Panel2.Controls.Add(chkPer);
            splitContainer1.Panel2.Controls.Add(chkCar);
            splitContainer1.Panel2.Controls.Add(chkSal);
            splitContainer1.Panel2.Controls.Add(label7);
            splitContainer1.Panel2.Controls.Add(chkPzt);
            splitContainer1.Panel2.Controls.Add(label6);
            splitContainer1.Panel2.Controls.Add(cboxPersonelTürü);
            splitContainer1.Panel2.Controls.Add(label5);
            splitContainer1.Panel2.Controls.Add(cboxCinsiyet);
            splitContainer1.Panel2.Controls.Add(txtCalistigiBirim);
            splitContainer1.Panel2.Controls.Add(label4);
            splitContainer1.Panel2.Controls.Add(txtAdSoyad);
            splitContainer1.Panel2.Controls.Add(label3);
            splitContainer1.Size = new Size(800, 382);
            splitContainer1.SplitterDistance = 266;
            splitContainer1.TabIndex = 3;
            // 
            // btnYeni
            // 
            btnYeni.Location = new Point(393, 20);
            btnYeni.Name = "btnYeni";
            btnYeni.Size = new Size(94, 29);
            btnYeni.TabIndex = 21;
            btnYeni.Text = "Yeni";
            btnYeni.UseVisualStyleBackColor = true;
            btnYeni.Click += btnYeni_Click;
            // 
            // button1
            // 
            button1.Location = new Point(332, 329);
            button1.Name = "button1";
            button1.Size = new Size(155, 48);
            button1.TabIndex = 20;
            button1.Text = "Ekle/Güncelle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbKaydet, toolStripSeparator1, tsbSil, toolStripSeparator2 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(530, 27);
            toolStrip1.TabIndex = 19;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsbKaydet
            // 
            tsbKaydet.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbKaydet.Image = Properties.Resources.diskette;
            tsbKaydet.ImageTransparentColor = Color.Magenta;
            tsbKaydet.Name = "tsbKaydet";
            tsbKaydet.Size = new Size(29, 24);
            tsbKaydet.Text = "toolStripButton3";
            tsbKaydet.Click += tsbKaydet_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 27);
            // 
            // tsbSil
            // 
            tsbSil.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbSil.Image = Properties.Resources.bin;
            tsbSil.ImageTransparentColor = Color.Magenta;
            tsbSil.Name = "tsbSil";
            tsbSil.Size = new Size(29, 24);
            tsbSil.Text = "toolStripButton4";
            tsbSil.Click += tsbSil_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 27);
            // 
            // rdÖzel
            // 
            rdÖzel.AutoSize = true;
            rdÖzel.Location = new Point(225, 346);
            rdÖzel.Name = "rdÖzel";
            rdÖzel.RightToLeft = RightToLeft.Yes;
            rdÖzel.Size = new Size(60, 24);
            rdÖzel.TabIndex = 18;
            rdÖzel.TabStop = true;
            rdÖzel.Text = "Özel";
            rdÖzel.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(33, 346);
            label8.Name = "label8";
            label8.Size = new Size(111, 20);
            label8.TabIndex = 17;
            label8.Text = "Sağlık Sigortası";
            // 
            // rdSgk
            // 
            rdSgk.AutoSize = true;
            rdSgk.Location = new Point(159, 346);
            rdSgk.Name = "rdSgk";
            rdSgk.Size = new Size(57, 24);
            rdSgk.TabIndex = 16;
            rdSgk.TabStop = true;
            rdSgk.Text = "SGK";
            rdSgk.UseVisualStyleBackColor = true;
            // 
            // chkPaz
            // 
            chkPaz.AutoSize = true;
            chkPaz.Location = new Point(408, 299);
            chkPaz.Name = "chkPaz";
            chkPaz.Size = new Size(57, 24);
            chkPaz.TabIndex = 15;
            chkPaz.Text = "PAZ";
            chkPaz.UseVisualStyleBackColor = true;
            // 
            // chkCmt
            // 
            chkCmt.AutoSize = true;
            chkCmt.Location = new Point(341, 299);
            chkCmt.Name = "chkCmt";
            chkCmt.Size = new Size(61, 24);
            chkCmt.TabIndex = 14;
            chkCmt.Text = "CMT";
            chkCmt.UseVisualStyleBackColor = true;
            // 
            // chkCum
            // 
            chkCum.AutoSize = true;
            chkCum.Location = new Point(279, 299);
            chkCum.Name = "chkCum";
            chkCum.Size = new Size(63, 24);
            chkCum.TabIndex = 13;
            chkCum.Text = "CUM";
            chkCum.UseVisualStyleBackColor = true;
            // 
            // chkPer
            // 
            chkPer.AutoSize = true;
            chkPer.Location = new Point(221, 299);
            chkPer.Name = "chkPer";
            chkPer.Size = new Size(56, 24);
            chkPer.TabIndex = 12;
            chkPer.Text = "PRŞ";
            chkPer.UseVisualStyleBackColor = true;
            // 
            // chkCar
            // 
            chkCar.AutoSize = true;
            chkCar.Location = new Point(159, 299);
            chkCar.Name = "chkCar";
            chkCar.Size = new Size(57, 24);
            chkCar.TabIndex = 11;
            chkCar.Text = "ÇRŞ";
            chkCar.UseVisualStyleBackColor = true;
            // 
            // chkSal
            // 
            chkSal.AutoSize = true;
            chkSal.Location = new Point(95, 299);
            chkSal.Name = "chkSal";
            chkSal.Size = new Size(56, 24);
            chkSal.TabIndex = 10;
            chkSal.Text = "SAL";
            chkSal.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(33, 266);
            label7.Name = "label7";
            label7.Size = new Size(112, 20);
            label7.TabIndex = 9;
            label7.Text = "Çalışma Günleri";
            // 
            // chkPzt
            // 
            chkPzt.AutoSize = true;
            chkPzt.Location = new Point(33, 299);
            chkPzt.Name = "chkPzt";
            chkPzt.Size = new Size(56, 24);
            chkPzt.TabIndex = 8;
            chkPzt.Text = "PZT";
            chkPzt.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(33, 234);
            label6.Name = "label6";
            label6.Size = new Size(97, 20);
            label6.TabIndex = 7;
            label6.Text = "Personel Türü";
            // 
            // cboxPersonelTürü
            // 
            cboxPersonelTürü.FormattingEnabled = true;
            cboxPersonelTürü.Items.AddRange(new object[] { "Yönetici", "Beyaz Yaka", "Gri Yaka", "Mavi Yaka" });
            cboxPersonelTürü.Location = new Point(159, 234);
            cboxPersonelTürü.Name = "cboxPersonelTürü";
            cboxPersonelTürü.Size = new Size(204, 28);
            cboxPersonelTürü.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 188);
            label5.Name = "label5";
            label5.Size = new Size(64, 20);
            label5.TabIndex = 5;
            label5.Text = "Cinsiyeti";
            // 
            // cboxCinsiyet
            // 
            cboxCinsiyet.FormattingEnabled = true;
            cboxCinsiyet.Items.AddRange(new object[] { "Erkek", "Kadın" });
            cboxCinsiyet.Location = new Point(159, 188);
            cboxCinsiyet.Name = "cboxCinsiyet";
            cboxCinsiyet.Size = new Size(204, 28);
            cboxCinsiyet.TabIndex = 4;
            // 
            // txtCalistigiBirim
            // 
            txtCalistigiBirim.Location = new Point(33, 143);
            txtCalistigiBirim.Name = "txtCalistigiBirim";
            txtCalistigiBirim.Size = new Size(339, 27);
            txtCalistigiBirim.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 120);
            label4.Name = "label4";
            label4.Size = new Size(101, 20);
            label4.TabIndex = 2;
            label4.Text = "Çalıştığı Birim";
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(33, 82);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(339, 27);
            txtAdSoyad.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 59);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 0;
            label3.Text = "Ad Soyad";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 507);
            Controls.Add(splitContainer1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private ListBox lboxPersoneller;
        private Label label2;
        private SplitContainer splitContainer1;
        private TextBox txtAdSoyad;
        private Label label3;
        private TextBox txtCalistigiBirim;
        private Label label4;
        private CheckBox chkPaz;
        private CheckBox chkCmt;
        private CheckBox chkCum;
        private CheckBox chkPer;
        private CheckBox chkCar;
        private CheckBox chkSal;
        private Label label7;
        private CheckBox chkPzt;
        private Label label6;
        private ComboBox cboxPersonelTürü;
        private Label label5;
        private ComboBox cboxCinsiyet;
        private RadioButton rdÖzel;
        private Label label8;
        private RadioButton rdSgk;
        private ToolStrip toolStrip1;
        private ToolStripButton tsbKaydet;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton tsbSil;
        private ToolStripSeparator toolStripSeparator2;
        private Button button1;
        private Button btnYeni;
    }
}