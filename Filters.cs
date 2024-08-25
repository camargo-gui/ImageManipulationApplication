using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ImageManipulationApplication
{
    class Filters
    {
        public static void NormalVerticalMirror(Bitmap src, Bitmap dest)
        {
            int width = src.Width;
            int height = src.Height;
            int aux = height - 1;

            for(int i = 0; i < height; i++)
            {
                for(int j = 0; j < width; j++)
                {
                    Color pixel = src.GetPixel(j, i);

                    dest.SetPixel(j, aux, pixel);
                }
                aux--;
            }
        }

        public static void VerticalMirrorDMA(Bitmap bitMapSrc, Bitmap bitMapDest)
        {
            int width = bitMapSrc.Width;
            int height = bitMapSrc.Height;
            int pixelSize = 3;

            BitmapData bitmapDataSrc = bitMapSrc.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
            BitmapData bitmapDataDest = bitMapDest.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);

            int strideSrc = bitmapDataSrc.Stride;
            int strideDest = bitmapDataDest.Stride;

            unsafe
            {
                byte* src = (byte*)bitmapDataSrc.Scan0.ToPointer();
                byte* dest = (byte*)bitmapDataDest.Scan0.ToPointer();

                for (int i = 0; i < height; i++)
                {
                    byte* srcLineStart = src + i * strideSrc;
                    byte* destLineStart = dest + (height - 1 - i) * strideDest;

                    for (int j = 0; j < width * pixelSize; j++)
                    {
                        destLineStart[j] = srcLineStart[j];
                    }
                }

                bitMapSrc.UnlockBits(bitmapDataSrc);
                bitMapDest.UnlockBits(bitmapDataDest);
            }
        }


        public static void NormalHorizontalMirror(Bitmap src, Bitmap dest)
        {
            int width = src.Width;
            int height = src.Height;
            int aux = width - 1;

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    Color pixel = src.GetPixel(i, j);

                    dest.SetPixel(aux, j, pixel);
                }
                aux--;
            }
        }
    }
}
