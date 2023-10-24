namespace Constructer
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxAd = new TextBox();
            textBoxAdres = new TextBox();
            textBoxYas = new TextBox();
            comboBoxStatu = new ComboBox();
            label4 = new Label();
            textBoxMesai = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(103, 263);
            button1.Name = "button1";
            button1.Size = new Size(125, 52);
            button1.TabIndex = 0;
            button1.Text = "Personel Oluştur";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 40);
            label1.Name = "label1";
            label1.Size = new Size(28, 20);
            label1.TabIndex = 1;
            label1.Text = "Ad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 103);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 2;
            label2.Text = "Adres";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 187);
            label3.Name = "label3";
            label3.Size = new Size(30, 20);
            label3.TabIndex = 3;
            label3.Text = "Yaş";
            // 
            // textBoxAd
            // 
            textBoxAd.Location = new Point(103, 40);
            textBoxAd.Name = "textBoxAd";
            textBoxAd.Size = new Size(125, 27);
            textBoxAd.TabIndex = 4;
            // 
            // textBoxAdres
            // 
            textBoxAdres.Location = new Point(103, 103);
            textBoxAdres.Multiline = true;
            textBoxAdres.Name = "textBoxAdres";
            textBoxAdres.Size = new Size(125, 43);
            textBoxAdres.TabIndex = 5;
            // 
            // textBoxYas
            // 
            textBoxYas.Location = new Point(103, 187);
            textBoxYas.Name = "textBoxYas";
            textBoxYas.Size = new Size(125, 27);
            textBoxYas.TabIndex = 6;
            // 
            // comboBoxStatu
            // 
            comboBoxStatu.FormattingEnabled = true;
            comboBoxStatu.Location = new Point(443, 187);
            comboBoxStatu.Name = "comboBoxStatu";
            comboBoxStatu.Size = new Size(151, 28);
            comboBoxStatu.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(331, 100);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 8;
            label4.Text = "Mesai Saati";
            // 
            // textBoxMesai
            // 
            textBoxMesai.Location = new Point(431, 97);
            textBoxMesai.Name = "textBoxMesai";
            textBoxMesai.Size = new Size(125, 27);
            textBoxMesai.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxMesai);
            Controls.Add(label4);
            Controls.Add(comboBoxStatu);
            Controls.Add(textBoxYas);
            Controls.Add(textBoxAdres);
            Controls.Add(textBoxAd);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Maaş";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxAd;
        private TextBox textBoxAdres;
        private TextBox textBoxYas;
        private ComboBox comboBoxStatu;
        private Label label4;
        private TextBox textBoxMesai;
    }
}