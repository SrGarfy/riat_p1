using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace riat_p1
{
    delegate int myDelegate(string a, string b);

    class Program
    {
        static int compare(string a, string b)
        {
            return 0;
        }

        static string[] interfaceSort(string[] strings, IComparer<string> comparer)
        {
            return strings.OrderBy(a => a, comparer).ToArray();
        }

        static string[] funcSort(string[] strings, Func<string, string, int> comparer)
        {
            return strings;
        }

        static string[] delegateSort(string[] strings, myDelegate comparer)
        {
            return strings;
        }
        static void Main(string[] args)
        {
            var strings = new[] {"aaa", "bbbbb", "cccc", "dd"};
            var interfaceSorted = interfaceSort(strings, new Comparer());
            var funcSorted = funcSort(strings, compare);
            var delegateSorted1 = delegateSort(strings, compare);
            var delegateSorted2 = delegateSort(strings, (a,b) => (a == b ? 1 : 0));

            foreach (var s in interfaceSorted)
            {
                Console.WriteLine(s);
            }
        }
    }
}
