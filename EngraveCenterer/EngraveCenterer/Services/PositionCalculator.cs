using EngraveCenterer.Models;
using EngraveCenterer.ViewModels;
using System;
using System.Drawing;
using Xamarin.Essentials;

namespace EngraveCenterer.Services
{
    public class PositionCalculator
    {
        private double _letterWidth;
        private double _letterHeight;
        private double _offsetX;
        private double _offsetY;

        public PositionCalculator() { }

        public Point CalculatePosition(Cover cover)
        {
            ReloadConfigValues();

            var textSize = GetTextSize(cover.FirstLine);
            var origin = CenterSizeAndReturnOrigin(cover.CoverSize, textSize);
            Point originWithOffset = ApplyOffset(origin);
            return originWithOffset;
        }


        private Point ApplyOffset(Point origin)
        {
            Point result = new Point();
            result.X = Convert.ToInt32(origin.X) + Convert.ToInt32( _offsetX);
            result.Y = Convert.ToInt32(origin.Y) + Convert.ToInt32(_offsetY);
            return result;
        }


        private Size GetTextSize(string textLine)
        {
            if (string.IsNullOrWhiteSpace(textLine))
            {
                throw new Exception("Hace falta un texto");
            }
            return new Size(Convert.ToInt32(_letterWidth * textLine.Length), Convert.ToInt32(_letterHeight));            
        }


        private Point CenterSizeAndReturnOrigin(Size cover, Size textArea)
        {
            if (cover.Width < textArea.Width || cover.Height < textArea.Height)
            {
                throw new Exception("El área de texto es más grande que la cubierta");
            }

            var x = (cover.Width - textArea.Width) / 2;
            var y = (cover.Height - textArea.Height) / 2;
            return new Point(x, y);
        }
        
        private void ReloadConfigValues()
        {
            _letterWidth = Preferences.Get(nameof(ConfigViewModel.LetterWidth), 8.0);
            _letterHeight = Preferences.Get(nameof(ConfigViewModel.LetterHeight), 12.0); ;
            _offsetX = Preferences.Get(nameof(ConfigViewModel.OffsetX), 0.0); ;
            _offsetY = Preferences.Get(nameof(ConfigViewModel.OffsetY), 0.0); ;
        }
    }
}
