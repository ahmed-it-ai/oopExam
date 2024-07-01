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
            bankAcount ahmed = new bankAcount();
            ahmed.setAcountData();
            while (true)
            {                
                ahmed.GetAcountData();
                Console.WriteLine("inter your Deposit :");
                ahmed.Deposit(int.Parse(Console.ReadLine()));
                Console.WriteLine("inter your  :");
                ahmed.Withdraw(int.Parse(Console.ReadLine()));
            }
        }
    }
    


}
