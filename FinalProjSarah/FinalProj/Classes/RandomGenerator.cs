 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProj.Classes
{
    public class RandomGenerator
    {
        private static Random myInstance = null;
        private RandomGenerator() { }
        public static Random GetInstance()
        {
            return myInstance is null ? myInstance = new Random() : myInstance;
        }
    }
}
