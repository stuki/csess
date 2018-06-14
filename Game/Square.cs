using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace Game
{
    public class Square
    {
        private static int _nextIndex = 0;
        private static Piece _activatedPiece = null;
        private static Square _activatedSquare;
        public int index;
        public Piece Piece;
        public TextBlock Rect;
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
            Rect = new TextBlock();
            Rect.FontSize = 64;
            Rect.TextAlignment = TextAlignment.Center;
            //Rect.VerticalAlignment = VerticalAlignment.Center;
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

        public TextBlock CreateRect()
        { 
            Rect.Background = _color;
            if (Piece != null)
            {
                Rect.Text = Piece.Unicode;
            }
            Rect.DataContext = this;
            Rect.MouseDown += new MouseButtonEventHandler(MouseDownHandler);
            Rect.MouseEnter += new MouseEventHandler(MouseHoverHandler);
            Rect.MouseLeave += new MouseEventHandler(MouseLeaveHandler);
            return Rect;
        }
        private void MouseDownHandler(object sender, MouseButtonEventArgs e)
        {
            if (_activatedSquare == null && Piece != null)
            {
                Rect.Opacity = 0.8;
                _activatedPiece = Piece;
                _activatedSquare = this;
                Piece = null;
            }
            else if (_activatedSquare != null)
            {
                if (Move.Validation(_activatedPiece, _activatedSquare, this))
                {
                    _activatedSquare.Rect.Opacity = 1;
                    _activatedSquare.Rect.Text = null;
                    Piece = _activatedPiece;
                    Rect.Text = Piece.Unicode;
                    _activatedPiece = null;
                    _activatedSquare = null;
                }
                else
                {
                    Flash(_activatedSquare);
                }
            }
        }

        private void MouseHoverHandler(object sender, MouseEventArgs e)
        {
            if (_activatedSquare != this)
            {
                Rect.Opacity = 0.95;
            }
        }

        private void MouseLeaveHandler(object sender, MouseEventArgs e)
        {
            if (_activatedSquare != this)
            {
                Rect.Opacity = 1;
            }
        }


        private void Flash(Square square)
        {
            // TODO: MAKE IT WORK GOD DAMMIT id:0
            // Oscar Storbacka
            // ostorbacka@gmail.com
            // https://github.com/stuki/csess/issues/1
            ColorAnimation animation = new ColorAnimation(
                Colors.Red,
                Colors.Blue,
                new Duration(TimeSpan.FromSeconds(5))
            );
            square.Rect.BeginAnimation(SolidColorBrush.ColorProperty, animation);
        }

    }
}