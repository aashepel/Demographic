using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Demographic
{
    internal static class ProbabilityCalculator
    {
        private static readonly RNGCryptoServiceProvider _random = new RNGCryptoServiceProvider();

        internal static bool IsEventHappened(double eventProbability)
        {
            byte[] randombyte = new byte[1];
            _random.GetBytes(randombyte);
            return (randombyte[0] / 255d) <= eventProbability;
        }
    }
}
