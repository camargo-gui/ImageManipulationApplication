using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;

namespace ImageManipulationApplication
{
    class PixelUtil
    {
        public static bool isBlack(Color color)
        {
            return color.R == 0 && color.G == 0 && color.B == 0;
        }

        public static bool isWhite(Color color)
        {
            return color.R == 255 && color.G == 255 && color.B == 255;
        }

        public static bool hasTransition(Color color1, Color color2)
        {
            return  isWhite(color1) && isBlack(color2);
        }

        public static Color[] GetNeighbords(Bitmap image, Point point)
        {
            int x = point.X, y = point.Y;
            return new Color[]
            {
                image.GetPixel(x - 1, y - 1),
                image.GetPixel(x, y - 1),
                image.GetPixel(x + 1, y - 1),
                image.GetPixel(x + 1, y),
                image.GetPixel(x + 1, y + 1),
                image.GetPixel(x, y + 1),
                image.GetPixel(x - 1, y + 1),
                image.GetPixel(x - 1, y)
            };
        }

        public static Point[] GetNeighbordsPoints(Bitmap image, Point point)
        {
            int x = point.X, y = point.Y;
            return new Point[]
            {
                new(x - 1, y - 1),
                new(x, y - 1),
                new(x + 1, y - 1),
                new(x + 1, y),
                new(x + 1, y + 1),
                new(x, y + 1),
                new(x - 1, y + 1),
                new(x - 1, y)
            };
        }

        public static Point[] GetAntiClockwiseNeighbordsPoints(Bitmap image, Point point)
        {
            int x = point.X, y = point.Y;
            return new Point[]
            {
                new(x + 1, y),
                new(x + 1, y - 1),
                new(x, y - 1),
                new(x - 1, y - 1),
                new(x - 1, y),
                new(x - 1, y + 1),
                new(x, y + 1),
                new(x + 1, y + 1),  
            };
        }
    }
}
