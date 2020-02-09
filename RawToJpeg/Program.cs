using ImageMagick;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawToJpeg
{
    class Program
    {
        static void Main(string[] args)
        {
            using (MagickImage image = new MagickImage("C:\\Users\\wictor\\Downloads\\IMG_2581.CR2"))
            {
                image.Write("C:\\Users\\wictor\\Downloads\\IMG_2581.jpg");
            }
        }
    }
}
