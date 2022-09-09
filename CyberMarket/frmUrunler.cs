using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace CyberMarket
{
    public partial class frmUrunler : Form
    {
        private string _aramaKriteri;
        private UrunDal _urunDal = new UrunDal();
        public frmUrunler(string aramaKriteri)
        {
            _aramaKriteri = aramaKriteri;
            InitializeComponent();
        }
        private void frmUrunler_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
        }

        private void LoadDataGridView()
        {
            dgvUrunler.ClearSelection();
            if (_aramaKriteri == "Tüm Ürünler")
            {
                dgvUrunler.DataSource = _urunDal.GetAll();
            }
            else
            {
                dgvUrunler.DataSource = _urunDal.GetBySinif(_aramaKriteri);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (CompanentControl())
            {
                UrunDal urunDal = new UrunDal();
                Urun urun = new Urun
                {
                    Id = Convert.ToInt32(lblUrunIdSonuc.Text),
                    UrunAdi = tbxUrunAdi.Text,
                    UrunFiyati = Convert.ToDecimal(tbxUrunFiyati.Text),
                    UrunAdedi = Convert.ToInt32(tbxUrunAdedi.Text),
                    UrunSinifi = cmbUrunSinifi.Text
                };
                if (!String.IsNullOrEmpty(ofdUpdatePicture.FileName))
                {
                    FileStream fileStream = new FileStream(ofdUpdatePicture.FileName, FileMode.Open, FileAccess.Read);
                    BinaryReader binaryReader = new BinaryReader(fileStream);
                    byte[] resim = binaryReader.ReadBytes((int)fileStream.Length);
                    binaryReader.Close();
                    fileStream.Close();
                    urun.UrunResmi = resim;
                    urunDal.Update(urun);
                }
                else
                {
                    urunDal.UpdateWithoutPicture(urun);
                }
                LoadDataGridView();
                MessageBox.Show("Ürün başarıyla Güncellendi !", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearAddPanel();
            }
        }
        private void ClearAddPanel()
        {
            lblUrunIdSonuc.Text = "";
            ofdUpdatePicture.FileName = null;
            pbxUrunResmi.Image = null;
            tbxUrunAdi.Clear();
            tbxUrunFiyati.Clear();
            tbxUrunAdedi.Clear();
            cmbUrunSinifi.SelectedIndex = -1;
        }

        private bool CompanentControl()
        {
            if (lblUrunIdSonuc.Text == "")
            {
                MessageBox.Show("Henüz bir ürün seçilmedi !", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
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
            if (ofdUpdatePicture.ShowDialog() == DialogResult.OK)
            {
                pbxUrunResmi.Image = Image.FromFile(ofdUpdatePicture.FileName);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lblUrunIdSonuc.Text != "")
            {
                DialogResult result = MessageBox.Show(lblUrunIdSonuc.Text + " ID'li ürün kalıcı olarak silinecek !", "Hata", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    _urunDal.Delete(Convert.ToInt32(lblUrunIdSonuc.Text));
                    LoadDataGridView();
                    MessageBox.Show("Ürün başarıyla silindi !", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Henüz bir ürün seçilmedi !", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvUrunler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ClearAddPanel();
            lblUrunIdSonuc.Text = dgvUrunler.CurrentRow.Cells[0].Value.ToString();
            tbxUrunAdi.Text = (string)dgvUrunler.CurrentRow.Cells[1].Value;
            tbxUrunFiyati.Text = dgvUrunler.CurrentRow.Cells[2].Value.ToString();
            tbxUrunAdedi.Text = dgvUrunler.CurrentRow.Cells[3].Value.ToString();
            cmbUrunSinifi.SelectedItem = (string)dgvUrunler.CurrentRow.Cells[4].Value;
            var Data = (byte[])(dgvUrunler.CurrentRow.Cells[5].Value);
            if (Data != null)
            {
                using (MemoryStream stream = new MemoryStream(Data))
                {
                    pbxUrunResmi.Image = Image.FromStream(stream);
                }
            }
            
        }
    }
}
