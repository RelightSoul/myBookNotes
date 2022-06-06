using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33.CustomInterface
{
    internal class PitchFork : IPointy
    {
        public byte Points { get { return 8; } }
    }
}
