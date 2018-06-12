using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Pawn : Piece
    {
        private readonly int _value = 100;

        public Pawn(bool isWhite) : base(isWhite)
        {
            IsWhite = isWhite;
        }
    }
    public class Knight : Piece
    {
        private readonly int _value = 300;

        public Knight(bool isWhite) : base(isWhite)
        {
            IsWhite = isWhite;
        }
    }
    public class Bishop : Piece
    {
        private readonly int _value = 300;

        public Bishop(bool isWhite) : base(isWhite)
        {
            IsWhite = isWhite;
        }
    }
    public class Rook : Piece
    {
        private readonly int _value = 500;

        public Rook(bool isWhite) : base(isWhite)
        {
            IsWhite = isWhite;
        }
    }
    public class Queen : Piece
    {
        private readonly int _value = 900;

        public Queen(bool isWhite) : base(isWhite)
        {
            IsWhite = isWhite;
        }
    }
    public class King : Piece
    {
        private readonly int _value = 999999;

        public King(bool isWhite) : base(isWhite)
        {
            IsWhite = isWhite;
        }
    }
}
