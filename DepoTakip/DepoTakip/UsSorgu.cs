using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DepoTakip
{
    public partial class UsSorgu : UserControl
    {
        private DeposDataContext db = new DeposDataContext();
        public UsSorgu()
        {
            InitializeComponent();
        }

        private void cmbxSorgu_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbxSorgu.SelectedIndex)
            {
                case 0:
                    CalısanBindingSource.DataSource = from employee in db.EMPLOYEEs
                                                      select employee;
                    dataGridViewSorgu.DataSource = CalısanBindingSource;
                    break;
                case 1:
                    dataGridViewSorgu.DataSource = from calısan in db.EMPLOYEEs
                                                   from depo in calısan.DEPOs
                                                   select new { depo.DepoName, calısan.FirstName, calısan.LastName };
                    break;
                case 2:
                    dataGridViewSorgu.DataSource = from depofrom in db.DEPOs
                                                   from depoto in db.DEPOs
                                                   from move in db.MOVEMENTs
                                                   from product in db.PRODUCTs
                                                   where depofrom.Depo_id == move.From_move && move.to_move == depoto.Depo_id && move.Product_id==product.Product_id
                                                   select new { HAREKET=depofrom.DepoName ,TRANSFER=depoto.DepoName, ÜRÜNADI=product.ProductName , MİKTAR=move.Quantity , TARİH=move.Created_at};                                   
                    break;       
                case 3:
                    dataGridViewSorgu.DataSource= from ürün in db.PRODUCTs
                                                  from muadil in db.PRODUCTs
                                                  from muadil_relation in db.URUNMUADILs
                                                  where ürün.Product_id==muadil_relation.Product_id && muadil_relation.Muadil_id==muadil.Product_id
                                                  select new { ÜRÜN= ürün.ProductName , MUADİL=muadil.ProductName};
                    break;
                case 4:
                    dataGridViewSorgu.DataSource = from depo in db.DEPOs
                                                   from product in db.PRODUCTs
                                                   from contain in db.DEPOCONTAINs
                                                   where depo.Depo_id == contain.Depo_id && contain.Product_id == product.Product_id
                                                   select new { DEPOADI = depo.DepoName, ÜRÜNADI = product.ProductName, MİKTAR = contain.Quantity, GİRİSTARİHİ = contain.Created_at };
                    break;
                case 5:
                    dataGridViewSorgu.DataSource = from depo in db.DEPOs
                                                   from product in db.PRODUCTs
                                                   from contain in db.DEPOCONTAINs
                                                   where depo.Depo_id == contain.Depo_id && contain.Product_id == product.Product_id && contain.Quantity < 10
                                                   select new { DEPOADI = depo.DepoName, ÜRÜNADI = product.ProductName, MİKTAR = contain.Quantity };
                    break;
                                                  
            }

            
        }

        private void btnKayıt_Click(object sender, EventArgs e)
        {
            if (txtCalısan.Text== "" ||  txtAd.Text == "" || txtSoyad.Text == "" || txtAdress.Text == "" || txtPhone.Text == "" || txtUsername.Text == "" || txtPassword.Text == "")
                MessageBox.Show("SAHALARI BOS GECMEYİNİZ!!!", "DİKKAT!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                var same_kullanıcı = (from same in db.EMPLOYEEs where same.Employee_TCNO == txtCalısan.Text select same).Count();
                if (same_kullanıcı == 0)
                {
                    EMPLOYEE new_kullanıcı = new EMPLOYEE();
                    new_kullanıcı.Employee_TCNO = txtCalısan.Text;
                    new_kullanıcı.FirstName = txtAd.Text;
                    new_kullanıcı.LastName = txtSoyad.Text;
                    new_kullanıcı.Adress = txtAdress.Text;
                    new_kullanıcı.Phone = txtPhone.Text;
                    new_kullanıcı.username = txtUsername.Text;
                    new_kullanıcı.password = txtPassword.Text;
                    new_kullanıcı.Email = txtEmail.Text;
                    new_kullanıcı.admin_mi = chckAdmin.Enabled;

                    db.EMPLOYEEs.InsertOnSubmit(new_kullanıcı);
                    db.SubmitChanges();
                    txtCalısan.Text="";
                    txtAd.Text = "";
                    txtSoyad.Text = "";
                    txtAdress.Text = "";
                    txtPhone.Text = "";
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    txtEmail.Text = "";
                    chckAdmin.Checked = false;
                    
                    MessageBox.Show("Kullanıcı Basarı ile Eklendi", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("BU TC noya Sahip Calısan Zaten Vardır", "DİKKAT!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCalısan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)08 && e.KeyChar != (char)44)
            {
                e.Handled = true;
                MessageBox.Show("Sadece Sayı Girişi Yapabilirsiniz ! ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 
            if(txtCalısan.Text.Length>11)
                MessageBox.Show("TC NO 11 Haneden Fazla Olamaz ! ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

           
        }

        private void txtAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == false && e.KeyChar != (char)08 && e.KeyChar != (char)44)
            {
                e.Handled = true;
                MessageBox.Show("Sadece Harf Girişi Yapabilirsiniz ! ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }    
        }

        private void txtSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == false && e.KeyChar != (char)08 && e.KeyChar != (char)44)
            {
                e.Handled = true;
                MessageBox.Show("Sadece Harf Girişi Yapabilirsiniz ! ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }    
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)08 && e.KeyChar != (char)44)
            {
                e.Handled = true;
                MessageBox.Show("Sadece Sayı Girişi Yapabilirsiniz ! ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }        
        }
    }
}
