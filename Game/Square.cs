using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Game
{
    public class Square
    {
        private static int _nextIndex = 1;
        public int index;
        public Piece Piece;
        public Rectangle rect;

        Dictionary<string, SolidColorBrush> color = new Dictionary<string, SolidColorBrush>();


        public Square(Piece piece = null)
        {
            Piece = piece;
            rect = new Rectangle();
            index = _nextIndex++;
            color.Add("black", new SolidColorBrush(Color.FromRgb(10, 10, 10)));
            color.Add("white", new SolidColorBrush(Color.FromRgb(200, 200, 200)));
        }

        public Rectangle CreateRect()
        {
            if (index % 2 == 0)
            {
                rect.Fill = color["black"];
            }
            else
            {
                rect.Fill = color["white"];
            }
            rect.DataContext = this;
            rect.MouseDown += new MouseButtonEventHandler(squareClicked);
            return rect;
        }

        private void squareClicked(object sender, MouseButtonEventArgs e)
        {
            rect.Fill = new SolidColorBrush(Color.FromRgb(1, 1, 1));
            Console.WriteLine(rect.DataContext);
            Console.WriteLine(index);
        }
    }
}
