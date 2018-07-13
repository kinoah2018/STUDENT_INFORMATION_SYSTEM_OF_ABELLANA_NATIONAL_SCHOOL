using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;

namespace ABELLANA_NATIONAL_SCHOOL_FINAL
{
    class Photo
    {
        public static byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }
        public static Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
        public static string byteArrayToBase64String(byte[] barry)
        {
            return Convert.ToBase64String(barry);
        }
        public static byte[] base64StringToBytetoArray(string gwapo)
        {
            return Convert.FromBase64String(gwapo);
        }
    }
}
