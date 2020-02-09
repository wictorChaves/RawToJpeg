using ImageMagick;
using System;
using System.IO;
using System.Windows.Forms;

namespace RawToJpeg
{
    class Program
    {

        [STAThread]
        static void Main(string[] args)
        {
            var origem = "";
            var destino = "";

            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == DialogResult.OK)
                origem = fbd.SelectedPath;
            else
                Environment.Exit(0);


            if (fbd.ShowDialog() == DialogResult.OK)
                destino = fbd.SelectedPath;
            else
                Environment.Exit(0);


            Console.Write("Processando... ");
            foreach (var filePath in Directory.GetFiles(origem))
            {
                var arrayPath = filePath.Split('\\');
                var fileName = arrayPath[arrayPath.Length - 1];

                var arrayFilename = fileName.Split('.');
                var ext = arrayFilename[arrayFilename.Length - 1];
                var name = arrayFilename[0];
                var target = destino + "\\" + name + ".jpg";

                RawToJpeg(filePath, target);
            }
            Console.Write("Fim do processo");
            Console.ReadKey();
        }

        public static void RawToJpeg(string source, string target)
        {
            using (MagickImage image = new MagickImage(source))
            {
                image.Write(target);
            }
        }

    }
}
