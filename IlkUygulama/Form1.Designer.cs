namespace IlkUygulama
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
            btnTikla = new Button();
            txtAdSoyad = new TextBox();
            SuspendLayout();
            // 
            // btnTikla
            // 
            btnTikla.Location = new Point(81, 92);
            btnTikla.Name = "btnTikla";
            btnTikla.Size = new Size(94, 29);
            btnTikla.TabIndex = 0;
            btnTikla.Text = "Bana Tıkla";
            btnTikla.UseVisualStyleBackColor = true;
            btnTikla.MouseClick += btnTikla_Click;
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.BackColor = SystemColors.Info;
            txtAdSoyad.Location = new Point(81, 59);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(94, 27);
            txtAdSoyad.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(265, 227);
            Controls.Add(txtAdSoyad);
            Controls.Add(btnTikla);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTikla;
        private TextBox txtAdSoyad;
    }
}