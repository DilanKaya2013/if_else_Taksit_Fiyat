using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calısma01tar010
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double fiyat=Convert.ToDouble(txtFiyat.Text);
            double taksitTutar = 0;
            double toplamtutar = 0;

            if (rbPesin.Checked)
            {
                toplamtutar=fiyat;
            }
            else if (rbTaksit2.Checked)
            {
                toplamtutar= fiyat * 1.02;
                taksitTutar = toplamtutar / 2;
            }
            else if (rbTaksit6.Checked)
            {
                toplamtutar = fiyat * 1.06;
                taksitTutar = toplamtutar / 6;

            }
            else if (rbTaksit9.Checked)
            {
                toplamtutar = fiyat * 1.09;
                taksitTutar = toplamtutar / 9;

            }
            else if (rbTaksit12.Checked)
            {
                toplamtutar = fiyat * 1.12;
                taksitTutar = toplamtutar / 12;

            }
            lblTaksittutar.Text="Taksit Tutar: "+taksitTutar.ToString()+"₺";
            lblToplamtutar.Text = "Toplam Tutar: " + toplamtutar.ToString()+"₺";
        }
    }
}
