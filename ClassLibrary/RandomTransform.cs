using PluginInterface;
using System;
using System.Drawing;
namespace Transforms
{
    [Version(1, 0)]
    public class RandomTransform : IPlugin
    {
        public string Name
        {
            get
            {
                return "Переворот изображения";
            }
        }
        public string Author
        {
            get
            {
                return "Me";
            }
        }


        public void Transform(System.Drawing.Bitmap bitmap)
        {
            var rnd = new Random();
            int x, y;
            for (x = 0; x < bitmap.Width; x++)
                for (y = 0; y < bitmap.Height; y++)
                {
                    int q = rnd.Next(100);
                    if (q <= 40) bitmap.SetPixel(x, y, Color.Gray);
                }
        }

    }
}