using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ATM
{
    class Atm
    {


      
        public float DepositAmount;
        public float WithDrawAmount;
        public float RemainingAmount;
       
        //List<Atm> users = new List<Atm>();

    public float Total = 0;

        public void DepositMoney(float depositAmount)
        {
            Console.WriteLine("Deposit Amount: {0}",depositAmount);
            Total += depositAmount;
            Console.ReadLine();
        }

        public void Withdraw(float withdrawAmount)
        {
            Console.WriteLine("Withdraw Amount: {0}",withdrawAmount);
            if (withdrawAmount <= Total)
            {
                Total -= withdrawAmount;
                Console.WriteLine($"Remaining Amount: {Total}");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Insufficient funds!");
            }
        }

        public void CheckBalance()
        {
            Console.WriteLine($"Balance: {Total}");
            Console.ReadLine();
        }
    }
}
