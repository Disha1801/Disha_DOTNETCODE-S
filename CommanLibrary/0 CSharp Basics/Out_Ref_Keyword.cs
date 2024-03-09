using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CommanLibrary._0_CSharp_Basics
{
    public class Out_Ref_Keyword
    {

        #region miscellaneous
        //Ref Keyword
        //need to initialize the ref parameter

        //out keyword
        //does not require initialization


        //swapping logic
        #endregion
        public void demo()
        {
            int a = 1;
            int b = 2;
            int total;
            Console.WriteLine(a+" "+b);
            swap(ref a, ref b,out total);
            Console.WriteLine(a+"-"+ b+"-"+ total);
        }
        public void swap(ref int a, ref int b ,out int total) 
        {


             int c = b;
              b=a;
             a=c;
            total = a + b;
    
        }
        ///Exercise 
        public static string GetNextName(ref int id)
        {
            string returnText = "Next-" + id;
            id=id + 1;
            return returnText;
        }
        public  void ex1()
        {
            int i = 1;
            Console.WriteLine("Previous value of integer i:" + i);
            string test = GetNextName(ref i);
            Console.WriteLine("Current value of integer i:" + i);
        }

        public static string GetNextNameByOut(out int id)
        {
            id = 1;
            string returnText = "Next-" + id;
            return returnText;
        }
        public void ex2()
        {
            int i= 0;
            Console.WriteLine("Previous value of integer i:" + i);
            string test = GetNextNameByOut(out i);
            Console.WriteLine("Current value of integer i:" + i);
        }



        


    }
}
