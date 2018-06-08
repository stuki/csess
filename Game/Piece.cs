using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public abstract class Piece
    {
        private readonly string _name;
        private readonly int _value;
        public bool _isActive { get; set; }
        public bool _isChecked { get; set; }
    }
}
