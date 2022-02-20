using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationUsingFalse
{
    public class CarFeatures
    {
        
    }
    public class Features
    {
    }
    public interface IFeatures
    {
        void Go(Features d);
        void Breake(Features f);
        void Drift(Features f);
    }
}
