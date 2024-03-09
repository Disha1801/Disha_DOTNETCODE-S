using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommanLibrary._01_OOPS.Polymorpshism
{
    public class MyParent//PARENT CLASS
    {

        public MyParent()

        {

            Console.WriteLine("myclassone class ctor");

        }
        public void Show()
        {
            Console.WriteLine("parent method");
        }
        public virtual void Show(string str)
        {
            Console.WriteLine("myclassone: " + str);
        }




    }

    public class MyChild : MyParent//CHILD CLASS

    {

        public MyChild()

        {

            Console.WriteLine("myclasstwo class ctor");
        }

        //method with same name and signature in child class
        public override void Show(string str)

        {

            Console.WriteLine("myclass2 :" + str);

        }
    }
}






