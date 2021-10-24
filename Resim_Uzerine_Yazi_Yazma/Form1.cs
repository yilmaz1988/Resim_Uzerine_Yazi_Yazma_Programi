using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resim_Uzerine_Yazi_Yazma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string resim;
        private void BtnResimSec_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            resim = openFileDialog1.FileName;
        }
        Color renk;
        private void BtnRenk_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            renk = colorDialog1.Color;
        }
        Bitmap bmp;
        private void BtnYazdir_Click(object sender, EventArgs e)
        {
            try
            {
                bmp = new Bitmap(resim);
                Graphics gr = Graphics.FromImage(bmp);
                gr.DrawString(TxtMetin.Text, new Font("Segoe UI", Convert.ToUInt16(TxtBoyut.Text), FontStyle.Bold), new SolidBrush(renk), 20, 30);
                pictureBox1.Image = bmp;
            }
            catch (Exception)
            {

                MessageBox.Show("Tüm alanlar dolu olmalıdır..");
            }

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {

          
                    saveFileDialog1.Filter = "Resim |.jpeg";
                    saveFileDialog1.ShowDialog();
                    bmp.Save(saveFileDialog1.FileName);
             
        }

    }
}

