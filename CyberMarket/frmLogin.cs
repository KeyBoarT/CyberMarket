using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CyberMarket
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private bool CompanentControl()
        {
            if (String.IsNullOrEmpty(tbxUsername.Text))
            {
                MessageBox.Show("Ad kısmı boş bırakılamaz !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void chckVisiblePassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chckVisiblePassword.Checked)
                tbxPassword.UseSystemPasswordChar = true;
            else
                tbxPassword.UseSystemPasswordChar = false;
        }

        private void tbxUsername_Enter(object sender, EventArgs e)
        {
            if (tbxUsername.Text == "Kullanıcı Adı")
            {
                tbxUsername.Clear();
                tbxUsername.ForeColor = Color.Black;
            }
        }

        private void tbxUsername_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxUsername.Text))
            {
                tbxUsername.Text = "Kullanıcı Adı";
                tbxUsername.ForeColor = Color.Gray;
            }
        }

        private void tbxPassword_Enter(object sender, EventArgs e)
        {
            if (tbxPassword.Text == "Parola")
            {
                tbxPassword.Clear();
                tbxPassword.ForeColor = Color.Black;
            }
        }
        private void tbxPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxPassword.Text))
            {
                tbxPassword.Text = "Parola";
                tbxPassword.ForeColor = Color.Gray;
            }
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (CompanentControl())
            {
                if (tbYonetici.Checked)
                {
                    if (tbxUsername.Text == "Mehmet Sezer" && tbxPassword.Text=="12345")
                    {
                        frmMain frm = new frmMain("Yönetici");
                        frm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı Adı ve Şifre uyuşmuyor !");
                    }
                }
                else
                {
                    if (tbxUsername.Text == "Samet Sezer" && tbxPassword.Text=="12")
                    {
                        frmMain frm = new frmMain("Çalışan");
                        frm.Show();
                        Hide();
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı Adı ve Şifre uyuşmuyor !");
                    }
                }
            }
        }
    }
}
