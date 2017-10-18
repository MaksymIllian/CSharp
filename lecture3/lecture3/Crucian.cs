using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace lecture3
{
    class Crucian: Fish, IHorse
    {
        Random rand;
        public Crucian()
        {
            rand = new Random();
            Thread.Sleep(1);
            idBeing = rand.Next();
        }
        public Crucian(Random rand)
        {
            this.rand = rand;
            idBeing = rand.Next();
        }
        string IHorse.EatGrass()
        {
            throw new NotImplementedException();
        }
    }
}
