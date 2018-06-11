using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Piece
    {
        private readonly string _name;
        private readonly int _value;
        public readonly bool IsWhite;
        public bool _isActive { get; set; }
        public bool _isChecked { get; set; }

        private static Dictionary<string, int> piece = new Dictionary<string, int>
            {
                {"pawn", 100},
                {"knight", 300},
                {"bishop", 300},
                {"rook", 500},
                {"queen", 900},
                {"king", 99999},
            };
        
        public Piece(string name, bool isWhite)
        {
            _name = name;
            _value = piece[name];
            IsWhite = isWhite;
            _isActive = true;
            _isChecked = false;
        }
    }
}
