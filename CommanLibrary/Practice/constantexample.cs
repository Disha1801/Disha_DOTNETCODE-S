using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommanLibrary.Practice
{
    public  class constantexample

    {

        public const decimal pi = (decimal)3.14;
        public static  void circle_area()

        {
           // const decimal pi = (decimal)3.14;

            Console.WriteLine("ENTER RADIUS");
            decimal r=Convert.ToDecimal(Console.ReadLine());
            decimal area = (pi * r * r);
            Console.WriteLine(area);
       
        }
    }
}
