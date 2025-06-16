using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.Util;

namespace ComputerVision3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnVideo_Click(object sender, EventArgs e)
        {
            if (DlgVideo.ShowDialog() == DialogResult.OK)
            {
                TxtVideo.Text = DlgVideo.FileName;
            }
        }

        private void BtnSintetiche_Click(object sender, EventArgs e)
        {
            if(DlgCartella.ShowDialog() == DialogResult.OK)
            {
                TxtSintetiche.Text = DlgCartella.SelectedPath;
            }
        }

        private Mat PrelevaFotogramma(VideoCapture video)
        {
            if (!video.Grab())
                return null;
            Mat appoggio = new Mat();
            video.Retrieve(appoggio);
            CvInvoke.CvtColor(appoggio, appoggio, ColorConversion.Rgb2Gray);
            CvInvoke.GaussianBlur(appoggio, appoggio, new Size(3, 3), 1);
            return appoggio;
        }

        private void BtnPreview_Click(object sender, EventArgs e)
        {
            using (VideoCapture video = new VideoCapture(TxtVideo.Text))
            {
                Mat prima = PrelevaFotogramma(video);
                Mat seconda = PrelevaFotogramma(video);
                if(prima != null && seconda != null)
                {
                    CvInvoke.AbsDiff(seconda, prima, seconda);
                    CvInvoke.Threshold(seconda, seconda, TrkThreshold.Value, 255, ThresholdType.Otsu);
                    
                    VectorOfVectorOfPoint contorni = new VectorOfVectorOfPoint();
                    CvInvoke.FindContours(seconda, contorni, null, RetrType.List, ChainApproxMethod.ChainApproxSimple);
                    List<VectorOfPoint> candidati = new List<VectorOfPoint>();
                    for(int i=0; i < contorni.Size; i++)
                    {
                        // se estraggo un contorno per volta
                        VectorOfPoint contorno = contorni[i];
                        VectorOfPoint semplificata = new VectorOfPoint();
                        CvInvoke.ApproxPolyDP( // per semplificarla
                            contorno, // come origine
                            semplificata, // nella destinazione
                            CvInvoke.ArcLength(contorno, true) * 0.05, // ottenendo il 5% della lunghezza
                            true // dammi solo forme chiuse
                        );
                        candidati.Add( semplificata );
                    }

                    foreach(VectorOfPoint singolo in candidati.Where(x => x.Size == 4))
                    {
                        Console.WriteLine(singolo.ToString());
                        Rectangle envelope = new Rectangle(
                                    
                        );
                        //CvInvoke.Rectangle(
                        //    seconda,
                        //    new Rectangle()
                        //);
                    }

                    PctPreview.Image = seconda.ToBitmap();
                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DlgVideo.Filter = "File MP4|*.mp4|Tutti i files|*.*";
            DlgVideo.Title = "Seleziona file video";
            DlgVideo.FileName = "c:\\";
        }
    }
}
