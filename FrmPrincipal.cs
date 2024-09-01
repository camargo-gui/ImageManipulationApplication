using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageManipulationApplication
{
    public partial class FrmPrincipal : Form
    {
        private Image image;
        private Bitmap src;
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void clickOpenImage(object sender, EventArgs e)
        {
            openFileDialog.FileName = "";
            openFileDialog.Filter = "Arquivos de Imagem (*.jpg;*.gif;*.bmp;*.png)|*.jpg;*.gif;*.bmp;*.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                image = Image.FromFile(openFileDialog.FileName);
                pictBoxImg1.Image = image;
                pictBoxImg1.SizeMode = PictureBoxSizeMode.Normal;
            }
        }

        private void clickNormalVerticalMirror(object sender, EventArgs e)
        {
            Bitmap destination = new Bitmap(image);
            src = (Bitmap)image;
            Filters.NormalVerticalMirror(src, destination);
            pictBoxImg2.Image = destination;
        }

        private void clickNormalHorizontalMirror(object sender, EventArgs e)
        {
            Bitmap destination = new Bitmap(image);
            src = (Bitmap)image;
            Filters.NormalHorizontalMirror(src, destination);
            pictBoxImg2.Image = destination;
        }

        private void clickVerticalMirrorDMA(object sender, EventArgs e)
        {
            Bitmap destination = new Bitmap(image);
            src = (Bitmap)image;
            Filters.VerticalMirrorDMA(src, destination);
            pictBoxImg2.Image = destination;
        }

        private void clickFourConected(object sender, EventArgs e)
        {
            Bitmap destination = new Bitmap(image);
            src = (Bitmap)image;
            Segmentation.FourConected(src, destination);
            pictBoxImg2.Image = destination;
        }

        private void clickEightConected(object sender, EventArgs e)
        {
            Bitmap destination = new Bitmap(image);
            src = (Bitmap)image;
            Segmentation.EightConected(src, destination);
            pictBoxImg2.Image = destination;
        }
    }
}
