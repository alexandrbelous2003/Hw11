using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw1.Searching
{
    internal class SearchBinary
    {
        public int Search(int[] a, int x)
        {
            int middle, left = 0, right = a.Length - 1;
            do
            {
                middle = (left + right) / 2;
                if (x > a[middle])
                    left = middle + 1;
                else
                    right = middle - 1;
            }
            while ((a[middle] != x) && (left <= right));
            if (a[middle] == x)
                return middle;
            else return -1;
        }
    }
}
