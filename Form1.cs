using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0_dan_başlayıp_sayıları_toplama_100den_fazlaolduğunda_kaç_kez_olduğunu_söyleyen_program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void btnkackezcalisti_Click(object sender, EventArgs e)
        {
            int dongu_say = 1;
            int toplam = 0;
            while (toplam <= 1000)
            {
                toplam = toplam + dongu_say;
                dongu_say += 1;
            }
            MessageBox.Show("Döngü toplam " + dongu_say.ToString() + " kez çalıştı");
        }
    }
}
