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
    public partial class FrmMusteri : Form
    {
        public FrmMusteri()
        {
            InitializeComponent();
        }
        
        public Musteri Musteri { get; set; }
        public bool Guncelleme { get; set; } = false;
        private void btnok_Click(object sender, EventArgs e)
        { 
            if (!ErrorControl(txtad)) return;
            if (!ErrorControl(txtsoyad)) return;
            if (!ErrorControl(txtmail)) return;
            if (!ErrorControl(txtadres)) return;

            Musteri.Ad = txtad.Text;
            Musteri.Soyad = txtsoyad.Text;
            Musteri.Mail = txtmail.Text;
            Musteri.Adres = txtadres.Text;

            DialogResult = DialogResult.OK;
        }

        private bool ErrorControl(Control c)
        {
            if (c is TextBox)
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

            if (c is MaskedTextBox)
            {
                if (!((MaskedTextBox)c).MaskFull)
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

        private void btncancel_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
