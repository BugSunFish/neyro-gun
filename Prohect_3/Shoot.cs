using Shooter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Prohect_3
{
    internal class Shoot
    {
        public Shoot(int x = Program.Wight / 2, int y = Program.Hight / 2)
        {
            _x = x;
            _y = y;
        }
        public int _x;
        public int _y;
        public int flies = 0;
    }
}
