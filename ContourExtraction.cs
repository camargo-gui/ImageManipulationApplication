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
    class ContourExtraction
    {
        public static void ContourFollowing(Bitmap src, Bitmap dest)
        {
            int width = src.Width, height = src.Height;
            int minX = width, minY = height, maxX = 0, maxY = 0;
            Point initialPoint, nextPoint;
            Point[] neighbors;

            for (int y = 1; y < height - 1; y++)
            {
                for (int x = 1; x < width - 1; x++)
                {
                    if (PixelUtil.hasTransition(src.GetPixel(x, y), src.GetPixel(x + 1, y)))
                    {
                        initialPoint = new Point(x, y);
                        neighbors = PixelUtil.GetAntiClockwiseNeighbordsPoints(src, initialPoint);
                        nextPoint = FindNextPoint(src, neighbors);
                        while (nextPoint != null && !(initialPoint.X == nextPoint.X && initialPoint.Y == nextPoint.Y))
                        {
                            minX = nextPoint.X < minX ? nextPoint.X : minX;
                            minY = nextPoint.Y < minY ? nextPoint.Y : minY;
                            maxX = nextPoint.X > maxX ? nextPoint.X : maxX;
                            maxY = nextPoint.Y > maxY ? nextPoint.Y : maxY;

                            src.SetPixel(nextPoint.X, nextPoint.Y, Color.Red);
                            dest.SetPixel(nextPoint.X, nextPoint.Y, Color.Red);
                            nextPoint = FindNextPoint(src, PixelUtil.GetAntiClockwiseNeighbordsPoints(src, nextPoint));
                        }
                        src.SetPixel(initialPoint.X, initialPoint.Y, Color.Red);
                        dest.SetPixel(initialPoint.X, initialPoint.Y, Color.Red);
                        PaintRectangle(dest, minX, minY, maxX, maxY);
                        minX = width; minY = height; maxX = 0; maxY = 0;
                    }
                }
            }
        }

        private static Point FindNextPoint(Bitmap src, Point[] neighbors)
        {
            int x, y;
            for(int i = 0; i < neighbors.Length - 1; i++)
            {
                x = neighbors[i].X; 
                y = neighbors[i].Y;
                if (
                    PixelUtil.hasTransition(
                    src.GetPixel(x, y),
                    src.GetPixel(neighbors[i+1].X, neighbors[i + 1].Y)))
                {
                  return neighbors[i];
                }
            }
            if (
                PixelUtil.hasTransition(
                src.GetPixel(neighbors[7].X, neighbors[7].Y),
                src.GetPixel(neighbors[0].X, neighbors[0].Y)))
            {
                return neighbors[7];
            }
            return null;
        }

        private static void PaintRectangle(Bitmap image, int minX, int minY, int maxX, int maxY)
        {
            for(int x = minX; x <= maxX; x++)
            {
                image.SetPixel(x, minY, Color.Blue);
                image.SetPixel(x, maxY, Color.Blue);
            }
            for(int y = minY; y <= maxY; y++)
            {
                image.SetPixel(minX, y, Color.Blue);
                image.SetPixel(maxX, y, Color.Blue);
            }
        }

    }
}
