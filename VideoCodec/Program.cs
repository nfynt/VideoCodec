using System;
using System.Collections.Generic;
using AForge.Video.FFMPEG;
using System.Drawing;
using System.IO;
using Shubham.VideoCodecLib;

namespace VideoCodec
{
    class Program
    {
        static void Main(string[] args)
        {
            int width, height, fps;
            width = 640; height = 480;
            fps = 25;


            Console.WriteLine("Hey");

            string loc = "D:\\Shubham_Data\\VideoCodec\\VideoCodec\\bin\\x86\\Debug\\TE\\test.mp4";


            Codec cc = new Codec(width, height, fps, loc);

            if (!Directory.Exists(Path.GetDirectoryName(loc)))
                Directory.CreateDirectory(Path.GetDirectoryName(loc));

            //VideoFileWriter writer = new VideoFileWriter();
            //writer.Open(loc, width, height, fps, AForge.Video.FFMPEG.VideoCodec.MPEG4);

            for (int i = 1; i < 222; i++)
            {
                //Image img = Image.FromStream(File.Open("D:\\Shubham_Data\\VideoCodec\\ImgSamples\\img"+i.ToString()+".jpg", FileMode.Open));
                //writer.WriteVideoFrame(new Bitmap(img));
                cc.AddFrame(File.ReadAllBytes("D:\\Shubham_Data\\VideoCodec\\ImgSamples\\img" + i.ToString() + ".jpg"));
            }

            //writer.Close();
            cc.SaveVideo();

            Console.WriteLine("Done");

            Console.ReadLine();
        }
    }
}
