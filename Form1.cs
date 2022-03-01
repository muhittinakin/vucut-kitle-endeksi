using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VucutKitleİndexHesap
{
    public partial class VKI : Form
    {
        public VKI()
        {
            InitializeComponent();
        }
        private void sadeceSayiGirme(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
         
        }

        private void button_hesapla_Click(object sender, EventArgs e)
        {
           
                double boy = Convert.ToDouble(textBox1.Text.Insert(1, ","));
                int kg = Convert.ToInt32(textBox2.Text);
                int sonuc = Convert.ToInt32(kg / (boy * boy));
            if (sonuc > 15 && sonuc < 20) MessageBox.Show("Biraz zayıfsınız. Beslenmenizi arttırmanız gerekli");
            if (sonuc > 20 && sonuc < 25) MessageBox.Show("İdeal Kilodasınız");
            if (sonuc > 25 && sonuc < 30) MessageBox.Show("Fazla kilonuz bulunuyor. Beslenmenizi arttırmayınız.");
            if (sonuc > 30 && sonuc < 40) MessageBox.Show("Obezsiniz. Beslenmenize dikkat etmelisiniz.");
            if (sonuc > 40) MessageBox.Show("Aşırı obezsiniz. Beslenmenize dikkat etmelisiniz.");
   
        }
        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            LblSonuc.Text = "";


        }
    }
}
