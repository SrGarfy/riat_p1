using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace riat_p1
{
    delegate bool myDelegate(string a, string b);

    class Program
    {
        static bool compare(string a, string b)
        {
            return (a.Length > b.Length ? true : false);
        }

        static string[] interfaceSort(string[] strings, IComparer<string> comparer)
        {
            return strings.OrderBy(a => a, comparer).ToArray();
        }

        static string[] funcSort(string[] strings, Func<string, string, bool> compare)
        {
            for (var i = 0; i < strings.Length; i++)
            {
                for (var j = i; j < strings.Length; j++)
                {
                    if (compare(strings[i], strings[j]))
                    {
                        var tmp = strings[i];
                        strings[i] = strings[j];
                        strings[j] = tmp;
                    }
                }
            }
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
            var delegateSorted2 = delegateSort(strings, (a,b) => (a == b));

            foreach (var s in funcSorted)
            {
                Console.WriteLine(s);
            }
        }
    }
}
