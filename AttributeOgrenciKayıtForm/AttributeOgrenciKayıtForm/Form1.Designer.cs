namespace AttributeOgrenciKayıtForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtAdi = new TextBox();
            txtSoyadi = new TextBox();
            txtBolumu = new TextBox();
            Dogrula = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(266, 141);
            label1.Name = "label1";
            label1.Size = new Size(48, 25);
            label1.TabIndex = 0;
            label1.Text = "Adı :";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(239, 194);
            label2.Name = "label2";
            label2.Size = new Size(75, 25);
            label2.TabIndex = 1;
            label2.Text = "Soyadı :";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(232, 242);
            label3.Name = "label3";
            label3.Size = new Size(82, 25);
            label3.TabIndex = 2;
            label3.Text = "Bölümü :";
            label3.Click += label3_Click;
            // 
            // txtAdi
            // 
            txtAdi.Location = new Point(357, 135);
            txtAdi.Name = "txtAdi";
            txtAdi.Size = new Size(150, 31);
            txtAdi.TabIndex = 3;
            txtAdi.TextChanged += textBox1_TextChanged;
            // 
            // txtSoyadi
            // 
            txtSoyadi.Location = new Point(357, 188);
            txtSoyadi.Name = "txtSoyadi";
            txtSoyadi.Size = new Size(150, 31);
            txtSoyadi.TabIndex = 4;
            // 
            // txtBolumu
            // 
            txtBolumu.Location = new Point(357, 236);
            txtBolumu.Name = "txtBolumu";
            txtBolumu.Size = new Size(150, 31);
            txtBolumu.TabIndex = 5;
            // 
            // Dogrula
            // 
            Dogrula.Location = new Point(395, 301);
            Dogrula.Name = "Dogrula";
            Dogrula.Size = new Size(112, 34);
            Dogrula.TabIndex = 6;
            Dogrula.Text = "Kayıt Ol";
            Dogrula.UseVisualStyleBackColor = true;
            Dogrula.Click += dogrula_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(283, 75);
            label4.Name = "label4";
            label4.Size = new Size(204, 25);
            label4.TabIndex = 7;
            label4.Text = "ÖĞRENCİ KAYIT FORMU";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(Dogrula);
            Controls.Add(txtBolumu);
            Controls.Add(txtSoyadi);
            Controls.Add(txtAdi);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtAdi;
        private TextBox txtSoyadi;
        private TextBox txtBolumu;
        private Button Dogrula;
        private Label label4;
    }
}
