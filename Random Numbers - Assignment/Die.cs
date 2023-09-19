using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_Numbers___Assignment
{
    internal class Die
    {
        private int _roll;
        private Random _generator;

        public Die()
        {
            _generator = new Random();
            _roll = _generator.Next(1, 7);
    
        }

        public int Roll
        {
            get { return _roll; }
        }

    
        public override string ToString()
        {
            return _roll + "";
        }

        public int RollDie()
        {
            _roll = _generator.Next(1, 7);
            return _roll;

        }
    }
}
