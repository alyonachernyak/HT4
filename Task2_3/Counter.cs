using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_3
{
    public class Counter
    {
        public static int Count { get; private set; }  = 0;

        public Counter()
        { 
           Count ++;
        }
    }
}
