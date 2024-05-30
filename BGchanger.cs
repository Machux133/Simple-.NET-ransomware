using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;


namespace WinFormsApp1
{
   
    class BGchanger
    {
        public const int SPI_SETDESKWALLPAPER = 20;
        public const int SPIF_UPDATEINFILE  = 1;
        public const int SPIF_SENDCHANGE = 2;
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int SystemParametersInfo(int uAction, int uPAram, String lpvParam, int fuWinIni);
        static public void bgchange() {
            string tempPath = Path.Combine(Path.GetTempPath(), "image.jpg");
            Bitmap bitmap = Properties.Resources.image;

            // Save the bitmap to a temporary file
            bitmap.Save(tempPath, System.Drawing.Imaging.ImageFormat.Jpeg);
            //using (MemoryStream ms = new MemoryStream(Properties.Resources.image))
            //  String path = @".\1.jpg";
            SystemParametersInfo(SPI_SETDESKWALLPAPER,0,tempPath,SPIF_UPDATEINFILE | SPIF_SENDCHANGE);
        }
        static public void bgchangeBack()
        {
            string tempPath = Path.Combine(Path.GetTempPath(), "image.jpg");
            Bitmap bitmap = Properties.Resources.wallpaper10;
            bitmap.Save(tempPath, System.Drawing.Imaging.ImageFormat.Jpeg);
            SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, tempPath, SPIF_UPDATEINFILE | SPIF_SENDCHANGE);
        }
    }
}
