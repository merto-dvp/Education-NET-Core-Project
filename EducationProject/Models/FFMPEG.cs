﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace EducationProject.Models
{
    public class FFMPEG
    {

        Process ffmpeg;

        public void exec(string input, string output, string parametri)
        {
            ffmpeg = new Process();

            ffmpeg.StartInfo.Arguments = " -i " + input + (parametri != null ? " " + parametri : "") + " " + output;
            ffmpeg.StartInfo.FileName = "~/Utilities/ffmpeg.exe";
            ffmpeg.StartInfo.UseShellExecute = false;
            ffmpeg.StartInfo.RedirectStandardOutput = true;
            ffmpeg.StartInfo.RedirectStandardError = true;
            ffmpeg.StartInfo.CreateNoWindow = true;

            ffmpeg.Start();
            ffmpeg.WaitForExit();
            ffmpeg.Close();
        }


        public void GetThumbnail(string video, string jpg, string velicina)
        {
            if (velicina == null) velicina = "320x240";
            exec(video, jpg, "-s " + velicina);
        }
    }
}
