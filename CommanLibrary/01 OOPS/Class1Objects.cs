using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommanLibrary._01_OOPS
{
    
        public class Class_Object2
        {

            public Class_Object2()
            {
                Console.WriteLine("Default constructor is called");
                //contructor--->shoul be same as class name
                //default constructor(ctor)----cause it has no parameter
                //this will always run when a new instance of this class or any child class is created

            }
            static Class_Object2()
            {
                Console.WriteLine("static constructor is called");
                //static ctor will not have any access modifier
                //static ctor will only be called once when the first object of that class iscreated
                //stattic ctor will always be called first whwen instance is created, even befire default ctor
                //static ctor will be calledby the CLR--->common language runtime, when the first instance of the class is created
            }
            public Class_Object2(int a)
            {
                Console.WriteLine("Parameterized 1 constructor is called");
                //parameterized constructor,
            }

            public Class_Object2(string str)
            {
                Console.WriteLine("Parameterized 2 constructor is called");
                //parameterized constructor,
            }
            public Class_Object2(int a, string str)
            {
                Console.WriteLine("Parameterized 3 constructor is called");
                //parameterized constructor,
            }
            public bool IsActive { get; set; }
            public int ID { get; set; }

            public string Name { get; set; }
            public string NameNotSet { get; }

            //global varibale
            public int a = 987;
            public string str = "Hello";

            int private_va = 25000;
            //all of the below variable are different from each other and hold value in different memory location
            int value = 10;
            int VALUE = 30;
            int Value = 50;
            int vaLUE = 60;

            public void Demo1()
            {
                Console.WriteLine(private_va);
                private_va = 120000;
                Console.WriteLine(private_va);
                a = 123;
                str = "he1lllooooo";
                Name = "Sophia";
                ID = 101;
                Console.WriteLine("Demo1 is called");
                //member function
            }
            public void Demo2()
            {
                private_va = 889000;
                Console.WriteLine(private_va);
                a = 666;
                str = "new hellllllooooo";
                Name = "Morana";
                ID = 301;
                Console.WriteLine("Demo2 is called");
                //member function
            }
            //Destructor:-
            //CLR will call the garbage collector and the garbage collector will call the destructor
            //we should never write/create a destructor in the class 
            //~Class_Object() {
            //}





        }
    }




