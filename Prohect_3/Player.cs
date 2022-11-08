using Shooter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Prohect_3
{
    internal class Player
    {
        public Player(int x = Program.Wight/2, int y = Program.Hight/2)
        {
            _x = x;
            _y = y;
        }
        public int _x;
        public int _y;
        public int hp = 100;
    }
}
