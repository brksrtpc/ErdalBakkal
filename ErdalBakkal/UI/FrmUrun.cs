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
    public partial class FrmUrun : Form
    {
        public FrmUrun()
        {
            InitializeComponent();
        }
         private void btncancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        public Urun Urun { get; set; }
        public bool Guncelleme { get; set; } = false;
       
        private void btnok_Click(object sender, EventArgs e)
        {

            if (!ErrorControl(txturad)) return;
            if (!ErrorControl(cbkategori)) return;
            if (!ErrorControl(nmfiyat)) return;
            if (!ErrorControl(nmstok)) return;
            if (!ErrorControl(cbmiktar)) return;
            if (!ErrorControl(txtdetay)) return;

            Urun.Ad = txturad.Text;
            Urun.Kategori = cbkategori.Text;
            Urun.Fiyat = (double)nmfiyat.Value;
            Urun.Stok = (double)nmstok.Value;
            Urun.Miktar = cbmiktar.Text;
            Urun.Detay = txtdetay.Text;


            DialogResult = DialogResult.OK;
        }
        private bool ErrorControl(Control c)
        {
            if (c is TextBox || c is ComboBox)
            {
                if (c.Text == "")
                {
                    errorProvider1.SetError(c, "Eksik veya hatalı bilgi");
                    c.Focus();
                    return false;
                }
                else
                {
                    errorProvider1.SetError(c, "");
                    return true;

                }
            }

            if (c is NumericUpDown)
            {
                if (((NumericUpDown)c).Value == 0)
                {
                    errorProvider1.SetError(c, "Eksik veya hatalı bilgi");
                    c.Focus();
                    return false;
                }
                else
                {
                    errorProvider1.SetError(c, "");
                    return true;

                }
            }

            return true;

        }

        
    }
}
