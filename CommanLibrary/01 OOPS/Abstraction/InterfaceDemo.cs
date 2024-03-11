using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLibrary._01_OOPs.Abstraction
{
    
        //relationship with classes ---> association, composition and aggregation
        // 
        #region InterfaceBasics

        //pure abstract class - all methods are abstract in nature(only signature and no body)
        //can't create instance of the interface
        //all methods has to be implemented in the child class.(C# 11 or .NET 6 onwards you can create default function)
        //should not use public,private,protectedin the methods which are inside an interface(This statement is true till C# 8)
        //interface help us to achieve multiple inheritance    

        //interface can be internal and public not protected, private
        public interface ITest1 //only signature
        {
        //public,protected-->accessible
        //private-->error

        //ITest1();//cannot create a constructor in a interface
        void Show(string str);

        void Print(string str);
        }
    //default methods are supportd in C# 8.o or greater
    //void DefualtMethod()
    //{
    //    Console.WriteLine("hello");
    //}

    public interface ITest2 //only signature
    {
        //public,protected-->accessible
        //private-->error
        void Show(string str);

        void Print(string str);

        void Delete(int id);
    }

    public class ParentTest1
    {
        public int id;
        public void Method()
        {
            Console.WriteLine("in ParentTest1");
        }
    }

    public class ParentTest2
    {
        public void Method()
        {

        }
    }

    //multiple inhertance is not allowed in c# that is why we can't inherit ParentClass2 in TestClass
    //int other words,class can't have multiple pARENT CLASS, but can inherit multiple interface
    //public class Test : ParentTest1,ParentTest2,ITest1, ITest2---error
    public class Test:ParentTest1,ITest1,ITest2
    {
        #region These Mathod are considered to be new method of Test class cause They do not match the interface mathod

        //public void Show()
        //{
        //    Console.WriteLine("");
        //}
        //public void Print()
        //{
        //    Console.WriteLine("");
        //}
        #endregion
        public void Show(string str) 
        { 
        Console.WriteLine(str); 
        }
        public void Print(string str )
        {
            Console.WriteLine(str);
        }
        public void Delete(int id)
        {
            Console.WriteLine($"id deleted {id}");
        }
    }
        #endregion

        #region ImplicitCalling

        #endregion
    }

