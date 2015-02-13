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
    public partial class PersonelPanel : Form
    {
        Form previous_form;
        public PersonelPanel(Form login)
        {
            previous_form = login;
            InitializeComponent();
        }

        private void PersonelPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            previous_form.Show();
        }
    }
}
