//MJPEGStream video = new MJPEGStream("https://video.autostrade.it/video-mp4_hq/dt4/53c1cb2d-9a8d-4882-b3e5-dab0528ebe5d-29.mp4");
using Emgu.CV;
using System.Drawing.Imaging;
using System.Runtime.CompilerServices;


if (!Directory.Exists("sintetiche"))
    Directory.CreateDirectory("sintetiche");

VideoCapture video = new VideoCapture("https://video.autostrade.it/video-mp4_hq/dt4/53c1cb2d-9a8d-4882-b3e5-dab0528ebe5d-29.mp4");
Mat sfondo = new Mat();
int i = 0;
while (video.Grab())
{
    Mat frame = new Mat();
    video.Retrieve(frame);
    CvInvoke.CvtColor(frame, frame, Emgu.CV.CvEnum.ColorConversion.Rgb2Gray);

    if (!sfondo.IsEmpty)
    {
        Mat differenza = new Mat();
        CvInvoke.AbsDiff(frame, sfondo, differenza);
        CvInvoke.Threshold(differenza, differenza, 50, 255, Emgu.CV.CvEnum.ThresholdType.Otsu);
        differenza
            .ToBitmap()
            .Save(
                Path.Combine("sintetiche", $"f_{i}.jpg"),
                ImageFormat.Jpeg
            );
    }
    i++;
    sfondo = frame;
}