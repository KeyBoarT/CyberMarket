
namespace CyberMarket
{
    partial class frmCalisanlar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnSil = new CustomBox.RJControls.RJButton();
            this.btnGuncelle = new CustomBox.RJControls.RJButton();
            this.gbxDetay = new System.Windows.Forms.GroupBox();
            this.lblCalisanIdSonuc = new System.Windows.Forms.Label();
            this.cmbDurum = new System.Windows.Forms.ComboBox();
            this.tbxPozisyon = new System.Windows.Forms.TextBox();
            this.tbxSoyad = new System.Windows.Forms.TextBox();
            this.tbxAd = new System.Windows.Forms.TextBox();
            this.lblUrunSinifi = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblPozisyon = new System.Windows.Forms.Label();
            this.lblCalisanId = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.gbxResim = new System.Windows.Forms.GroupBox();
            this.pbxResim = new RJCodeAdvance.RJControls.RJCircularPictureBox();
            this.pnlBetween = new System.Windows.Forms.Panel();
            this.dgvCalisanlar = new System.Windows.Forms.DataGridView();
            this.ofdUpdatePicture = new System.Windows.Forms.OpenFileDialog();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CalisanAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrunFiyati = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pozisyon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Durum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Resim = new System.Windows.Forms.DataGridViewImageColumn();
            this.pnlBottom.SuspendLayout();
            this.gbxDetay.SuspendLayout();
            this.gbxResim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxResim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalisanlar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.btnSil);
            this.pnlBottom.Controls.Add(this.btnGuncelle);
            this.pnlBottom.Controls.Add(this.gbxDetay);
            this.pnlBottom.Controls.Add(this.gbxResim);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 334);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(778, 335);
            this.pnlBottom.TabIndex = 3;
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.btnSil.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.btnSil.BorderColor = System.Drawing.Color.Red;
            this.btnSil.BorderRadius = 20;
            this.btnSil.BorderSize = 0;
            this.btnSil.FlatAppearance.BorderSize = 0;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnSil.ForeColor = System.Drawing.Color.White;
            this.btnSil.Location = new System.Drawing.Point(525, 283);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(195, 40);
            this.btnSil.TabIndex = 7;
            this.btnSil.Text = "Sil";
            this.btnSil.TextColor = System.Drawing.Color.White;
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.btnGuncelle.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.btnGuncelle.BorderColor = System.Drawing.Color.Red;
            this.btnGuncelle.BorderRadius = 20;
            this.btnGuncelle.BorderSize = 0;
            this.btnGuncelle.FlatAppearance.BorderSize = 0;
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuncelle.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnGuncelle.ForeColor = System.Drawing.Color.White;
            this.btnGuncelle.Location = new System.Drawing.Point(324, 283);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(195, 40);
            this.btnGuncelle.TabIndex = 6;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.TextColor = System.Drawing.Color.White;
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // gbxDetay
            // 
            this.gbxDetay.Controls.Add(this.lblCalisanIdSonuc);
            this.gbxDetay.Controls.Add(this.cmbDurum);
            this.gbxDetay.Controls.Add(this.tbxPozisyon);
            this.gbxDetay.Controls.Add(this.tbxSoyad);
            this.gbxDetay.Controls.Add(this.tbxAd);
            this.gbxDetay.Controls.Add(this.lblUrunSinifi);
            this.gbxDetay.Controls.Add(this.lblAd);
            this.gbxDetay.Controls.Add(this.lblPozisyon);
            this.gbxDetay.Controls.Add(this.lblCalisanId);
            this.gbxDetay.Controls.Add(this.lblSoyad);
            this.gbxDetay.Font = new System.Drawing.Font("Roboto Mono", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxDetay.Location = new System.Drawing.Point(324, 0);
            this.gbxDetay.Name = "gbxDetay";
            this.gbxDetay.Size = new System.Drawing.Size(403, 275);
            this.gbxDetay.TabIndex = 5;
            this.gbxDetay.TabStop = false;
            this.gbxDetay.Text = "Bilgiler";
            // 
            // lblCalisanIdSonuc
            // 
            this.lblCalisanIdSonuc.AutoSize = true;
            this.lblCalisanIdSonuc.Location = new System.Drawing.Point(124, 26);
            this.lblCalisanIdSonuc.Name = "lblCalisanIdSonuc";
            this.lblCalisanIdSonuc.Size = new System.Drawing.Size(0, 28);
            this.lblCalisanIdSonuc.TabIndex = 15;
            // 
            // cmbDurum
            // 
            this.cmbDurum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDurum.FormattingEnabled = true;
            this.cmbDurum.Items.AddRange(new object[] {
            "Tüm Çalışan",
            "Güncel Çalışan",
            "İzinli Çalışan",
            "Eski Çalışan"});
            this.cmbDurum.Location = new System.Drawing.Point(129, 227);
            this.cmbDurum.Name = "cmbDurum";
            this.cmbDurum.Size = new System.Drawing.Size(264, 36);
            this.cmbDurum.TabIndex = 14;
            // 
            // tbxPozisyon
            // 
            this.tbxPozisyon.Location = new System.Drawing.Point(129, 176);
            this.tbxPozisyon.Name = "tbxPozisyon";
            this.tbxPozisyon.Size = new System.Drawing.Size(264, 35);
            this.tbxPozisyon.TabIndex = 13;
            // 
            // tbxSoyad
            // 
            this.tbxSoyad.Location = new System.Drawing.Point(129, 125);
            this.tbxSoyad.Name = "tbxSoyad";
            this.tbxSoyad.Size = new System.Drawing.Size(264, 35);
            this.tbxSoyad.TabIndex = 12;
            // 
            // tbxAd
            // 
            this.tbxAd.Location = new System.Drawing.Point(129, 74);
            this.tbxAd.Name = "tbxAd";
            this.tbxAd.Size = new System.Drawing.Size(264, 35);
            this.tbxAd.TabIndex = 11;
            // 
            // lblUrunSinifi
            // 
            this.lblUrunSinifi.AutoSize = true;
            this.lblUrunSinifi.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunSinifi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.lblUrunSinifi.Location = new System.Drawing.Point(6, 232);
            this.lblUrunSinifi.Name = "lblUrunSinifi";
            this.lblUrunSinifi.Size = new System.Drawing.Size(77, 23);
            this.lblUrunSinifi.TabIndex = 9;
            this.lblUrunSinifi.Text = "Durum :";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.lblAd.Location = new System.Drawing.Point(6, 79);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(49, 23);
            this.lblAd.TabIndex = 6;
            this.lblAd.Text = "Adı :";
            // 
            // lblPozisyon
            // 
            this.lblPozisyon.AutoSize = true;
            this.lblPozisyon.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPozisyon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.lblPozisyon.Location = new System.Drawing.Point(6, 181);
            this.lblPozisyon.Name = "lblPozisyon";
            this.lblPozisyon.Size = new System.Drawing.Size(100, 23);
            this.lblPozisyon.TabIndex = 7;
            this.lblPozisyon.Text = "Pozisyon :";
            // 
            // lblCalisanId
            // 
            this.lblCalisanId.AutoSize = true;
            this.lblCalisanId.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCalisanId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.lblCalisanId.Location = new System.Drawing.Point(6, 28);
            this.lblCalisanId.Name = "lblCalisanId";
            this.lblCalisanId.Size = new System.Drawing.Size(38, 23);
            this.lblCalisanId.TabIndex = 5;
            this.lblCalisanId.Text = "ID :";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoyad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.lblSoyad.Location = new System.Drawing.Point(6, 130);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(113, 23);
            this.lblSoyad.TabIndex = 8;
            this.lblSoyad.Text = "Ürün Fiyatı :";
            // 
            // gbxResim
            // 
            this.gbxResim.Controls.Add(this.pbxResim);
            this.gbxResim.Font = new System.Drawing.Font("Roboto Mono", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxResim.Location = new System.Drawing.Point(0, 0);
            this.gbxResim.Name = "gbxResim";
            this.gbxResim.Size = new System.Drawing.Size(318, 333);
            this.gbxResim.TabIndex = 1;
            this.gbxResim.TabStop = false;
            this.gbxResim.Text = "Resim";
            // 
            // pbxResim
            // 
            this.pbxResim.BackColor = System.Drawing.Color.Silver;
            this.pbxResim.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.pbxResim.BorderColor = System.Drawing.Color.RoyalBlue;
            this.pbxResim.BorderColor2 = System.Drawing.Color.HotPink;
            this.pbxResim.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.pbxResim.BorderSize = 2;
            this.pbxResim.GradientAngle = 50F;
            this.pbxResim.Location = new System.Drawing.Point(12, 32);
            this.pbxResim.Name = "pbxResim";
            this.pbxResim.Size = new System.Drawing.Size(277, 277);
            this.pbxResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxResim.TabIndex = 0;
            this.pbxResim.TabStop = false;
            this.pbxResim.Click += new System.EventHandler(this.pbxResim_Click);
            // 
            // pnlBetween
            // 
            this.pnlBetween.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(122)))), ((int)(((byte)(245)))));
            this.pnlBetween.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBetween.Location = new System.Drawing.Point(0, 314);
            this.pnlBetween.Name = "pnlBetween";
            this.pnlBetween.Size = new System.Drawing.Size(778, 20);
            this.pnlBetween.TabIndex = 4;
            // 
            // dgvCalisanlar
            // 
            this.dgvCalisanlar.AllowUserToAddRows = false;
            this.dgvCalisanlar.AllowUserToDeleteRows = false;
            this.dgvCalisanlar.AllowUserToResizeColumns = false;
            this.dgvCalisanlar.AllowUserToResizeRows = false;
            this.dgvCalisanlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCalisanlar.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.dgvCalisanlar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCalisanlar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvCalisanlar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(122)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Source Code Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCalisanlar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCalisanlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCalisanlar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.CalisanAdi,
            this.UrunFiyati,
            this.Pozisyon,
            this.Durum,
            this.Resim});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCalisanlar.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCalisanlar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCalisanlar.EnableHeadersVisualStyles = false;
            this.dgvCalisanlar.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(132)))), ((int)(((byte)(203)))));
            this.dgvCalisanlar.Location = new System.Drawing.Point(0, 0);
            this.dgvCalisanlar.Name = "dgvCalisanlar";
            this.dgvCalisanlar.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCalisanlar.RowHeadersVisible = false;
            this.dgvCalisanlar.RowTemplate.Height = 150;
            this.dgvCalisanlar.RowTemplate.ReadOnly = true;
            this.dgvCalisanlar.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCalisanlar.Size = new System.Drawing.Size(778, 314);
            this.dgvCalisanlar.TabIndex = 5;
            this.dgvCalisanlar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCalisanlar_CellClick);
            // 
            // ofdUpdatePicture
            // 
            this.ofdUpdatePicture.Filter = "JPG Dosyaları|*.jpg| JPEG Dosyaları|*.jpeg| PNG Dosyaları|*.png";
            this.ofdUpdatePicture.FilterIndex = 2;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "Id";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // CalisanAdi
            // 
            this.CalisanAdi.DataPropertyName = "Ad";
            this.CalisanAdi.HeaderText = "Ad";
            this.CalisanAdi.Name = "CalisanAdi";
            // 
            // UrunFiyati
            // 
            this.UrunFiyati.DataPropertyName = "Soyad";
            this.UrunFiyati.HeaderText = "Soyad";
            this.UrunFiyati.Name = "UrunFiyati";
            // 
            // Pozisyon
            // 
            this.Pozisyon.DataPropertyName = "Pozisyon";
            this.Pozisyon.HeaderText = "Pozisyon";
            this.Pozisyon.Name = "Pozisyon";
            // 
            // Durum
            // 
            this.Durum.DataPropertyName = "Durum";
            this.Durum.HeaderText = "Durum";
            this.Durum.Name = "Durum";
            // 
            // Resim
            // 
            this.Resim.DataPropertyName = "Resim";
            this.Resim.HeaderText = "Resim";
            this.Resim.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Resim.Name = "Resim";
            this.Resim.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Resim.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // frmCalisanlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 669);
            this.Controls.Add(this.dgvCalisanlar);
            this.Controls.Add(this.pnlBetween);
            this.Controls.Add(this.pnlBottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCalisanlar";
            this.Text = "frmCalisanlar";
            this.Load += new System.EventHandler(this.frmCalisanlar_Load);
            this.pnlBottom.ResumeLayout(false);
            this.gbxDetay.ResumeLayout(false);
            this.gbxDetay.PerformLayout();
            this.gbxResim.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxResim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalisanlar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBottom;
        private CustomBox.RJControls.RJButton btnSil;
        private CustomBox.RJControls.RJButton btnGuncelle;
        private System.Windows.Forms.GroupBox gbxDetay;
        private System.Windows.Forms.Label lblCalisanIdSonuc;
        private System.Windows.Forms.ComboBox cmbDurum;
        private System.Windows.Forms.TextBox tbxPozisyon;
        private System.Windows.Forms.TextBox tbxSoyad;
        private System.Windows.Forms.TextBox tbxAd;
        private System.Windows.Forms.Label lblUrunSinifi;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblPozisyon;
        private System.Windows.Forms.Label lblCalisanId;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.GroupBox gbxResim;
        private RJCodeAdvance.RJControls.RJCircularPictureBox pbxResim;
        private System.Windows.Forms.Panel pnlBetween;
        private System.Windows.Forms.DataGridView dgvCalisanlar;
        private System.Windows.Forms.OpenFileDialog ofdUpdatePicture;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CalisanAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunFiyati;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pozisyon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Durum;
        private System.Windows.Forms.DataGridViewImageColumn Resim;
    }
}