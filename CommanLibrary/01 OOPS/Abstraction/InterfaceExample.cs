using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLibrary._01_OOPs.Abstraction
{
    public class InterfaceExample
    {
        public interface IDemo
        {
            void Print(string str);
            void Show(string str);
        }

        public class Demo : IDemo
        {
            public void Print(string str)
            {
                Console.WriteLine(str);
            }

            //Explicit --->should not be decorated with any access modifier
            //don't use public--->error
               void IDemo.Show(string str) 
            {
                Console.WriteLine(str); 
            }
        }
    }
}
