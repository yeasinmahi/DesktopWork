using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace problemSet01
{
    class UpperLower
    {
        public void UpperLowerLimit(int lower,int upper, Label ans)
        {

            ans.Text = "From " + lower + " to " + upper + " values: ";
            for (int i = lower; i <= upper; i++)
            {
                ans.Text += " " + i;
            }
          
        }
    }
}
