using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommanLibrary.Practice
{
    public class Compound_Interest
    {
        

       
        public  void Compound() 
        {
            Console.WriteLine("Enter Amount");
            double amount = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Time");
            double time = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter rate");
            double rate = Convert.ToDouble(Console.ReadLine());
            double interestRate = rate / 100;
            double CI=amount*Math.Pow(1+interestRate,time)-amount;
            double totalAmount = amount + CI;

            Console.WriteLine("Pricipal amount:"+amount);
            Console.WriteLine("Compound Interst:" + CI);
            Console.WriteLine("Total amount after" + time + "years:"+totalAmount);













        }
    }
}
