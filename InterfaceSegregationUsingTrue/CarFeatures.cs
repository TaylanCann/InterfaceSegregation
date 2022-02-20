using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationUsingTrue
{
    public class CarFeatures
    {
        public class Features
        {
        }
        public interface IGo
        {
            void Go(Features d);          
        }
        public interface IBreake
        {
            void Breake(Features f);        
        }
        public interface IDrift
        {
            void Drift(Features f);
        }
    }
}
