using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using RJCodeAdvance.RJControls;
using System.IO;

namespace CyberMarket
{
    public partial class frmMain : Form
    {
        private int borderSize = 2;
        public frmMain(string session)
        {
            InitializeComponent();
            this.Padding = new Padding(borderSize); //Border size
            this.BackColor = Color.FromArgb(21, 122, 245); //Border color
            CollapseMenu();
            if (session=="Çalışan")
            {
                btnCalisanBilgileri.Visible = false;
            }
        }

        //Dll Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pnlTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //Overriden method 
        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;//Standar Title Bar - Snap Window
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MINIMIZE = 0xF020; //Minimize form (Before)
            const int SC_RESTORE = 0xF120; //Restore form (Before)
            const int WM_NCHITTEST = 0x0084;//Win32, Mouse Input Notification: Determine what part of the window corresponds to a point, allows to resize the form.
            const int resizeAreaSize = 10;
            #region Form Resize
            // Resize/WM_NCHITTEST values
            const int HTCLIENT = 1; //Represents the client area of the window
            const int HTLEFT = 10;  //Left border of a window, allows resize horizontally to the left
            const int HTRIGHT = 11; //Right border of a window, allows resize horizontally to the right
            const int HTTOP = 12;   //Upper-horizontal border of a window, allows resize vertically up
            const int HTTOPLEFT = 13;//Upper-left corner of a window border, allows resize diagonally to the left
            const int HTTOPRIGHT = 14;//Upper-right corner of a window border, allows resize diagonally to the right
            const int HTBOTTOM = 15; //Lower-horizontal border of a window, allows resize vertically down
            const int HTBOTTOMLEFT = 16;//Lower-left corner of a window border, allows resize diagonally to the left
            const int HTBOTTOMRIGHT = 17;//Lower-right corner of a window border, allows resize diagonally to the right
            ///<Doc> More Information: https://docs.microsoft.com/en-us/windows/win32/inputdev/wm-nchittest </Doc>
            if (m.Msg == WM_NCHITTEST)
            { //If the windows m is WM_NCHITTEST
                base.WndProc(ref m);
                if (this.WindowState == FormWindowState.Normal)//Resize the form if it is in normal state
                {
                    if ((int)m.Result == HTCLIENT)//If the result of the m (mouse pointer) is in the client area of the window
                    {
                        Point screenPoint = new Point(m.LParam.ToInt32()); //Gets screen point coordinates(X and Y coordinate of the pointer)                           
                        Point clientPoint = this.PointToClient(screenPoint); //Computes the location of the screen point into client coordinates                          
                        if (clientPoint.Y <= resizeAreaSize)//If the pointer is at the top of the form (within the resize area- X coordinate)
                        {
                            if (clientPoint.X <= resizeAreaSize) //If the pointer is at the coordinate X=0 or less than the resizing area(X=10) in 
                                m.Result = (IntPtr)HTTOPLEFT; //Resize diagonally to the left
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize))//If the pointer is at the coordinate X=11 or less than the width of the form(X=Form.Width-resizeArea)
                                m.Result = (IntPtr)HTTOP; //Resize vertically up
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTTOPRIGHT;
                        }
                        else if (clientPoint.Y <= (this.Size.Height - resizeAreaSize)) //If the pointer is inside the form at the Y coordinate(discounting the resize area size)
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize horizontally to the left
                                m.Result = (IntPtr)HTLEFT;
                            else if (clientPoint.X > (this.Width - resizeAreaSize))//Resize horizontally to the right
                                m.Result = (IntPtr)HTRIGHT;
                        }
                        else
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize diagonally to the left
                                m.Result = (IntPtr)HTBOTTOMLEFT;
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize)) //Resize vertically down
                                m.Result = (IntPtr)HTBOTTOM;
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTBOTTOMRIGHT;
                        }
                    }
                }
                return;
            }
            #endregion
            //Remove border and keep snap window
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }
            //Keep form size when it is minimized and restored. Since the form is resized because it takes into account the size of the title bar and borders.
            base.WndProc(ref m);
        }

        //Event method
        private void frmMain_Resize(object sender, EventArgs e)
        {
            AdjustForm();
        }

        //Private method
        private void AdjustForm()
        {
            switch(this.WindowState)
            {
                case FormWindowState.Maximized:
                    this.Padding = new Padding(0, 8, 8, 0);
                    break;
                case FormWindowState.Normal:
                    if (this.Padding.Top != borderSize)
                        this.Padding = new Padding();
                    break;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            CollapseMenu();
            pnlAddProduct.Location = new Point(this.pnlFill.Width - pnlAddProduct.Width, this.pnlFill.Height - pnlAddProduct.Height);
        }

        private void CollapseMenu()
        {
            if (this.pnlMenu.Width > 200)
            {
                pnlMenu.Width = 100;
                pbxLogo.Visible = false;
                btnMenu.Dock = DockStyle.Top;
                foreach (Button menuButton in pnlMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0);
                }
            }
            else
            {
                pnlMenu.Width = 230;
                pbxLogo.Visible = true;
                btnMenu.Dock = DockStyle.None;
                foreach (Button menuButton in pnlMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "   " + menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(10, 0, 0, 0);
                }

            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Open_DropDownMenu(RJDropdownMenu dropdownMenu, object sender)
        {
            Control control = (Control)sender;
            dropdownMenu.VisibleChanged += new EventHandler((sender2, ev) =>
                DropDownMenu_VisibleChanged(sender2, ev, control));
            dropdownMenu.Show(control, control.Width, 0);
        }

        private void DropDownMenu_VisibleChanged(object sender, EventArgs e, Control control)
        {
            RJDropdownMenu dropdownMenu = (RJDropdownMenu)sender;
            if (!DesignMode)
            {
                if (dropdownMenu.Visible)
                {
                    control.BackColor = Color.FromArgb(18, 109, 220);
                }
                else
                    control.BackColor = Color.FromArgb(21, 122, 245);
            }
        }

        private void btnCalisanBilgileri_Click(object sender, EventArgs e)
        {
            Open_DropDownMenu(ddmCalisanlar, sender);
        }

        private void btnUrunBilgileri_Click(object sender, EventArgs e)
        {
            Open_DropDownMenu(ddmUrunler, sender);
        }

        Form _activeForm;
        private void OpenChildForm(Form childForm)
        {
            if (_activeForm != null)
                _activeForm.Close();
            _activeForm = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            pnlFill.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            lblDashBoard.Text = "Ana Sayfa";
            if (_activeForm != null)
                _activeForm.Close();
        }

        private void tümÜrünlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblDashBoard.Text = "Ürünler";
            OpenChildForm(new frmUrunler("Tüm Ürünler"));
        }

        private void btnAddPanelClose_Click(object sender, EventArgs e)
        {
            for (int i = pnlAddProduct.Height; i >= 0; i--)
            {
                pnlAddProduct.Location = new Point(this.pnlFill.Width - pnlAddProduct.Width, this.pnlFill.Height - i);
            }
            pnlAddProduct.Visible = false;
        }

        private void btnAddCalisanClose_Click(object sender, EventArgs e)
        {
            for (int i = pnlAddCalisan.Height; i >= 0; i--)
            {
                pnlAddCalisan.Location = new Point(this.pnlFill.Width - pnlAddCalisan.Width, this.pnlFill.Height - i);
            }
            pnlAddCalisan.Visible = false;
        }

        //ClearAddPanel Method
        private void ClearAddProductPanel()
        {
            ofdAddUrunPicture.FileName = null;
            pbxUrunResmi.Image = null;
            tbxUrunAdi.Clear();
            tbxUrunFiyati.Clear();
            tbxUrunAdedi.Clear();
            cmbUrunSinifi.SelectedIndex = -1;
        }

        private void ClearAddCalisanPanel()
        {
            ofdAddCalisanPicture.FileName = null;
            pbxCalisanResmi.Image = null;
            tbxAd.Clear();
            tbxSoyad.Clear();
            tbxPozisyon.Clear();
        }

        //Urun ekle toolstrip
        private void ürünlerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ClearAddProductPanel();
            pnlAddProduct.Location = new Point(this.pnlFill.Width - pnlAddProduct.Width, this.pnlFill.Height - pnlAddProduct.Height);
            pnlAddProduct.Visible = true;
            pnlAddCalisan.Visible = false;
            pnlAddProduct.BringToFront();
        }

        private void frmMain_SizeChanged(object sender, EventArgs e)
        {
            pnlAddProduct.Location = new Point(this.pnlFill.Width - pnlAddProduct.Width, this.pnlFill.Height - pnlAddProduct.Height);
            pnlAddCalisan.Location = new Point(this.pnlFill.Width - pnlAddCalisan.Width, this.pnlFill.Height - pnlAddCalisan.Height);
        }


        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            if (CompanentControlProduct())
            {
                UrunDal urunDal = new UrunDal();
                Urun urun = new Urun
                {
                    UrunAdi = tbxUrunAdi.Text,
                    UrunFiyati = Convert.ToDecimal(tbxUrunFiyati.Text),
                    UrunAdedi = Convert.ToInt32(tbxUrunAdedi.Text),
                    UrunSinifi = cmbUrunSinifi.Text
                };
                if (!String.IsNullOrEmpty(ofdAddUrunPicture.FileName))
                {
                    FileStream fileStream = new FileStream(ofdAddUrunPicture.FileName, FileMode.Open, FileAccess.Read);
                    BinaryReader binaryReader = new BinaryReader(fileStream);
                    byte[] resim = binaryReader.ReadBytes((int)fileStream.Length);
                    binaryReader.Close();
                    fileStream.Close();
                    urun.UrunResmi = resim;
                }
                else
                    urun.UrunResmi = new byte[0];
                urunDal.Add(urun);
                MessageBox.Show("Ürün başarıyla eklendi !", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearAddProductPanel();
            }
        }
        private void btnCalisanEkle_Click(object sender, EventArgs e)
        {
            if (CompanentControlCalisan())
            {
                CalisanDal calisanDal = new CalisanDal();
                Calisan calisan = new Calisan
                {
                    Ad = tbxAd.Text,
                    Soyad = tbxSoyad.Text,
                    Pozisyon = tbxPozisyon.Text,
                    Durum = "Güncel Çalışan"
                };
                if (!String.IsNullOrEmpty(ofdAddCalisanPicture.FileName))
                {
                    FileStream fileStream = new FileStream(ofdAddCalisanPicture.FileName, FileMode.Open, FileAccess.Read);
                    BinaryReader binaryReader = new BinaryReader(fileStream);
                    byte[] resim = binaryReader.ReadBytes((int)fileStream.Length);
                    binaryReader.Close();
                    fileStream.Close();
                    calisan.Resim = resim;
                }
                else
                    calisan.Resim = new byte[0];
                calisanDal.Add(calisan);
                MessageBox.Show("Çalışan başarıyla kaydedildi !", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearAddCalisanPanel();
            }
        }

        private bool CompanentControlCalisan()
        {
            if (String.IsNullOrEmpty(tbxAd.Text))
            {
                MessageBox.Show("Ad boş olamaz !", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (String.IsNullOrEmpty(tbxSoyad.Text))
            {
                MessageBox.Show("Soyad boş olamaz !", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (String.IsNullOrEmpty(tbxPozisyon.Text))
            {
                MessageBox.Show("Pozisyon boş olamaz !", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }


        private bool CompanentControlProduct()
        {
            if (String.IsNullOrEmpty(tbxUrunAdi.Text))
            {
                MessageBox.Show("Ürün Adı boş olamaz !", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (String.IsNullOrEmpty(tbxUrunFiyati.Text))
            {
                MessageBox.Show("Ürün Adı boş olamaz !", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                try
                {
                    decimal denemeSayi = Convert.ToDecimal(tbxUrunFiyati.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Lütfen geçerli bir ürün fiyatı girin !", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            if (String.IsNullOrEmpty(tbxUrunAdedi.Text))
            {
                MessageBox.Show("Ürün Adedi boş olamaz !", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                try
                {
                    int denemeSayi = Convert.ToInt32(tbxUrunAdedi.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Lütfen geçerli bir ürün adedi girin !", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }

        private void pbxUrunResmi_Click(object sender, EventArgs e)
        {
            if (ofdAddUrunPicture.ShowDialog() == DialogResult.OK)
            {
                pbxUrunResmi.Image = Image.FromFile(ofdAddUrunPicture.FileName);
            }
        }
        private void pbxCalisanResmi_Click(object sender, EventArgs e)
        {
            if (ofdAddCalisanPicture.ShowDialog() == DialogResult.OK)
            {
                pbxCalisanResmi.Image = Image.FromFile(ofdAddCalisanPicture.FileName);
            }
        }

        private void atıştırmalıkToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            lblDashBoard.Text = "Atıştırmalık";
            OpenChildForm(new frmUrunler("Atıştırmalık"));
        }

        private void sütVeSütÜrünleriToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            lblDashBoard.Text = "Süt ve Süt Ürünleri";
            OpenChildForm(new frmUrunler("Süt ve Süt Ürünleri"));
        }

        private void şarküteriToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            lblDashBoard.Text = "Şarküteri";
            OpenChildForm(new frmUrunler("Şarküteri"));
        }

        private void giyimToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            lblDashBoard.Text = "Giyim";
            OpenChildForm(new frmUrunler("Giyim"));
        }

        private void elektronikToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            lblDashBoard.Text = "Elektronik";
            OpenChildForm(new frmUrunler("Elektronik"));
        }

        private void çalışanEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearAddCalisanPanel();
            pnlAddCalisan.Location = new Point(this.pnlFill.Width - pnlAddCalisan.Width, this.pnlFill.Height - pnlAddCalisan.Height);
            pnlAddCalisan.Visible = true;
            pnlAddProduct.Visible = false;
            pnlAddCalisan.BringToFront();
        }

        private void tümÇalışanlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblDashBoard.Text = "Çalışanlar";
            OpenChildForm(new frmCalisanlar("Tüm Çalışanlar"));
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
