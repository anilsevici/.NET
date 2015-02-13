namespace DepoTakip
{
    partial class UsSorgu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tbControlPersonel = new System.Windows.Forms.TabControl();
            this.tbpgSorgu = new System.Windows.Forms.TabPage();
            this.dataGridViewSorgu = new System.Windows.Forms.DataGridView();
            this.cmbxSorgu = new System.Windows.Forms.ComboBox();
            this.tbpgKullanıcıEkle = new System.Windows.Forms.TabPage();
            this.chckAdmin = new System.Windows.Forms.CheckBox();
            this.btnKayıt = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtCalısan = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAdress = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CalısanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbControlPersonel.SuspendLayout();
            this.tbpgSorgu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSorgu)).BeginInit();
            this.tbpgKullanıcıEkle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CalısanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tbControlPersonel
            // 
            this.tbControlPersonel.Controls.Add(this.tbpgSorgu);
            this.tbControlPersonel.Controls.Add(this.tbpgKullanıcıEkle);
            this.tbControlPersonel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbControlPersonel.Location = new System.Drawing.Point(3, 20);
            this.tbControlPersonel.Name = "tbControlPersonel";
            this.tbControlPersonel.SelectedIndex = 0;
            this.tbControlPersonel.Size = new System.Drawing.Size(1140, 530);
            this.tbControlPersonel.TabIndex = 0;
            // 
            // tbpgSorgu
            // 
            this.tbpgSorgu.BackColor = System.Drawing.Color.Azure;
            this.tbpgSorgu.Controls.Add(this.pictureBox4);
            this.tbpgSorgu.Controls.Add(this.pictureBox3);
            this.tbpgSorgu.Controls.Add(this.pictureBox2);
            this.tbpgSorgu.Controls.Add(this.dataGridViewSorgu);
            this.tbpgSorgu.Controls.Add(this.cmbxSorgu);
            this.tbpgSorgu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbpgSorgu.Location = new System.Drawing.Point(4, 29);
            this.tbpgSorgu.Name = "tbpgSorgu";
            this.tbpgSorgu.Padding = new System.Windows.Forms.Padding(3);
            this.tbpgSorgu.Size = new System.Drawing.Size(1132, 497);
            this.tbpgSorgu.TabIndex = 0;
            this.tbpgSorgu.Text = "SORGULAMALAR";
            // 
            // dataGridViewSorgu
            // 
            this.dataGridViewSorgu.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridViewSorgu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSorgu.Location = new System.Drawing.Point(6, 79);
            this.dataGridViewSorgu.Name = "dataGridViewSorgu";
            this.dataGridViewSorgu.Size = new System.Drawing.Size(1120, 277);
            this.dataGridViewSorgu.TabIndex = 1;
            // 
            // cmbxSorgu
            // 
            this.cmbxSorgu.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmbxSorgu.FormattingEnabled = true;
            this.cmbxSorgu.Items.AddRange(new object[] {
            "Calısanları Görüntüle",
            "Depodan Sorumlu Calısanları ve Depo İsimlerini Görüntüle",
            "Depolar Arası Hareketleri Görüntüle",
            "Bütün Ürünlerin Muadillerini Görüntüle",
            "Bütün Depoların İcereklerini Görüntüle",
            "Deposundaki Ürünlerden stok miktarı 10 un altına düsmüs bütün Depo isimlerini,Ürü" +
                "nlerini ve Miktarını Görüntüle"});
            this.cmbxSorgu.Location = new System.Drawing.Point(3, 3);
            this.cmbxSorgu.Name = "cmbxSorgu";
            this.cmbxSorgu.Size = new System.Drawing.Size(1126, 32);
            this.cmbxSorgu.TabIndex = 0;
            this.cmbxSorgu.SelectedIndexChanged += new System.EventHandler(this.cmbxSorgu_SelectedIndexChanged);
            // 
            // tbpgKullanıcıEkle
            // 
            this.tbpgKullanıcıEkle.BackColor = System.Drawing.Color.Azure;
            this.tbpgKullanıcıEkle.Controls.Add(this.pictureBox1);
            this.tbpgKullanıcıEkle.Controls.Add(this.chckAdmin);
            this.tbpgKullanıcıEkle.Controls.Add(this.btnKayıt);
            this.tbpgKullanıcıEkle.Controls.Add(this.txtEmail);
            this.tbpgKullanıcıEkle.Controls.Add(this.txtAd);
            this.tbpgKullanıcıEkle.Controls.Add(this.txtSoyad);
            this.tbpgKullanıcıEkle.Controls.Add(this.txtPhone);
            this.tbpgKullanıcıEkle.Controls.Add(this.txtAdress);
            this.tbpgKullanıcıEkle.Controls.Add(this.txtUsername);
            this.tbpgKullanıcıEkle.Controls.Add(this.txtPassword);
            this.tbpgKullanıcıEkle.Controls.Add(this.txtCalısan);
            this.tbpgKullanıcıEkle.Controls.Add(this.lblEmail);
            this.tbpgKullanıcıEkle.Controls.Add(this.lblAdress);
            this.tbpgKullanıcıEkle.Controls.Add(this.lblTelefon);
            this.tbpgKullanıcıEkle.Controls.Add(this.lblUsername);
            this.tbpgKullanıcıEkle.Controls.Add(this.lblPassword);
            this.tbpgKullanıcıEkle.Controls.Add(this.lblSoyad);
            this.tbpgKullanıcıEkle.Controls.Add(this.lblAd);
            this.tbpgKullanıcıEkle.Controls.Add(this.label1);
            this.tbpgKullanıcıEkle.Location = new System.Drawing.Point(4, 29);
            this.tbpgKullanıcıEkle.Name = "tbpgKullanıcıEkle";
            this.tbpgKullanıcıEkle.Padding = new System.Windows.Forms.Padding(3);
            this.tbpgKullanıcıEkle.Size = new System.Drawing.Size(1132, 497);
            this.tbpgKullanıcıEkle.TabIndex = 1;
            this.tbpgKullanıcıEkle.Text = "KULLANICI EKLE";
            // 
            // chckAdmin
            // 
            this.chckAdmin.AutoSize = true;
            this.chckAdmin.Location = new System.Drawing.Point(499, 270);
            this.chckAdmin.Name = "chckAdmin";
            this.chckAdmin.Size = new System.Drawing.Size(101, 24);
            this.chckAdmin.TabIndex = 18;
            this.chckAdmin.Text = "Admin Mi";
            this.chckAdmin.UseVisualStyleBackColor = true;
            // 
            // btnKayıt
            // 
            this.btnKayıt.Location = new System.Drawing.Point(499, 331);
            this.btnKayıt.Name = "btnKayıt";
            this.btnKayıt.Size = new System.Drawing.Size(301, 65);
            this.btnKayıt.TabIndex = 17;
            this.btnKayıt.Text = "KULLANICI KAYIT EKLE";
            this.btnKayıt.UseVisualStyleBackColor = true;
            this.btnKayıt.Click += new System.EventHandler(this.btnKayıt_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(637, 212);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(163, 26);
            this.txtEmail.TabIndex = 16;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(206, 140);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(154, 26);
            this.txtAd.TabIndex = 15;
            this.txtAd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAd_KeyPress);
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(206, 224);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(154, 26);
            this.txtSoyad.TabIndex = 14;
            this.txtSoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoyad_KeyPress);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(206, 308);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(154, 26);
            this.txtPhone.TabIndex = 13;
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone_KeyPress);
            // 
            // txtAdress
            // 
            this.txtAdress.Location = new System.Drawing.Point(206, 401);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(154, 26);
            this.txtAdress.TabIndex = 12;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(637, 57);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(163, 26);
            this.txtUsername.TabIndex = 11;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(637, 140);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(163, 26);
            this.txtPassword.TabIndex = 10;
            // 
            // txtCalısan
            // 
            this.txtCalısan.Location = new System.Drawing.Point(206, 54);
            this.txtCalısan.Name = "txtCalısan";
            this.txtCalısan.Size = new System.Drawing.Size(154, 26);
            this.txtCalısan.TabIndex = 9;
            this.txtCalısan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCalısan_KeyPress);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(495, 218);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(53, 20);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "Email";
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.Location = new System.Drawing.Point(59, 407);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(70, 20);
            this.lblAdress.TabIndex = 7;
            this.lblAdress.Text = "Adress:";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(59, 314);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(65, 20);
            this.lblTelefon.TabIndex = 6;
            this.lblTelefon.Text = "Phone:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(495, 57);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(91, 20);
            this.lblUsername.TabIndex = 5;
            this.lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(495, 146);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(85, 20);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "password";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(59, 230);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(100, 20);
            this.lblSoyad.TabIndex = 2;
            this.lblSoyad.Text = "Last Name:";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(59, 146);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(101, 20);
            this.lblAd.TabIndex = 1;
            this.lblAd.Text = "First Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calısan TC No:";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::DepoTakip.Properties.Resources.question_mark_man_head_symbol_small1;
            this.pictureBox4.Location = new System.Drawing.Point(841, 369);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(111, 122);
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::DepoTakip.Properties.Resources.question_mark_man_head_symbol_small1;
            this.pictureBox3.Location = new System.Drawing.Point(458, 369);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(116, 122);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DepoTakip.Properties.Resources.question_mark_man_head_symbol_small;
            this.pictureBox2.Location = new System.Drawing.Point(99, 369);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(124, 122);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DepoTakip.Properties.Resources.indir;
            this.pictureBox1.Location = new System.Drawing.Point(879, 122);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(206, 201);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // UsSorgu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbControlPersonel);
            this.Name = "UsSorgu";
            this.Size = new System.Drawing.Size(1160, 553);
            this.tbControlPersonel.ResumeLayout(false);
            this.tbpgSorgu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSorgu)).EndInit();
            this.tbpgKullanıcıEkle.ResumeLayout(false);
            this.tbpgKullanıcıEkle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CalısanBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbControlPersonel;
        private System.Windows.Forms.TabPage tbpgSorgu;
        private System.Windows.Forms.DataGridView dataGridViewSorgu;
        private System.Windows.Forms.ComboBox cmbxSorgu;
        private System.Windows.Forms.TabPage tbpgKullanıcıEkle;
        private System.Windows.Forms.BindingSource CalısanBindingSource;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblAdress;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKayıt;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtCalısan;
        private System.Windows.Forms.CheckBox chckAdmin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;

    }
}
