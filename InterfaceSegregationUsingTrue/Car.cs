using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static InterfaceSegregationUsingTrue.CarFeatures;

namespace InterfaceSegregationUsingTrue
{
    public class Car
    {
            
    }
    public class Nissan350Z : Car, IBreake,IGo,IDrift
    {
        public void Breake(Features f)
        {
            Console.WriteLine("Breaked");
        }

        public void Drift(Features f)
        {
            Console.WriteLine("Drifted");
        }

        public void Go(Features d)
        {
            Console.WriteLine("Went");
        }
    }

    public class Renault12 : Car, IBreake, IGo
    {
        public void Breake(Features f)
        {
            Console.WriteLine("Breaked");
        }

        public void Go(Features d)
        {
            Console.WriteLine("Went");
        }
    }
}
