using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;

namespace ClickCounter
{
    static class ImageManipulator
    {
        private static List<Image> imageHistory = new List<Image>();
        private static List<String> manipulationHistory = new List<String>();

        private static PropertyService propSerivice = PropertyService.getInstance();

        /// <summary>
        /// Draws a point to the given image and returns it
        /// </summary>
        /// <param name="image"></param>
        /// <param name="coords"></param>
        /// <param name="color"></param>
        /// <returns></returns>
        public static Image drawPoint(String counterId, Image image, Point coords, Color color)
        {
            if( image == null || coords == null || color == null )
            {
                throw new ArgumentException("One argument is null");
            }

            
            addHistoryEntry(counterId, (Image)image.Clone());

            Graphics g = Graphics.FromImage(image);

            Pen pen = new Pen(color, propSerivice.penWidth);
            g.DrawRectangle(pen, coords.X, coords.Y, propSerivice.rectangleSize.Width, propSerivice.rectangleSize.Height);
            g.Save();

            return image;
        }

        public static String getLastManipulationId()
        {
            return manipulationHistory.LastOrDefault();
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        public static Image revertLastManipulation()
        {
            if (imageHistory.Count > 0)
            {
                // get image before last modification and remove it from list
                Image i = imageHistory.Last<Image>();
                imageHistory.RemoveAt(imageHistory.Count - 1);
                manipulationHistory.RemoveAt(manipulationHistory.Count - 1);
                return i;
            }

            return null;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        private static void addHistoryEntry(String counterId, Image image)
        {
            if( counterId != null && image != null )
            {
                // if max historie count is reached, remove the oldest entry
                if(imageHistory.Count >= propSerivice.maxHistorie )
                {
                    imageHistory.RemoveAt(0);
                    manipulationHistory.RemoveAt(0);
                }

                imageHistory.Add(image);
                manipulationHistory.Add(counterId);
            }
        }
    }
}
