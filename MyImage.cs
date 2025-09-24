using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace CS332_Lab2
{
    public class MyImage
    {
        private Bitmap image;
        private BitmapData data;
        private int width;
        private int height;
        private int stride;
        private byte[] pixels;
        private int bytesPerPixel;
        private bool locked = false;

        public int Width { get { return this.width; } }
        public Bitmap Img { get { return image; } }
        public int Height { get { return this.height; } }
        public MyImage(Bitmap img) 
        { 
            this.image = img;
            this.width = img.Width;
            this.height = img.Height;
        }

        public void Lock()
        {
            data = image.LockBits(
                new Rectangle(0, 0, Width, Height),
                ImageLockMode.ReadWrite,
                image.PixelFormat);

            this.locked = true;
            this.stride = data.Stride;
            bytesPerPixel = Image.GetPixelFormatSize(image.PixelFormat) / 8;

            int bytes = Math.Abs(stride) * Height;
            pixels = new byte[bytes];
            Marshal.Copy(data.Scan0, pixels, 0, bytes);
        }

        public void Unlock()
        {
            if (!locked)
            {
                return;
            }

            Marshal.Copy(pixels, 0, data.Scan0, pixels.Length);
            Img.UnlockBits(data);

            locked = false;
            pixels = null;
        }

        public (int R, int G, int B) GetRGB(int x, int y)
        {
            if (!locked) throw new InvalidOperationException("Bitmap not locked");

            int position = y * this.stride + x * bytesPerPixel;

            byte b = pixels[position];
            byte g = pixels[position + 1];
            byte r = pixels[position + 2];
            return (r, g, b);
        }

        public void SetPixel(int x, int y, (int r, int g, int b) color)
        {
            if (!locked) throw new InvalidOperationException("Bitmap not locked");

            int position = y * this.stride + x * bytesPerPixel;

            pixels[position] = (byte) color.b;
            pixels[position + 1] = (byte) color.g;
            pixels[position + 2] = (byte)color.r;
        }
    }
}
