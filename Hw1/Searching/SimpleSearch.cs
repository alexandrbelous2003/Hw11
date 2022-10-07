using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw1.Searching
{
    internal class SimpleSearch
    {
        public int Search(int[] a, int x)
        {
            int i = 0;
            while (i < a.Length && a[i] != x) i++;
            if (i < a.Length)
                return i;
            else return -1;
        }
    }
}
