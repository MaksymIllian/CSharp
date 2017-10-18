using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture3
{
    class Program
    {
        static int WhoCanBreatheUnderwater(List<LivingBeings> l)
        {
            int count=0;
            Console.WriteLine("Who Can Breathe Underwater:");
            for (int i = 0; i < l.Count; i++)
            {
                if ((l[i] as IFish) == null)
                {
                    Console.WriteLine("id"+i+":"+l[i].idBeing);
                }
            }

                return count;
        }
        static int CountOfLegs(List<LivingBeings> l)
        {
            int count = 0;
            //LivingBeings item;
            foreach(LivingBeings item in l)
            {
                if ( item is IAnimals)
                {
                   count+= ((IAnimals)item).numberOfLegs;
                }
            }

            return count;
        }
        static void AddToCollection(List<LivingBeings> listOfBeings)
        {
            
            Console.WriteLine("Enter type count of Living Beings");
            Console.WriteLine("(1 type count = 1 horse, 1 dog, 1 roach, 1 crucian)");
            int n = Convert.ToInt32(Console.ReadLine());
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                LivingBeings being = new Horse(4,rand);
                LivingBeings being2 = new Dog(4,rand);
                LivingBeings being3 = new Roach(rand);
                LivingBeings being4 = new Crucian(rand);
                listOfBeings.Add(being);
                listOfBeings.Add(being2);
                listOfBeings.Add(being3);
                listOfBeings.Add(being4);
            }

        }
        static void Main(string[] args)
        {
            List<LivingBeings> listOfBeings = new List<LivingBeings>();
            AddToCollection(listOfBeings);
            WhoCanBreatheUnderwater(listOfBeings);
            Console.WriteLine("Count of legs:" + CountOfLegs(listOfBeings).ToString());
        }
    }
}
