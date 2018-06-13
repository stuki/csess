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
        public static int[] AreaOfMovement =
            { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1,
              -1, -1, -1, -1, -1, -1, -1, -1, -1, -1,
              -1,  0,  0,  0,  0,  0,  0,  0,  0, -1,
              -1,  0,  0,  0,  0,  0,  0,  0,  0, -1,
              -1,  0,  0,  0,  0,  0,  0,  0,  0, -1,
              -1,  0,  0,  0,  0,  0,  0,  0,  0, -1,
              -1,  0,  0,  0,  0,  0,  0,  0,  0, -1,
              -1,  0,  0,  0,  0,  0,  0,  0,  0, -1,
              -1,  0,  0,  0,  0,  0,  0,  0,  0, -1,
              -1,  0,  0,  0,  0,  0,  0,  0,  0, -1,
              -1, -1, -1, -1, -1, -1, -1, -1, -1, -1,
              -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 };
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
            _field[63].Piece = new Rook(true);
        }

        public static int[] To120(Square square)
        {
            int index = ((square.index / 8) * 2) + 21 + square.index;
            int[] newBoard = AreaOfMovement;
            newBoard[index] = 1;
            return newBoard;
        }
    }   
}
