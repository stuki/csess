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

        public List<Square> Field()
        {
            return _field;
        }

        public Board()
        {
            for (int i = 0; i < _field.Count; i++)
            {
                _field[i] = new Square();
            }
        }
    }   
}
