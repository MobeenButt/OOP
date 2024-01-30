using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Atm atm = new Atm();

            atm.DepositMoney(2100);
            atm.CheckBalance();
            atm.DepositMoney(100);
            atm.CheckBalance();
            atm.Withdraw(1000);

            atm.CheckBalance();



        }
    }
}

