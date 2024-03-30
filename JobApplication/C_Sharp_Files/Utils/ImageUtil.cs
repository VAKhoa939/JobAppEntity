using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobApplication
{
    static class ImageUtil
    {
        public static Image ByteToImage(byte[] bytes)
        {
            MemoryStream memoryStream = new MemoryStream(bytes);
            return Image.FromStream(memoryStream);
        }
    }
}
