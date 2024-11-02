namespace VücudEndeksi
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
            lblBoy = new Label();
            lblKilo = new Label();
            button1 = new Button();
            txtBoy = new TextBox();
            txtKilo = new TextBox();
            lblBoyCins = new Label();
            lblKiloCins = new Label();
            lblSonuc = new Label();
            lblDurum = new Label();
            SuspendLayout();
            // 
            // lblBoy
            // 
            lblBoy.AutoSize = true;
            lblBoy.Location = new Point(49, 49);
            lblBoy.Name = "lblBoy";
            lblBoy.Size = new Size(65, 20);
            lblBoy.TabIndex = 0;
            lblBoy.Text = "Boyunuz";
            // 
            // lblKilo
            // 
            lblKilo.AutoSize = true;
            lblKilo.Location = new Point(49, 87);
            lblKilo.Name = "lblKilo";
            lblKilo.Size = new Size(58, 20);
            lblKilo.TabIndex = 1;
            lblKilo.Text = "Kilonuz";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Info;
            button1.Location = new Point(139, 140);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Hesapla";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtBoy
            // 
            txtBoy.Location = new Point(128, 46);
            txtBoy.Name = "txtBoy";
            txtBoy.Size = new Size(125, 27);
            txtBoy.TabIndex = 3;
            // 
            // txtKilo
            // 
            txtKilo.Location = new Point(128, 84);
            txtKilo.Name = "txtKilo";
            txtKilo.Size = new Size(125, 27);
            txtKilo.TabIndex = 4;
            // 
            // lblBoyCins
            // 
            lblBoyCins.AutoSize = true;
            lblBoyCins.Location = new Point(259, 49);
            lblBoyCins.Name = "lblBoyCins";
            lblBoyCins.Size = new Size(29, 20);
            lblBoyCins.TabIndex = 5;
            lblBoyCins.Text = "cm";
            // 
            // lblKiloCins
            // 
            lblKiloCins.AutoSize = true;
            lblKiloCins.Location = new Point(259, 87);
            lblKiloCins.Name = "lblKiloCins";
            lblKiloCins.Size = new Size(25, 20);
            lblKiloCins.TabIndex = 6;
            lblKiloCins.Text = "kg";
            // 
            // lblSonuc
            // 
            lblSonuc.AutoSize = true;
            lblSonuc.Location = new Point(139, 204);
            lblSonuc.Name = "lblSonuc";
            lblSonuc.Size = new Size(85, 20);
            lblSonuc.TabIndex = 7;
            lblSonuc.Text = "VKI DEĞERİ";
            // 
            // lblDurum
            // 
            lblDurum.AutoSize = true;
            lblDurum.Location = new Point(144, 251);
            lblDurum.Name = "lblDurum";
            lblDurum.Size = new Size(98, 20);
            lblDurum.TabIndex = 8;
            lblDurum.Text = "VKİ DURUMU";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(lblDurum);
            Controls.Add(lblSonuc);
            Controls.Add(lblKiloCins);
            Controls.Add(lblBoyCins);
            Controls.Add(txtKilo);
            Controls.Add(txtBoy);
            Controls.Add(button1);
            Controls.Add(lblKilo);
            Controls.Add(lblBoy);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBoy;
        private Label lblKilo;
        private Button button1;
        private TextBox txtBoy;
        private TextBox txtKilo;
        private Label lblBoyCins;
        private Label lblKiloCins;
        private Label lblSonuc;
        private Label lblDurum;
    }
}