using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DepoTakip
{
    public partial class Login : Form
    {
        private DeposDataContext db = new DeposDataContext();
        public Login()
        {
            InitializeComponent(); 
        }

        private void Login_Load(object sender, EventArgs e)
        {
            cmbxSec.SelectedIndex = 0;
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {

            if (txtKullanıcı.Text == "")
            {
                errorLogin.SetError(txtKullanıcı, "Kullanıcı adı bos gecilemez");
                MessageBox.Show("Kullanıcı adınızı boş bırakamazsınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtPassword.Text == "")
            {
                errorLogin.SetError(txtPassword, "Şifre bos gecilemez");
                MessageBox.Show("Lütfen şifre giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {


                if (cmbxSec.SelectedIndex == 0)
                {
                    var Result = from admin in db.EMPLOYEEs
                                 where (admin.username == txtKullanıcı.Text && admin.password == txtPassword.Text && admin.admin_mi == true)
                                 select admin;
                    if (Result.Any())
                    {
                        txtKullanıcı.Text = null;
                        txtPassword.Text = null;
                        this.Hide();
                        AdminPanel adminpanel = new AdminPanel(this);
                        adminpanel.Show();
                    }
                    else
                        MessageBox.Show("Admin Yetkisine Sahip Degilsiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }
                else
                {
                    var Result = from personel in db.EMPLOYEEs
                                 where (personel.username == txtKullanıcı.Text && personel.password == txtPassword.Text && personel.admin_mi == false)
                                 select personel;
                    if (Result.Any())
                    {
                        txtKullanıcı.Text = null;
                        txtPassword.Text = null;
                        this.Hide();
                        PersonelPanel personelpanel = new PersonelPanel(this);
                        personelpanel.Show();
                    }
                    else
                       MessageBox.Show("Kullanıcı Bulunamadı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            
        }

      


        

        
    }
}
