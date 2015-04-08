using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace problemSet01
{
    class EvenNumber
    {
        public void EvenNum(Label ans)
        {
            ans.Text="All Even Numbers between 1-100 are:";
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    ans.Text+=" " + i;
                }
            }
        }
    }
}
