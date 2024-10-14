namespace Amp12A_603_StokTakipProgramı
{
    partial class ProjeAnasayfası
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuTedarikci = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUrun = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSatis = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMusteri = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPersonel = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grdUrunListesi = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mskTxtMusteriTelefon = new System.Windows.Forms.MaskedTextBox();
            this.txtMusteriAdSoyad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNot = new System.Windows.Forms.RichTextBox();
            this.txtGenelToplam = new System.Windows.Forms.TextBox();
            this.grdSatilacakUrunler = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnMusteriSec = new System.Windows.Forms.Button();
            this.btnSatisYap = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdUrunListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSatilacakUrunler)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuTedarikci,
            this.menuUrun,
            this.menuSatis,
            this.menuMusteri,
            this.menuPersonel});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1065, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuTedarikci
            // 
            this.menuTedarikci.Name = "menuTedarikci";
            this.menuTedarikci.Size = new System.Drawing.Size(112, 20);
            this.menuTedarikci.Text = "Tedarikçi İşlemleri";
            // 
            // menuUrun
            // 
            this.menuUrun.Name = "menuUrun";
            this.menuUrun.Size = new System.Drawing.Size(92, 20);
            this.menuUrun.Text = "Ürün İşlemleri";
            // 
            // menuSatis
            // 
            this.menuSatis.Name = "menuSatis";
            this.menuSatis.Size = new System.Drawing.Size(96, 20);
            this.menuSatis.Text = "Sattış Detayları";
            // 
            // menuMusteri
            // 
            this.menuMusteri.Name = "menuMusteri";
            this.menuMusteri.Size = new System.Drawing.Size(106, 20);
            this.menuMusteri.Text = "Müşteri İşlemleri";
            // 
            // menuPersonel
            // 
            this.menuPersonel.Name = "menuPersonel";
            this.menuPersonel.Size = new System.Drawing.Size(111, 20);
            this.menuPersonel.Text = "Personel İşlemleri";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdUrunListesi);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(430, 456);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün listesi";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnMusteriSec);
            this.groupBox2.Controls.Add(this.grdSatilacakUrunler);
            this.groupBox2.Controls.Add(this.txtGenelToplam);
            this.groupBox2.Controls.Add(this.txtNot);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnSatisYap);
            this.groupBox2.Controls.Add(this.btnSil);
            this.groupBox2.Controls.Add(this.btnEkle);
            this.groupBox2.Controls.Add(this.txtMusteriAdSoyad);
            this.groupBox2.Controls.Add(this.mskTxtMusteriTelefon);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(460, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(593, 456);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Satış işlemi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(840, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Personel adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(961, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "yetki";
            // 
            // grdUrunListesi
            // 
            this.grdUrunListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdUrunListesi.Location = new System.Drawing.Point(7, 20);
            this.grdUrunListesi.MultiSelect = false;
            this.grdUrunListesi.Name = "grdUrunListesi";
            this.grdUrunListesi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdUrunListesi.Size = new System.Drawing.Size(417, 379);
            this.grdUrunListesi.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(153, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Müşteri telefon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(153, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "müşteri";
            // 
            // mskTxtMusteriTelefon
            // 
            this.mskTxtMusteriTelefon.Location = new System.Drawing.Point(248, 33);
            this.mskTxtMusteriTelefon.Mask = "(999) 000-0000";
            this.mskTxtMusteriTelefon.Name = "mskTxtMusteriTelefon";
            this.mskTxtMusteriTelefon.Size = new System.Drawing.Size(100, 20);
            this.mskTxtMusteriTelefon.TabIndex = 2;
            // 
            // txtMusteriAdSoyad
            // 
            this.txtMusteriAdSoyad.Enabled = false;
            this.txtMusteriAdSoyad.Location = new System.Drawing.Point(236, 60);
            this.txtMusteriAdSoyad.Name = "txtMusteriAdSoyad";
            this.txtMusteriAdSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtMusteriAdSoyad.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(219, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Satışı yapılacak ürünler";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(181, 356);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Not ekle";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(321, 416);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "genel toplam";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(500, 414);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "₺";
            // 
            // txtNot
            // 
            this.txtNot.Location = new System.Drawing.Point(250, 334);
            this.txtNot.Name = "txtNot";
            this.txtNot.Size = new System.Drawing.Size(195, 48);
            this.txtNot.TabIndex = 11;
            this.txtNot.Text = "";
            // 
            // txtGenelToplam
            // 
            this.txtGenelToplam.Enabled = false;
            this.txtGenelToplam.Location = new System.Drawing.Point(394, 411);
            this.txtGenelToplam.Name = "txtGenelToplam";
            this.txtGenelToplam.Size = new System.Drawing.Size(100, 20);
            this.txtGenelToplam.TabIndex = 12;
            // 
            // grdSatilacakUrunler
            // 
            this.grdSatilacakUrunler.AllowUserToAddRows = false;
            this.grdSatilacakUrunler.AllowUserToDeleteRows = false;
            this.grdSatilacakUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSatilacakUrunler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.grdSatilacakUrunler.Location = new System.Drawing.Point(123, 140);
            this.grdSatilacakUrunler.Name = "grdSatilacakUrunler";
            this.grdSatilacakUrunler.Size = new System.Drawing.Size(464, 150);
            this.grdSatilacakUrunler.TabIndex = 13;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Kod";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Ürün adı";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Miktar";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Birim fiyat";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Toplam";
            this.Column5.Name = "Column5";
            // 
            // btnMusteriSec
            // 
            this.btnMusteriSec.Image = global::Amp12A_603_StokTakipProgramı.Properties.Resources.people1;
            this.btnMusteriSec.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMusteriSec.Location = new System.Drawing.Point(354, 25);
            this.btnMusteriSec.Name = "btnMusteriSec";
            this.btnMusteriSec.Size = new System.Drawing.Size(71, 35);
            this.btnMusteriSec.TabIndex = 14;
            this.btnMusteriSec.Text = "Seç";
            this.btnMusteriSec.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMusteriSec.UseVisualStyleBackColor = true;
            // 
            // btnSatisYap
            // 
            this.btnSatisYap.Image = global::Amp12A_603_StokTakipProgramı.Properties.Resources.coupon;
            this.btnSatisYap.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSatisYap.Location = new System.Drawing.Point(155, 398);
            this.btnSatisYap.Name = "btnSatisYap";
            this.btnSatisYap.Size = new System.Drawing.Size(98, 38);
            this.btnSatisYap.TabIndex = 6;
            this.btnSatisYap.Text = "Satış yap";
            this.btnSatisYap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSatisYap.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            this.btnSil.Image = global::Amp12A_603_StokTakipProgramı.Properties.Resources.back;
            this.btnSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSil.Location = new System.Drawing.Point(6, 192);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(90, 34);
            this.btnSil.TabIndex = 5;
            this.btnSil.Text = "Sil";
            this.btnSil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // btnEkle
            // 
            this.btnEkle.Image = global::Amp12A_603_StokTakipProgramı.Properties.Resources.right;
            this.btnEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEkle.Location = new System.Drawing.Point(6, 140);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(90, 34);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEkle.UseVisualStyleBackColor = true;
            // 
            // ProjeAnasayfası
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 493);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ProjeAnasayfası";
            this.Text = "Proje Anasayfası";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdUrunListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSatilacakUrunler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuTedarikci;
        private System.Windows.Forms.ToolStripMenuItem menuUrun;
        private System.Windows.Forms.ToolStripMenuItem menuSatis;
        private System.Windows.Forms.ToolStripMenuItem menuMusteri;
        private System.Windows.Forms.ToolStripMenuItem menuPersonel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView grdUrunListesi;
        private System.Windows.Forms.Button btnSatisYap;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtMusteriAdSoyad;
        private System.Windows.Forms.MaskedTextBox mskTxtMusteriTelefon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView grdSatilacakUrunler;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.TextBox txtGenelToplam;
        private System.Windows.Forms.RichTextBox txtNot;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnMusteriSec;
    }
}