using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommanLibrary._0_CSharp_Basics
{
    public class Class_Object

    {
        //Property shortcut=>prop+press enter
        //Property 
        //diff between property and global variable:

        public int ID { get; set; }
        
        public string Name{ get; set; }
        public string Name_not_to_beset { get; set; }
        public bool IsActive { get; set; }



        //Global variable
        int a = 199;
        string str = "Hi hello Kemcho";

        //all variables have different values and all variables aare different
        int value =10;
        int VALUE = 30;
        int Value = 50;
        int ValuE = 80;

        //c# is case sensitive 



       //shortcut to create constructor
        //ctor+press enter
        public Class_Object()

        {
            Console.WriteLine("no-arg constructor");

            //Defaultconstructor->coz it has no parameter
            //This will always run when a new object/instance of this class
            ////or any child class is created 
        }
        static Class_Object()
        {
            Console.WriteLine("static  constructor");
            //constructor name should be same as class name 
            //static constructor ->it does not have any access modifier
            //it will only called once when the firstobject of that class is created
            //static ctor will always be called first when instance is created ,even before default constructor
            //static ctor is called by the CLR->Comman Language runtime
            //
        }
        public Class_Object(int a)
        {
            //Parameterized constructor
            Console.WriteLine("parameterized constructor");
        }
        public Class_Object(string str)
        {
            //Parameterized constructor
            Console.WriteLine("parameterized constructor2");

        }

        public Class_Object(string str,int a)
        {
            //Parameterized constructor
            Console.WriteLine("parameterized constructor 3");
        }
        //Private constructor also exist in c#
        public void DemoClassObject_one()
        {
           // Name_not_to_be_set = "This is DemoClassObjectmethod";
            ID = 100;
            a = 100000;
            str = "disha";
            Name = "Singh";
            //Member function of class "Class_Object"
            Console.WriteLine("DemoClassObject class 1");

        }
        public void DemoClassObject_two()
        {
            Name = "This is DemoClassObjectmethod2";
            ID = 100;
            str = "method2";
            a = 200000;

            //Member function of class "Class_Object"
            Console.WriteLine("DemoClassObject class 2");

        }
    }
}
