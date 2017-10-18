using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace lecture3
{
    class Roach : Fish
    {
        Random rand = new Random();
        public Roach()
        {
            Thread.Sleep(1);
            idBeing = rand.Next();
        }
        public Roach(Random rand)
        {
            this.rand = rand;
            idBeing = rand.Next();
        }
    }
}
