//MJPEGStream video = new MJPEGStream("https://video.autostrade.it/video-mp4_hq/dt4/53c1cb2d-9a8d-4882-b3e5-dab0528ebe5d-29.mp4");
using Emgu.CV;
using System.Drawing.Imaging;

if (!Directory.Exists("sintetiche"))
    Directory.CreateDirectory("sintetiche");

VideoCapture video = new VideoCapture("https://video.autostrade.it/video-mp4_hq/dt4/53c1cb2d-9a8d-4882-b3e5-dab0528ebe5d-29.mp4");
Mat frame = new Mat();
int i = 0;
while (video.Grab())
{
    video.Retrieve(frame);
    CvInvoke.CvtColor(frame, frame, Emgu.CV.CvEnum.ColorConversion.Rgb2Hls);
    //CvInvoke.CvtColor(frame, frame, Emgu.CV.CvEnum.ColorConversion.Rgb2Gray);

    frame
        .ToBitmap()
        .Save(
            Path.Combine("sintetiche", $"f_{i}.jpg"),
            ImageFormat.Jpeg
        );
    i++;
}