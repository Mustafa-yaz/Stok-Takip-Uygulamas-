namespace Amp12A_603_StokTakipProgramı
{
    partial class SatışDetayları
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grdSatislar = new System.Windows.Forms.DataGridView();
            this.grdSatilanUrunler = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSatisIptal = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSatisToplam = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSatislar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSatilanUrunler)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdSatislar);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(869, 383);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bilgi girişi";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSatisToplam);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnSatisIptal);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.grdSatilanUrunler);
            this.groupBox2.Location = new System.Drawing.Point(403, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(446, 372);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Satış detayları";
            // 
            // grdSatislar
            // 
            this.grdSatislar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSatislar.Location = new System.Drawing.Point(6, 19);
            this.grdSatislar.MultiSelect = false;
            this.grdSatislar.Name = "grdSatislar";
            this.grdSatislar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdSatislar.Size = new System.Drawing.Size(391, 358);
            this.grdSatislar.TabIndex = 2;
            // 
            // grdSatilanUrunler
            // 
            this.grdSatilanUrunler.BackgroundColor = System.Drawing.SystemColors.Info;
            this.grdSatilanUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSatilanUrunler.Location = new System.Drawing.Point(26, 116);
            this.grdSatilanUrunler.Name = "grdSatilanUrunler";
            this.grdSatilanUrunler.Size = new System.Drawing.Size(379, 117);
            this.grdSatilanUrunler.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(124, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Satılan ürünler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(158, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Satış toplam fiyat";
            // 
            // btnSatisIptal
            // 
            this.btnSatisIptal.Image = global::Amp12A_603_StokTakipProgramı.Properties.Resources.delete;
            this.btnSatisIptal.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSatisIptal.Location = new System.Drawing.Point(39, 312);
            this.btnSatisIptal.Name = "btnSatisIptal";
            this.btnSatisIptal.Size = new System.Drawing.Size(107, 44);
            this.btnSatisIptal.TabIndex = 3;
            this.btnSatisIptal.Text = "Satış iptal et";
            this.btnSatisIptal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSatisIptal.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(367, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "₺";
            // 
            // txtSatisToplam
            // 
            this.txtSatisToplam.Enabled = false;
            this.txtSatisToplam.Location = new System.Drawing.Point(261, 283);
            this.txtSatisToplam.Name = "txtSatisToplam";
            this.txtSatisToplam.Size = new System.Drawing.Size(100, 20);
            this.txtSatisToplam.TabIndex = 5;
            // 
            // SatışDetayları
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "SatışDetayları";
            this.Text = "Satış Detayları";
            this.Load += new System.EventHandler(this.SatışDetayları_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSatislar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSatilanUrunler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView grdSatislar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView grdSatilanUrunler;
        private System.Windows.Forms.TextBox txtSatisToplam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSatisIptal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}