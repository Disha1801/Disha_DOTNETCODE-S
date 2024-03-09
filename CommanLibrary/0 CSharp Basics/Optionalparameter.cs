using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommanLibrary._0_CSharp_Basics
{
    public class Optionalparameter
    {
public void optionalParameter(int a,int b,int c=10)
        {
            Console.WriteLine(a+b+c);
            

        }
        

        //Method Over-loading

        public void optionalParameter(int a, int b, int d, int c = 20)
        {
            Console.WriteLine(a + b + c + d);
        }
    }
    

}



