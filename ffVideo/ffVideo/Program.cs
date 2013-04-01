﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;

namespace ffVideo
{
    class Testffmpeg
    {

        static void Main(string[] args)
        {
            string mpegpath = @"E:\Csharp\ffvideo\";
            string ffmpegPath = Path.Combine(mpegpath, "ffmpeg.exe");
            string inputMovie = @"E:\Csharp\ffvideo\test.mp4";
            string parameters = string.Format("-i {0} -f image2 E:\\Csharp\\ffvideo\\frames\\frame-%1d.png", inputMovie);
            Process proc = new Process();
            proc.StartInfo.FileName = ffmpegPath;
            proc.StartInfo.UseShellExecute = false;
            proc.StartInfo.Arguments = parameters;
            proc.Start();     
         
        }
    }
}
