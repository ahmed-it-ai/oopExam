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

            // testing About Extension methods to sorting list of numbers
            int[] x = {6,8,7,9,1,1,2,0,1,2,0};
            x.print();
            x.sorting();
            x.print();
            Console.ReadLine();





            //free code
            //int s = 1;
            //int n = 10;
            //for (int x= 1;x<n+1;x++)
            //{
            //    s = s * x;
            //    Console.WriteLine($"x={x}  S={s}");
            //}

            //int x = 10;
            //Console.WriteLine(bankAcount.Factorial(x));
            //Console.ReadLine();


            //bankAcount salma = new bankAcount("QNB","CAIRO","EG124674",5000);
            //string s = "ahmed";
            //Console.WriteLine(s.cunter());//static class (vidoe 13 About {Extension Class} )
            //bankAcount.StaticMethod();// static Methods (vidoe 12)
            //Console.ReadLine();

            //salma.GetAcountData();
            //Console.WriteLine("inter your Deposit :");
            //salma.Deposit(int.Parse(Console.ReadLine()));
            //Console.WriteLine("inter your  :");
            //salma.Withdraw(int.Parse(Console.ReadLine()));

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
    static class Ext
    {
        public static int[] sorting(this int[] inpot)
        {
            
            for (int i = 0; i < inpot.Length; i++)
            {
                for (int x = 0; x < inpot.Length-1; x++)
                {
                    if (inpot[x] > inpot[x + 1])
                    {
                        int xx = inpot[x];
                        inpot[x] = inpot[x + 1];
                        inpot[x + 1] = xx;
                    }

                }
            }


            return inpot;
        }
        public static void print(this int[] inpot )
        {
            Console.Write("(");
            for (int i = 0; i < inpot.Length; i++)
            {
                Console.Write(inpot[i]);
            }
            Console.WriteLine(")");
        }
    }


}
