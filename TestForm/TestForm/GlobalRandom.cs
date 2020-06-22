using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestForm
{
    static class GlobalRandom
    {
        public static Random Random { get; } = new Random();
    }
}
