using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw1.Sorting
{
    internal class SimpleInclusionsSorting
    {
        public void SortInsertion(int[] a)
        {
            int tmp = a[0];
            int N = a.Length;
            for(int i = 1; i < N; i++)
            {
                int j = i - 1;
                while (j >= 0 && tmp < a[j])
                    a[j + 1] = a[j--];
                a[j + i] = tmp;
            }    
        }
    }
}
