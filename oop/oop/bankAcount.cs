using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
   
    class bankAcount
    {

        public string BankName { get; set; }
        public string BranchName { get; set; }
        public string AcountNumber { get; set; }
        public int Balance { get; set; }
        public bankAcount()
        {
            
            Console.WriteLine("Constructors");
        }
        public bankAcount(string bankName, string branchName, string acountNumber, int balance)
        {
            // to set All parametars from Constructor
            BankName = bankName;
            BranchName = branchName;
            AcountNumber = acountNumber;
            Balance = balance;
        }



        public void Withdraw(int amount)
        {
            int newBalance = Balance - amount;
            if (newBalance <= 0)
            {
                Console.WriteLine("Invalid:");
            }
            else
            {
                Balance = newBalance;
                Console.WriteLine($" Withdraw Amount is {amount} ");
                Console.WriteLine($" Your new balance for {AcountNumber} is {Balance} ");
            }
            Console.WriteLine(DateTime.Now);
        }
        public void Deposit(int amount)
        {
            Balance += amount;
            Console.WriteLine($"Deposit Amount is {amount}");
            Console.WriteLine($" Your new balance for {AcountNumber} is {Balance} ");
            Console.WriteLine(DateTime.Now);
        }
        public void GetAcountData()
        {
            Console.WriteLine("         Acount Data");
            Console.WriteLine($"Bank Name :{BankName}");
            Console.WriteLine($"Branch Name :{BranchName}");
            Console.WriteLine($"Acount Number :{AcountNumber}");
            Console.WriteLine($"Balance : {Balance}");
        }
        public void setAcountData()
        {
            Console.Write("inter your Bank Name:");
            BankName = Console.ReadLine();
            Console.Write("inter your Branch Name:");
            BranchName = Console.ReadLine();
            Console.Write("inter your Acount Number:");
            AcountNumber = Console.ReadLine();
            Console.Write("inter your Balance:");
            Balance = int.Parse(Console.ReadLine());
        }

    }

}
