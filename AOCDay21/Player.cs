using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOCDay21
{
    public class Player
    {
        public int Position { get; set; }
        public int Score { get; set; }

        public Player(int _position, int _score)
        {
            Score = _score;
            Position = _position;
        }

        public int Move(int _diceTotal)
        {
            return _diceTotal;
        }
    }
}
