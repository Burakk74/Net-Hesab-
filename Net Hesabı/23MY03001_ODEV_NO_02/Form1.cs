using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _23MY03001_ODEV_NO_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double toplam_net;
        

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {

            int turkce_dogru_sayisi = Convert.ToInt32(turkce_dogru.Text);
            int turkce_yanlis_sayisi = Convert.ToInt32(turkce_yanlis.Text);
           
            int sosyal_dogru_sayisi = Convert.ToInt32(sosyal_dogru.Text);
            int sosyal_yanlis_sayisi = Convert.ToInt32(sosyal_yanlis.Text);

            int mat_dogru_sayisi = Convert.ToInt32(matematik_dogru.Text);
            int mat_yanlis_sayisi = Convert.ToInt32(matematik_yanlis.Text);

            int fen_dogru_sayisi = Convert.ToInt32(fen_dogru.Text);
            int fen_yanlis_sayisi = Convert.ToInt32(fen_yanlis.Text);
            
            double turkce_net = turkce_dogru_sayisi - (0.25 * turkce_yanlis_sayisi);
            turkce_net_lbl.Text =Convert.ToString(turkce_net);

            double sosyal_net = sosyal_dogru_sayisi - (0.25 * sosyal_yanlis_sayisi);
            sosyal_net_lbl.Text = Convert.ToString(sosyal_net);

            double matematik_net = mat_dogru_sayisi - (0.25 * mat_yanlis_sayisi);
            matematik_net_lbl.Text = Convert.ToString (matematik_net);

            double fen_net = fen_dogru_sayisi - (0.25 * fen_yanlis_sayisi);
            fen_net_lbl.Text = Convert.ToString(fen_net);

            toplam_net = turkce_net + sosyal_net + matematik_net + fen_net;

            label14.Text = Convert.ToString(toplam_net);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lütfen alanları doldurduğunuzdan emin olun");
            }


        }
    }
}
