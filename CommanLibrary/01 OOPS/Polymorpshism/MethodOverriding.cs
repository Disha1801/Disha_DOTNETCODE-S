using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommanLibrary._01_OOPS.Polymorpshism
{
   public  class MyClassOne//PARENT CLASS
    {

        public MyClassOne()

        {

            Console.WriteLine("myclassone class ctor");

        }
        public   void Show()
        {
            Console.WriteLine("parent method");
        }
        public void Show(string str)
        {
            Console.WriteLine("myclassone: "+str);
        }




    }

    public class MyClassTwo : MyClassOne//CHILD CLASS

    {

        public MyClassTwo()

        {

            Console.WriteLine("myclasstwo class ctor");
        }

        //method with same name and signature in child class
        public  void Show(string str)

        {
            
            Console.WriteLine("myclass2 :"+str);

        }
    }



}
