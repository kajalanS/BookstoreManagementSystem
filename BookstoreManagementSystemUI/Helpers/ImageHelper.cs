using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagementSystemUI.Helpers
{
    public static class ImageHelper
    {
        public static byte[] ImageToByteArray(this Image image, ImageFormat saveFormat)
        {
            using var ms = new MemoryStream();
            image.Save(ms, saveFormat);
            return ms.ToArray();
        }

        public static Image? ByteArrayToImage(this byte[] bytes)
        {
            using var ms = new MemoryStream(bytes);
            return Image.FromStream(ms);
        }
    }
}
