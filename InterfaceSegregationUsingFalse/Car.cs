using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static InterfaceSegregationUsingFalse.CarFeatures;

namespace InterfaceSegregationUsingFalse
{
    public class Car
    {

    }
    public class Nissan350Z : Car, IFeatures
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

    public class Renault12 : Car, IFeatures
    {
        public void Breake(Features f)
        {
            Console.WriteLine("Breaked");
        }

        public void Drift(Features f)
        {
            throw new NotImplementedException();
        }

        public void Go(Features d)
        {
            Console.WriteLine("Went");
        }
    }
}
