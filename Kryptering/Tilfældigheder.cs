using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Kryptering
{
    internal class Tilfældigheder
    {
        public int Execute(int maxRandom, int randomCount)
        {
            var rnd = 0;
            for (int i = 0; i < randomCount; i++)
            {
                rnd = RandomNumberGenerator.GetInt32(0, maxRandom);
            }
            return rnd;
        }
    }
}
