using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slayd_1575
{
    public partial class Form1 : Form
    {
        List<Bitmap> resimler = new List<Bitmap>();
        int sayac;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            resimler.Add(Properties.Resources._355735);
            resimler.Add(Properties.Resources._3dduvarkagitlari_66b08fac);
            resimler.Add(Properties.Resources.besiktas_vodafone_park_1557306);
            resimler.Add(Properties.Resources.resim2);
            resimler.Add(Properties.Resources.Quaresma);
            resimler.Add(Properties.Resources.Talisca);
            resimler.Add(Properties.Resources.bayrak);
            resimler.Add(Properties.Resources.Q7T94);
            resimler.Add(Properties.Resources.direek_icardi);

            timer1.Start();
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            sayac = sayac % resimler.Count;
            pictureBox1.Image = resimler[sayac];

        }
    }
}

