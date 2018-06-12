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
        private static Piece _activatedPiece = null;
        public int index;
        public Piece Piece;
        public Rectangle Rect;
        private SolidColorBrush _color;
        private readonly Dictionary<string, SolidColorBrush> _colorList =
            new Dictionary<string, SolidColorBrush> {
                { "black", new SolidColorBrush(Color.FromRgb(118, 150, 86)) },
                { "white", new SolidColorBrush(Color.FromRgb(238, 238, 210)) },
                { "hilight", new SolidColorBrush(Color.FromRgb(186, 202, 68)) }
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
            Rect.Fill = _color;
            Rect.DataContext = this;
            Rect.MouseDown += new MouseButtonEventHandler(MouseDownHandler);
            return Rect;
        }

        private void MouseDownHandler(object sender, MouseButtonEventArgs e)
        {
            if (Rect.Fill.Equals(_color) && _activatedPiece == null)
            {
                Rect.Fill = _colorList["hilight"];
                _activatedPiece = Piece;
                Piece = null;
            }
            else
            {
                Rect.Fill = _color;
                if (Move.Validation(_activatedPiece, this))
                {
                    Piece = _activatedPiece;
                    _activatedPiece = null;
                }
            }
        } 
    }
}