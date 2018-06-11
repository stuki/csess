using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Game
{
    public class Board
    {
        private List<Square> _field = new List<Square>(new Square[64]);
        private List<List<Square>> _history;

        public List<List<Square>> History { get => _history; set => _history = value; }

        public List<Square> Field { get => _field; }

        public Board()
        {
            for (int i = 0; i < _field.Count; i++)
            {
                _field[i] = new Square();
            }
            _field[63].Piece = new Piece("rook", true);
        }
    }   
}
