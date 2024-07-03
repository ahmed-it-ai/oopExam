using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    class Program
    {
        static void Main(string[] args)
        {
          
            bankAcount salma = new bankAcount("QNB","CAIRO","EG124674",5000);
            while (true)
            {
                salma.GetAcountData();
                Console.WriteLine("inter your Deposit :");
                salma.Deposit(int.Parse(Console.ReadLine()));
                Console.WriteLine("inter your  :");
                salma.Withdraw(int.Parse(Console.ReadLine()));
            }
            //bankAcount ahmed = new bankAcount();
            //ahmed.setAcountData();
            //while (true)
            //{                
            //    ahmed.GetAcountData();
            //    Console.WriteLine("inter your Deposit :");
            //    ahmed.Deposit(int.Parse(Console.ReadLine()));
            //    Console.WriteLine("inter your  :");
            //    ahmed.Withdraw(int.Parse(Console.ReadLine()));
            //}

        }
    }
    


}
