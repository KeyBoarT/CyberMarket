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
    public partial class frmCalisanlar : Form
    {
        private string _aramaKriteri;
        private CalisanDal _calisanDal = new CalisanDal();
        public frmCalisanlar(string aramaKriteri)
        {
            _aramaKriteri = aramaKriteri;
            InitializeComponent();
        }

        private void frmCalisanlar_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
        }
        private void LoadDataGridView()
        {
            dgvCalisanlar.ClearSelection();
            if (_aramaKriteri == "Tüm Çalışanlar")
            {
                dgvCalisanlar.DataSource = _calisanDal.GetAll();
            }
            else
            {
                dgvCalisanlar.DataSource = _calisanDal.GetByDurum(_aramaKriteri);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (CompanentControl())
            {
                Calisan calisan = new Calisan
                {
                    Id = Convert.ToInt32(lblCalisanIdSonuc.Text),
                    Ad = tbxAd.Text,
                    Soyad = tbxSoyad.Text,
                    Pozisyon = tbxPozisyon.Text,
                    Durum = cmbDurum.Text
                };
                if (!String.IsNullOrEmpty(ofdUpdatePicture.FileName))
                {
                    FileStream fileStream = new FileStream(ofdUpdatePicture.FileName, FileMode.Open, FileAccess.Read);
                    BinaryReader binaryReader = new BinaryReader(fileStream);
                    byte[] resim = binaryReader.ReadBytes((int)fileStream.Length);
                    binaryReader.Close();
                    fileStream.Close();
                    calisan.Resim = resim;
                    _calisanDal.Update(calisan);
                }
                else
                {
                    _calisanDal.UpdateWithoutPicture(calisan);
                }
                LoadDataGridView();
                MessageBox.Show("Çalışan başarıyla Güncellendi !", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearAddPanel();
            }
        }
        private void ClearAddPanel()
        {
            lblCalisanIdSonuc.Text = "";
            ofdUpdatePicture.FileName = null;
            pbxResim.Image = null;
            tbxAd.Clear();
            tbxSoyad.Clear();
            tbxPozisyon.Clear();
            cmbDurum.SelectedIndex = -1;
        }

        private bool CompanentControl()
        {
            if (lblCalisanIdSonuc.Text == "")
            {
                MessageBox.Show("Henüz bir çalışan seçilmedi !", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
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

        private void pbxResim_Click(object sender, EventArgs e)
        {
            if (ofdUpdatePicture.ShowDialog() == DialogResult.OK)
            {
                pbxResim.Image = Image.FromFile(ofdUpdatePicture.FileName);
            }
        }

        private void dgvCalisanlar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ClearAddPanel();
            lblCalisanIdSonuc.Text = dgvCalisanlar.CurrentRow.Cells[0].Value.ToString();
            tbxAd.Text = (string)dgvCalisanlar.CurrentRow.Cells[1].Value;
            tbxSoyad.Text = (string)dgvCalisanlar.CurrentRow.Cells[2].Value;
            tbxPozisyon.Text = (string)dgvCalisanlar.CurrentRow.Cells[3].Value;
            cmbDurum.SelectedItem = (string)dgvCalisanlar.CurrentRow.Cells[4].Value;
            var Data = (byte[])(dgvCalisanlar.CurrentRow.Cells[5].Value);
            if (Data != null)
            {
                using (MemoryStream stream = new MemoryStream(Data))
                {
                    pbxResim.Image = Image.FromStream(stream);
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lblCalisanIdSonuc.Text != "")
            {
                DialogResult result = MessageBox.Show(lblCalisanIdSonuc.Text + " ID'li ürün kalıcı olarak silinecek !", "Hata", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    _calisanDal.Delete(Convert.ToInt32(lblCalisanIdSonuc.Text));
                    LoadDataGridView();
                    MessageBox.Show("Çalışan başarıyla silindi !", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Henüz bir çalışan seçilmedi !", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
