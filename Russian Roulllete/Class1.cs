using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Russianroulletegun
{
    class Roullete
    {
        public int load;
        public int bulleteloadspin;

        public int Bulleteloop(int skip)
        {
            if (skip == 6)
            {
                skip = 1;
            }
            else
            {
                skip++;
            }
            return skip;
        }
    }
}



