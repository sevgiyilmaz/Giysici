using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Giysici
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] Bedenler = { "Xs", "S", "M", "L", "XL", "2XL", "3XL" };
        string[] Markalar = { "LcWaikiki", "Levis", "Mavi", "Zara", "Koton", "Decathlon", "Oysho", "PullandBear", "Defacto", "Ramsey", "HandM" };
        string[] Turler = { "Pantolon", "Elbise", "Bluz", "Gömlek", "Etek", "Tulum", "T-Shirt", "Şort", "Takım Elbise", "Şapka", "Ayakkabı", "Kemer" };

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbBeden.Items.AddRange(Bedenler);
            cmbMarka.Items.AddRange(Markalar);
            cmbTur.Items.AddRange(Turler);
            MevsimBulucu();
        }
        void MevsimBulucu()
        {
            switch (DateTime.Now.Month)
            {
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                    rbYazlik.Checked = true;
                    break;
                case 9:
                case 10:
                case 11:
                case 12:
                case 1:
                case 2:
                    rbKislik.Checked = true;
                    break;
                default:
                    break;
            }
        }
        
        Product yeniUrun = null;
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            if (cmbBeden.SelectedIndex==-1||cmbMarka.SelectedIndex==-1||cmbTur.SelectedIndex==-1)
            {
                MessageBox.Show("Marka,Beden veya Tür seçenekelerinden en az biri seçili değildir.");
                return;
            }
            yeniUrun = new Product();
            yeniUrun.Beden = cmbBeden.SelectedItem.ToString();
            yeniUrun.Marka = cmbMarka.SelectedItem.ToString();
            yeniUrun.Tur = cmbTur.SelectedItem.ToString();
            yeniUrun.Yazlık = rbYazlik.Checked ? true : false;
            string renkler = "";
            foreach (CheckBox chb in groupBox1.Controls)
            {
                if (chb.Checked)
                {
                    renkler += chb.Text + ",";
                }
            }
            yeniUrun.Renkler = renkler.TrimEnd(',');
            yeniUrun.Adet = Convert.ToInt32(nudAdet.Value);
            lblTutar.Text = $"Toplam:{yeniUrun.AraToplam.ToString("c2")}";
        }

        private void btnSepeteEkle_Click(object sender, EventArgs e)
        {
            if (yeniUrun==null)
            {
                MessageBox.Show("Önce Eklemek İstediğiniz Ürünün Bilgilerini Girerek Hesapla Butonuna Basınız...");
                return;
            }
            listBox1.Items.Add(yeniUrun);
            FormuIlkHalineDondur(this);
        }
        //Recursive Metot(Özyenilemeli metot)=Metodun içerisindwe kendini çağırması.
        void FormuIlkHalineDondur(Control ctrls)
        {
            foreach (Control item in ctrls.Controls)
            {
                if (item is ComboBox)
                {
                    (item as ComboBox).SelectedIndex = -1;
                }
                else if (item is CheckBox)
                {
                    (item as CheckBox).Checked = false;
                }
                else if(item is GroupBox)
                {
                    GroupBox renkler = item as GroupBox;
                    if (renkler.Controls.Count>0)
                    {
                        FormuIlkHalineDondur(renkler);
                    }
                }
                else if (item is RadioButton)
                {
                    MevsimBulucu();
                }
                else if (item is NumericUpDown)
                {
                    (item as NumericUpDown).Value = 1;
                }
            }
            lblTutar.Text= "Tutar:_______ ₺";
        }

        private void btnSiparisiOnayla_Click(object sender, EventArgs e)
        {
            int toplamAdet = 0;
            decimal toplamTutar = 0;
            foreach (Product urun in listBox1.Items)
            {
                toplamAdet += urun.Adet;
                toplamTutar += urun.AraToplam;
            }
            lblToplamTutar.Text = $"Toplam Tutar: {toplamTutar.ToString("C2")}";
            MessageBox.Show($"Siparişinizdeki Urun Adet Bilgisi :{toplamAdet}\nSiparişiniz Toplam Tutar Bilgisi:{toplamTutar.ToString("C2")}", "Sipariş Özeti", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Product u = listBox1.SelectedItem as Product;
            MessageBox.Show($"{u.Marka}\n{u.Tur}\n{u.Fiyat}\n{u.Adet}\n{u.AraToplam}");
        }
    }
}
