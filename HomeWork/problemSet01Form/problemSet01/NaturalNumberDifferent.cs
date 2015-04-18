using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace problemSet01
{
    class NaturalNumberDifferent
    {
        public void NaturalNumber(Label ans)
        {
            Int64 firstNumber = 0, secondNumber = 0, result = 0;
            for (int i = 1; i <= 100; i++)
            {
                firstNumber += i * i;
                secondNumber += i;
            }
            secondNumber *= secondNumber;
            result = secondNumber - firstNumber;
            ans.Text= "Your Desire number is: " + result;

        }
    }
}
