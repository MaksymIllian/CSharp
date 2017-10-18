using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace lecture3
{
    class Dog : Animals, IFish,IAnimals
    {
        
        Random rand;
        public Dog()
        {
            rand = new Random();
            Thread.Sleep(1);
            idBeing = rand.Next();
            numberOfLegs = 4;
        }
        public Dog(int legs,Random rand)
        {
            this.rand = rand;
            Thread.Sleep(1);
            idBeing = rand.Next();
            numberOfLegs = legs;
        }

        public string BreatheUnderwater()
        {
            throw new NotImplementedException();
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
