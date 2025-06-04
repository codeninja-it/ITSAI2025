using ComputerVision1.Strutture;
using System.Drawing.Imaging;

namespace ComputerVision1
{
    public partial class Form1 : Form
    {
        private string[] argomenti;

        public Form1(string[] inIngresso)
        {
            InitializeComponent();
            argomenti = inIngresso;
            BtnCalcola.Text = "Apri immagine";
        }

        private void BtnCalcola_Click(object sender, EventArgs e)
        {
            if(DlgApri.ShowDialog() == DialogResult.OK)
            {
                PctPreview.Image =
                    Image.FromFile(DlgApri.FileName);
                Bitmap immagine = (Bitmap)PctPreview.Image;
                PercentualeColori colori = Scomponi(immagine);
                TxtRisultato.Text += $"Immagine caricata nelle dimensioni {PctPreview.Size}!";
                TxtRisultato.Text += $"Rosso:\t{colori.PercR}";
                TxtRisultato.Text += $"Verde:\t{colori.PercG}";
                TxtRisultato.Text += $"Blu:\t{colori.PercB}";
            }
        }

        private PercentualeColori Scomponi(Bitmap target)
        {
            Bitmap canaleR = new Bitmap(target.Width, target.Height);
            Bitmap canaleG = new Bitmap(target.Width, target.Height);
            Bitmap canaleB = new Bitmap(target.Width, target.Height);
            PercentualeColori risultato = new PercentualeColori(target.Size);
            for(int x=0; x < target.Width; x++)
            {
                for(int y=0; y < target.Height; y++)
                {
                    Color casella = target.GetPixel(x, y);
                    risultato.R += casella.R;
                    risultato.G += casella.G;
                    risultato.B += casella.B;
                    if(casella.R > TrkSoglia.Value)
                        canaleR.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                    if(casella.G > TrkSoglia.Value)
                        canaleG.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                    if(casella.B > TrkSoglia.Value)
                        canaleB.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                }
            }
            canaleR.Save("canaleR.jpg", ImageFormat.Jpeg);
            canaleG.Save("canaleG.jpg", ImageFormat.Jpeg);
            canaleB.Save("canaleB.jpg", ImageFormat.Jpeg);
            return risultato;
        }
    }
}
