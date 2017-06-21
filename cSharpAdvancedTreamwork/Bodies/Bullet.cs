using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace cSharpAdvancedTreamwork.Bodies
{
    public class Bullet
    {
        public int x { get; set; }
        public int y { get; set; }
        public int speed { get; set; }

        public Bullet(int x, int y)
        {
            this.x = x;
            this.y = y;
            this.speed = 2;
        }

    }
}
