using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try { 
            Account acc = new Account(100);
            //Console.WriteLine(acc.Deposit(50));
            //Console.WriteLine(acc.Withdraw(50));
            Console.WriteLine(acc.Withdraw(9000));
            }
            catch(InvalidWithDraw ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();

        }
    }
}
