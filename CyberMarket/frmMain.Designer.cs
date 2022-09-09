
namespace CyberMarket
{
    partial class frmMain
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.btnAyarlar = new FontAwesome.Sharp.IconButton();
            this.btnUrunBilgileri = new FontAwesome.Sharp.IconButton();
            this.btnCalisanBilgileri = new FontAwesome.Sharp.IconButton();
            this.btnHome = new FontAwesome.Sharp.IconButton();
            this.pnlPictureBox = new System.Windows.Forms.Panel();
            this.btnMenu = new FontAwesome.Sharp.IconButton();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.lblDashBoard = new System.Windows.Forms.Label();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.btnMaximize = new FontAwesome.Sharp.IconButton();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.pnlFill = new System.Windows.Forms.Panel();
            this.pnlAddCalisan = new System.Windows.Forms.Panel();
            this.btnCalisanEkle = new CustomBox.RJControls.RJButton();
            this.gbxBilgiler = new System.Windows.Forms.GroupBox();
            this.tbxPozisyon = new System.Windows.Forms.TextBox();
            this.tbxSoyad = new System.Windows.Forms.TextBox();
            this.tbxAd = new System.Windows.Forms.TextBox();
            this.lblAd = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gbxCalisanResim = new System.Windows.Forms.GroupBox();
            this.pbxCalisanResmi = new RJCodeAdvance.RJControls.RJCircularPictureBox();
            this.btnAddCalisanClose = new FontAwesome.Sharp.IconButton();
            this.pnlAddProduct = new System.Windows.Forms.Panel();
            this.btnUrunEkle = new CustomBox.RJControls.RJButton();
            this.gbxDetay = new System.Windows.Forms.GroupBox();
            this.cmbUrunSinifi = new System.Windows.Forms.ComboBox();
            this.tbxUrunAdedi = new System.Windows.Forms.TextBox();
            this.tbxUrunFiyati = new System.Windows.Forms.TextBox();
            this.tbxUrunAdi = new System.Windows.Forms.TextBox();
            this.lblUrunSinifi = new System.Windows.Forms.Label();
            this.lblUrunAdi = new System.Windows.Forms.Label();
            this.lblUrunAdedi = new System.Windows.Forms.Label();
            this.lblUrunFiyati = new System.Windows.Forms.Label();
            this.gbxUrunResim = new System.Windows.Forms.GroupBox();
            this.pbxUrunResmi = new RJCodeAdvance.RJControls.RJCircularPictureBox();
            this.btnAddPanelClose = new FontAwesome.Sharp.IconButton();
            this.ddmCalisanlar = new RJCodeAdvance.RJControls.RJDropdownMenu(this.components);
            this.mevcutÇalışanlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tümÇalışanlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.güncelÇalışanlarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.izinliÇalışanlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eskiÇalışanlarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.çalışanEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ddmUrunler = new RJCodeAdvance.RJControls.RJDropdownMenu(this.components);
            this.ürünlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tümÜrünlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atıştırmalıkToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sütVeSütÜrünleriToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.şarküteriToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.giyimToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.elektronikToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünlerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ofdAddUrunPicture = new System.Windows.Forms.OpenFileDialog();
            this.ofdAddCalisanPicture = new System.Windows.Forms.OpenFileDialog();
            this.pnlMenu.SuspendLayout();
            this.pnlPictureBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.pnlTitleBar.SuspendLayout();
            this.pnlFill.SuspendLayout();
            this.pnlAddCalisan.SuspendLayout();
            this.gbxBilgiler.SuspendLayout();
            this.gbxCalisanResim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCalisanResmi)).BeginInit();
            this.pnlAddProduct.SuspendLayout();
            this.gbxDetay.SuspendLayout();
            this.gbxUrunResim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUrunResmi)).BeginInit();
            this.ddmCalisanlar.SuspendLayout();
            this.ddmUrunler.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(122)))), ((int)(((byte)(245)))));
            this.pnlMenu.Controls.Add(this.btnExit);
            this.pnlMenu.Controls.Add(this.btnAyarlar);
            this.pnlMenu.Controls.Add(this.btnUrunBilgileri);
            this.pnlMenu.Controls.Add(this.btnCalisanBilgileri);
            this.pnlMenu.Controls.Add(this.btnHome);
            this.pnlMenu.Controls.Add(this.pnlPictureBox);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(230, 729);
            this.pnlMenu.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.SignOut;
            this.btnExit.IconColor = System.Drawing.Color.White;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 30;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(0, 683);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.btnExit.Size = new System.Drawing.Size(230, 46);
            this.btnExit.TabIndex = 6;
            this.btnExit.Tag = "Çıkış";
            this.btnExit.Text = "   Çıkış";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAyarlar
            // 
            this.btnAyarlar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(122)))), ((int)(((byte)(245)))));
            this.btnAyarlar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAyarlar.FlatAppearance.BorderSize = 0;
            this.btnAyarlar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAyarlar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAyarlar.ForeColor = System.Drawing.Color.White;
            this.btnAyarlar.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.btnAyarlar.IconColor = System.Drawing.Color.White;
            this.btnAyarlar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAyarlar.IconSize = 30;
            this.btnAyarlar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAyarlar.Location = new System.Drawing.Point(0, 252);
            this.btnAyarlar.Name = "btnAyarlar";
            this.btnAyarlar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAyarlar.Size = new System.Drawing.Size(230, 46);
            this.btnAyarlar.TabIndex = 5;
            this.btnAyarlar.Tag = "Ayarlar";
            this.btnAyarlar.Text = "   Ayarlar";
            this.btnAyarlar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAyarlar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAyarlar.UseVisualStyleBackColor = false;
            // 
            // btnUrunBilgileri
            // 
            this.btnUrunBilgileri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(122)))), ((int)(((byte)(245)))));
            this.btnUrunBilgileri.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUrunBilgileri.FlatAppearance.BorderSize = 0;
            this.btnUrunBilgileri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUrunBilgileri.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunBilgileri.ForeColor = System.Drawing.Color.White;
            this.btnUrunBilgileri.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.btnUrunBilgileri.IconColor = System.Drawing.Color.White;
            this.btnUrunBilgileri.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUrunBilgileri.IconSize = 30;
            this.btnUrunBilgileri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUrunBilgileri.Location = new System.Drawing.Point(0, 206);
            this.btnUrunBilgileri.Name = "btnUrunBilgileri";
            this.btnUrunBilgileri.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnUrunBilgileri.Size = new System.Drawing.Size(230, 46);
            this.btnUrunBilgileri.TabIndex = 3;
            this.btnUrunBilgileri.Tag = "Ürünler";
            this.btnUrunBilgileri.Text = "   Ürünler";
            this.btnUrunBilgileri.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUrunBilgileri.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUrunBilgileri.UseVisualStyleBackColor = false;
            this.btnUrunBilgileri.Click += new System.EventHandler(this.btnUrunBilgileri_Click);
            // 
            // btnCalisanBilgileri
            // 
            this.btnCalisanBilgileri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(122)))), ((int)(((byte)(245)))));
            this.btnCalisanBilgileri.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCalisanBilgileri.FlatAppearance.BorderSize = 0;
            this.btnCalisanBilgileri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalisanBilgileri.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCalisanBilgileri.ForeColor = System.Drawing.Color.White;
            this.btnCalisanBilgileri.IconChar = FontAwesome.Sharp.IconChar.UserTag;
            this.btnCalisanBilgileri.IconColor = System.Drawing.Color.White;
            this.btnCalisanBilgileri.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCalisanBilgileri.IconSize = 30;
            this.btnCalisanBilgileri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalisanBilgileri.Location = new System.Drawing.Point(0, 160);
            this.btnCalisanBilgileri.Name = "btnCalisanBilgileri";
            this.btnCalisanBilgileri.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCalisanBilgileri.Size = new System.Drawing.Size(230, 46);
            this.btnCalisanBilgileri.TabIndex = 2;
            this.btnCalisanBilgileri.Tag = "Çalışanlar";
            this.btnCalisanBilgileri.Text = "   Çalışanlar";
            this.btnCalisanBilgileri.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalisanBilgileri.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCalisanBilgileri.UseVisualStyleBackColor = false;
            this.btnCalisanBilgileri.Click += new System.EventHandler(this.btnCalisanBilgileri_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(122)))), ((int)(((byte)(245)))));
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btnHome.IconColor = System.Drawing.Color.White;
            this.btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHome.IconSize = 30;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 114);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(230, 46);
            this.btnHome.TabIndex = 1;
            this.btnHome.Tag = "Ana Sayfa";
            this.btnHome.Text = "   Ana Sayfa";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pnlPictureBox
            // 
            this.pnlPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(122)))), ((int)(((byte)(245)))));
            this.pnlPictureBox.Controls.Add(this.btnMenu);
            this.pnlPictureBox.Controls.Add(this.pbxLogo);
            this.pnlPictureBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPictureBox.Location = new System.Drawing.Point(0, 0);
            this.pnlPictureBox.Name = "pnlPictureBox";
            this.pnlPictureBox.Size = new System.Drawing.Size(230, 114);
            this.pnlPictureBox.TabIndex = 0;
            // 
            // btnMenu
            // 
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.IconChar = FontAwesome.Sharp.IconChar.Navicon;
            this.btnMenu.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.btnMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMenu.IconSize = 30;
            this.btnMenu.Location = new System.Drawing.Point(170, 0);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(60, 60);
            this.btnMenu.TabIndex = 1;
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // pbxLogo
            // 
            this.pbxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbxLogo.Image")));
            this.pbxLogo.Location = new System.Drawing.Point(0, 0);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(164, 87);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxLogo.TabIndex = 0;
            this.pbxLogo.TabStop = false;
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.BackColor = System.Drawing.Color.White;
            this.pnlTitleBar.Controls.Add(this.lblDashBoard);
            this.pnlTitleBar.Controls.Add(this.btnMinimize);
            this.pnlTitleBar.Controls.Add(this.btnMaximize);
            this.pnlTitleBar.Controls.Add(this.btnClose);
            this.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleBar.Location = new System.Drawing.Point(230, 0);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(778, 60);
            this.pnlTitleBar.TabIndex = 1;
            this.pnlTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitleBar_MouseDown);
            // 
            // lblDashBoard
            // 
            this.lblDashBoard.AutoSize = true;
            this.lblDashBoard.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDashBoard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.lblDashBoard.Location = new System.Drawing.Point(6, 9);
            this.lblDashBoard.Name = "lblDashBoard";
            this.lblDashBoard.Size = new System.Drawing.Size(207, 45);
            this.lblDashBoard.TabIndex = 5;
            this.lblDashBoard.Text = "Ana Sayfa";
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(184)))), ((int)(((byte)(217)))));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btnMinimize.IconColor = System.Drawing.Color.White;
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimize.IconSize = 20;
            this.btnMinimize.Location = new System.Drawing.Point(649, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(45, 25);
            this.btnMinimize.TabIndex = 4;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.IconChar = FontAwesome.Sharp.IconChar.ExpandAlt;
            this.btnMaximize.IconColor = System.Drawing.Color.White;
            this.btnMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximize.IconSize = 20;
            this.btnMaximize.Location = new System.Drawing.Point(691, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(45, 25);
            this.btnMaximize.TabIndex = 3;
            this.btnMaximize.UseVisualStyleBackColor = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(95)))), ((int)(((byte)(132)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.Navicon;
            this.btnClose.IconColor = System.Drawing.Color.White;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 20;
            this.btnClose.Location = new System.Drawing.Point(733, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(45, 25);
            this.btnClose.TabIndex = 2;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlFill
            // 
            this.pnlFill.BackColor = System.Drawing.Color.White;
            this.pnlFill.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlFill.BackgroundImage")));
            this.pnlFill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlFill.Controls.Add(this.pnlAddCalisan);
            this.pnlFill.Controls.Add(this.pnlAddProduct);
            this.pnlFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFill.Location = new System.Drawing.Point(230, 60);
            this.pnlFill.Name = "pnlFill";
            this.pnlFill.Size = new System.Drawing.Size(778, 669);
            this.pnlFill.TabIndex = 2;
            // 
            // pnlAddCalisan
            // 
            this.pnlAddCalisan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(122)))), ((int)(((byte)(245)))));
            this.pnlAddCalisan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlAddCalisan.Controls.Add(this.btnCalisanEkle);
            this.pnlAddCalisan.Controls.Add(this.gbxBilgiler);
            this.pnlAddCalisan.Controls.Add(this.gbxCalisanResim);
            this.pnlAddCalisan.Controls.Add(this.btnAddCalisanClose);
            this.pnlAddCalisan.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pnlAddCalisan.Location = new System.Drawing.Point(14, 6);
            this.pnlAddCalisan.Name = "pnlAddCalisan";
            this.pnlAddCalisan.Size = new System.Drawing.Size(450, 663);
            this.pnlAddCalisan.TabIndex = 2;
            this.pnlAddCalisan.Visible = false;
            // 
            // btnCalisanEkle
            // 
            this.btnCalisanEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.btnCalisanEkle.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.btnCalisanEkle.BorderColor = System.Drawing.Color.Red;
            this.btnCalisanEkle.BorderRadius = 20;
            this.btnCalisanEkle.BorderSize = 0;
            this.btnCalisanEkle.FlatAppearance.BorderSize = 0;
            this.btnCalisanEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalisanEkle.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnCalisanEkle.ForeColor = System.Drawing.Color.White;
            this.btnCalisanEkle.Location = new System.Drawing.Point(12, 586);
            this.btnCalisanEkle.Name = "btnCalisanEkle";
            this.btnCalisanEkle.Size = new System.Drawing.Size(423, 63);
            this.btnCalisanEkle.TabIndex = 7;
            this.btnCalisanEkle.Text = "Çalışanı Kaydet";
            this.btnCalisanEkle.TextColor = System.Drawing.Color.White;
            this.btnCalisanEkle.UseVisualStyleBackColor = false;
            this.btnCalisanEkle.Click += new System.EventHandler(this.btnCalisanEkle_Click);
            // 
            // gbxBilgiler
            // 
            this.gbxBilgiler.Controls.Add(this.tbxPozisyon);
            this.gbxBilgiler.Controls.Add(this.tbxSoyad);
            this.gbxBilgiler.Controls.Add(this.tbxAd);
            this.gbxBilgiler.Controls.Add(this.lblAd);
            this.gbxBilgiler.Controls.Add(this.label3);
            this.gbxBilgiler.Controls.Add(this.label4);
            this.gbxBilgiler.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxBilgiler.Location = new System.Drawing.Point(3, 305);
            this.gbxBilgiler.Name = "gbxBilgiler";
            this.gbxBilgiler.Size = new System.Drawing.Size(440, 275);
            this.gbxBilgiler.TabIndex = 6;
            this.gbxBilgiler.TabStop = false;
            this.gbxBilgiler.Text = "Bilgiler";
            // 
            // tbxPozisyon
            // 
            this.tbxPozisyon.Font = new System.Drawing.Font("Roboto Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxPozisyon.Location = new System.Drawing.Point(128, 223);
            this.tbxPozisyon.Name = "tbxPozisyon";
            this.tbxPozisyon.Size = new System.Drawing.Size(304, 33);
            this.tbxPozisyon.TabIndex = 13;
            // 
            // tbxSoyad
            // 
            this.tbxSoyad.Font = new System.Drawing.Font("Roboto Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxSoyad.Location = new System.Drawing.Point(128, 131);
            this.tbxSoyad.Name = "tbxSoyad";
            this.tbxSoyad.Size = new System.Drawing.Size(304, 33);
            this.tbxSoyad.TabIndex = 12;
            // 
            // tbxAd
            // 
            this.tbxAd.Font = new System.Drawing.Font("Roboto Mono Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxAd.Location = new System.Drawing.Point(128, 37);
            this.tbxAd.Name = "tbxAd";
            this.tbxAd.Size = new System.Drawing.Size(304, 35);
            this.tbxAd.TabIndex = 11;
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.lblAd.Location = new System.Drawing.Point(6, 44);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(44, 23);
            this.lblAd.TabIndex = 6;
            this.lblAd.Text = "Ad :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.label3.Location = new System.Drawing.Point(6, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Pozisyon :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.label4.Location = new System.Drawing.Point(6, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Soyad :";
            // 
            // gbxCalisanResim
            // 
            this.gbxCalisanResim.Controls.Add(this.pbxCalisanResmi);
            this.gbxCalisanResim.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxCalisanResim.Location = new System.Drawing.Point(3, 44);
            this.gbxCalisanResim.Name = "gbxCalisanResim";
            this.gbxCalisanResim.Size = new System.Drawing.Size(440, 255);
            this.gbxCalisanResim.TabIndex = 2;
            this.gbxCalisanResim.TabStop = false;
            this.gbxCalisanResim.Text = "Resim";
            // 
            // pbxCalisanResmi
            // 
            this.pbxCalisanResmi.BackColor = System.Drawing.Color.Silver;
            this.pbxCalisanResmi.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.pbxCalisanResmi.BorderColor = System.Drawing.Color.RoyalBlue;
            this.pbxCalisanResmi.BorderColor2 = System.Drawing.Color.HotPink;
            this.pbxCalisanResmi.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.pbxCalisanResmi.BorderSize = 2;
            this.pbxCalisanResmi.GradientAngle = 50F;
            this.pbxCalisanResmi.Location = new System.Drawing.Point(117, 32);
            this.pbxCalisanResmi.Name = "pbxCalisanResmi";
            this.pbxCalisanResmi.Size = new System.Drawing.Size(210, 210);
            this.pbxCalisanResmi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxCalisanResmi.TabIndex = 0;
            this.pbxCalisanResmi.TabStop = false;
            this.pbxCalisanResmi.Click += new System.EventHandler(this.pbxCalisanResmi_Click);
            // 
            // btnAddCalisanClose
            // 
            this.btnAddCalisanClose.FlatAppearance.BorderSize = 0;
            this.btnAddCalisanClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCalisanClose.ForeColor = System.Drawing.Color.DarkRed;
            this.btnAddCalisanClose.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            this.btnAddCalisanClose.IconColor = System.Drawing.Color.White;
            this.btnAddCalisanClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddCalisanClose.IconSize = 30;
            this.btnAddCalisanClose.Location = new System.Drawing.Point(404, 3);
            this.btnAddCalisanClose.Name = "btnAddCalisanClose";
            this.btnAddCalisanClose.Size = new System.Drawing.Size(35, 35);
            this.btnAddCalisanClose.TabIndex = 0;
            this.btnAddCalisanClose.UseVisualStyleBackColor = true;
            this.btnAddCalisanClose.Click += new System.EventHandler(this.btnAddCalisanClose_Click);
            // 
            // pnlAddProduct
            // 
            this.pnlAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(122)))), ((int)(((byte)(245)))));
            this.pnlAddProduct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlAddProduct.Controls.Add(this.btnUrunEkle);
            this.pnlAddProduct.Controls.Add(this.gbxDetay);
            this.pnlAddProduct.Controls.Add(this.gbxUrunResim);
            this.pnlAddProduct.Controls.Add(this.btnAddPanelClose);
            this.pnlAddProduct.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pnlAddProduct.Location = new System.Drawing.Point(328, 6);
            this.pnlAddProduct.Name = "pnlAddProduct";
            this.pnlAddProduct.Size = new System.Drawing.Size(450, 663);
            this.pnlAddProduct.TabIndex = 1;
            this.pnlAddProduct.Visible = false;
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.btnUrunEkle.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.btnUrunEkle.BorderColor = System.Drawing.Color.Red;
            this.btnUrunEkle.BorderRadius = 20;
            this.btnUrunEkle.BorderSize = 0;
            this.btnUrunEkle.FlatAppearance.BorderSize = 0;
            this.btnUrunEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUrunEkle.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnUrunEkle.ForeColor = System.Drawing.Color.White;
            this.btnUrunEkle.Location = new System.Drawing.Point(13, 586);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(423, 63);
            this.btnUrunEkle.TabIndex = 7;
            this.btnUrunEkle.Text = "Ürünü Ekle";
            this.btnUrunEkle.TextColor = System.Drawing.Color.White;
            this.btnUrunEkle.UseVisualStyleBackColor = false;
            this.btnUrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click);
            // 
            // gbxDetay
            // 
            this.gbxDetay.Controls.Add(this.cmbUrunSinifi);
            this.gbxDetay.Controls.Add(this.tbxUrunAdedi);
            this.gbxDetay.Controls.Add(this.tbxUrunFiyati);
            this.gbxDetay.Controls.Add(this.tbxUrunAdi);
            this.gbxDetay.Controls.Add(this.lblUrunSinifi);
            this.gbxDetay.Controls.Add(this.lblUrunAdi);
            this.gbxDetay.Controls.Add(this.lblUrunAdedi);
            this.gbxDetay.Controls.Add(this.lblUrunFiyati);
            this.gbxDetay.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxDetay.Location = new System.Drawing.Point(3, 305);
            this.gbxDetay.Name = "gbxDetay";
            this.gbxDetay.Size = new System.Drawing.Size(440, 275);
            this.gbxDetay.TabIndex = 6;
            this.gbxDetay.TabStop = false;
            this.gbxDetay.Text = "Ürün Detayı";
            // 
            // cmbUrunSinifi
            // 
            this.cmbUrunSinifi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUrunSinifi.Font = new System.Drawing.Font("Roboto Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbUrunSinifi.FormattingEnabled = true;
            this.cmbUrunSinifi.Items.AddRange(new object[] {
            "Atıştırmalık",
            "Süt ve Süt Ürünleri",
            "Şarküteri",
            "Giyim",
            "Elektronik"});
            this.cmbUrunSinifi.Location = new System.Drawing.Point(129, 228);
            this.cmbUrunSinifi.Name = "cmbUrunSinifi";
            this.cmbUrunSinifi.Size = new System.Drawing.Size(304, 33);
            this.cmbUrunSinifi.TabIndex = 14;
            // 
            // tbxUrunAdedi
            // 
            this.tbxUrunAdedi.Font = new System.Drawing.Font("Roboto Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxUrunAdedi.Location = new System.Drawing.Point(129, 165);
            this.tbxUrunAdedi.Name = "tbxUrunAdedi";
            this.tbxUrunAdedi.Size = new System.Drawing.Size(304, 33);
            this.tbxUrunAdedi.TabIndex = 13;
            // 
            // tbxUrunFiyati
            // 
            this.tbxUrunFiyati.Font = new System.Drawing.Font("Roboto Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxUrunFiyati.Location = new System.Drawing.Point(129, 102);
            this.tbxUrunFiyati.Name = "tbxUrunFiyati";
            this.tbxUrunFiyati.Size = new System.Drawing.Size(304, 33);
            this.tbxUrunFiyati.TabIndex = 12;
            // 
            // tbxUrunAdi
            // 
            this.tbxUrunAdi.Font = new System.Drawing.Font("Roboto Mono Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxUrunAdi.Location = new System.Drawing.Point(129, 37);
            this.tbxUrunAdi.Name = "tbxUrunAdi";
            this.tbxUrunAdi.Size = new System.Drawing.Size(304, 35);
            this.tbxUrunAdi.TabIndex = 11;
            // 
            // lblUrunSinifi
            // 
            this.lblUrunSinifi.AutoSize = true;
            this.lblUrunSinifi.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunSinifi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.lblUrunSinifi.Location = new System.Drawing.Point(6, 233);
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
            this.lblUrunAdi.Location = new System.Drawing.Point(6, 44);
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
            this.lblUrunAdedi.Location = new System.Drawing.Point(6, 170);
            this.lblUrunAdedi.Name = "lblUrunAdedi";
            this.lblUrunAdedi.Size = new System.Drawing.Size(117, 23);
            this.lblUrunAdedi.TabIndex = 7;
            this.lblUrunAdedi.Text = "Ürün Adedi :";
            // 
            // lblUrunFiyati
            // 
            this.lblUrunFiyati.AutoSize = true;
            this.lblUrunFiyati.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunFiyati.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.lblUrunFiyati.Location = new System.Drawing.Point(6, 107);
            this.lblUrunFiyati.Name = "lblUrunFiyati";
            this.lblUrunFiyati.Size = new System.Drawing.Size(113, 23);
            this.lblUrunFiyati.TabIndex = 8;
            this.lblUrunFiyati.Text = "Ürün Fiyatı :";
            // 
            // gbxUrunResim
            // 
            this.gbxUrunResim.Controls.Add(this.pbxUrunResmi);
            this.gbxUrunResim.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxUrunResim.Location = new System.Drawing.Point(3, 44);
            this.gbxUrunResim.Name = "gbxUrunResim";
            this.gbxUrunResim.Size = new System.Drawing.Size(440, 255);
            this.gbxUrunResim.TabIndex = 2;
            this.gbxUrunResim.TabStop = false;
            this.gbxUrunResim.Text = "Ürün Resmi";
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
            this.pbxUrunResmi.Location = new System.Drawing.Point(117, 32);
            this.pbxUrunResmi.Name = "pbxUrunResmi";
            this.pbxUrunResmi.Size = new System.Drawing.Size(210, 210);
            this.pbxUrunResmi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxUrunResmi.TabIndex = 0;
            this.pbxUrunResmi.TabStop = false;
            this.pbxUrunResmi.Click += new System.EventHandler(this.pbxUrunResmi_Click);
            // 
            // btnAddPanelClose
            // 
            this.btnAddPanelClose.FlatAppearance.BorderSize = 0;
            this.btnAddPanelClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPanelClose.ForeColor = System.Drawing.Color.DarkRed;
            this.btnAddPanelClose.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            this.btnAddPanelClose.IconColor = System.Drawing.Color.White;
            this.btnAddPanelClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddPanelClose.IconSize = 30;
            this.btnAddPanelClose.Location = new System.Drawing.Point(404, 3);
            this.btnAddPanelClose.Name = "btnAddPanelClose";
            this.btnAddPanelClose.Size = new System.Drawing.Size(35, 35);
            this.btnAddPanelClose.TabIndex = 0;
            this.btnAddPanelClose.UseVisualStyleBackColor = true;
            this.btnAddPanelClose.Click += new System.EventHandler(this.btnAddPanelClose_Click);
            // 
            // ddmCalisanlar
            // 
            this.ddmCalisanlar.IsMainMenu = false;
            this.ddmCalisanlar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mevcutÇalışanlarToolStripMenuItem,
            this.çalışanEkleToolStripMenuItem});
            this.ddmCalisanlar.MenuItemHeight = 50;
            this.ddmCalisanlar.MenuItemTextColor = System.Drawing.Color.Empty;
            this.ddmCalisanlar.Name = "rjDropdownMenu1";
            this.ddmCalisanlar.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(122)))), ((int)(((byte)(245)))));
            this.ddmCalisanlar.Size = new System.Drawing.Size(137, 48);
            // 
            // mevcutÇalışanlarToolStripMenuItem
            // 
            this.mevcutÇalışanlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tümÇalışanlarToolStripMenuItem,
            this.güncelÇalışanlarToolStripMenuItem1,
            this.izinliÇalışanlarToolStripMenuItem,
            this.eskiÇalışanlarToolStripMenuItem2});
            this.mevcutÇalışanlarToolStripMenuItem.Name = "mevcutÇalışanlarToolStripMenuItem";
            this.mevcutÇalışanlarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mevcutÇalışanlarToolStripMenuItem.Text = "Çalışanlar";
            // 
            // tümÇalışanlarToolStripMenuItem
            // 
            this.tümÇalışanlarToolStripMenuItem.Name = "tümÇalışanlarToolStripMenuItem";
            this.tümÇalışanlarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tümÇalışanlarToolStripMenuItem.Text = "Tüm Çalışanlar";
            this.tümÇalışanlarToolStripMenuItem.Click += new System.EventHandler(this.tümÇalışanlarToolStripMenuItem_Click);
            // 
            // güncelÇalışanlarToolStripMenuItem1
            // 
            this.güncelÇalışanlarToolStripMenuItem1.Name = "güncelÇalışanlarToolStripMenuItem1";
            this.güncelÇalışanlarToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.güncelÇalışanlarToolStripMenuItem1.Text = "Güncel Çalışanlar";
            // 
            // izinliÇalışanlarToolStripMenuItem
            // 
            this.izinliÇalışanlarToolStripMenuItem.Name = "izinliÇalışanlarToolStripMenuItem";
            this.izinliÇalışanlarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.izinliÇalışanlarToolStripMenuItem.Text = "İzinli Çalışanlar";
            // 
            // eskiÇalışanlarToolStripMenuItem2
            // 
            this.eskiÇalışanlarToolStripMenuItem2.Name = "eskiÇalışanlarToolStripMenuItem2";
            this.eskiÇalışanlarToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.eskiÇalışanlarToolStripMenuItem2.Text = "Eski Çalışanlar";
            // 
            // çalışanEkleToolStripMenuItem
            // 
            this.çalışanEkleToolStripMenuItem.Name = "çalışanEkleToolStripMenuItem";
            this.çalışanEkleToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.çalışanEkleToolStripMenuItem.Text = "Çalışan Ekle";
            this.çalışanEkleToolStripMenuItem.Click += new System.EventHandler(this.çalışanEkleToolStripMenuItem_Click);
            // 
            // ddmUrunler
            // 
            this.ddmUrunler.IsMainMenu = false;
            this.ddmUrunler.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ürünlerToolStripMenuItem,
            this.ürünlerToolStripMenuItem1});
            this.ddmUrunler.MenuItemHeight = 50;
            this.ddmUrunler.MenuItemTextColor = System.Drawing.Color.Empty;
            this.ddmUrunler.Name = "ddmUrunler";
            this.ddmUrunler.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(122)))), ((int)(((byte)(245)))));
            this.ddmUrunler.Size = new System.Drawing.Size(125, 48);
            // 
            // ürünlerToolStripMenuItem
            // 
            this.ürünlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tümÜrünlerToolStripMenuItem,
            this.atıştırmalıkToolStripMenuItem1,
            this.sütVeSütÜrünleriToolStripMenuItem1,
            this.şarküteriToolStripMenuItem1,
            this.giyimToolStripMenuItem1,
            this.elektronikToolStripMenuItem1});
            this.ürünlerToolStripMenuItem.Name = "ürünlerToolStripMenuItem";
            this.ürünlerToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.ürünlerToolStripMenuItem.Text = "Ürünler";
            // 
            // tümÜrünlerToolStripMenuItem
            // 
            this.tümÜrünlerToolStripMenuItem.Name = "tümÜrünlerToolStripMenuItem";
            this.tümÜrünlerToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.tümÜrünlerToolStripMenuItem.Text = "Tüm Ürünler";
            this.tümÜrünlerToolStripMenuItem.Click += new System.EventHandler(this.tümÜrünlerToolStripMenuItem_Click);
            // 
            // atıştırmalıkToolStripMenuItem1
            // 
            this.atıştırmalıkToolStripMenuItem1.Name = "atıştırmalıkToolStripMenuItem1";
            this.atıştırmalıkToolStripMenuItem1.Size = new System.Drawing.Size(171, 22);
            this.atıştırmalıkToolStripMenuItem1.Text = "Atıştırmalık";
            this.atıştırmalıkToolStripMenuItem1.Click += new System.EventHandler(this.atıştırmalıkToolStripMenuItem1_Click);
            // 
            // sütVeSütÜrünleriToolStripMenuItem1
            // 
            this.sütVeSütÜrünleriToolStripMenuItem1.Name = "sütVeSütÜrünleriToolStripMenuItem1";
            this.sütVeSütÜrünleriToolStripMenuItem1.Size = new System.Drawing.Size(171, 22);
            this.sütVeSütÜrünleriToolStripMenuItem1.Text = "Süt ve Süt Ürünleri";
            this.sütVeSütÜrünleriToolStripMenuItem1.Click += new System.EventHandler(this.sütVeSütÜrünleriToolStripMenuItem1_Click);
            // 
            // şarküteriToolStripMenuItem1
            // 
            this.şarküteriToolStripMenuItem1.Name = "şarküteriToolStripMenuItem1";
            this.şarküteriToolStripMenuItem1.Size = new System.Drawing.Size(171, 22);
            this.şarküteriToolStripMenuItem1.Text = "Şarküteri";
            this.şarküteriToolStripMenuItem1.Click += new System.EventHandler(this.şarküteriToolStripMenuItem1_Click);
            // 
            // giyimToolStripMenuItem1
            // 
            this.giyimToolStripMenuItem1.Name = "giyimToolStripMenuItem1";
            this.giyimToolStripMenuItem1.Size = new System.Drawing.Size(171, 22);
            this.giyimToolStripMenuItem1.Text = "Giyim";
            this.giyimToolStripMenuItem1.Click += new System.EventHandler(this.giyimToolStripMenuItem1_Click);
            // 
            // elektronikToolStripMenuItem1
            // 
            this.elektronikToolStripMenuItem1.Name = "elektronikToolStripMenuItem1";
            this.elektronikToolStripMenuItem1.Size = new System.Drawing.Size(171, 22);
            this.elektronikToolStripMenuItem1.Text = "Elektronik";
            this.elektronikToolStripMenuItem1.Click += new System.EventHandler(this.elektronikToolStripMenuItem1_Click);
            // 
            // ürünlerToolStripMenuItem1
            // 
            this.ürünlerToolStripMenuItem1.Name = "ürünlerToolStripMenuItem1";
            this.ürünlerToolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.ürünlerToolStripMenuItem1.Text = "Ürün Ekle";
            this.ürünlerToolStripMenuItem1.Click += new System.EventHandler(this.ürünlerToolStripMenuItem1_Click);
            // 
            // ofdAddUrunPicture
            // 
            this.ofdAddUrunPicture.Filter = "JPG Dosyaları|*.jpg| JPEG Dosyaları|*.jpeg| PNG Dosyaları|*.png";
            this.ofdAddUrunPicture.FilterIndex = 2;
            // 
            // ofdAddCalisanPicture
            // 
            this.ofdAddCalisanPicture.Filter = "JPG Dosyaları|*.jpg| JPEG Dosyaları|*.jpeg| PNG Dosyaları|*.png";
            this.ofdAddCalisanPicture.FilterIndex = 2;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.pnlFill);
            this.Controls.Add(this.pnlTitleBar);
            this.Controls.Add(this.pnlMenu);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.SizeChanged += new System.EventHandler(this.frmMain_SizeChanged);
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            this.pnlMenu.ResumeLayout(false);
            this.pnlPictureBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.pnlTitleBar.ResumeLayout(false);
            this.pnlTitleBar.PerformLayout();
            this.pnlFill.ResumeLayout(false);
            this.pnlAddCalisan.ResumeLayout(false);
            this.gbxBilgiler.ResumeLayout(false);
            this.gbxBilgiler.PerformLayout();
            this.gbxCalisanResim.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxCalisanResmi)).EndInit();
            this.pnlAddProduct.ResumeLayout(false);
            this.gbxDetay.ResumeLayout(false);
            this.gbxDetay.PerformLayout();
            this.gbxUrunResim.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxUrunResmi)).EndInit();
            this.ddmCalisanlar.ResumeLayout(false);
            this.ddmUrunler.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlPictureBox;
        private System.Windows.Forms.Panel pnlTitleBar;
        private System.Windows.Forms.Panel pnlFill;
        private System.Windows.Forms.PictureBox pbxLogo;
        private FontAwesome.Sharp.IconButton btnMenu;
        private FontAwesome.Sharp.IconButton btnHome;
        private FontAwesome.Sharp.IconButton btnExit;
        private FontAwesome.Sharp.IconButton btnAyarlar;
        private FontAwesome.Sharp.IconButton btnUrunBilgileri;
        private FontAwesome.Sharp.IconButton btnCalisanBilgileri;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private FontAwesome.Sharp.IconButton btnMaximize;
        private FontAwesome.Sharp.IconButton btnClose;
        private System.Windows.Forms.Label lblDashBoard;
        private RJCodeAdvance.RJControls.RJDropdownMenu ddmCalisanlar;
        private System.Windows.Forms.ToolStripMenuItem mevcutÇalışanlarToolStripMenuItem;
        private RJCodeAdvance.RJControls.RJDropdownMenu ddmUrunler;
        private System.Windows.Forms.ToolStripMenuItem ürünlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tümÜrünlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atıştırmalıkToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sütVeSütÜrünleriToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem şarküteriToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem giyimToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem elektronikToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ürünlerToolStripMenuItem1;
        private System.Windows.Forms.Panel pnlAddProduct;
        private FontAwesome.Sharp.IconButton btnAddPanelClose;
        private System.Windows.Forms.GroupBox gbxUrunResim;
        private RJCodeAdvance.RJControls.RJCircularPictureBox pbxUrunResmi;
        private System.Windows.Forms.GroupBox gbxDetay;
        private System.Windows.Forms.ComboBox cmbUrunSinifi;
        private System.Windows.Forms.TextBox tbxUrunAdedi;
        private System.Windows.Forms.TextBox tbxUrunFiyati;
        private System.Windows.Forms.TextBox tbxUrunAdi;
        private System.Windows.Forms.Label lblUrunSinifi;
        private System.Windows.Forms.Label lblUrunAdi;
        private System.Windows.Forms.Label lblUrunAdedi;
        private System.Windows.Forms.Label lblUrunFiyati;
        private CustomBox.RJControls.RJButton btnUrunEkle;
        private System.Windows.Forms.OpenFileDialog ofdAddUrunPicture;
        private System.Windows.Forms.ToolStripMenuItem tümÇalışanlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem güncelÇalışanlarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem izinliÇalışanlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eskiÇalışanlarToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem çalışanEkleToolStripMenuItem;
        private System.Windows.Forms.Panel pnlAddCalisan;
        private CustomBox.RJControls.RJButton btnCalisanEkle;
        private System.Windows.Forms.GroupBox gbxBilgiler;
        private System.Windows.Forms.TextBox tbxPozisyon;
        private System.Windows.Forms.TextBox tbxSoyad;
        private System.Windows.Forms.TextBox tbxAd;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbxCalisanResim;
        private RJCodeAdvance.RJControls.RJCircularPictureBox pbxCalisanResmi;
        private FontAwesome.Sharp.IconButton btnAddCalisanClose;
        private System.Windows.Forms.OpenFileDialog ofdAddCalisanPicture;
    }
}

