using System.Drawing.Imaging;

namespace ComputerVision2
{
    public partial class Form1 : Form
    {
        private Image selezionata;
        private Bitmap sintetica;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAnalizza_Click(object sender, EventArgs e)
        {
            Bitmap originale = (Bitmap)selezionata;
            sintetica = new Bitmap(originale.Width, originale.Height);
            for (int x = 0; x < originale.Size.Width; x++)
            {
                for (int y = 0; y < originale.Size.Height; y++)
                {
                    Color colore = originale.GetPixel(x, y);
                    float hue = colore.GetHue();
                    float lumiosità = colore.GetBrightness() * 100;
                    if (hue > TrkMinimo.Value && hue < TrkMassimo.Value && lumiosità < TrkLight.Value)
                    {
                        sintetica.SetPixel(x, y, Color.White);
                    }
                    else
                    {
                        sintetica.SetPixel(x, y, Color.Black);
                    }
                }
            }
            sintetica.Save("sintentica.jpg", ImageFormat.Jpeg);
            PctPreview.Image = sintetica;
        }

        private void BtnApri_Click(object sender, EventArgs e)
        {
            if (DlgApri.ShowDialog() == DialogResult.OK)
            {
                selezionata = Image.FromFile(DlgApri.FileName);
                PctPreview.Image = selezionata;
            }
        }

        private void BtnContorni_Click(object sender, EventArgs e)
        {
            if(sintetica == null)
            {
                MessageBox.Show("Sarà prima il caso che tu analizzi un'immagine");
                return;
            }

            Bitmap bordi = new Bitmap(sintetica.Width, sintetica.Height);

            for(int y=1; y < sintetica.Height; y++)
            {
                for(int x=0; x < sintetica.Width; x++)
                {
                    //delta = attuale - precedente
                    Color attuale = sintetica.GetPixel(x, y);
                    Color precedente = sintetica.GetPixel(x, y - 1);
                    int delta = attuale.R - precedente.R; // Abs(-255 >> 0 >> 255) => (0 >> 255)
                    if (delta != 0)
                        bordi.SetPixel(x, y, Color.White);
                    else
                        bordi.SetPixel(x, y, Color.Black);
                }
            }
            PctPreview.Image = bordi;
        }
    }
}
