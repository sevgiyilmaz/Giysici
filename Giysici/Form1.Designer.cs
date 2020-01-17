namespace Giysici
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnSiparisiOnayla = new System.Windows.Forms.Button();
            this.btnSepeteEkle = new System.Windows.Forms.Button();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.nudAdet = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkPembe = new System.Windows.Forms.CheckBox();
            this.chkSiyah = new System.Windows.Forms.CheckBox();
            this.chkMor = new System.Windows.Forms.CheckBox();
            this.chkMavi = new System.Windows.Forms.CheckBox();
            this.chkYesil = new System.Windows.Forms.CheckBox();
            this.chkKirmizi = new System.Windows.Forms.CheckBox();
            this.chkBeyaz = new System.Windows.Forms.CheckBox();
            this.chkSari = new System.Windows.Forms.CheckBox();
            this.rbKislik = new System.Windows.Forms.RadioButton();
            this.rbYazlik = new System.Windows.Forms.RadioButton();
            this.cmbTur = new System.Windows.Forms.ComboBox();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            this.lblTutar = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbMarka = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbBeden = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(7, 215);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(978, 264);
            this.listBox1.TabIndex = 41;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnSiparisiOnayla
            // 
            this.btnSiparisiOnayla.BackColor = System.Drawing.Color.Teal;
            this.btnSiparisiOnayla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSiparisiOnayla.Location = new System.Drawing.Point(551, 143);
            this.btnSiparisiOnayla.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSiparisiOnayla.Name = "btnSiparisiOnayla";
            this.btnSiparisiOnayla.Size = new System.Drawing.Size(168, 52);
            this.btnSiparisiOnayla.TabIndex = 40;
            this.btnSiparisiOnayla.Text = "Siparişi Onayla";
            this.btnSiparisiOnayla.UseVisualStyleBackColor = false;
            this.btnSiparisiOnayla.Click += new System.EventHandler(this.btnSiparisiOnayla_Click);
            // 
            // btnSepeteEkle
            // 
            this.btnSepeteEkle.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSepeteEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSepeteEkle.Location = new System.Drawing.Point(555, 79);
            this.btnSepeteEkle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSepeteEkle.Name = "btnSepeteEkle";
            this.btnSepeteEkle.Size = new System.Drawing.Size(430, 39);
            this.btnSepeteEkle.TabIndex = 39;
            this.btnSepeteEkle.Text = "Sepete Ekle";
            this.btnSepeteEkle.UseVisualStyleBackColor = false;
            this.btnSepeteEkle.Click += new System.EventHandler(this.btnSepeteEkle_Click);
            // 
            // btnHesapla
            // 
            this.btnHesapla.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnHesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapla.Location = new System.Drawing.Point(674, 22);
            this.btnHesapla.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(149, 43);
            this.btnHesapla.TabIndex = 38;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = false;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // nudAdet
            // 
            this.nudAdet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudAdet.Location = new System.Drawing.Point(605, 31);
            this.nudAdet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudAdet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAdet.Name = "nudAdet";
            this.nudAdet.Size = new System.Drawing.Size(48, 26);
            this.nudAdet.TabIndex = 37;
            this.nudAdet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkPembe);
            this.groupBox1.Controls.Add(this.chkSiyah);
            this.groupBox1.Controls.Add(this.chkMor);
            this.groupBox1.Controls.Add(this.chkMavi);
            this.groupBox1.Controls.Add(this.chkYesil);
            this.groupBox1.Controls.Add(this.chkKirmizi);
            this.groupBox1.Controls.Add(this.chkBeyaz);
            this.groupBox1.Controls.Add(this.chkSari);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(334, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(209, 201);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Renkler";
            // 
            // chkPembe
            // 
            this.chkPembe.AutoSize = true;
            this.chkPembe.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.chkPembe.Location = new System.Drawing.Point(116, 168);
            this.chkPembe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkPembe.Name = "chkPembe";
            this.chkPembe.Size = new System.Drawing.Size(78, 24);
            this.chkPembe.TabIndex = 0;
            this.chkPembe.Text = "Pembe";
            this.chkPembe.UseVisualStyleBackColor = true;
            // 
            // chkSiyah
            // 
            this.chkSiyah.AutoSize = true;
            this.chkSiyah.Location = new System.Drawing.Point(116, 75);
            this.chkSiyah.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkSiyah.Name = "chkSiyah";
            this.chkSiyah.Size = new System.Drawing.Size(67, 24);
            this.chkSiyah.TabIndex = 0;
            this.chkSiyah.Text = "Siyah";
            this.chkSiyah.UseVisualStyleBackColor = true;
            // 
            // chkMor
            // 
            this.chkMor.AutoSize = true;
            this.chkMor.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.chkMor.Location = new System.Drawing.Point(15, 168);
            this.chkMor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkMor.Name = "chkMor";
            this.chkMor.Size = new System.Drawing.Size(55, 24);
            this.chkMor.TabIndex = 0;
            this.chkMor.Text = "Mor";
            this.chkMor.UseVisualStyleBackColor = true;
            // 
            // chkMavi
            // 
            this.chkMavi.AutoSize = true;
            this.chkMavi.ForeColor = System.Drawing.SystemColors.Highlight;
            this.chkMavi.Location = new System.Drawing.Point(15, 75);
            this.chkMavi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkMavi.Name = "chkMavi";
            this.chkMavi.Size = new System.Drawing.Size(60, 24);
            this.chkMavi.TabIndex = 0;
            this.chkMavi.Text = "Mavi";
            this.chkMavi.UseVisualStyleBackColor = true;
            // 
            // chkYesil
            // 
            this.chkYesil.AutoSize = true;
            this.chkYesil.ForeColor = System.Drawing.Color.ForestGreen;
            this.chkYesil.Location = new System.Drawing.Point(116, 122);
            this.chkYesil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkYesil.Name = "chkYesil";
            this.chkYesil.Size = new System.Drawing.Size(62, 24);
            this.chkYesil.TabIndex = 0;
            this.chkYesil.Text = "Yeşil";
            this.chkYesil.UseVisualStyleBackColor = true;
            // 
            // chkKirmizi
            // 
            this.chkKirmizi.AutoSize = true;
            this.chkKirmizi.ForeColor = System.Drawing.Color.Red;
            this.chkKirmizi.Location = new System.Drawing.Point(116, 29);
            this.chkKirmizi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkKirmizi.Name = "chkKirmizi";
            this.chkKirmizi.Size = new System.Drawing.Size(73, 24);
            this.chkKirmizi.TabIndex = 0;
            this.chkKirmizi.Text = "Kırmızı";
            this.chkKirmizi.UseVisualStyleBackColor = true;
            // 
            // chkBeyaz
            // 
            this.chkBeyaz.AutoSize = true;
            this.chkBeyaz.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.chkBeyaz.Location = new System.Drawing.Point(15, 122);
            this.chkBeyaz.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkBeyaz.Name = "chkBeyaz";
            this.chkBeyaz.Size = new System.Drawing.Size(72, 24);
            this.chkBeyaz.TabIndex = 0;
            this.chkBeyaz.Text = "Beyaz";
            this.chkBeyaz.UseVisualStyleBackColor = true;
            // 
            // chkSari
            // 
            this.chkSari.AutoSize = true;
            this.chkSari.ForeColor = System.Drawing.Color.LemonChiffon;
            this.chkSari.Location = new System.Drawing.Point(15, 29);
            this.chkSari.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkSari.Name = "chkSari";
            this.chkSari.Size = new System.Drawing.Size(56, 24);
            this.chkSari.TabIndex = 0;
            this.chkSari.Text = "Sarı";
            this.chkSari.UseVisualStyleBackColor = true;
            // 
            // rbKislik
            // 
            this.rbKislik.AutoSize = true;
            this.rbKislik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbKislik.Location = new System.Drawing.Point(264, 171);
            this.rbKislik.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbKislik.Name = "rbKislik";
            this.rbKislik.Size = new System.Drawing.Size(62, 24);
            this.rbKislik.TabIndex = 34;
            this.rbKislik.TabStop = true;
            this.rbKislik.Text = "Kışlık";
            this.rbKislik.UseVisualStyleBackColor = true;
            // 
            // rbYazlik
            // 
            this.rbYazlik.AutoSize = true;
            this.rbYazlik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbYazlik.Location = new System.Drawing.Point(149, 171);
            this.rbYazlik.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbYazlik.Name = "rbYazlik";
            this.rbYazlik.Size = new System.Drawing.Size(69, 24);
            this.rbYazlik.TabIndex = 35;
            this.rbYazlik.TabStop = true;
            this.rbYazlik.Text = "Yazlık";
            this.rbYazlik.UseVisualStyleBackColor = true;
            // 
            // cmbTur
            // 
            this.cmbTur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbTur.FormattingEnabled = true;
            this.cmbTur.Location = new System.Drawing.Point(75, 109);
            this.cmbTur.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbTur.Name = "cmbTur";
            this.cmbTur.Size = new System.Drawing.Size(250, 28);
            this.cmbTur.TabIndex = 33;
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.AutoSize = true;
            this.lblToplamTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamTutar.Location = new System.Drawing.Point(791, 156);
            this.lblToplamTutar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(190, 20);
            this.lblToplamTutar.TabIndex = 30;
            this.lblToplamTutar.Text = "Toplam Tutar : _______ ₺";
            // 
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTutar.Location = new System.Drawing.Point(851, 37);
            this.lblTutar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(134, 20);
            this.lblTutar.TabIndex = 29;
            this.lblTutar.Text = "Tutar : _______ ₺";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(551, 33);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "Adet :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(3, 112);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Tür :";
            // 
            // cmbMarka
            // 
            this.cmbMarka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbMarka.FormattingEnabled = true;
            this.cmbMarka.Location = new System.Drawing.Point(75, 57);
            this.cmbMarka.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbMarka.Name = "cmbMarka";
            this.cmbMarka.Size = new System.Drawing.Size(250, 28);
            this.cmbMarka.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(3, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Marka :";
            // 
            // cmbBeden
            // 
            this.cmbBeden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBeden.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbBeden.FormattingEnabled = true;
            this.cmbBeden.Location = new System.Drawing.Point(75, 4);
            this.cmbBeden.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbBeden.Name = "cmbBeden";
            this.cmbBeden.Size = new System.Drawing.Size(250, 28);
            this.cmbBeden.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Beden :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(990, 483);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnSiparisiOnayla);
            this.Controls.Add(this.btnSepeteEkle);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.nudAdet);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rbKislik);
            this.Controls.Add(this.rbYazlik);
            this.Controls.Add(this.cmbTur);
            this.Controls.Add(this.lblToplamTutar);
            this.Controls.Add(this.lblTutar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbMarka);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbBeden);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnSiparisiOnayla;
        private System.Windows.Forms.Button btnSepeteEkle;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.NumericUpDown nudAdet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkPembe;
        private System.Windows.Forms.CheckBox chkSiyah;
        private System.Windows.Forms.CheckBox chkMor;
        private System.Windows.Forms.CheckBox chkMavi;
        private System.Windows.Forms.CheckBox chkYesil;
        private System.Windows.Forms.CheckBox chkKirmizi;
        private System.Windows.Forms.CheckBox chkBeyaz;
        private System.Windows.Forms.CheckBox chkSari;
        private System.Windows.Forms.RadioButton rbKislik;
        private System.Windows.Forms.RadioButton rbYazlik;
        private System.Windows.Forms.ComboBox cmbTur;
        private System.Windows.Forms.Label lblToplamTutar;
        private System.Windows.Forms.Label lblTutar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbMarka;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbBeden;
        private System.Windows.Forms.Label label1;
    }
}

