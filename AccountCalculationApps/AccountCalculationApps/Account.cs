using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountCalculationApps
{
    class Account
    {
        public string accountNumber;
        public string customerName;
        public double aDeposit;
        public double aWithdraw;
        public double totalBalance;
        public  double totalSaveAmount=0.0;
        public double accountWidthdraw = 0.0;
        


       /*/public double SaveAmount()
        {

            aDeposit = aDeposit + aDeposit;
            return aDeposit;
        }*/
        
        public double GetNetBlance()
        {
            if (accountWidthdraw <= totalSaveAmount)
            {
                totalBalance = totalSaveAmount - accountWidthdraw;
                return totalBalance;
            }
            else
            {
                MessageBox.Show("you have not enough money"+totalBalance);
                return totalBalance;
            }

        }
    }
}
