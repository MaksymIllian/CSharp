using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture3
{
    abstract class Animals : LivingBeings, IAnimals 
    {
        public int numberOfLegs;

        public Animals()
        {
 
        }
        int IAnimals.numberOfLegs
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
