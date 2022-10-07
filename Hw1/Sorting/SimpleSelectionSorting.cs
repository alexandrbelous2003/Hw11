using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw1.Sorting
{
    internal class SimpleSelectionSorting
    {
        public void SortSelection(int[] a)
        {
            int N = a.Length;
            int min = 0, imin = 0, i;
            for (i = 0; i < N; i++)
            {
                min = a[i]; imin = i;
                for(int j = i+1; j < N; j++)
                {
                    if (a[j] < min) min = a[j]; imin = j;
                }
                if (i != imin)
                {
                    a[imin] = a[i];
                    a[i] = min;
                }
            }
        }
    }
}
