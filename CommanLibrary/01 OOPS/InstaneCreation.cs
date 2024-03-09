using CommanLibrary._0_CSharp_Basics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommanLibrary._01_OOPS
{
    //RunTime polymorphism->Method Overriding -virtual n override
    public class ParentClass

    {
        
public ParentClass() 
       
        {

            Console.WriteLine("parent class ctor");

        }
        public void ShowMsg()
        {
            Console.WriteLine("parent class msg");
        }

    }

    public class ChildClass:ParentClass

    {

        public ChildClass()

        {

            Console.WriteLine("child class ctor");
        }
        
    public void ShowMsg()
      
        {
            base.ShowMsg();
            //base keyword refers to parent class ,this is how u  call the method of parent class 
            //in child class
            Console.WriteLine("child class msg ");
        
        }
    }

}
