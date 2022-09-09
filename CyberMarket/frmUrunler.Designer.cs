
namespace CyberMarket
{
    partial class frmUrunler
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbxResim = new System.Windows.Forms.GroupBox();
            this.pbxUrunResmi = new RJCodeAdvance.RJControls.RJCircularPictureBox();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnSil = new CustomBox.RJControls.RJButton();
            this.btnGuncelle = new CustomBox.RJControls.RJButton();
            this.gbxDetay = new System.Windows.Forms.GroupBox();
            this.cmbUrunSinifi = new System.Windows.Forms.ComboBox();
            this.tbxUrunAdedi = new System.Windows.Forms.TextBox();
            this.tbxUrunFiyati = new System.Windows.Forms.TextBox();
            this.tbxUrunAdi = new System.Windows.Forms.TextBox();
            this.lblUrunSinifi = new System.Windows.Forms.Label();
            this.lblUrunAdi = new System.Windows.Forms.Label();
            this.lblUrunAdedi = new System.Windows.Forms.Label();
            this.lblUrunId = new System.Windows.Forms.Label();
            this.lblUrunFiyati = new System.Windows.Forms.Label();
            this.pnlBetween = new System.Windows.Forms.Panel();
            this.dgvUrunler = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrunAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrunFiyati = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrunAdedi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrunSınıfı = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrunResmi = new System.Windows.Forms.DataGridViewImageColumn();
            this.ofdUpdatePicture = new System.Windows.Forms.OpenFileDialog();
            this.lblUrunIdSonuc = new System.Windows.Forms.Label();
            this.gbxResim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUrunResmi)).BeginInit();
            this.pnlBottom.SuspendLayout();
            this.gbxDetay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunler)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxResim
            // 
            this.gbxResim.Controls.Add(this.pbxUrunResmi);
            this.gbxResim.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxResim.Location = new System.Drawing.Point(0, 0);
            this.gbxResim.Name = "gbxResim";
            this.gbxResim.Size = new System.Drawing.Size(318, 333);
            this.gbxResim.TabIndex = 1;
            this.gbxResim.TabStop = false;
            this.gbxResim.Text = "Ürün Resmi";
            // 
            // pbxUrunResmi
            // 
            this.pbxUrunResmi.BackColor = System.Drawing.Color.Silver;
            this.pbxUrunResmi.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.pbxUrunResmi.BorderColor = System.Drawing.Color.RoyalBlue;
            this.pbxUrunResmi.BorderColor2 = System.Drawing.Color.HotPink;
            this.pbxUrunResmi.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.pbxUrunResmi.BorderSize = 2;
            this.pbxUrunResmi.GradientAngle = 50F;
            this.pbxUrunResmi.Location = new System.Drawing.Point(12, 32);
            this.pbxUrunResmi.Name = "pbxUrunResmi";
            this.pbxUrunResmi.Size = new System.Drawing.Size(277, 277);
            this.pbxUrunResmi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxUrunResmi.TabIndex = 0;
            this.pbxUrunResmi.TabStop = false;
            this.pbxUrunResmi.Click += new System.EventHandler(this.pbxUrunResmi_Click);
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
            this.pnlBottom.TabIndex = 2;
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
            this.gbxDetay.Controls.Add(this.lblUrunIdSonuc);
            this.gbxDetay.Controls.Add(this.cmbUrunSinifi);
            this.gbxDetay.Controls.Add(this.tbxUrunAdedi);
            this.gbxDetay.Controls.Add(this.tbxUrunFiyati);
            this.gbxDetay.Controls.Add(this.tbxUrunAdi);
            this.gbxDetay.Controls.Add(this.lblUrunSinifi);
            this.gbxDetay.Controls.Add(this.lblUrunAdi);
            this.gbxDetay.Controls.Add(this.lblUrunAdedi);
            this.gbxDetay.Controls.Add(this.lblUrunId);
            this.gbxDetay.Controls.Add(this.lblUrunFiyati);
            this.gbxDetay.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxDetay.Location = new System.Drawing.Point(324, 0);
            this.gbxDetay.Name = "gbxDetay";
            this.gbxDetay.Size = new System.Drawing.Size(403, 275);
            this.gbxDetay.TabIndex = 5;
            this.gbxDetay.TabStop = false;
            this.gbxDetay.Text = "Ürün Detayı";
            // 
            // cmbUrunSinifi
            // 
            this.cmbUrunSinifi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUrunSinifi.FormattingEnabled = true;
            this.cmbUrunSinifi.Items.AddRange(new object[] {
            "Atıştırmalık",
            "Süt ve Süt Ürünleri",
            "Şarküteri",
            "Giyim",
            "Elektronik"});
            this.cmbUrunSinifi.Location = new System.Drawing.Point(129, 227);
            this.cmbUrunSinifi.Name = "cmbUrunSinifi";
            this.cmbUrunSinifi.Size = new System.Drawing.Size(264, 33);
            this.cmbUrunSinifi.TabIndex = 14;
            // 
            // tbxUrunAdedi
            // 
            this.tbxUrunAdedi.Location = new System.Drawing.Point(129, 176);
            this.tbxUrunAdedi.Name = "tbxUrunAdedi";
            this.tbxUrunAdedi.Size = new System.Drawing.Size(264, 33);
            this.tbxUrunAdedi.TabIndex = 13;
            // 
            // tbxUrunFiyati
            // 
            this.tbxUrunFiyati.Location = new System.Drawing.Point(129, 125);
            this.tbxUrunFiyati.Name = "tbxUrunFiyati";
            this.tbxUrunFiyati.Size = new System.Drawing.Size(264, 33);
            this.tbxUrunFiyati.TabIndex = 12;
            // 
            // tbxUrunAdi
            // 
            this.tbxUrunAdi.Location = new System.Drawing.Point(129, 74);
            this.tbxUrunAdi.Name = "tbxUrunAdi";
            this.tbxUrunAdi.Size = new System.Drawing.Size(264, 33);
            this.tbxUrunAdi.TabIndex = 11;
            // 
            // lblUrunSinifi
            // 
            this.lblUrunSinifi.AutoSize = true;
            this.lblUrunSinifi.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunSinifi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.lblUrunSinifi.Location = new System.Drawing.Point(6, 232);
            this.lblUrunSinifi.Name = "lblUrunSinifi";
            this.lblUrunSinifi.Size = new System.Drawing.Size(112, 23);
            this.lblUrunSinifi.TabIndex = 9;
            this.lblUrunSinifi.Text = "Ürün Sınıfı :";
            // 
            // lblUrunAdi
            // 
            this.lblUrunAdi.AutoSize = true;
            this.lblUrunAdi.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.lblUrunAdi.Location = new System.Drawing.Point(6, 79);
            this.lblUrunAdi.Name = "lblUrunAdi";
            this.lblUrunAdi.Size = new System.Drawing.Size(96, 23);
            this.lblUrunAdi.TabIndex = 6;
            this.lblUrunAdi.Text = "Ürün Adı :";
            // 
            // lblUrunAdedi
            // 
            this.lblUrunAdedi.AutoSize = true;
            this.lblUrunAdedi.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunAdedi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.lblUrunAdedi.Location = new System.Drawing.Point(6, 181);
            this.lblUrunAdedi.Name = "lblUrunAdedi";
            this.lblUrunAdedi.Size = new System.Drawing.Size(117, 23);
            this.lblUrunAdedi.TabIndex = 7;
            this.lblUrunAdedi.Text = "Ürün Adedi :";
            // 
            // lblUrunId
            // 
            this.lblUrunId.AutoSize = true;
            this.lblUrunId.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.lblUrunId.Location = new System.Drawing.Point(6, 28);
            this.lblUrunId.Name = "lblUrunId";
            this.lblUrunId.Size = new System.Drawing.Size(38, 23);
            this.lblUrunId.TabIndex = 5;
            this.lblUrunId.Text = "ID :";
            // 
            // lblUrunFiyati
            // 
            this.lblUrunFiyati.AutoSize = true;
            this.lblUrunFiyati.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunFiyati.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.lblUrunFiyati.Location = new System.Drawing.Point(6, 130);
            this.lblUrunFiyati.Name = "lblUrunFiyati";
            this.lblUrunFiyati.Size = new System.Drawing.Size(113, 23);
            this.lblUrunFiyati.TabIndex = 8;
            this.lblUrunFiyati.Text = "Ürün Fiyatı :";
            // 
            // pnlBetween
            // 
            this.pnlBetween.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(122)))), ((int)(((byte)(245)))));
            this.pnlBetween.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBetween.Location = new System.Drawing.Point(0, 314);
            this.pnlBetween.Name = "pnlBetween";
            this.pnlBetween.Size = new System.Drawing.Size(778, 20);
            this.pnlBetween.TabIndex = 3;
            // 
            // dgvUrunler
            // 
            this.dgvUrunler.AllowUserToAddRows = false;
            this.dgvUrunler.AllowUserToDeleteRows = false;
            this.dgvUrunler.AllowUserToResizeColumns = false;
            this.dgvUrunler.AllowUserToResizeRows = false;
            this.dgvUrunler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUrunler.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.dgvUrunler.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUrunler.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvUrunler.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(122)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Source Code Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUrunler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUrunler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.UrunAdi,
            this.UrunFiyati,
            this.UrunAdedi,
            this.UrunSınıfı,
            this.UrunResmi});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Roboto Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUrunler.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvUrunler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUrunler.EnableHeadersVisualStyles = false;
            this.dgvUrunler.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(132)))), ((int)(((byte)(203)))));
            this.dgvUrunler.Location = new System.Drawing.Point(0, 0);
            this.dgvUrunler.Name = "dgvUrunler";
            this.dgvUrunler.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvUrunler.RowHeadersVisible = false;
            this.dgvUrunler.RowTemplate.Height = 150;
            this.dgvUrunler.RowTemplate.ReadOnly = true;
            this.dgvUrunler.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUrunler.Size = new System.Drawing.Size(778, 314);
            this.dgvUrunler.TabIndex = 4;
            this.dgvUrunler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUrunler_CellClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "Id";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // UrunAdi
            // 
            this.UrunAdi.DataPropertyName = "UrunAdi";
            this.UrunAdi.HeaderText = "Ürün Adı";
            this.UrunAdi.Name = "UrunAdi";
            // 
            // UrunFiyati
            // 
            this.UrunFiyati.DataPropertyName = "UrunFiyati";
            this.UrunFiyati.HeaderText = "Ürün Fiyatı";
            this.UrunFiyati.Name = "UrunFiyati";
            // 
            // UrunAdedi
            // 
            this.UrunAdedi.DataPropertyName = "UrunAdedi";
            this.UrunAdedi.HeaderText = "Ürün Adedi";
            this.UrunAdedi.Name = "UrunAdedi";
            // 
            // UrunSınıfı
            // 
            this.UrunSınıfı.DataPropertyName = "UrunSinifi";
            this.UrunSınıfı.HeaderText = "Ürün Sınıfı";
            this.UrunSınıfı.Name = "UrunSınıfı";
            // 
            // UrunResmi
            // 
            this.UrunResmi.DataPropertyName = "UrunResmi";
            this.UrunResmi.HeaderText = "Ürün Resmi";
            this.UrunResmi.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.UrunResmi.Name = "UrunResmi";
            this.UrunResmi.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.UrunResmi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ofdUpdatePicture
            // 
            this.ofdUpdatePicture.Filter = "JPG Dosyaları|*.jpg| JPEG Dosyaları|*.jpeg| PNG Dosyaları|*.png";
            this.ofdUpdatePicture.FilterIndex = 2;
            // 
            // lblUrunIdSonuc
            // 
            this.lblUrunIdSonuc.AutoSize = true;
            this.lblUrunIdSonuc.Location = new System.Drawing.Point(124, 26);
            this.lblUrunIdSonuc.Name = "lblUrunIdSonuc";
            this.lblUrunIdSonuc.Size = new System.Drawing.Size(0, 25);
            this.lblUrunIdSonuc.TabIndex = 15;
            // 
            // frmUrunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 669);
            this.Controls.Add(this.dgvUrunler);
            this.Controls.Add(this.pnlBetween);
            this.Controls.Add(this.pnlBottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUrunler";
            this.Text = "frmUrunler";
            this.Load += new System.EventHandler(this.frmUrunler_Load);
            this.gbxResim.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxUrunResmi)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            this.gbxDetay.ResumeLayout(false);
            this.gbxDetay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbxResim;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.GroupBox gbxDetay;
        private RJCodeAdvance.RJControls.RJCircularPictureBox pbxUrunResmi;
        private System.Windows.Forms.Label lblUrunSinifi;
        private System.Windows.Forms.Label lblUrunAdi;
        private System.Windows.Forms.Label lblUrunAdedi;
        private System.Windows.Forms.Label lblUrunId;
        private System.Windows.Forms.Label lblUrunFiyati;
        private CustomBox.RJControls.RJButton btnGuncelle;
        private CustomBox.RJControls.RJButton btnSil;
        private System.Windows.Forms.Panel pnlBetween;
        private System.Windows.Forms.ComboBox cmbUrunSinifi;
        private System.Windows.Forms.TextBox tbxUrunAdedi;
        private System.Windows.Forms.TextBox tbxUrunFiyati;
        private System.Windows.Forms.TextBox tbxUrunAdi;
        private System.Windows.Forms.DataGridView dgvUrunler;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunFiyati;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunAdedi;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunSınıfı;
        private System.Windows.Forms.DataGridViewImageColumn UrunResmi;
        private System.Windows.Forms.OpenFileDialog ofdUpdatePicture;
        private System.Windows.Forms.Label lblUrunIdSonuc;
    }
}