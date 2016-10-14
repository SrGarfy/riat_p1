using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace riat_p1
{
    class Comparer : IComparer<string>
    {
        public int Compare(string a, string b)
        {
            return (a.Length > b.Length ? 
                1 : 
                (a.Length == b.Length ? 0 : -1)
                );
        }
    }
}
