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
            //CvInvoke.GaussianBlur(appoggio, appoggio, new Size(3, 3), 1);
            return appoggio;
        }

        private void BtnPreview_Click(object sender, EventArgs e)
        {
            using (VideoCapture video = new VideoCapture(TxtVideo.Text))
            {
                Mat vecchia = new Mat();
                while(video.Grab())
                {
                    Mat aColori = new Mat();
                    video.Retrieve(aColori);
                    Mat attuale = new Mat();
                    CvInvoke.CvtColor(aColori, attuale, ColorConversion.Rgb2Gray);
                    if (!vecchia.IsEmpty)
                    {
                        CvInvoke.Threshold(attuale, attuale, (double)TrkThreshold.Value, 255, ThresholdType.Binary);
                        Mat differenza = new Mat();
                        CvInvoke.AbsDiff(attuale, vecchia, differenza);
                        
                        VectorOfVectorOfPoint contorni = new VectorOfVectorOfPoint();
                        CvInvoke.FindContours(differenza, contorni, null, RetrType.List, ChainApproxMethod.ChainApproxSimple);
                        List<VectorOfPoint> candidati = new List<VectorOfPoint>();
                        for (int i = 0; i < contorni.Size; i++)
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
                            candidati.Add(semplificata);
                        }

                        foreach (VectorOfPoint singolo in candidati.Where(x => x.Size == 4))
                        {
                            Point[] vertici = singolo.ToArray();
                            Rectangle envelope = new Rectangle(
                                vertici.Min(p => p.X),
                                vertici.Min(p => p.Y),
                                vertici.Max(p => p.X) - vertici.Min(p => p.X),
                                vertici.Max(p => p.Y) - vertici.Min(p => p.Y)
                            );
                            if (envelope.Width * envelope.Height > TrkArea.Value)
                                CvInvoke.Rectangle(
                                    aColori,
                                    envelope,
                                    new MCvScalar(0, 0, 200)
                                );
                        }

                        PctPreview.Image = aColori.ToBitmap();
                        PctPreview.Invalidate();
                        Application.DoEvents();
                    }
                    vecchia = attuale;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TxtVideo.Text = "https://video.autostrade.it/video-mp4_hq/dt4/53c1cb2d-9a8d-4882-b3e5-dab0528ebe5d-29.mp4";
            DlgVideo.Filter = "File MP4|*.mp4|Tutti i files|*.*";
            DlgVideo.Title = "Seleziona file video";
            DlgVideo.FileName = "c:\\";
        }
    }
}
