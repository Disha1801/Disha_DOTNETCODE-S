using CommanLibrary._0_CSharp_Basics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommanLibrary._01_OOPS.Abstraction
{
    public abstract  class AbstractClass
    {
        //abstract class cannot be instantiated which means we cant allocate memory to it 
        //but abstract class can still have a constructor
        //means object cannot be created
        //abstract class can have abstract as well as non abstact method
        //abstract class method has to be inherited in other class
        //if we will prefixx any class with sealed keyword then we cant inherit that class

        //Static keyword is used to create object but w.r.t Comman Language Runtime
        //jo bhi comman functions hame chaiye usko abstract kardo fir inherit kardo jahan jahan use krna hai 
        public AbstractClass()
        {
            Console.WriteLine("Abstract class constructor");
        }
        public abstract  string Name { get;  }
        public abstract string ShowMessage(string msg);
        //only declaration and no body
        //non-abstract method
        //IMP QN:-
        //can we create constructor of abstract class?
        //=>Constructor of abstract class  will be called by child classobject  as in inheritance child class goes to its constructor
        //and after that it goes to parent class constructor ,so this is how we can call constructor of parent class

        //The abstract methods of abstract class has to be implemented in the child class




        public string NonAbstractMethod()
        {
            return "Hello!";
        }

        public   class Anonabstractclass:AbstractClass
        {
            public Anonabstractclass()
            {
                Console.WriteLine(" Const of  Anonabstractclass");
            }



            public override string Name { get{ return " ..."; }}
            public override  string ShowMessage(string msg )
            {
                return "Msg";
            }

        }



        public void calculate()
        {

        }
    }
}
