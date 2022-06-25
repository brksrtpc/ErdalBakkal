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
    public partial class FrmSatis : Form
    {
        public FrmSatis()
        {
            InitializeComponent();
        }

        public Satis Satis { get; set; }
        public bool Guncelleme { get; set; } = false;

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnok_Click(object sender, EventArgs e)
        {
            if (nmfiyat.Value == 0)
            {
                errorProvider1.SetError(nmfiyat, "Lütfen fiyat giriniz!");
                nmfiyat.Focus();
                return;

            }
            else
            {
                errorProvider1.SetError(nmfiyat, "");
            }

            Satis.Tarih = dttarih.Value;
            Satis.Fiyat = (double)nmfiyat.Value;
            Satis.UrunID = Guid.Parse(txtUrun.Text);
            Satis.MusteriID = Guid.Parse(txtMusteri.Text);

            DialogResult = DialogResult.OK;
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void FrmSatis_Load(object sender, EventArgs e)
        {
            txtid.Text = Satis.ID.ToString();
            if (Guncelleme)
            {
                txtMusteri.Text = Satis.MusteriID.ToString();
                txtUrun.Text = Satis.UrunID.ToString();
                nmfiyat.Value = (decimal)Satis.Fiyat;
                dttarih.Value = Satis.Tarih;
            }
        }
    }
}
