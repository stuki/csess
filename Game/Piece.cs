using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Piece
    {
        public string Unicode;
        public bool IsWhite;
        public bool _isActive { get; set; }
        public bool _isAttacked { get; set; }

        protected static Dictionary<string, int> pieceValue = 
            new Dictionary<string, int>
                {
                    {"pawn", 100},
                    {"knight", 300},
                    {"bishop", 300},
                    {"rook", 500},
                    {"queen", 900},
                    {"king", 99999},
                };
        protected static Dictionary<string, string> pieceUnicodeWhite = 
            new Dictionary<string, string>
                {
                    {"pawn", "\u2659"},
                    {"knight", "\u2658"},
                    {"bishop", "\u2657"},
                    {"rook", "\u2656"},
                    {"queen", "\u2655"},
                    {"king", "\u2654"},
                };
        protected static Dictionary<string, string> pieceUnicodeBlack = 
            new Dictionary<string, string>
                {
                    {"pawn", "\u265F"},
                    {"knight", "\u265E"},
                    {"bishop", "\u265D"},
                    {"rook", "\u265C"},
                    {"queen", "\u265B"},
                    {"king", "\u265A"},
                };
        public Piece(bool isWhite)
        {
            IsWhite = isWhite;
            _isActive = true;
            _isAttacked = false;
        }
    }
}
