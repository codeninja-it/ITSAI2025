using Accord.Video;

MJPEGStream video = new MJPEGStream("https://video.autostrade.it/video-mp4_hq/dt4/53c1cb2d-9a8d-4882-b3e5-dab0528ebe5d-29.mp4");

video.NewFrame += Video_NewFrame;

video.Start();

void Video_NewFrame(object sender, NewFrameEventArgs eventArgs)
{
    Console.WriteLine(video.FramesReceived);
}