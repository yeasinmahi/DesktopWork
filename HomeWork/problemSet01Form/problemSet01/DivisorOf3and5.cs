using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace problemSet01
{
    class DivisorOf3and5
    {
        public void Divisor(Label ans)
        {
            Int64 result = 0;
            for (int i = 1; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    result += i;
                }
            }
            ans.Text="Summation of total number of divisor of 3 and 5 is " + result;
        }
    }
}
