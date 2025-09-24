using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace CS332_Lab2
{
    public static class Task2
    {
        public enum COLOR { R, G, B };
        public static MyImage RImage = null;
        public static MyImage GImage = null;
        public static MyImage BImage = null;
        public static void updateDict<T>(Dictionary<T, int> dict, T key)
        {
            if (dict.ContainsKey(key))
            {
                dict[key]++;
            }
            else
            {
                dict[key] = 1;
            }
        }

        public static Dictionary<(COLOR, int), int> extractRGB(MyImage img)
        {
            Dictionary<(COLOR, int), int> res = new Dictionary<(COLOR, int), int>();
            RImage = new MyImage(new Bitmap(img.Img));
            GImage = new MyImage(new Bitmap(img.Img));
            BImage = new MyImage(new Bitmap(img.Img));

            img.Lock();
            RImage.Lock();
            GImage.Lock();
            BImage.Lock();

            for (int x = 0; x < img.Width; x++)
            {
                for(int y = 0; y < img.Height; y++)
                {
                    var (r, g, b) = img.GetRGB(x, y);
                    updateDict(res, (COLOR.R, r));
                    RImage.SetPixel(x, y, (r, 0, 0));

                    updateDict(res, (COLOR.G, g));
                    GImage.SetPixel(x, y, (0, g, 0));

                    updateDict(res, (COLOR.B, b));
                    BImage.SetPixel(x, y, (0, 0, b));
                }
            }

            img.Unlock();
            RImage.Unlock();
            GImage.Unlock();
            BImage.Unlock();

            return res;
        }
    }
}
