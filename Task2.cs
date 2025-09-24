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
            img.Lock();

            for(int x = 0; x < img.Width; x++)
            {
                for(int y = 0; y < img.Height; y++)
                {
                    var (r, g, b) = img.GetRGB(x, y);
                    updateDict(res, (COLOR.R, r));
                    updateDict(res, (COLOR.G, g));
                    updateDict(res, (COLOR.B, b));
                }
            }

            img.Unlock();
            return res;
        }
    }
}
