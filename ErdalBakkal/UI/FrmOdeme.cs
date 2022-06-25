using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ErdalBakkal.UI
{
    public partial class FrmOdeme : Form
    {
        private Odeme odeme;

        public FrmOdeme()
        {
            InitializeComponent();
        }
        private void btncancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        public Odeme Odeme { get; set; }
        public bool Guncelleme { get; set; } = false;
        private void btnok_Click(object sender, EventArgs e)
        {
            if (nmtutar.Value == 0)
            {
                errorProvider1.SetError(nmtutar, "Lütfen bir tutar giriniz");
                nmtutar.Focus();
                return;

            }
            else
            {
                errorProvider1.SetError(nmtutar, "");
            }
            if (cbtur.SelectedItem == null)
            {
                errorProvider1.SetError(cbtur, "Ödeme türü seçiniz!!");
                cbtur.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(cbtur, "");
            }

            if (txtaciklama.Text == "")
            {
                errorProvider1.SetError(txtaciklama, "Bir açıklama giriniz");
                txtaciklama.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(txtaciklama, "");
            }

            Odeme.Tur = cbtur.SelectedItem.ToString();
            Odeme.Tutar = (double)nmtutar.Value;
            Odeme.Aciklama = txtaciklama.Text;
            Odeme.Tarih = dttarih.Value;

            DialogResult = DialogResult.OK;


        }


    }
}
