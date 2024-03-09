using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommanLibrary._0_CSharp_Basics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace CommonLIbrary.CSharp_Basics

    {
        public class Operator
        {

            public void DemoArray()
            {
                int[] arr = { 2, 4, 7, 8, 90, 1, 3, 78, 56 };
                Console.WriteLine("------------------Sort------------------");
                Array.Sort(arr);
                PrintArray(arr);
                Console.WriteLine("-----------------Reverse-------------");
                Array.Reverse(arr);
                PrintArray(arr);
                Console.WriteLine("------------------------String to Charater array-------------------");
                string s1 = "hello world";
                char[] ch = s1.ToCharArray();
                foreach (char c in ch)
                    Console.WriteLine(c);
            }

            public void PrintArray(int[] a)
            {
                foreach (int i in a)
                {
                    Console.WriteLine(i);
                }
            }
            public void DemoOperator()
            {
                int n1 = 12;
                int n2 = 14;
                int n3 = n1 + n2;
                Console.WriteLine("Addition: " + n3);

                string str1 = "sebastian ";
                string str2 = "knight";
                string str3 = str1 + str2;
                Console.WriteLine(str3);

                int a = 10;
                int b = 10;
                int c = 20;
                int d = 30;
                int e = 20;
                int f = 20;
                int g = 20;

                int result = a ^ b ^ c ^ d ^ e ^ f ^ g;
                Console.WriteLine(result);


                for (int i = 100; i > 0; i--)
                {
                    bool divBy3 = i % 3 == 0;
                    bool divBy5 = i % 5 == 0;
                    if (divBy3 && divBy5)
                        Console.WriteLine("AB");
                    else if (divBy3)
                        Console.WriteLine("A");
                    else if (divBy5)
                        Console.WriteLine("B");
                    else
                        Console.WriteLine(i);

                }
            }


            public void DemoOptionalParameter(int a, int b = 5, int c = 15)
            {
                Console.WriteLine(a + b + c);
            }

            public void DemoOptionalParameter(string first, string last = "Knight")
            {
                Console.WriteLine(first + " " + last);
            }



        }
    }

}
