using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Game
{
    public class Square
    {
        private static int _nextIndex = 0;
        private static Square _activated;
        public int index;
        public Piece Piece;
        public Rectangle Rect;
        private SolidColorBrush _color;
        private readonly Dictionary<string, SolidColorBrush> _colorList =
            new Dictionary<string, SolidColorBrush> {
                { "black", new SolidColorBrush(Color.FromRgb(100, 100, 100)) },
                { "white", new SolidColorBrush(Color.FromRgb(200, 200, 200)) },
                { "hilight", new SolidColorBrush(Color.FromRgb(150, 1, 1)) }
            };

        public Square(Piece piece = null)
        {
            Piece = piece;
            Rect = new Rectangle();
            index = _nextIndex++;
            _color = _colorList["white"];

            if ((index / 8) % 2 == 0)
            {
                if (index % 2 == 0)
                {
                    _color = _colorList["black"];
                }
            }
            else
            {
                if (index % 2 != 0)
                {
                    _color = _colorList["black"];
                }
            }
        }

        public Rectangle CreateRect()
        {
            int lol = index / 8;
            Rect.Fill = _color;
            Rect.DataContext = this;
            Rect.MouseDown += new MouseButtonEventHandler(MouseDownHandler);
            Rect.MouseUp += new MouseButtonEventHandler(MouseUpHandler);
            return Rect;
        }

        private void MouseDownHandler(object sender, MouseButtonEventArgs e)
        {
            UIElement element = (UIElement)sender;
            Rect.Fill = _colorList["hilight"];
            _activated = this;
            element.CaptureMouse();
        }
        private void MouseUpHandler(object sender, MouseButtonEventArgs e)
        {
            UIElement element = (UIElement)sender;
            Rect.Fill = _color;
            _activated = null;
            element.ReleaseMouseCapture();
        }   
    }
}
