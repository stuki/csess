using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Piece
    {
        public bool IsWhite;
        public bool _isActive { get; set; }
        public bool _isAttacked { get; set; }

        private static Dictionary<string, int> piece = new Dictionary<string, int>
            {
                {"pawn", 100},
                {"knight", 300},
                {"bishop", 300},
                {"rook", 500},
                {"queen", 900},
                {"king", 99999},
            };
        
        public Piece(bool isWhite)
        {
            IsWhite = isWhite;
            _isActive = true;
            _isAttacked = false;
        }
    }
}
