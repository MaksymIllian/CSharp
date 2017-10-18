using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace lecture3
{
    class Horse : Animals,IAnimals
    {
        Random rand;
        
        public Horse()
        {
            rand = new Random();
            Thread.Sleep(1);
            this.numberOfLegs = 4;
            idBeing = rand.Next();
        }
        public Horse(int legs, Random rand)
        {
            this.rand = rand;
            this.numberOfLegs = legs;
            idBeing = rand.Next();
        }
        public string EatGrass()
        {
            return "Grass is eated";
        }



        int IAnimals.numberOfLegs
        {
            get
            {
                return numberOfLegs;
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
