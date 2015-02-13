using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DepoTakip
{
    public partial class AdminPanel : Form
    {
        Form previous_form;
        private DeposDataContext db = new DeposDataContext();
        public AdminPanel(Form login)
        {
            previous_form = login;
            InitializeComponent();
        }

        private void AdminPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            previous_form.Show();
           
        }


        private void AdminPanel_Load(object sender, EventArgs e)
        {
            ürünGetir();
            kategoriGetir();
            cmbxKategoriGetir();
            
           
            refreshDepo();

        }

        private void tbcntrlAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tbcntrlAdmin.SelectedIndex)
            {
                case 1:
                    cmbxÜrünMuadilGetir();
                    break;
                case 2:
                    cmbxDepoGetir();
                    break;
                case 3:
                    cmbxDepoÜrünEkleGetir();
                    break;
                case 4:
                    cmbxDepoTransferGetir();
                    break;

            }
        }

        private void ürünGetir()
        {
            pRODUCTBindingSource.DataSource = from product in db.PRODUCTs select product;
        }

        private void kategoriGetir()
        {
            cATEGORYBindingSource.DataSource = from category  in db.CATEGORies orderby category.Category_id select category;
        }

        private void cmbxKategoriGetir()
        {
            cmbxKategori.DataSource = from category in db.CATEGORies select category.CategoryName;
        }

        private void cmbxÜrünMuadilGetir()
        {
            cmbxÜrünM.DataSource = from product in db.PRODUCTs select product.ProductName;
            cmbxÜrünMuadil.DataSource = from product in db.PRODUCTs select product.ProductName;
        }

        private void cmbxDepoGetir()
        {
            cmbxDepoName.DataSource = from depo in db.DEPOs select depo.DepoName;
            
        }

        private void refreshDepo()
        {
            dEPOBindingSource.DataSource = from depo in db.DEPOs
                                           select depo;

            dEPOBindingSource.MoveFirst();
            txtDepoName.Clear();
            cmbxDepoGetir();
        }

        private void cmbxDepoÜrünEkleGetir()
        {
            cmbxDepoÜrün.DataSource = from depo in db.DEPOs select depo.DepoName;
            cmbxEkleÜrün.DataSource = from product in db.PRODUCTs select product.ProductName;
        }


        private void cmbxDepoTransferGetir()
        {
            cmbxDepoFrom.DataSource = from depo in db.DEPOs select depo.DepoName;
            cmbxDepoTo.DataSource = from depo in db.DEPOs select depo.DepoName;
            cmbxÜrünTransfer.DataSource = from product in db.PRODUCTs select product.ProductName;
        }

      

        private void btnÜrünEkle_Click(object sender, EventArgs e)
        {

            if (txtÜrün.Text == "")
            {
                errorProviderÜrünveKategoriAdı.SetError(txtÜrün, "Ürün adı bos gecilemez");
                MessageBox.Show("Ürün adını boş bırakamazsınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var sameproduct = (from same in db.PRODUCTs where txtÜrün.Text == same.ProductName select same).Count();
                if (sameproduct == 0)
                {
                    PRODUCT new_product = new PRODUCT();
                    CATEGORY category = db.CATEGORies.First(c => c.CategoryName.Equals(cmbxKategori.SelectedItem));
                    new_product.Product_id = db.PRODUCTs.Count() + 1;
                    new_product.ProductName = txtÜrün.Text;
                    new_product.Category_id = category.Category_id;
                    new_product.Quantity = (int)nmrcMiktar.Value;

                    db.PRODUCTs.InsertOnSubmit(new_product);
                    db.SubmitChanges();
                    MessageBox.Show("Ürün Basarı ile Eklendi", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtÜrün.Text = "";
                    ürünGetir();
                }
                else
                    MessageBox.Show("Bu Ürün Bulunmaktadır", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            }


        }

        private void btnÜrünGüncelle_Click(object sender, EventArgs e)
        {
            if (txtÜrün.Text == "")
            {
                errorProviderÜrünveKategoriAdı.SetError(txtÜrün, "Ürün adı bos gecilemez");
                MessageBox.Show("Ürün adını boş bırakamazsınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                    PRODUCT update_product = (from u in db.PRODUCTs
                                              where u.Product_id == Convert.ToInt32(dataGridViewÜrün.CurrentRow.Cells[0].Value)
                                              select u).SingleOrDefault();
                    CATEGORY category = db.CATEGORies.First(c => c.CategoryName.Equals(cmbxKategori.SelectedItem));

                    update_product.ProductName = txtÜrün.Text;
                    update_product.Category_id = category.Category_id;
                    update_product.Quantity = (int)nmrcMiktar.Value;

                    db.SubmitChanges();
                    MessageBox.Show("Ürün Basarı ile Güncellendi", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtÜrün.Text = "";
                    ürünGetir();
                
                
            }


        }

        private void dataGridViewÜrün_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CATEGORY category = db.CATEGORies.First(c => c.Category_id.Equals(dataGridViewÜrün.CurrentRow.Cells[2].Value));
            txtÜrün.Text = dataGridViewÜrün.CurrentRow.Cells[1].Value.ToString();
            nmrcMiktar.Value = Convert.ToDecimal(dataGridViewÜrün.CurrentRow.Cells[3].Value);
            cmbxKategori.SelectedItem = category.CategoryName;
        }

        private void btnYeniKategori_Click(object sender, EventArgs e)
        {
            if (txtYeniKategori.Text == "")
            {
                errorProviderÜrünveKategoriAdı.SetError(txtYeniKategori, "Kategori adı bos gecilemez");
                MessageBox.Show("Kategori adını boş bırakamazsınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var samecategory = (from same in db.CATEGORies where txtYeniKategori.Text == same.CategoryName select same).Count();
                if (samecategory == 0)
                {
                    CATEGORY new_category = new CATEGORY();

                    new_category.CategoryName = txtYeniKategori.Text;
                    new_category.Category_id = db.CATEGORies.Count() + 1;

                    db.CATEGORies.InsertOnSubmit(new_category);
                    db.SubmitChanges();

                    MessageBox.Show("Kategori Basarı ile Eklendi", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtYeniKategori.Text = "";

                    kategoriGetir();
                    cmbxKategoriGetir();
                }
                else
                    MessageBox.Show("Bu Kategori Bulunmaktadır", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            }
        }

        private void btnÜrünMuadil_Click(object sender, EventArgs e)
        {
            if (cmbxÜrünM.SelectedItem.Equals(cmbxÜrünMuadil.SelectedItem))
                MessageBox.Show("Aynı ürünü muadil olarak secemezsiniz", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                URUNMUADIL new_muadil = new URUNMUADIL();

                PRODUCT urun = db.PRODUCTs.First(u => u.ProductName.Equals(cmbxÜrünM.SelectedItem));
                PRODUCT urun_muadil = db.PRODUCTs.First(m => m.ProductName.Equals(cmbxÜrünMuadil.SelectedItem));
                var same_muadil = (from same in db.URUNMUADILs where same.Product_id== urun.Product_id && same.Muadil_id==urun_muadil.Product_id select same).Count();
                if (same_muadil == 0)
                {
                    new_muadil.Product_id = urun.Product_id;
                    new_muadil.Muadil_id = urun_muadil.Product_id;

                    db.URUNMUADILs.InsertOnSubmit(new_muadil);
                    db.SubmitChanges();
                    MessageBox.Show("Ürün Muadil islemi basarı ile gerceklesti.", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Bu ürün icin aynı muadil girisi yapılmıs", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDepoAra_Click(object sender, EventArgs e)
        {
            dEPOBindingSource.DataSource = from depo in db.DEPOs
                                           where depo.DepoName.StartsWith(txtDepoName.Text)
                                           select depo;

            dEPOBindingSource.MoveFirst();
        }

        private void cmbxDepoName_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDepoName.Text = (String)cmbxDepoName.SelectedItem;
        }

        private void btnBütünDepoAra_Click(object sender, EventArgs e)
        {
            refreshDepo();
        }

        private void bindingNavigatorSave_Click(object sender, EventArgs e)
        {
            Validate();
            var same_depo = (from same in db.DEPOs where depoNameTextBox.Text == same.DepoName select same).Count();
            if (same_depo == 0)
            {
                dEPOBindingSource.EndEdit();
                db.SubmitChanges();

                MessageBox.Show("Depo Basarı ile Eklendi", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                refreshDepo();
            }
            else
                MessageBox.Show("Bu Depo Bulunmaktadır", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private void btnDepoÜrünEkle_Click(object sender, EventArgs e)
        {
            DEPOCONTAIN new_contain = new DEPOCONTAIN();
            DEPO depo = db.DEPOs.First(d => d.DepoName.Equals(cmbxDepoÜrün.SelectedItem));
            PRODUCT product  = db.PRODUCTs.First (p => p.ProductName.Equals(cmbxEkleÜrün.SelectedItem));

            var same_depocontain = (from same in db.DEPOCONTAINs where same.Depo_id == depo.Depo_id && same.Product_id == product.Product_id select same).Count();
            if (same_depocontain == 0)
            {

                new_contain.Depo_id = depo.Depo_id;
                new_contain.Product_id = product.Product_id;
                new_contain.Quantity = Convert.ToInt32(nmrcÜrünEkleMiktar.Value);
                new_contain.Created_at = created_atDateTimePicker.Value;

                db.DEPOCONTAINs.InsertOnSubmit(new_contain);
                db.SubmitChanges();

                MessageBox.Show("Depoya Ürün Basarı ile Eklendi", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Bu Depoya bu ürün icin zaten giris yapılmıs", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnTransferYap_Click(object sender, EventArgs e)
        {
            if (cmbxDepoFrom.SelectedItem.Equals(cmbxDepoTo.SelectedItem))
                MessageBox.Show("Aynı depolar arası transfer gerceklestiremezsiniz!!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                MOVEMENT new_transfer = new MOVEMENT();
                DEPO depo_from = db.DEPOs.First(d => d.DepoName.Equals(cmbxDepoFrom.SelectedItem));
                DEPO depo__to = db.DEPOs.First(t => t.DepoName.Equals(cmbxDepoTo.SelectedItem));
                PRODUCT product_transfer = db.PRODUCTs.First(prt => prt.ProductName.Equals(cmbxÜrünTransfer.SelectedItem));

                var var_mı = (from x in db.DEPOCONTAINs where x.Depo_id == depo_from.Depo_id && x.Product_id == product_transfer.Product_id select x).Count();
                if (var_mı == 0)
                    MessageBox.Show("Böyle bir depo ya da depoda böyle bir ürün yok!!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {


                    DEPOCONTAIN isvalid = db.DEPOCONTAINs.First(v => v.Depo_id.Equals(depo_from.Depo_id) && v.Product_id.Equals(product_transfer.Product_id));

                    if (isvalid.Quantity >= (int)nmrcÜrünTransferMiktar.Value)
                    {
                        new_transfer.From_move = depo_from.Depo_id;
                        new_transfer.to_move = depo__to.Depo_id;
                        new_transfer.Product_id = product_transfer.Product_id;
                        new_transfer.Quantity = Convert.ToInt32(nmrcÜrünTransferMiktar.Value);
                        new_transfer.Created_at = dateÜrünTransfer.Value;

                        db.MOVEMENTs.InsertOnSubmit(new_transfer);
                        db.SubmitChanges();
                        MessageBox.Show("Transfer Basarı ile Gerceklesti", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("TRANSFER GERCEKLESTİRİLEMİYOR!! DEPODA BU URUN İCİN YETERLİ MİKTAR YOK!!!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void txtYeniKategori_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == false && e.KeyChar != (char)08 && e.KeyChar != (char)44)
            {
                e.Handled = true;
                MessageBox.Show("Sadece Harf Girişi Yapabilirsiniz ! ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }    
        }

        

        
    
    }
}
